using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class FileOperation
{
    static string id, name, depId, hireDate, depName;
    private static char[] chId;
    private static char[] chName;
    private static char[] chDepId;
    private static char[] chHireDate;
    private static char[] chDepName;
    FileOperation()
    {

    }



    public static List<Employee> read() //returns list of all employees in the file.
    {
        if (File.Exists("employees.txt"))
        {

            FileStream FS = new FileStream("Employees.txt", FileMode.Open);
            StreamReader sr = new StreamReader(FS);
            List<Employee> Employees = new List<Employee>();

            while (sr.Peek() != -1)
            {
                Employee temp = new Employee();
                char[] id = new char[5];
                char[] name = new char[20];
                char[] date = new char[10];
                char[] depID = new char[5];

                sr.Read(id, 0, 5);
                sr.Read(name, 0, 20);
                sr.Read(date, 0, 10);
                sr.Read(depID, 0, 5);

                string Id = new string(id);
                string Name = new string(name);
                string Date = new string(date);
                string DepId = new string(depID);

                string[] DateInfo = Date.Split('/');
                DateTime HireDate = new DateTime(int.Parse(DateInfo[2]), int.Parse(DateInfo[1]), int.Parse(DateInfo[0]));

                temp.Id = int.Parse(Id);
                temp.Name = Name;
                temp.HireDate = HireDate;
                temp.DepId = int.Parse(DepId);

                Employees.Add(temp);
            }

            sr.Close();
            return Employees;
        }

        return null;
    }


    public static List<Employee> GetByDepId(int DepId) //returns list of employees of dep depId
    {
        List<Employee> AllEmployees = read();
        List<Employee> Emp = new List<Employee>();
        for (int i = 0; i < AllEmployees.Count; i++)
        {
            if (AllEmployees[i].DepId == DepId)
                Emp.Add(AllEmployees[i]);
        }
        return Emp;
    }

    public static List<Employee> GetByEmpId(int Id) //returns list of employees of dep depId
    {
        List<Employee> AllEmployees = read();
        List<Employee> Emp = new List<Employee>();
        for (int i = 0; i < AllEmployees.Count; i++)
        {
            if (AllEmployees[i].Id == Id)
                Emp.Add(AllEmployees[i]);
        }
        return Emp;
    }

    public static bool writeEmployee(Employee emp, long offset)
    {
        id = emp.Id.ToString(); name = emp.Name; depId = emp.DepId.ToString();
        hireDate = emp.HireDate.ToShortDateString();

        if (id.Length <= 5 && name.Length <= 20 && hireDate.Length <= 10 && depId.Length <= 5)
        {
            FileStream Fs = new FileStream("Employees.txt", FileMode.Open, FileAccess.Write);
            StreamWriter st = new StreamWriter(Fs);
            st.Flush();
            st.BaseStream.Seek(offset, SeekOrigin.Begin);

            chId = new char[5]; chName = new char[20]; chHireDate = new char[10];
            chDepId = new char[5];

            id.CopyTo(0, chId, 0, id.Length);
            name.CopyTo(0, chName, 0, name.Length);
            depId.CopyTo(0, chDepId, 0, depId.Length);
            hireDate.CopyTo(0, chHireDate, 0, hireDate.Length);

            st.Write(chId, 0, 5);
            st.Write(chName, 0, 20);
            st.Write(chHireDate, 0, 10);
            st.Write(chDepId, 0, 5);
            st.Close();
            return true;
        }
        return false;
    }

    public static bool updateEmployee(int uId, Employee emp)
    {
        FileStream fs = new FileStream("Employees.txt", FileMode.Open, FileAccess.ReadWrite);
        StreamReader sr = new StreamReader(fs);
        int offset = 0;
        while (true)
        {
            if (offset * 40 > fs.Length)
            {
                return false;
            }
            sr.BaseStream.Flush();
            sr.BaseStream.Seek(offset * 40, SeekOrigin.Begin);
            sr.Read(chId, 0, 5);
            id = chId.ToString();
            if (int.Parse(id) == uId)
            {
                break;
            }
            offset++;
        }
        writeEmployee(emp, offset);
        return true;
    }

    public static bool writeDep(Departement dep)
    {
        depId = dep.Id.ToString();
        depName = dep.Name;
        if (depId.Length <= 5 && depName.Length <= 20)
        {
            FileStream Fs = new FileStream("Department.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Fs);
            chDepId = new char[5]; chDepName = new char[20];
            depId.CopyTo(0, chDepId, 0, depId.Length);
            depName.CopyTo(0, chDepName, 0, depName.Length);
            sw.Write(depId, 0, 5);
            sw.Write(depName, 0, 20);
            return true;
        }
        return false;
    }

    public static long getOffset()
    {
        FileStream Fs = new FileStream("Employees.txt", FileMode.OpenOrCreate);
        long length = Fs.Length;
        Fs.Close();
        return length;
    }
}
