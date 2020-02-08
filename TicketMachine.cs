using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M
{    
    class TicketMachine
    {
        
        private int _ticketPrice;
        public int TicketPrice
        {
            get { return _ticketPrice; }
            set {
                if (value < 0)
                {
                    _ticketPrice = 1;
                }
                else
                {
                    _ticketPrice = value;
                }
            }
        }
        private int _balance;
        public int Balance
        {
            get { return _balance; }
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("Please insert money");
                    value = Int32.Parse(Console.ReadLine());
                }
                _balance = value;
            }
        }

        private int _total;
        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private int _discount;
        public int Discount
        {
            get { return _discount; }
            set
            {
                if (value > 0)
                {
                    _discount = value;
                    Console.WriteLine("You are a staff member for SoCS");

                }
                else if (value == 0)
                {
                    _discount = value;
                    Console.WriteLine("You are not a staff member for SoCS");
                }
            }
        }       
        public void insertMoney(int amount) { Balance = amount; }
      
        public void printTicket()
        {
            if (_discount == 1)
            {
                int DiscountTicket = TicketPrice / 2;
                Console.WriteLine($"\nYour discounted ticket price is £{DiscountTicket}");
                
                Console.WriteLine("\nWould you like to refund your inserted money?\n");
                string refund = Console.ReadLine();
                if (refund == "Yes")
                {
                    refundMoney();
                    
                }
                if (Balance >= DiscountTicket)
                {
                    Balance = Balance - DiscountTicket;
                    Total = DiscountTicket;

                    Console.WriteLine("********************");
                    Console.WriteLine("* SoCS Line Ticket *");
                    Console.WriteLine($"*Price = £{DiscountTicket} *");
                    Console.WriteLine("********************");
                }
                else if (Balance <= DiscountTicket)
                {
                    Console.WriteLine("You have insufficient balance to purchase a ticket");
                }
                status();
                Console.WriteLine($"The price of the ticket = £{DiscountTicket}\n");
            }
            if (_discount == 0)
            {
                Console.WriteLine("\nYou recieve no discount on your ticket price");
                Console.WriteLine("\nWould you like to refund your inserted money?\n");
                string refund = Console.ReadLine();
                if (refund == "Yes")
                {
                    refundMoney();

                }
                if (Balance >= TicketPrice)
                {
                    Balance = Balance - TicketPrice;
                    Total = TicketPrice;

                    Console.WriteLine("********************");
                    Console.WriteLine("* SoCS Line Ticket *");
                    Console.WriteLine($"*Price = £{TicketPrice} *");
                    Console.WriteLine("********************");
                }
                else if (Balance <= TicketPrice)
                {
                    Console.WriteLine("You have insufficient balance to purchase a ticket");
                }
                status();
                Console.WriteLine($"The price of the ticket = £{TicketPrice}\n");

            }

        }       
        public void status()
        {
            Console.WriteLine($"Your remaining balance is £{Balance}\n");
            Console.WriteLine($"The total amount spent on the ticket = £{Total}\n");
        }

        public void empty()
        {
            Console.WriteLine($"We will remove £{Balance} from the machine");
            int Removal = Balance - Balance;
            Console.WriteLine($"Your Balance is £{Removal}");

        }

        public void refundMoney()
        {
            _balance = _balance - _balance;
            Console.WriteLine($"Your balance is now £{_balance}");
            System.Environment.Exit(0);
            
        }

    }
}