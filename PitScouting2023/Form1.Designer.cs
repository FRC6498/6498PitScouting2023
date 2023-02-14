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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cmbMotor = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.pbRobot = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckb_Community = new System.Windows.Forms.CheckBox();
            this.ckb_Floor = new System.Windows.Forms.CheckBox();
            this.ckb_Preloaded = new System.Windows.Forms.CheckBox();
            this.txt_AutoNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_AutoCharge = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckb_InShelf = new System.Windows.Forms.CheckBox();
            this.ckb_InFloor = new System.Windows.Forms.CheckBox();
            this.ckb_Mid = new System.Windows.Forms.CheckBox();
            this.ckb_Low = new System.Windows.Forms.CheckBox();
            this.ckb_High = new System.Windows.Forms.CheckBox();
            this.txt_TeleOpNotes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ckb_Pieces = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckb_LEDs = new System.Windows.Forms.CheckBox();
            this.ckb_AI = new System.Windows.Forms.CheckBox();
            this.txt_OtherNotes = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ofd_Import = new System.Windows.Forms.OpenFileDialog();
            this.sfd_Submit = new System.Windows.Forms.SaveFileDialog();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drivetrain Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drivetrain Motor:";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(298, 15);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(121, 45);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.Text = "6498";
            // 
            // cmbMotor
            // 
            this.cmbMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotor.FormattingEnabled = true;
            this.cmbMotor.Items.AddRange(new object[] {
            "Red Line",
            "Falcon",
            "Neo",
            "CIM",
            "Other"});
            this.cmbMotor.Location = new System.Drawing.Point(298, 115);
            this.cmbMotor.Name = "cmbMotor";
            this.cmbMotor.Size = new System.Drawing.Size(199, 46);
            this.cmbMotor.TabIndex = 4;
            this.cmbMotor.Text = "Pick One";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Tank",
            "Swerve",
            "Omniwheel",
            "Mechanum",
            "ETC."});
            this.cmbType.Location = new System.Drawing.Point(298, 63);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(199, 46);
            this.cmbType.TabIndex = 5;
            this.cmbType.Text = "Pick One";
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(991, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(223, 122);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pbRobot
            // 
            this.pbRobot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbRobot.Location = new System.Drawing.Point(1220, 6);
            this.pbRobot.Name = "pbRobot";
            this.pbRobot.Size = new System.Drawing.Size(250, 250);
            this.pbRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRobot.TabIndex = 7;
            this.pbRobot.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckb_Community);
            this.panel1.Controls.Add(this.ckb_Floor);
            this.panel1.Controls.Add(this.ckb_Preloaded);
            this.panel1.Controls.Add(this.txt_AutoNotes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_AutoCharge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 574);
            this.panel1.TabIndex = 8;
            // 
            // ckb_Community
            // 
            this.ckb_Community.AutoSize = true;
            this.ckb_Community.Checked = true;
            this.ckb_Community.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Community.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Community.Location = new System.Drawing.Point(0, 156);
            this.ckb_Community.Name = "ckb_Community";
            this.ckb_Community.Size = new System.Drawing.Size(447, 41);
            this.ckb_Community.TabIndex = 17;
            this.ckb_Community.Text = "Can it leave the Community?";
            this.ckb_Community.UseVisualStyleBackColor = true;
            // 
            // ckb_Floor
            // 
            this.ckb_Floor.AutoSize = true;
            this.ckb_Floor.Checked = true;
            this.ckb_Floor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Floor.Location = new System.Drawing.Point(0, 112);
            this.ckb_Floor.Name = "ckb_Floor";
            this.ckb_Floor.Size = new System.Drawing.Size(385, 41);
            this.ckb_Floor.TabIndex = 16;
            this.ckb_Floor.Text = "Score pieces from floor?";
            this.ckb_Floor.UseVisualStyleBackColor = true;
            // 
            // ckb_Preloaded
            // 
            this.ckb_Preloaded.AutoSize = true;
            this.ckb_Preloaded.Checked = true;
            this.ckb_Preloaded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Preloaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Preloaded.Location = new System.Drawing.Point(0, 72);
            this.ckb_Preloaded.Name = "ckb_Preloaded";
            this.ckb_Preloaded.Size = new System.Drawing.Size(390, 41);
            this.ckb_Preloaded.TabIndex = 15;
            this.ckb_Preloaded.Text = "Score preloaded pieces?";
            this.ckb_Preloaded.UseVisualStyleBackColor = true;
            // 
            // txt_AutoNotes
            // 
            this.txt_AutoNotes.Location = new System.Drawing.Point(3, 354);
            this.txt_AutoNotes.Multiline = true;
            this.txt_AutoNotes.Name = "txt_AutoNotes";
            this.txt_AutoNotes.Size = new System.Drawing.Size(479, 217);
            this.txt_AutoNotes.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 48);
            this.label6.TabIndex = 13;
            this.label6.Text = "Auto Notes:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Charging station:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmb_AutoCharge
            // 
            this.cmb_AutoCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_AutoCharge.FormattingEnabled = true;
            this.cmb_AutoCharge.Items.AddRange(new object[] {
            "Not Docked",
            "Docked !& Engaged",
            "Docked && Engaged"});
            this.cmb_AutoCharge.Location = new System.Drawing.Point(0, 239);
            this.cmb_AutoCharge.Name = "cmb_AutoCharge";
            this.cmb_AutoCharge.Size = new System.Drawing.Size(475, 46);
            this.cmb_AutoCharge.TabIndex = 11;
            this.cmb_AutoCharge.Text = "Pick One";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 48);
            this.label4.TabIndex = 11;
            this.label4.Text = "Auto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.ckb_InShelf);
            this.panel2.Controls.Add(this.ckb_InFloor);
            this.panel2.Controls.Add(this.ckb_Mid);
            this.panel2.Controls.Add(this.ckb_Low);
            this.panel2.Controls.Add(this.ckb_High);
            this.panel2.Controls.Add(this.txt_TeleOpNotes);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.ckb_Pieces);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(503, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 732);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ckb_InShelf
            // 
            this.ckb_InShelf.AutoSize = true;
            this.ckb_InShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_InShelf.Location = new System.Drawing.Point(344, 322);
            this.ckb_InShelf.Name = "ckb_InShelf";
            this.ckb_InShelf.Size = new System.Drawing.Size(117, 43);
            this.ckb_InShelf.TabIndex = 26;
            this.ckb_InShelf.Text = "Shelf";
            this.ckb_InShelf.UseVisualStyleBackColor = true;
            // 
            // ckb_InFloor
            // 
            this.ckb_InFloor.AutoSize = true;
            this.ckb_InFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_InFloor.Location = new System.Drawing.Point(344, 273);
            this.ckb_InFloor.Name = "ckb_InFloor";
            this.ckb_InFloor.Size = new System.Drawing.Size(117, 43);
            this.ckb_InFloor.TabIndex = 25;
            this.ckb_InFloor.Text = "Floor";
            this.ckb_InFloor.UseVisualStyleBackColor = true;
            // 
            // ckb_Mid
            // 
            this.ckb_Mid.AutoSize = true;
            this.ckb_Mid.Checked = true;
            this.ckb_Mid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Mid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Mid.Location = new System.Drawing.Point(19, 317);
            this.ckb_Mid.Name = "ckb_Mid";
            this.ckb_Mid.Size = new System.Drawing.Size(94, 43);
            this.ckb_Mid.TabIndex = 24;
            this.ckb_Mid.Text = "Mid";
            this.ckb_Mid.UseVisualStyleBackColor = true;
            // 
            // ckb_Low
            // 
            this.ckb_Low.AutoSize = true;
            this.ckb_Low.Checked = true;
            this.ckb_Low.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Low.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Low.Location = new System.Drawing.Point(19, 354);
            this.ckb_Low.Name = "ckb_Low";
            this.ckb_Low.Size = new System.Drawing.Size(102, 43);
            this.ckb_Low.TabIndex = 23;
            this.ckb_Low.Text = "Low";
            this.ckb_Low.UseVisualStyleBackColor = true;
            // 
            // ckb_High
            // 
            this.ckb_High.AutoSize = true;
            this.ckb_High.Checked = true;
            this.ckb_High.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_High.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_High.Location = new System.Drawing.Point(19, 273);
            this.ckb_High.Name = "ckb_High";
            this.ckb_High.Size = new System.Drawing.Size(110, 43);
            this.ckb_High.TabIndex = 22;
            this.ckb_High.Text = "High";
            this.ckb_High.UseVisualStyleBackColor = true;
            // 
            // txt_TeleOpNotes
            // 
            this.txt_TeleOpNotes.Location = new System.Drawing.Point(3, 471);
            this.txt_TeleOpNotes.Multiline = true;
            this.txt_TeleOpNotes.Name = "txt_TeleOpNotes";
            this.txt_TeleOpNotes.Size = new System.Drawing.Size(479, 258);
            this.txt_TeleOpNotes.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(304, 48);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tele-Op Notes:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(336, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 48);
            this.label10.TabIndex = 19;
            this.label10.Text = "Intake:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 48);
            this.label9.TabIndex = 16;
            this.label9.Text = "Scores:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 48);
            this.label8.TabIndex = 14;
            this.label8.Text = "Charging Station:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckb_Pieces
            // 
            this.ckb_Pieces.AutoSize = true;
            this.ckb_Pieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Pieces.Location = new System.Drawing.Point(91, 80);
            this.ckb_Pieces.Name = "ckb_Pieces";
            this.ckb_Pieces.Size = new System.Drawing.Size(255, 43);
            this.ckb_Pieces.TabIndex = 13;
            this.ckb_Pieces.Text = "Score pieces?";
            this.ckb_Pieces.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 48);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tele-Op";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ckb_LEDs);
            this.panel3.Controls.Add(this.ckb_AI);
            this.panel3.Controls.Add(this.txt_OtherNotes);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(994, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 479);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ckb_LEDs
            // 
            this.ckb_LEDs.AutoSize = true;
            this.ckb_LEDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_LEDs.Location = new System.Drawing.Point(22, 110);
            this.ckb_LEDs.Name = "ckb_LEDs";
            this.ckb_LEDs.Size = new System.Drawing.Size(142, 43);
            this.ckb_LEDs.TabIndex = 28;
            this.ckb_LEDs.Text = "LEDs?";
            this.ckb_LEDs.UseVisualStyleBackColor = true;
            // 
            // ckb_AI
            // 
            this.ckb_AI.AutoSize = true;
            this.ckb_AI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_AI.Location = new System.Drawing.Point(22, 61);
            this.ckb_AI.Name = "ckb_AI";
            this.ckb_AI.Size = new System.Drawing.Size(265, 43);
            this.ckb_AI.TabIndex = 27;
            this.ckb_AI.Text = "AI Assistence?";
            this.ckb_AI.UseVisualStyleBackColor = true;
            // 
            // txt_OtherNotes
            // 
            this.txt_OtherNotes.Location = new System.Drawing.Point(3, 215);
            this.txt_OtherNotes.Multiline = true;
            this.txt_OtherNotes.Name = "txt_OtherNotes";
            this.txt_OtherNotes.Size = new System.Drawing.Size(470, 258);
            this.txt_OtherNotes.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(340, 48);
            this.label14.TabIndex = 22;
            this.label14.Text = "Any Other Notes:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 48);
            this.label13.TabIndex = 13;
            this.label13.Text = "Other Info";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(991, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 124);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofd_Import
            // 
            this.ofd_Import.FileName = "openFileDialog1";
            this.ofd_Import.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_Import_FileOk);
            // 
            // tmrCheck
            // 
            this.tmrCheck.Enabled = true;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Not Docked",
            "Docked !& Engaged",
            "Docked && Engaged"});
            this.comboBox1.Location = new System.Drawing.Point(3, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(475, 46);
            this.comboBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbRobot);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbMotor);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pit Scouting";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ComboBox cmbMotor;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.PictureBox pbRobot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AutoNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_AutoCharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckb_Pieces;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TeleOpNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_OtherNotes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog ofd_Import;
        private System.Windows.Forms.SaveFileDialog sfd_Submit;
        private System.Windows.Forms.CheckBox ckb_Community;
        private System.Windows.Forms.CheckBox ckb_Floor;
        private System.Windows.Forms.CheckBox ckb_Preloaded;
        private System.Windows.Forms.CheckBox ckb_InShelf;
        private System.Windows.Forms.CheckBox ckb_InFloor;
        private System.Windows.Forms.CheckBox ckb_Mid;
        private System.Windows.Forms.CheckBox ckb_Low;
        private System.Windows.Forms.CheckBox ckb_High;
        private System.Windows.Forms.CheckBox ckb_LEDs;
        private System.Windows.Forms.CheckBox ckb_AI;
        private System.Windows.Forms.Timer tmrCheck;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

