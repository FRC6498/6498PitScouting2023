namespace PitScouting2023
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
            this.lbl_Info_TeamNumber = new System.Windows.Forms.Label();
            this.lbl_Info_DtType = new System.Windows.Forms.Label();
            this.lbl_Info_DtMotor = new System.Windows.Forms.Label();
            this.txt_Info_TeamNumber = new System.Windows.Forms.TextBox();
            this.cmb_Info_DtMotor = new System.Windows.Forms.ComboBox();
            this.cmb_Info_DtType = new System.Windows.Forms.ComboBox();
            this.btn_Display_Import = new System.Windows.Forms.Button();
            this.pb_Display_Robot = new System.Windows.Forms.PictureBox();
            this.pnl_Auto = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Auto_Name = new System.Windows.Forms.Label();
            this.ckb_Auto_Preloaded = new System.Windows.Forms.CheckBox();
            this.ckb_Auto_Floor = new System.Windows.Forms.CheckBox();
            this.ckb_Auto_Community = new System.Windows.Forms.CheckBox();
            this.lbl_Auto_Station = new System.Windows.Forms.Label();
            this.cmb_Auto_Station = new System.Windows.Forms.ComboBox();
            this.lbl_Auto_Notes = new System.Windows.Forms.Label();
            this.txt_Auto_Notes = new System.Windows.Forms.TextBox();
            this.pnl_TeleOp = new System.Windows.Forms.Panel();
            this.lbl_TeleOp_Name = new System.Windows.Forms.Label();
            this.ckb_TeleOp_Pieces = new System.Windows.Forms.CheckBox();
            this.lbl_TeleOp_Station = new System.Windows.Forms.Label();
            this.cmb_TeleOp_Station = new System.Windows.Forms.ComboBox();
            this.lbl_TeleOp_Scores = new System.Windows.Forms.Label();
            this.ckb_TeleOp_High = new System.Windows.Forms.CheckBox();
            this.ckb_TeleOp_Mid = new System.Windows.Forms.CheckBox();
            this.ckb_TeleOp_Low = new System.Windows.Forms.CheckBox();
            this.lbl_TeleOp_Intake = new System.Windows.Forms.Label();
            this.ckb_TeleOp_InFloor = new System.Windows.Forms.CheckBox();
            this.ckb_TeleOp_InShelf = new System.Windows.Forms.CheckBox();
            this.lbl_TeleOp_Notes = new System.Windows.Forms.Label();
            this.txt_TeleOp_Notes = new System.Windows.Forms.TextBox();
            this.pnl_OtherInfo = new System.Windows.Forms.Panel();
            this.lbl_OtherInfo_Name = new System.Windows.Forms.Label();
            this.ckb_OtherInfo_AI = new System.Windows.Forms.CheckBox();
            this.ckb_OtherInfo_LEDs = new System.Windows.Forms.CheckBox();
            this.lbl_OtherInfo_Notes = new System.Windows.Forms.Label();
            this.txt_OtherInfo_Notes = new System.Windows.Forms.TextBox();
            this.btn_Display_Submit = new System.Windows.Forms.Button();
            this.ofd_Import = new System.Windows.Forms.OpenFileDialog();
            this.sfd_Submit = new System.Windows.Forms.SaveFileDialog();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.pnl_Display = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Display_Robot)).BeginInit();
            this.pnl_Auto.SuspendLayout();
            this.pnl_TeleOp.SuspendLayout();
            this.pnl_OtherInfo.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            this.pnl_Display.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Info_TeamNumber
            // 
            this.lbl_Info_TeamNumber.AutoSize = true;
            this.lbl_Info_TeamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info_TeamNumber.Location = new System.Drawing.Point(7, 10);
            this.lbl_Info_TeamNumber.Name = "lbl_Info_TeamNumber";
            this.lbl_Info_TeamNumber.Size = new System.Drawing.Size(243, 39);
            this.lbl_Info_TeamNumber.TabIndex = 0;
            this.lbl_Info_TeamNumber.Text = "Team Number:";
            // 
            // lbl_Info_DtType
            // 
            this.lbl_Info_DtType.AutoSize = true;
            this.lbl_Info_DtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info_DtType.Location = new System.Drawing.Point(7, 66);
            this.lbl_Info_DtType.Name = "lbl_Info_DtType";
            this.lbl_Info_DtType.Size = new System.Drawing.Size(257, 39);
            this.lbl_Info_DtType.TabIndex = 1;
            this.lbl_Info_DtType.Text = "Drivetrain Type:";
            // 
            // lbl_Info_DtMotor
            // 
            this.lbl_Info_DtMotor.AutoSize = true;
            this.lbl_Info_DtMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info_DtMotor.Location = new System.Drawing.Point(7, 118);
            this.lbl_Info_DtMotor.Name = "lbl_Info_DtMotor";
            this.lbl_Info_DtMotor.Size = new System.Drawing.Size(267, 39);
            this.lbl_Info_DtMotor.TabIndex = 2;
            this.lbl_Info_DtMotor.Text = "Drivetrain Motor:";
            // 
            // txt_Info_TeamNumber
            // 
            this.txt_Info_TeamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Info_TeamNumber.Location = new System.Drawing.Point(293, 10);
            this.txt_Info_TeamNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Info_TeamNumber.Name = "txt_Info_TeamNumber";
            this.txt_Info_TeamNumber.Size = new System.Drawing.Size(121, 41);
            this.txt_Info_TeamNumber.TabIndex = 3;
            this.txt_Info_TeamNumber.TextChanged += new System.EventHandler(this.btn_Display_Submit_Validate);
            // 
            // cmb_Info_DtMotor
            // 
            this.cmb_Info_DtMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Info_DtMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Info_DtMotor.FormattingEnabled = true;
            this.cmb_Info_DtMotor.Items.AddRange(new object[] {
            "Red Line",
            "Falcon",
            "Neo",
            "CIM",
            "Other"});
            this.cmb_Info_DtMotor.Location = new System.Drawing.Point(293, 114);
            this.cmb_Info_DtMotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Info_DtMotor.Name = "cmb_Info_DtMotor";
            this.cmb_Info_DtMotor.Size = new System.Drawing.Size(188, 44);
            this.cmb_Info_DtMotor.TabIndex = 4;
            this.cmb_Info_DtMotor.SelectedIndexChanged += new System.EventHandler(this.btn_Display_Submit_Validate);
            // 
            // cmb_Info_DtType
            // 
            this.cmb_Info_DtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Info_DtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Info_DtType.FormattingEnabled = true;
            this.cmb_Info_DtType.Items.AddRange(new object[] {
            "Tank",
            "Swerve",
            "Omniwheel",
            "Mechanum",
            "ETC."});
            this.cmb_Info_DtType.Location = new System.Drawing.Point(293, 58);
            this.cmb_Info_DtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Info_DtType.Name = "cmb_Info_DtType";
            this.cmb_Info_DtType.Size = new System.Drawing.Size(187, 44);
            this.cmb_Info_DtType.TabIndex = 5;
            this.cmb_Info_DtType.SelectedIndexChanged += new System.EventHandler(this.btn_Display_Submit_Validate);
            // 
            // btn_Display_Import
            // 
            this.btn_Display_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Display_Import.Location = new System.Drawing.Point(3, 2);
            this.btn_Display_Import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Display_Import.Name = "btn_Display_Import";
            this.btn_Display_Import.Size = new System.Drawing.Size(216, 112);
            this.btn_Display_Import.TabIndex = 6;
            this.btn_Display_Import.Text = "Import";
            this.btn_Display_Import.UseVisualStyleBackColor = true;
            this.btn_Display_Import.Click += new System.EventHandler(this.btn_Display_Import_Click);
            // 
            // pb_Display_Robot
            // 
            this.pb_Display_Robot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_Display_Robot.Location = new System.Drawing.Point(223, 2);
            this.pb_Display_Robot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Display_Robot.Name = "pb_Display_Robot";
            this.pb_Display_Robot.Size = new System.Drawing.Size(251, 250);
            this.pb_Display_Robot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Display_Robot.TabIndex = 7;
            this.pb_Display_Robot.TabStop = false;
            // 
            // pnl_Auto
            // 
            this.pnl_Auto.Controls.Add(this.button1);
            this.pnl_Auto.Controls.Add(this.lbl_Auto_Name);
            this.pnl_Auto.Controls.Add(this.ckb_Auto_Preloaded);
            this.pnl_Auto.Controls.Add(this.ckb_Auto_Floor);
            this.pnl_Auto.Controls.Add(this.ckb_Auto_Community);
            this.pnl_Auto.Controls.Add(this.lbl_Auto_Station);
            this.pnl_Auto.Controls.Add(this.cmb_Auto_Station);
            this.pnl_Auto.Controls.Add(this.lbl_Auto_Notes);
            this.pnl_Auto.Controls.Add(this.txt_Auto_Notes);
            this.pnl_Auto.Location = new System.Drawing.Point(12, 183);
            this.pnl_Auto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Auto.Name = "pnl_Auto";
            this.pnl_Auto.Size = new System.Drawing.Size(485, 558);
            this.pnl_Auto.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Use Random Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Auto_Name
            // 
            this.lbl_Auto_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Auto_Name.AutoSize = true;
            this.lbl_Auto_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Auto_Name.Location = new System.Drawing.Point(5, 21);
            this.lbl_Auto_Name.Name = "lbl_Auto_Name";
            this.lbl_Auto_Name.Size = new System.Drawing.Size(106, 48);
            this.lbl_Auto_Name.TabIndex = 11;
            this.lbl_Auto_Name.Text = "Auto";
            this.lbl_Auto_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckb_Auto_Preloaded
            // 
            this.ckb_Auto_Preloaded.AutoSize = true;
            this.ckb_Auto_Preloaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Auto_Preloaded.Location = new System.Drawing.Point(12, 71);
            this.ckb_Auto_Preloaded.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_Auto_Preloaded.Name = "ckb_Auto_Preloaded";
            this.ckb_Auto_Preloaded.Size = new System.Drawing.Size(390, 41);
            this.ckb_Auto_Preloaded.TabIndex = 15;
            this.ckb_Auto_Preloaded.Text = "Score preloaded pieces?";
            this.ckb_Auto_Preloaded.UseVisualStyleBackColor = true;
            // 
            // ckb_Auto_Floor
            // 
            this.ckb_Auto_Floor.AutoSize = true;
            this.ckb_Auto_Floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Auto_Floor.Location = new System.Drawing.Point(12, 112);
            this.ckb_Auto_Floor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_Auto_Floor.Name = "ckb_Auto_Floor";
            this.ckb_Auto_Floor.Size = new System.Drawing.Size(385, 41);
            this.ckb_Auto_Floor.TabIndex = 16;
            this.ckb_Auto_Floor.Text = "Score pieces from floor?";
            this.ckb_Auto_Floor.UseVisualStyleBackColor = true;
            // 
            // ckb_Auto_Community
            // 
            this.ckb_Auto_Community.AutoSize = true;
            this.ckb_Auto_Community.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Auto_Community.Location = new System.Drawing.Point(12, 156);
            this.ckb_Auto_Community.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_Auto_Community.Name = "ckb_Auto_Community";
            this.ckb_Auto_Community.Size = new System.Drawing.Size(422, 41);
            this.ckb_Auto_Community.TabIndex = 17;
            this.ckb_Auto_Community.Text = "Can leave the Community?";
            this.ckb_Auto_Community.UseVisualStyleBackColor = true;
            // 
            // lbl_Auto_Station
            // 
            this.lbl_Auto_Station.AutoSize = true;
            this.lbl_Auto_Station.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Auto_Station.Location = new System.Drawing.Point(5, 197);
            this.lbl_Auto_Station.Name = "lbl_Auto_Station";
            this.lbl_Auto_Station.Size = new System.Drawing.Size(274, 39);
            this.lbl_Auto_Station.TabIndex = 11;
            this.lbl_Auto_Station.Text = "Charging station:";
            // 
            // cmb_Auto_Station
            // 
            this.cmb_Auto_Station.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Auto_Station.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Auto_Station.FormattingEnabled = true;
            this.cmb_Auto_Station.Items.AddRange(new object[] {
            "Not Docked",
            "Docked !& Engaged",
            "Docked && Engaged"});
            this.cmb_Auto_Station.Location = new System.Drawing.Point(9, 239);
            this.cmb_Auto_Station.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Auto_Station.Name = "cmb_Auto_Station";
            this.cmb_Auto_Station.Size = new System.Drawing.Size(467, 46);
            this.cmb_Auto_Station.TabIndex = 11;
            this.cmb_Auto_Station.SelectedIndexChanged += new System.EventHandler(this.cmb_Auto_Station_SelectedIndexChanged);
            // 
            // lbl_Auto_Notes
            // 
            this.lbl_Auto_Notes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Auto_Notes.AutoSize = true;
            this.lbl_Auto_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Auto_Notes.Location = new System.Drawing.Point(5, 303);
            this.lbl_Auto_Notes.Name = "lbl_Auto_Notes";
            this.lbl_Auto_Notes.Size = new System.Drawing.Size(238, 48);
            this.lbl_Auto_Notes.TabIndex = 13;
            this.lbl_Auto_Notes.Text = "Auto Notes:";
            this.lbl_Auto_Notes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Auto_Notes
            // 
            this.txt_Auto_Notes.Location = new System.Drawing.Point(3, 354);
            this.txt_Auto_Notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Auto_Notes.Multiline = true;
            this.txt_Auto_Notes.Name = "txt_Auto_Notes";
            this.txt_Auto_Notes.Size = new System.Drawing.Size(477, 200);
            this.txt_Auto_Notes.TabIndex = 14;
            // 
            // pnl_TeleOp
            // 
            this.pnl_TeleOp.Controls.Add(this.lbl_TeleOp_Name);
            this.pnl_TeleOp.Controls.Add(this.ckb_TeleOp_Pieces);
            this.pnl_TeleOp.Controls.Add(this.lbl_TeleOp_Station);
            this.pnl_TeleOp.Controls.Add(this.cmb_TeleOp_Station);
            this.pnl_TeleOp.Controls.Add(this.lbl_TeleOp_Scores);
            this.pnl_TeleOp.Controls.Add(this.ckb_TeleOp_High);
            this.pnl_TeleOp.Controls.Add(this.ckb_TeleOp_Mid);
            this.pnl_TeleOp.Controls.Add(this.ckb_TeleOp_Low);
            this.pnl_TeleOp.Controls.Add(this.lbl_TeleOp_Intake);
            this.pnl_TeleOp.Controls.Add(this.ckb_TeleOp_InFloor);
            this.pnl_TeleOp.Controls.Add(this.ckb_TeleOp_InShelf);
            this.pnl_TeleOp.Controls.Add(this.lbl_TeleOp_Notes);
            this.pnl_TeleOp.Controls.Add(this.txt_TeleOp_Notes);
            this.pnl_TeleOp.Location = new System.Drawing.Point(503, 6);
            this.pnl_TeleOp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_TeleOp.Name = "pnl_TeleOp";
            this.pnl_TeleOp.Size = new System.Drawing.Size(485, 735);
            this.pnl_TeleOp.TabIndex = 9;
            // 
            // lbl_TeleOp_Name
            // 
            this.lbl_TeleOp_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeleOp_Name.AutoSize = true;
            this.lbl_TeleOp_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeleOp_Name.Location = new System.Drawing.Point(11, 7);
            this.lbl_TeleOp_Name.Name = "lbl_TeleOp_Name";
            this.lbl_TeleOp_Name.Size = new System.Drawing.Size(172, 48);
            this.lbl_TeleOp_Name.TabIndex = 12;
            this.lbl_TeleOp_Name.Text = "Tele-Op";
            this.lbl_TeleOp_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckb_TeleOp_Pieces
            // 
            this.ckb_TeleOp_Pieces.AutoSize = true;
            this.ckb_TeleOp_Pieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_TeleOp_Pieces.Location = new System.Drawing.Point(91, 80);
            this.ckb_TeleOp_Pieces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_TeleOp_Pieces.Name = "ckb_TeleOp_Pieces";
            this.ckb_TeleOp_Pieces.Size = new System.Drawing.Size(255, 43);
            this.ckb_TeleOp_Pieces.TabIndex = 13;
            this.ckb_TeleOp_Pieces.Text = "Score pieces?";
            this.ckb_TeleOp_Pieces.UseVisualStyleBackColor = true;
            // 
            // lbl_TeleOp_Station
            // 
            this.lbl_TeleOp_Station.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeleOp_Station.AutoSize = true;
            this.lbl_TeleOp_Station.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeleOp_Station.Location = new System.Drawing.Point(3, 126);
            this.lbl_TeleOp_Station.Name = "lbl_TeleOp_Station";
            this.lbl_TeleOp_Station.Size = new System.Drawing.Size(343, 48);
            this.lbl_TeleOp_Station.TabIndex = 14;
            this.lbl_TeleOp_Station.Text = "Charging Station:";
            this.lbl_TeleOp_Station.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_TeleOp_Station
            // 
            this.cmb_TeleOp_Station.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TeleOp_Station.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TeleOp_Station.FormattingEnabled = true;
            this.cmb_TeleOp_Station.Items.AddRange(new object[] {
            "Not Docked",
            "Docked !& Engaged",
            "Docked && Engaged"});
            this.cmb_TeleOp_Station.Location = new System.Drawing.Point(3, 177);
            this.cmb_TeleOp_Station.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_TeleOp_Station.Name = "cmb_TeleOp_Station";
            this.cmb_TeleOp_Station.Size = new System.Drawing.Size(475, 46);
            this.cmb_TeleOp_Station.TabIndex = 18;
            this.cmb_TeleOp_Station.SelectedValueChanged += new System.EventHandler(this.cmb_TeleOp_Station_SelectedValueChanged);
            // 
            // lbl_TeleOp_Scores
            // 
            this.lbl_TeleOp_Scores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeleOp_Scores.AutoSize = true;
            this.lbl_TeleOp_Scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeleOp_Scores.Location = new System.Drawing.Point(11, 226);
            this.lbl_TeleOp_Scores.Name = "lbl_TeleOp_Scores";
            this.lbl_TeleOp_Scores.Size = new System.Drawing.Size(162, 48);
            this.lbl_TeleOp_Scores.TabIndex = 16;
            this.lbl_TeleOp_Scores.Text = "Scores:";
            this.lbl_TeleOp_Scores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckb_TeleOp_High
            // 
            this.ckb_TeleOp_High.AutoSize = true;
            this.ckb_TeleOp_High.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_TeleOp_High.Location = new System.Drawing.Point(19, 277);
            this.ckb_TeleOp_High.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_TeleOp_High.Name = "ckb_TeleOp_High";
            this.ckb_TeleOp_High.Size = new System.Drawing.Size(110, 43);
            this.ckb_TeleOp_High.TabIndex = 22;
            this.ckb_TeleOp_High.Text = "High";
            this.ckb_TeleOp_High.UseVisualStyleBackColor = true;
            // 
            // ckb_TeleOp_Mid
            // 
            this.ckb_TeleOp_Mid.AutoSize = true;
            this.ckb_TeleOp_Mid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_TeleOp_Mid.Location = new System.Drawing.Point(19, 318);
            this.ckb_TeleOp_Mid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_TeleOp_Mid.Name = "ckb_TeleOp_Mid";
            this.ckb_TeleOp_Mid.Size = new System.Drawing.Size(94, 43);
            this.ckb_TeleOp_Mid.TabIndex = 24;
            this.ckb_TeleOp_Mid.Text = "Mid";
            this.ckb_TeleOp_Mid.UseVisualStyleBackColor = true;
            // 
            // ckb_TeleOp_Low
            // 
            this.ckb_TeleOp_Low.AutoSize = true;
            this.ckb_TeleOp_Low.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_TeleOp_Low.Location = new System.Drawing.Point(19, 354);
            this.ckb_TeleOp_Low.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_TeleOp_Low.Name = "ckb_TeleOp_Low";
            this.ckb_TeleOp_Low.Size = new System.Drawing.Size(102, 43);
            this.ckb_TeleOp_Low.TabIndex = 23;
            this.ckb_TeleOp_Low.Text = "Low";
            this.ckb_TeleOp_Low.UseVisualStyleBackColor = true;
            // 
            // lbl_TeleOp_Intake
            // 
            this.lbl_TeleOp_Intake.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeleOp_Intake.AutoSize = true;
            this.lbl_TeleOp_Intake.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeleOp_Intake.Location = new System.Drawing.Point(312, 228);
            this.lbl_TeleOp_Intake.Name = "lbl_TeleOp_Intake";
            this.lbl_TeleOp_Intake.Size = new System.Drawing.Size(146, 48);
            this.lbl_TeleOp_Intake.TabIndex = 19;
            this.lbl_TeleOp_Intake.Text = "Intake:";
            this.lbl_TeleOp_Intake.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckb_TeleOp_InFloor
            // 
            this.ckb_TeleOp_InFloor.AutoSize = true;
            this.ckb_TeleOp_InFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_TeleOp_InFloor.Location = new System.Drawing.Point(321, 273);
            this.ckb_TeleOp_InFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_TeleOp_InFloor.Name = "ckb_TeleOp_InFloor";
            this.ckb_TeleOp_InFloor.Size = new System.Drawing.Size(117, 43);
            this.ckb_TeleOp_InFloor.TabIndex = 25;
            this.ckb_TeleOp_InFloor.Text = "Floor";
            this.ckb_TeleOp_InFloor.UseVisualStyleBackColor = true;
            // 
            // ckb_TeleOp_InShelf
            // 
            this.ckb_TeleOp_InShelf.AutoSize = true;
            this.ckb_TeleOp_InShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_TeleOp_InShelf.Location = new System.Drawing.Point(321, 321);
            this.ckb_TeleOp_InShelf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_TeleOp_InShelf.Name = "ckb_TeleOp_InShelf";
            this.ckb_TeleOp_InShelf.Size = new System.Drawing.Size(117, 43);
            this.ckb_TeleOp_InShelf.TabIndex = 26;
            this.ckb_TeleOp_InShelf.Text = "Shelf";
            this.ckb_TeleOp_InShelf.UseVisualStyleBackColor = true;
            // 
            // lbl_TeleOp_Notes
            // 
            this.lbl_TeleOp_Notes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TeleOp_Notes.AutoSize = true;
            this.lbl_TeleOp_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeleOp_Notes.Location = new System.Drawing.Point(3, 420);
            this.lbl_TeleOp_Notes.Name = "lbl_TeleOp_Notes";
            this.lbl_TeleOp_Notes.Size = new System.Drawing.Size(304, 48);
            this.lbl_TeleOp_Notes.TabIndex = 20;
            this.lbl_TeleOp_Notes.Text = "Tele-Op Notes:";
            this.lbl_TeleOp_Notes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_TeleOp_Notes
            // 
            this.txt_TeleOp_Notes.Location = new System.Drawing.Point(3, 471);
            this.txt_TeleOp_Notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeleOp_Notes.Multiline = true;
            this.txt_TeleOp_Notes.Name = "txt_TeleOp_Notes";
            this.txt_TeleOp_Notes.Size = new System.Drawing.Size(479, 258);
            this.txt_TeleOp_Notes.TabIndex = 21;
            // 
            // pnl_OtherInfo
            // 
            this.pnl_OtherInfo.Controls.Add(this.lbl_OtherInfo_Name);
            this.pnl_OtherInfo.Controls.Add(this.ckb_OtherInfo_AI);
            this.pnl_OtherInfo.Controls.Add(this.ckb_OtherInfo_LEDs);
            this.pnl_OtherInfo.Controls.Add(this.lbl_OtherInfo_Notes);
            this.pnl_OtherInfo.Controls.Add(this.txt_OtherInfo_Notes);
            this.pnl_OtherInfo.Location = new System.Drawing.Point(995, 262);
            this.pnl_OtherInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_OtherInfo.Name = "pnl_OtherInfo";
            this.pnl_OtherInfo.Size = new System.Drawing.Size(476, 479);
            this.pnl_OtherInfo.TabIndex = 10;
            // 
            // lbl_OtherInfo_Name
            // 
            this.lbl_OtherInfo_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_OtherInfo_Name.AutoSize = true;
            this.lbl_OtherInfo_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OtherInfo_Name.Location = new System.Drawing.Point(13, 10);
            this.lbl_OtherInfo_Name.Name = "lbl_OtherInfo_Name";
            this.lbl_OtherInfo_Name.Size = new System.Drawing.Size(206, 48);
            this.lbl_OtherInfo_Name.TabIndex = 13;
            this.lbl_OtherInfo_Name.Text = "Other Info";
            this.lbl_OtherInfo_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckb_OtherInfo_AI
            // 
            this.ckb_OtherInfo_AI.AutoSize = true;
            this.ckb_OtherInfo_AI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_OtherInfo_AI.Location = new System.Drawing.Point(21, 62);
            this.ckb_OtherInfo_AI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_OtherInfo_AI.Name = "ckb_OtherInfo_AI";
            this.ckb_OtherInfo_AI.Size = new System.Drawing.Size(265, 43);
            this.ckb_OtherInfo_AI.TabIndex = 27;
            this.ckb_OtherInfo_AI.Text = "AI Assistence?";
            this.ckb_OtherInfo_AI.UseVisualStyleBackColor = true;
            // 
            // ckb_OtherInfo_LEDs
            // 
            this.ckb_OtherInfo_LEDs.AutoSize = true;
            this.ckb_OtherInfo_LEDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_OtherInfo_LEDs.Location = new System.Drawing.Point(21, 110);
            this.ckb_OtherInfo_LEDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_OtherInfo_LEDs.Name = "ckb_OtherInfo_LEDs";
            this.ckb_OtherInfo_LEDs.Size = new System.Drawing.Size(142, 43);
            this.ckb_OtherInfo_LEDs.TabIndex = 28;
            this.ckb_OtherInfo_LEDs.Text = "LEDs?";
            this.ckb_OtherInfo_LEDs.UseVisualStyleBackColor = true;
            // 
            // lbl_OtherInfo_Notes
            // 
            this.lbl_OtherInfo_Notes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_OtherInfo_Notes.AutoSize = true;
            this.lbl_OtherInfo_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OtherInfo_Notes.Location = new System.Drawing.Point(13, 154);
            this.lbl_OtherInfo_Notes.Name = "lbl_OtherInfo_Notes";
            this.lbl_OtherInfo_Notes.Size = new System.Drawing.Size(340, 48);
            this.lbl_OtherInfo_Notes.TabIndex = 22;
            this.lbl_OtherInfo_Notes.Text = "Any Other Notes:";
            this.lbl_OtherInfo_Notes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_OtherInfo_Notes
            // 
            this.txt_OtherInfo_Notes.Location = new System.Drawing.Point(3, 215);
            this.txt_OtherInfo_Notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_OtherInfo_Notes.Multiline = true;
            this.txt_OtherInfo_Notes.Name = "txt_OtherInfo_Notes";
            this.txt_OtherInfo_Notes.Size = new System.Drawing.Size(471, 258);
            this.txt_OtherInfo_Notes.TabIndex = 23;
            // 
            // btn_Display_Submit
            // 
            this.btn_Display_Submit.Enabled = false;
            this.btn_Display_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Display_Submit.Location = new System.Drawing.Point(3, 139);
            this.btn_Display_Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Display_Submit.Name = "btn_Display_Submit";
            this.btn_Display_Submit.Size = new System.Drawing.Size(216, 112);
            this.btn_Display_Submit.TabIndex = 11;
            this.btn_Display_Submit.Text = "Submit";
            this.btn_Display_Submit.UseVisualStyleBackColor = true;
            this.btn_Display_Submit.Click += new System.EventHandler(this.btn_Display_Submit_Click);
            // 
            // ofd_Import
            // 
            this.ofd_Import.FileName = "openFileDialog1";
            this.ofd_Import.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_Import_FileOk);
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.lbl_Info_TeamNumber);
            this.pnl_Info.Controls.Add(this.lbl_Info_DtType);
            this.pnl_Info.Controls.Add(this.lbl_Info_DtMotor);
            this.pnl_Info.Controls.Add(this.txt_Info_TeamNumber);
            this.pnl_Info.Controls.Add(this.cmb_Info_DtType);
            this.pnl_Info.Controls.Add(this.cmb_Info_DtMotor);
            this.pnl_Info.Location = new System.Drawing.Point(12, 4);
            this.pnl_Info.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(487, 176);
            this.pnl_Info.TabIndex = 12;
            // 
            // pnl_Display
            // 
            this.pnl_Display.Controls.Add(this.btn_Display_Import);
            this.pnl_Display.Controls.Add(this.btn_Display_Submit);
            this.pnl_Display.Controls.Add(this.pb_Display_Robot);
            this.pnl_Display.Location = new System.Drawing.Point(995, 6);
            this.pnl_Display.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Display.Name = "pnl_Display";
            this.pnl_Display.Size = new System.Drawing.Size(476, 255);
            this.pnl_Display.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 753);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.pnl_Auto);
            this.Controls.Add(this.pnl_TeleOp);
            this.Controls.Add(this.pnl_Display);
            this.Controls.Add(this.pnl_OtherInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pit Scouting";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Display_Robot)).EndInit();
            this.pnl_Auto.ResumeLayout(false);
            this.pnl_Auto.PerformLayout();
            this.pnl_TeleOp.ResumeLayout(false);
            this.pnl_TeleOp.PerformLayout();
            this.pnl_OtherInfo.ResumeLayout(false);
            this.pnl_OtherInfo.PerformLayout();
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            this.pnl_Display.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_Info_TeamNumber;
        public System.Windows.Forms.Label lbl_Info_DtType;
        private System.Windows.Forms.Label lbl_Info_DtMotor;
        private System.Windows.Forms.TextBox txt_Info_TeamNumber;
        private System.Windows.Forms.ComboBox cmb_Info_DtMotor;
        private System.Windows.Forms.ComboBox cmb_Info_DtType;
        private System.Windows.Forms.Button btn_Display_Import;
        private System.Windows.Forms.PictureBox pb_Display_Robot;
        private System.Windows.Forms.Panel pnl_Auto;
        private System.Windows.Forms.Panel pnl_TeleOp;
        private System.Windows.Forms.Panel pnl_OtherInfo;
        private System.Windows.Forms.Label lbl_Auto_Name;
        private System.Windows.Forms.TextBox txt_Auto_Notes;
        private System.Windows.Forms.Label lbl_Auto_Notes;
        private System.Windows.Forms.Label lbl_Auto_Station;
        private System.Windows.Forms.ComboBox cmb_Auto_Station;
        private System.Windows.Forms.Label lbl_TeleOp_Scores;
        private System.Windows.Forms.Label lbl_TeleOp_Station;
        private System.Windows.Forms.CheckBox ckb_TeleOp_Pieces;
        private System.Windows.Forms.Label lbl_TeleOp_Name;
        private System.Windows.Forms.TextBox txt_TeleOp_Notes;
        private System.Windows.Forms.Label lbl_TeleOp_Notes;
        private System.Windows.Forms.Label lbl_TeleOp_Intake;
        private System.Windows.Forms.Label lbl_OtherInfo_Name;
        private System.Windows.Forms.Button btn_Display_Submit;
        private System.Windows.Forms.TextBox txt_OtherInfo_Notes;
        private System.Windows.Forms.Label lbl_OtherInfo_Notes;
        private System.Windows.Forms.OpenFileDialog ofd_Import;
        private System.Windows.Forms.SaveFileDialog sfd_Submit;
        public System.Windows.Forms.CheckBox ckb_Auto_Community;
        private System.Windows.Forms.CheckBox ckb_Auto_Floor;
        private System.Windows.Forms.CheckBox ckb_Auto_Preloaded;
        private System.Windows.Forms.CheckBox ckb_TeleOp_InShelf;
        private System.Windows.Forms.CheckBox ckb_TeleOp_InFloor;
        private System.Windows.Forms.CheckBox ckb_TeleOp_Mid;
        private System.Windows.Forms.CheckBox ckb_TeleOp_Low;
        private System.Windows.Forms.CheckBox ckb_TeleOp_High;
        private System.Windows.Forms.CheckBox ckb_OtherInfo_LEDs;
        private System.Windows.Forms.CheckBox ckb_OtherInfo_AI;
        private System.Windows.Forms.ComboBox cmb_TeleOp_Station;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Panel pnl_Display;
        private System.Windows.Forms.Button button1;
    }
}

