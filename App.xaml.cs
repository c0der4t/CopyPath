using System.Windows;

namespace CopyPath
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            if (e.Args.Length == 1)
            {
                Clipboard.SetText(e.Args[0].ToString());
            }

            System.Windows.Application.Current.Shutdown();

        }


    }
}
