using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PitScouting2023
{
    public partial class Form1 : Form
    {
        #region Variables
        bool allNums;
        #region TextInput
        public int TeamNumber;
        #endregion
        #region Combo Boxes
        public static string DriveType;
        public static string DriveMotors;
        public static string AutoCharge;
        public static string Score;
        public static string TeleCharge;
        #endregion
        #region Check boxes
        public static bool PrePieces;
        public static bool Floor;
        public static bool Leave;
        public static bool ScorePieces;
        public static bool High;
        public static bool Mid;
        public static bool Low;
        public static bool IntakeFloor;
        public static bool IntakeShelf;
        public static bool AiAssistance;
        public static bool LEDs;
        #endregion
        #region Lists
        public List<bool> Bools = new List<bool>
        {
            PrePieces,
            Floor,
            Leave,
            ScorePieces,
            High,
            Mid,
            Low,
            IntakeFloor,
            IntakeShelf,
            AiAssistance,
            LEDs
        };
        public List<string> strings = new List<string>
        {
            DriveType,
            DriveMotors,
            AutoCharge,
            Score,
            TeleCharge
        };
        public List<CheckBox> Checks = new List<CheckBox>();
        public List<ComboBox> Combos = new List<ComboBox>();
        public List<TextBox> Notes = new List<TextBox>();
        #endregion
        #region Notes
        public string AutoNotes;
        public string TeleNotes;
        public string OtherNotes;
        #endregion
        #region Image
        #region image array
        #endregion
        public Image Bot;
        #endregion
        #endregion

        //Filter should only show images
        private const string OFD_FILTER = "Image Files (.jpeg, .bmp, .png, .jfif) |*.jpg;*.bmp;*.png;*.jfif";
        //create Random because why not
        Random Rnd = new Random();
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
            CreatePDF();
            //Show dialog box to confirm submission
            //sfd_Submit.ShowDialog();
            #region Reset Inputs
            for (int i = 0; i < Checks.Count; i++)
            {
                Checks[i].Checked = false;
            }
            for (int i = 0; i < Combos.Count; i++)
            {
                Combos[i].SelectedIndex = -1;
            }
            for (int i = 0; i < Notes.Count; i++)
            {
                Notes[i].Text = string.Empty;
            }
            pb_Display_Robot.Image = null;
            #endregion
            #region Reset Variables
            for (int i = 0; i < Bools.Count; i++)
            {
                Bools[i] = false;
            }
            for (int i = 0; i < strings.Count; i++)
            {
                strings[i] = "";
            }
            #endregion
            RandomWindow();
        }
        public void EditorResponse(string fileName, string word, string replacement, string saveFileName)
        {
            StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + fileName);
            string input = reader.ReadToEnd();
        }
        public void CreatePDF()
        {
            // Create a new PDF document
            PdfDocument pdfDocument = new PdfDocument();
            // Create an empty page
            PdfPage pdfPage = pdfDocument.AddPage();
            // Get an XGraphics object for drawing
            XGraphics xGraphics = XGraphics.FromPdfPage(pdfPage);
            // Create a font
            XFont xFont = new XFont("Verdana", 20, XFontStyle.BoldItalic);
            // Draw the text
            xGraphics.DrawString("File Format Developer Guide", xFont, XBrushes.Black, new XRect(0, 0, pdfPage.Width, pdfPage.Height), XStringFormats.Center);
            // Save the document...
            pdfDocument.Save("fileformat.pdf");
        }
        public void AnnotatePdf()
        {
            // Create a PDF text annotation
            PdfTextAnnotation textAnnot = new PdfTextAnnotation();
            textAnnot.Title = "This is the title";
            textAnnot.Subject = "This is the subject";
            textAnnot.Contents = "This is the contents of the annotation.\rThis is the 2nd line.";
            textAnnot.Icon = PdfTextAnnotationIcon.Note;

        }
        private void valueChange_updae(object sender, EventArgs e)
        {

        }
        private void Import()
        {
            //defines the doc
            PdfSharp.Pdf.PdfDocument PDFDoc = new PdfSharp.Pdf.PdfDocument("testFile.pdf");
            //define new doc
            PdfSharp.Pdf.PdfDocument PDFNewDoc = new PdfSharp.Pdf.PdfDocument();
            for (int Pg = 0; Pg < PDFDoc.Pages.Count; Pg++)
            {
                //add page
                PDFNewDoc.AddPage(PDFDoc.Pages[Pg]);
            }
            //save Doc
            PDFNewDoc.Save("resultFile.PDF");
        }
        public static bool ContainsSubPath(string pathToFile, string subPath)
        {
            // Define Main-Path
            pathToFile = Path.GetDirectoryName(pathToFile) + "\\";
            // Define Target-Path
            string searchPath = Path.GetDirectoryName(subPath) + "\\";
            // See if there is a match
            bool containsIt = pathToFile.IndexOf(searchPath, StringComparison.OrdinalIgnoreCase) > -1;
            // Return results
            return containsIt;
        }
        private void ofd_Import_FileOk(object sender, CancelEventArgs e)
        {
            //Load picture in the picturebox
            pb_Display_Robot.Load(@ofd_Import.FileName);
            // Force Check
            btn_Display_Submit_Validate(sender, e);
        }

        /* Checking selected indexes is a bit more robust than checking the text, and tying it to the controls updating
         * rather than a timer should be just slightly more efficient and responsive (Only checking if it changes, rather than constantly checking)
         */
        private void btn_Display_Submit_Validate(object sender, EventArgs e)// this is tied to the team number text box for some reason
        {
            //Button enabled = All required info is filled in | can be broken out into if statement for clarity
            allNums = true;
            try
            {
                // See if only contains digets (ie; [0-9])
                Convert.ToInt64(txt_Info_TeamNumber.Text);
            }
            catch
            {
                // Set to false if catches an error
                allNums = false;
            }
            // Check if all requirements are met
            btn_Display_Submit.Enabled = (allNums && !(string.IsNullOrWhiteSpace(txt_Info_TeamNumber.Text) || cmb_Info_DtMotor.SelectedIndex == -1 || cmb_Info_DtType.SelectedIndex == -1 || cmb_Auto_Station.SelectedIndex == -1 || cmb_TeleOp_Station.SelectedIndex == -1 || pb_Display_Robot.Image == null));
        }
        #endregion

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            #region Update Variables
            if (txt_Info_TeamNumber.Text != null && txt_Info_TeamNumber.Text != "")
            {
                TeamNumber = (Convert.ToInt16(txt_Info_TeamNumber.Text));
            }
            #region Notes
            if (txt_Auto_Notes.Text != null && txt_Auto_Notes.Text != "")
            {
                AutoNotes = txt_Auto_Notes.Text;
            }
            if (txt_TeleOp_Notes.Text != null && txt_TeleOp_Notes.Text != "")
            {
                TeleNotes = txt_TeleOp_Notes.Text;
            }
            if (txt_OtherInfo_Notes.Text != null && txt_OtherInfo_Notes.Text != "")
            {
                OtherNotes = txt_Auto_Notes.Text;
            }
            #endregion
            #region bools from check boxes
            Leave = ckb_Auto_Community.Checked;
            Floor = ckb_Auto_Floor.Checked;
            PrePieces = ckb_Auto_Preloaded.Checked;
            ScorePieces = ckb_TeleOp_Pieces.Checked;
            High = ckb_TeleOp_High.Checked;
            Mid = ckb_TeleOp_Mid.Checked;
            Low = ckb_TeleOp_Low.Checked;
            IntakeFloor = ckb_TeleOp_InFloor.Checked;
            IntakeShelf = ckb_TeleOp_InShelf.Checked;
            AiAssistance = ckb_OtherInfo_AI.Checked;
            LEDs = ckb_OtherInfo_LEDs.Checked;
            #endregion
            #region String from Combo Boxes
            DriveType = cmb_Info_DtType.SelectedItem.ToString();
            DriveMotors = cmb_Info_DtMotor.SelectedItem.ToString();
            AutoCharge = cmb_Auto_Station.SelectedItem.ToString();
            TeleCharge = cmb_TeleOp_Station.SelectedItem.ToString();
            #endregion
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Populate Check box List
            Checks.Add((CheckBox)ckb_Auto_Community);
            Checks.Add((CheckBox)ckb_Auto_Preloaded);
            Checks.Add((CheckBox)ckb_OtherInfo_AI);
            Checks.Add((CheckBox)ckb_OtherInfo_LEDs);
            Checks.Add((CheckBox)ckb_TeleOp_High);
            Checks.Add((CheckBox)ckb_TeleOp_InFloor);
            Checks.Add((CheckBox)ckb_TeleOp_InShelf);
            Checks.Add((CheckBox)ckb_TeleOp_Low);
            Checks.Add((CheckBox)ckb_TeleOp_Mid);
            Checks.Add((CheckBox)ckb_TeleOp_Pieces);
            Checks.Add((CheckBox)ckb_Auto_Floor);
            #endregion
            #region Populate Combo Box List
            Combos.Add((ComboBox)cmb_Auto_Station);
            Combos.Add((ComboBox)cmb_Info_DtMotor);
            Combos.Add((ComboBox)cmb_Info_DtType);
            Combos.Add((ComboBox)cmb_TeleOp_Station);
            #endregion
            #region Populate Notes List
            Notes.Add((TextBox)txt_Auto_Notes);
            Notes.Add((TextBox)txt_Info_TeamNumber);
            Notes.Add((TextBox)txt_OtherInfo_Notes);
            Notes.Add((TextBox)txt_TeleOp_Notes);
            #endregion
            RandomWindow();
        }
        public void RandomWindow()
        {
            #region put window in random spot >:)
            //int max x = (desktop screen size) - this.size
            this.Location = new System.Drawing.Point(Rnd.Next(420), Rnd.Next(180));
            #endregion
        }

        private void cmb_Auto_Station_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Force Check
            btn_Display_Submit_Validate(sender, e);
        }

        private void cmb_TeleOp_Station_SelectedValueChanged(object sender, EventArgs e)
        {
            // Force Check
            btn_Display_Submit_Validate(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Info_TeamNumber.Text = Rnd.Next(1000000).ToString("00000");
            String Image = "C:\\Users\\FRC6498\\Desktop\\OIP.jfif";
            pb_Display_Robot.Load(@Image);
            cmb_Auto_Station.SelectedIndex= Rnd.Next(cmb_Auto_Station.Items.Count);
            cmb_Info_DtMotor.SelectedIndex= Rnd.Next(cmb_Info_DtMotor.Items.Count);
            cmb_Info_DtType.SelectedIndex=Rnd.Next(cmb_Info_DtType.Items.Count);
            cmb_TeleOp_Station.SelectedIndex=Rnd.Next(cmb_TeleOp_Station.Items.Count);
            for(int i = 0; i < Checks.Count; i++)
            {
                if (Rnd.Next(2) == 1)
                {
                    Checks[i].Checked = true;
                }
                else
                {
                    Checks[i].Checked = false;
                }
            }
            // Force Check
            btn_Display_Submit_Validate(sender, e);
        }
    }
}