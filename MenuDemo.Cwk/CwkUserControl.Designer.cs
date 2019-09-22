namespace MenuDemo.Cwk
{
    partial class CwkUserControl
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
            this.label_Cwk = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // label_Cwk
            // 
            this.label_Cwk.Location = new System.Drawing.Point(362, 256);
            this.label_Cwk.Name = "label_Cwk";
            this.label_Cwk.Size = new System.Drawing.Size(36, 14);
            this.label_Cwk.TabIndex = 0;
            this.label_Cwk.Text = "财务科";
            // 
            // CwkUserControl
            // 
            this.Controls.Add(this.label_Cwk);
            this.Size = new System.Drawing.Size(853, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label_Cwk;
    }
}
