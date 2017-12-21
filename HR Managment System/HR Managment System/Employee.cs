using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee : IComparable
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
    public int CompareTo(object obj)
    {
        Employee other = obj as Employee;
        if(id == other.Id && name == other.Name && depId == other.DepId)
        {
            return 0;
        }
        else if(id > other.Id)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
    static public bool operator==(Employee first, object second)
    {
        if (second == null || second.GetType() != typeof(Employee))
        {
            return false;
        }
        Employee Second = second as Employee;
        if (first.Id == Second.Id && first.Name == Second.Name && first.DepId == Second.DepId)
        {
            return true;
        }
        return false;
    }
    static public bool operator!=(Employee first, object second)
    {
        if(second == null || second.GetType() != typeof(Employee))
        {
            return true;
        }
        Employee Second = second as Employee;
        if (first.Id == Second.Id && first.Name == Second.Name && first.DepId == Second.DepId)
        {
            return false;
        }
        return true;
    }
    public override bool Equals(object obj)
    {
        if(obj.GetType() == typeof(Employee))
        {
            Employee e = obj as Employee;
            return this == e;
        }
        return false;
    }
}