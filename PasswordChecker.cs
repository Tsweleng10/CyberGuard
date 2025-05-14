using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public static class PasswordChecker
    {
        public static string EvaluateStrength(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return "Password cannot be empty.";

            bool hasUpper = false, hasLower = false, hasDigit = false, hasSymbol = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else hasSymbol = true;
            }

            if (password.Length >= 12 && hasUpper && hasLower && hasDigit && hasSymbol)
                return "🔐 Strong Password!";
            else if (password.Length >= 8 && hasUpper && hasLower && (hasDigit || hasSymbol))
                return "🛡️ Medium Strength Password.";
            else
                return "⚠️ Weak Password. Try adding uppercase, numbers, and symbols.";
        }
    }
}