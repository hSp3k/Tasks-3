using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Task1.Source
{
    internal static class UtilityTask1
    {
        internal static double GetAverageLength(string line)
        {
            string[] arrayString = line.Replace(" ","").Split(new[] { '.','?','!', ':', ';', ',', '-',
                '(', ')', '[', ']','{','}' });

            double sum = 0;
            foreach (var item in arrayString)
            {
                sum += item.Length;
            }
            return sum / arrayString.Length;
        }
    }
}
