
using System;

namespace VotingEligibility
{
    class Program
    {
        static void Main(string[] args)
        {
            string vname;
            int age;

            try
            {
                Console.Write("Enter your Name: ");
                vname = Console.ReadLine();
                Console.Write("Enter your Age: ");
                age = int.Parse(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine($"Hi {vname}, your age is greater than 18, so you are eligible to vote.");
                }
                else
                {
                    Console.WriteLine($"Sorry {vname}, your age is less than 18, so you are not eligible to vote.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}

