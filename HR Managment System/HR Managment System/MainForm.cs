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
        try
        {
            ActiveEmployee = FileOperation.GetByEmpId(int.Parse(SearchText.Text))[0];
        }
        catch
        {
            MessageBox.Show("ID Non Existant");
            return;
        }
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
            if(SearchEditableName.Text.Length > 20 || SearchEditableName.Text.Length == 0)
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            SearchEditableName.Visible = false;
            SearchNameButton.Text = "Edit";
            ActiveEmployee.Name = SearchEditableName.Text;
            FileOperation.FileErrorType res = FileOperation.updateEmployee(ActiveUID, ActiveEmployee);
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
            if (SearchEditableID.Text.Length > 5 || SearchEditableID.Text.Length == 0)
            {
                MessageBox.Show("Invalid ID");
                return;
            }
            SearchEditableID.Visible = false;
            SearchIDButton.Text = "Edit";
            ActiveEmployee.Id = int.Parse(SearchEditableID.Text);
            if (FileOperation.updateEmployee(ActiveUID, ActiveEmployee) == FileOperation.FileErrorType.InvalidEmployeeID)
            {
                MessageBox.Show("ID Already Used");
            }
            else
            {
                FileOperation.UpdateEmpDic(ActiveUID, ActiveEmployee.Id);
                ActiveUID = int.Parse(SearchEditableID.Text);
                SearchValueID.Text = SearchEditableID.Text;
            }
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
            if (SearchEditableDepartmentNo.Text.Length > 5 || SearchEditableDepartmentNo.Text.Length == 0)
            {
                MessageBox.Show("Invalid Department Number");
                return;
            }
            SearchEditableDepartmentNo.Visible = false;
            SearchDepartmentNoButton.Text = "Edit";
            ActiveEmployee.DepId = int.Parse(SearchEditableDepartmentNo.Text);
            FileOperation.FileErrorType res = FileOperation.updateEmployee(ActiveUID, ActiveEmployee);
            if (res == FileOperation.FileErrorType.InvalidDepartmentID)
            {
                MessageBox.Show("Invalid Department");
            }
            else
            {
                SearchValueDepartmentNo.Text = SearchEditableDepartmentNo.Text;
            }
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
        //Clearing existing error messages
        EmployeeNameError.Text = "";
        EmployeeDepIdError.Text = "";
        EmployeeIdError.Text = "";
        Submit_Result.Text = "";

        //Displaying error messages if input is invalid
        bool InvalidInput = false;
        if (EmployeeName.Text.Length > 20 || EmployeeName.Text.Length == 0)
        {
            EmployeeNameError.Text = "Name's length should be between 1 and 20";
            InvalidInput = true;
        }
        if (EmployeeId.Text.Length > 5 || EmployeeId.Text.Length == 0)
        {
            EmployeeIdError.Text = "ID's length should be between 1 and 5";
            InvalidInput = true;
        }
        if (EmployeeDepId.Text.Length > 5 || EmployeeDepId.Text.Length == 0)
        {
            EmployeeDepIdError.Text = "ID's length should be between 1 and 5";
            InvalidInput = true;
        }
        if (InvalidInput == true)
            return;

        //Creating Employee object with the entered data
        Employee temp = new Employee();
        temp.Id = int.Parse(EmployeeId.Text);
        temp.Name = EmployeeName.Text;
        temp.DepId = int.Parse(EmployeeDepId.Text);
        temp.HireDate = EmployeeHiryDate.Value;

        //Sending entered data to FileOperation class
        FileOperation.FileErrorType res = FileOperation.WriteEmployee(temp, FileOperation.getOffset(), true);

        //Prompting the user with the submission result
        if (res == FileOperation.FileErrorType.NoError)
        {
            Submit_Result.Text = "Employee was addded succesfully!";

            //Clearing input fields
            EmployeeId.Text = "";
            EmployeeName.Text = "";
            EmployeeDepId.Text = "";
        }
        else if (res == FileOperation.FileErrorType.InvalidDepartmentID)
        {
            EmployeeDepIdError.Text = "Department ID doesn't exist";
        }
        else if (res == FileOperation.FileErrorType.InvalidEmployeeID)
        {
            EmployeeIdError.Text = "Employee ID is used before";
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
            DisplayDataShow.Rows.Add(emp.Id.ToString(), emp.Name, emp.HireDate.ToShortDateString(), FileOperation.GetDepartmentName(emp.DepId), emp.DepId);
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

        //Clearing input fields
        EmployeeId.Text = "";
        EmployeeName.Text = "";
        EmployeeDepId.Text = "";
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
        if (FileOperation.writeDep(newdep))
        {
            MessageBox.Show("Department Added Sucessfully");
        }
        else
        {
            MessageBox.Show("Department already exist");
        }
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
