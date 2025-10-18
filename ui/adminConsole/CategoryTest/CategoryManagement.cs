using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.CategoryTest
{
    internal class CategoryManagement(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
        public void Show()
        {
            char? option = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Category Management Module Test");
                Console.WriteLine("1. Constructor Test");
                Console.WriteLine("2. Search and Retrieval Test");
                Console.WriteLine("0. Exit");

                option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        Console.WriteLine("\nConstructor Test...");
                        break;
                    case '2':
                        Console.WriteLine("\nSearch and Retrieval Test...");
                        break;
                    case '0':
                        Console.WriteLine("\nExiting User Management Module Test...");
                        return;
                    default:
                        Console.WriteLine("\nInvalid Option. Please try again.");
                        Console.ReadKey();
                        break;
                }

            } while (true);
        }
    }
}
