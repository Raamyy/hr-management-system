using System;
using System.Windows.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }
    private void PanelDisplayButton_Click(object sender, EventArgs e)
    {
        DisplayDataShow.Rows.Add(100.ToString(), "7sen", "1001", "9910");
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
    }
    private void SearchPanelButton_Click(object sender, EventArgs e)
    {
        SearchNameButton.Enabled = true;
        SearchIDButton.Enabled = true;
        SearchHiringDateButton.Enabled = true;
        SearchDepartmentNoButton.Enabled = true;
        //PerformSearch
        SearchValueName.Text = "7sen";
        SearchValueID.Text = "255";
        SearchValueHirinDate.Text = "1990";
        SearchValueDepartmentNo.Text = "99904";
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
            //Editing Procedure
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
            //Editing Procedure
            SearchValueID.Text = SearchEditableID.Text;
        }
    }
    private void SearchHiringDateButton_Click(object sender, EventArgs e)
    {
        if (!SearchEditableHiringDate.Visible)
        {
            SearchEditableHiringDate.Text = SearchValueHirinDate.Text;
            SearchEditableHiringDate.Visible = true;
            SearchHiringDateButton.Text = "Done";
        }
        else
        {
            SearchEditableHiringDate.Visible = false;
            SearchHiringDateButton.Text = "Edit";
            //Editing Procedure
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
            //Editing Procedure
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
    }
}
