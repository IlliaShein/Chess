using System.Windows;
using System.Windows.Input;

namespace Chess.Windows
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu newWindow = new MainMenu();
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

        private void ScreenSizeButton_Click(object sender, RoutedEventArgs e)
        {
            GameLogic.ScreenSizeButtonLogicProcession(OptionsWindow, GridOptions);
        }
    }
}
