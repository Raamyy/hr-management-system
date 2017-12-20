﻿
partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.DisplayButton = new System.Windows.Forms.Button();
        this.SearchButton = new System.Windows.Forms.Button();
        this.WriteButton = new System.Windows.Forms.Button();
        this.LandingPanel = new System.Windows.Forms.Panel();
        this.DisplayPanel = new System.Windows.Forms.Panel();
        this.DisplayBackButton = new System.Windows.Forms.Button();
        this.DisplayDataShow = new System.Windows.Forms.DataGridView();
        this.DataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.DataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.DataHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.DataDepartmenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.PanelDisplayButton = new System.Windows.Forms.Button();
        this.DummyDepartLabel = new System.Windows.Forms.Label();
        this.DisplayDepartmentTextBox = new System.Windows.Forms.TextBox();
        this.SearchPanel = new System.Windows.Forms.Panel();
        this.SearchEditableHiringDate = new System.Windows.Forms.DateTimePicker();
        this.SearchBack = new System.Windows.Forms.Button();
        this.SearchPanelButton = new System.Windows.Forms.Button();
        this.DummySearchLabel = new System.Windows.Forms.Label();
        this.SearchDepartmentNoButton = new System.Windows.Forms.Button();
        this.SearchHiringDateButton = new System.Windows.Forms.Button();
        this.SearchIDButton = new System.Windows.Forms.Button();
        this.SearchNameButton = new System.Windows.Forms.Button();
        this.SearchEditableDepartmentNo = new System.Windows.Forms.TextBox();
        this.SearchEditableID = new System.Windows.Forms.TextBox();
        this.SearchEditableName = new System.Windows.Forms.TextBox();
        this.SearchValueDepartmentNo = new System.Windows.Forms.Label();
        this.SearchValueHirinDate = new System.Windows.Forms.Label();
        this.SearchValueID = new System.Windows.Forms.Label();
        this.SearchValueName = new System.Windows.Forms.Label();
        this.SearchDepartmentNo = new System.Windows.Forms.Label();
        this.SearchHiringDate = new System.Windows.Forms.Label();
        this.SearchIDLabel = new System.Windows.Forms.Label();
        this.SearchLabelName = new System.Windows.Forms.Label();
        this.SearchText = new System.Windows.Forms.TextBox();
        this.WritingPanel = new System.Windows.Forms.Panel();
        this.BackButton = new System.Windows.Forms.Button();
        this.EmployeeHiryDate = new System.Windows.Forms.DateTimePicker();
        this.Submit_Result = new System.Windows.Forms.Label();
        this.EmployeeDepIdError = new System.Windows.Forms.Label();
        this.EmployeeIdError = new System.Windows.Forms.Label();
        this.EmployeeSubmitButton = new System.Windows.Forms.Button();
        this.EmployeeNameError = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.EmployeeDepId = new System.Windows.Forms.TextBox();
        this.EmployeeId = new System.Windows.Forms.TextBox();
        this.Title = new System.Windows.Forms.Label();
        this.EmployeeName = new System.Windows.Forms.TextBox();
        this.LandingPanel.SuspendLayout();
        this.DisplayPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.DisplayDataShow)).BeginInit();
        this.SearchPanel.SuspendLayout();
        this.WritingPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // DisplayButton
        // 
        this.DisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.DisplayButton.Location = new System.Drawing.Point(222, 12);
        this.DisplayButton.Name = "DisplayButton";
        this.DisplayButton.Size = new System.Drawing.Size(268, 137);
        this.DisplayButton.TabIndex = 0;
        this.DisplayButton.Text = "Display";
        this.DisplayButton.UseVisualStyleBackColor = true;
        this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
        // 
        // SearchButton
        // 
        this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.SearchButton.Location = new System.Drawing.Point(222, 155);
        this.SearchButton.Name = "SearchButton";
        this.SearchButton.Size = new System.Drawing.Size(268, 79);
        this.SearchButton.TabIndex = 1;
        this.SearchButton.Text = "Update";
        this.SearchButton.UseVisualStyleBackColor = true;
        this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
        // 
        // WriteButton
        // 
        this.WriteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.WriteButton.Location = new System.Drawing.Point(222, 240);
        this.WriteButton.Name = "WriteButton";
        this.WriteButton.Size = new System.Drawing.Size(268, 50);
        this.WriteButton.TabIndex = 2;
        this.WriteButton.Text = "Write";
        this.WriteButton.UseVisualStyleBackColor = true;
        this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
        // 
        // LandingPanel
        // 
        this.LandingPanel.Controls.Add(this.DisplayButton);
        this.LandingPanel.Controls.Add(this.WriteButton);
        this.LandingPanel.Controls.Add(this.SearchButton);
        this.LandingPanel.Location = new System.Drawing.Point(0, 0);
        this.LandingPanel.Name = "LandingPanel";
        this.LandingPanel.Size = new System.Drawing.Size(710, 319);
        this.LandingPanel.TabIndex = 3;
        // 
        // DisplayPanel
        // 
        this.DisplayPanel.Controls.Add(this.DisplayBackButton);
        this.DisplayPanel.Controls.Add(this.DisplayDataShow);
        this.DisplayPanel.Controls.Add(this.PanelDisplayButton);
        this.DisplayPanel.Controls.Add(this.DummyDepartLabel);
        this.DisplayPanel.Controls.Add(this.DisplayDepartmentTextBox);
        this.DisplayPanel.Location = new System.Drawing.Point(0, 0);
        this.DisplayPanel.Name = "DisplayPanel";
        this.DisplayPanel.Size = new System.Drawing.Size(707, 319);
        this.DisplayPanel.TabIndex = 3;
        this.DisplayPanel.Visible = false;
        // 
        // DisplayBackButton
        // 
        this.DisplayBackButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.DisplayBackButton.Location = new System.Drawing.Point(-1, 296);
        this.DisplayBackButton.Name = "DisplayBackButton";
        this.DisplayBackButton.Size = new System.Drawing.Size(75, 23);
        this.DisplayBackButton.TabIndex = 4;
        this.DisplayBackButton.Text = "Back";
        this.DisplayBackButton.UseVisualStyleBackColor = true;
        this.DisplayBackButton.Click += new System.EventHandler(this.DisplayBackButton_Click);
        // 
        // DisplayDataShow
        // 
        this.DisplayDataShow.AllowUserToAddRows = false;
        this.DisplayDataShow.AllowUserToDeleteRows = false;
        this.DisplayDataShow.AllowUserToResizeColumns = false;
        this.DisplayDataShow.AllowUserToResizeRows = false;
        this.DisplayDataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.DisplayDataShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataID,
            this.DataName,
            this.DataHireDate,
            this.DataDepartmenNo});
        this.DisplayDataShow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
        this.DisplayDataShow.Location = new System.Drawing.Point(132, 38);
        this.DisplayDataShow.Name = "DisplayDataShow";
        this.DisplayDataShow.ReadOnly = true;
        this.DisplayDataShow.Size = new System.Drawing.Size(443, 269);
        this.DisplayDataShow.TabIndex = 3;
        // 
        // DataID
        // 
        this.DataID.HeaderText = "ID";
        this.DataID.Name = "DataID";
        this.DataID.ReadOnly = true;
        // 
        // DataName
        // 
        this.DataName.HeaderText = "Name";
        this.DataName.Name = "DataName";
        this.DataName.ReadOnly = true;
        // 
        // DataHireDate
        // 
        this.DataHireDate.HeaderText = "Hire Date";
        this.DataHireDate.Name = "DataHireDate";
        this.DataHireDate.ReadOnly = true;
        // 
        // DataDepartmenNo
        // 
        this.DataDepartmenNo.HeaderText = "Department No.";
        this.DataDepartmenNo.Name = "DataDepartmenNo";
        this.DataDepartmenNo.ReadOnly = true;
        // 
        // PanelDisplayButton
        // 
        this.PanelDisplayButton.Location = new System.Drawing.Point(414, 10);
        this.PanelDisplayButton.Name = "PanelDisplayButton";
        this.PanelDisplayButton.Size = new System.Drawing.Size(75, 23);
        this.PanelDisplayButton.TabIndex = 2;
        this.PanelDisplayButton.Text = "Display";
        this.PanelDisplayButton.UseVisualStyleBackColor = true;
        this.PanelDisplayButton.Click += new System.EventHandler(this.PanelDisplayButton_Click);
        // 
        // DummyDepartLabel
        // 
        this.DummyDepartLabel.AutoSize = true;
        this.DummyDepartLabel.Location = new System.Drawing.Point(218, 15);
        this.DummyDepartLabel.Name = "DummyDepartLabel";
        this.DummyDepartLabel.Size = new System.Drawing.Size(64, 13);
        this.DummyDepartLabel.TabIndex = 1;
        this.DummyDepartLabel.Text = "Department";
        // 
        // DisplayDepartmentTextBox
        // 
        this.DisplayDepartmentTextBox.Location = new System.Drawing.Point(286, 12);
        this.DisplayDepartmentTextBox.Name = "DisplayDepartmentTextBox";
        this.DisplayDepartmentTextBox.Size = new System.Drawing.Size(122, 20);
        this.DisplayDepartmentTextBox.TabIndex = 0;
        // 
        // SearchPanel
        // 
        this.SearchPanel.Controls.Add(this.SearchEditableHiringDate);
        this.SearchPanel.Controls.Add(this.SearchBack);
        this.SearchPanel.Controls.Add(this.SearchPanelButton);
        this.SearchPanel.Controls.Add(this.DummySearchLabel);
        this.SearchPanel.Controls.Add(this.SearchDepartmentNoButton);
        this.SearchPanel.Controls.Add(this.SearchHiringDateButton);
        this.SearchPanel.Controls.Add(this.SearchIDButton);
        this.SearchPanel.Controls.Add(this.SearchNameButton);
        this.SearchPanel.Controls.Add(this.SearchEditableDepartmentNo);
        this.SearchPanel.Controls.Add(this.SearchEditableID);
        this.SearchPanel.Controls.Add(this.SearchEditableName);
        this.SearchPanel.Controls.Add(this.SearchValueDepartmentNo);
        this.SearchPanel.Controls.Add(this.SearchValueHirinDate);
        this.SearchPanel.Controls.Add(this.SearchValueID);
        this.SearchPanel.Controls.Add(this.SearchValueName);
        this.SearchPanel.Controls.Add(this.SearchDepartmentNo);
        this.SearchPanel.Controls.Add(this.SearchHiringDate);
        this.SearchPanel.Controls.Add(this.SearchIDLabel);
        this.SearchPanel.Controls.Add(this.SearchLabelName);
        this.SearchPanel.Controls.Add(this.SearchText);
        this.SearchPanel.Location = new System.Drawing.Point(0, 0);
        this.SearchPanel.Name = "SearchPanel";
        this.SearchPanel.Size = new System.Drawing.Size(710, 319);
        this.SearchPanel.TabIndex = 3;
        this.SearchPanel.Visible = false;
        // 
        // SearchEditableHiringDate
        // 
        this.SearchEditableHiringDate.Location = new System.Drawing.Point(258, 148);
        this.SearchEditableHiringDate.Name = "SearchEditableHiringDate";
        this.SearchEditableHiringDate.Size = new System.Drawing.Size(162, 20);
        this.SearchEditableHiringDate.TabIndex = 20;
        this.SearchEditableHiringDate.Visible = false;
        this.SearchEditableHiringDate.ValueChanged += new System.EventHandler(this.SearchEditableHiringDate_ValueChanged);
        // 
        // SearchBack
        // 
        this.SearchBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.SearchBack.Location = new System.Drawing.Point(301, 284);
        this.SearchBack.Name = "SearchBack";
        this.SearchBack.Size = new System.Drawing.Size(75, 23);
        this.SearchBack.TabIndex = 19;
        this.SearchBack.Text = "Back";
        this.SearchBack.UseVisualStyleBackColor = true;
        this.SearchBack.Click += new System.EventHandler(this.SearchBack_Click);
        // 
        // SearchPanelButton
        // 
        this.SearchPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.SearchPanelButton.Location = new System.Drawing.Point(393, 10);
        this.SearchPanelButton.Name = "SearchPanelButton";
        this.SearchPanelButton.Size = new System.Drawing.Size(75, 23);
        this.SearchPanelButton.TabIndex = 18;
        this.SearchPanelButton.Text = "Search";
        this.SearchPanelButton.UseVisualStyleBackColor = true;
        this.SearchPanelButton.Click += new System.EventHandler(this.SearchPanelButton_Click);
        // 
        // DummySearchLabel
        // 
        this.DummySearchLabel.AutoSize = true;
        this.DummySearchLabel.Location = new System.Drawing.Point(208, 15);
        this.DummySearchLabel.Name = "DummySearchLabel";
        this.DummySearchLabel.Size = new System.Drawing.Size(74, 13);
        this.DummySearchLabel.TabIndex = 17;
        this.DummySearchLabel.Text = "Employee ID :";
        // 
        // SearchDepartmentNoButton
        // 
        this.SearchDepartmentNoButton.Enabled = false;
        this.SearchDepartmentNoButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.SearchDepartmentNoButton.Location = new System.Drawing.Point(436, 187);
        this.SearchDepartmentNoButton.Name = "SearchDepartmentNoButton";
        this.SearchDepartmentNoButton.Size = new System.Drawing.Size(75, 23);
        this.SearchDepartmentNoButton.TabIndex = 16;
        this.SearchDepartmentNoButton.Text = "Edit";
        this.SearchDepartmentNoButton.UseVisualStyleBackColor = true;
        this.SearchDepartmentNoButton.Click += new System.EventHandler(this.SearchDepartmentNoButton_Click);
        // 
        // SearchHiringDateButton
        // 
        this.SearchHiringDateButton.Enabled = false;
        this.SearchHiringDateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.SearchHiringDateButton.Location = new System.Drawing.Point(436, 148);
        this.SearchHiringDateButton.Name = "SearchHiringDateButton";
        this.SearchHiringDateButton.Size = new System.Drawing.Size(75, 23);
        this.SearchHiringDateButton.TabIndex = 15;
        this.SearchHiringDateButton.Text = "Edit";
        this.SearchHiringDateButton.UseVisualStyleBackColor = true;
        this.SearchHiringDateButton.Click += new System.EventHandler(this.SearchHiringDateButton_Click);
        // 
        // SearchIDButton
        // 
        this.SearchIDButton.Enabled = false;
        this.SearchIDButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.SearchIDButton.Location = new System.Drawing.Point(436, 108);
        this.SearchIDButton.Name = "SearchIDButton";
        this.SearchIDButton.Size = new System.Drawing.Size(75, 23);
        this.SearchIDButton.TabIndex = 14;
        this.SearchIDButton.Text = "Edit";
        this.SearchIDButton.UseVisualStyleBackColor = true;
        this.SearchIDButton.Click += new System.EventHandler(this.SearchIDButton_Click);
        // 
        // SearchNameButton
        // 
        this.SearchNameButton.Enabled = false;
        this.SearchNameButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.SearchNameButton.Location = new System.Drawing.Point(436, 64);
        this.SearchNameButton.Name = "SearchNameButton";
        this.SearchNameButton.Size = new System.Drawing.Size(75, 23);
        this.SearchNameButton.TabIndex = 13;
        this.SearchNameButton.Text = "Edit";
        this.SearchNameButton.UseVisualStyleBackColor = true;
        this.SearchNameButton.Click += new System.EventHandler(this.SearchNameButton_Click);
        // 
        // SearchEditableDepartmentNo
        // 
        this.SearchEditableDepartmentNo.Location = new System.Drawing.Point(287, 187);
        this.SearchEditableDepartmentNo.Name = "SearchEditableDepartmentNo";
        this.SearchEditableDepartmentNo.Size = new System.Drawing.Size(100, 20);
        this.SearchEditableDepartmentNo.TabIndex = 12;
        this.SearchEditableDepartmentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.SearchEditableDepartmentNo.Visible = false;
        // 
        // SearchEditableID
        // 
        this.SearchEditableID.Location = new System.Drawing.Point(287, 108);
        this.SearchEditableID.Name = "SearchEditableID";
        this.SearchEditableID.Size = new System.Drawing.Size(100, 20);
        this.SearchEditableID.TabIndex = 10;
        this.SearchEditableID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.SearchEditableID.Visible = false;
        // 
        // SearchEditableName
        // 
        this.SearchEditableName.Location = new System.Drawing.Point(287, 64);
        this.SearchEditableName.Name = "SearchEditableName";
        this.SearchEditableName.Size = new System.Drawing.Size(100, 20);
        this.SearchEditableName.TabIndex = 9;
        this.SearchEditableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.SearchEditableName.Visible = false;
        // 
        // SearchValueDepartmentNo
        // 
        this.SearchValueDepartmentNo.AutoSize = true;
        this.SearchValueDepartmentNo.Location = new System.Drawing.Point(311, 192);
        this.SearchValueDepartmentNo.Name = "SearchValueDepartmentNo";
        this.SearchValueDepartmentNo.Size = new System.Drawing.Size(63, 13);
        this.SearchValueDepartmentNo.TabIndex = 8;
        this.SearchValueDepartmentNo.Text = "--------------";
        // 
        // SearchValueHirinDate
        // 
        this.SearchValueHirinDate.AutoSize = true;
        this.SearchValueHirinDate.Location = new System.Drawing.Point(311, 153);
        this.SearchValueHirinDate.Name = "SearchValueHirinDate";
        this.SearchValueHirinDate.Size = new System.Drawing.Size(63, 13);
        this.SearchValueHirinDate.TabIndex = 7;
        this.SearchValueHirinDate.Text = "--------------";
        // 
        // SearchValueID
        // 
        this.SearchValueID.AutoSize = true;
        this.SearchValueID.Location = new System.Drawing.Point(311, 113);
        this.SearchValueID.Name = "SearchValueID";
        this.SearchValueID.Size = new System.Drawing.Size(63, 13);
        this.SearchValueID.TabIndex = 6;
        this.SearchValueID.Text = "--------------";
        // 
        // SearchValueName
        // 
        this.SearchValueName.AutoSize = true;
        this.SearchValueName.Location = new System.Drawing.Point(311, 69);
        this.SearchValueName.Name = "SearchValueName";
        this.SearchValueName.Size = new System.Drawing.Size(63, 13);
        this.SearchValueName.TabIndex = 5;
        this.SearchValueName.Text = "--------------";
        // 
        // SearchDepartmentNo
        // 
        this.SearchDepartmentNo.AutoSize = true;
        this.SearchDepartmentNo.Location = new System.Drawing.Point(175, 190);
        this.SearchDepartmentNo.Name = "SearchDepartmentNo";
        this.SearchDepartmentNo.Size = new System.Drawing.Size(87, 13);
        this.SearchDepartmentNo.TabIndex = 4;
        this.SearchDepartmentNo.Text = "Department No :";
        // 
        // SearchHiringDate
        // 
        this.SearchHiringDate.AutoSize = true;
        this.SearchHiringDate.Location = new System.Drawing.Point(175, 151);
        this.SearchHiringDate.Name = "SearchHiringDate";
        this.SearchHiringDate.Size = new System.Drawing.Size(67, 13);
        this.SearchHiringDate.TabIndex = 3;
        this.SearchHiringDate.Text = "Hiring Date :";
        // 
        // SearchIDLabel
        // 
        this.SearchIDLabel.AutoSize = true;
        this.SearchIDLabel.Location = new System.Drawing.Point(175, 111);
        this.SearchIDLabel.Name = "SearchIDLabel";
        this.SearchIDLabel.Size = new System.Drawing.Size(28, 13);
        this.SearchIDLabel.TabIndex = 2;
        this.SearchIDLabel.Text = "ID : ";
        // 
        // SearchLabelName
        // 
        this.SearchLabelName.AutoSize = true;
        this.SearchLabelName.Location = new System.Drawing.Point(175, 67);
        this.SearchLabelName.Name = "SearchLabelName";
        this.SearchLabelName.Size = new System.Drawing.Size(41, 13);
        this.SearchLabelName.TabIndex = 1;
        this.SearchLabelName.Text = "Name :";
        // 
        // SearchText
        // 
        this.SearchText.Location = new System.Drawing.Point(287, 12);
        this.SearchText.Name = "SearchText";
        this.SearchText.Size = new System.Drawing.Size(100, 20);
        this.SearchText.TabIndex = 0;
        // 
        // WritingPanel
        // 
        this.WritingPanel.Controls.Add(this.BackButton);
        this.WritingPanel.Controls.Add(this.EmployeeHiryDate);
        this.WritingPanel.Controls.Add(this.Submit_Result);
        this.WritingPanel.Controls.Add(this.EmployeeDepIdError);
        this.WritingPanel.Controls.Add(this.EmployeeIdError);
        this.WritingPanel.Controls.Add(this.EmployeeSubmitButton);
        this.WritingPanel.Controls.Add(this.EmployeeNameError);
        this.WritingPanel.Controls.Add(this.label4);
        this.WritingPanel.Controls.Add(this.label3);
        this.WritingPanel.Controls.Add(this.label2);
        this.WritingPanel.Controls.Add(this.label1);
        this.WritingPanel.Controls.Add(this.EmployeeDepId);
        this.WritingPanel.Controls.Add(this.EmployeeId);
        this.WritingPanel.Controls.Add(this.Title);
        this.WritingPanel.Controls.Add(this.EmployeeName);
        this.WritingPanel.Location = new System.Drawing.Point(0, 0);
        this.WritingPanel.Name = "WritingPanel";
        this.WritingPanel.Size = new System.Drawing.Size(710, 319);
        this.WritingPanel.TabIndex = 4;
        // 
        // BackButton
        // 
        this.BackButton.Location = new System.Drawing.Point(24, 22);
        this.BackButton.Name = "BackButton";
        this.BackButton.Size = new System.Drawing.Size(86, 43);
        this.BackButton.TabIndex = 15;
        this.BackButton.Text = "Back";
        this.BackButton.UseVisualStyleBackColor = true;
        this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
        // 
        // EmployeeHiryDate
        // 
        this.EmployeeHiryDate.Location = new System.Drawing.Point(406, 364);
        this.EmployeeHiryDate.Name = "EmployeeHiryDate";
        this.EmployeeHiryDate.Size = new System.Drawing.Size(204, 27);
        this.EmployeeHiryDate.TabIndex = 14;
        this.EmployeeHiryDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
        //
        // 
        // Submit_Result
        // 
        this.Submit_Result.AutoSize = true;
        this.Submit_Result.Location = new System.Drawing.Point(766, 430);
        this.Submit_Result.Name = "Submit_Result";
        this.Submit_Result.Size = new System.Drawing.Size(0, 13);
        this.Submit_Result.TabIndex = 13;
        this.Submit_Result.Click += new System.EventHandler(this.label5_Click_1);
        // 
        // EmployeeDepIdError
        // 
        this.EmployeeDepIdError.AutoSize = true;
        this.EmployeeDepIdError.Location = new System.Drawing.Point(462, 204);
        this.EmployeeDepIdError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.EmployeeDepIdError.Name = "EmployeeDepIdError";
        this.EmployeeDepIdError.Size = new System.Drawing.Size(0, 13);
        this.EmployeeDepIdError.TabIndex = 12;
        // 
        // EmployeeIdError
        // 
        this.EmployeeIdError.AutoSize = true;
        this.EmployeeIdError.Location = new System.Drawing.Point(459, 151);
        this.EmployeeIdError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.EmployeeIdError.Name = "EmployeeIdError";
        this.EmployeeIdError.Size = new System.Drawing.Size(0, 13);
        this.EmployeeIdError.TabIndex = 11;
        // 
        // EmployeeSubmitButton
        // 
        this.EmployeeSubmitButton.Location = new System.Drawing.Point(779, 370);
        this.EmployeeSubmitButton.Name = "EmployeeSubmitButton";
        this.EmployeeSubmitButton.Size = new System.Drawing.Size(146, 42);
        this.EmployeeSubmitButton.TabIndex = 9;
        this.EmployeeSubmitButton.Text = "Submit";
        this.EmployeeSubmitButton.UseVisualStyleBackColor = true;
        this.EmployeeSubmitButton.Click += new System.EventHandler(this.EmployeeSubmitButton_Click);
        // 
        // EmployeeNameError
        // 
        this.EmployeeNameError.AutoSize = true;
        this.EmployeeNameError.Location = new System.Drawing.Point(468, 110);
        this.EmployeeNameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.EmployeeNameError.Name = "EmployeeNameError";
        this.EmployeeNameError.Size = new System.Drawing.Size(0, 13);
        this.EmployeeNameError.TabIndex = 10;
        this.EmployeeNameError.Click += new System.EventHandler(this.label5_Click);
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(175, 253);
        this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(60, 13);
        this.label4.TabIndex = 8;
        this.label4.Text = "Hiring Date";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(175, 205);
        this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(78, 13);
        this.label3.TabIndex = 7;
        this.label3.Text = "Department ID";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(175, 155);
        this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(18, 13);
        this.label2.TabIndex = 6;
        this.label2.Text = "ID";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(175, 110);
        this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(34, 13);
        this.label1.TabIndex = 5;
        this.label1.Text = "Name";
        this.label1.Click += new System.EventHandler(this.label1_Click);
        // 
        // EmployeeDepId
        // 
        this.EmployeeDepId.Location = new System.Drawing.Point(271, 199);
        this.EmployeeDepId.Margin = new System.Windows.Forms.Padding(2);
        this.EmployeeDepId.Name = "EmployeeDepId";
        this.EmployeeDepId.Size = new System.Drawing.Size(137, 20);
        this.EmployeeDepId.TabIndex = 3;
        // 
        // EmployeeId
        // 
        this.EmployeeId.Location = new System.Drawing.Point(271, 150);
        this.EmployeeId.Margin = new System.Windows.Forms.Padding(2);
        this.EmployeeId.Name = "EmployeeId";
        this.EmployeeId.Size = new System.Drawing.Size(137, 20);
        this.EmployeeId.TabIndex = 2;
        // 
        // Title
        // 
        this.Title.AutoSize = true;
        this.Title.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Title.Location = new System.Drawing.Point(185, 34);
        this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.Title.Name = "Title";
        this.Title.Size = new System.Drawing.Size(254, 26);
        this.Title.TabIndex = 1;
        this.Title.Text = "Enter the user information";
        // 
        // EmployeeName
        // 
        this.EmployeeName.Location = new System.Drawing.Point(271, 105);
        this.EmployeeName.Margin = new System.Windows.Forms.Padding(2);
        this.EmployeeName.Name = "EmployeeName";
        this.EmployeeName.Size = new System.Drawing.Size(137, 20);
        this.EmployeeName.TabIndex = 0;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(707, 319);
        this.Controls.Add(this.WritingPanel);
        this.Controls.Add(this.LandingPanel);
        this.Controls.Add(this.SearchPanel);
        this.Controls.Add(this.DisplayPanel);
        this.Name = "MainForm";
        this.Text = "HRMS";
        this.LandingPanel.ResumeLayout(false);
        this.DisplayPanel.ResumeLayout(false);
        this.DisplayPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.DisplayDataShow)).EndInit();
        this.SearchPanel.ResumeLayout(false);
        this.SearchPanel.PerformLayout();
        this.WritingPanel.ResumeLayout(false);
        this.WritingPanel.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button DisplayButton;
    private System.Windows.Forms.Button SearchButton;
    private System.Windows.Forms.Button WriteButton;
    private System.Windows.Forms.Panel LandingPanel;
    private System.Windows.Forms.Panel DisplayPanel;
    private System.Windows.Forms.Button PanelDisplayButton;
    private System.Windows.Forms.Label DummyDepartLabel;
    private System.Windows.Forms.TextBox DisplayDepartmentTextBox;
    private System.Windows.Forms.DataGridView DisplayDataShow;
    private System.Windows.Forms.DataGridViewTextBoxColumn DataID;
    private System.Windows.Forms.DataGridViewTextBoxColumn DataName;
    private System.Windows.Forms.DataGridViewTextBoxColumn DataHireDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn DataDepartmenNo;
    private System.Windows.Forms.Button DisplayBackButton;
    private System.Windows.Forms.Panel SearchPanel;
    private System.Windows.Forms.Label SearchValueDepartmentNo;
    private System.Windows.Forms.Label SearchValueHirinDate;
    private System.Windows.Forms.Label SearchValueID;
    private System.Windows.Forms.Label SearchValueName;
    private System.Windows.Forms.Label SearchDepartmentNo;
    private System.Windows.Forms.Label SearchHiringDate;
    private System.Windows.Forms.Label SearchIDLabel;
    private System.Windows.Forms.Label SearchLabelName;
    private System.Windows.Forms.TextBox SearchText;
    private System.Windows.Forms.Button SearchPanelButton;
    private System.Windows.Forms.Label DummySearchLabel;
    private System.Windows.Forms.Button SearchDepartmentNoButton;
    private System.Windows.Forms.Button SearchHiringDateButton;
    private System.Windows.Forms.Button SearchIDButton;
    private System.Windows.Forms.Button SearchNameButton;
    private System.Windows.Forms.TextBox SearchEditableDepartmentNo;
    private System.Windows.Forms.TextBox SearchEditableID;
    private System.Windows.Forms.TextBox SearchEditableName;
    private System.Windows.Forms.Button SearchBack;
    private System.Windows.Forms.DateTimePicker SearchEditableHiringDate;
    private System.Windows.Forms.Panel WritingPanel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox EmployeeDepId;
    private System.Windows.Forms.TextBox EmployeeId;
    private System.Windows.Forms.Label Title;
    private System.Windows.Forms.TextBox EmployeeName;
    private System.Windows.Forms.Button EmployeeSubmitButton;
    private System.Windows.Forms.Label EmployeeNameError;
    private System.Windows.Forms.Label EmployeeDepIdError;
    private System.Windows.Forms.Label EmployeeIdError;
    private System.Windows.Forms.Label Submit_Result;
    private System.Windows.Forms.DateTimePicker EmployeeHiryDate;
    private System.Windows.Forms.Button BackButton;
}

