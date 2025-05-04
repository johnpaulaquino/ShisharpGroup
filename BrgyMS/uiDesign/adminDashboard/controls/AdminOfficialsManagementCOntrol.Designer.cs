namespace BrgyMS.uiDesign.adminDashboard.controls {
    partial class AdminOfficialsManagementControl {
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
            components = new System.ComponentModel.Container();
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
            dataGridOFficialsable = new Krypton.Toolkit.KryptonDataGridView();
            id = new DataGridViewTextBoxColumn();
            col1 = new DataGridViewTextBoxColumn();
            col2 = new DataGridViewTextBoxColumn();
            col3 = new DataGridViewTextBoxColumn();
            col4 = new DataGridViewTextBoxColumn();
            col5 = new DataGridViewTextBoxColumn();
            ctxOfficials = new ContextMenuStrip(components);
            updateBlotterToolStripMenuItem = new ToolStripMenuItem();
            deleteBlotterToolStripMenuItem = new ToolStripMenuItem();
            pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOFficialsable).BeginInit();
            ctxOfficials.SuspendLayout();
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
            nudLimit.Location = new Point(82, 139);
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
            kryptonLabel3.Location = new Point(32, 141);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(44, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F);
            kryptonLabel3.TabIndex = 12;
            kryptonLabel3.Values.Text = "Show";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel4.Location = new Point(143, 141);
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
            kryptonSeparator1.Size = new Size(944, 5);
            kryptonSeparator1.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(kryptonLabel5);
            kryptonPanel1.Controls.Add(kryptonDateTimePicker1);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(dtpkStartDate);
            kryptonPanel1.Controls.Add(dataGridOFficialsable);
            kryptonPanel1.Controls.Add(nudLimit);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Location = new Point(0, 83);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(944, 594);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 1;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(560, 65);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(101, 26);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 26;
            kryptonLabel5.Values.Text = "Start Date";
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.Location = new Point(677, 65);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(251, 25);
            kryptonDateTimePicker1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F);
            kryptonDateTimePicker1.TabIndex = 25;
            kryptonDateTimePicker1.ValueNullable = new DateTime(2025, 4, 28, 8, 54, 50, 0);
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(560, 135);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(94, 26);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 24;
            kryptonLabel1.Values.Text = "End Date";
            // 
            // dtpkStartDate
            // 
            dtpkStartDate.Format = DateTimePickerFormat.Custom;
            dtpkStartDate.Location = new Point(677, 135);
            dtpkStartDate.Name = "dtpkStartDate";
            dtpkStartDate.Size = new Size(251, 25);
            dtpkStartDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F);
            dtpkStartDate.TabIndex = 23;
            dtpkStartDate.ValueNullable = new DateTime(2025, 4, 28, 0, 0, 0, 0);
            // 
            // dataGridOFficialsable
            // 
            dataGridOFficialsable.AccessibleRole = AccessibleRole.None;
            dataGridOFficialsable.AllowDrop = true;
            dataGridOFficialsable.AllowUserToAddRows = false;
            dataGridOFficialsable.AllowUserToDeleteRows = false;
            dataGridOFficialsable.AllowUserToResizeColumns = false;
            dataGridOFficialsable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOFficialsable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridOFficialsable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridOFficialsable.AutoGenerateKryptonColumns = false;
            dataGridOFficialsable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOFficialsable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridOFficialsable.BorderStyle = BorderStyle.None;
            dataGridOFficialsable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOFficialsable.Columns.AddRange(new DataGridViewColumn[] { id, col1, col2, col3, col4, col5 });
            dataGridOFficialsable.ContextMenuStrip = ctxOfficials;
            dataGridOFficialsable.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridOFficialsable.Location = new Point(36, 184);
            dataGridOFficialsable.MultiSelect = false;
            dataGridOFficialsable.Name = "dataGridOFficialsable";
            dataGridOFficialsable.RowHeadersVisible = false;
            dataGridOFficialsable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOFficialsable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridOFficialsable.ScrollBars = ScrollBars.Vertical;
            dataGridOFficialsable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridOFficialsable.Size = new Size(892, 375);
            dataGridOFficialsable.StateCommon.Background.Color1 = Color.White;
            dataGridOFficialsable.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dataGridOFficialsable.StateCommon.DataCell.Border.Color1 = Color.DimGray;
            dataGridOFficialsable.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dataGridOFficialsable.StateCommon.DataCell.Content.Padding = new Padding(10);
            dataGridOFficialsable.StateCommon.HeaderColumn.Back.Color1 = Color.White;
            dataGridOFficialsable.StateCommon.HeaderColumn.Back.Color2 = Color.White;
            dataGridOFficialsable.StateCommon.HeaderColumn.Border.Color1 = Color.DimGray;
            dataGridOFficialsable.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dataGridOFficialsable.StateCommon.HeaderColumn.Border.Width = 2;
            dataGridOFficialsable.StateCommon.HeaderColumn.Content.Color1 = Color.DimGray;
            dataGridOFficialsable.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridOFficialsable.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridOFficialsable.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridOFficialsable.TabIndex = 18;
            dataGridOFficialsable.ToolTipShadow = false;
            dataGridOFficialsable.MouseDown += dataGridOFficialsable_MouseDown;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // col1
            // 
            col1.HeaderText = "Complainant ID";
            col1.Name = "col1";
            col1.ReadOnly = true;
            // 
            // col2
            // 
            col2.HeaderText = "Respondent ID";
            col2.Name = "col2";
            col2.ReadOnly = true;
            // 
            // col3
            // 
            col3.HeaderText = "Status";
            col3.Name = "col3";
            col3.ReadOnly = true;
            // 
            // col4
            // 
            col4.HeaderText = "Statements";
            col4.Name = "col4";
            col4.ReadOnly = true;
            // 
            // col5
            // 
            col5.HeaderText = "Date Filed";
            col5.Name = "col5";
            col5.ReadOnly = true;
            // 
            // ctxOfficials
            // 
            ctxOfficials.Font = new Font("Segoe UI", 9F);
            ctxOfficials.Items.AddRange(new ToolStripItem[] { updateBlotterToolStripMenuItem, deleteBlotterToolStripMenuItem });
            ctxOfficials.Name = "ctxBlotter";
            ctxOfficials.Size = new Size(211, 70);
            // 
            // updateBlotterToolStripMenuItem
            // 
            updateBlotterToolStripMenuItem.Name = "updateBlotterToolStripMenuItem";
            updateBlotterToolStripMenuItem.Size = new Size(210, 22);
            updateBlotterToolStripMenuItem.Text = "Update Barangay Officials";
            updateBlotterToolStripMenuItem.Click += updateBlotterToolStripMenuItem_Click;
            // 
            // deleteBlotterToolStripMenuItem
            // 
            deleteBlotterToolStripMenuItem.Name = "deleteBlotterToolStripMenuItem";
            deleteBlotterToolStripMenuItem.Size = new Size(210, 22);
            deleteBlotterToolStripMenuItem.Text = "Delete Barangay  Officials";
            deleteBlotterToolStripMenuItem.Click += deleteBlotterToolStripMenuItem_Click;
            // 
            // pnlMainContentControler
            // 
            pnlMainContentControler.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlMainContentControler.Controls.Add(kryptonPanel2);
            pnlMainContentControler.Controls.Add(kryptonPanel1);
            pnlMainContentControler.Location = new Point(0, -35);
            pnlMainContentControler.Name = "pnlMainContentControler";
            pnlMainContentControler.Size = new Size(944, 677);
            pnlMainContentControler.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel2.Controls.Add(kryptonSeparator1);
            kryptonPanel2.Controls.Add(kryptonLabel2);
            kryptonPanel2.Location = new Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(944, 80);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kryptonLabel2.Location = new Point(36, 48);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(321, 29);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Barangay Officials Management";
            // 
            // AdminOfficialsManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMainContentControler);
            Name = "AdminOfficialsManagementControl";
            Size = new Size(944, 607);
            Load += AdminOfficialsManagementControl_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOFficialsable).EndInit();
            ctxOfficials.ResumeLayout(false);
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
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpkStartDate;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn col1;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn col4;
        private DataGridViewTextBoxColumn col5;
        protected internal Krypton.Toolkit.KryptonDataGridView dataGridOFficialsable;
        private ContextMenuStrip ctxOfficials;
        private ToolStripMenuItem updateBlotterToolStripMenuItem;
        private ToolStripMenuItem deleteBlotterToolStripMenuItem;
    }
}
