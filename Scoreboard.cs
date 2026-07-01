using System;
using System.Collections.Generic;
using System.IO;

namespace RH
{
    internal static class Scoreboard
    {
        private static readonly string FilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scoreboard.txt");

        public static void Save(string username, string game, int score)
        {
            int best = GetBest(username, game);
            if (score <= best) return;

            var lines = File.Exists(FilePath)
                ? new List<string>(File.ReadAllLines(FilePath))
                : new List<string>();

            string entry = $"{username},{game},{score}";
            bool found = false;

            for (int i = 0; i < lines.Count; i++)
            {
                string[] p = lines[i].Split(',');
                if (p.Length == 3 && p[0] == username && p[1] == game)
                {
                    lines[i] = entry;
                    found = true;
                    break;
                }
            }

            if (!found)
                lines.Add(entry);

            using StreamWriter sw = new StreamWriter(FilePath, false);
            foreach (string line in lines)
                sw.WriteLine(line);
        }

        public static int GetBest(string username, string game)
        {
            if (!File.Exists(FilePath)) return 0;

            using StreamReader sr = new StreamReader(FilePath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] p = line.Split(',');
                if (p.Length == 3 && p[0] == username && p[1] == game
                    && int.TryParse(p[2], out int s))
                    return s;
            }
            return 0;
        }

        public static List<(string Username, int Score)> GetLeaderboard(string game)
        {
            var list = new List<(string Username, int Score)>();

            if (!File.Exists(FilePath)) return list;

            using StreamReader sr = new StreamReader(FilePath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] p = line.Split(',');
                if (p.Length == 3 && p[1] == game && int.TryParse(p[2], out int s))
                    list.Add((p[0], s));
            }

            for (int i = 0; i < list.Count - 1; i++)
                for (int j = 0; j < list.Count - 1 - i; j++)
                    if (list[j].Score < list[j + 1].Score)
                    {
                        var tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }

            return list;
        }

        public static string[] Games => new[]
            { "Guess", "Memory", "MathQuiz", "QuickPick" };
    }
}
