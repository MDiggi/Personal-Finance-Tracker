using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using System.Security.Cryptography.X509Certificates;

namespace Personal_Finance_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userService = new UserService<User>();
            var transactionService = new TransactionService<Transaction>();

            User user = new User(userService.Count() + 1, "test1", "password", "email");
            userService.Add(user);

            Console.WriteLine("All Users:");
            userService.PrintAll();

            Transaction transaction = new Transaction(transactionService.Count() + 1, "Groceries", 50.75m, DateTime.Now, "Food", "Bought groceries", user.GetId());
        }
    }
}
