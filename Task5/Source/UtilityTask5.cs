using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5.Source
{
    internal class UtilityTask5
    {
        internal static void WriteFoundDates(string line)
        {
            Console.WriteLine("Найденные даты: ");
            foreach (Match match in SearchDates(line))
            {
                Console.Write(String.Format("{0}-{1}-{2}",
                    match.Groups["day"].Value,
                    match.Groups["month"].Value,
                    match.Groups["year"].Value));
                Console.Write($", где день = {match.Groups["day"].Value}");
                Console.Write($", месяц = {match.Groups["month"].Value}");
                Console.Write($", год = {match.Groups["year"].Value}\n");
            }
        }

        private static MatchCollection SearchDates(string line)
        {
            string pattern = @"(?<day>(?:[0][1-9]|[1-2][0-9]|[3][0-1]))-" +
                             @"(?<month>(?:[0][1-9]|[1][0-2]))-" +
                             @"(?<year>[1-9][0-9]{3})";
            return Regex.Matches(line, pattern);
        }
    }
}
