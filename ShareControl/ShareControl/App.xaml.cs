using System.Windows;

namespace ShareControl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(" NDA3MzU5QDMxMzgyZTMzMmUzMEdlU3h0djdLWkowQlV4dTF6MVd3VU1HT2dtVC9GNkhsdnQzQ2FzckxWSFU9");
            base.OnStartup(e);
        }
    }
}
