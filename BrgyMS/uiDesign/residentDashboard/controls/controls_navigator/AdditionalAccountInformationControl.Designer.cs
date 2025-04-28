namespace BrgyMS.uiDesign.residentDashboard.controls {
    partial class AdditionalAccountInformationControl
    {
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
        private void InitializeComponent()
        {
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            cboGender = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            cboSuffix = new Krypton.Toolkit.KryptonComboBox();
            txtLname = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            txtMname = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            txtUsername = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboSuffix).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.AutoScroll = true;
            kryptonPanel1.AutoSize = true;
            kryptonPanel1.Controls.Add(cboGender);
            kryptonPanel1.Controls.Add(kryptonLabel5);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Controls.Add(cboSuffix);
            kryptonPanel1.Controls.Add(txtLname);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Controls.Add(txtMname);
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(txtUsername);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Margin = new Padding(2);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(420, 450);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 0;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.DropDownWidth = 159;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(3, 376);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(412, 22);
            cboGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cboGender.TabIndex = 49;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(4, 345);
            kryptonLabel5.Margin = new Padding(2);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(87, 29);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 48;
            kryptonLabel5.Values.Text = "Gender";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(4, 278);
            kryptonLabel4.Margin = new Padding(2);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(69, 29);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 47;
            kryptonLabel4.Values.Text = "Suffix";
            // 
            // cboSuffix
            // 
            cboSuffix.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuffix.DropDownWidth = 159;
            cboSuffix.Items.AddRange(new object[] { "Jr. ", "Sr.", "III", "II" });
            cboSuffix.Location = new Point(4, 309);
            cboSuffix.Name = "cboSuffix";
            cboSuffix.Size = new Size(411, 22);
            cboSuffix.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cboSuffix.TabIndex = 46;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(4, 220);
            txtLname.Margin = new Padding(4, 3, 4, 3);
            txtLname.Multiline = true;
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(411, 40);
            txtLname.StateCommon.Back.Color1 = Color.White;
            txtLname.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtLname.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtLname.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtLname.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtLname.StateCommon.Border.Rounding = 5F;
            txtLname.StateCommon.Content.Color1 = Color.Gray;
            txtLname.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLname.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtLname.TabIndex = 8;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(4, 190);
            kryptonLabel3.Margin = new Padding(2);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(110, 29);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 7;
            kryptonLabel3.Values.Text = "Lastname";
            // 
            // txtMname
            // 
            txtMname.Location = new Point(4, 131);
            txtMname.Margin = new Padding(4, 3, 4, 3);
            txtMname.Multiline = true;
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(411, 40);
            txtMname.StateCommon.Back.Color1 = Color.White;
            txtMname.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtMname.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtMname.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtMname.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtMname.StateCommon.Border.Rounding = 5F;
            txtMname.StateCommon.Content.Color1 = Color.Gray;
            txtMname.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMname.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtMname.TabIndex = 6;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(4, 100);
            kryptonLabel2.Margin = new Padding(2);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(134, 29);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 5;
            kryptonLabel2.Values.Text = "Middlename";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(4, 44);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(411, 40);
            txtUsername.StateCommon.Back.Color1 = Color.White;
            txtUsername.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtUsername.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtUsername.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUsername.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtUsername.StateCommon.Border.Rounding = 5F;
            txtUsername.StateCommon.Content.Color1 = Color.Gray;
            txtUsername.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtUsername.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(4, 14);
            kryptonLabel1.Margin = new Padding(2);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(111, 29);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Firstname";
            // 
            // PersonalAccountInformationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Margin = new Padding(2);
            Name = "PersonalAccountInformationControl";
            Size = new Size(420, 450);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboSuffix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtMname;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonTextBox txtLname;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox cboSuffix;
        private Krypton.Toolkit.KryptonComboBox cboGender;
    }
}
