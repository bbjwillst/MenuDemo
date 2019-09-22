namespace MenuDemo
{
    partial class MainForm
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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.MenuTileBarGroup = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.SetupTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SetupNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.label_Setup = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.SetupNavigationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.MenuTileBarGroup);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(5);
            this.tileBar.MaxId = 5;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 118);
            this.tileBar.MinimumSize = new System.Drawing.Size(117, 118);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(34, 12, 34, 12);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.SetupTileBarItem;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(915, 118);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // MenuTileBarGroup
            // 
            this.MenuTileBarGroup.Items.Add(this.SetupTileBarItem);
            this.MenuTileBarGroup.Name = "MenuTileBarGroup";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.SetupNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 118);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.SetupNavigationPage});
            this.navigationFrame.SelectedPage = this.SetupNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(915, 486);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            this.navigationFrame.TransitionType = DevExpress.Utils.Animation.Transitions.Push;
            // 
            // SetupTileBarItem
            // 
            this.SetupTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "设置";
            this.SetupTileBarItem.Elements.Add(tileItemElement2);
            this.SetupTileBarItem.Id = 4;
            this.SetupTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.SetupTileBarItem.Name = "SetupTileBarItem";
            // 
            // SetupNavigationPage
            // 
            this.SetupNavigationPage.Controls.Add(this.label_Setup);
            this.SetupNavigationPage.Name = "SetupNavigationPage";
            this.SetupNavigationPage.Size = new System.Drawing.Size(915, 486);
            // 
            // label_Setup
            // 
            this.label_Setup.Location = new System.Drawing.Point(400, 205);
            this.label_Setup.Name = "label_Setup";
            this.label_Setup.Size = new System.Drawing.Size(24, 14);
            this.label_Setup.TabIndex = 0;
            this.label_Setup.Text = "设置";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 604);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.SetupNavigationPage.ResumeLayout(false);
            this.SetupNavigationPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup MenuTileBarGroup;
        private DevExpress.XtraBars.Navigation.TileBarItem SetupTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage SetupNavigationPage;
        private DevExpress.XtraEditors.LabelControl label_Setup;
    }
}