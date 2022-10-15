using Task4_2.Source;


namespace Task4_2
{
    internal class Program
    {
        // <b>Это</b> текст <i>с</i> < <font color=”red”>HTML</font> кодами
        internal static void Main(string[] args)
        {
            Console.Write("Введите HTML текст: ");
            string? line = Console.ReadLine();
            Console.WriteLine("Результат замены: " + UtilityTask4.Replace(line));
        }
    }
}