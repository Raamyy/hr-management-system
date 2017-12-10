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
        static string id, name, depId, hireDate, depName;
        private static char[] chId = new char[5];
        private static char[] chName = new char[20];
        private static char[] chDepId = new char[5];
        private static char[] chHireDate = new char[10];
        FileOperation()
        {

        }
        void read()
        {

        }

        public static bool writeEmployee(Employee emp, int offset)
        {
            id = emp.Id.ToString(); name = emp.Name; depId = emp.DepId.ToString();
            hireDate = emp.HireDate.ToString();

            if (id.Length <= 5 && name.Length <= 20 && hireDate.Length <= 10 && depId.Length <= 5)
            {
                FileStream Fs = new FileStream("Employees.txt", FileMode.Append, FileAccess.Write);
                StreamWriter st = new StreamWriter(Fs);
                st.Flush();
                if (offset < Fs.Length)
                    st.BaseStream.Seek(offset, SeekOrigin.Begin);
                id.CopyTo(0, chId, 0, 5);
                name.CopyTo(0, chName, 0, 20);
                depId.CopyTo(0, chDepId, 0, 5);
                hireDate.CopyTo(0, chHireDate, 0, 10);

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
            depId = dep.
            if(depId.Length <= 5)
            {
                return true;
            }
            return false;
        }
    }
}
