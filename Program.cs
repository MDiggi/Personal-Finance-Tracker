using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using Personal_Finance_Tracker.ui;
using System.Security.Cryptography.X509Certificates;

namespace Personal_Finance_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransactionService<Transaction> transactionService = new TransactionService<Transaction>();
            UserService<User> userService = new UserService<User>();
            TestConsole testConsole = new TestConsole(transactionService, userService);
            testConsole.Show();
        }
    }
}
