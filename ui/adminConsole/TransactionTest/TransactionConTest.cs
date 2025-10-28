using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.TransactionTest
{
    internal class TransactionConTest(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
        public void Show()
        {
            char? option = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Transaction Constructor Test");
                Console.WriteLine("1. Parameterized Constructor");
                Console.WriteLine("2. Normal Constructor");
                Console.WriteLine("3. Default Constructor");
                Console.WriteLine("0. Exit");
                option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    case '1':
                        ParameterizedConstructorTest();
                        break;
                    case '2':
                        NormalConstructorTest();
                        break;
                    case '3':
                        DefaultConstructorTest();
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

        private void ParameterizedConstructorTest()
        {
            Console.Clear();
            uint id;
            uint userId;
            DateTime date;
            string description;
            decimal amount;
            Category category = new Category();
            TransactionType flag;

            Console.Write("Transaction ID: ");
            id = uint.Parse(Console.ReadLine() ?? "0");
            Console.Write("User ID: ");
            userId = uint.Parse(Console.ReadLine() ?? "0");
            Console.Write("Date (yyyy-MM-dd): ");
            date = DateTime.Parse(Console.ReadLine() ?? DateTime.MinValue.ToString());
            Console.Write("Description: ");
            description = Console.ReadLine() ?? string.Empty;
            Console.Write("Amount: ");
            amount = decimal.Parse(Console.ReadLine() ?? "0");
            Console.Write("Transaction Type (0: None, 1: Income, 2: Expense, 3: Transfer): ");
            flag = (TransactionType)Enum.Parse(typeof(TransactionType), Console.ReadLine() ?? "0");

            Transaction transaction = new Transaction(id, userId, date, description, amount, category, flag);
            Console.WriteLine(transaction);
            Console.ReadKey();
        }

        private void NormalConstructorTest()
        {
            Console.Clear();
            uint userId;
            string description;
            decimal amount;

            Console.Write("User ID: ");
            userId = uint.Parse(Console.ReadLine() ?? "0");
            Console.Write("Description: ");
            description = Console.ReadLine() ?? string.Empty;
            Console.Write("Amount: ");
            amount = decimal.Parse(Console.ReadLine() ?? "0");

            Transaction transaction = new Transaction(userId, description, amount);
            Console.WriteLine(transaction);
            Console.ReadKey();
        }

        private void DefaultConstructorTest()
        {
            Console.Clear();
            Transaction transaction = new Transaction();
            Console.WriteLine(transaction);
            Console.ReadKey();
        }
    }
}
