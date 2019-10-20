using miniQuizOld.View;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace miniQuizOld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event FieldEvent ClickOnField;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void AddField(int x, int y)
        {
            Button fieldButton = new Button
            {
                Tag = new Point(x, y),
                Height = 100,
                Width = 150,
                Background = Brushes.AliceBlue
            };

            Grid.SetRow(fieldButton, x);
            Grid.SetColumn(fieldButton, y);
            MainGrid.Children.Add(fieldButton);
            myFieldButtons.Add(fieldButton);

            fieldButton.Click += FieldClick;
        }

        public void ShowMessage(string message, int x, int y)
        {
            Button selectedButton = myFieldButtons.Single(
                f => ((Point)f.Tag).X == x && ((Point)f.Tag).Y == y);
            selectedButton.Content = message;
        }

        private List<Button> myFieldButtons = new List<Button>();

        private void FieldClick(object sender, RoutedEventArgs e)
        {
            Button fieldButton = (Button)sender;
            Point p = (Point)fieldButton.Tag;
            ClickOnField(this, new FieldEventArgs((int)p.X, (int)p.Y));
        }
    }
}
