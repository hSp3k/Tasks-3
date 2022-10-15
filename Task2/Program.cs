

using Task2.Source;

namespace Task2
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.Write("Введите строку : ");
            string? line = Console.ReadLine().ToLower();
            UtilityTask2.CheckingPalindrome(line);
        }
    }
}