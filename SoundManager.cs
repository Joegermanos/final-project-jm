using System;
using System.Threading;
using System.Threading.Tasks;

namespace RH
{
    internal static class SoundManager
    {
        private static CancellationTokenSource _bgCts;

        public static void PlayCorrect()
        {
            Task.Run(() =>
            {
                try { Console.Beep(523, 80); Console.Beep(659, 80); Console.Beep(784, 130); }
                catch { }
            });
        }

        public static void PlayWrong()
        {
            Task.Run(() =>
            {
                try { Console.Beep(280, 120); Console.Beep(220, 180); }
                catch { }
            });
        }

        public static void PlayGameOver()
        {
            Task.Run(() =>
            {
                try
                {
                    Console.Beep(440, 180);
                    Console.Beep(370, 180);
                    Console.Beep(294, 180);
                    Console.Beep(220, 400);
                }
                catch { }
            });
        }

        public static void PlaySuccess()
        {
            Task.Run(() =>
            {
                try
                {
                    Console.Beep(523, 80);
                    Console.Beep(659, 80);
                    Console.Beep(784, 80);
                    Console.Beep(1047, 200);
                }
                catch { }
            });
        }

        public static void StartBackground()
        {
            StopBackground();
            _bgCts = new CancellationTokenSource();
            var token = _bgCts.Token;

            Task.Run(() =>
            {
                int[] notes = { 262, 294, 330, 294, 349, 330, 294, 262 };
                int i = 0;
                while (!token.IsCancellationRequested)
                {
                    try { Console.Beep(notes[i % notes.Length], 220); }
                    catch { }
                    Thread.Sleep(30);
                    i++;
                }
            }, token);
        }

        public static void StopBackground()
        {
            _bgCts?.Cancel();
            _bgCts = null;
        }
    }
}
