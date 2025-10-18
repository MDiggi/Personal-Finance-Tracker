using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using Personal_Finance_Tracker.ui.adminConsole.CategoryTest;
using Personal_Finance_Tracker.ui.adminConsole.ReportTest;
using Personal_Finance_Tracker.ui.adminConsole.TransactionTest;
using Personal_Finance_Tracker.ui.adminConsole.UserTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole
{
    internal class AdminConsole(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
        private UserManagement userManagement = new UserManagement(transactionService, userService);
        private TransactionManagement transactionManagement = new TransactionManagement(transactionService, userService);
        private CategoryManagement categoryManagement = new CategoryManagement(transactionService, userService);
        private ReportManagement reportManagement = new ReportManagement(transactionService, userService);

        public void Show()
        {
            char? option = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Admin Console");
                Console.WriteLine("1. Manage Users");
                Console.WriteLine("2. Manage Transactions");
                Console.WriteLine("3. Manage Categories (needs 1 user created)");
                Console.WriteLine("4. Reports");
                Console.WriteLine("0. Exit");
                option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    case '1':
                        userManagement.Show();
                        break;
                    case '2':
                        transactionManagement.Show();
                        break;
                    case '3':
                        categoryManagement.Show();
                        break;
                    case '4':
                        reportManagement.Show();
                        break;
                    case '0':
                        Console.WriteLine("\nExiting Admin Console...");
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
