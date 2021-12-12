
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
            this.generalHealthTab = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.allergyButton = new System.Windows.Forms.Button();
            this.generalHealthButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.demographicsTableAdapter = new GroupFinalProject.PatientDatabaseDataSetTableAdapters.DemographicsTableAdapter();
            this.tableAdapterManager = new GroupFinalProject.PatientDatabaseDataSetTableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            this.patientTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demographicsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demographicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(7, 35);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(127, 20);
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
            this.comboBox1.Location = new System.Drawing.Point(7, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.patientTab);
            this.tabControl1.Controls.Add(this.allergyTab);
            this.tabControl1.Controls.Add(this.generalHealthTab);
            this.tabControl1.Location = new System.Drawing.Point(140, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 437);
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
            this.patientTab.Location = new System.Drawing.Point(4, 22);
            this.patientTab.Name = "patientTab";
            this.patientTab.Padding = new System.Windows.Forms.Padding(3);
            this.patientTab.Size = new System.Drawing.Size(717, 411);
            this.patientTab.TabIndex = 0;
            this.patientTab.Text = "Demographics";
            this.patientTab.UseVisualStyleBackColor = true;
            // 
            // demographEditButton
            // 
            this.demographEditButton.Location = new System.Drawing.Point(6, 371);
            this.demographEditButton.Name = "demographEditButton";
            this.demographEditButton.Size = new System.Drawing.Size(111, 23);
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
            this.demographicsDataGridView.Name = "demographicsDataGridView";
            this.demographicsDataGridView.Size = new System.Drawing.Size(716, 114);
            this.demographicsDataGridView.TabIndex = 17;
            this.demographicsDataGridView.SelectionChanged += new System.EventHandler(this.demographicsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PatientID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StreetAddress";
            this.dataGridViewTextBoxColumn5.HeaderText = "StreetAddress";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn6.HeaderText = "City";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn7.HeaderText = "State";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
            this.label7.Location = new System.Drawing.Point(211, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // iDBox
            // 
            this.iDBox.Location = new System.Drawing.Point(243, 131);
            this.iDBox.Name = "iDBox";
            this.iDBox.ReadOnly = true;
            this.iDBox.Size = new System.Drawing.Size(191, 20);
            this.iDBox.TabIndex = 13;
            // 
            // demographSaveButton
            // 
            this.demographSaveButton.Location = new System.Drawing.Point(600, 371);
            this.demographSaveButton.Name = "demographSaveButton";
            this.demographSaveButton.Size = new System.Drawing.Size(111, 23);
            this.demographSaveButton.TabIndex = 9;
            this.demographSaveButton.Text = "Save New Patient";
            this.demographSaveButton.UseVisualStyleBackColor = true;
            this.demographSaveButton.Click += new System.EventHandler(this.demographSaveButton_Click);
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(418, 314);
            this.stateBox.Name = "stateBox";
            this.stateBox.ReadOnly = true;
            this.stateBox.Size = new System.Drawing.Size(226, 20);
            this.stateBox.TabIndex = 11;
            // 
            // demographEditPatientButton
            // 
            this.demographEditPatientButton.Location = new System.Drawing.Point(483, 371);
            this.demographEditPatientButton.Name = "demographEditPatientButton";
            this.demographEditPatientButton.Size = new System.Drawing.Size(111, 23);
            this.demographEditPatientButton.TabIndex = 8;
            this.demographEditPatientButton.Text = "Edit Patient";
            this.demographEditPatientButton.UseVisualStyleBackColor = true;
            this.demographEditPatientButton.Click += new System.EventHandler(this.demographEditPatientButton_Click);
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(418, 242);
            this.cityBox.Name = "cityBox";
            this.cityBox.ReadOnly = true;
            this.cityBox.Size = new System.Drawing.Size(226, 20);
            this.cityBox.TabIndex = 10;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(418, 175);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(226, 20);
            this.addressBox.TabIndex = 9;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(93, 314);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.ReadOnly = true;
            this.firstNameBox.Size = new System.Drawing.Size(191, 20);
            this.firstNameBox.TabIndex = 8;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(93, 242);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.ReadOnly = true;
            this.lastNameBox.Size = new System.Drawing.Size(191, 20);
            this.lastNameBox.TabIndex = 7;
            // 
            // patientIdBox
            // 
            this.patientIdBox.Location = new System.Drawing.Point(93, 174);
            this.patientIdBox.Name = "patientIdBox";
            this.patientIdBox.ReadOnly = true;
            this.patientIdBox.Size = new System.Drawing.Size(191, 20);
            this.patientIdBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Street Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // allergyTab
            // 
            this.allergyTab.Location = new System.Drawing.Point(4, 22);
            this.allergyTab.Name = "allergyTab";
            this.allergyTab.Padding = new System.Windows.Forms.Padding(3);
            this.allergyTab.Size = new System.Drawing.Size(717, 411);
            this.allergyTab.TabIndex = 1;
            this.allergyTab.Text = "Allergies";
            this.allergyTab.UseVisualStyleBackColor = true;
            // 
            // generalHealthTab
            // 
            this.generalHealthTab.Location = new System.Drawing.Point(4, 22);
            this.generalHealthTab.Name = "generalHealthTab";
            this.generalHealthTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalHealthTab.Size = new System.Drawing.Size(717, 411);
            this.generalHealthTab.TabIndex = 2;
            this.generalHealthTab.Text = "General Health";
            this.generalHealthTab.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(7, 95);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(12, 204);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(111, 23);
            this.patientButton.TabIndex = 5;
            this.patientButton.Text = "Patient";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // allergyButton
            // 
            this.allergyButton.Location = new System.Drawing.Point(12, 274);
            this.allergyButton.Name = "allergyButton";
            this.allergyButton.Size = new System.Drawing.Size(111, 23);
            this.allergyButton.TabIndex = 6;
            this.allergyButton.Text = "Allergies";
            this.allergyButton.UseVisualStyleBackColor = true;
            this.allergyButton.Click += new System.EventHandler(this.allergyButton_Click);
            // 
            // generalHealthButton
            // 
            this.generalHealthButton.Location = new System.Drawing.Point(13, 350);
            this.generalHealthButton.Name = "generalHealthButton";
            this.generalHealthButton.Size = new System.Drawing.Size(111, 23);
            this.generalHealthButton.TabIndex = 7;
            this.generalHealthButton.Text = "General Health";
            this.generalHealthButton.UseVisualStyleBackColor = true;
            this.generalHealthButton.Click += new System.EventHandler(this.generalHealthButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 446);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.generalHealthButton);
            this.Controls.Add(this.allergyButton);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchBox);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.patientTab.ResumeLayout(false);
            this.patientTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demographicsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demographicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDatabaseDataSet)).EndInit();
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
    }
}

