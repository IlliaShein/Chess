using Chess.Classes.ChessBoard;
using Chess.Classes.Game;
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
            ShowRealTimeButton.IsChecked = ChessClock.IfTimeShowing();
            ShowAvailableTurnsButton.IsChecked = ChessBoard.IfShowingAvailableTurns();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu newWindow = new MainMenu();
            if (WindowState == WindowState.Normal)
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

        private void ShowRealTimeButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ChessClock.SetShowing(false);
        }

        private void ShowRealTimeButton_Checked(object sender, RoutedEventArgs e)
        {
            ChessClock.SetShowing(true);
        }

        private void ShowAvailableTurnsButton_Checked(object sender, RoutedEventArgs e)
        {
            ChessBoard.SetShowingAvailableTurns(true);
        }

        private void ShowAvailableTurnsButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ChessBoard.SetShowingAvailableTurns(false);
        }
    }
}
