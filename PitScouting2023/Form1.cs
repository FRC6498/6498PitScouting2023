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
        //Filter should only show images
        private const string OFD_FILTER = "All files (*.jfif)|*.jfif";

        public Form1()
        {
            InitializeComponent();
        }

        #region Display Panel Events
        private void btn_Display_Import_Click(object sender, EventArgs e)
        {
            //Set filter
            ofd_Import.Filter = OFD_FILTER;
            //Display the file selection dialog box
            ofd_Import.ShowDialog();
        }

        private void btn_Display_Submit_Click(object sender, EventArgs e)
        {
            //Show dialog box to confirm submission
            sfd_Submit.ShowDialog();
        }

        private void ofd_Import_FileOk(object sender, CancelEventArgs e)
        {
            //Load picture in the picturebox
            pb_Display_Robot.Load(@ofd_Import.FileName);
        }

        /* Checking selected indexes is a bit more robust than checking the text, and tying it to the controls updating
         * rather than a timer should be just slightly more efficient and responsive (Only checking if it changes, rather than constantly checking)
         */
        private void btn_Display_Submit_Validate(object sender, EventArgs e)
        {
            //Button enabled = All required info is filled in | can be broken out into if statement for clarity
            btn_Display_Submit.Enabled = !(string.IsNullOrWhiteSpace(tb_Info_TeamNumber.Text) || cmb_Info_DtMotor.SelectedIndex == -1 || cmb_Info_DtType.SelectedIndex == -1);
        }
        #endregion

        /*
        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            if (tb_Info_TeamNumber.Text == "" || cmb_Info_DtMotor.Text == "Pick One" || cmb_Info_DtType.Text == "Pick One")
            {
                btn_Display_Submit.Enabled = false;
            }
            else
            {
               btn_Display_Submit.Enabled = true;
            }
        }
        */
    }
}