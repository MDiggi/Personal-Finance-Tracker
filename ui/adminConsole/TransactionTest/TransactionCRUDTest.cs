using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.TransactionTest
{
    internal class TransactionCRUDTest(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
        public void Show()
        {
            char? option = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Transaction CRUD Operations Test");
                Console.WriteLine("1. Add Transaction");
                Console.WriteLine("2. Delete Transaction");
                Console.WriteLine("3. Update Transaction");
                Console.WriteLine("4. Print All Transactions");
                Console.WriteLine("5. Get Transactions");
                Console.WriteLine("6. Verify Existence");
                Console.WriteLine("0. Exit");
                option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    case '1':
                        TestAddTransaction();
                        break;
                    case '2':
                        TestRemoveTransaction();
                        break;
                    case '3':
                        TestUpdateTransaction();
                        break;
                    case '4':
                        TestPrintAllTransactions();
                        break;
                    case '5':
                        TestGetTransactions();
                        break;
                    case '0':
                        Console.WriteLine("\nExiting Transaction CRUD Operations Test...");
                        return;
                    default:
                        Console.WriteLine("\nInvalid Option. Please try again.");
                        Console.ReadKey();
                        break;
                }
            } while (true);
        }

        private void TestAddTransaction()
        {
            Console.Clear();
            uint id = transactionService.Count() + 1;
            uint userId;
            string description;
            decimal amount;

            do
            {
                Console.Write("User ID: ");
                userId = uint.Parse(Console.ReadLine() ?? "0");
                if (userService.IdCheck(userId))
                    break;
                else
                    Console.WriteLine("User ID does not exist. Please try again.");
            } while (true);

            User user = userService.GetById(userId);

            Console.Write("Description: ");
            description = Console.ReadLine() ?? string.Empty;
            Console.Write("Amount: ");
            amount = decimal.Parse(Console.ReadLine() ?? "0");
            Transaction transaction = new Transaction(id, userId, description, amount);
            transactionService.Add(transaction);
            user.GetTransactions().Add(transaction);
            Console.Clear();
            Console.WriteLine("\nTransaction added successfully!");
            Console.WriteLine(user.PrintTransactions());
        }

        private void TestRemoveTransaction()
        {
            Console.Clear();
            uint id;
            Console.Write("Transaction ID to remove: ");
            id = uint.Parse(Console.ReadLine() ?? "0");
            if (transactionService.IdCheck(id))
            {
                Transaction transaction = transactionService.GetById(id);
                User user = userService.GetById(transaction.GetUserId());
                transactionService.Remove(transaction);
                user.GetTransactions().Remove(transaction);
                Console.Clear();
                Console.WriteLine("\nTransaction removed successfully!");
                Console.WriteLine(user.PrintTransactions());
            }
            else
            {
                Console.WriteLine("Transaction ID does not exist. Press any key to return to menu.");
                Console.ReadKey();
            }
        }

        private void TestUpdateTransaction()
        {
            Console.Clear();
            Transaction oldTransaction;
            Transaction newTransaction;

            do
            {
                Console.Write("Old Transaction ID:");
                uint id = uint.Parse(Console.ReadLine() ?? "0");
                if (transactionService.GetById(id) != null)
                {
                    oldTransaction = transactionService.GetById(id);
                    break;
                }
                else
                    Console.WriteLine("Transaction ID does not exist. Please try again.");
            } while (true);

            Console.Clear();

            do
            {
                Console.Write("New Transaction ID:");
                uint id = uint.Parse(Console.ReadLine() ?? "0");
                if (transactionService.GetById(id) != null)
                {
                    newTransaction = transactionService.GetById(id);
                    break;
                }
                else
                    Console.WriteLine("Transaction ID does not exist. Please try again.");
            } while (true);

            if (oldTransaction.GetUserId() != newTransaction.GetUserId())
            {
                Console.Clear();
                Console.WriteLine("Cannot update transaction. User IDs do not match. Press any key to return to menu.");
                Console.ReadKey();
                return;
            }

            transactionService.Update(oldTransaction, newTransaction);
            Console.Clear();
            Console.WriteLine("\nTransaction updated successfully!");
            Console.ReadKey();
        }

        private void TestPrintAllTransactions()
        {
            Console.Clear();
            transactionService.PrintAll();
            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey();
        }

        private void TestGetTransactions()
        {
            Console.Clear();
            char? option = null;

            do
            {
                Console.WriteLine("Get Transactions By:");
                Console.WriteLine("1. Transaction ID");
                Console.WriteLine("2. User ID");
                Console.WriteLine("3. Category ID");
                Console.WriteLine("4. Get All Transactions");
                Console.WriteLine("0. Exit");
                option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Transaction ID: ");
                        uint id = uint.Parse(Console.ReadLine() ?? "0");
                        Transaction transaction1 = transactionService.GetById(id);
                        if (transaction1 != null)
                            Console.WriteLine(transaction1.ToString());
                        else
                            Console.WriteLine("Transaction ID does not exist.");
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        break;

                    case '2':
                        Console.Clear();
                        Console.Write("User ID: ");
                        uint userId = uint.Parse(Console.ReadLine() ?? "0");
                        List<Transaction> userTransactions = transactionService.GetByUserId(userId);
                        if (userTransactions.Count > 0)
                        {
                            foreach (var transaction in userTransactions)
                            {
                                Console.WriteLine(transaction.ToString());
                            }
                        }
                        else
                            Console.WriteLine("No transactions found for this User ID.");
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        break;

                    case '3':
                        Console.Clear();
                        Console.Write("Category ID: ");
                        uint categoryId = uint.Parse(Console.ReadLine() ?? "0");
                        Console.Write("User ID: ");
                        uint userIdForCategory = uint.Parse(Console.ReadLine() ?? "0");
                        User user = userService.GetById(userIdForCategory);

                        List<Transaction> categoryTransactions = transactionService.GetByCategoryId(categoryId, user);
                        if (categoryTransactions.Count > 0)
                        {
                            foreach (var transaction in categoryTransactions)
                            {
                                Console.WriteLine(transaction.ToString());
                            }
                        }
                        else
                            Console.WriteLine("No transactions found for this Category ID.");
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        break;
                    case '4':
                        Console.Clear();
                        List<Transaction> allTransactions = transactionService.GetAll();
                        foreach (var transaction in allTransactions)
                        {
                            Console.WriteLine(transaction.ToString());
                        }
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        break;
                    case '0':
                        return;

                    default:
                        Console.WriteLine("\nInvalid Option. Please try again.");
                        Console.ReadKey();
                        break;

                }
            
            }while (true);
        }
    }
}
