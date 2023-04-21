using System;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Chess.Classes.Game
{
    public static class ChessClock
    {
        private static bool _showTime = true;
        public static void SetClock(TextBlock textBlock)
        {
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, args) => textBlock.Text = DateTime.Now.ToString("HH:mm");
            timer.Start();
        }

        public static bool IfTimeShowing()
        {
            return _showTime;
        }

        public static void SetShowing(bool show)
        {
            _showTime = show;
        }
    }
}
