using miniQuizOld.Controller;
using System.Windows;

namespace miniQuizOld
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow mainWindow = new MainWindow();
            new MainController(mainWindow);
            mainWindow.Show();
        }
    }
}
