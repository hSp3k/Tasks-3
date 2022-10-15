using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3.Source
{
    internal class UtilityTask3
    {
        internal static void CheckingEmail(string email)
        {
            if (Checking(email) == true)
            {
                Console.WriteLine($"Введенная строка “{email}” является электронной почтой");
            }
            else
            {
                Console.WriteLine($"Введенная строка “{email}” НЕ является электронной почтой");
            }
        }

        private static bool Checking(string email)
        {
            string pattern = @"^[0-9a-zA-Zа-яА-Я](?:[\w\.\-]*[0-9a-zA-Zа-яА-Я])?" +
                             @"@" +
                             @"(?:[0-9a-zA-Zа-яА-Я](?:[\w\-]*[0-9a-zA-Zа-яА-Я])?\.)+" +
                             @"[a-zA-Zа-яА-Я]{2,6}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
