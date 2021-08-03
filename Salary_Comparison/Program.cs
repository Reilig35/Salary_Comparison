using System;

namespace Salary_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person 1 Details
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1");
            Console.WriteLine("Please enter your hourly rate?\n");
            decimal Person1_Rate = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("How many hours do you work a week?\n");
            decimal Person1_Hours = Convert.ToDecimal(Console.ReadLine());

            decimal Person1_Yearly = (Person1_Hours * Person1_Rate) * 52;

            //Person 2 Details
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate?\n");
            decimal Person2_Rate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("How many hours do you work a week?\n");
            decimal Person2_Hours = Convert.ToDecimal(Console.ReadLine());

            decimal Person2_Yearly = (Person2_Hours * Person2_Rate) * 52;

            //Printing out yearly incomes
            Console.WriteLine($"Annual salary of Person 1 is\n_____________________________\n{Person1_Yearly}\n");
            Console.WriteLine($"Annual salary of Person 2 is\n_____________________________\n{Person2_Yearly}\n");

            //Result
            if (Person1_Yearly > Person2_Yearly)
            {
                Console.WriteLine($"Does person 1 make more money than Person 2\n_____________________________________________\n{true}");
            }
            else
            {
                Console.WriteLine($"Does person 1 make more money than Person 2\n_____________________________________________\n{false}");
            }
        }
    }
}
