using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.TransactionTest
{
    internal class TransactionCRUDTest
    {
        public void Show()
        {
            char? option = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Transaction CRUD Operations Test");
                Console.WriteLine("1. Create Transaction Test");
                Console.WriteLine("2. Read Transaction Test");
                Console.WriteLine("3. Update Transaction Test");
                Console.WriteLine("4. Delete Transaction Test");
                Console.WriteLine("0. Exit");
                option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    case '1':
                        Console.WriteLine("\nCreate Transaction Test...");
                        break;
                    case '2':
                        Console.WriteLine("\nRead Transaction Test...");
                        break;
                    case '3':
                        Console.WriteLine("\nUpdate Transaction Test...");
                        break;
                    case '4':
                        Console.WriteLine("\nDelete Transaction Test...");
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
    }
}
