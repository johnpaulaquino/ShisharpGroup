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
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            cboSuffix = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            kryptonComboBox2 = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboSuffix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.AutoScroll = true;
            kryptonPanel1.AutoSize = true;
            kryptonPanel1.Controls.Add(kryptonPanel2);
            kryptonPanel1.Controls.Add(kryptonLabel9);
            kryptonPanel1.Controls.Add(kryptonTextBox3);
            kryptonPanel1.Controls.Add(kryptonLabel8);
            kryptonPanel1.Controls.Add(kryptonTextBox2);
            kryptonPanel1.Controls.Add(kryptonTextBox1);
            kryptonPanel1.Controls.Add(kryptonLabel7);
            kryptonPanel1.Controls.Add(kryptonDateTimePicker1);
            kryptonPanel1.Controls.Add(kryptonLabel6);
            kryptonPanel1.Controls.Add(kryptonComboBox2);
            kryptonPanel1.Controls.Add(kryptonComboBox1);
            kryptonPanel1.Controls.Add(btnLogin);
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Controls.Add(cboGender);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Controls.Add(cboSuffix);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Margin = new Padding(2);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(420, 450);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 0;
            kryptonPanel1.Paint += kryptonPanel1_Paint;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.DropDownWidth = 159;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cboGender.Location = new Point(9, 803);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(386, 22);
            cboGender.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 14.25F);
            cboGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cboGender.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F);
            cboGender.TabIndex = 49;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(12, 769);
            kryptonLabel4.Margin = new Padding(2);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(155, 29);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 47;
            kryptonLabel4.Values.Text = "Resident Type";
            // 
            // cboSuffix
            // 
            cboSuffix.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuffix.DropDownWidth = 159;
            cboSuffix.Items.AddRange(new object[] { "Jr. ", "Sr.", "III", "II" });
            cboSuffix.Location = new Point(12, 725);
            cboSuffix.Name = "cboSuffix";
            cboSuffix.Size = new Size(388, 22);
            cboSuffix.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 14.25F);
            cboSuffix.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cboSuffix.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F);
            cboSuffix.TabIndex = 46;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(12, 691);
            kryptonLabel3.Margin = new Padding(2);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(204, 29);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 7;
            kryptonLabel3.Values.Text = "Employment Status";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(12, 529);
            kryptonLabel2.Margin = new Padding(2);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(246, 29);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 5;
            kryptonLabel2.Values.Text = "Educational Attaintment";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 614);
            kryptonLabel1.Margin = new Padding(2);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(124, 29);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Civil Status";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Location = new Point(132, 12);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(150, 143);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 51;
            kryptonPictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(132, 161);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Back.ColorAngle = 45F;
            btnLogin.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.OverrideDefault.Border.Rounding = 5F;
            btnLogin.OverrideDefault.Border.Width = 1;
            btnLogin.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnLogin.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLogin.Size = new Size(150, 42);
            btnLogin.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateCommon.Back.ColorAngle = 45F;
            btnLogin.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLogin.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            btnLogin.StateCommon.Border.ColorAngle = 45F;
            btnLogin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.StateCommon.Border.Rounding = 5F;
            btnLogin.StateCommon.Border.Width = 1;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.StateDisabled.Border.Rounding = 5F;
            btnLogin.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateNormal.Border.Rounding = 5F;
            btnLogin.StateNormal.Content.ShortText.Color1 = Color.White;
            btnLogin.StateNormal.Content.ShortText.Color2 = Color.White;
            btnLogin.StatePressed.Back.Color1 = Color.White;
            btnLogin.StatePressed.Back.Color2 = Color.White;
            btnLogin.StatePressed.Back.ColorAngle = 130F;
            btnLogin.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnLogin.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnLogin.StatePressed.Border.ColorAngle = 130F;
            btnLogin.StatePressed.Border.Rounding = 5F;
            btnLogin.StatePressed.Border.Width = 1;
            btnLogin.StatePressed.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StatePressed.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnLogin.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnLogin.StateTracking.Back.ColorAngle = 45F;
            btnLogin.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLogin.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.StateTracking.Border.ColorAngle = 45F;
            btnLogin.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLogin.StateTracking.Border.Rounding = 5F;
            btnLogin.StateTracking.Border.Width = 1;
            btnLogin.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnLogin.StateTracking.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnLogin.TabIndex = 52;
            btnLogin.Values.DropDownArrowColor = Color.Empty;
            btnLogin.Values.Text = "Upload";
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            kryptonComboBox1.DropDownWidth = 159;
            kryptonComboBox1.Items.AddRange(new object[] { "Jr. ", "Sr.", "III", "II" });
            kryptonComboBox1.Location = new Point(12, 563);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(388, 28);
            kryptonComboBox1.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 14.25F);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F);
            kryptonComboBox1.TabIndex = 53;
            // 
            // kryptonComboBox2
            // 
            kryptonComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            kryptonComboBox2.DropDownWidth = 159;
            kryptonComboBox2.Items.AddRange(new object[] { "Jr. ", "Sr.", "III", "II" });
            kryptonComboBox2.Location = new Point(12, 648);
            kryptonComboBox2.Name = "kryptonComboBox2";
            kryptonComboBox2.Size = new Size(388, 22);
            kryptonComboBox2.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 14.25F);
            kryptonComboBox2.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox2.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F);
            kryptonComboBox2.TabIndex = 54;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(12, 232);
            kryptonLabel6.Margin = new Padding(2);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(94, 29);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel6.TabIndex = 55;
            kryptonLabel6.Values.Text = "Birthday";
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.Location = new Point(12, 275);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(270, 25);
            kryptonDateTimePicker1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonDateTimePicker1.TabIndex = 56;
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(287, 232);
            kryptonLabel7.Margin = new Padding(2);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(53, 29);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel7.TabIndex = 57;
            kryptonLabel7.Values.Text = "Age";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(287, 266);
            kryptonTextBox1.Multiline = true;
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(100, 45);
            kryptonTextBox1.TabIndex = 58;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(12, 360);
            kryptonTextBox2.Multiline = true;
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(378, 45);
            kryptonTextBox2.TabIndex = 59;
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(12, 326);
            kryptonLabel8.Margin = new Padding(2);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(129, 29);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel8.TabIndex = 60;
            kryptonLabel8.Values.Text = "Contact No.";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(12, 425);
            kryptonLabel9.Margin = new Padding(2);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(93, 29);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel9.TabIndex = 62;
            kryptonLabel9.Values.Text = "Religion";
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.Location = new Point(12, 459);
            kryptonTextBox3.Multiline = true;
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(378, 45);
            kryptonTextBox3.TabIndex = 61;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Location = new Point(188, 831);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(28, 30);
            kryptonPanel2.TabIndex = 63;
            // 
            // AdditionalAccountInformationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Margin = new Padding(2);
            Name = "AdditionalAccountInformationControl";
            Size = new Size(420, 450);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboSuffix).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox cboSuffix;
        private Krypton.Toolkit.KryptonComboBox cboGender;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}
