using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using ShareControl.ViewModels;
using ShareControl.Views;
using System.Windows;

namespace ShareControl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDA3MzU5QDMxMzgyZTMzMmUzMEdlU3h0djdLWkowQlV4dTF6MVd3VU1HT2dtVC9GNkhsdnQzQ2FzckxWSFU9");           
        }
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MenuView, MenuViewModel>();
        }
    }
}
