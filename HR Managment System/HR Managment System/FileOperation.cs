using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class FileOperation
{
    public enum FileErrorType { InvalidDepartmentID, InvalidEmployeeID, FieldOutOfRange, FieldNonExistant, NoError }; //Enum to send the type of error
    static string id, name, depId, hireDate, depName;
    private static Dictionary<int, bool> IsUsedEmployeeID = new Dictionary<int, bool>(); // A map to know if employee ID used before or not
    private static Dictionary<int, bool> IsUsedDepartmentID = new Dictionary<int, bool>(); // A map to know if department ID used before or not
    private static char[] chId;
    private static char[] chName;
    private static char[] chDepId;
    private static char[] chHireDate;
    private static char[] chDepName;
    FileOperation()
    {

    }

    public static string GetDepartmentName(int id)
    {
        List<Departement> Departments = Read_Dep();
        foreach (Departement Dep in Departments)
        {
            if (Dep.Id.Equals(id))
                return Dep.Name;
        }
        return "";
    }
    public static List<Employee> read() //returns list of all employees in the file.
    {
        if (File.Exists("Employees.txt"))
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
                IsUsedEmployeeID[temp.Id] = true; // Updating Employees IDs map
            }

            sr.Close();
            return Employees;
        }

        return new List<Employee>();
    }
    public static List<Departement> Read_Dep() //returns list of all departments in the file.
    {
        if (File.Exists("Department.txt"))
        {

            FileStream FS = new FileStream("Department.txt", FileMode.Open);
            StreamReader sr = new StreamReader(FS);
            List<Departement> Departments = new List<Departement>();

            while (sr.Peek() != -1)
            {
                Departement temp = new Departement();
                char[] id = new char[5];
                char[] name = new char[20];
                sr.Read(id, 0, 5);
                sr.Read(name, 0, 20);
                string Id = new string(id);
                string Name = new string(name);
                temp.Id = int.Parse(Id);

                temp.Name = Name;
                Departments.Add(temp);
                IsUsedDepartmentID[temp.Id] = true; // Updating Departments IDs map
            }
            sr.Close();
            return Departments;
        }
        return null;
    }
    public static List<Employee> GetByDepId(int DepId) //returns list of employees from a specific department ID
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
    public static List<Employee> GetByDepName(string DepName) //returns list of employees from a specific department Name
    {
        List<Employee> AllEmployees = read();
        List<Departement> AllDepartements = Read_Dep();
        List<Employee> Emp = new List<Employee>();
        if (AllDepartements == null) return Emp;
        Dictionary<int, string> GetDep = new Dictionary<int, string>();

        for (int i = 0; i < AllDepartements.Count; i++)
        {
            GetDep[AllDepartements[i].Id] = AllDepartements[i].Name;
        }
        for (int i = 0; i < AllEmployees.Count; i++)
        {
            if (GetDep[AllEmployees[i].DepId].Trim('\0', ' ') == DepName)
            {
                Emp.Add(AllEmployees[i]);
            }
        }
        return Emp;
    }
    public static List<Employee> GetByEmpName(string EmpName) //returns list of employees with a specific name
    {
        List<Employee> AllEmployees = read();
        List<Employee> Emp = new List<Employee>();
        if (EmpName == "") return Emp;
        for (int i = 0; i < AllEmployees.Count; i++)
        {
            if (AllEmployees[i].Name.Trim('\0', ' ') == EmpName.Trim('\0', ' '))
            {
                Emp.Add(AllEmployees[i]);
            }
        }
        return Emp;
    }
    public static List<Employee> GetByEmpId(int Id) //returns list of employee of the given id
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
    public static FileErrorType WriteEmployee(Employee emp, long offset, bool CheckID)
    {
        if (IsUsedDepartmentID.ContainsKey(emp.DepId) == false)
        {
            return FileErrorType.InvalidDepartmentID;
        }
        if (CheckID && IsUsedEmployeeID.ContainsKey(emp.Id) == true)
        {
            return FileErrorType.InvalidEmployeeID;
        }
        id = emp.Id.ToString(); name = emp.Name; depId = emp.DepId.ToString();
        hireDate = emp.HireDate.Day + "/" + emp.HireDate.Month + "/" + emp.HireDate.Year;
        if (id.Length > 5 && name.Length > 20 && hireDate.Length > 10 && depId.Length > 5)
        {
            return FileErrorType.FieldOutOfRange;
        }
        FileStream Fs = new FileStream("Employees.txt", FileMode.Open, FileAccess.Write);
        StreamWriter st = new StreamWriter(Fs);
        st.Flush();
        st.BaseStream.Seek(offset, SeekOrigin.Begin);

        chId = new char[5]; chName = new char[20]; chHireDate = new char[10];
        chDepId = new char[5];

        IsUsedEmployeeID[emp.Id] = true;

        id.CopyTo(0, chId, 0, id.Length);
        name.CopyTo(0, chName, 0, name.Length);
        depId.CopyTo(0, chDepId, 0, depId.Length);
        hireDate.CopyTo(0, chHireDate, 0, hireDate.Length);
        st.Write(chId, 0, 5);
        st.Write(chName, 0, 20);
        st.Write(chHireDate, 0, 10);
        st.Write(chDepId, 0, 5);
        st.Close();
        return FileErrorType.NoError;
    }
    public static FileErrorType updateEmployee(int uId, Employee emp)
    {
        FileStream fs = new FileStream("Employees.txt", FileMode.Open, FileAccess.ReadWrite);
        StreamReader sr = new StreamReader(fs);
        int offset = 0;
        while (true)
        {
            if (offset * 40 >= fs.Length)
            { 
                sr.Close();
                return FileErrorType.FieldNonExistant;
            }
            chId = new char[5];
            sr.DiscardBufferedData();
            sr.BaseStream.Seek(offset * 40, SeekOrigin.Begin);
            sr.Read(chId, 0, 5);
            id = new string(chId);
            if (int.Parse(id) == uId)
            {
                break;
            }
            offset++;
        }
        sr.Close();
        if(emp.Id == uId)
        {
            return WriteEmployee(emp, offset * 40, false);
        }
        else
        {
            return WriteEmployee(emp, offset * 40, true);
        }
    }
    public static void UpdateEmpDic(int PreviousId, int NewId) // Updating dictionary when A new ID is assigned to an employee
    {
        IsUsedEmployeeID[PreviousId] = false;
        IsUsedEmployeeID[NewId] = true;
    }

    public static bool writeDep(Departement dep)
    {
        depId = dep.Id.ToString();
        depName = dep.Name;
        if (depId.Length <= 5 && depName.Length <= 20 && IsUsedDepartmentID.ContainsKey(dep.Id) == false)
        {
            FileStream Fs = new FileStream("Department.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Fs);
            chDepId = new char[5]; chDepName = new char[20];
            depId.CopyTo(0, chDepId, 0, depId.Length);
            depName.CopyTo(0, chDepName, 0, depName.Length);
            sw.Write(chDepId, 0, 5);
            sw.Write(chDepName, 0, 20);
            IsUsedDepartmentID[int.Parse(depId)]= true;  //Updating Departments IDs map
            sw.Close();
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
