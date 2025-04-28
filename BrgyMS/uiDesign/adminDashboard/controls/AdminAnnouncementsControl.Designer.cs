namespace BrgyMS.uiDesign.adminDashboard.controls {
    partial class AdminAnnouncementsControl {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            nudLimit = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            dtpkStartDate = new Krypton.Toolkit.KryptonDateTimePicker();
            dataGridAdminDashboard = new Krypton.Toolkit.KryptonDataGridView();
            id = new DataGridViewTextBoxColumn();
            colemail = new DataGridViewTextBoxColumn();
            colrole = new DataGridViewTextBoxColumn();
            colfullname = new DataGridViewTextBoxColumn();
            colgender = new DataGridViewTextBoxColumn();
            colbday = new DataGridViewTextBoxColumn();
            colage = new DataGridViewTextBoxColumn();
            colcontact = new DataGridViewTextBoxColumn();
            colrtype = new DataGridViewTextBoxColumn();
            pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAdminDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlMainContentControler).BeginInit();
            pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // nudLimit
            // 
            nudLimit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudLimit.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudLimit.Location = new Point(86, 33);
            nudLimit.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudLimit.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudLimit.Name = "nudLimit";
            nudLimit.Size = new Size(55, 22);
            nudLimit.TabIndex = 13;
            nudLimit.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel3.Location = new Point(36, 35);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(44, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F);
            kryptonLabel3.TabIndex = 12;
            kryptonLabel3.Values.Text = "Show";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel4.Location = new Point(147, 35);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(53, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F);
            kryptonLabel4.TabIndex = 14;
            kryptonLabel4.Values.Text = "Entries";
            // 
            // kryptonSeparator1
            // 
            kryptonSeparator1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonSeparator1.Location = new Point(-3, 78);
            kryptonSeparator1.Name = "kryptonSeparator1";
            kryptonSeparator1.Size = new Size(1125, 5);
            kryptonSeparator1.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(kryptonLabel5);
            kryptonPanel1.Controls.Add(kryptonDateTimePicker1);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(dtpkStartDate);
            kryptonPanel1.Controls.Add(dataGridAdminDashboard);
            kryptonPanel1.Controls.Add(nudLimit);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Location = new Point(0, 83);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1125, 594);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 1;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(731, 26);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(101, 26);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 22;
            kryptonLabel5.Values.Text = "Start Date";
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.Location = new Point(848, 26);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(251, 29);
            kryptonDateTimePicker1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonDateTimePicker1.TabIndex = 21;
            kryptonDateTimePicker1.ValueNullable = new DateTime(2025, 4, 28, 8, 54, 50, 0);
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(731, 85);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(94, 26);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 20;
            kryptonLabel1.Values.Text = "End Date";
            // 
            // dtpkStartDate
            // 
            dtpkStartDate.Location = new Point(848, 85);
            dtpkStartDate.Name = "dtpkStartDate";
            dtpkStartDate.Size = new Size(251, 29);
            dtpkStartDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpkStartDate.TabIndex = 19;
            dtpkStartDate.ValueNullable = new DateTime(2025, 4, 28, 0, 0, 0, 0);
            // 
            // dataGridAdminDashboard
            // 
            dataGridAdminDashboard.AccessibleRole = AccessibleRole.None;
            dataGridAdminDashboard.AllowDrop = true;
            dataGridAdminDashboard.AllowUserToAddRows = false;
            dataGridAdminDashboard.AllowUserToDeleteRows = false;
            dataGridAdminDashboard.AllowUserToResizeColumns = false;
            dataGridAdminDashboard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridAdminDashboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAdminDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridAdminDashboard.AutoGenerateKryptonColumns = false;
            dataGridAdminDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAdminDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridAdminDashboard.BorderStyle = BorderStyle.None;
            dataGridAdminDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAdminDashboard.Columns.AddRange(new DataGridViewColumn[] { id, colemail, colrole, colfullname, colgender, colbday, colage, colcontact, colrtype });
            dataGridAdminDashboard.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridAdminDashboard.Location = new Point(26, 150);
            dataGridAdminDashboard.MultiSelect = false;
            dataGridAdminDashboard.Name = "dataGridAdminDashboard";
            dataGridAdminDashboard.RowHeadersVisible = false;
            dataGridAdminDashboard.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridAdminDashboard.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridAdminDashboard.ScrollBars = ScrollBars.Vertical;
            dataGridAdminDashboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAdminDashboard.Size = new Size(1073, 428);
            dataGridAdminDashboard.StateCommon.Background.Color1 = Color.White;
            dataGridAdminDashboard.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dataGridAdminDashboard.StateCommon.DataCell.Border.Color1 = Color.DimGray;
            dataGridAdminDashboard.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dataGridAdminDashboard.StateCommon.DataCell.Content.Padding = new Padding(10);
            dataGridAdminDashboard.StateCommon.HeaderColumn.Back.Color1 = Color.White;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Back.Color2 = Color.White;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Border.Color1 = Color.DimGray;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Border.Width = 2;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Content.Color1 = Color.DimGray;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridAdminDashboard.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridAdminDashboard.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridAdminDashboard.TabIndex = 18;
            dataGridAdminDashboard.ToolTipShadow = false;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // colemail
            // 
            colemail.HeaderText = "Email";
            colemail.Name = "colemail";
            colemail.ReadOnly = true;
            // 
            // colrole
            // 
            colrole.HeaderText = "Role";
            colrole.Name = "colrole";
            colrole.ReadOnly = true;
            // 
            // colfullname
            // 
            colfullname.HeaderText = "Fullname";
            colfullname.Name = "colfullname";
            colfullname.ReadOnly = true;
            // 
            // colgender
            // 
            colgender.HeaderText = "Gender";
            colgender.Name = "colgender";
            colgender.ReadOnly = true;
            // 
            // colbday
            // 
            colbday.HeaderText = "Birthday";
            colbday.Name = "colbday";
            colbday.ReadOnly = true;
            // 
            // colage
            // 
            colage.HeaderText = "Age";
            colage.Name = "colage";
            colage.ReadOnly = true;
            // 
            // colcontact
            // 
            colcontact.HeaderText = "Contact No.";
            colcontact.Name = "colcontact";
            colcontact.ReadOnly = true;
            // 
            // colrtype
            // 
            colrtype.HeaderText = "Resident Type";
            colrtype.Name = "colrtype";
            colrtype.ReadOnly = true;
            // 
            // pnlMainContentControler
            // 
            pnlMainContentControler.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlMainContentControler.Controls.Add(kryptonPanel2);
            pnlMainContentControler.Controls.Add(kryptonPanel1);
            pnlMainContentControler.Location = new Point(0, -35);
            pnlMainContentControler.Name = "pnlMainContentControler";
            pnlMainContentControler.Size = new Size(1125, 677);
            pnlMainContentControler.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel2.Controls.Add(kryptonSeparator1);
            kryptonPanel2.Controls.Add(kryptonLabel2);
            kryptonPanel2.Location = new Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1125, 80);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.TabIndex = 2;
            kryptonPanel2.Paint += kryptonPanel2_Paint;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel2.Location = new Point(36, 43);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(291, 29);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Announcement Management";
            // 
            // AdminAnnouncementsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMainContentControler);
            Name = "AdminAnnouncementsControl";
            Size = new Size(1125, 607);
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAdminDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlMainContentControler).EndInit();
            pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonNumericUpDown nudLimit;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonDataGridView dataGridAdminDashboard;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colemail;
        private DataGridViewTextBoxColumn colrole;
        private DataGridViewTextBoxColumn colfullname;
        private DataGridViewTextBoxColumn colgender;
        private DataGridViewTextBoxColumn colbday;
        private DataGridViewTextBoxColumn colage;
        private DataGridViewTextBoxColumn colcontact;
        private DataGridViewTextBoxColumn colrtype;
        private Krypton.Toolkit.KryptonDateTimePicker dtpkStartDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
