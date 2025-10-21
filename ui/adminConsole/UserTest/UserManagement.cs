using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.UserTest
{
    internal class UserManagement(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
        UserConTest userConTest = new UserConTest(transactionService, userService);
        UserCRUDTest userCRUDTest = new UserCRUDTest(transactionService, userService);

        public void Show()
        {
            char? option = null;
            do
            {
                Console.Clear();
                Console.WriteLine("User Management Module Test");
                Console.WriteLine("1. Constructor Test");
                Console.WriteLine("2. CRUD Operations Test");
                Console.WriteLine("0. Exit");

                option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        userConTest.Show();
                        break;
                    case '2':
                        userCRUDTest.Show();
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
    }
}
