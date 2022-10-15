using System.Text.RegularExpressions;


namespace Task4_1
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.Write("Введите HTML текст: ");
            string? line = Console.ReadLine();
            Console.WriteLine("Результат замены: " + Regex.Replace(line, @"<[^>]*>", "_"));
        }
    }
}