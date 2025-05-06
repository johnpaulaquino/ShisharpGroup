using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    partial class ResidentUserLogsControl {
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
            this.dataGridAdminDashboard = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluserid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colactions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaffectedtable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldateperformed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminDashboard)).BeginInit();
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
            this.kryptonPanel1.Controls.Add(this.dataGridAdminDashboard);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 72);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(809, 526);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // dataGridAdminDashboard
            // 
            this.dataGridAdminDashboard.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridAdminDashboard.AllowDrop = true;
            this.dataGridAdminDashboard.AllowUserToAddRows = false;
            this.dataGridAdminDashboard.AllowUserToDeleteRows = false;
            this.dataGridAdminDashboard.AllowUserToResizeColumns = false;
            this.dataGridAdminDashboard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridAdminDashboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAdminDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAdminDashboard.AutoGenerateKryptonColumns = false;
            this.dataGridAdminDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAdminDashboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAdminDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAdminDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdminDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.coluserid,
            this.colusername,
            this.colrole,
            this.colactions,
            this.colaffectedtable,
            this.coldateperformed});
            this.dataGridAdminDashboard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridAdminDashboard.Location = new System.Drawing.Point(21, 29);
            this.dataGridAdminDashboard.MultiSelect = false;
            this.dataGridAdminDashboard.Name = "dataGridAdminDashboard";
            this.dataGridAdminDashboard.RowHeadersVisible = false;
            this.dataGridAdminDashboard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridAdminDashboard.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAdminDashboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAdminDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAdminDashboard.Size = new System.Drawing.Size(770, 453);
            this.dataGridAdminDashboard.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridAdminDashboard.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridAdminDashboard.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAdminDashboard.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridAdminDashboard.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Border.Width = 2;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridAdminDashboard.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridAdminDashboard.TabIndex = 18;
            this.dataGridAdminDashboard.ToolTipShadow = false;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // coluserid
            // 
            this.coluserid.HeaderText = "User ID";
            this.coluserid.Name = "coluserid";
            this.coluserid.ReadOnly = true;
            // 
            // colusername
            // 
            this.colusername.HeaderText = "Username";
            this.colusername.Name = "colusername";
            this.colusername.ReadOnly = true;
            // 
            // colrole
            // 
            this.colrole.HeaderText = "Role";
            this.colrole.Name = "colrole";
            this.colrole.ReadOnly = true;
            // 
            // colactions
            // 
            this.colactions.HeaderText = "Actions Made";
            this.colactions.Name = "colactions";
            this.colactions.ReadOnly = true;
            // 
            // colaffectedtable
            // 
            this.colaffectedtable.HeaderText = "Affected Table";
            this.colaffectedtable.Name = "colaffectedtable";
            this.colaffectedtable.ReadOnly = true;
            // 
            // coldateperformed
            // 
            this.coldateperformed.HeaderText = "Date Performed";
            this.coldateperformed.Name = "coldateperformed";
            this.coldateperformed.ReadOnly = true;
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
            this.kryptonLabel2.Size = new System.Drawing.Size(123, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Users Logs";
            // 
            // ResidentUserLogsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContentControler);
            this.Name = "ResidentUserLogsControl";
            this.Size = new System.Drawing.Size(809, 526);
            this.Load += new System.EventHandler(this.ResidentUserLogsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminDashboard)).EndInit();
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
        private Krypton.Toolkit.KryptonDataGridView dataGridAdminDashboard;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn coluserid;
        private DataGridViewTextBoxColumn colusername;
        private DataGridViewTextBoxColumn colrole;
        private DataGridViewTextBoxColumn colactions;
        private DataGridViewTextBoxColumn colaffectedtable;
        private DataGridViewTextBoxColumn coldateperformed;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
    }
}
