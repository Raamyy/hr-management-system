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
        void read()
        {

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
