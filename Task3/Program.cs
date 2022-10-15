using System.Text.RegularExpressions;
using Task3.Source;

namespace Task3
{
    internal class Program
    {
        // p_ivanov@mail.rol.ru
        internal static void Main(string[] args)
        {
            Console.Write("Введите строку : ");
            string? email = Console.ReadLine();
            UtilityTask3.CheckingEmail(email);
        }
    }
}