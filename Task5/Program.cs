using System.Text.RegularExpressions;
using Task5.Source;

namespace Task5
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // 2008 год наступит 01-01-2008 и закончится 31-12-2008

            Console.Write("Введите текст, содержащий дату в формате dd-mm-yyyy: ");
            string? line = Console.ReadLine();
            UtilityTask5.WriteFoundDates(line);
        }
    }
}