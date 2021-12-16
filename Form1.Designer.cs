
namespace GroupFinalProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patientTab = new System.Windows.Forms.TabPage();
            this.demographEditButton = new System.Windows.Forms.Button();
            this.demographicsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demographicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDatabaseDataSet = new GroupFinalProject.PatientDatabaseDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.iDBox = new System.Windows.Forms.TextBox();
            this.demographSaveButton = new System.Windows.Forms.Button();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.demographEditPatientButton = new System.Windows.Forms.Button();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.patientIdBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.allergyTab = new System.Windows.Forms.TabPage();
            this.medicationNeedBoxA = new System.Windows.Forms.TextBox();
            this.DateDiscoveredBoxA = new System.Windows.Forms.TextBox();
            this.allergenBoxA = new System.Windows.Forms.TextBox();
            this.patientIDBoxA = new System.Windows.Forms.TextBox();
            this.iDBoxA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.generalHealthTab = new System.Windows.Forms.TabPage();
            this.maritalBoxG = new System.Windows.Forms.TextBox();
            this.patientIDBoxG = new System.Windows.Forms.TextBox();
            this.bloodTypeBoxG = new System.Windows.Forms.TextBox();
            this.iDBoxG = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.allergyButton = new System.Windows.Forms.Button();
            this.generalHealthButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.demographicsTableAdapter = new GroupFinalProject.PatientDatabaseDataSetTableAdapters.DemographicsTableAdapter();
            this.tableAdapterManager = new GroupFinalProject.PatientDatabaseDataSetTableAdapters.TableAdapterManager();
            this.rhBoxG = new System.Windows.Forms.TextBox();
            this.tobaccoBoxG = new System.Windows.Forms.TextBox();
            this.alacoholBoxG = new System.Windows.Forms.TextBox();
            this.drugBoxG = new System.Windows.Forms.TextBox();
            this.modifyBtnA = new System.Windows.Forms.Button();
            this.saveBtnA = new System.Windows.Forms.Button();
            this.modifyBtnG = new System.Windows.Forms.Button();
            this.saveBtnG = new System.Windows.Forms.Button();
            this.editPatientBtnA = new System.Windows.Forms.Button();
            this.editPatientBtnG = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.patientTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demographicsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demographicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDatabaseDataSet)).BeginInit();
            this.allergyTab.SuspendLayout();
            this.generalHealthTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(9, 43);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(168, 22);
            this.searchBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Search by Patient ID",
            "Search by Last Name",
            "Search by Phone Number"});
            this.comboBox1.Location = new System.Drawing.Point(9, 84);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.patientTab);
            this.tabControl1.Controls.Add(this.allergyTab);
            this.tabControl1.Controls.Add(this.generalHealthTab);
            this.tabControl1.Location = new System.Drawing.Point(187, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 538);
            this.tabControl1.TabIndex = 3;
            // 
            // patientTab
            // 
            this.patientTab.AutoScroll = true;
            this.patientTab.Controls.Add(this.demographEditButton);
            this.patientTab.Controls.Add(this.demographicsDataGridView);
            this.patientTab.Controls.Add(this.label7);
            this.patientTab.Controls.Add(this.iDBox);
            this.patientTab.Controls.Add(this.demographSaveButton);
            this.patientTab.Controls.Add(this.stateBox);
            this.patientTab.Controls.Add(this.demographEditPatientButton);
            this.patientTab.Controls.Add(this.cityBox);
            this.patientTab.Controls.Add(this.addressBox);
            this.patientTab.Controls.Add(this.firstNameBox);
            this.patientTab.Controls.Add(this.lastNameBox);
            this.patientTab.Controls.Add(this.patientIdBox);
            this.patientTab.Controls.Add(this.label6);
            this.patientTab.Controls.Add(this.label5);
            this.patientTab.Controls.Add(this.label4);
            this.patientTab.Controls.Add(this.label3);
            this.patientTab.Controls.Add(this.label2);
            this.patientTab.Controls.Add(this.label1);
            this.patientTab.Location = new System.Drawing.Point(4, 25);
            this.patientTab.Margin = new System.Windows.Forms.Padding(4);
            this.patientTab.Name = "patientTab";
            this.patientTab.Padding = new System.Windows.Forms.Padding(4);
            this.patientTab.Size = new System.Drawing.Size(959, 509);
            this.patientTab.TabIndex = 0;
            this.patientTab.Text = "Demographics";
            this.patientTab.UseVisualStyleBackColor = true;
            // 
            // demographEditButton
            // 
            this.demographEditButton.Location = new System.Drawing.Point(8, 457);
            this.demographEditButton.Margin = new System.Windows.Forms.Padding(4);
            this.demographEditButton.Name = "demographEditButton";
            this.demographEditButton.Size = new System.Drawing.Size(148, 28);
            this.demographEditButton.TabIndex = 18;
            this.demographEditButton.Text = "Modify";
            this.demographEditButton.UseVisualStyleBackColor = true;
            this.demographEditButton.Click += new System.EventHandler(this.demographEditButton_Click);
            // 
            // demographicsDataGridView
            // 
            this.demographicsDataGridView.AutoGenerateColumns = false;
            this.demographicsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demographicsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.demographicsDataGridView.DataSource = this.demographicsBindingSource;
            this.demographicsDataGridView.Location = new System.Drawing.Point(1, 0);
            this.demographicsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.demographicsDataGridView.Name = "demographicsDataGridView";
            this.demographicsDataGridView.RowHeadersWidth = 51;
            this.demographicsDataGridView.Size = new System.Drawing.Size(955, 140);
            this.demographicsDataGridView.TabIndex = 17;
            this.demographicsDataGridView.SelectionChanged += new System.EventHandler(this.demographicsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PatientID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StreetAddress";
            this.dataGridViewTextBoxColumn5.HeaderText = "StreetAddress";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn6.HeaderText = "City";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn7.HeaderText = "State";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // demographicsBindingSource
            // 
            this.demographicsBindingSource.DataMember = "Demographics";
            this.demographicsBindingSource.DataSource = this.patientDatabaseDataSet;
            // 
            // patientDatabaseDataSet
            // 
            this.patientDatabaseDataSet.DataSetName = "PatientDatabaseDataSet";
            this.patientDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // iDBox
            // 
            this.iDBox.Location = new System.Drawing.Point(324, 161);
            this.iDBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDBox.Name = "iDBox";
            this.iDBox.ReadOnly = true;
            this.iDBox.Size = new System.Drawing.Size(253, 22);
            this.iDBox.TabIndex = 13;
            // 
            // demographSaveButton
            // 
            this.demographSaveButton.Location = new System.Drawing.Point(800, 457);
            this.demographSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.demographSaveButton.Name = "demographSaveButton";
            this.demographSaveButton.Size = new System.Drawing.Size(148, 28);
            this.demographSaveButton.TabIndex = 9;
            this.demographSaveButton.Text = "Save New Patient";
            this.demographSaveButton.UseVisualStyleBackColor = true;
            this.demographSaveButton.Click += new System.EventHandler(this.demographSaveButton_Click);
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(557, 386);
            this.stateBox.Margin = new System.Windows.Forms.Padding(4);
            this.stateBox.Name = "stateBox";
            this.stateBox.ReadOnly = true;
            this.stateBox.Size = new System.Drawing.Size(300, 22);
            this.stateBox.TabIndex = 11;
            // 
            // demographEditPatientButton
            // 
            this.demographEditPatientButton.Location = new System.Drawing.Point(644, 457);
            this.demographEditPatientButton.Margin = new System.Windows.Forms.Padding(4);
            this.demographEditPatientButton.Name = "demographEditPatientButton";
            this.demographEditPatientButton.Size = new System.Drawing.Size(148, 28);
            this.demographEditPatientButton.TabIndex = 8;
            this.demographEditPatientButton.Text = "Edit Patient";
            this.demographEditPatientButton.UseVisualStyleBackColor = true;
            this.demographEditPatientButton.Click += new System.EventHandler(this.demographEditPatientButton_Click);
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(557, 298);
            this.cityBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityBox.Name = "cityBox";
            this.cityBox.ReadOnly = true;
            this.cityBox.Size = new System.Drawing.Size(300, 22);
            this.cityBox.TabIndex = 10;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(557, 215);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(300, 22);
            this.addressBox.TabIndex = 9;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(124, 386);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.ReadOnly = true;
            this.firstNameBox.Size = new System.Drawing.Size(253, 22);
            this.firstNameBox.TabIndex = 8;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(124, 298);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.ReadOnly = true;
            this.lastNameBox.Size = new System.Drawing.Size(253, 22);
            this.lastNameBox.TabIndex = 7;
            // 
            // patientIdBox
            // 
            this.patientIdBox.Location = new System.Drawing.Point(124, 214);
            this.patientIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.patientIdBox.Name = "patientIdBox";
            this.patientIdBox.ReadOnly = true;
            this.patientIdBox.Size = new System.Drawing.Size(253, 22);
            this.patientIdBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Street Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // allergyTab
            // 
            this.allergyTab.Controls.Add(this.editPatientBtnA);
            this.allergyTab.Controls.Add(this.saveBtnA);
            this.allergyTab.Controls.Add(this.modifyBtnA);
            this.allergyTab.Controls.Add(this.medicationNeedBoxA);
            this.allergyTab.Controls.Add(this.DateDiscoveredBoxA);
            this.allergyTab.Controls.Add(this.allergenBoxA);
            this.allergyTab.Controls.Add(this.patientIDBoxA);
            this.allergyTab.Controls.Add(this.iDBoxA);
            this.allergyTab.Controls.Add(this.label13);
            this.allergyTab.Controls.Add(this.label12);
            this.allergyTab.Controls.Add(this.label11);
            this.allergyTab.Controls.Add(this.label10);
            this.allergyTab.Controls.Add(this.label9);
            this.allergyTab.Location = new System.Drawing.Point(4, 25);
            this.allergyTab.Margin = new System.Windows.Forms.Padding(4);
            this.allergyTab.Name = "allergyTab";
            this.allergyTab.Padding = new System.Windows.Forms.Padding(4);
            this.allergyTab.Size = new System.Drawing.Size(959, 509);
            this.allergyTab.TabIndex = 1;
            this.allergyTab.Text = "Allergies";
            this.allergyTab.UseVisualStyleBackColor = true;
            // 
            // medicationNeedBoxA
            // 
            this.medicationNeedBoxA.Location = new System.Drawing.Point(624, 307);
            this.medicationNeedBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.medicationNeedBoxA.Name = "medicationNeedBoxA";
            this.medicationNeedBoxA.ReadOnly = true;
            this.medicationNeedBoxA.Size = new System.Drawing.Size(253, 22);
            this.medicationNeedBoxA.TabIndex = 24;
            // 
            // DateDiscoveredBoxA
            // 
            this.DateDiscoveredBoxA.Location = new System.Drawing.Point(624, 216);
            this.DateDiscoveredBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.DateDiscoveredBoxA.Name = "DateDiscoveredBoxA";
            this.DateDiscoveredBoxA.ReadOnly = true;
            this.DateDiscoveredBoxA.Size = new System.Drawing.Size(253, 22);
            this.DateDiscoveredBoxA.TabIndex = 23;
            // 
            // allergenBoxA
            // 
            this.allergenBoxA.Location = new System.Drawing.Point(624, 133);
            this.allergenBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.allergenBoxA.Name = "allergenBoxA";
            this.allergenBoxA.ReadOnly = true;
            this.allergenBoxA.Size = new System.Drawing.Size(253, 22);
            this.allergenBoxA.TabIndex = 22;
            // 
            // patientIDBoxA
            // 
            this.patientIDBoxA.Location = new System.Drawing.Point(115, 216);
            this.patientIDBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.patientIDBoxA.Name = "patientIDBoxA";
            this.patientIDBoxA.ReadOnly = true;
            this.patientIDBoxA.Size = new System.Drawing.Size(253, 22);
            this.patientIDBoxA.TabIndex = 21;
            // 
            // iDBoxA
            // 
            this.iDBoxA.Location = new System.Drawing.Point(115, 137);
            this.iDBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.iDBoxA.Name = "iDBoxA";
            this.iDBoxA.ReadOnly = true;
            this.iDBoxA.Size = new System.Drawing.Size(253, 22);
            this.iDBoxA.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(418, 307);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Medication Needed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(445, 213);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Date Discovered";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(525, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Allergen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Patient ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "ID";
            // 
            // generalHealthTab
            // 
            this.generalHealthTab.Controls.Add(this.editPatientBtnG);
            this.generalHealthTab.Controls.Add(this.saveBtnG);
            this.generalHealthTab.Controls.Add(this.modifyBtnG);
            this.generalHealthTab.Controls.Add(this.drugBoxG);
            this.generalHealthTab.Controls.Add(this.alacoholBoxG);
            this.generalHealthTab.Controls.Add(this.tobaccoBoxG);
            this.generalHealthTab.Controls.Add(this.rhBoxG);
            this.generalHealthTab.Controls.Add(this.maritalBoxG);
            this.generalHealthTab.Controls.Add(this.patientIDBoxG);
            this.generalHealthTab.Controls.Add(this.bloodTypeBoxG);
            this.generalHealthTab.Controls.Add(this.iDBoxG);
            this.generalHealthTab.Controls.Add(this.label21);
            this.generalHealthTab.Controls.Add(this.label20);
            this.generalHealthTab.Controls.Add(this.label19);
            this.generalHealthTab.Controls.Add(this.label18);
            this.generalHealthTab.Controls.Add(this.label17);
            this.generalHealthTab.Controls.Add(this.label16);
            this.generalHealthTab.Controls.Add(this.label15);
            this.generalHealthTab.Controls.Add(this.label14);
            this.generalHealthTab.Location = new System.Drawing.Point(4, 25);
            this.generalHealthTab.Margin = new System.Windows.Forms.Padding(4);
            this.generalHealthTab.Name = "generalHealthTab";
            this.generalHealthTab.Padding = new System.Windows.Forms.Padding(4);
            this.generalHealthTab.Size = new System.Drawing.Size(959, 509);
            this.generalHealthTab.TabIndex = 2;
            this.generalHealthTab.Text = "General Health";
            this.generalHealthTab.UseVisualStyleBackColor = true;
            // 
            // maritalBoxG
            // 
            this.maritalBoxG.Location = new System.Drawing.Point(158, 235);
            this.maritalBoxG.Margin = new System.Windows.Forms.Padding(4);
            this.maritalBoxG.Name = "maritalBoxG";
            this.maritalBoxG.ReadOnly = true;
            this.maritalBoxG.Size = new System.Drawing.Size(253, 22);
            this.maritalBoxG.TabIndex = 28;
            // 
            // patientIDBoxG
            // 
            this.patientIDBoxG.Location = new System.Drawing.Point(158, 165);
            this.patientIDBoxG.Margin = new System.Windows.Forms.Padding(4);
            this.patientIDBoxG.Name = "patientIDBoxG";
            this.patientIDBoxG.ReadOnly = true;
            this.patientIDBoxG.Size = new System.Drawing.Size(253, 22);
            this.patientIDBoxG.TabIndex = 27;
            // 
            // bloodTypeBoxG
            // 
            this.bloodTypeBoxG.Location = new System.Drawing.Point(158, 305);
            this.bloodTypeBoxG.Margin = new System.Windows.Forms.Padding(4);
            this.bloodTypeBoxG.Name = "bloodTypeBoxG";
            this.bloodTypeBoxG.ReadOnly = true;
            this.bloodTypeBoxG.Size = new System.Drawing.Size(253, 22);
            this.bloodTypeBoxG.TabIndex = 26;
            // 
            // iDBoxG
            // 
            this.iDBoxG.Location = new System.Drawing.Point(158, 100);
            this.iDBoxG.Margin = new System.Windows.Forms.Padding(4);
            this.iDBoxG.Name = "iDBoxG";
            this.iDBoxG.ReadOnly = true;
            this.iDBoxG.Size = new System.Drawing.Size(253, 22);
            this.iDBoxG.TabIndex = 25;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(565, 302);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 25);
            this.label21.TabIndex = 24;
            this.label21.Text = "Drug Use";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(528, 230);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 25);
            this.label20.TabIndex = 23;
            this.label20.Text = "Alacohol Use";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(528, 162);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 25);
            this.label19.TabIndex = 22;
            this.label19.Text = "Tobacco Use";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(580, 94);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 25);
            this.label18.TabIndex = 21;
            this.label18.Text = "RhType";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(29, 302);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 25);
            this.label17.TabIndex = 20;
            this.label17.Text = "Blood Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 234);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 25);
            this.label16.TabIndex = 19;
            this.label16.Text = "Marital Status";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(112, 100);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 25);
            this.label15.TabIndex = 18;
            this.label15.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 161);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "Patient ID";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(9, 117);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(169, 28);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(16, 251);
            this.patientButton.Margin = new System.Windows.Forms.Padding(4);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(148, 28);
            this.patientButton.TabIndex = 5;
            this.patientButton.Text = "Patient";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // allergyButton
            // 
            this.allergyButton.Location = new System.Drawing.Point(16, 337);
            this.allergyButton.Margin = new System.Windows.Forms.Padding(4);
            this.allergyButton.Name = "allergyButton";
            this.allergyButton.Size = new System.Drawing.Size(148, 28);
            this.allergyButton.TabIndex = 6;
            this.allergyButton.Text = "Allergies";
            this.allergyButton.UseVisualStyleBackColor = true;
            this.allergyButton.Click += new System.EventHandler(this.allergyButton_Click);
            // 
            // generalHealthButton
            // 
            this.generalHealthButton.Location = new System.Drawing.Point(17, 431);
            this.generalHealthButton.Margin = new System.Windows.Forms.Padding(4);
            this.generalHealthButton.Name = "generalHealthButton";
            this.generalHealthButton.Size = new System.Drawing.Size(148, 28);
            this.generalHealthButton.TabIndex = 7;
            this.generalHealthButton.Text = "General Health";
            this.generalHealthButton.UseVisualStyleBackColor = true;
            this.generalHealthButton.Click += new System.EventHandler(this.generalHealthButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Search:";
            // 
            // demographicsTableAdapter
            // 
            this.demographicsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AllergyTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DemographicsTableAdapter = this.demographicsTableAdapter;
            this.tableAdapterManager.GeneralTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GroupFinalProject.PatientDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rhBoxG
            // 
            this.rhBoxG.Location = new System.Drawing.Point(675, 95);
            this.rhBoxG.Margin = new System.Windows.Forms.Padding(4);
            this.rhBoxG.Name = "rhBoxG";
            this.rhBoxG.ReadOnly = true;
            this.rhBoxG.Size = new System.Drawing.Size(253, 22);
            this.rhBoxG.TabIndex = 29;
            // 
            // tobaccoBoxG
            // 
            this.tobaccoBoxG.Location = new System.Drawing.Point(675, 161);
            this.tobaccoBoxG.Margin = new System.Windows.Forms.Padding(4);
            this.tobaccoBoxG.Name = "tobaccoBoxG";
            this.tobaccoBoxG.ReadOnly = true;
            this.tobaccoBoxG.Size = new System.Drawing.Size(253, 22);
            this.tobaccoBoxG.TabIndex = 30;
            // 
            // alacoholBoxG
            // 
            this.alacoholBoxG.Location = new System.Drawing.Point(675, 234);
            this.alacoholBoxG.Margin = new System.Windows.Forms.Padding(4);
            this.alacoholBoxG.Name = "alacoholBoxG";
            this.alacoholBoxG.ReadOnly = true;
            this.alacoholBoxG.Size = new System.Drawing.Size(253, 22);
            this.alacoholBoxG.TabIndex = 31;
            // 
            // drugBoxG
            // 
            this.drugBoxG.Location = new System.Drawing.Point(675, 302);
            this.drugBoxG.Margin = new System.Windows.Forms.Padding(4);
            this.drugBoxG.Name = "drugBoxG";
            this.drugBoxG.ReadOnly = true;
            this.drugBoxG.Size = new System.Drawing.Size(253, 22);
            this.drugBoxG.TabIndex = 32;
            // 
            // modifyBtnA
            // 
            this.modifyBtnA.Location = new System.Drawing.Point(8, 477);
            this.modifyBtnA.Margin = new System.Windows.Forms.Padding(4);
            this.modifyBtnA.Name = "modifyBtnA";
            this.modifyBtnA.Size = new System.Drawing.Size(148, 28);
            this.modifyBtnA.TabIndex = 25;
            this.modifyBtnA.Text = "Modify";
            this.modifyBtnA.UseVisualStyleBackColor = true;
            // 
            // saveBtnA
            // 
            this.saveBtnA.Location = new System.Drawing.Point(803, 473);
            this.saveBtnA.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtnA.Name = "saveBtnA";
            this.saveBtnA.Size = new System.Drawing.Size(148, 28);
            this.saveBtnA.TabIndex = 26;
            this.saveBtnA.Text = "Save";
            this.saveBtnA.UseVisualStyleBackColor = true;
            // 
            // modifyBtnG
            // 
            this.modifyBtnG.Location = new System.Drawing.Point(10, 473);
            this.modifyBtnG.Margin = new System.Windows.Forms.Padding(4);
            this.modifyBtnG.Name = "modifyBtnG";
            this.modifyBtnG.Size = new System.Drawing.Size(148, 28);
            this.modifyBtnG.TabIndex = 33;
            this.modifyBtnG.Text = "Modify";
            this.modifyBtnG.UseVisualStyleBackColor = true;
            // 
            // saveBtnG
            // 
            this.saveBtnG.Location = new System.Drawing.Point(803, 473);
            this.saveBtnG.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtnG.Name = "saveBtnG";
            this.saveBtnG.Size = new System.Drawing.Size(148, 28);
            this.saveBtnG.TabIndex = 34;
            this.saveBtnG.Text = "Save";
            this.saveBtnG.UseVisualStyleBackColor = true;
            // 
            // editPatientBtnA
            // 
            this.editPatientBtnA.Location = new System.Drawing.Point(647, 473);
            this.editPatientBtnA.Margin = new System.Windows.Forms.Padding(4);
            this.editPatientBtnA.Name = "editPatientBtnA";
            this.editPatientBtnA.Size = new System.Drawing.Size(148, 28);
            this.editPatientBtnA.TabIndex = 27;
            this.editPatientBtnA.Text = "Edit Patient";
            this.editPatientBtnA.UseVisualStyleBackColor = true;
            // 
            // editPatientBtnG
            // 
            this.editPatientBtnG.Location = new System.Drawing.Point(647, 473);
            this.editPatientBtnG.Margin = new System.Windows.Forms.Padding(4);
            this.editPatientBtnG.Name = "editPatientBtnG";
            this.editPatientBtnG.Size = new System.Drawing.Size(148, 28);
            this.editPatientBtnG.TabIndex = 35;
            this.editPatientBtnG.Text = "Edit Patient";
            this.editPatientBtnG.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 549);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.generalHealthButton);
            this.Controls.Add(this.allergyButton);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.patientTab.ResumeLayout(false);
            this.patientTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demographicsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demographicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDatabaseDataSet)).EndInit();
            this.allergyTab.ResumeLayout(false);
            this.allergyTab.PerformLayout();
            this.generalHealthTab.ResumeLayout(false);
            this.generalHealthTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage patientTab;
        private System.Windows.Forms.TabPage allergyTab;
        private System.Windows.Forms.TabPage generalHealthTab;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button allergyButton;
        private System.Windows.Forms.Button generalHealthButton;
        private System.Windows.Forms.Button demographEditPatientButton;
        private System.Windows.Forms.Button demographSaveButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox patientIdBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox iDBox;
        private PatientDatabaseDataSet patientDatabaseDataSet;
        private System.Windows.Forms.BindingSource demographicsBindingSource;
        private PatientDatabaseDataSetTableAdapters.DemographicsTableAdapter demographicsTableAdapter;
        private PatientDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView demographicsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button demographEditButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox allergenBoxA;
        private System.Windows.Forms.TextBox patientIDBoxA;
        private System.Windows.Forms.TextBox iDBoxA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox medicationNeedBoxA;
        private System.Windows.Forms.TextBox DateDiscoveredBoxA;
        private System.Windows.Forms.TextBox maritalBoxG;
        private System.Windows.Forms.TextBox patientIDBoxG;
        private System.Windows.Forms.TextBox bloodTypeBoxG;
        private System.Windows.Forms.TextBox iDBoxG;
        private System.Windows.Forms.TextBox drugBoxG;
        private System.Windows.Forms.TextBox alacoholBoxG;
        private System.Windows.Forms.TextBox tobaccoBoxG;
        private System.Windows.Forms.TextBox rhBoxG;
        private System.Windows.Forms.Button saveBtnA;
        private System.Windows.Forms.Button modifyBtnA;
        private System.Windows.Forms.Button saveBtnG;
        private System.Windows.Forms.Button modifyBtnG;
        private System.Windows.Forms.Button editPatientBtnA;
        private System.Windows.Forms.Button editPatientBtnG;
    }
}

