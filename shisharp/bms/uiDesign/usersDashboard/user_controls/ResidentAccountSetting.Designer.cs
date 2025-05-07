using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.user_controls {
    partial class ResidentAccountSetting {
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
            this.ctxmenuAccManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.pnlAsMainContentHolder = new Krypton.Toolkit.KryptonPanel();
            this.ctxmenuAccManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).BeginInit();
            this.pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAsMainContentHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxmenuAccManagement
            // 
            this.ctxmenuAccManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxmenuAccManagement.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxmenuAccManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.ctxmenuAccManagement.Name = "contextMenuStrip1";
            this.ctxmenuAccManagement.Size = new System.Drawing.Size(161, 26);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.actionsToolStripMenuItem.Text = "Update Account";
            // 
            // pnlMainContentControler
            // 
            this.pnlMainContentControler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainContentControler.Controls.Add(this.kryptonPanel2);
            this.pnlMainContentControler.Controls.Add(this.pnlAsMainContentHolder);
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
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonSeparator1.Location = new System.Drawing.Point(0, 65);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(809, 4);
            this.kryptonSeparator1.TabIndex = 4;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonLabel2.Location = new System.Drawing.Point(30, 38);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(176, 29);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Account Settings";
            // 
            // pnlAsMainContentHolder
            // 
            this.pnlAsMainContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAsMainContentHolder.Location = new System.Drawing.Point(0, 0);
            this.pnlAsMainContentHolder.MaximumSize = new System.Drawing.Size(1286, 2167);
            this.pnlAsMainContentHolder.Name = "pnlAsMainContentHolder";
            this.pnlAsMainContentHolder.Size = new System.Drawing.Size(809, 587);
            this.pnlAsMainContentHolder.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlAsMainContentHolder.TabIndex = 5;
            // 
            // ResidentAccountSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContentControler);
            this.Name = "ResidentAccountSetting";
            this.Size = new System.Drawing.Size(809, 526);
            this.Load += new System.EventHandler(this.ResidentAccountSetting_Load_1);
            this.ctxmenuAccManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMainContentControler)).EndInit();
            this.pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAsMainContentHolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ContextMenuStrip ctxmenuAccManagement;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private Krypton.Toolkit.KryptonPanel pnlAsMainContentHolder;
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
    }
}
