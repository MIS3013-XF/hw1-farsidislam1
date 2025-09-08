// HW1a Sales Total

// Your Name: Farsid Islam
// Did you seek help ? If yes, specify the helper or web link here: I used the slides provided in class to help me.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What kind of ticket do you wanna buy?");
            string myTicket = Console.ReadLine();

            Console.WriteLine("How many would you like to buy?");
            int myAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the price?");
            double myPrice = Convert.ToDouble(Console.ReadLine());

            const double SALES_TAX_RATE = 0.085;
            double AmtXPrice = myAmount * myPrice;
            double salesTax = AmtXPrice * SALES_TAX_RATE;
            double total = AmtXPrice + salesTax;

            Console.WriteLine($"Your subtotal is ${AmtXPrice}");
            Console.WriteLine($"Your sales tax is ${salesTax}");
            Console.WriteLine($"Your final total is ${total}");
        }
    }
}
