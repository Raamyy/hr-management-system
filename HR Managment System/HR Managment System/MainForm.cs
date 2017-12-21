using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }
    private void DisplayButton_Click(object sender, EventArgs e)
    {
        DisplayPanel.Visible = true;
        LandingPanel.Visible = false;
    }
    private void DisplayBackButton_Click(object sender, EventArgs e)
    {
        LandingPanel.Visible = true;
        DisplayPanel.Visible = false;
        DisplayDataShow.Rows.Clear();
    }
    Employee ActiveEmployee;
    int ActiveUID;
    private void SearchPanelButton_Click(object sender, EventArgs e)
    {
        ActiveEmployee = FileOperation.GetByEmpId(int.Parse(SearchText.Text))[0];
        if (ActiveEmployee != null)
        {
            ActiveUID = int.Parse(SearchText.Text);
            SearchNameButton.Enabled = true;
            SearchIDButton.Enabled = true;
            SearchHiringDateButton.Enabled = true;
            SearchDepartmentNoButton.Enabled = true;
            SearchValueName.Text = ActiveEmployee.Name;
            SearchValueID.Text = ActiveEmployee.Id.ToString();
            SearchValueHirinDate.Text = ActiveEmployee.HireDate.ToShortDateString();
            SearchValueDepartmentNo.Text = ActiveEmployee.DepId.ToString();
        }
        else
        {
            SearchNameButton.Enabled = false;
            SearchIDButton.Enabled = false;
            SearchHiringDateButton.Enabled = false;
            SearchDepartmentNoButton.Enabled = false;
            SearchValueName.Text = "--------";
            SearchValueID.Text = "--------";
            SearchValueHirinDate.Text = "--------";
            SearchValueDepartmentNo.Text = "--------";
            //buttons need to be reset....
        }
    }
    private void SearchNameButton_Click(object sender, EventArgs e)
    {
        if (!SearchEditableName.Visible)
        {
            SearchEditableName.Text = SearchValueName.Text;
            SearchEditableName.Visible = true;
            SearchNameButton.Text = "Done";
        }
        else
        {
            SearchEditableName.Visible = false;
            SearchNameButton.Text = "Edit";
            ActiveEmployee.Name = SearchEditableName.Text;
            FileOperation.updateEmployee(ActiveUID, ActiveEmployee);
            SearchValueName.Text = SearchEditableName.Text;
        }
    }
    private void SearchIDButton_Click(object sender, EventArgs e)
    {
        if (!SearchEditableID.Visible)
        {
            SearchEditableID.Text = SearchValueID.Text;
            SearchEditableID.Visible = true;
            SearchIDButton.Text = "Done";
        }
        else
        {
            SearchEditableID.Visible = false;
            SearchIDButton.Text = "Edit";
            ActiveEmployee.Id = int.Parse(SearchEditableID.Text);
            FileOperation.updateEmployee(ActiveUID, ActiveEmployee);
            ActiveUID = int.Parse(SearchEditableID.Text);
            SearchValueID.Text = SearchEditableID.Text;
        }
    }
    private void SearchHiringDateButton_Click(object sender, EventArgs e)
    {
        if (!SearchEditableHiringDate.Visible)
        {
            SearchEditableHiringDate.Value = ActiveEmployee.HireDate;
            SearchEditableHiringDate.Visible = true;
            SearchHiringDateButton.Text = "Done";
        }
        else
        {
            SearchEditableHiringDate.Visible = false;
            SearchHiringDateButton.Text = "Edit";
            ActiveEmployee.HireDate = SearchEditableHiringDate.Value;
            FileOperation.updateEmployee(ActiveUID, ActiveEmployee);
            SearchValueHirinDate.Text = SearchEditableHiringDate.Text;
        }
    }
    private void SearchDepartmentNoButton_Click(object sender, EventArgs e)
    {
        if (!SearchEditableDepartmentNo.Visible)
        {
            SearchEditableDepartmentNo.Text = SearchValueDepartmentNo.Text;
            SearchEditableDepartmentNo.Visible = true;
            SearchDepartmentNoButton.Text = "Done";
        }
        else
        {
            SearchEditableDepartmentNo.Visible = false;
            SearchDepartmentNoButton.Text = "Edit";
            ActiveEmployee.DepId = int.Parse(SearchEditableDepartmentNo.Text);
            FileOperation.updateEmployee(ActiveUID, ActiveEmployee);
            SearchValueDepartmentNo.Text = SearchEditableDepartmentNo.Text;
        }
    }
    private void SearchBack_Click(object sender, EventArgs e)
    {
        LandingPanel.Visible = true;
        SearchPanel.Visible = false;
    }
    private void SearchButton_Click(object sender, EventArgs e)
    {
        SearchPanel.Visible = true;
        LandingPanel.Visible = false;
        SearchNameButton.Enabled = false;
        SearchIDButton.Enabled = false;
        SearchHiringDateButton.Enabled = false;
        SearchDepartmentNoButton.Enabled = false;
        SearchValueName.Text = "--------";
        SearchValueID.Text = "--------";
        SearchValueHirinDate.Text = "--------";
        SearchValueDepartmentNo.Text = "--------";
        //buttons need to be reset....
    }

    private void WriteButton_Click(object sender, EventArgs e)
    {
        Adding.Show();
        LandingPanel.Hide();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void EmployeeSubmitButton_Click(object sender, EventArgs e)
    {
        EmployeeNameError.Text = "";
        EmployeeDepIdError.Text = "";
        EmployeeIdError.Text = "";
        Submit_Result.Text = "";
        Employee temp = new Employee();
        temp.Id = int.Parse(EmployeeId.Text);
        temp.Name = EmployeeName.Text;
        temp.DepId = int.Parse(EmployeeDepId.Text);
        temp.HireDate = EmployeeHiryDate.Value;

        if (temp.Name.Length > 20 || temp.Name.Length == 0)
            EmployeeNameError.Text = "Invalid Input";
        if (EmployeeId.Text.Length > 5 || EmployeeId.Text.Length == 0)
            EmployeeIdError.Text = "Invalid Input";
        if (EmployeeDepId.Text.Length > 5 || EmployeeDepId.Text.Length == 0)
            EmployeeDepIdError.Text = "Invalid Input";
        FileOperation.FileErrorType res = FileOperation.WriteEmployee(temp, FileOperation.getOffset());
        if (res == FileOperation.FileErrorType.NoError)
        {
            Submit_Result.Text = "Employee was addded succesfully!";
        }
        else if(res == FileOperation.FileErrorType.InvalidDepartmentID)
        {
            EmployeeDepIdError.Text = "Department ID non-existant";
        }
        else if(res == FileOperation.FileErrorType.InvalidEmployeeID)
        {
            EmployeeIdError.Text = "Employee ID used before";
        }
    }
    private void label5_Click(object sender, EventArgs e)
    {

    }
    private void FilterHandler(object sender, EventArgs e)
    {
        SortedSet<Employee> set = new SortedSet<Employee>();
        DisplayDataShow.Rows.Clear();
        int n;
        if (DisplayDepartmentInput.Text == "" && DisplayIDInput.Text == "" && DisplayNameInput.Text == "" && DisplayDepartmentNoInput.Text == "")
        {
            foreach (Employee emp in FileOperation.read())
            {
                set.Add(emp);
            }
        }
        if (int.TryParse(DisplayDepartmentNoInput.Text, out n))
        {
            foreach (Employee emp in FileOperation.GetByDepId(n))
            {
                set.Add(emp);
            }
        }
        if (int.TryParse(DisplayIDInput.Text, out n))
        {
            foreach (Employee emp in FileOperation.GetByEmpId(n))
            {
                set.Add(emp);
            }
        }
        foreach (Employee emp in FileOperation.GetByDepName(DisplayDepartmentInput.Text))
        {
            set.Add(emp);
        }
        foreach (Employee emp in FileOperation.GetByEmpName(DisplayNameInput.Text))
        {
            set.Add(emp);
        }
        foreach (Employee emp in set)
        {
            DisplayDataShow.Rows.Add(emp.Id.ToString(), emp.Name, emp.HireDate.ToShortDateString(), "TODO", emp.DepId);
        }
    }
    private void DisplayPanel_VisibleChanged(object sender, EventArgs e)
    {
        if (DisplayPanel.Visible)
        {
            FilterHandler(sender, e);
        }
        else
        {
            DisplayDataShow.Rows.Clear();
            DisplayNameInput.Text = "";
            DisplayIDInput.Text = "";
            DisplayDepartmentInput.Text = "";
            DisplayDepartmentNoInput.Text = "";
        }
    }
    private void EmployeeHiringDate_TextChanged(object sender, EventArgs e)
    {

    }

    private void label5_Click_1(object sender, EventArgs e)
    {

    }

    private void SearchEditableHiringDate_ValueChanged(object sender, EventArgs e)
    {

    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        WritingPanel.Hide();
        LandingPanel.Show();
    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void submitdept_Click(object sender, EventArgs e)
    {
        if (deptid.Text.Length > 5 || deptname.Text.Length > 20)
        {
            MessageBox.Show("You exceeded length limits!!");
            return;
        }
        else if (deptid.Text.Length == 0 || deptname.Text.Length == 0)
        {
            MessageBox.Show("You can't leave field empty!!");
            return;
        }

        //na2es hena case law el id aw el name mawgoden
        Departement newdep = new Departement();
        newdep.Id = int.Parse(deptid.Text);
        newdep.Name = deptname.Text;
        FileOperation.writeDep(newdep);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        AddingDept.Show();
        Adding.Hide();
    }

    private void addempbut_Click(object sender, EventArgs e)
    {
        WritingPanel.Show();
        Adding.Hide();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        Adding.Show();
        AddingDept.Hide();
    }

    private void backbt2_Click(object sender, EventArgs e)
    {
        LandingPanel.Show();
        Adding.Hide();
    }

    private void WritingPanel_VisibleChanged(object sender, EventArgs e)
    {
        EmployeeNameError.Text = "";
        EmployeeDepIdError.Text = "";
        EmployeeIdError.Text = "";
        Submit_Result.Text = "";
    }
}
