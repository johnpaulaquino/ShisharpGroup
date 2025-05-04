using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.adminDashboard.modals.modals_controls {
    partial class CreateUsersModalControl {
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
            this.cbMcSecretary = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.cbMcShowPass = new Krypton.Toolkit.KryptonCheckBox();
            this.btnMcCreate = new Krypton.Toolkit.KryptonButton();
            this.txtMcPassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtMcUsername = new Krypton.Toolkit.KryptonTextBox();
            this.txtMcEmail = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cbMcSecretary);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.cbMcShowPass);
            this.kryptonPanel1.Controls.Add(this.btnMcCreate);
            this.kryptonPanel1.Controls.Add(this.txtMcPassword);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.txtMcUsername);
            this.kryptonPanel1.Controls.Add(this.txtMcEmail);
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
            // cbMcSecretary
            // 
            this.cbMcSecretary.AutoSize = false;
            this.cbMcSecretary.Location = new System.Drawing.Point(15, 399);
            this.cbMcSecretary.Name = "cbMcSecretary";
            this.cbMcSecretary.Size = new System.Drawing.Size(110, 39);
            this.cbMcSecretary.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMcSecretary.TabIndex = 42;
            this.cbMcSecretary.ThreeState = true;
            this.cbMcSecretary.Values.Text = "Secretary";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(15, 366);
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
            this.cbMcShowPass.Location = new System.Drawing.Point(255, 309);
            this.cbMcShowPass.Name = "cbMcShowPass";
            this.cbMcShowPass.Size = new System.Drawing.Size(129, 39);
            this.cbMcShowPass.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMcShowPass.TabIndex = 39;
            this.cbMcShowPass.Values.Text = "Show Password";
            this.cbMcShowPass.CheckedChanged += new System.EventHandler(this.cbMcShowPass_CheckedChanged);
            // 
            // btnMcCreate
            // 
            this.btnMcCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMcCreate.Location = new System.Drawing.Point(123, 544);
            this.btnMcCreate.Name = "btnMcCreate";
            this.btnMcCreate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.OverrideDefault.Back.ColorAngle = 45F;
            this.btnMcCreate.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMcCreate.OverrideDefault.Border.Rounding = 5F;
            this.btnMcCreate.OverrideDefault.Border.Width = 1;
            this.btnMcCreate.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMcCreate.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMcCreate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnMcCreate.Size = new System.Drawing.Size(160, 44);
            this.btnMcCreate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.StateCommon.Back.ColorAngle = 45F;
            this.btnMcCreate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnMcCreate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnMcCreate.StateCommon.Border.ColorAngle = 45F;
            this.btnMcCreate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMcCreate.StateCommon.Border.Rounding = 5F;
            this.btnMcCreate.StateCommon.Border.Width = 1;
            this.btnMcCreate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMcCreate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMcCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMcCreate.StateDisabled.Border.Rounding = 5F;
            this.btnMcCreate.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.StateNormal.Border.Rounding = 5F;
            this.btnMcCreate.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMcCreate.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMcCreate.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnMcCreate.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnMcCreate.StatePressed.Back.ColorAngle = 130F;
            this.btnMcCreate.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnMcCreate.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnMcCreate.StatePressed.Border.ColorAngle = 130F;
            this.btnMcCreate.StatePressed.Border.Rounding = 5F;
            this.btnMcCreate.StatePressed.Border.Width = 1;
            this.btnMcCreate.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnMcCreate.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnMcCreate.StateTracking.Back.ColorAngle = 45F;
            this.btnMcCreate.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnMcCreate.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.StateTracking.Border.ColorAngle = 45F;
            this.btnMcCreate.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMcCreate.StateTracking.Border.Rounding = 5F;
            this.btnMcCreate.StateTracking.Border.Width = 1;
            this.btnMcCreate.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMcCreate.TabIndex = 38;
            this.btnMcCreate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnMcCreate.Values.Text = "Create";
            this.btnMcCreate.Click += new System.EventHandler(this.btnMcCreate_Click_1);
            // 
            // txtMcPassword
            // 
            this.txtMcPassword.Location = new System.Drawing.Point(15, 265);
            this.txtMcPassword.Multiline = true;
            this.txtMcPassword.Name = "txtMcPassword";
            this.txtMcPassword.PasswordChar = '●';
            this.txtMcPassword.Size = new System.Drawing.Size(369, 39);
            this.txtMcPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMcPassword.TabIndex = 11;
            this.txtMcPassword.ToolTipValues.Description = "";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(15, 240);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(98, 23);
            this.kryptonLabel6.StateCommon.Padding = new System.Windows.Forms.Padding(-2);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 10;
            this.kryptonLabel6.Values.Text = "Password";
            // 
            // txtMcUsername
            // 
            this.txtMcUsername.Location = new System.Drawing.Point(15, 187);
            this.txtMcUsername.Multiline = true;
            this.txtMcUsername.Name = "txtMcUsername";
            this.txtMcUsername.Size = new System.Drawing.Size(369, 39);
            this.txtMcUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMcUsername.TabIndex = 5;
            // 
            // txtMcEmail
            // 
            this.txtMcEmail.Location = new System.Drawing.Point(15, 107);
            this.txtMcEmail.Multiline = true;
            this.txtMcEmail.Name = "txtMcEmail";
            this.txtMcEmail.Size = new System.Drawing.Size(369, 39);
            this.txtMcEmail.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMcEmail.TabIndex = 4;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(15, 162);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(103, 23);
            this.kryptonLabel3.StateCommon.Padding = new System.Windows.Forms.Padding(-2);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Username";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 82);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(58, 23);
            this.kryptonLabel2.StateCommon.Padding = new System.Windows.Forms.Padding(-2);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Email";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(133, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(185, 33);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Create Account";
            // 
            // CreateUsersModalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "CreateUsersModalControl";
            this.Size = new System.Drawing.Size(398, 599);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonCheckBox cbMcShowPass;
        private Krypton.Toolkit.KryptonButton btnMcCreate;
        protected internal Krypton.Toolkit.KryptonTextBox txtMcPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        protected internal Krypton.Toolkit.KryptonTextBox txtMcUsername;
        protected internal Krypton.Toolkit.KryptonTextBox txtMcEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonCheckBox cbMcSecretary;
    }
}
