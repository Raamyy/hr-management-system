using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HR_Managment_System
{
    class FileOperation
    {
        FileOperation()
        {

        }



        List<Employee> read() //returns list of all employees in the file.
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


        List<Employee> GetByDepId(int DepId) //returns list of employees of dep depId
        {
            List<Employee> AllEmployees = read();
            List<Employee> Emp = new List<Employee>();
            for(int i=0; i<AllEmployees.Count; i++)
            {
                if (AllEmployees[i].DepId == DepId)
                    Emp.Add(AllEmployees[i]);
            }
            return Emp;
        }

        List<Employee> GetByEmpId(int Id) //returns list of employees of dep depId
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

        public static bool write(Employee emp)
        {
            FileStream Fs = new FileStream("Employee.txt", FileMode.Append, FileAccess.Write);
            StreamWriter st = new StreamWriter(Fs);
            string id = emp.Id.ToString(), name = emp.Name, DepId = emp.DepId.ToString(),
                hireDate = emp.HireDate.ToString();
            if(id.Length <= 5 && name.Length <= 20 &&  hireDate.Length <= 10 && DepId.Length <= 5)
            {

                return true;
            }
            return false;
        }
    }
}
