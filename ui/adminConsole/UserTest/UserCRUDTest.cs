using Personal_Finance_Tracker.models;
using Personal_Finance_Tracker.services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.UserTest
{
    internal class UserCRUDTest(TransactionService<Transaction> transactionService, UserService<User> userService)
    {
        public void Show()
        {
            char? option = null;
            do
            {
                Console.Clear();
                Console.WriteLine("User CRUD Test Module");
                Console.WriteLine("a. Add User");
                Console.WriteLine("b. Delete User");
                Console.WriteLine("c. Update User");
                Console.WriteLine("e. Print All Users [GetAll() funcional]");
                Console.WriteLine("f. Print User with User");
                Console.WriteLine("g. Count Users");
                Console.WriteLine("h. Clear All Users");
                Console.WriteLine("i. Check User Existence bt User");

                Console.WriteLine("\nTo be implemented/fixed:");
                Console.WriteLine("j. Print User by Username");
                Console.WriteLine("k. Print User by ID");

                Console.WriteLine("l. Check User Existence by Username");
                Console.WriteLine("m. Check User Existence by ID");

                Console.WriteLine("0. Exit");

                option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case 'a':
                        TestAddUser();
                        break;
                    case 'b':
                        TestDeleteUser();
                        break;
                    case 'c':
                        TestUpdateUser();
                        break;
                    case 'e':
                        TestPrintAllUsers();
                        break;
                    case 'f':
                        Console.WriteLine("\nPrint User with User Test...");
                        break;
                    case 'g':
                        Console.WriteLine("\nCount Users Test...");
                        break;
                    case 'h':
                        Console.WriteLine("\nClear All Users Test...");
                        break;
                    case 'i':
                        Console.WriteLine("\nCheck User Existence by User Test...");
                        break;
                    case 'j':
                        Console.WriteLine("\nPrint User by Username Test... [To be implemented/fixed]");
                        break;
                    case 'k':
                        Console.WriteLine("\nPrint User by ID Test... [To be implemented/fixed]");
                        break;
                    case 'l':
                        Console.WriteLine("\nCheck User Existence by Username Test... [To be implemented/fixed]");
                        break;
                    case 'm':
                        Console.WriteLine("\nCheck User Existence by ID Test... [To be implemented/fixed]");
                        break;
                    case '0':
                        Console.WriteLine("\nExiting User CRUD Test Module...");
                        return;
                    default:
                        Console.WriteLine("\nInvalid Option. Please try again.");
                        Console.ReadKey();
                        break;
                }
            } while (true);
        }

        private void TestAddUser()
        {
            Console.Clear();
            uint id = userService.Count() + 1;
            List<Transaction> transactions = new List<Transaction>();
            List<Category> categories = new List<Category>();

            Console.Write("User: ");
            string username = Console.ReadLine() ?? string.Empty;
            Console.Write("Password: ");
            string password = Console.ReadLine() ?? string.Empty;
            Console.Write("Email: ");
            string email = Console.ReadLine() ?? string.Empty;
            Console.Write("Created At (yyyy-MM-dd HH:mm:ss): ");
            DateTime createdAt = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("\n\nTransaction Input Test");
            Console.Write("Description: ");
            string transactionDescription = Console.ReadLine() ?? string.Empty;
            Console.Write("Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            transactions.Add(new Transaction(id, transactionDescription, amount));
            transactionService.Add(transactions[0]);

            Console.WriteLine("\n\nCategory Input Test");
            uint categoryId = 1;
            Console.Write("Name: ");
            string categoryName = Console.ReadLine() ?? string.Empty;
            Console.Write("Description: ");
            string categoryDescription = Console.ReadLine() ?? string.Empty;
            categories.Add(new Category(categoryId, categoryName, categoryDescription));


            Console.Write("Balance: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            User user = new User(id, username, password, email, createdAt, transactions, categories, balance);
            userService.Add(user);
            Console.Clear();
            Console.WriteLine("\nUser added successfully! (Should be 2 Categories, 1 User, 1 Transaction)\n");
            Console.WriteLine("===============================================================");
            userService.PrintUser(user);
            Console.WriteLine("===============================================================");
            Console.WriteLine(userService.PrintUserCategories(user));
            Console.WriteLine("===============================================================");
            Console.WriteLine(userService.PrintUserTransactions(user));
            Console.WriteLine("===============================================================");

            Console.ReadKey();
        }

        private void TestDeleteUser()
        {
            do
            {
                Console.WriteLine("1. User ID:");
                Console.WriteLine("2. Username: ");
                Console.WriteLine("0. Exit");

                char? option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    case '1':
                        Console.Write("Enter User ID: ");
                        string userIdInput = Console.ReadLine() ?? string.Empty;
                        int.TryParse(userIdInput, out int userId);
                        // User userToDelete = userService.GetById((uint)userId);
                        //userService.Delete(userToDelete);
                        break;
                    case '2':
                        Console.Write("Enter Username: ");
                        string username = Console.ReadLine() ?? string.Empty;
                        // User userToDeleteByUsername = userService.GetByUsername(username);
                        //userService.Delete(userToDeleteByUsername);
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

        private void TestUpdateUser()
        {
            User oldUser = new User();
            User newUser = new User();

            Console.Clear();
            Console.WriteLine("Old User");
            Console.WriteLine("1. User ID:");
            Console.WriteLine("2. Username: ");
            Console.WriteLine("0. Exit");
            char? option1 = Console.ReadKey().KeyChar;
            switch (option1)
            {
                case '1':
                    Console.Write("Enter User ID: ");
                    string userIdInput = Console.ReadLine() ?? string.Empty;
                    int.TryParse(userIdInput, out int userId);
                    // oldUser = userService.GetById((uint)userId);
                    return;
                case '2':
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine() ?? string.Empty;
                    // oldUser = userService.GetByUsername(username);
                    return;
                case '0':
                    return;
                default:
                    Console.WriteLine("\nInvalid Option. Please try again.");
                    Console.ReadKey();
                    break;
            }

            Console.Clear();
            Console.WriteLine("New User");
            Console.WriteLine("1. User ID:");
            Console.WriteLine("2. Username: ");
            Console.WriteLine("0. Exit");

            char? option2 = Console.ReadKey().KeyChar;
            switch (option2)
            {
                case '1':
                    Console.Write("Enter User ID: ");
                    string userIdInput = Console.ReadLine() ?? string.Empty;
                    int.TryParse(userIdInput, out int userId);
                    // newUser = userService.GetById((uint)userId);
                    return;
                case '2':
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine() ?? string.Empty;
                    // newUser = userService.GetByUsername(username);
                    return;
                case '0':
                    return;
                default:
                    Console.WriteLine("\nInvalid Option. Please try again.");
                    Console.ReadKey();
                    break;
            }

            userService.Update(oldUser, newUser);
        }

        private void TestPrintAllUsers()
        {
            Console.Clear();
            Console.WriteLine("All Users:");
            userService.PrintAll();
            Console.ReadKey();
        }
    }
}
