using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment_System
{
    class Employee
    {
            private int id;
            private string name;
            private int depId;
            private DateTime hireDate;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int DepId { get => depId; set => depId = value; }
        public DateTime HireDate { get => hireDate; set => hireDate = value; }
    }
}
