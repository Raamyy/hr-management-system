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

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int DepId
        {
            get
            {
                return DepId;
            }
            set
            {
                DepId = value;
            }
        }
        public DateTime HireDate
        {
            get
            {
                return hireDate;
            }
            set
            {
                hireDate = value;
            }

        }
    }
}
