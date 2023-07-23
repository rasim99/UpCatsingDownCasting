using Service.Services;
using Service.Services.interfaces;
using System;

namespace PracticInClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an email\n");
            string email = Console.ReadLine();

            Console.WriteLine("\nPlease enter an password");
            string password = Console.ReadLine();

            int role = 0;

            IAccount account = new Account();

            Console.WriteLine(account.Login(email, password, role));
        }
    }
}
