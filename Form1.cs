using System;
using System.Data;
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

        //search bar control //search bar control //search bar control //search bar control //search bar control
        private void searchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < demographicsDataGridView.Rows.Count; i++)
            {
                if (!demographicsDataGridView.Rows[i].IsNewRow)
                {
                    if (demographicsDataGridView[0, i].Value.ToString() == searchBox.Text)
                        demographicsDataGridView.Rows[i].Selected = true;
                    else
                        demographicsDataGridView.Rows[i].Selected = false;
                }
            }
        }

// Demographics Control // Demographics Control // DemoGraphics Control // Demographics Control
        private void demographicsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.demographicsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientDatabaseDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDatabaseDataSet.General' table. You can move, or remove it, as needed.
            this.generalTableAdapter.Fill(this.patientDatabaseDataSet.General);
            // TODO: This line of code loads data into the 'patientDatabaseDataSet.Allergy' table. You can move, or remove it, as needed.
            this.allergyTableAdapter.Fill(this.patientDatabaseDataSet.Allergy);
            // TODO: This line of code loads data into the 'patientDatabaseDataSet.Demographics' table. You can move, or remove it, as needed.
            this.demographicsTableAdapter.Fill(this.patientDatabaseDataSet.Demographics);
        }

        private void demographEditButton_Click(object sender, EventArgs e)
        {
            iDBox.ReadOnly = false;
            patientIdBox.ReadOnly = false;
            lastNameBox.ReadOnly = false;
            firstNameBox.ReadOnly = false;
            addressBox.ReadOnly = false;
            cityBox.ReadOnly = false;
            stateBox.ReadOnly = false;
        }

        private void demographSaveButton_Click(object sender, EventArgs e)
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

        private void demographEditPatientButton_Click(object sender, EventArgs e)
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

        private void demographicsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in demographicsDataGridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }

            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                iDBox.Text = row.Cells[0].Value.ToString();
                patientIdBox.Text = row.Cells[1].Value.ToString();
                lastNameBox.Text = row.Cells[3].Value.ToString();
                firstNameBox.Text = row.Cells[2].Value.ToString();
                addressBox.Text = row.Cells[4].Value.ToString();
                cityBox.Text = row.Cells[5].Value.ToString();
                stateBox.Text = row.Cells[6].Value.ToString();
            }
        }

//Allergy Tab Control //Allergy Tab Control //Allergy Tab Control //Allergy Tab Control //Allergy Tab Control
        
        private void iDBox_TextChanged(object sender, EventArgs e)
        {
            iDBoxA.Text = iDBox.Text;
            iDBoxG.Text = iDBox.Text;

            Namelabel1.Visible = true;
            Namelabel1.Text = firstNameBox.Text +" "+ lastNameBox.Text;
            
            namelabel2.Visible = true;
            namelabel2.Text = firstNameBox.Text + " " + lastNameBox.Text;
        }

        private void iDBoxA_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < allergyDataGridView.Rows.Count; i++)
            {
                if (!allergyDataGridView.Rows[i].IsNewRow)
                {
                    if (allergyDataGridView[0, i].Value.ToString() == iDBoxA.Text)
                        allergyDataGridView.Rows[i].Selected = true;
                    else
                        allergyDataGridView.Rows[i].Selected = false;
                }
            }
        }

        private void allergyDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in allergyDataGridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }

            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                patientIDBoxA.Text = row.Cells[1].Value.ToString();
                allergenBoxA.Text = row.Cells[2].Value.ToString();
                //allergenDateTimePicker.Value = row.Cells[3].Value.ToString();
                medicationNeedBoxA.Text = row.Cells[4].Value.ToString();
            }
        }
        
        private void modifyBtnA_Click(object sender, EventArgs e)
        {
            iDBoxA.ReadOnly = false;
            patientIDBoxA.ReadOnly = false;
            allergenBoxA.ReadOnly = false;
            medicationNeedBoxA.ReadOnly = false;
        }

        private void editAllergenBtnA_Click(object sender, EventArgs e)
        {

        }

//General Health Controls //General Health Controls //General Health Controls //General Health Controls //General Health Controls
        private void iDBoxG_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < generalDataGridView.Rows.Count; i++)
            {
                if (!generalDataGridView.Rows[i].IsNewRow)
                {
                    if (generalDataGridView[0, i].Value.ToString() == iDBoxA.Text)
                        generalDataGridView.Rows[i].Selected = true;
                    else
                        generalDataGridView.Rows[i].Selected = false;
                }
            }
        }

        private void generalDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in generalDataGridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }

            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                patientIDBoxG.Text = row.Cells[1].Value.ToString();
                maritalBoxG.Text = row.Cells[2].Value.ToString();
                bloodTypeBoxG.Text = row.Cells[3].Value.ToString();
                rhBoxG.Text = row.Cells[4].Value.ToString();
                tobaccoBoxG.Text = row.Cells[5].Value.ToString();
                alacoholBoxG.Text = row.Cells[6].Value.ToString();
                drugBoxG.Text = row.Cells[7].Value.ToString();
            }
        }

        private void modifyBtnG_Click(object sender, EventArgs e)
        {
            patientIDBoxG.ReadOnly = false;
            maritalBoxG.ReadOnly = false;
            bloodTypeBoxG.ReadOnly = false;
            rhBoxG.ReadOnly = false;
            tobaccoBoxG.ReadOnly = false;
            drugBoxG.ReadOnly = false;
        }

        private void saveBtnG_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into General (ID, PatientID, MaritalStatus, BloodType, RhType, TobaccoUse, AlcoholUse, Drugs)" +
                    " values('" + iDBoxG.Text + "','" + patientIDBoxG.Text + "','" + maritalBoxG.Text + "','" + bloodTypeBoxG.Text + "','" + rhBoxG.Text + "','" + tobaccoBoxG.Text + "','" + alacoholBoxG.Text + "','" + drugBoxG.Text +"')";

                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
