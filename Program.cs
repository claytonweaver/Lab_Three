using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resume = true;
            string oddorEven = "";

            while (resume == true)
            {
                Console.WriteLine("Please enter your name.");
                string userName = Console.ReadLine();
                Console.WriteLine($"Hello, {userName}. Please enter a number between 1 and 100.");
                int userNum = int.Parse(Console.ReadLine());





                if (userNum > 100 || userNum < 0)
                {
                    Console.WriteLine("Please enter a number between 1 and 100.");
                    userNum = int.Parse(Console.ReadLine());
                }

                    if (userNum % 2 == 0)
                {
                    oddorEven = "even";

                }
                else
                {
                    oddorEven = "odd";
                }

                if (userNum >= 1 && userNum <= 25 && oddorEven == "even")
                {
                    Console.WriteLine($"{oddorEven} and less than 25.");
                }
                else if (userNum >= 1 && userNum <= 25 && oddorEven == "odd")
                {
                    Console.WriteLine(oddorEven);
                }
                else if (userNum >= 26 && userNum <= 60)
                {
                    Console.WriteLine(oddorEven);
                }
                else if (userNum > 60)
                {
                    Console.WriteLine($"{userNum} is {oddorEven}");
                }
                

                Console.WriteLine("Do you want to try again? (Y/N)");
                char userKey = Console.ReadLine().ToUpper()[0];
                
                if (userKey == 'Y')
                {
                    resume = true;
                }
                else if (userKey == 'N')
                    resume = false;
                }
                

                


            }
        }
    }


