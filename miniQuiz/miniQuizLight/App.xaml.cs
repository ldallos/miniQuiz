using System.Windows;
using miniQuizLight.View;
using miniQuizLight.ViewModel;

namespace miniQuizLight
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
            mainWindow.DataContext = new MainViewModel(new QuestionViewHandler());
            mainWindow.Show();
        }
    }
}
