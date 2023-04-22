using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Chess.Windows
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow();

            if (this.WindowState == WindowState.Normal)
            {
                newWindow.WindowState = WindowState.Normal;
            }
            else
            {
                newWindow.WindowState = WindowState.Maximized;
            }
            newWindow.Show();
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Options newWindow = new Options();
            if (this.WindowState == WindowState.Normal)
            {
                newWindow.WindowState = WindowState.Normal;
            }
            else
            {
                newWindow.WindowState = WindowState.Maximized;
            }

            if (WindowState == WindowState.Normal)
            {
                newWindow.ScreenSizeButton.Content = "Full screen";
            }
            else // WindowState == WindowState.Maximized
            {
                newWindow.ScreenSizeButton.Content = "Window";
            }

            newWindow.Show();
            Close();
        }
    }
}
