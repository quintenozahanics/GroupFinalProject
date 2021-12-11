using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GroupFinalProject
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\qozahani\\source\\repos\\quintenozahanics\\GroupFinalProject\\PatientDatabase.accdb";
        }

        //Make the buttons open different tabs
        private void patientButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("patientTab");
        }
        private void allergyButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("allergyTab");
        }
        private void generalHealthButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("generalHealthTab");
        }

        /// Demographics Control /// Demographics Control /// DemoGraphics Control /// Demographics Control
        private void demographicsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.demographicsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDatabaseDataSet.Demographics' table. You can move, or remove it, as needed.
            this.demographicsTableAdapter.Fill(this.patientDatabaseDataSet.Demographics);

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            iDBox.ReadOnly = false;
            patientIdBox.ReadOnly = false;
            lastNameBox.ReadOnly = false;
            firstNameBox.ReadOnly = false;
            addressBox.ReadOnly = false;
            cityBox.ReadOnly = false;
            stateBox.ReadOnly = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Demographics (ID, PatientID, LastName, FirstName, StreetAddress, City, State)" +
                    " values('" + iDBox.Text + "','" + patientIdBox.Text + "','" + lastNameBox.Text + "','" + firstNameBox.Text + "','" + addressBox.Text + "','" + cityBox.Text + "','" + stateBox.Text + "')";

                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Demographics set PatientID = '" + patientIdBox.Text + "', LastName = '" + lastNameBox.Text + "', FirstName = '" + firstNameBox.Text + "', StreetAddress = '" + addressBox.Text + "', City = '" + cityBox.Text + "', State = '" + stateBox.Text +"' where ID = " + iDBox.Text+"";
                MessageBox.Show(query);
                command.CommandText =query;
                   

                command.ExecuteNonQuery();
                MessageBox.Show("Data Edit Successful");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }   
    }
}
