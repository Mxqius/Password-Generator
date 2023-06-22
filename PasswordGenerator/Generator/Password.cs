using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator.Generator
{
    public static class Password
    {
        public static readonly string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static readonly string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        public static readonly string NumberChars = "0123456789";
        public static readonly string SymbolChars = "!@#$%^&*()_+-=[]{}|;':,.<>/?";

        private static Random random = new Random();

        public enum PasswordStrength
        {
            VeryWeak,
            Weak,
            Strong
        }
        public static string GenerateRandomPassword(int length, string chars, bool excludeDuplicate)
        {

            if (excludeDuplicate && length > chars.Length)            
                excludeDuplicate = false;            

            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                char randomChar = chars[random.Next(chars.Length)];

                if (excludeDuplicate && password.Contains(randomChar))
                {
                    i--;
                    continue;
                }

                password[i] = randomChar;
            }

            return new string(password);

        }
        public static PasswordStrength CheckPasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
                return PasswordStrength.VeryWeak;

            int score = 0;

            if (password.Length >= 8)
                score++;

            if (password.Length >= 12)
                score++;

            if (password.Length >= 16)
                score++;

            if (password.Any(char.IsUpper))
                score++;

            if (password.Any(char.IsLower))
                score++;

            if (password.Any(char.IsDigit))
                score++;

            if (password.Any(char.IsSymbol) || password.Any(char.IsPunctuation))
                score++;

            if (score <= 2)
                return PasswordStrength.VeryWeak;
            if (score <= 4)
                return PasswordStrength.Weak;

            return PasswordStrength.Strong;
        }
    }
}
