using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.ReportTest
{
    internal class ReportManagement(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
        public void Show()
        {
            char? option = null;
            do
            {
                // To-do later on once module is created and the rest of the modules are functional
                option = Console.ReadKey().KeyChar;
                return;
            } while (true);

        }
    }
}
