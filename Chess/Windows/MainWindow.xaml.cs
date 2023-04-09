using Chess.Classes.ChessBoard;
using Chess.Classes.Figures;
using Chess.Classes.Game;
using Chess.Windows;
using System.Windows;
using System.Windows.Input;

namespace Chess
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ChessBoard.FillBoard();
            ChessBoard.FillColorBoard();
        }

        private void WhitePawn0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.WHITE, 0, e, GameField);
        }

        private void WhitePawn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.WHITE, 1, e, GameField);
        }

        private void WhitePawn2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
             GameLogic.SelectPiece<Pawn>(FigureColor.WHITE, 2, e, GameField);
        }

        private void WhitePawn3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.WHITE, 3, e, GameField);
        }

        private void WhitePawn4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.WHITE, 4, e, GameField);
        }

        private void WhitePawn5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.WHITE, 5, e, GameField);
        }

        private void WhitePawn6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.WHITE, 6, e, GameField);
        }

        private void WhitePawn7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.WHITE, 7, e, GameField);   
        }

        private void BlackPawn0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.BLACK, 0, e, GameField);
        }

        private void BlackPawn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.BLACK, 1, e, GameField);
        }

        private void BlackPawn2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.BLACK, 2, e, GameField);
        }

        private void BlackPawn3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.BLACK, 3, e, GameField);        
        }

        private void BlackPawn4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.BLACK, 4, e, GameField);
        }

        private void BlackPawn5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.BLACK, 5, e, GameField);
        }

        private void BlackPawn6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.BLACK, 6, e, GameField);
        }

        private void BlackPawn7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Pawn>(FigureColor.BLACK, 7, e, GameField);
        }
        private void WhiteKnight1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Knight>(FigureColor.WHITE, 0, e, GameField);
        }

        private void WhiteKnight2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Knight>(FigureColor.WHITE, 1, e, GameField);
        }

        private void BlackKnight1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Knight>(FigureColor.BLACK, 0, e, GameField);
        }

        private void BlackKnight2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Knight>(FigureColor.BLACK, 1, e, GameField);
        }

        private void WhiteBishop1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Bishop>(FigureColor.WHITE, 0, e, GameField);
        }

        private void WhiteBishop2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Bishop>(FigureColor.WHITE, 1, e, GameField);
        }

        private void BlackBishop1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Bishop>(FigureColor.BLACK, 0, e, GameField);
        }

        private void BlackBishop2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Bishop>(FigureColor.BLACK, 1, e, GameField);
        }

        private void WhiteRock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Rook>(FigureColor.WHITE, 0, e,GameField);
        }

        private void WhiteRock2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Rook>(FigureColor.WHITE, 1, e, GameField);
        }

        private void BlackRock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Rook>(FigureColor.BLACK, 0, e, GameField);
        }

        private void BlackRock2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Rook>(FigureColor.BLACK, 1, e, GameField);
        }

        private void WhiteQueen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Queen>(FigureColor.WHITE, e, GameField);
        }

        private void BlackQueen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<Queen>(FigureColor.BLACK, e, GameField);
        }

        private void WhiteKing_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.SelectPiece<King>(FigureColor.WHITE, e, GameField);
        }

        private void BlackKing_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           GameLogic.SelectPiece<King>(FigureColor.BLACK, e, GameField);
        }

        private void GameField_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.GameFieldClickLogicProcessing(e, GameField);
        }

        private void RealTimeTB_Loaded(object sender, RoutedEventArgs e)
        {
            ChessClock.SetClock(RealTimeTB);
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu newWindow = new MainMenu();
            newWindow.Show();
            this.Close();
        }

        private void FullScreenButton_Click(object sender, RoutedEventArgs e)
        {
            GameLogic.ScreenSizeButtonLogicProcession(StartWindow, GameField);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
