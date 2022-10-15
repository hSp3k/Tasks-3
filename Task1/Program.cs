

using Task1.Source;

namespace Task1
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.Write("Введите строку : ");
            string? line = Console.ReadLine();
            Console.WriteLine(UtilityTask1.GetAverageLength(line));
        }

    }
}