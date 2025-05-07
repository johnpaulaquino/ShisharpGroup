using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.secretary_controls {
    partial class SecretaryBlotterControl {
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
            this.kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnBlotter = new Krypton.Toolkit.KryptonButton();
            this.dataGridBlotterTable = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlotterTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).BeginInit();
            this.pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.kryptonPanel1.Controls.Add(this.btnBlotter);
            this.kryptonPanel1.Controls.Add(this.dataGridBlotterTable);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 72);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(809, 515);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnBlotter
            // 
            this.btnBlotter.Location = new System.Drawing.Point(27, 39);
            this.btnBlotter.Name = "btnBlotter";
            this.btnBlotter.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.OverrideDefault.Back.ColorAngle = 45F;
            this.btnBlotter.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBlotter.OverrideDefault.Border.Rounding = 5F;
            this.btnBlotter.OverrideDefault.Border.Width = 1;
            this.btnBlotter.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBlotter.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBlotter.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnBlotter.Size = new System.Drawing.Size(141, 39);
            this.btnBlotter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.StateCommon.Back.ColorAngle = 45F;
            this.btnBlotter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnBlotter.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnBlotter.StateCommon.Border.ColorAngle = 45F;
            this.btnBlotter.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBlotter.StateCommon.Border.Rounding = 5F;
            this.btnBlotter.StateCommon.Border.Width = 1;
            this.btnBlotter.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBlotter.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBlotter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlotter.StateDisabled.Border.Rounding = 5F;
            this.btnBlotter.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.StateNormal.Border.Rounding = 5F;
            this.btnBlotter.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBlotter.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBlotter.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnBlotter.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnBlotter.StatePressed.Back.ColorAngle = 130F;
            this.btnBlotter.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnBlotter.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.btnBlotter.StatePressed.Border.ColorAngle = 130F;
            this.btnBlotter.StatePressed.Border.Rounding = 5F;
            this.btnBlotter.StatePressed.Border.Width = 1;
            this.btnBlotter.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btnBlotter.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnBlotter.StateTracking.Back.ColorAngle = 45F;
            this.btnBlotter.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnBlotter.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.StateTracking.Border.ColorAngle = 45F;
            this.btnBlotter.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBlotter.StateTracking.Border.Rounding = 5F;
            this.btnBlotter.StateTracking.Border.Width = 1;
            this.btnBlotter.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnBlotter.TabIndex = 38;
            this.btnBlotter.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBlotter.Values.Text = "Blotter Resident";
            this.btnBlotter.Click += new System.EventHandler(this.btnBlotter_Click_1);
            // 
            // dataGridBlotterTable
            // 
            this.dataGridBlotterTable.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridBlotterTable.AllowDrop = true;
            this.dataGridBlotterTable.AllowUserToAddRows = false;
            this.dataGridBlotterTable.AllowUserToDeleteRows = false;
            this.dataGridBlotterTable.AllowUserToResizeColumns = false;
            this.dataGridBlotterTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridBlotterTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBlotterTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBlotterTable.AutoGenerateKryptonColumns = false;
            this.dataGridBlotterTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBlotterTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridBlotterTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBlotterTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBlotterTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5});
            this.dataGridBlotterTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridBlotterTable.Location = new System.Drawing.Point(31, 116);
            this.dataGridBlotterTable.MultiSelect = false;
            this.dataGridBlotterTable.Name = "dataGridBlotterTable";
            this.dataGridBlotterTable.RowHeadersVisible = false;
            this.dataGridBlotterTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridBlotterTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBlotterTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridBlotterTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBlotterTable.Size = new System.Drawing.Size(765, 368);
            this.dataGridBlotterTable.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridBlotterTable.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridBlotterTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridBlotterTable.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridBlotterTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Border.Width = 2;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DimGray;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridBlotterTable.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridBlotterTable.TabIndex = 18;
            this.dataGridBlotterTable.ToolTipShadow = false;
            this.dataGridBlotterTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridBlotterTable_MouseDown_1);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // col1
            // 
            this.col1.HeaderText = "Complainant ID";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.HeaderText = "Respondent ID";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.HeaderText = "Status";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col4
            // 
            this.col4.HeaderText = "Statements";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            // 
            // col5
            // 
            this.col5.HeaderText = "Date Filed";
            this.col5.Name = "col5";
            this.col5.ReadOnly = true;
            // 
            // pnlMainContentControler
            // 
            this.pnlMainContentControler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.kryptonLabel2.Size = new System.Drawing.Size(208, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Blotter Management";
            // 
            // SecretaryBlotterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContentControler);
            this.Name = "SecretaryBlotterControl";
            this.Size = new System.Drawing.Size(809, 526);
            this.Load += new System.EventHandler(this.SecretaryBlotterControl_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBlotterTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).EndInit();
            this.pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnBlotter;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn col1;
        private DataGridViewTextBoxColumn col2;
        private DataGridViewTextBoxColumn col3;
        private DataGridViewTextBoxColumn col4;
        private DataGridViewTextBoxColumn col5;
        protected internal Krypton.Toolkit.KryptonDataGridView dataGridBlotterTable;
    }
}
