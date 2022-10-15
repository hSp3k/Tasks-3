using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Source
{
    internal class UtilityTask2
    {
        internal static void CheckingPalindrome(string line)
        {
            if(Checking(line) == true)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка НЕ является палиндромом");
            }
        }

        private static bool Checking(string line)
        {
            StringBuilder tempLine = new StringBuilder();
            foreach (var item in line)
            {
                if(char.IsLetter(item))
                {
                    tempLine.Append(item);
                }
            }
            char[] tempArray = tempLine.ToString().ToCharArray();
            Array.Reverse(tempArray);
            return new string(tempArray) == tempLine.ToString();
        }
    }
}
