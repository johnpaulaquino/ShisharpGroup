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
            components = new System.ComponentModel.Container();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            pnlAsMainContentHolder = new Krypton.Toolkit.KryptonPanel();
            ctxmenuAccManagement = new ContextMenuStrip(components);
            actionsToolStripMenuItem = new ToolStripMenuItem();
            pnlMainContentControler = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlAsMainContentHolder).BeginInit();
            ctxmenuAccManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlMainContentControler).BeginInit();
            pnlMainContentControler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.AutoScroll = true;
            kryptonPanel1.Controls.Add(pnlAsMainContentHolder);
            kryptonPanel1.Location = new Point(0, 83);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(944, 594);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.TabIndex = 1;
            // 
            // pnlAsMainContentHolder
            // 
            pnlAsMainContentHolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAsMainContentHolder.Location = new Point(0, 3);
            pnlAsMainContentHolder.MaximumSize = new Size(1500, 2500);
            pnlAsMainContentHolder.Name = "pnlAsMainContentHolder";
            pnlAsMainContentHolder.Size = new Size(944, 591);
            pnlAsMainContentHolder.StateCommon.Color1 = Color.White;
            pnlAsMainContentHolder.TabIndex = 4;
            // 
            // ctxmenuAccManagement
            // 
            ctxmenuAccManagement.Font = new Font("Segoe UI", 9F);
            ctxmenuAccManagement.ImageScalingSize = new Size(24, 24);
            ctxmenuAccManagement.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem });
            ctxmenuAccManagement.Name = "contextMenuStrip1";
            ctxmenuAccManagement.Size = new Size(161, 26);
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(160, 22);
            actionsToolStripMenuItem.Text = "Update Account";
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
            kryptonLabel2.Location = new Point(35, 48);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(176, 29);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 15.75F);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Account Settings";
            // 
            // ResidentAccountSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMainContentControler);
            Name = "ResidentAccountSetting";
            Size = new Size(944, 607);
            Load += ResidentAccountSetting_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlAsMainContentHolder).EndInit();
            ctxmenuAccManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlMainContentControler).EndInit();
            pnlMainContentControler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel pnlMainContentControler;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ContextMenuStrip ctxmenuAccManagement;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private Krypton.Toolkit.KryptonPanel pnlAsMainContentHolder;
    }
}
