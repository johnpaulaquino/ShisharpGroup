using System;
using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nudLimit = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnAddOfficials = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.dtpkStartDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dataGridOfficalsTable = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaffectedtable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfficalsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).BeginInit();
            this.pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudLimit
            // 
            this.nudLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLimit.Location = new System.Drawing.Point(70, 120);
            this.nudLimit.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(47, 22);
            this.nudLimit.TabIndex = 13;
            this.nudLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel3.Location = new System.Drawing.Point(27, 119);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(44, 19);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "Show";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel4.Location = new System.Drawing.Point(123, 119);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(53, 19);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Entries";
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonSeparator1.Location = new System.Drawing.Point(-3, 68);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(809, 4);
            this.kryptonSeparator1.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Controls.Add(this.btnAddOfficials);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonDateTimePicker1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.dtpkStartDate);
            this.kryptonPanel1.Controls.Add(this.dataGridOfficalsTable);
            this.kryptonPanel1.Controls.Add(this.nudLimit);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 72);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(809, 515);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnAddOfficials
            // 
            this.btnAddOfficials.Location = new System.Drawing.Point(27, 39);
            this.btnAddOfficials.Name = "btnAddOfficials";
            this.btnAddOfficials.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.OverrideDefault.Back.ColorAngle = 45F;
            this.btnAddOfficials.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddOfficials.OverrideDefault.Border.Rounding = 5F;
            this.btnAddOfficials.OverrideDefault.Border.Width = 1;
            this.btnAddOfficials.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddOfficials.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddOfficials.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddOfficials.Size = new System.Drawing.Size(141, 39);
            this.btnAddOfficials.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.StateCommon.Back.ColorAngle = 45F;
            this.btnAddOfficials.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddOfficials.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddOfficials.StateCommon.Border.ColorAngle = 45F;
            this.btnAddOfficials.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddOfficials.StateCommon.Border.Rounding = 5F;
            this.btnAddOfficials.StateCommon.Border.Width = 1;
            this.btnAddOfficials.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddOfficials.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddOfficials.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOfficials.StateDisabled.Border.Rounding = 5F;
            this.btnAddOfficials.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.StateNormal.Border.Rounding = 5F;
            this.btnAddOfficials.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddOfficials.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddOfficials.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnAddOfficials.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnAddOfficials.StatePressed.Back.ColorAngle = 130F;
            this.btnAddOfficials.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnAddOfficials.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnAddOfficials.StatePressed.Border.ColorAngle = 130F;
            this.btnAddOfficials.StatePressed.Border.Rounding = 5F;
            this.btnAddOfficials.StatePressed.Border.Width = 1;
            this.btnAddOfficials.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnAddOfficials.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnAddOfficials.StateTracking.Back.ColorAngle = 45F;
            this.btnAddOfficials.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnAddOfficials.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.StateTracking.Border.ColorAngle = 45F;
            this.btnAddOfficials.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddOfficials.StateTracking.Border.Rounding = 5F;
            this.btnAddOfficials.StateTracking.Border.Width = 1;
            this.btnAddOfficials.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnAddOfficials.TabIndex = 38;
            this.btnAddOfficials.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddOfficials.Values.Text = "Add Officials";
            this.btnAddOfficials.Click += new System.EventHandler(this.btnAddOfficials_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(480, 66);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(101, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 26;
            this.kryptonLabel5.Values.Text = "Start Date";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(580, 66);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(215, 25);
            this.kryptonDateTimePicker1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kryptonDateTimePicker1.TabIndex = 25;
            this.kryptonDateTimePicker1.ValueNullable = new System.DateTime(2025, 4, 28, 8, 54, 50, 0);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(480, 127);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(94, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 24;
            this.kryptonLabel1.Values.Text = "End Date";
            // 
            // dtpkStartDate
            // 
            this.dtpkStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkStartDate.Location = new System.Drawing.Point(580, 127);
            this.dtpkStartDate.Name = "dtpkStartDate";
            this.dtpkStartDate.Size = new System.Drawing.Size(215, 25);
            this.dtpkStartDate.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpkStartDate.TabIndex = 23;
            this.dtpkStartDate.ValueNullable = new System.DateTime(2025, 4, 28, 0, 0, 0, 0);
            // 
            // dataGridOfficalsTable
            // 
            this.dataGridOfficalsTable.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridOfficalsTable.AllowDrop = true;
            this.dataGridOfficalsTable.AllowUserToAddRows = false;
            this.dataGridOfficalsTable.AllowUserToDeleteRows = false;
            this.dataGridOfficalsTable.AllowUserToResizeColumns = false;
            this.dataGridOfficalsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridOfficalsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridOfficalsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOfficalsTable.AutoGenerateKryptonColumns = false;
            this.dataGridOfficalsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOfficalsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOfficalsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridOfficalsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOfficalsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colusername,
            this.colrole,
            this.colactions,
            this.colaffectedtable});
            this.dataGridOfficalsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridOfficalsTable.Location = new System.Drawing.Point(31, 159);
            this.dataGridOfficalsTable.MultiSelect = false;
            this.dataGridOfficalsTable.Name = "dataGridOfficalsTable";
            this.dataGridOfficalsTable.RowHeadersVisible = false;
            this.dataGridOfficalsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridOfficalsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridOfficalsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridOfficalsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOfficalsTable.Size = new System.Drawing.Size(765, 325);
            this.dataGridOfficalsTable.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridOfficalsTable.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridOfficalsTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridOfficalsTable.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridOfficalsTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridOfficalsTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dataGridOfficalsTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dataGridOfficalsTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridOfficalsTable.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridOfficalsTable.StateCommon.HeaderColumn.Border.Width = 2;
            this.dataGridOfficalsTable.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DimGray;
            this.dataGridOfficalsTable.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridOfficalsTable.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridOfficalsTable.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridOfficalsTable.TabIndex = 18;
            this.dataGridOfficalsTable.ToolTipShadow = false;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // colusername
            // 
            this.colusername.HeaderText = "Document Type";
            this.colusername.Name = "colusername";
            this.colusername.ReadOnly = true;
            // 
            // colrole
            // 
            this.colrole.HeaderText = "Status";
            this.colrole.Name = "colrole";
            this.colrole.ReadOnly = true;
            // 
            // colactions
            // 
            this.colactions.HeaderText = "Request Date";
            this.colactions.Name = "colactions";
            this.colactions.ReadOnly = true;
            // 
            // colaffectedtable
            // 
            this.colaffectedtable.HeaderText = "Purpose";
            this.colaffectedtable.Name = "colaffectedtable";
            this.colaffectedtable.ReadOnly = true;
            // 
            // pnlMainContentControler
            // 
            this.pnlMainContentControler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainContentControler.Controls.Add(this.kryptonPanel2);
            this.pnlMainContentControler.Controls.Add(this.kryptonPanel1);
            this.pnlMainContentControler.Location = new System.Drawing.Point(0, -30);
            this.pnlMainContentControler.Name = "pnlMainContentControler";
            this.pnlMainContentControler.Size = new System.Drawing.Size(809, 587);
            this.pnlMainContentControler.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel2.Controls.Add(this.kryptonSeparator1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(809, 69);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel2.Location = new System.Drawing.Point(31, 38);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(321, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Barangay Officials Management";
            // 
            // SecretaryOfficialsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContentControler);
            this.Name = "SecretaryOfficialsControl";
            this.Size = new System.Drawing.Size(809, 526);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfficalsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).EndInit();
            this.pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

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
