using System;
using System.IO;

namespace RH
{
    internal static class User
    {
        private static readonly string FilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");

        public static string SignIn(string username, string password)
        {
            if (!File.Exists(FilePath)) return null;

            using StreamReader sr = new StreamReader(FilePath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                    return username;
            }
            return null;
        }

        public static bool UsernameExists(string username)
        {
            if (!File.Exists(FilePath)) return false;

            using StreamReader sr = new StreamReader(FilePath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 1 && parts[0] == username)
                    return true;
            }
            return false;
        }

        public static bool SignUp(string username, string password)
        {
            if (UsernameExists(username)) return false;

            using StreamWriter sw = new StreamWriter(FilePath, append: true);
            sw.WriteLine($"{username},{password}");
            return true;
        }

        public static string ValidatePassword(string password)
        {
            if (password.Length < 6)
                return "Password must be at least 6 characters.";

            bool hasUpper = false, hasLower = false, hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            if (!hasUpper) return "Password must have an uppercase letter.";
            if (!hasLower) return "Password must have a lowercase letter.";
            if (!hasDigit) return "Password must have a number.";

            return null;
        }
    }
}
