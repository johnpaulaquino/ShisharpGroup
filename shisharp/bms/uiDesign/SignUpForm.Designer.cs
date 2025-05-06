using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrgyMs.uiDesign {
    partial class SignUpForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnSPrevious = new Krypton.Toolkit.KryptonButton();
            this.btnSLogin = new Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.btnSNext = new Krypton.Toolkit.KryptonButton();
            this.btnSCreateAccount = new Krypton.Toolkit.KryptonButton();
            this.pnlSLogCredentials = new Krypton.Toolkit.KryptonPanel();
            this.lblPageNum1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel33 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel32 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel31 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel30 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtSUsername = new Krypton.Toolkit.KryptonTextBox();
            this.cbSShowPass = new Krypton.Toolkit.KryptonCheckBox();
            this.lblPanelInfo = new Krypton.Toolkit.KryptonLabel();
            this.txtSPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtSEmail = new Krypton.Toolkit.KryptonTextBox();
            this.txtSConfirmPass = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.pnlSEmailVerification = new Krypton.Toolkit.KryptonPanel();
            this.btnResend = new Krypton.Toolkit.KryptonButton();
            this.lblTimer = new Krypton.Toolkit.KryptonLabel();
            this.lblPageNum2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel50 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel51 = new Krypton.Toolkit.KryptonLabel();
            this.txtSOtpCode = new Krypton.Toolkit.KryptonTextBox();
            this.pnlSPinfo1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel37 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel36 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel34 = new Krypton.Toolkit.KryptonLabel();
            this.cboSGender = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.cboSSuffix = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.txtSLastname = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.txtSMName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtSFName = new Krypton.Toolkit.KryptonTextBox();
            this.lblPageNum3 = new Krypton.Toolkit.KryptonLabel();
            this.lblPanelInfo1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.pnlSAddInfo1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel22 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel35 = new Krypton.Toolkit.KryptonLabel();
            this.cboResidentType = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel20 = new Krypton.Toolkit.KryptonLabel();
            this.cboEmpStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel21 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel23 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel28 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel24 = new Krypton.Toolkit.KryptonLabel();
            this.cboAEducAttain = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel16 = new Krypton.Toolkit.KryptonLabel();
            this.cboACivilStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            this.cbAVoterStatus = new Krypton.Toolkit.KryptonCheckBox();
            this.dtpkABirthday = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            this.lblPageNum4 = new Krypton.Toolkit.KryptonLabel();
            this.lblPanelinfo2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.pnlSAddInfo2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel29 = new Krypton.Toolkit.KryptonLabel();
            this.txtAContactNo = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel18 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel25 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel48 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel49 = new Krypton.Toolkit.KryptonLabel();
            this.txtAPoRFilePath = new Krypton.Toolkit.KryptonTextBox();
            this.btnAProofOfresidency = new Krypton.Toolkit.KryptonButton();
            this.txtAProfilePicFilePath = new Krypton.Toolkit.KryptonTextBox();
            this.txtAReligion = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel17 = new Krypton.Toolkit.KryptonLabel();
            this.btnAAddProfilePic = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel19 = new Krypton.Toolkit.KryptonLabel();
            this.lblPageNum5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel26 = new Krypton.Toolkit.KryptonLabel();
            this.pnlSAddress = new Krypton.Toolkit.KryptonPanel();
            this.lblBlockNoAs = new Krypton.Toolkit.KryptonLabel();
            this.lblLotNoAs = new Krypton.Toolkit.KryptonLabel();
            this.lblVillageAs = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel44 = new Krypton.Toolkit.KryptonLabel();
            this.txtSBlockNo = new Krypton.Toolkit.KryptonTextBox();
            this.lblSBlockNo = new Krypton.Toolkit.KryptonLabel();
            this.txtSLotNo = new Krypton.Toolkit.KryptonTextBox();
            this.lblLotNo = new Krypton.Toolkit.KryptonLabel();
            this.cbIsLiveInSubdivision = new Krypton.Toolkit.KryptonCheckBox();
            this.txtSSubdivision = new Krypton.Toolkit.KryptonTextBox();
            this.lblSubdivision = new Krypton.Toolkit.KryptonLabel();
            this.lblHouseNo = new Krypton.Toolkit.KryptonLabel();
            this.lblHouseNoAs = new Krypton.Toolkit.KryptonLabel();
            this.txtSHouseNo = new Krypton.Toolkit.KryptonTextBox();
            this.txtSStreet = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel40 = new Krypton.Toolkit.KryptonLabel();
            this.lblPageNum6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel42 = new Krypton.Toolkit.KryptonLabel();
            this.btnAAddPOR = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSLogCredentials)).BeginInit();
            this.pnlSLogCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSEmailVerification)).BeginInit();
            this.pnlSEmailVerification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSPinfo1)).BeginInit();
            this.pnlSPinfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSSuffix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSAddInfo1)).BeginInit();
            this.pnlSAddInfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboResidentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmpStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAEducAttain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboACivilStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSAddInfo2)).BeginInit();
            this.pnlSAddInfo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSAddress)).BeginInit();
            this.pnlSAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnSPrevious);
            this.kryptonPanel1.Controls.Add(this.btnSLogin);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.btnSNext);
            this.kryptonPanel1.Controls.Add(this.btnSCreateAccount);
            this.kryptonPanel1.Controls.Add(this.pnlSLogCredentials);
            this.kryptonPanel1.Controls.Add(this.pnlSEmailVerification);
            this.kryptonPanel1.Controls.Add(this.pnlSPinfo1);
            this.kryptonPanel1.Controls.Add(this.pnlSAddInfo1);
            this.kryptonPanel1.Controls.Add(this.pnlSAddInfo2);
            this.kryptonPanel1.Controls.Add(this.pnlSAddress);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1049, 590);
            this.kryptonPanel1.TabIndex = 39;
            // 
            // btnSPrevious
            // 
            this.btnSPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPrevious.Location = new System.Drawing.Point(601, 538);
            this.btnSPrevious.Name = "btnSPrevious";
            this.btnSPrevious.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSPrevious.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSPrevious.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSPrevious.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSPrevious.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSPrevious.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSPrevious.OverrideDefault.Border.Rounding = 18F;
            this.btnSPrevious.OverrideDefault.Border.Width = 1;
            this.btnSPrevious.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSPrevious.Size = new System.Drawing.Size(160, 44);
            this.btnSPrevious.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSPrevious.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSPrevious.StateCommon.Back.ColorAngle = 45F;
            this.btnSPrevious.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSPrevious.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSPrevious.StateCommon.Border.ColorAngle = 45F;
            this.btnSPrevious.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSPrevious.StateCommon.Border.Rounding = 5F;
            this.btnSPrevious.StateCommon.Border.Width = 1;
            this.btnSPrevious.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSPrevious.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSPrevious.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPrevious.StateNormal.Border.Rounding = 5F;
            this.btnSPrevious.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSPrevious.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSPrevious.StatePressed.Back.ColorAngle = 130F;
            this.btnSPrevious.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSPrevious.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnSPrevious.StatePressed.Border.ColorAngle = 130F;
            this.btnSPrevious.StatePressed.Border.Rounding = 5F;
            this.btnSPrevious.StatePressed.Border.Width = 1;
            this.btnSPrevious.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSPrevious.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSPrevious.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSPrevious.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSPrevious.StateTracking.Back.ColorAngle = 45F;
            this.btnSPrevious.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSPrevious.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSPrevious.StateTracking.Border.ColorAngle = 45F;
            this.btnSPrevious.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSPrevious.StateTracking.Border.Rounding = 5F;
            this.btnSPrevious.StateTracking.Border.Width = 1;
            this.btnSPrevious.TabIndex = 45;
            this.btnSPrevious.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSPrevious.Values.Text = "Previous";
            this.btnSPrevious.Visible = false;
            this.btnSPrevious.Click += new System.EventHandler(this.btnSPrevious_Click_1);
            // 
            // btnSLogin
            // 
            this.btnSLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSLogin.Location = new System.Drawing.Point(34, 26);
            this.btnSLogin.Name = "btnSLogin";
            this.btnSLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnSLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnSLogin.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSLogin.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSLogin.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSLogin.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSLogin.OverrideDefault.Border.Rounding = 18F;
            this.btnSLogin.OverrideDefault.Border.Width = 1;
            this.btnSLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSLogin.Size = new System.Drawing.Size(160, 44);
            this.btnSLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnSLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnSLogin.StateCommon.Back.ColorAngle = 45F;
            this.btnSLogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSLogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSLogin.StateCommon.Border.ColorAngle = 45F;
            this.btnSLogin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSLogin.StateCommon.Border.Rounding = 5F;
            this.btnSLogin.StateCommon.Border.Width = 1;
            this.btnSLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSLogin.StateDisabled.Border.Rounding = 5F;
            this.btnSLogin.StateNormal.Border.Rounding = 5F;
            this.btnSLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSLogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSLogin.StatePressed.Back.ColorAngle = 130F;
            this.btnSLogin.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSLogin.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnSLogin.StatePressed.Border.ColorAngle = 130F;
            this.btnSLogin.StatePressed.Border.Rounding = 5F;
            this.btnSLogin.StatePressed.Border.Width = 1;
            this.btnSLogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSLogin.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSLogin.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnSLogin.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnSLogin.StateTracking.Back.ColorAngle = 45F;
            this.btnSLogin.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSLogin.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSLogin.StateTracking.Border.ColorAngle = 45F;
            this.btnSLogin.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSLogin.StateTracking.Border.Rounding = 5F;
            this.btnSLogin.StateTracking.Border.Width = 1;
            this.btnSLogin.TabIndex = 41;
            this.btnSLogin.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSLogin.Values.Text = "Login";
            this.btnSLogin.Click += new System.EventHandler(this.btnSLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(685, 49);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.kryptonLabel3.Size = new System.Drawing.Size(213, 33);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 39;
            this.kryptonLabel3.Values.Text = "Let\'s Get Started!";
            // 
            // btnSNext
            // 
            this.btnSNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSNext.Location = new System.Drawing.Point(849, 538);
            this.btnSNext.Name = "btnSNext";
            this.btnSNext.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSNext.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSNext.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSNext.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSNext.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSNext.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSNext.OverrideDefault.Border.Rounding = 18F;
            this.btnSNext.OverrideDefault.Border.Width = 1;
            this.btnSNext.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSNext.Size = new System.Drawing.Size(160, 44);
            this.btnSNext.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSNext.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSNext.StateCommon.Back.ColorAngle = 45F;
            this.btnSNext.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSNext.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSNext.StateCommon.Border.ColorAngle = 45F;
            this.btnSNext.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSNext.StateCommon.Border.Rounding = 5F;
            this.btnSNext.StateCommon.Border.Width = 1;
            this.btnSNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSNext.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSNext.StateNormal.Border.Rounding = 5F;
            this.btnSNext.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSNext.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSNext.StatePressed.Back.ColorAngle = 130F;
            this.btnSNext.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSNext.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnSNext.StatePressed.Border.ColorAngle = 130F;
            this.btnSNext.StatePressed.Border.Rounding = 5F;
            this.btnSNext.StatePressed.Border.Width = 1;
            this.btnSNext.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSNext.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSNext.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSNext.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSNext.StateTracking.Back.ColorAngle = 45F;
            this.btnSNext.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSNext.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSNext.StateTracking.Border.ColorAngle = 45F;
            this.btnSNext.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSNext.StateTracking.Border.Rounding = 5F;
            this.btnSNext.StateTracking.Border.Width = 1;
            this.btnSNext.TabIndex = 42;
            this.btnSNext.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSNext.Values.Text = "Next";
            this.btnSNext.Click += new System.EventHandler(this.btnSNext_Click_1);
            // 
            // btnSCreateAccount
            // 
            this.btnSCreateAccount.Location = new System.Drawing.Point(849, 538);
            this.btnSCreateAccount.Name = "btnSCreateAccount";
            this.btnSCreateAccount.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSCreateAccount.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSCreateAccount.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSCreateAccount.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSCreateAccount.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSCreateAccount.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSCreateAccount.OverrideDefault.Border.Rounding = 18F;
            this.btnSCreateAccount.OverrideDefault.Border.Width = 1;
            this.btnSCreateAccount.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSCreateAccount.Size = new System.Drawing.Size(160, 44);
            this.btnSCreateAccount.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSCreateAccount.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSCreateAccount.StateCommon.Back.ColorAngle = 45F;
            this.btnSCreateAccount.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSCreateAccount.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSCreateAccount.StateCommon.Border.ColorAngle = 45F;
            this.btnSCreateAccount.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSCreateAccount.StateCommon.Border.Rounding = 5F;
            this.btnSCreateAccount.StateCommon.Border.Width = 1;
            this.btnSCreateAccount.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSCreateAccount.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSCreateAccount.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCreateAccount.StateNormal.Border.Rounding = 5F;
            this.btnSCreateAccount.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSCreateAccount.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSCreateAccount.StatePressed.Back.ColorAngle = 130F;
            this.btnSCreateAccount.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSCreateAccount.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnSCreateAccount.StatePressed.Border.ColorAngle = 130F;
            this.btnSCreateAccount.StatePressed.Border.Rounding = 5F;
            this.btnSCreateAccount.StatePressed.Border.Width = 1;
            this.btnSCreateAccount.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSCreateAccount.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSCreateAccount.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSCreateAccount.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSCreateAccount.StateTracking.Back.ColorAngle = 45F;
            this.btnSCreateAccount.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSCreateAccount.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSCreateAccount.StateTracking.Border.ColorAngle = 45F;
            this.btnSCreateAccount.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSCreateAccount.StateTracking.Border.Rounding = 5F;
            this.btnSCreateAccount.StateTracking.Border.Width = 1;
            this.btnSCreateAccount.TabIndex = 46;
            this.btnSCreateAccount.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSCreateAccount.Values.Text = "Submit";
            this.btnSCreateAccount.Click += new System.EventHandler(this.btnSCreateAccount_Click);
            // 
            // pnlSLogCredentials
            // 
            this.pnlSLogCredentials.Controls.Add(this.lblPageNum1);
            this.pnlSLogCredentials.Controls.Add(this.kryptonLabel33);
            this.pnlSLogCredentials.Controls.Add(this.kryptonLabel32);
            this.pnlSLogCredentials.Controls.Add(this.kryptonLabel31);
            this.pnlSLogCredentials.Controls.Add(this.kryptonLabel30);
            this.pnlSLogCredentials.Controls.Add(this.kryptonLabel6);
            this.pnlSLogCredentials.Controls.Add(this.kryptonLabel5);
            this.pnlSLogCredentials.Controls.Add(this.kryptonLabel4);
            this.pnlSLogCredentials.Controls.Add(this.txtSUsername);
            this.pnlSLogCredentials.Controls.Add(this.cbSShowPass);
            this.pnlSLogCredentials.Controls.Add(this.lblPanelInfo);
            this.pnlSLogCredentials.Controls.Add(this.txtSPassword);
            this.pnlSLogCredentials.Controls.Add(this.txtSEmail);
            this.pnlSLogCredentials.Controls.Add(this.txtSConfirmPass);
            this.pnlSLogCredentials.Controls.Add(this.kryptonLabel7);
            this.pnlSLogCredentials.Location = new System.Drawing.Point(601, 101);
            this.pnlSLogCredentials.Name = "pnlSLogCredentials";
            this.pnlSLogCredentials.Size = new System.Drawing.Size(409, 432);
            this.pnlSLogCredentials.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlSLogCredentials.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnlSLogCredentials.TabIndex = 43;
            // 
            // lblPageNum1
            // 
            this.lblPageNum1.Location = new System.Drawing.Point(300, 14);
            this.lblPageNum1.Name = "lblPageNum1";
            this.lblPageNum1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.lblPageNum1.Size = new System.Drawing.Size(94, 26);
            this.lblPageNum1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum1.TabIndex = 65;
            this.lblPageNum1.Values.Text = "1 out of 7";
            // 
            // kryptonLabel33
            // 
            this.kryptonLabel33.Location = new System.Drawing.Point(164, 306);
            this.kryptonLabel33.Name = "kryptonLabel33";
            this.kryptonLabel33.Size = new System.Drawing.Size(17, 26);
            this.kryptonLabel33.StateCommon.Padding = new System.Windows.Forms.Padding(0, -1, -1, -1);
            this.kryptonLabel33.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel33.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel33.TabIndex = 64;
            this.kryptonLabel33.Values.Text = "*";
            // 
            // kryptonLabel32
            // 
            this.kryptonLabel32.Location = new System.Drawing.Point(102, 226);
            this.kryptonLabel32.Name = "kryptonLabel32";
            this.kryptonLabel32.Size = new System.Drawing.Size(17, 26);
            this.kryptonLabel32.StateCommon.Padding = new System.Windows.Forms.Padding(0, -1, -1, -1);
            this.kryptonLabel32.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel32.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel32.TabIndex = 63;
            this.kryptonLabel32.Values.Text = "*";
            // 
            // kryptonLabel31
            // 
            this.kryptonLabel31.Location = new System.Drawing.Point(131, 147);
            this.kryptonLabel31.Name = "kryptonLabel31";
            this.kryptonLabel31.Size = new System.Drawing.Size(17, 26);
            this.kryptonLabel31.StateCommon.Padding = new System.Windows.Forms.Padding(0, -1, -1, -1);
            this.kryptonLabel31.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel31.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel31.TabIndex = 62;
            this.kryptonLabel31.Values.Text = "*";
            // 
            // kryptonLabel30
            // 
            this.kryptonLabel30.Location = new System.Drawing.Point(69, 71);
            this.kryptonLabel30.Name = "kryptonLabel30";
            this.kryptonLabel30.Size = new System.Drawing.Size(17, 26);
            this.kryptonLabel30.StateCommon.Padding = new System.Windows.Forms.Padding(0, -1, -1, -1);
            this.kryptonLabel30.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel30.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel30.TabIndex = 61;
            this.kryptonLabel30.Values.Text = "*";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(24, 226);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(96, 26);
            this.kryptonLabel6.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, 0, -1);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 38;
            this.kryptonLabel6.Values.Text = "Password";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(24, 147);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(103, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 37;
            this.kryptonLabel5.Values.Text = "Username";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(24, 71);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(59, 26);
            this.kryptonLabel4.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, 0, -1);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 36;
            this.kryptonLabel4.Values.Text = "Email";
            // 
            // txtSUsername
            // 
            this.txtSUsername.Location = new System.Drawing.Point(24, 175);
            this.txtSUsername.Multiline = true;
            this.txtSUsername.Name = "txtSUsername";
            this.txtSUsername.Size = new System.Drawing.Size(357, 35);
            this.txtSUsername.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSUsername.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSUsername.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSUsername.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSUsername.StateCommon.Border.Rounding = 5F;
            this.txtSUsername.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSUsername.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtSUsername.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSUsername.TabIndex = 35;
            // 
            // cbSShowPass
            // 
            this.cbSShowPass.Location = new System.Drawing.Point(238, 383);
            this.cbSShowPass.Name = "cbSShowPass";
            this.cbSShowPass.Size = new System.Drawing.Size(166, 26);
            this.cbSShowPass.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSShowPass.TabIndex = 34;
            this.cbSShowPass.Values.Text = "Show Password";
            // 
            // lblPanelInfo
            // 
            this.lblPanelInfo.Location = new System.Drawing.Point(24, 14);
            this.lblPanelInfo.Name = "lblPanelInfo";
            this.lblPanelInfo.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.lblPanelInfo.Size = new System.Drawing.Size(165, 26);
            this.lblPanelInfo.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelInfo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelInfo.TabIndex = 26;
            this.lblPanelInfo.Values.Text = "Login Credentials";
            // 
            // txtSPassword
            // 
            this.txtSPassword.Location = new System.Drawing.Point(24, 254);
            this.txtSPassword.Multiline = true;
            this.txtSPassword.Name = "txtSPassword";
            this.txtSPassword.PasswordChar = '●';
            this.txtSPassword.Size = new System.Drawing.Size(357, 35);
            this.txtSPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSPassword.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSPassword.StateCommon.Border.Rounding = 5F;
            this.txtSPassword.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSPassword.TabIndex = 32;
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(24, 99);
            this.txtSEmail.Multiline = true;
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(357, 35);
            this.txtSEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSEmail.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSEmail.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSEmail.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSEmail.StateCommon.Border.Rounding = 5F;
            this.txtSEmail.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSEmail.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSEmail.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtSEmail.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSEmail.TabIndex = 30;
            // 
            // txtSConfirmPass
            // 
            this.txtSConfirmPass.Location = new System.Drawing.Point(24, 333);
            this.txtSConfirmPass.Multiline = true;
            this.txtSConfirmPass.Name = "txtSConfirmPass";
            this.txtSConfirmPass.PasswordChar = '●';
            this.txtSConfirmPass.Size = new System.Drawing.Size(357, 35);
            this.txtSConfirmPass.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSConfirmPass.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSConfirmPass.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSConfirmPass.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSConfirmPass.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSConfirmPass.StateCommon.Border.Rounding = 5F;
            this.txtSConfirmPass.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSConfirmPass.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSConfirmPass.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSConfirmPass.TabIndex = 31;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(24, 305);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(173, 26);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 39;
            this.kryptonLabel7.Values.Text = "Confirm Password";
            // 
            // pnlSEmailVerification
            // 
            this.pnlSEmailVerification.Controls.Add(this.btnResend);
            this.pnlSEmailVerification.Controls.Add(this.lblTimer);
            this.pnlSEmailVerification.Controls.Add(this.lblPageNum2);
            this.pnlSEmailVerification.Controls.Add(this.kryptonLabel50);
            this.pnlSEmailVerification.Controls.Add(this.kryptonLabel51);
            this.pnlSEmailVerification.Controls.Add(this.txtSOtpCode);
            this.pnlSEmailVerification.Location = new System.Drawing.Point(601, 98);
            this.pnlSEmailVerification.Name = "pnlSEmailVerification";
            this.pnlSEmailVerification.Size = new System.Drawing.Size(409, 432);
            this.pnlSEmailVerification.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlSEmailVerification.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnlSEmailVerification.TabIndex = 66;
            // 
            // btnResend
            // 
            this.btnResend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResend.Enabled = false;
            this.btnResend.Location = new System.Drawing.Point(288, 169);
            this.btnResend.Name = "btnResend";
            this.btnResend.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnResend.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnResend.OverrideDefault.Back.ColorAngle = 45F;
            this.btnResend.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnResend.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnResend.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnResend.OverrideDefault.Border.Rounding = 18F;
            this.btnResend.OverrideDefault.Border.Width = 1;
            this.btnResend.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnResend.Size = new System.Drawing.Size(93, 29);
            this.btnResend.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnResend.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnResend.StateCommon.Back.ColorAngle = 45F;
            this.btnResend.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnResend.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnResend.StateCommon.Border.ColorAngle = 45F;
            this.btnResend.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnResend.StateCommon.Border.Rounding = 5F;
            this.btnResend.StateCommon.Border.Width = 1;
            this.btnResend.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnResend.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnResend.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResend.StateNormal.Border.Rounding = 5F;
            this.btnResend.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnResend.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnResend.StatePressed.Back.ColorAngle = 130F;
            this.btnResend.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnResend.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnResend.StatePressed.Border.ColorAngle = 130F;
            this.btnResend.StatePressed.Border.Rounding = 5F;
            this.btnResend.StatePressed.Border.Width = 1;
            this.btnResend.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnResend.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnResend.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnResend.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnResend.StateTracking.Back.ColorAngle = 45F;
            this.btnResend.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnResend.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnResend.StateTracking.Border.ColorAngle = 45F;
            this.btnResend.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnResend.StateTracking.Border.Rounding = 5F;
            this.btnResend.StateTracking.Border.Width = 1;
            this.btnResend.TabIndex = 67;
            this.btnResend.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnResend.Values.Text = "Re-Send OTP";
            this.btnResend.Click += new System.EventHandler(this.btnResend_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Location = new System.Drawing.Point(286, 141);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(110, 20);
            this.lblTimer.TabIndex = 66;
            this.lblTimer.Values.Text = "OTP expires in 60s";
            // 
            // lblPageNum2
            // 
            this.lblPageNum2.Location = new System.Drawing.Point(300, 14);
            this.lblPageNum2.Name = "lblPageNum2";
            this.lblPageNum2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.lblPageNum2.Size = new System.Drawing.Size(94, 26);
            this.lblPageNum2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum2.TabIndex = 65;
            this.lblPageNum2.Values.Text = "1 out of 7";
            // 
            // kryptonLabel50
            // 
            this.kryptonLabel50.Location = new System.Drawing.Point(24, 71);
            this.kryptonLabel50.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.kryptonLabel50.Name = "kryptonLabel50";
            this.kryptonLabel50.Size = new System.Drawing.Size(102, 26);
            this.kryptonLabel50.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, 0, -1);
            this.kryptonLabel50.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel50.TabIndex = 36;
            this.kryptonLabel50.Values.Text = "OTP Code";
            // 
            // kryptonLabel51
            // 
            this.kryptonLabel51.Location = new System.Drawing.Point(24, 14);
            this.kryptonLabel51.Name = "kryptonLabel51";
            this.kryptonLabel51.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.kryptonLabel51.Size = new System.Drawing.Size(160, 26);
            this.kryptonLabel51.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel51.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel51.TabIndex = 26;
            this.kryptonLabel51.Values.Text = "Email Verificaton";
            // 
            // txtSOtpCode
            // 
            this.txtSOtpCode.Location = new System.Drawing.Point(24, 99);
            this.txtSOtpCode.Multiline = true;
            this.txtSOtpCode.Name = "txtSOtpCode";
            this.txtSOtpCode.Size = new System.Drawing.Size(357, 35);
            this.txtSOtpCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSOtpCode.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSOtpCode.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSOtpCode.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSOtpCode.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSOtpCode.StateCommon.Border.Rounding = 5F;
            this.txtSOtpCode.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSOtpCode.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOtpCode.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSOtpCode.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtSOtpCode.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSOtpCode.TabIndex = 30;
            // 
            // pnlSPinfo1
            // 
            this.pnlSPinfo1.Controls.Add(this.kryptonLabel37);
            this.pnlSPinfo1.Controls.Add(this.kryptonLabel36);
            this.pnlSPinfo1.Controls.Add(this.kryptonLabel34);
            this.pnlSPinfo1.Controls.Add(this.cboSGender);
            this.pnlSPinfo1.Controls.Add(this.kryptonLabel12);
            this.pnlSPinfo1.Controls.Add(this.cboSSuffix);
            this.pnlSPinfo1.Controls.Add(this.kryptonLabel11);
            this.pnlSPinfo1.Controls.Add(this.kryptonLabel9);
            this.pnlSPinfo1.Controls.Add(this.txtSLastname);
            this.pnlSPinfo1.Controls.Add(this.kryptonLabel8);
            this.pnlSPinfo1.Controls.Add(this.txtSMName);
            this.pnlSPinfo1.Controls.Add(this.kryptonLabel1);
            this.pnlSPinfo1.Controls.Add(this.txtSFName);
            this.pnlSPinfo1.Controls.Add(this.lblPageNum3);
            this.pnlSPinfo1.Controls.Add(this.lblPanelInfo1);
            this.pnlSPinfo1.Controls.Add(this.kryptonLabel10);
            this.pnlSPinfo1.Location = new System.Drawing.Point(601, 101);
            this.pnlSPinfo1.Name = "pnlSPinfo1";
            this.pnlSPinfo1.Size = new System.Drawing.Size(409, 432);
            this.pnlSPinfo1.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlSPinfo1.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnlSPinfo1.TabIndex = 45;
            // 
            // kryptonLabel37
            // 
            this.kryptonLabel37.Location = new System.Drawing.Point(274, 306);
            this.kryptonLabel37.Name = "kryptonLabel37";
            this.kryptonLabel37.Size = new System.Drawing.Size(17, 26);
            this.kryptonLabel37.StateCommon.Padding = new System.Windows.Forms.Padding(0, -1, -1, -1);
            this.kryptonLabel37.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel37.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel37.TabIndex = 67;
            this.kryptonLabel37.Values.Text = "*";
            // 
            // kryptonLabel36
            // 
            this.kryptonLabel36.Location = new System.Drawing.Point(102, 226);
            this.kryptonLabel36.Name = "kryptonLabel36";
            this.kryptonLabel36.Size = new System.Drawing.Size(17, 26);
            this.kryptonLabel36.StateCommon.Padding = new System.Windows.Forms.Padding(0, -1, -1, -1);
            this.kryptonLabel36.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel36.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel36.TabIndex = 66;
            this.kryptonLabel36.Values.Text = "*";
            // 
            // kryptonLabel34
            // 
            this.kryptonLabel34.Location = new System.Drawing.Point(102, 71);
            this.kryptonLabel34.Name = "kryptonLabel34";
            this.kryptonLabel34.Size = new System.Drawing.Size(17, 26);
            this.kryptonLabel34.StateCommon.Padding = new System.Windows.Forms.Padding(0, -1, -1, -1);
            this.kryptonLabel34.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel34.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel34.TabIndex = 64;
            this.kryptonLabel34.Values.Text = "*";
            // 
            // cboSGender
            // 
            this.cboSGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSGender.DropDownWidth = 159;
            this.cboSGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cboSGender.Location = new System.Drawing.Point(213, 333);
            this.cboSGender.Name = "cboSGender";
            this.cboSGender.Size = new System.Drawing.Size(171, 22);
            this.cboSGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboSGender.TabIndex = 47;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(213, 305);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(75, 26);
            this.kryptonLabel12.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, 0, -1);
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 46;
            this.kryptonLabel12.Values.Text = "Gender";
            // 
            // cboSSuffix
            // 
            this.cboSSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSSuffix.DropDownWidth = 159;
            this.cboSSuffix.Items.AddRange(new object[] {
            "Jr. ",
            "Sr.",
            "III",
            "II"});
            this.cboSSuffix.Location = new System.Drawing.Point(24, 333);
            this.cboSSuffix.Name = "cboSSuffix";
            this.cboSSuffix.Size = new System.Drawing.Size(171, 22);
            this.cboSSuffix.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboSSuffix.TabIndex = 45;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(24, 305);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(185, 26);
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.TabIndex = 44;
            this.kryptonLabel11.Values.Text = "Suffix (If applicable)";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(24, 226);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(96, 26);
            this.kryptonLabel9.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, 0, -1);
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 42;
            this.kryptonLabel9.Values.Text = "Lastname";
            // 
            // txtSLastname
            // 
            this.txtSLastname.Location = new System.Drawing.Point(24, 254);
            this.txtSLastname.Multiline = true;
            this.txtSLastname.Name = "txtSLastname";
            this.txtSLastname.Size = new System.Drawing.Size(360, 35);
            this.txtSLastname.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSLastname.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSLastname.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSLastname.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSLastname.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSLastname.StateCommon.Border.Rounding = 5F;
            this.txtSLastname.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSLastname.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLastname.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSLastname.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtSLastname.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSLastname.TabIndex = 41;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(24, 147);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(239, 26);
            this.kryptonLabel8.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, 0, -1);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 40;
            this.kryptonLabel8.Values.Text = "Middlename (If applicable)";
            // 
            // txtSMName
            // 
            this.txtSMName.Location = new System.Drawing.Point(24, 175);
            this.txtSMName.Multiline = true;
            this.txtSMName.Name = "txtSMName";
            this.txtSMName.Size = new System.Drawing.Size(360, 35);
            this.txtSMName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSMName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSMName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSMName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSMName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSMName.StateCommon.Border.Rounding = 5F;
            this.txtSMName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSMName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSMName.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtSMName.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSMName.TabIndex = 39;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(24, 71);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(97, 26);
            this.kryptonLabel1.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, 0, -1);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 38;
            this.kryptonLabel1.Values.Text = "Firstname";
            // 
            // txtSFName
            // 
            this.txtSFName.Location = new System.Drawing.Point(24, 99);
            this.txtSFName.Multiline = true;
            this.txtSFName.Name = "txtSFName";
            this.txtSFName.Size = new System.Drawing.Size(360, 35);
            this.txtSFName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSFName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSFName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSFName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSFName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSFName.StateCommon.Border.Rounding = 5F;
            this.txtSFName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSFName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSFName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSFName.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtSFName.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtSFName.TabIndex = 37;
            // 
            // lblPageNum3
            // 
            this.lblPageNum3.Location = new System.Drawing.Point(316, 14);
            this.lblPageNum3.Name = "lblPageNum3";
            this.lblPageNum3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.lblPageNum3.Size = new System.Drawing.Size(94, 26);
            this.lblPageNum3.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum3.TabIndex = 28;
            this.lblPageNum3.Values.Text = "1 out of 7";
            // 
            // lblPanelInfo1
            // 
            this.lblPanelInfo1.Location = new System.Drawing.Point(24, 14);
            this.lblPanelInfo1.Name = "lblPanelInfo1";
            this.lblPanelInfo1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.lblPanelInfo1.Size = new System.Drawing.Size(193, 26);
            this.lblPanelInfo1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelInfo1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelInfo1.TabIndex = 27;
            this.lblPanelInfo1.Values.Text = "Personal Information";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(-165, -23);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.kryptonLabel10.Size = new System.Drawing.Size(85, 26);
            this.kryptonLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 26;
            this.kryptonLabel10.Values.Text = "Address";
            // 
            // pnlSAddInfo1
            // 
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel22);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel35);
            this.pnlSAddInfo1.Controls.Add(this.cboResidentType);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel20);
            this.pnlSAddInfo1.Controls.Add(this.cboEmpStatus);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel21);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel23);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel14);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel28);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel24);
            this.pnlSAddInfo1.Controls.Add(this.cboAEducAttain);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel16);
            this.pnlSAddInfo1.Controls.Add(this.cboACivilStatus);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel15);
            this.pnlSAddInfo1.Controls.Add(this.cbAVoterStatus);
            this.pnlSAddInfo1.Controls.Add(this.dtpkABirthday);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel13);
            this.pnlSAddInfo1.Controls.Add(this.lblPageNum4);
            this.pnlSAddInfo1.Controls.Add(this.lblPanelinfo2);
            this.pnlSAddInfo1.Controls.Add(this.kryptonLabel2);
            this.pnlSAddInfo1.Location = new System.Drawing.Point(601, 101);
            this.pnlSAddInfo1.Name = "pnlSAddInfo1";
            this.pnlSAddInfo1.Size = new System.Drawing.Size(409, 432);
            this.pnlSAddInfo1.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlSAddInfo1.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnlSAddInfo1.TabIndex = 44;
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.Location = new System.Drawing.Point(133, 347);
            this.kryptonLabel22.Name = "kryptonLabel22";
            this.kryptonLabel22.Size = new System.Drawing.Size(15, 26);
            this.kryptonLabel22.StateCommon.Padding = new System.Windows.Forms.Padding(-2, -1, -1, -1);
            this.kryptonLabel22.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel22.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel22.TabIndex = 71;
            this.kryptonLabel22.Values.Text = "*";
            // 
            // kryptonLabel35
            // 
            this.kryptonLabel35.Location = new System.Drawing.Point(21, 347);
            this.kryptonLabel35.Name = "kryptonLabel35";
            this.kryptonLabel35.Size = new System.Drawing.Size(131, 26);
            this.kryptonLabel35.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -5, -1);
            this.kryptonLabel35.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel35.TabIndex = 70;
            this.kryptonLabel35.Values.Text = "Resident Type";
            // 
            // cboResidentType
            // 
            this.cboResidentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResidentType.DropDownWidth = 413;
            this.cboResidentType.Items.AddRange(new object[] {
            "Normal",
            "PWD",
            "Senior Citizen"});
            this.cboResidentType.Location = new System.Drawing.Point(24, 374);
            this.cboResidentType.Name = "cboResidentType";
            this.cboResidentType.Size = new System.Drawing.Size(354, 22);
            this.cboResidentType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboResidentType.TabIndex = 69;
            // 
            // kryptonLabel20
            // 
            this.kryptonLabel20.Location = new System.Drawing.Point(172, 282);
            this.kryptonLabel20.Name = "kryptonLabel20";
            this.kryptonLabel20.Size = new System.Drawing.Size(15, 26);
            this.kryptonLabel20.StateCommon.Padding = new System.Windows.Forms.Padding(-2, -1, -1, -1);
            this.kryptonLabel20.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel20.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel20.TabIndex = 68;
            this.kryptonLabel20.Values.Text = "*";
            // 
            // cboEmpStatus
            // 
            this.cboEmpStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpStatus.DropDownWidth = 416;
            this.cboEmpStatus.Items.AddRange(new object[] {
            "Employed",
            "Self-Employed",
            "Unemployed",
            "Student"});
            this.cboEmpStatus.Location = new System.Drawing.Point(24, 309);
            this.cboEmpStatus.Name = "cboEmpStatus";
            this.cboEmpStatus.Size = new System.Drawing.Size(357, 25);
            this.cboEmpStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboEmpStatus.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpStatus.TabIndex = 67;
            // 
            // kryptonLabel21
            // 
            this.kryptonLabel21.Location = new System.Drawing.Point(24, 282);
            this.kryptonLabel21.Name = "kryptonLabel21";
            this.kryptonLabel21.Size = new System.Drawing.Size(174, 26);
            this.kryptonLabel21.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -5, -1);
            this.kryptonLabel21.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel21.TabIndex = 66;
            this.kryptonLabel21.Values.Text = "Employment Status";
            // 
            // kryptonLabel23
            // 
            this.kryptonLabel23.Location = new System.Drawing.Point(111, 139);
            this.kryptonLabel23.Name = "kryptonLabel23";
            this.kryptonLabel23.Size = new System.Drawing.Size(15, 26);
            this.kryptonLabel23.StateCommon.Padding = new System.Windows.Forms.Padding(-2, -1, -1, -1);
            this.kryptonLabel23.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel23.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel23.TabIndex = 64;
            this.kryptonLabel23.Values.Text = "*";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(89, 71);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(15, 26);
            this.kryptonLabel14.StateCommon.Padding = new System.Windows.Forms.Padding(-2, -1, -1, -1);
            this.kryptonLabel14.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel14.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel14.TabIndex = 62;
            this.kryptonLabel14.Values.Text = "*";
            // 
            // kryptonLabel28
            // 
            this.kryptonLabel28.Location = new System.Drawing.Point(278, 68);
            this.kryptonLabel28.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.kryptonLabel28.Name = "kryptonLabel28";
            this.kryptonLabel28.Size = new System.Drawing.Size(112, 26);
            this.kryptonLabel28.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -5, -1);
            this.kryptonLabel28.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel28.TabIndex = 61;
            this.kryptonLabel28.Values.Text = "Voter Status";
            // 
            // kryptonLabel24
            // 
            this.kryptonLabel24.Location = new System.Drawing.Point(207, 211);
            this.kryptonLabel24.Name = "kryptonLabel24";
            this.kryptonLabel24.Size = new System.Drawing.Size(15, 26);
            this.kryptonLabel24.StateCommon.Padding = new System.Windows.Forms.Padding(-2, -1, -1, -1);
            this.kryptonLabel24.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel24.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel24.TabIndex = 58;
            this.kryptonLabel24.Values.Text = "*";
            // 
            // cboAEducAttain
            // 
            this.cboAEducAttain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAEducAttain.DropDownWidth = 416;
            this.cboAEducAttain.Items.AddRange(new object[] {
            "Elementary Graduate",
            "Junior High Graduate",
            "Senior High Graduate",
            "College Graduate",
            "Undergraduate"});
            this.cboAEducAttain.Location = new System.Drawing.Point(24, 239);
            this.cboAEducAttain.Name = "cboAEducAttain";
            this.cboAEducAttain.Size = new System.Drawing.Size(357, 25);
            this.cboAEducAttain.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAEducAttain.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboAEducAttain.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAEducAttain.TabIndex = 44;
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(25, 211);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(212, 26);
            this.kryptonLabel16.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -5, -1);
            this.kryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel16.TabIndex = 43;
            this.kryptonLabel16.Values.Text = "Educational Attaintment";
            // 
            // cboACivilStatus
            // 
            this.cboACivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboACivilStatus.DropDownWidth = 416;
            this.cboACivilStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Seperated",
            "Widowed"});
            this.cboACivilStatus.Location = new System.Drawing.Point(24, 166);
            this.cboACivilStatus.Name = "cboACivilStatus";
            this.cboACivilStatus.Size = new System.Drawing.Size(357, 25);
            this.cboACivilStatus.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboACivilStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cboACivilStatus.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboACivilStatus.TabIndex = 42;
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(24, 139);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(103, 26);
            this.kryptonLabel15.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -5, -1);
            this.kryptonLabel15.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel15.TabIndex = 41;
            this.kryptonLabel15.Values.Text = "Civil Status";
            // 
            // cbAVoterStatus
            // 
            this.cbAVoterStatus.Location = new System.Drawing.Point(278, 99);
            this.cbAVoterStatus.Name = "cbAVoterStatus";
            this.cbAVoterStatus.Size = new System.Drawing.Size(78, 23);
            this.cbAVoterStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAVoterStatus.TabIndex = 40;
            this.cbAVoterStatus.Values.Text = "Eligible";
            // 
            // dtpkABirthday
            // 
            this.dtpkABirthday.Location = new System.Drawing.Point(24, 97);
            this.dtpkABirthday.Name = "dtpkABirthday";
            this.dtpkABirthday.Size = new System.Drawing.Size(232, 25);
            this.dtpkABirthday.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkABirthday.TabIndex = 38;
            this.dtpkABirthday.ValueNullable = new System.DateTime(2025, 4, 16, 0, 0, 0, 0);
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(24, 71);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(77, 26);
            this.kryptonLabel13.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -5, -1);
            this.kryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel13.TabIndex = 37;
            this.kryptonLabel13.Values.Text = "Birthday";
            // 
            // lblPageNum4
            // 
            this.lblPageNum4.Location = new System.Drawing.Point(316, 14);
            this.lblPageNum4.Name = "lblPageNum4";
            this.lblPageNum4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.lblPageNum4.Size = new System.Drawing.Size(94, 26);
            this.lblPageNum4.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum4.TabIndex = 29;
            this.lblPageNum4.Values.Text = "1 out of 7";
            // 
            // lblPanelinfo2
            // 
            this.lblPanelinfo2.Location = new System.Drawing.Point(24, 14);
            this.lblPanelinfo2.Name = "lblPanelinfo2";
            this.lblPanelinfo2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.lblPanelinfo2.Size = new System.Drawing.Size(202, 26);
            this.lblPanelinfo2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelinfo2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelinfo2.TabIndex = 27;
            this.lblPanelinfo2.Values.Text = "Additional Information";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(-165, -23);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.kryptonLabel2.Size = new System.Drawing.Size(85, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 26;
            this.kryptonLabel2.Values.Text = "Address";
            // 
            // pnlSAddInfo2
            // 
            this.pnlSAddInfo2.Controls.Add(this.kryptonLabel29);
            this.pnlSAddInfo2.Controls.Add(this.txtAContactNo);
            this.pnlSAddInfo2.Controls.Add(this.kryptonLabel18);
            this.pnlSAddInfo2.Controls.Add(this.kryptonLabel25);
            this.pnlSAddInfo2.Controls.Add(this.kryptonLabel48);
            this.pnlSAddInfo2.Controls.Add(this.kryptonLabel49);
            this.pnlSAddInfo2.Controls.Add(this.txtAPoRFilePath);
            this.pnlSAddInfo2.Controls.Add(this.btnAProofOfresidency);
            this.pnlSAddInfo2.Controls.Add(this.txtAProfilePicFilePath);
            this.pnlSAddInfo2.Controls.Add(this.txtAReligion);
            this.pnlSAddInfo2.Controls.Add(this.kryptonLabel17);
            this.pnlSAddInfo2.Controls.Add(this.btnAAddProfilePic);
            this.pnlSAddInfo2.Controls.Add(this.kryptonLabel19);
            this.pnlSAddInfo2.Controls.Add(this.lblPageNum5);
            this.pnlSAddInfo2.Controls.Add(this.kryptonLabel26);
            this.pnlSAddInfo2.Location = new System.Drawing.Point(601, 101);
            this.pnlSAddInfo2.Name = "pnlSAddInfo2";
            this.pnlSAddInfo2.Size = new System.Drawing.Size(409, 432);
            this.pnlSAddInfo2.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlSAddInfo2.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnlSAddInfo2.TabIndex = 49;
            // 
            // kryptonLabel29
            // 
            this.kryptonLabel29.Location = new System.Drawing.Point(112, 147);
            this.kryptonLabel29.Name = "kryptonLabel29";
            this.kryptonLabel29.Size = new System.Drawing.Size(15, 26);
            this.kryptonLabel29.StateCommon.Padding = new System.Windows.Forms.Padding(-2, -1, -1, -1);
            this.kryptonLabel29.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel29.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel29.TabIndex = 69;
            this.kryptonLabel29.Values.Text = "*";
            // 
            // txtAContactNo
            // 
            this.txtAContactNo.Location = new System.Drawing.Point(25, 180);
            this.txtAContactNo.Multiline = true;
            this.txtAContactNo.Name = "txtAContactNo";
            this.txtAContactNo.Size = new System.Drawing.Size(360, 35);
            this.txtAContactNo.TabIndex = 68;
            // 
            // kryptonLabel18
            // 
            this.kryptonLabel18.Location = new System.Drawing.Point(21, 147);
            this.kryptonLabel18.Name = "kryptonLabel18";
            this.kryptonLabel18.Size = new System.Drawing.Size(108, 26);
            this.kryptonLabel18.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -5, -1);
            this.kryptonLabel18.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel18.TabIndex = 67;
            this.kryptonLabel18.Values.Text = "Contact No.";
            // 
            // kryptonLabel25
            // 
            this.kryptonLabel25.Location = new System.Drawing.Point(89, 68);
            this.kryptonLabel25.Name = "kryptonLabel25";
            this.kryptonLabel25.Size = new System.Drawing.Size(15, 26);
            this.kryptonLabel25.StateCommon.Padding = new System.Windows.Forms.Padding(-2, -1, -1, -1);
            this.kryptonLabel25.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel25.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel25.TabIndex = 65;
            this.kryptonLabel25.Values.Text = "*";
            // 
            // kryptonLabel48
            // 
            this.kryptonLabel48.Location = new System.Drawing.Point(24, 229);
            this.kryptonLabel48.Name = "kryptonLabel48";
            this.kryptonLabel48.Size = new System.Drawing.Size(170, 26);
            this.kryptonLabel48.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -5, -1);
            this.kryptonLabel48.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel48.TabIndex = 58;
            this.kryptonLabel48.Values.Text = "Proof of Residency";
            // 
            // kryptonLabel49
            // 
            this.kryptonLabel49.Location = new System.Drawing.Point(166, 226);
            this.kryptonLabel49.Name = "kryptonLabel49";
            this.kryptonLabel49.Size = new System.Drawing.Size(20, 26);
            this.kryptonLabel49.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel49.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel49.TabIndex = 57;
            this.kryptonLabel49.Values.Text = "*";
            // 
            // txtAPoRFilePath
            // 
            this.txtAPoRFilePath.Location = new System.Drawing.Point(24, 257);
            this.txtAPoRFilePath.Multiline = true;
            this.txtAPoRFilePath.Name = "txtAPoRFilePath";
            this.txtAPoRFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAPoRFilePath.Size = new System.Drawing.Size(256, 35);
            this.txtAPoRFilePath.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPoRFilePath.TabIndex = 54;
            this.txtAPoRFilePath.Text = "File Path";
            // 
            // btnAProofOfresidency
            // 
            this.btnAProofOfresidency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAProofOfresidency.Location = new System.Drawing.Point(294, 253);
            this.btnAProofOfresidency.Name = "btnAProofOfresidency";
            this.btnAProofOfresidency.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAProofOfresidency.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAProofOfresidency.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAProofOfresidency.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAProofOfresidency.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAProofOfresidency.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAProofOfresidency.OverrideDefault.Border.Rounding = 18F;
            this.btnAProofOfresidency.OverrideDefault.Border.Width = 1;
            this.btnAProofOfresidency.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAProofOfresidency.Size = new System.Drawing.Size(91, 35);
            this.btnAProofOfresidency.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAProofOfresidency.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAProofOfresidency.StateCommon.Back.ColorAngle = 45F;
            this.btnAProofOfresidency.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAProofOfresidency.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAProofOfresidency.StateCommon.Border.ColorAngle = 45F;
            this.btnAProofOfresidency.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAProofOfresidency.StateCommon.Border.Rounding = 5F;
            this.btnAProofOfresidency.StateCommon.Border.Width = 1;
            this.btnAProofOfresidency.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAProofOfresidency.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAProofOfresidency.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAProofOfresidency.StateNormal.Border.Rounding = 5F;
            this.btnAProofOfresidency.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnAProofOfresidency.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnAProofOfresidency.StatePressed.Back.ColorAngle = 130F;
            this.btnAProofOfresidency.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAProofOfresidency.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnAProofOfresidency.StatePressed.Border.ColorAngle = 130F;
            this.btnAProofOfresidency.StatePressed.Border.Rounding = 5F;
            this.btnAProofOfresidency.StatePressed.Border.Width = 1;
            this.btnAProofOfresidency.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAProofOfresidency.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAProofOfresidency.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAProofOfresidency.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAProofOfresidency.StateTracking.Back.ColorAngle = 45F;
            this.btnAProofOfresidency.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAProofOfresidency.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAProofOfresidency.StateTracking.Border.ColorAngle = 45F;
            this.btnAProofOfresidency.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAProofOfresidency.StateTracking.Border.Rounding = 5F;
            this.btnAProofOfresidency.StateTracking.Border.Width = 1;
            this.btnAProofOfresidency.TabIndex = 53;
            this.btnAProofOfresidency.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAProofOfresidency.Values.Text = "Add Picture";
            this.btnAProofOfresidency.Click += new System.EventHandler(this.btnAProofOfresidency_Click_1);
            // 
            // txtAProfilePicFilePath
            // 
            this.txtAProfilePicFilePath.Location = new System.Drawing.Point(24, 333);
            this.txtAProfilePicFilePath.Multiline = true;
            this.txtAProfilePicFilePath.Name = "txtAProfilePicFilePath";
            this.txtAProfilePicFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAProfilePicFilePath.Size = new System.Drawing.Size(256, 35);
            this.txtAProfilePicFilePath.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAProfilePicFilePath.TabIndex = 51;
            this.txtAProfilePicFilePath.Text = "File Path";
            // 
            // txtAReligion
            // 
            this.txtAReligion.Location = new System.Drawing.Point(24, 96);
            this.txtAReligion.Multiline = true;
            this.txtAReligion.Name = "txtAReligion";
            this.txtAReligion.Size = new System.Drawing.Size(360, 35);
            this.txtAReligion.TabIndex = 46;
            // 
            // kryptonLabel17
            // 
            this.kryptonLabel17.Location = new System.Drawing.Point(24, 68);
            this.kryptonLabel17.Name = "kryptonLabel17";
            this.kryptonLabel17.Size = new System.Drawing.Size(76, 26);
            this.kryptonLabel17.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, -5, -1);
            this.kryptonLabel17.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel17.TabIndex = 45;
            this.kryptonLabel17.Values.Text = "Religion";
            // 
            // btnAAddProfilePic
            // 
            this.btnAAddProfilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAAddProfilePic.Location = new System.Drawing.Point(294, 333);
            this.btnAAddProfilePic.Name = "btnAAddProfilePic";
            this.btnAAddProfilePic.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAAddProfilePic.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAAddProfilePic.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAAddProfilePic.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAAddProfilePic.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAAddProfilePic.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAAddProfilePic.OverrideDefault.Border.Rounding = 18F;
            this.btnAAddProfilePic.OverrideDefault.Border.Width = 1;
            this.btnAAddProfilePic.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAAddProfilePic.Size = new System.Drawing.Size(91, 35);
            this.btnAAddProfilePic.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAAddProfilePic.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAAddProfilePic.StateCommon.Back.ColorAngle = 45F;
            this.btnAAddProfilePic.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAAddProfilePic.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAAddProfilePic.StateCommon.Border.ColorAngle = 45F;
            this.btnAAddProfilePic.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAAddProfilePic.StateCommon.Border.Rounding = 5F;
            this.btnAAddProfilePic.StateCommon.Border.Width = 1;
            this.btnAAddProfilePic.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAAddProfilePic.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAAddProfilePic.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAAddProfilePic.StateNormal.Border.Rounding = 5F;
            this.btnAAddProfilePic.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnAAddProfilePic.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnAAddProfilePic.StatePressed.Back.ColorAngle = 130F;
            this.btnAAddProfilePic.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAAddProfilePic.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnAAddProfilePic.StatePressed.Border.ColorAngle = 130F;
            this.btnAAddProfilePic.StatePressed.Border.Rounding = 5F;
            this.btnAAddProfilePic.StatePressed.Border.Width = 1;
            this.btnAAddProfilePic.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAAddProfilePic.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAAddProfilePic.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAAddProfilePic.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAAddProfilePic.StateTracking.Back.ColorAngle = 45F;
            this.btnAAddProfilePic.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAAddProfilePic.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAAddProfilePic.StateTracking.Border.ColorAngle = 45F;
            this.btnAAddProfilePic.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAAddProfilePic.StateTracking.Border.Rounding = 5F;
            this.btnAAddProfilePic.StateTracking.Border.Width = 1;
            this.btnAAddProfilePic.TabIndex = 50;
            this.btnAAddProfilePic.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAAddProfilePic.Values.Text = "Add Picture";
            this.btnAAddProfilePic.Click += new System.EventHandler(this.btnAAddProfilePic_Click_1);
            // 
            // kryptonLabel19
            // 
            this.kryptonLabel19.Location = new System.Drawing.Point(24, 305);
            this.kryptonLabel19.Name = "kryptonLabel19";
            this.kryptonLabel19.Size = new System.Drawing.Size(135, 26);
            this.kryptonLabel19.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel19.TabIndex = 38;
            this.kryptonLabel19.Values.Text = "Profile Picture";
            // 
            // lblPageNum5
            // 
            this.lblPageNum5.Location = new System.Drawing.Point(304, 14);
            this.lblPageNum5.Name = "lblPageNum5";
            this.lblPageNum5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.lblPageNum5.Size = new System.Drawing.Size(94, 26);
            this.lblPageNum5.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum5.TabIndex = 29;
            this.lblPageNum5.Values.Text = "1 out of 7";
            // 
            // kryptonLabel26
            // 
            this.kryptonLabel26.Location = new System.Drawing.Point(24, 14);
            this.kryptonLabel26.Name = "kryptonLabel26";
            this.kryptonLabel26.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.kryptonLabel26.Size = new System.Drawing.Size(218, 26);
            this.kryptonLabel26.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel26.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel26.TabIndex = 27;
            this.kryptonLabel26.Values.Text = "Additional Information 2";
            // 
            // pnlSAddress
            // 
            this.pnlSAddress.Controls.Add(this.lblBlockNoAs);
            this.pnlSAddress.Controls.Add(this.lblLotNoAs);
            this.pnlSAddress.Controls.Add(this.lblVillageAs);
            this.pnlSAddress.Controls.Add(this.kryptonLabel44);
            this.pnlSAddress.Controls.Add(this.txtSBlockNo);
            this.pnlSAddress.Controls.Add(this.lblSBlockNo);
            this.pnlSAddress.Controls.Add(this.txtSLotNo);
            this.pnlSAddress.Controls.Add(this.lblLotNo);
            this.pnlSAddress.Controls.Add(this.cbIsLiveInSubdivision);
            this.pnlSAddress.Controls.Add(this.txtSSubdivision);
            this.pnlSAddress.Controls.Add(this.lblSubdivision);
            this.pnlSAddress.Controls.Add(this.lblHouseNo);
            this.pnlSAddress.Controls.Add(this.lblHouseNoAs);
            this.pnlSAddress.Controls.Add(this.txtSHouseNo);
            this.pnlSAddress.Controls.Add(this.txtSStreet);
            this.pnlSAddress.Controls.Add(this.kryptonLabel40);
            this.pnlSAddress.Controls.Add(this.lblPageNum6);
            this.pnlSAddress.Controls.Add(this.kryptonLabel42);
            this.pnlSAddress.Location = new System.Drawing.Point(601, 98);
            this.pnlSAddress.Name = "pnlSAddress";
            this.pnlSAddress.Size = new System.Drawing.Size(409, 432);
            this.pnlSAddress.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlSAddress.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnlSAddress.TabIndex = 57;
            // 
            // lblBlockNoAs
            // 
            this.lblBlockNoAs.Location = new System.Drawing.Point(288, 347);
            this.lblBlockNoAs.Name = "lblBlockNoAs";
            this.lblBlockNoAs.Size = new System.Drawing.Size(14, 26);
            this.lblBlockNoAs.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblBlockNoAs.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockNoAs.StateNormal.Padding = new System.Windows.Forms.Padding(0, -1, 0, -1);
            this.lblBlockNoAs.TabIndex = 67;
            this.lblBlockNoAs.Values.Text = "*";
            // 
            // lblLotNoAs
            // 
            this.lblLotNoAs.Location = new System.Drawing.Point(82, 346);
            this.lblLotNoAs.Name = "lblLotNoAs";
            this.lblLotNoAs.Size = new System.Drawing.Size(14, 26);
            this.lblLotNoAs.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblLotNoAs.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNoAs.StateNormal.Padding = new System.Windows.Forms.Padding(0, -1, 0, -1);
            this.lblLotNoAs.TabIndex = 66;
            this.lblLotNoAs.Values.Text = "*";
            // 
            // lblVillageAs
            // 
            this.lblVillageAs.Location = new System.Drawing.Point(122, 266);
            this.lblVillageAs.Name = "lblVillageAs";
            this.lblVillageAs.Size = new System.Drawing.Size(14, 26);
            this.lblVillageAs.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblVillageAs.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillageAs.StateNormal.Padding = new System.Windows.Forms.Padding(0, -1, 0, -1);
            this.lblVillageAs.TabIndex = 65;
            this.lblVillageAs.Values.Text = "*";
            // 
            // kryptonLabel44
            // 
            this.kryptonLabel44.Location = new System.Drawing.Point(75, 193);
            this.kryptonLabel44.Name = "kryptonLabel44";
            this.kryptonLabel44.Size = new System.Drawing.Size(14, 26);
            this.kryptonLabel44.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel44.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel44.StateNormal.Padding = new System.Windows.Forms.Padding(0, -1, 0, -1);
            this.kryptonLabel44.TabIndex = 64;
            this.kryptonLabel44.Values.Text = "*";
            // 
            // txtSBlockNo
            // 
            this.txtSBlockNo.Location = new System.Drawing.Point(210, 374);
            this.txtSBlockNo.Multiline = true;
            this.txtSBlockNo.Name = "txtSBlockNo";
            this.txtSBlockNo.Size = new System.Drawing.Size(171, 35);
            this.txtSBlockNo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSBlockNo.TabIndex = 63;
            this.txtSBlockNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSBlockNo_KeyPress);
            // 
            // lblSBlockNo
            // 
            this.lblSBlockNo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblSBlockNo.Location = new System.Drawing.Point(213, 347);
            this.lblSBlockNo.Name = "lblSBlockNo";
            this.lblSBlockNo.Size = new System.Drawing.Size(96, 25);
            this.lblSBlockNo.StateCommon.Padding = new System.Windows.Forms.Padding(-1, 0, -1, -1);
            this.lblSBlockNo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSBlockNo.TabIndex = 62;
            this.lblSBlockNo.Values.Text = "Block No.";
            // 
            // txtSLotNo
            // 
            this.txtSLotNo.Location = new System.Drawing.Point(21, 374);
            this.txtSLotNo.Multiline = true;
            this.txtSLotNo.Name = "txtSLotNo";
            this.txtSLotNo.Size = new System.Drawing.Size(171, 35);
            this.txtSLotNo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLotNo.TabIndex = 61;
            this.txtSLotNo.TextChanged += new System.EventHandler(this.txtSLotNo_TextChanged);
            this.txtSLotNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLotNo_KeyPress);
            // 
            // lblLotNo
            // 
            this.lblLotNo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblLotNo.Location = new System.Drawing.Point(24, 346);
            this.lblLotNo.Name = "lblLotNo";
            this.lblLotNo.Size = new System.Drawing.Size(76, 25);
            this.lblLotNo.StateCommon.Padding = new System.Windows.Forms.Padding(-1, 0, -1, -1);
            this.lblLotNo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNo.TabIndex = 60;
            this.lblLotNo.Values.Text = "Lot No.";
            // 
            // cbIsLiveInSubdivision
            // 
            this.cbIsLiveInSubdivision.Location = new System.Drawing.Point(24, 71);
            this.cbIsLiveInSubdivision.Name = "cbIsLiveInSubdivision";
            this.cbIsLiveInSubdivision.Size = new System.Drawing.Size(332, 33);
            this.cbIsLiveInSubdivision.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsLiveInSubdivision.TabIndex = 59;
            this.cbIsLiveInSubdivision.Values.Text = "Do you lived in subdivision?";
            this.cbIsLiveInSubdivision.CheckedChanged += new System.EventHandler(this.cbIsLiveInSubdivision_CheckedChanged);
            // 
            // txtSSubdivision
            // 
            this.txtSSubdivision.Location = new System.Drawing.Point(21, 294);
            this.txtSSubdivision.Multiline = true;
            this.txtSSubdivision.Name = "txtSSubdivision";
            this.txtSSubdivision.Size = new System.Drawing.Size(360, 35);
            this.txtSSubdivision.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSubdivision.TabIndex = 58;
            // 
            // lblSubdivision
            // 
            this.lblSubdivision.Location = new System.Drawing.Point(24, 266);
            this.lblSubdivision.Name = "lblSubdivision";
            this.lblSubdivision.Size = new System.Drawing.Size(121, 25);
            this.lblSubdivision.StateCommon.Padding = new System.Windows.Forms.Padding(-1, 0, -1, -1);
            this.lblSubdivision.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubdivision.TabIndex = 57;
            this.lblSubdivision.Values.Text = "Villagename";
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.Location = new System.Drawing.Point(24, 117);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(105, 25);
            this.lblHouseNo.StateCommon.Padding = new System.Windows.Forms.Padding(-1, 0, -1, -1);
            this.lblHouseNo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNo.TabIndex = 56;
            this.lblHouseNo.Values.Text = "House No.";
            // 
            // lblHouseNoAs
            // 
            this.lblHouseNoAs.Location = new System.Drawing.Point(108, 116);
            this.lblHouseNoAs.Name = "lblHouseNoAs";
            this.lblHouseNoAs.Size = new System.Drawing.Size(20, 26);
            this.lblHouseNoAs.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblHouseNoAs.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNoAs.TabIndex = 55;
            this.lblHouseNoAs.Values.Text = "*";
            // 
            // txtSHouseNo
            // 
            this.txtSHouseNo.Location = new System.Drawing.Point(21, 145);
            this.txtSHouseNo.Multiline = true;
            this.txtSHouseNo.Name = "txtSHouseNo";
            this.txtSHouseNo.Size = new System.Drawing.Size(360, 35);
            this.txtSHouseNo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSHouseNo.TabIndex = 54;
            this.txtSHouseNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSHouseNo_KeyPress_1);
            // 
            // txtSStreet
            // 
            this.txtSStreet.Location = new System.Drawing.Point(21, 217);
            this.txtSStreet.Multiline = true;
            this.txtSStreet.Name = "txtSStreet";
            this.txtSStreet.Size = new System.Drawing.Size(360, 35);
            this.txtSStreet.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSStreet.TabIndex = 51;
            // 
            // kryptonLabel40
            // 
            this.kryptonLabel40.Location = new System.Drawing.Point(24, 193);
            this.kryptonLabel40.Name = "kryptonLabel40";
            this.kryptonLabel40.Size = new System.Drawing.Size(65, 25);
            this.kryptonLabel40.StateCommon.Padding = new System.Windows.Forms.Padding(-1, 0, -1, -1);
            this.kryptonLabel40.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel40.TabIndex = 38;
            this.kryptonLabel40.Values.Text = "Street";
            // 
            // lblPageNum6
            // 
            this.lblPageNum6.Location = new System.Drawing.Point(303, 14);
            this.lblPageNum6.Name = "lblPageNum6";
            this.lblPageNum6.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.lblPageNum6.Size = new System.Drawing.Size(94, 26);
            this.lblPageNum6.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum6.TabIndex = 29;
            this.lblPageNum6.Values.Text = "1 out of 7";
            // 
            // kryptonLabel42
            // 
            this.kryptonLabel42.Location = new System.Drawing.Point(24, 14);
            this.kryptonLabel42.Name = "kryptonLabel42";
            this.kryptonLabel42.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.kryptonLabel42.Size = new System.Drawing.Size(85, 26);
            this.kryptonLabel42.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel42.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel42.TabIndex = 27;
            this.kryptonLabel42.Values.Text = "Address ";
            // 
            // btnAAddPOR
            // 
            this.btnAAddPOR.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnAAddPOR.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnAAddPOR.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.btnAAddPOR.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnAAddPOR.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnAAddPOR.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.btnAAddPOR.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnAAddPOR.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnAAddPOR.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.btnAAddPOR.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAAddPOR.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAAddPOR.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.btnAAddPOR.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAAddPOR.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnAAddPOR.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.btnAAddPOR.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnAAddPOR.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnAAddPOR.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnAAddPOR.FormStyles.FormCommon.StateCommon.Border.Rounding = 16F;
            this.btnAAddPOR.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnAAddPOR.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnAAddPOR.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAAddPOR.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnAAddPOR.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            this.btnAAddPOR.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnAAddPOR.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnAAddPOR.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.btnAAddPOR.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.btnAAddPOR.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(28, 114);
            this.kryptonTextBox1.Multiline = true;
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(416, 40);
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 59;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1049, 590);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSLogCredentials)).EndInit();
            this.pnlSLogCredentials.ResumeLayout(false);
            this.pnlSLogCredentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSEmailVerification)).EndInit();
            this.pnlSEmailVerification.ResumeLayout(false);
            this.pnlSEmailVerification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSPinfo1)).EndInit();
            this.pnlSPinfo1.ResumeLayout(false);
            this.pnlSPinfo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSSuffix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSAddInfo1)).EndInit();
            this.pnlSAddInfo1.ResumeLayout(false);
            this.pnlSAddInfo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboResidentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmpStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAEducAttain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboACivilStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSAddInfo2)).EndInit();
            this.pnlSAddInfo2.ResumeLayout(false);
            this.pnlSAddInfo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSAddress)).EndInit();
            this.pnlSAddress.ResumeLayout(false);
            this.pnlSAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnSPrevious;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnSNext;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonPanel pnlSAddInfo1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPanel pnlSLogCredentials;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtSUsername;
        private Krypton.Toolkit.KryptonCheckBox cbSShowPass;
        private Krypton.Toolkit.KryptonLabel lblPanelInfo;
        private Krypton.Toolkit.KryptonTextBox txtSPassword;
        private Krypton.Toolkit.KryptonTextBox txtSEmail;
        private Krypton.Toolkit.KryptonTextBox txtSConfirmPass;
        private Krypton.Toolkit.KryptonCustomPaletteBase btnAAddPOR;
        private Krypton.Toolkit.KryptonButton btnSLogin;
        private Krypton.Toolkit.KryptonButton btnSCreateAccount;
        private Krypton.Toolkit.KryptonPanel pnlSPinfo1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel lblPanelinfo2;
        private Krypton.Toolkit.KryptonLabel lblPanelInfo1;
        private Krypton.Toolkit.KryptonLabel lblPageNum3;
        private Krypton.Toolkit.KryptonLabel lblPageNum4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtSFName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonTextBox txtSMName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonTextBox txtSLastname;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonComboBox cboSSuffix;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonComboBox cboSGender;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonDateTimePicker dtpkABirthday;
        private Krypton.Toolkit.KryptonCheckBox cbAVoterStatus;
        private Krypton.Toolkit.KryptonComboBox cboACivilStatus;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonComboBox cboAEducAttain;
        private Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Krypton.Toolkit.KryptonLabel kryptonLabel17;
        private Krypton.Toolkit.KryptonTextBox txtAReligion;
        private Krypton.Toolkit.KryptonPanel pnlSAddInfo2;
        private Krypton.Toolkit.KryptonTextBox txtSStreet;
        private Krypton.Toolkit.KryptonLabel lblPageNum5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel26;
        private Krypton.Toolkit.KryptonLabel kryptonLabel19;
        private Krypton.Toolkit.KryptonButton btnAAddProfilePic;
        private Krypton.Toolkit.KryptonTextBox txtAProfilePicFilePath;
        private Krypton.Toolkit.KryptonTextBox txtAPoRFilePath;
        private Krypton.Toolkit.KryptonButton btnAProofOfresidency;
        private Krypton.Toolkit.KryptonLabel kryptonLabel24;
        private Krypton.Toolkit.KryptonLabel kryptonLabel28;
        private Krypton.Toolkit.KryptonLabel kryptonLabel30;
        private Krypton.Toolkit.KryptonLabel kryptonLabel31;
        private Krypton.Toolkit.KryptonLabel kryptonLabel32;
        private Krypton.Toolkit.KryptonLabel kryptonLabel33;
        private Krypton.Toolkit.KryptonLabel kryptonLabel34;
        private Krypton.Toolkit.KryptonLabel kryptonLabel37;
        private Krypton.Toolkit.KryptonLabel kryptonLabel36;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonLabel kryptonLabel25;
        private Krypton.Toolkit.KryptonLabel kryptonLabel23;
        private Krypton.Toolkit.KryptonPanel pnlSAddress;
        private Krypton.Toolkit.KryptonLabel lblHouseNo;
        private Krypton.Toolkit.KryptonLabel lblHouseNoAs;
        private Krypton.Toolkit.KryptonLabel kryptonLabel40;
        private Krypton.Toolkit.KryptonLabel lblPageNum6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel42;
        private Krypton.Toolkit.KryptonTextBox txtSHouseNo;
        private Krypton.Toolkit.KryptonTextBox txtSSubdivision;
        private Krypton.Toolkit.KryptonLabel lblSubdivision;
        private Krypton.Toolkit.KryptonCheckBox cbIsLiveInSubdivision;
        private Krypton.Toolkit.KryptonTextBox txtSLotNo;
        private Krypton.Toolkit.KryptonLabel lblLotNo;
        private Krypton.Toolkit.KryptonTextBox txtSBlockNo;
        private Krypton.Toolkit.KryptonLabel lblSBlockNo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel44;
        private Krypton.Toolkit.KryptonLabel lblVillageAs;
        private Krypton.Toolkit.KryptonLabel lblBlockNoAs;
        private Krypton.Toolkit.KryptonLabel lblLotNoAs;
        private Krypton.Toolkit.KryptonLabel kryptonLabel48;
        private Krypton.Toolkit.KryptonLabel kryptonLabel49;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonLabel lblPageNum1;
        private Krypton.Toolkit.KryptonPanel pnlSEmailVerification;
        private Krypton.Toolkit.KryptonLabel lblPageNum2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel21;
        private Krypton.Toolkit.KryptonLabel kryptonLabel38;
        private Krypton.Toolkit.KryptonLabel kryptonLabel39;
        private Krypton.Toolkit.KryptonLabel kryptonLabel41;
        private Krypton.Toolkit.KryptonLabel kryptonLabel45;
        private Krypton.Toolkit.KryptonLabel kryptonLabel46;
        private Krypton.Toolkit.KryptonLabel kryptonLabel47;
        private Krypton.Toolkit.KryptonLabel kryptonLabel50;
        private Krypton.Toolkit.KryptonLabel kryptonLabel51;
        private Krypton.Toolkit.KryptonTextBox txtSOtpCode;
        private Krypton.Toolkit.KryptonLabel kryptonLabel29;
        private Krypton.Toolkit.KryptonTextBox txtAContactNo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel18;
        private Krypton.Toolkit.KryptonLabel kryptonLabel20;
        private Krypton.Toolkit.KryptonComboBox cboEmpStatus;
        private Krypton.Toolkit.KryptonComboBox cboResidentType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private Krypton.Toolkit.KryptonLabel kryptonLabel35;
        private Krypton.Toolkit.KryptonButton btnResend;
        private Krypton.Toolkit.KryptonLabel lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}