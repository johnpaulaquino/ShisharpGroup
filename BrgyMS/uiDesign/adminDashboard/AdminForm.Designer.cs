namespace BrgyMS.uiDesign {
    partial class AdminForm {
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            pnlMainContainer = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            cboFilter = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            dataGridAdminDashboard = new Krypton.Toolkit.KryptonDataGridView();
            id = new DataGridViewTextBoxColumn();
            colemail = new DataGridViewTextBoxColumn();
            colrole = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colfullname = new DataGridViewTextBoxColumn();
            colgender = new DataGridViewTextBoxColumn();
            colbday = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            colcontact = new DataGridViewTextBoxColumn();
            colrtype = new DataGridViewTextBoxColumn();
            nudLimit = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            txtSearch = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            pnlRighSeperator = new Krypton.Toolkit.KryptonPanel();
            pnlRightSeperator = new Krypton.Toolkit.KryptonPanel();
            pnlTopSeperator = new Krypton.Toolkit.KryptonPanel();
            pnlSidebar = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            picMenuButton = new Krypton.Toolkit.KryptonPictureBox();
            kryptonTaskDialog1 = new Krypton.Toolkit.KryptonTaskDialog();
            ((System.ComponentModel.ISupportInitialize)pnlMainContainer).BeginInit();
            pnlMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAdminDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlRighSeperator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlRightSeperator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlTopSeperator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlSidebar).BeginInit();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMenuButton).BeginInit();
            SuspendLayout();
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlMainContainer.CausesValidation = false;
            pnlMainContainer.Controls.Add(kryptonPanel2);
            pnlMainContainer.Controls.Add(pnlTopSeperator);
            pnlMainContainer.Controls.Add(pnlSidebar);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(0, 0);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Size = new Size(1224, 684);
            pnlMainContainer.StateCommon.Color1 = SystemColors.AppWorkspace;
            pnlMainContainer.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(cboFilter);
            kryptonPanel2.Controls.Add(kryptonLabel5);
            kryptonPanel2.Controls.Add(kryptonPanel5);
            kryptonPanel2.Controls.Add(kryptonPanel1);
            kryptonPanel2.Controls.Add(kryptonPanel3);
            kryptonPanel2.Controls.Add(pnlRighSeperator);
            kryptonPanel2.Controls.Add(pnlRightSeperator);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(100, 49);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1124, 635);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.TabIndex = 6;
            // 
            // cboFilter
            // 
            cboFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilter.DropDownWidth = 203;
            cboFilter.Location = new Point(872, 45);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(203, 22);
            cboFilter.StateCommon.ComboBox.Border.Color1 = Color.Transparent;
            cboFilter.StateCommon.ComboBox.Border.Color2 = Color.Transparent;
            cboFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cboFilter.TabIndex = 13;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(53, 38);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(62, 29);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonLabel5.TabIndex = 3;
            kryptonLabel5.Target = this;
            kryptonLabel5.Values.Text = "Filter";
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Dock = DockStyle.Bottom;
            kryptonPanel5.Location = new Point(25, 80);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.Size = new Size(1074, 25);
            kryptonPanel5.StateCommon.Color1 = Color.FromArgb(220, 230, 224);
            kryptonPanel5.TabIndex = 12;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(25, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1074, 25);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(220, 230, 224);
            kryptonPanel1.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonPanel1.TabIndex = 5;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(kryptonLabel2);
            kryptonPanel3.Controls.Add(kryptonSeparator1);
            kryptonPanel3.Controls.Add(kryptonPanel4);
            kryptonPanel3.Dock = DockStyle.Bottom;
            kryptonPanel3.Location = new Point(25, 105);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(1074, 530);
            kryptonPanel3.StateCommon.Color1 = Color.White;
            kryptonPanel3.TabIndex = 5;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(28, 27);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(173, 29);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonLabel2.TabIndex = 2;
            kryptonLabel2.Values.Text = "User Information";
            // 
            // kryptonSeparator1
            // 
            kryptonSeparator1.Dock = DockStyle.Bottom;
            kryptonSeparator1.Location = new Point(0, 83);
            kryptonSeparator1.Name = "kryptonSeparator1";
            kryptonSeparator1.Size = new Size(1074, 5);
            kryptonSeparator1.TabIndex = 0;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(dataGridAdminDashboard);
            kryptonPanel4.Controls.Add(nudLimit);
            kryptonPanel4.Controls.Add(kryptonLabel3);
            kryptonPanel4.Controls.Add(txtSearch);
            kryptonPanel4.Controls.Add(kryptonLabel4);
            kryptonPanel4.Dock = DockStyle.Bottom;
            kryptonPanel4.Location = new Point(0, 88);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(1074, 442);
            kryptonPanel4.StateCommon.Color1 = Color.White;
            kryptonPanel4.TabIndex = 1;
            // 
            // dataGridAdminDashboard
            // 
            dataGridAdminDashboard.AllowUserToAddRows = false;
            dataGridAdminDashboard.AllowUserToDeleteRows = false;
            dataGridAdminDashboard.AllowUserToResizeRows = false;
            dataGridAdminDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridAdminDashboard.AutoGenerateKryptonColumns = false;
            dataGridAdminDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAdminDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridAdminDashboard.BorderStyle = BorderStyle.None;
            dataGridAdminDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAdminDashboard.Columns.AddRange(new DataGridViewColumn[] { id, colemail, colrole, colStatus, colfullname, colgender, colbday, age, colcontact, colrtype });
            dataGridAdminDashboard.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridAdminDashboard.Location = new Point(28, 105);
            dataGridAdminDashboard.MultiSelect = false;
            dataGridAdminDashboard.Name = "dataGridAdminDashboard";
            dataGridAdminDashboard.RowHeadersVisible = false;
            dataGridAdminDashboard.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridAdminDashboard.ScrollBars = ScrollBars.Vertical;
            dataGridAdminDashboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAdminDashboard.Size = new Size(1022, 337);
            dataGridAdminDashboard.StateCommon.Background.Color1 = Color.White;
            dataGridAdminDashboard.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dataGridAdminDashboard.StateCommon.DataCell.Border.Color1 = Color.DimGray;
            dataGridAdminDashboard.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Back.Color1 = Color.White;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Back.Color2 = Color.White;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Border.Color1 = Color.DimGray;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Border.Width = 2;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Content.Color1 = Color.DimGray;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridAdminDashboard.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridAdminDashboard.TabIndex = 11;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.BackColor = Color.White;
            id.DefaultCellStyle = dataGridViewCellStyle5;
            id.HeaderText = "ID";
            id.Name = "id";
            id.Resizable = DataGridViewTriState.False;
            id.Width = 55;
            // 
            // colemail
            // 
            dataGridViewCellStyle6.BackColor = Color.White;
            colemail.DefaultCellStyle = dataGridViewCellStyle6;
            colemail.HeaderText = "Email";
            colemail.Name = "colemail";
            colemail.Resizable = DataGridViewTriState.False;
            // 
            // colrole
            // 
            colrole.HeaderText = "Role";
            colrole.Name = "colrole";
            colrole.Resizable = DataGridViewTriState.False;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.Resizable = DataGridViewTriState.False;
            // 
            // colfullname
            // 
            colfullname.HeaderText = "Fullname";
            colfullname.Name = "colfullname";
            colfullname.Resizable = DataGridViewTriState.False;
            // 
            // colgender
            // 
            colgender.HeaderText = "Gender";
            colgender.Name = "colgender";
            colgender.Resizable = DataGridViewTriState.False;
            // 
            // colbday
            // 
            colbday.HeaderText = "Birthday";
            colbday.Name = "colbday";
            colbday.Resizable = DataGridViewTriState.False;
            // 
            // age
            // 
            age.HeaderText = "Age";
            age.Name = "age";
            age.Resizable = DataGridViewTriState.False;
            // 
            // colcontact
            // 
            colcontact.HeaderText = "Contact No.";
            colcontact.Name = "colcontact";
            colcontact.Resizable = DataGridViewTriState.False;
            // 
            // colrtype
            // 
            colrtype.HeaderText = "Resident Type";
            colrtype.Name = "colrtype";
            colrtype.Resizable = DataGridViewTriState.False;
            // 
            // nudLimit
            // 
            nudLimit.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudLimit.Location = new Point(88, 48);
            nudLimit.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudLimit.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudLimit.Name = "nudLimit";
            nudLimit.Size = new Size(55, 22);
            nudLimit.TabIndex = 4;
            nudLimit.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel3.Location = new Point(38, 50);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(44, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F);
            kryptonLabel3.TabIndex = 3;
            kryptonLabel3.Values.Text = "Show";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(800, 35);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 40);
            txtSearch.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.StateCommon.Content.Padding = new Padding(5, -1, 5, 15);
            txtSearch.TabIndex = 10;
            txtSearch.Text = "Search";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel4.Location = new Point(149, 50);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(53, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F);
            kryptonLabel4.TabIndex = 5;
            kryptonLabel4.Values.Text = "Entries";
            // 
            // pnlRighSeperator
            // 
            pnlRighSeperator.Dock = DockStyle.Left;
            pnlRighSeperator.Location = new Point(0, 0);
            pnlRighSeperator.Name = "pnlRighSeperator";
            pnlRighSeperator.Size = new Size(25, 635);
            pnlRighSeperator.StateCommon.Color1 = Color.FromArgb(220, 230, 224);
            pnlRighSeperator.TabIndex = 11;
            // 
            // pnlRightSeperator
            // 
            pnlRightSeperator.Dock = DockStyle.Right;
            pnlRightSeperator.Location = new Point(1099, 0);
            pnlRightSeperator.Name = "pnlRightSeperator";
            pnlRightSeperator.Size = new Size(25, 635);
            pnlRightSeperator.StateCommon.Color1 = Color.FromArgb(220, 230, 224);
            pnlRightSeperator.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            pnlRightSeperator.TabIndex = 4;
            // 
            // pnlTopSeperator
            // 
            pnlTopSeperator.Dock = DockStyle.Top;
            pnlTopSeperator.Location = new Point(100, 0);
            pnlTopSeperator.Name = "pnlTopSeperator";
            pnlTopSeperator.Size = new Size(1124, 49);
            pnlTopSeperator.StateCommon.Color1 = Color.White;
            pnlTopSeperator.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            pnlTopSeperator.TabIndex = 4;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(kryptonPanel6);
            pnlSidebar.Controls.Add(kryptonLabel1);
            pnlSidebar.Controls.Add(picMenuButton);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.RightToLeft = RightToLeft.No;
            pnlSidebar.Size = new Size(100, 684);
            pnlSidebar.StateCommon.Color1 = Color.IndianRed;
            pnlSidebar.StateCommon.Color2 = Color.IndianRed;
            pnlSidebar.StateCommon.ColorAngle = 100F;
            pnlSidebar.StateNormal.Color1 = Color.White;
            pnlSidebar.StateNormal.Color2 = Color.DimGray;
            pnlSidebar.StateNormal.ColorAngle = 100F;
            pnlSidebar.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            pnlSidebar.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            pnlSidebar.TabIndex = 0;
            // 
            // kryptonPanel6
            // 
            kryptonPanel6.Dock = DockStyle.Right;
            kryptonPanel6.Location = new Point(99, 0);
            kryptonPanel6.Name = "kryptonPanel6";
            kryptonPanel6.Size = new Size(1, 684);
            kryptonPanel6.StateCommon.Color1 = Color.FromArgb(220, 230, 224);
            kryptonPanel6.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(24, 361);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(36, 20);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Logs";
            // 
            // picMenuButton
            // 
            picMenuButton.Image = (Image)resources.GetObject("picMenuButton.Image");
            picMenuButton.InitialImage = null;
            picMenuButton.Location = new Point(35, 30);
            picMenuButton.Name = "picMenuButton";
            picMenuButton.Size = new Size(25, 25);
            picMenuButton.SizeMode = PictureBoxSizeMode.Zoom;
            picMenuButton.TabIndex = 1;
            picMenuButton.TabStop = false;
            // 
            // kryptonTaskDialog1
            // 
            kryptonTaskDialog1.CheckboxText = null;
            kryptonTaskDialog1.Content = null;
            kryptonTaskDialog1.DefaultRadioButton = null;
            kryptonTaskDialog1.FooterHyperlink = null;
            kryptonTaskDialog1.FooterText = null;
            kryptonTaskDialog1.MainInstruction = null;
            kryptonTaskDialog1.TextExtra = "Ctrl+C to copy";
            kryptonTaskDialog1.UseNativeOSIcons = false;
            kryptonTaskDialog1.WindowTitle = null;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 684);
            Controls.Add(pnlMainContainer);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pnlMainContainer).EndInit();
            pnlMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAdminDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlRighSeperator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlRightSeperator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlTopSeperator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlSidebar).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMenuButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnlMainContainer;
        private Krypton.Toolkit.KryptonPanel pnlSidebar;
        private Krypton.Toolkit.KryptonPictureBox picMenuButton;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn Column1;
        private Krypton.Toolkit.KryptonTaskDialog kryptonTaskDialog1;
        private Krypton.Toolkit.KryptonPanel pnlRightSeperator;
        private Krypton.Toolkit.KryptonPanel pnlTopSeperator;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonNumericUpDown nudLimit;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonDataGridView dataGridAdminDashboard;
        private Krypton.Toolkit.KryptonPanel pnlRighSeperator;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Krypton.Toolkit.KryptonComboBox cboFilter;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colemail;
        private DataGridViewTextBoxColumn colrole;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colfullname;
        private DataGridViewTextBoxColumn colgender;
        private DataGridViewTextBoxColumn colbday;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn colcontact;
        private DataGridViewTextBoxColumn colrtype;
    }
}