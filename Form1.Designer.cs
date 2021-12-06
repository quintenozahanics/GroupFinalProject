
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patientTab = new System.Windows.Forms.TabPage();
            this.allergyTab = new System.Windows.Forms.TabPage();
            this.generalHealthTab = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.allergyButton = new System.Windows.Forms.Button();
            this.generalHealthButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Search by Patient ID",
            "Search by Last Name",
            "Search by Phone Number"});
            this.comboBox1.Location = new System.Drawing.Point(17, 49);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.patientTab);
            this.tabControl1.Controls.Add(this.allergyTab);
            this.tabControl1.Controls.Add(this.generalHealthTab);
            this.tabControl1.Location = new System.Drawing.Point(187, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 538);
            this.tabControl1.TabIndex = 3;
            // 
            // patientTab
            // 
            this.patientTab.Location = new System.Drawing.Point(4, 25);
            this.patientTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientTab.Name = "patientTab";
            this.patientTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientTab.Size = new System.Drawing.Size(869, 509);
            this.patientTab.TabIndex = 0;
            this.patientTab.Text = "Demographics";
            this.patientTab.UseVisualStyleBackColor = true;
            // 
            // allergyTab
            // 
            this.allergyTab.Location = new System.Drawing.Point(4, 25);
            this.allergyTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allergyTab.Name = "allergyTab";
            this.allergyTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allergyTab.Size = new System.Drawing.Size(869, 509);
            this.allergyTab.TabIndex = 1;
            this.allergyTab.Text = "Allergies";
            this.allergyTab.UseVisualStyleBackColor = true;
            // 
            // generalHealthTab
            // 
            this.generalHealthTab.Location = new System.Drawing.Point(4, 25);
            this.generalHealthTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generalHealthTab.Name = "generalHealthTab";
            this.generalHealthTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generalHealthTab.Size = new System.Drawing.Size(869, 509);
            this.generalHealthTab.TabIndex = 2;
            this.generalHealthTab.Text = "General Health";
            this.generalHealthTab.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(17, 84);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(148, 28);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(16, 219);
            this.patientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(148, 28);
            this.patientButton.TabIndex = 5;
            this.patientButton.Text = "Patient";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // allergyButton
            // 
            this.allergyButton.Location = new System.Drawing.Point(17, 255);
            this.allergyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allergyButton.Name = "allergyButton";
            this.allergyButton.Size = new System.Drawing.Size(148, 28);
            this.allergyButton.TabIndex = 6;
            this.allergyButton.Text = "Allergies";
            this.allergyButton.UseVisualStyleBackColor = true;
            this.allergyButton.Click += new System.EventHandler(this.allergyButton_Click);
            // 
            // generalHealthButton
            // 
            this.generalHealthButton.Location = new System.Drawing.Point(17, 290);
            this.generalHealthButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generalHealthButton.Name = "generalHealthButton";
            this.generalHealthButton.Size = new System.Drawing.Size(148, 28);
            this.generalHealthButton.TabIndex = 7;
            this.generalHealthButton.Text = "General Health";
            this.generalHealthButton.UseVisualStyleBackColor = true;
            this.generalHealthButton.Click += new System.EventHandler(this.generalHealthButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(17, 465);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(148, 28);
            this.modifyButton.TabIndex = 8;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(17, 511);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 28);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.generalHealthButton);
            this.Controls.Add(this.allergyButton);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Patient";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage patientTab;
        private System.Windows.Forms.TabPage allergyTab;
        private System.Windows.Forms.TabPage generalHealthTab;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button allergyButton;
        private System.Windows.Forms.Button generalHealthButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button saveButton;
    }
}

