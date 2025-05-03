namespace BrgyMS.uiDesign.usersDashboard.secretary_controls {
    partial class SecretaryOfficialsControl {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            nudLimit = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnAddOfficials = new Krypton.Toolkit.KryptonButton();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            dtpkStartDate = new Krypton.Toolkit.KryptonDateTimePicker();
            dataGridOfficalsTable = new Krypton.Toolkit.KryptonDataGridView();
            id = new DataGridViewTextBoxColumn();
            colusername = new DataGridViewTextBoxColumn();
            colrole = new DataGridViewTextBoxColumn();
            colactions = new DataGridViewTextBoxColumn();
            colaffectedtable = new DataGridViewTextBoxColumn();
            pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOfficalsTable).BeginInit();
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
            kryptonPanel1.Controls.Add(btnAddOfficials);
            kryptonPanel1.Controls.Add(kryptonLabel5);
            kryptonPanel1.Controls.Add(kryptonDateTimePicker1);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(dtpkStartDate);
            kryptonPanel1.Controls.Add(dataGridOfficalsTable);
            kryptonPanel1.Controls.Add(nudLimit);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Location = new Point(0, 83);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(944, 594);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 1;
            // 
            // btnAddOfficials
            // 
            btnAddOfficials.Location = new Point(32, 45);
            btnAddOfficials.Margin = new Padding(4, 3, 4, 3);
            btnAddOfficials.Name = "btnAddOfficials";
            btnAddOfficials.OverrideDefault.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.OverrideDefault.Back.ColorAngle = 45F;
            btnAddOfficials.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAddOfficials.OverrideDefault.Border.Rounding = 5F;
            btnAddOfficials.OverrideDefault.Border.Width = 1;
            btnAddOfficials.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnAddOfficials.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnAddOfficials.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAddOfficials.Size = new Size(164, 45);
            btnAddOfficials.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.StateCommon.Back.ColorAngle = 45F;
            btnAddOfficials.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAddOfficials.StateCommon.Border.Color2 = Color.FromArgb(6, 174, 244);
            btnAddOfficials.StateCommon.Border.ColorAngle = 45F;
            btnAddOfficials.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAddOfficials.StateCommon.Border.Rounding = 5F;
            btnAddOfficials.StateCommon.Border.Width = 1;
            btnAddOfficials.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddOfficials.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddOfficials.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddOfficials.StateDisabled.Border.Rounding = 5F;
            btnAddOfficials.StateNormal.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.StateNormal.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.StateNormal.Border.Rounding = 5F;
            btnAddOfficials.StateNormal.Content.ShortText.Color1 = Color.White;
            btnAddOfficials.StateNormal.Content.ShortText.Color2 = Color.White;
            btnAddOfficials.StatePressed.Back.Color1 = Color.White;
            btnAddOfficials.StatePressed.Back.Color2 = Color.White;
            btnAddOfficials.StatePressed.Back.ColorAngle = 130F;
            btnAddOfficials.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnAddOfficials.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnAddOfficials.StatePressed.Border.ColorAngle = 130F;
            btnAddOfficials.StatePressed.Border.Rounding = 5F;
            btnAddOfficials.StatePressed.Border.Width = 1;
            btnAddOfficials.StatePressed.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.StatePressed.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnAddOfficials.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnAddOfficials.StateTracking.Back.ColorAngle = 45F;
            btnAddOfficials.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAddOfficials.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.StateTracking.Border.ColorAngle = 45F;
            btnAddOfficials.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAddOfficials.StateTracking.Border.Rounding = 5F;
            btnAddOfficials.StateTracking.Border.Width = 1;
            btnAddOfficials.StateTracking.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.StateTracking.Content.ShortText.Color2 = Color.FromArgb(8, 142, 254);
            btnAddOfficials.TabIndex = 38;
            btnAddOfficials.Values.DropDownArrowColor = Color.Empty;
            btnAddOfficials.Values.Text = "Add Officials";
            btnAddOfficials.Click += btnBlotter_Click;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(560, 76);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(101, 26);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel5.TabIndex = 26;
            kryptonLabel5.Values.Text = "Start Date";
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.Location = new Point(677, 76);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(251, 25);
            kryptonDateTimePicker1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F);
            kryptonDateTimePicker1.TabIndex = 25;
            kryptonDateTimePicker1.ValueNullable = new DateTime(2025, 4, 28, 8, 54, 50, 0);
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(560, 146);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(94, 26);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 24;
            kryptonLabel1.Values.Text = "End Date";
            // 
            // dtpkStartDate
            // 
            dtpkStartDate.Format = DateTimePickerFormat.Custom;
            dtpkStartDate.Location = new Point(677, 146);
            dtpkStartDate.Name = "dtpkStartDate";
            dtpkStartDate.Size = new Size(251, 25);
            dtpkStartDate.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F);
            dtpkStartDate.TabIndex = 23;
            dtpkStartDate.ValueNullable = new DateTime(2025, 4, 28, 0, 0, 0, 0);
            // 
            // dataGridOfficalsTable
            // 
            dataGridOfficalsTable.AccessibleRole = AccessibleRole.None;
            dataGridOfficalsTable.AllowDrop = true;
            dataGridOfficalsTable.AllowUserToAddRows = false;
            dataGridOfficalsTable.AllowUserToDeleteRows = false;
            dataGridOfficalsTable.AllowUserToResizeColumns = false;
            dataGridOfficalsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOfficalsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridOfficalsTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridOfficalsTable.AutoGenerateKryptonColumns = false;
            dataGridOfficalsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOfficalsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridOfficalsTable.BorderStyle = BorderStyle.None;
            dataGridOfficalsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOfficalsTable.Columns.AddRange(new DataGridViewColumn[] { id, colusername, colrole, colactions, colaffectedtable });
            dataGridOfficalsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridOfficalsTable.Location = new Point(36, 184);
            dataGridOfficalsTable.MultiSelect = false;
            dataGridOfficalsTable.Name = "dataGridOfficalsTable";
            dataGridOfficalsTable.RowHeadersVisible = false;
            dataGridOfficalsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridOfficalsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridOfficalsTable.ScrollBars = ScrollBars.Vertical;
            dataGridOfficalsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridOfficalsTable.Size = new Size(892, 375);
            dataGridOfficalsTable.StateCommon.Background.Color1 = Color.White;
            dataGridOfficalsTable.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dataGridOfficalsTable.StateCommon.DataCell.Border.Color1 = Color.DimGray;
            dataGridOfficalsTable.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dataGridOfficalsTable.StateCommon.DataCell.Content.Padding = new Padding(10);
            dataGridOfficalsTable.StateCommon.HeaderColumn.Back.Color1 = Color.White;
            dataGridOfficalsTable.StateCommon.HeaderColumn.Back.Color2 = Color.White;
            dataGridOfficalsTable.StateCommon.HeaderColumn.Border.Color1 = Color.DimGray;
            dataGridOfficalsTable.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dataGridOfficalsTable.StateCommon.HeaderColumn.Border.Width = 2;
            dataGridOfficalsTable.StateCommon.HeaderColumn.Content.Color1 = Color.DimGray;
            dataGridOfficalsTable.StateCommon.HeaderColumn.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridOfficalsTable.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridOfficalsTable.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dataGridOfficalsTable.TabIndex = 18;
            dataGridOfficalsTable.ToolTipShadow = false;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // colusername
            // 
            colusername.HeaderText = "Document Type";
            colusername.Name = "colusername";
            colusername.ReadOnly = true;
            // 
            // colrole
            // 
            colrole.HeaderText = "Status";
            colrole.Name = "colrole";
            colrole.ReadOnly = true;
            // 
            // colactions
            // 
            colactions.HeaderText = "Request Date";
            colactions.Name = "colactions";
            colactions.ReadOnly = true;
            // 
            // colaffectedtable
            // 
            colaffectedtable.HeaderText = "Purpose";
            colaffectedtable.Name = "colaffectedtable";
            colaffectedtable.ReadOnly = true;
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
            // SecretaryOfficialsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMainContentControler);
            Name = "SecretaryOfficialsControl";
            Size = new Size(944, 607);
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOfficalsTable).EndInit();
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
        private Krypton.Toolkit.KryptonDataGridView dataGridOfficalsTable;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpkStartDate;
        private Krypton.Toolkit.KryptonButton btnAddOfficials;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colusername;
        private DataGridViewTextBoxColumn colrole;
        private DataGridViewTextBoxColumn colactions;
        private DataGridViewTextBoxColumn colaffectedtable;
    }
}
