using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Images;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace MenuDemo
{
    public partial class MainForm : XtraForm
    {
        private int _nDllFiles;

        public MainForm()
        {
            InitializeComponent();
            LoadAllPlugins();
        }

        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = MenuTileBarGroup.Items.IndexOf(e.Item);
        }

        private void LoadAllPlugins()
        {
            var files = Directory.GetFiles(Application.StartupPath + @"\plugins");
            foreach (var file in files)
            {
                if(!file.ToLower().EndsWith(".dll"))
                    continue;

                try
                {
                    var ab = Assembly.LoadFrom(file);
                    var types = ab.GetTypes();
                    foreach (var type in types)
                    {
                        if (type.GetInterface("IMenu") == null)
                            continue;

                        var mCaption = type.GetMethod("GetMenuCaption");
                        var mName = type.GetMethod("GetMenuName");

                        var obj = ab.CreateInstance(type.FullName ?? throw new InvalidOperationException());
                        var retCaption = mCaption?.Invoke(obj, null);
                        var retName = mName?.Invoke(obj, null);

                        var tileItem = new TileBarItem
                        {
                            Id = _nDllFiles + 1,
                            Name = retName?.ToString(),
                            Text = retCaption?.ToString(),
                            ItemSize = TileBarItemSize.Medium,
                            Image = ImageResourceCache.Default.GetImage("images/actions/clear_32x32.png"),
                            ImageToTextAlignment = TileControlImageToTextAlignment.Top,
                            ImageAlignment = TileItemContentAlignment.TopCenter
                        };
                        MenuTileBarGroup.Items.Add(tileItem);

                        var nbp = obj as NavigationPage;
                        navigationFrame.Pages.Add(nbp);

                        _nDllFiles++;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
    }
}