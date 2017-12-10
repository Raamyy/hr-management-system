using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
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
            return depId;
        }
        set
        {
            depId = value;
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