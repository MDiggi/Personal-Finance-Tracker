using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker.ui.adminConsole.TransactionTest
{
    internal class TransactionConTest
    {
        public void Show()
        {
            char? option = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Transaction Constructor Test");
                Console.WriteLine("1. Test Transaction Constructor");
                Console.WriteLine("0. Exit");
                option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    case '1':
                        Console.WriteLine("\nTesting Transaction Constructor...");
                        // Here you would add actual test code for the Transaction constructor
                        break;
                    case '0':
                        Console.WriteLine("\nExiting Transaction Constructor Test...");
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
