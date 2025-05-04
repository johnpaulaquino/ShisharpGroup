using System.Drawing;

namespace BrgyMS.docs_templates {
    partial class Viewer {
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
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.stiRibbonViewerControl1 = new Stimulsoft.Report.Viewer.StiRibbonViewerControl();
            this.SuspendLayout();
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(272, 238);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(77, 22);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // stiRibbonViewerControl1
            // 
            this.stiRibbonViewerControl1.AllowDrop = true;
            this.stiRibbonViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiRibbonViewerControl1.Location = new System.Drawing.Point(0, 0);
            this.stiRibbonViewerControl1.Name = "stiRibbonViewerControl1";
            this.stiRibbonViewerControl1.Report = null;
            this.stiRibbonViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiRibbonViewerControl1.ShowZoom = true;
            this.stiRibbonViewerControl1.Size = new System.Drawing.Size(686, 390);
            this.stiRibbonViewerControl1.TabIndex = 1;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.stiRibbonViewerControl1);
            this.Name = "Viewer";
            this.Text = "Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Stimulsoft.Report.Viewer.StiRibbonViewerControl stiRibbonViewerControl1;
    }
}