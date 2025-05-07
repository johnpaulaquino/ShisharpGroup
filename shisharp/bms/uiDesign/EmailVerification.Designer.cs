namespace shisharp.bms.uiDesign {
    partial class EmailVerification {
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
            this.components = new System.ComponentModel.Container();
            this.lblEmail = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnResend = new Krypton.Toolkit.KryptonButton();
            this.lblTimer = new Krypton.Toolkit.KryptonLabel();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.txtSOtpCode = new Krypton.Toolkit.KryptonTextBox();
            this.lblOtpCode = new Krypton.Toolkit.KryptonLabel();
            this.btnSubmit = new Krypton.Toolkit.KryptonButton();
            this.btnVerifyCode = new Krypton.Toolkit.KryptonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(3, 71);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 26);
            this.lblEmail.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, 0, -1);
            this.lblEmail.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.TabIndex = 76;
            this.lblEmail.Values.Text = "Email";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnResend);
            this.kryptonPanel1.Controls.Add(this.lblTimer);
            this.kryptonPanel1.Controls.Add(this.txtEmail);
            this.kryptonPanel1.Controls.Add(this.lblEmail);
            this.kryptonPanel1.Controls.Add(this.txtSOtpCode);
            this.kryptonPanel1.Controls.Add(this.lblOtpCode);
            this.kryptonPanel1.Controls.Add(this.btnSubmit);
            this.kryptonPanel1.Controls.Add(this.btnVerifyCode);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(350, 306);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 77;
            // 
            // btnResend
            // 
            this.btnResend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResend.Enabled = false;
            this.btnResend.Location = new System.Drawing.Point(239, 172);
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
            this.btnResend.TabIndex = 83;
            this.btnResend.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnResend.Values.Text = "Re-Send OTP";
            this.btnResend.Visible = false;
            this.btnResend.Click += new System.EventHandler(this.btnResend_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Location = new System.Drawing.Point(237, 144);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(110, 20);
            this.lblTimer.TabIndex = 82;
            this.lblTimer.Values.Text = "OTP expires in 60s";
            this.lblTimer.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(3, 103);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 35);
            this.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtEmail.StateCommon.Border.Rounding = 5F;
            this.txtEmail.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtEmail.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtEmail.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txtEmail.TabIndex = 81;
            // 
            // txtSOtpCode
            // 
            this.txtSOtpCode.Location = new System.Drawing.Point(3, 103);
            this.txtSOtpCode.Multiline = true;
            this.txtSOtpCode.Name = "txtSOtpCode";
            this.txtSOtpCode.Size = new System.Drawing.Size(344, 35);
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
            this.txtSOtpCode.TabIndex = 79;
            // 
            // lblOtpCode
            // 
            this.lblOtpCode.Location = new System.Drawing.Point(3, 71);
            this.lblOtpCode.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblOtpCode.Name = "lblOtpCode";
            this.lblOtpCode.Size = new System.Drawing.Size(102, 26);
            this.lblOtpCode.StateCommon.Padding = new System.Windows.Forms.Padding(-1, -1, 0, -1);
            this.lblOtpCode.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtpCode.TabIndex = 80;
            this.lblOtpCode.Values.Text = "OTP Code";
            this.lblOtpCode.Visible = false;
            this.lblOtpCode.Click += new System.EventHandler(this.kryptonLabel1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(103, 259);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmit.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmit.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSubmit.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmit.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmit.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmit.OverrideDefault.Border.Rounding = 18F;
            this.btnSubmit.OverrideDefault.Border.Width = 1;
            this.btnSubmit.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSubmit.Size = new System.Drawing.Size(160, 44);
            this.btnSubmit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmit.StateCommon.Back.ColorAngle = 45F;
            this.btnSubmit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmit.StateCommon.Border.ColorAngle = 45F;
            this.btnSubmit.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmit.StateCommon.Border.Rounding = 5F;
            this.btnSubmit.StateCommon.Border.Width = 1;
            this.btnSubmit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.StateNormal.Border.Rounding = 5F;
            this.btnSubmit.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnSubmit.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnSubmit.StatePressed.Back.ColorAngle = 130F;
            this.btnSubmit.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSubmit.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnSubmit.StatePressed.Border.ColorAngle = 130F;
            this.btnSubmit.StatePressed.Border.Rounding = 5F;
            this.btnSubmit.StatePressed.Border.Width = 1;
            this.btnSubmit.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmit.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubmit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubmit.StateTracking.Back.ColorAngle = 45F;
            this.btnSubmit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSubmit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSubmit.StateTracking.Border.ColorAngle = 45F;
            this.btnSubmit.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmit.StateTracking.Border.Rounding = 5F;
            this.btnSubmit.StateTracking.Border.Width = 1;
            this.btnSubmit.TabIndex = 76;
            this.btnSubmit.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyCode.Location = new System.Drawing.Point(103, 259);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnVerifyCode.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnVerifyCode.OverrideDefault.Back.ColorAngle = 45F;
            this.btnVerifyCode.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnVerifyCode.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnVerifyCode.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnVerifyCode.OverrideDefault.Border.Rounding = 18F;
            this.btnVerifyCode.OverrideDefault.Border.Width = 1;
            this.btnVerifyCode.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnVerifyCode.Size = new System.Drawing.Size(160, 44);
            this.btnVerifyCode.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnVerifyCode.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnVerifyCode.StateCommon.Back.ColorAngle = 45F;
            this.btnVerifyCode.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnVerifyCode.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnVerifyCode.StateCommon.Border.ColorAngle = 45F;
            this.btnVerifyCode.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnVerifyCode.StateCommon.Border.Rounding = 5F;
            this.btnVerifyCode.StateCommon.Border.Width = 1;
            this.btnVerifyCode.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnVerifyCode.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnVerifyCode.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyCode.StateNormal.Border.Rounding = 5F;
            this.btnVerifyCode.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnVerifyCode.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnVerifyCode.StatePressed.Back.ColorAngle = 130F;
            this.btnVerifyCode.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnVerifyCode.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnVerifyCode.StatePressed.Border.ColorAngle = 130F;
            this.btnVerifyCode.StatePressed.Border.Rounding = 5F;
            this.btnVerifyCode.StatePressed.Border.Width = 1;
            this.btnVerifyCode.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnVerifyCode.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnVerifyCode.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerifyCode.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerifyCode.StateTracking.Back.ColorAngle = 45F;
            this.btnVerifyCode.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnVerifyCode.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnVerifyCode.StateTracking.Border.ColorAngle = 45F;
            this.btnVerifyCode.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnVerifyCode.StateTracking.Border.Rounding = 5F;
            this.btnVerifyCode.StateTracking.Border.Width = 1;
            this.btnVerifyCode.TabIndex = 84;
            this.btnVerifyCode.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnVerifyCode.Values.Text = "Verify";
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EmailVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "EmailVerification";
            this.Size = new System.Drawing.Size(350, 306);
            this.Load += new System.EventHandler(this.EmailVerification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblEmail;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonTextBox txtSOtpCode;
        private Krypton.Toolkit.KryptonButton btnSubmit;
        private Krypton.Toolkit.KryptonLabel lblOtpCode;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonButton btnResend;
        private Krypton.Toolkit.KryptonLabel lblTimer;
        private Krypton.Toolkit.KryptonButton btnVerifyCode;
    }
}
