using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.adminDashboard.controls {
    partial class AdminAccountVerification {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nudAvLimit = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.dataGridAmTable = new Krypton.Toolkit.KryptonDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxAccountVerification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.atsVerfiyAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAmTable)).BeginInit();
            this.ctxAccountVerification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).BeginInit();
            this.pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudAvLimit
            // 
            this.nudAvLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudAvLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAvLimit.Location = new System.Drawing.Point(74, 29);
            this.nudAvLimit.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAvLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAvLimit.Name = "nudAvLimit";
            this.nudAvLimit.Size = new System.Drawing.Size(47, 22);
            this.nudAvLimit.TabIndex = 13;
            this.nudAvLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAvLimit.ValueChanged += new System.EventHandler(this.nudAvLimit_ValueChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel3.Location = new System.Drawing.Point(31, 27);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(44, 19);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "Show";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel4.Location = new System.Drawing.Point(126, 27);
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
            this.kryptonPanel1.Controls.Add(this.dataGridAmTable);
            this.kryptonPanel1.Controls.Add(this.txtSearch);
            this.kryptonPanel1.Controls.Add(this.nudAvLimit);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 72);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(809, 515);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // dataGridAmTable
            // 
            this.dataGridAmTable.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridAmTable.AllowDrop = true;
            this.dataGridAmTable.AllowUserToAddRows = false;
            this.dataGridAmTable.AllowUserToDeleteRows = false;
            this.dataGridAmTable.AllowUserToResizeColumns = false;
            this.dataGridAmTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridAmTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAmTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAmTable.AutoGenerateKryptonColumns = false;
            this.dataGridAmTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAmTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAmTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAmTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colemail,
            this.colfullname,
            this.colgender,
            this.colcaddress});
            this.dataGridAmTable.ContextMenuStrip = this.ctxAccountVerification;
            this.dataGridAmTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridAmTable.Location = new System.Drawing.Point(22, 85);
            this.dataGridAmTable.MultiSelect = false;
            this.dataGridAmTable.Name = "dataGridAmTable";
            this.dataGridAmTable.RowHeadersVisible = false;
            this.dataGridAmTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridAmTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAmTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAmTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAmTable.Size = new System.Drawing.Size(765, 416);
            this.dataGridAmTable.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridAmTable.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridAmTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAmTable.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridAmTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridAmTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dataGridAmTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dataGridAmTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAmTable.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.dataGridAmTable.StateCommon.HeaderColumn.Border.Width = 2;
            this.dataGridAmTable.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DimGray;
            this.dataGridAmTable.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridAmTable.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridAmTable.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridAmTable.TabIndex = 18;
            this.dataGridAmTable.ToolTipShadow = false;
            this.dataGridAmTable.VirtualMode = true;
            this.dataGridAmTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridAmTable_MouseDown);
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // colemail
            // 
            this.colemail.HeaderText = "Email";
            this.colemail.Name = "colemail";
            this.colemail.ReadOnly = true;
            // 
            // colfullname
            // 
            this.colfullname.HeaderText = "Fullname";
            this.colfullname.Name = "colfullname";
            this.colfullname.ReadOnly = true;
            // 
            // colgender
            // 
            this.colgender.HeaderText = "Gender";
            this.colgender.Name = "colgender";
            this.colgender.ReadOnly = true;
            // 
            // colcaddress
            // 
            this.colcaddress.FillWeight = 200F;
            this.colcaddress.HeaderText = "Address";
            this.colcaddress.Name = "colcaddress";
            this.colcaddress.ReadOnly = true;
            // 
            // ctxAccountVerification
            // 
            this.ctxAccountVerification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxAccountVerification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atsVerfiyAccount});
            this.ctxAccountVerification.Name = "ctxAccountVerification";
            this.ctxAccountVerification.Size = new System.Drawing.Size(202, 34);
            // 
            // atsVerfiyAccount
            // 
            this.atsVerfiyAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atsVerfiyAccount.Name = "atsVerfiyAccount";
            this.atsVerfiyAccount.Size = new System.Drawing.Size(201, 30);
            this.atsVerfiyAccount.Text = "Verify Account";
            this.atsVerfiyAccount.Click += new System.EventHandler(this.atsVerfiyAccount_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(435, 17);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(352, 35);
            this.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, -1, 5, 15);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.kryptonLabel2.Location = new System.Drawing.Point(31, 33);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(205, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Account Verification";
            // 
            // AdminAccountVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContentControler);
            this.Name = "AdminAccountVerification";
            this.Size = new System.Drawing.Size(809, 526);
            this.Load += new System.EventHandler(this.AdminAccountVerification_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAmTable)).EndInit();
            this.ctxAccountVerification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).EndInit();
            this.pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colemail;
        private DataGridViewTextBoxColumn colfullname;
        private DataGridViewTextBoxColumn colgender;
        private DataGridViewTextBoxColumn colcaddress;
        private ContextMenuStrip ctxAccountVerification;
        private ToolStripMenuItem atsVerfiyAccount;
        protected internal Krypton.Toolkit.KryptonDataGridView dataGridAmTable;
        protected internal Krypton.Toolkit.KryptonNumericUpDown nudAvLimit;
    }
}
