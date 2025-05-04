using System.Drawing;
using System.Windows.Forms;

namespace BrgyMS.uiDesign.usersDashboard.modals {
    partial class UsersModal {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pnlContainer = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)pnlContainer).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(370, 535);
            pnlContainer.StateCommon.Color1 = Color.White;
            pnlContainer.TabIndex = 0;
            // 
            // UsersModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(370, 535);
            Controls.Add(pnlContainer);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsersModal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += RequestDocsModal_Load;
            ((System.ComponentModel.ISupportInitialize)pnlContainer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected internal Krypton.Toolkit.KryptonPanel pnlContainer;
    }
}