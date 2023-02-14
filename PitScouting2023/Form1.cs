using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PitScouting2023
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)//btnImport
        {
            ofd_Import.Filter = "All files (*.jfif)|*.jfif";
            ofd_Import.ShowDialog();
           // (.jfif)
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//btnSubmit
        {
            sfd_Submit.ShowDialog();
        }

        private void ofd_Import_FileOk(object sender, CancelEventArgs e)
        {
            pbRobot.Load(@ofd_Import.FileName);
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            if (txtNumber.Text == "" || cmbMotor.Text == "Pick One" || cmbType.Text == "Pick One")
            {
                button1.Enabled = false;
            }
            else
            {
               button1.Enabled = true;
            }
        }

        private void cmb_TeleCharge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}