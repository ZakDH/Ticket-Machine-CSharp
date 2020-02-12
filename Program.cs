using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketMachine t = new TicketMachine();

            Console.WriteLine("Are you a staff member for SoCS? ");
            string staffMember = Console.ReadLine();
            string Member = "Yes";
                if (staffMember == Member)
                {
                    t.Discount = 1;
                }            
                else
                {
                    t.Discount = 0;
                }
            
            Console.WriteLine("Please enter a ticket price: ");
            t.TicketPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your money amount: ");
            int amount = Int32.Parse(Console.ReadLine());
            t.insertMoney(amount);

            t.printTicket();

            if (t.Balance >= t.TicketPrice)
            {
                Console.WriteLine("Would you like to print off another additional ticket? Yes or No\n");
                string decision = Console.ReadLine();
                if (decision == "Yes")
                {
                    t.printTicket();
                }
                else
                {
                    Console.WriteLine("Okay. I will display your current balance\n");
                    t.status();
                }
            }
            Console.WriteLine("Do you want to remove all money from the machine? ");
            string decision2 = Console.ReadLine();
            if (decision2 == "Yes")
            {
                t.empty();
            }
            else
            {
                Console.WriteLine($"\nOkay your balance is still £{t.Balance}");
            }
        }
    }
}

//commiting//