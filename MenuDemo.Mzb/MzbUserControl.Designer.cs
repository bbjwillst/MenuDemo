namespace MenuDemo.Mzb
{
    partial class MzbUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Mzb = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // label_Mzb
            // 
            this.label_Mzb.Location = new System.Drawing.Point(382, 320);
            this.label_Mzb.Name = "label_Mzb";
            this.label_Mzb.Size = new System.Drawing.Size(21, 14);
            this.label_Mzb.TabIndex = 0;
            this.label_Mzb.Text = "Mzb";
            // 
            // MzbUserControl1
            // 
            this.Controls.Add(this.label_Mzb);
            this.Name = "MzbUserControl1";
            this.Size = new System.Drawing.Size(907, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label_Mzb;
    }
}
