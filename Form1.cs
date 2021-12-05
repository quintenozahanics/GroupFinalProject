using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
