using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.UserTest
{
    internal class UserSNRTest(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
    }
}
