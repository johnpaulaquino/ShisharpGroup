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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.dataGridOfficalsTable = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaffectedtable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ctcOfficials = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addAsRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfficalsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).BeginInit();
            this.pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.ctcOfficials.SuspendLayout();
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
            this.kryptonPanel1.Controls.Add(this.dataGridOfficalsTable);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 72);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(809, 515);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // dataGridOfficalsTable
            // 
            this.dataGridOfficalsTable.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridOfficalsTable.AllowDrop = true;
            this.dataGridOfficalsTable.AllowUserToAddRows = false;
            this.dataGridOfficalsTable.AllowUserToDeleteRows = false;
            this.dataGridOfficalsTable.AllowUserToResizeColumns = false;
            this.dataGridOfficalsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridOfficalsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dataGridOfficalsTable.Location = new System.Drawing.Point(31, 42);
            this.dataGridOfficalsTable.MultiSelect = false;
            this.dataGridOfficalsTable.Name = "dataGridOfficalsTable";
            this.dataGridOfficalsTable.RowHeadersVisible = false;
            this.dataGridOfficalsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridOfficalsTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridOfficalsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridOfficalsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOfficalsTable.Size = new System.Drawing.Size(765, 442);
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
            this.dataGridOfficalsTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridOfficalsTable_MouseDown);
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
            this.kryptonLabel2.Size = new System.Drawing.Size(321, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Barangay Officials Management";
            // 
            // ctcOfficials
            // 
            this.ctcOfficials.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctcOfficials.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAsRToolStripMenuItem,
            this.officialsToolStripMenuItem});
            this.ctcOfficials.Name = "ctcOfficials";
            this.ctcOfficials.Size = new System.Drawing.Size(181, 70);
            // 
            // addAsRToolStripMenuItem
            // 
            this.addAsRToolStripMenuItem.Name = "addAsRToolStripMenuItem";
            this.addAsRToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addAsRToolStripMenuItem.Text = "Add as Officials";
            this.addAsRToolStripMenuItem.Click += new System.EventHandler(this.addAsRToolStripMenuItem_Click);
            // 
            // officialsToolStripMenuItem
            // 
            this.officialsToolStripMenuItem.Name = "officialsToolStripMenuItem";
            this.officialsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.officialsToolStripMenuItem.Text = "View Information";
            this.officialsToolStripMenuItem.Click += new System.EventHandler(this.officialsToolStripMenuItem_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfficalsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).EndInit();
            this.pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ctcOfficials.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonDataGridView dataGridOfficalsTable;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colusername;
        private DataGridViewTextBoxColumn colrole;
        private DataGridViewTextBoxColumn colactions;
        private DataGridViewTextBoxColumn colaffectedtable;
        private ContextMenuStrip ctcOfficials;
        private ToolStripMenuItem addAsRToolStripMenuItem;
        private ToolStripMenuItem officialsToolStripMenuItem;
    }
}
