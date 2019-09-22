using DevExpress.XtraBars.Navigation;
using IMenuInterface;

namespace MenuDemo.Mzb
{
    public partial class MzbUserControl : NavigationPage, IMenu
    {
        public MzbUserControl()
        {
            InitializeComponent();
        }

        public string GetMenuName()
        {
            return "MzbUserControl";
        }

        public string GetMenuCaption()
        {
            return "门诊部";
        }
    }
}
