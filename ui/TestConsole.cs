using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using Personal_Finance_Tracker.ui.adminConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui
{
    internal class TestConsole(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
        AdminConsole adminConsole = new AdminConsole(transactionService,userService);

        public void Show()
        {
            char? option = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Test Console");
                Console.WriteLine("1. Admin Console");
                Console.WriteLine("0. Exit");
                option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    case '1':
                        
                        adminConsole.Show();
                        break;
                    case '0':
                        Console.WriteLine("\ndick");
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
