using Prism.Regions;
using ShareControl.Views;
using Syncfusion.Windows.Shared;

namespace ShareControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow(IRegionManager manager)
        {
            InitializeComponent();
            manager.RegisterViewWithRegion("ContentRegion", typeof(MenuView));
        }
    }
}
