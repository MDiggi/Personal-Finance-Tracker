using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui
{
    internal class TestConsole
    {
        //Admin Console Tests
        public void UserManagement()
        {
            Console.WriteLine("User Management Module Test");

        }
        public void AdminConsole()
        {
            char? option = null;
            do
            {
                Console.WriteLine("Admin Console");
                Console.WriteLine("1. Manage Users");
                Console.WriteLine("2. Manage Transactions");
                Console.WriteLine("3. Manage Categories");
                Console.WriteLine("4. Reports");
                Console.WriteLine("0. Exit");

                option = Console.ReadKey().KeyChar;

                Console.Clear();

                switch(option)
                {
                    case '1':
                        Console.WriteLine("\nManaging Users...");
                        break;
                    case '2':
                        Console.WriteLine("\nManaging Transactions...");
                        break;
                    case '3':
                        Console.WriteLine("\nManaging Categories...");
                        break;
                    case '4':
                        Console.WriteLine("\nGenerating Reports...");
                        break;
                    case '0':
                        Console.WriteLine("\nExiting Admin Console...");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Option. Please try again.");
                        break;
                }
            } while(option != 0);
        }
    }
}
