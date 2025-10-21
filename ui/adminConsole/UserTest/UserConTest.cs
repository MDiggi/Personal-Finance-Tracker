using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.UserTest
{
    internal class UserConTest(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
        public void Show()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("User Constructor Test");
                Console.WriteLine("1. Fully Parametrized Constructor");
                Console.WriteLine("2. Registering User Constructor");
                Console.WriteLine("3. Default Constructor");
                Console.WriteLine("0. Exit");

                char? option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        TestFullyParametrizedConstructor();
                        break;
                    case '2':
                        TestRegisteringUserConstructor();
                        break;
                    case '3':
                        TestDefaultConstructor();
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Option. Please try again.");
                        Console.ReadKey();
                        break;
                }
            } while (true);
        }

        private void TestFullyParametrizedConstructor()
        {
            Console.Clear();
            uint id = userService.Count() + 1;
            string username;
            string password;
            string email;
            DateTime createdAt = DateTime.Now;
            List<Transaction> transactions = new List<Transaction>();
            List<Category> categories = new List<Category>();
            decimal balance;

            Console.Write("User: ");
            username = Console.ReadLine() ?? string.Empty;
            Console.Write("\nPassword: ");
            password = Console.ReadLine() ?? string.Empty;
            Console.Write("\nEmail: ");
            email = Console.ReadLine() ?? string.Empty;
            Console.Write("\nBalance: ");
            balance = Convert.ToDecimal(Console.ReadLine());

            User user = new User(id, username, password, email, createdAt, transactions, categories, balance);
            userService.Add(user);
            Console.Write(user);
            Console.ReadKey();
            userService.Delete(user);
        }

        private void TestRegisteringUserConstructor()
        {
            Console.Clear();
            uint id = userService.Count() + 1;
            string username;
            string password;
            string email;
            Console.Write("\nUser: ");
            username = Console.ReadLine() ?? string.Empty;
            Console.Write("\nPassword: ");
            password = Console.ReadLine() ?? string.Empty;
            Console.Write("\nEmail: ");
            email = Console.ReadLine() ?? string.Empty;
            User user = new User(id, username, password, email);
            userService.Add(user);
            Console.Write(user);
            Console.ReadKey();
            userService.Delete(user);
        }

        private void TestDefaultConstructor()
        {
            Console.Clear();
            User user = new User();
            userService.Add(user);
            Console.Write(user);
            Console.ReadKey();
            userService.Delete(user);
        }
    }
}
