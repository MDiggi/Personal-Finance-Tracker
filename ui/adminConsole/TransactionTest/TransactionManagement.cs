using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.TransactionTest
{
    internal class TransactionManagement(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
        public void Show()
        {
            char? option = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Transaction Management Module Test");
                Console.WriteLine("1. Constructor Test");
                Console.WriteLine("2. CRUD Operations Test");
                Console.WriteLine("3. Search and Retrieval Test");
                Console.WriteLine("4. Utility Methods Test");
                Console.WriteLine("0. Exit");

                option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        Console.WriteLine("\nConstructor Test...");
                        break;
                    case '2':
                        Console.WriteLine("\nCRUD Operations Test...");
                        break;
                    case '3':
                        Console.WriteLine("\nSearch and Retrieval Test...");
                        break;
                    case '4':
                        Console.WriteLine("\nUtility Methods Test...");
                        break;
                    case '0':
                        Console.WriteLine("\nExiting Transaction Management Module Test...");
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
