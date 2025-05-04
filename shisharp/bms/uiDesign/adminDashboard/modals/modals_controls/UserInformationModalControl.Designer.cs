using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.adminDashboard.modals.modals_controls {
    partial class UserInformationModalControl {
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
            this.btgURole = new System.Windows.Forms.GroupBox();
            this.cbMcUsers = new Krypton.Toolkit.KryptonCheckBox();
            this.cbMcSecretary = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.cbMcShowPass = new Krypton.Toolkit.KryptonCheckBox();
            this.btnMcLogin = new Krypton.Toolkit.KryptonButton();
            this.txtMcPassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtMcUserId = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.cbMcStatus = new Krypton.Toolkit.KryptonCheckBox();
            this.txtMcUsername = new Krypton.Toolkit.KryptonTextBox();
            this.txtMcEmail = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.btgURole.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btgURole);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.cbMcShowPass);
            this.kryptonPanel1.Controls.Add(this.btnMcLogin);
            this.kryptonPanel1.Controls.Add(this.txtMcPassword);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.txtMcUserId);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.cbMcStatus);
            this.kryptonPanel1.Controls.Add(this.txtMcUsername);
            this.kryptonPanel1.Controls.Add(this.txtMcEmail);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(398, 599);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btgURole
            // 
            this.btgURole.Controls.Add(this.cbMcUsers);
            this.btgURole.Controls.Add(this.cbMcSecretary);
            this.btgURole.Location = new System.Drawing.Point(174, 477);
            this.btgURole.Name = "btgURole";
            this.btgURole.Size = new System.Drawing.Size(211, 39);
            this.btgURole.TabIndex = 43;
            this.btgURole.TabStop = false;
            // 
            // cbMcUsers
            // 
            this.cbMcUsers.AutoSize = false;
            this.cbMcUsers.Checked = true;
            this.cbMcUsers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMcUsers.Location = new System.Drawing.Point(5, 0);
            this.cbMcUsers.Name = "cbMcUsers";
            this.cbMcUsers.Size = new System.Drawing.Size(76, 39);
            this.cbMcUsers.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMcUsers.TabIndex = 41;
            this.cbMcUsers.Values.Text = "User";
            // 
            // cbMcSecretary
            // 
            this.cbMcSecretary.AutoSize = false;
            this.cbMcSecretary.Location = new System.Drawing.Point(101, 0);
            this.cbMcSecretary.Name = "cbMcSecretary";
            this.cbMcSecretary.Size = new System.Drawing.Size(110, 39);
            this.cbMcSecretary.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMcSecretary.TabIndex = 42;
            this.cbMcSecretary.ThreeState = true;
            this.cbMcSecretary.Values.Text = "Secretary";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(183, 452);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(48, 23);
            this.kryptonLabel7.StateCommon.Padding = new System.Windows.Forms.Padding(-2);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 40;
            this.kryptonLabel7.Values.Text = "Role";
            // 
            // cbMcShowPass
            // 
            this.cbMcShowPass.AutoSize = false;
            this.cbMcShowPass.Location = new System.Drawing.Point(255, 394);
            this.cbMcShowPass.Name = "cbMcShowPass";
            this.cbMcShowPass.Size = new System.Drawing.Size(129, 39);
            this.cbMcShowPass.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMcShowPass.TabIndex = 39;
            this.cbMcShowPass.Values.Text = "Show Password";
            // 
            // btnMcLogin
            // 
            this.btnMcLogin.Location = new System.Drawing.Point(111, 541);
            this.btnMcLogin.Name = "btnMcLogin";
            this.btnMcLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.OverrideDefault.Back.ColorAngle = 45F;
            this.btnMcLogin.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMcLogin.OverrideDefault.Border.Rounding = 5F;
            this.btnMcLogin.OverrideDefault.Border.Width = 1;
            this.btnMcLogin.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMcLogin.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMcLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnMcLogin.Size = new System.Drawing.Size(160, 44);
            this.btnMcLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.StateCommon.Back.ColorAngle = 45F;
            this.btnMcLogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnMcLogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnMcLogin.StateCommon.Border.ColorAngle = 45F;
            this.btnMcLogin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMcLogin.StateCommon.Border.Rounding = 5F;
            this.btnMcLogin.StateCommon.Border.Width = 1;
            this.btnMcLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMcLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMcLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMcLogin.StateDisabled.Border.Rounding = 5F;
            this.btnMcLogin.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.StateNormal.Border.Rounding = 5F;
            this.btnMcLogin.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMcLogin.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMcLogin.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnMcLogin.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnMcLogin.StatePressed.Back.ColorAngle = 130F;
            this.btnMcLogin.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnMcLogin.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnMcLogin.StatePressed.Border.ColorAngle = 130F;
            this.btnMcLogin.StatePressed.Border.Rounding = 5F;
            this.btnMcLogin.StatePressed.Border.Width = 1;
            this.btnMcLogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnMcLogin.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnMcLogin.StateTracking.Back.ColorAngle = 45F;
            this.btnMcLogin.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnMcLogin.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.StateTracking.Border.ColorAngle = 45F;
            this.btnMcLogin.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMcLogin.StateTracking.Border.Rounding = 5F;
            this.btnMcLogin.StateTracking.Border.Width = 1;
            this.btnMcLogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcLogin.TabIndex = 38;
            this.btnMcLogin.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnMcLogin.Values.Text = "Save Changes";
            this.btnMcLogin.Click += new System.EventHandler(this.btnMcLogin_Click_1);
            // 
            // txtMcPassword
            // 
            this.txtMcPassword.Location = new System.Drawing.Point(10, 350);
            this.txtMcPassword.Multiline = true;
            this.txtMcPassword.Name = "txtMcPassword";
            this.txtMcPassword.Size = new System.Drawing.Size(375, 39);
            this.txtMcPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMcPassword.TabIndex = 11;
            this.txtMcPassword.ToolTipValues.Description = "";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(10, 325);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(98, 23);
            this.kryptonLabel6.StateCommon.Padding = new System.Windows.Forms.Padding(-2);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 10;
            this.kryptonLabel6.Values.Text = "Password";
            // 
            // txtMcUserId
            // 
            this.txtMcUserId.Enabled = false;
            this.txtMcUserId.Location = new System.Drawing.Point(10, 114);
            this.txtMcUserId.Multiline = true;
            this.txtMcUserId.Name = "txtMcUserId";
            this.txtMcUserId.Size = new System.Drawing.Size(375, 39);
            this.txtMcUserId.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMcUserId.TabIndex = 8;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(15, 89);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(77, 23);
            this.kryptonLabel5.StateCommon.Padding = new System.Windows.Forms.Padding(-2);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 7;
            this.kryptonLabel5.Values.Text = "User ID";
            // 
            // cbMcStatus
            // 
            this.cbMcStatus.AutoSize = false;
            this.cbMcStatus.Checked = true;
            this.cbMcStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMcStatus.Location = new System.Drawing.Point(10, 477);
            this.cbMcStatus.Name = "cbMcStatus";
            this.cbMcStatus.Size = new System.Drawing.Size(159, 39);
            this.cbMcStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMcStatus.TabIndex = 6;
            this.cbMcStatus.Values.Text = "Activated";
            // 
            // txtMcUsername
            // 
            this.txtMcUsername.Location = new System.Drawing.Point(10, 272);
            this.txtMcUsername.Multiline = true;
            this.txtMcUsername.Name = "txtMcUsername";
            this.txtMcUsername.Size = new System.Drawing.Size(375, 39);
            this.txtMcUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMcUsername.TabIndex = 5;
            // 
            // txtMcEmail
            // 
            this.txtMcEmail.Location = new System.Drawing.Point(10, 192);
            this.txtMcEmail.Multiline = true;
            this.txtMcEmail.Name = "txtMcEmail";
            this.txtMcEmail.Size = new System.Drawing.Size(375, 39);
            this.txtMcEmail.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMcEmail.TabIndex = 4;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(10, 452);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(65, 23);
            this.kryptonLabel4.StateCommon.Padding = new System.Windows.Forms.Padding(-2);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "Status";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(10, 247);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(103, 23);
            this.kryptonLabel3.StateCommon.Padding = new System.Windows.Forms.Padding(-2);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Username";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(10, 167);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(58, 23);
            this.kryptonLabel2.StateCommon.Padding = new System.Windows.Forms.Padding(-2);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Email";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(98, 10);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(234, 33);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Account Information";
            // 
            // UserInformationModalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "UserInformationModalControl";
            this.Size = new System.Drawing.Size(398, 599);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.btgURole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonCheckBox cbMcShowPass;
        private Krypton.Toolkit.KryptonButton btnMcLogin;
        protected internal Krypton.Toolkit.KryptonTextBox txtMcPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        protected internal Krypton.Toolkit.KryptonTextBox txtMcUserId;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonCheckBox cbMcStatus;
        protected internal Krypton.Toolkit.KryptonTextBox txtMcUsername;
        protected internal Krypton.Toolkit.KryptonTextBox txtMcEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonCheckBox cbMcUsers;
        private Krypton.Toolkit.KryptonCheckBox cbMcSecretary;
        private GroupBox btgURole;
    }
}
