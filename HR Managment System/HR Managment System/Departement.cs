using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Departement
{
    private int id;
    private string name;

    public int Id
    {
        get { return id; }
        set { id = value; }
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
}
