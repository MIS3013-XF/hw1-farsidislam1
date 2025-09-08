// HW1b Grade

// Your Name: Farsid Islam
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your OU ID?");
            int IDnumb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for Homework?");
            double hw = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for Participations?");
            double parti = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            double E1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            double E2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for Exam 3?");
            double E3 = Convert.ToDouble(Console.ReadLine());

            const double HW_PERC = 0.20;
            const double PARTI_PERC = 0.15;
            const double E1_PERC = 0.15;
            const double E2_PERC = 0.25;
            const double E3_PERC = 0.25;

            double total = (hw * HW_PERC) + (parti * PARTI_PERC) + (E1 * E1_PERC) + (E2 * E2_PERC) + (E3 * E3_PERC);

            Console.WriteLine($"{firstname} {lastname} ({IDnumb}), your final grade is {total:F2}%");
        }
    }
}
