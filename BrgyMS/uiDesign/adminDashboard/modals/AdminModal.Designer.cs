namespace BrgyMS.uiDesign.adminDashboard.modals {
    partial class AdminModal {
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
            pnlModalMainContent = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)pnlModalMainContent).BeginInit();
            SuspendLayout();
            // 
            // pnlModalMainContent
            // 
            pnlModalMainContent.Dock = DockStyle.Fill;
            pnlModalMainContent.Location = new Point(0, 0);
            pnlModalMainContent.Name = "pnlModalMainContent";
            pnlModalMainContent.Size = new Size(464, 691);
            pnlModalMainContent.StateCommon.Color1 = Color.White;
            pnlModalMainContent.TabIndex = 0;
            // 
            // AdminModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 691);
            Controls.Add(pnlModalMainContent);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminModal";
            SizeGripStyle = SizeGripStyle.Hide;
            FormClosing += AdminModal_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pnlModalMainContent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected internal Krypton.Toolkit.KryptonPanel pnlModalMainContent;
    }
}