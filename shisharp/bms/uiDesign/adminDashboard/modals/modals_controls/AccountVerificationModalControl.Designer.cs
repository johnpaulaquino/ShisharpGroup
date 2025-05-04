using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.adminDashboard.modals.modals_controls {
    partial class RequestDocumentsModalCotntrol {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.pnlMainContentHolder = new Krypton.Toolkit.KryptonPanel();
            this.txtAvEmail = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.txtxAvaddress = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.btnAvDecline = new Krypton.Toolkit.KryptonButton();
            this.btnAvVerify = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtAvAge = new Krypton.Toolkit.KryptonTextBox();
            this.picAvProofOfResidency = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtAvGender = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtAvBday = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtAvFname = new Krypton.Toolkit.KryptonTextBox();
            this.picAvProfilePicture = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).BeginInit();
            this.pnlMainContentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvProofOfResidency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pnlMainContentHolder);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(411, 607);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // pnlMainContentHolder
            // 
            this.pnlMainContentHolder.AutoScroll = true;
            this.pnlMainContentHolder.Controls.Add(this.txtAvEmail);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel8);
            this.pnlMainContentHolder.Controls.Add(this.txtxAvaddress);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel7);
            this.pnlMainContentHolder.Controls.Add(this.kryptonPanel3);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel6);
            this.pnlMainContentHolder.Controls.Add(this.txtAvAge);
            this.pnlMainContentHolder.Controls.Add(this.picAvProofOfResidency);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel5);
            this.pnlMainContentHolder.Controls.Add(this.txtAvGender);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel4);
            this.pnlMainContentHolder.Controls.Add(this.txtAvBday);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel3);
            this.pnlMainContentHolder.Controls.Add(this.txtAvFname);
            this.pnlMainContentHolder.Controls.Add(this.picAvProfilePicture);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel2);
            this.pnlMainContentHolder.Controls.Add(this.kryptonLabel1);
            this.pnlMainContentHolder.Location = new System.Drawing.Point(3, 3);
            this.pnlMainContentHolder.Name = "pnlMainContentHolder";
            this.pnlMainContentHolder.Size = new System.Drawing.Size(406, 599);
            this.pnlMainContentHolder.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlMainContentHolder.TabIndex = 12;
            // 
            // txtAvEmail
            // 
            this.txtAvEmail.Location = new System.Drawing.Point(10, 231);
            this.txtAvEmail.Multiline = true;
            this.txtAvEmail.Name = "txtAvEmail";
            this.txtAvEmail.ReadOnly = true;
            this.txtAvEmail.Size = new System.Drawing.Size(367, 39);
            this.txtAvEmail.TabIndex = 16;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(10, 204);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 15;
            this.kryptonLabel8.Values.Text = "Email";
            // 
            // txtxAvaddress
            // 
            this.txtxAvaddress.Location = new System.Drawing.Point(10, 402);
            this.txtxAvaddress.Multiline = true;
            this.txtxAvaddress.Name = "txtxAvaddress";
            this.txtxAvaddress.ReadOnly = true;
            this.txtxAvaddress.Size = new System.Drawing.Size(367, 39);
            this.txtxAvaddress.TabIndex = 14;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(10, 374);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(85, 26);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 13;
            this.kryptonLabel7.Values.Text = "Address";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btnAvDecline);
            this.kryptonPanel3.Controls.Add(this.btnAvVerify);
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 852);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(385, 77);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel3.TabIndex = 12;
            // 
            // btnAvDecline
            // 
            this.btnAvDecline.Location = new System.Drawing.Point(10, 12);
            this.btnAvDecline.Name = "btnAvDecline";
            this.btnAvDecline.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAvDecline.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAvDecline.OverrideDefault.Border.Rounding = 5F;
            this.btnAvDecline.OverrideDefault.Border.Width = 1;
            this.btnAvDecline.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAvDecline.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAvDecline.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAvDecline.Size = new System.Drawing.Size(160, 44);
            this.btnAvDecline.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.StateCommon.Back.ColorAngle = 45F;
            this.btnAvDecline.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAvDecline.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAvDecline.StateCommon.Border.ColorAngle = 45F;
            this.btnAvDecline.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAvDecline.StateCommon.Border.Rounding = 5F;
            this.btnAvDecline.StateCommon.Border.Width = 1;
            this.btnAvDecline.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAvDecline.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAvDecline.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvDecline.StateDisabled.Border.Rounding = 5F;
            this.btnAvDecline.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.StateNormal.Border.Rounding = 5F;
            this.btnAvDecline.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAvDecline.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAvDecline.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnAvDecline.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnAvDecline.StatePressed.Back.ColorAngle = 130F;
            this.btnAvDecline.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAvDecline.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnAvDecline.StatePressed.Border.ColorAngle = 130F;
            this.btnAvDecline.StatePressed.Border.Rounding = 5F;
            this.btnAvDecline.StatePressed.Border.Width = 1;
            this.btnAvDecline.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnAvDecline.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnAvDecline.StateTracking.Back.ColorAngle = 45F;
            this.btnAvDecline.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAvDecline.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.StateTracking.Border.ColorAngle = 45F;
            this.btnAvDecline.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAvDecline.StateTracking.Border.Rounding = 5F;
            this.btnAvDecline.StateTracking.Border.Width = 1;
            this.btnAvDecline.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvDecline.TabIndex = 40;
            this.btnAvDecline.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAvDecline.Values.Text = "Decline Account";
            this.btnAvDecline.Click += new System.EventHandler(this.btnAvDecline_Click_1);
            // 
            // btnAvVerify
            // 
            this.btnAvVerify.Location = new System.Drawing.Point(214, 12);
            this.btnAvVerify.Name = "btnAvVerify";
            this.btnAvVerify.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAvVerify.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAvVerify.OverrideDefault.Border.Rounding = 5F;
            this.btnAvVerify.OverrideDefault.Border.Width = 1;
            this.btnAvVerify.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAvVerify.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAvVerify.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAvVerify.Size = new System.Drawing.Size(160, 44);
            this.btnAvVerify.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.StateCommon.Back.ColorAngle = 45F;
            this.btnAvVerify.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAvVerify.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAvVerify.StateCommon.Border.ColorAngle = 45F;
            this.btnAvVerify.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAvVerify.StateCommon.Border.Rounding = 5F;
            this.btnAvVerify.StateCommon.Border.Width = 1;
            this.btnAvVerify.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAvVerify.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAvVerify.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvVerify.StateDisabled.Border.Rounding = 5F;
            this.btnAvVerify.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.StateNormal.Border.Rounding = 5F;
            this.btnAvVerify.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAvVerify.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAvVerify.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnAvVerify.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnAvVerify.StatePressed.Back.ColorAngle = 130F;
            this.btnAvVerify.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAvVerify.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnAvVerify.StatePressed.Border.ColorAngle = 130F;
            this.btnAvVerify.StatePressed.Border.Rounding = 5F;
            this.btnAvVerify.StatePressed.Border.Width = 1;
            this.btnAvVerify.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnAvVerify.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnAvVerify.StateTracking.Back.ColorAngle = 45F;
            this.btnAvVerify.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAvVerify.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.StateTracking.Border.ColorAngle = 45F;
            this.btnAvVerify.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAvVerify.StateTracking.Border.Rounding = 5F;
            this.btnAvVerify.StateTracking.Border.Width = 1;
            this.btnAvVerify.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAvVerify.TabIndex = 39;
            this.btnAvVerify.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAvVerify.Values.Text = "Verify Account";
            this.btnAvVerify.Click += new System.EventHandler(this.btnAvVerify_Click_1);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(10, 620);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(182, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 10;
            this.kryptonLabel6.Values.Text = "Proof Of Residency";
            // 
            // txtAvAge
            // 
            this.txtAvAge.Location = new System.Drawing.Point(203, 568);
            this.txtAvAge.Multiline = true;
            this.txtAvAge.Name = "txtAvAge";
            this.txtAvAge.ReadOnly = true;
            this.txtAvAge.Size = new System.Drawing.Size(171, 39);
            this.txtAvAge.TabIndex = 9;
            // 
            // picAvProofOfResidency
            // 
            this.picAvProofOfResidency.Location = new System.Drawing.Point(10, 647);
            this.picAvProofOfResidency.Name = "picAvProofOfResidency";
            this.picAvProofOfResidency.Size = new System.Drawing.Size(364, 192);
            this.picAvProofOfResidency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvProofOfResidency.TabIndex = 11;
            this.picAvProofOfResidency.TabStop = false;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(203, 540);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 8;
            this.kryptonLabel5.Values.Text = "Age";
            // 
            // txtAvGender
            // 
            this.txtAvGender.Location = new System.Drawing.Point(10, 568);
            this.txtAvGender.Multiline = true;
            this.txtAvGender.Name = "txtAvGender";
            this.txtAvGender.ReadOnly = true;
            this.txtAvGender.Size = new System.Drawing.Size(171, 39);
            this.txtAvGender.TabIndex = 7;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(10, 540);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(78, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 6;
            this.kryptonLabel4.Values.Text = "Gender";
            // 
            // txtAvBday
            // 
            this.txtAvBday.Location = new System.Drawing.Point(10, 488);
            this.txtAvBday.Multiline = true;
            this.txtAvBday.Name = "txtAvBday";
            this.txtAvBday.ReadOnly = true;
            this.txtAvBday.Size = new System.Drawing.Size(367, 39);
            this.txtAvBday.TabIndex = 5;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(10, 460);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(85, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Birthday";
            // 
            // txtAvFname
            // 
            this.txtAvFname.Location = new System.Drawing.Point(10, 317);
            this.txtAvFname.Multiline = true;
            this.txtAvFname.Name = "txtAvFname";
            this.txtAvFname.ReadOnly = true;
            this.txtAvFname.Size = new System.Drawing.Size(367, 39);
            this.txtAvFname.TabIndex = 3;
            // 
            // picAvProfilePicture
            // 
            this.picAvProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvProfilePicture.Location = new System.Drawing.Point(129, 41);
            this.picAvProfilePicture.Name = "picAvProfilePicture";
            this.picAvProfilePicture.Size = new System.Drawing.Size(129, 130);
            this.picAvProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvProfilePicture.TabIndex = 2;
            this.picAvProfilePicture.TabStop = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(100, -2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(233, 33);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Account Verification";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 289);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(94, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Fullname";
            // 
            // RequestDocumentsModalCotntrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "RequestDocumentsModalCotntrol";
            this.Size = new System.Drawing.Size(411, 607);
            this.Load += new System.EventHandler(this.RequestDocumentsModalCotntrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentHolder)).EndInit();
            this.pnlMainContentHolder.ResumeLayout(false);
            this.pnlMainContentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvProofOfResidency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public Krypton.Toolkit.KryptonPanel pnlMainContentHolder;
        private Krypton.Toolkit.KryptonButton btnAvVerify;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        protected internal Krypton.Toolkit.KryptonTextBox txtAvAge;
        protected internal Krypton.Toolkit.KryptonPictureBox picAvProofOfResidency;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        protected internal Krypton.Toolkit.KryptonTextBox txtAvGender;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        protected internal Krypton.Toolkit.KryptonTextBox txtAvBday;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        protected internal Krypton.Toolkit.KryptonTextBox txtAvFname;
        protected internal Krypton.Toolkit.KryptonPictureBox picAvProfilePicture;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnAvDecline;
        protected internal Krypton.Toolkit.KryptonTextBox txtxAvaddress;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        protected internal Krypton.Toolkit.KryptonTextBox txtAvEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
    }
}
