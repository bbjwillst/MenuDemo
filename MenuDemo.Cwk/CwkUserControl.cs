using DevExpress.XtraBars.Navigation;
using IMenuInterface;

namespace MenuDemo.Cwk
{
    public partial class CwkUserControl : NavigationPage, IMenu
    {
        public CwkUserControl()
        {
            InitializeComponent();
        }

        public string GetMenuName()
        {
            return "CwkUserControl";
        }

        public string GetMenuCaption()
        {
            return "财务科";
        }
    }
}
