using System;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalCoffeeCost = 0;
            Start:
            Console.WriteLine("Please select your coffee size: 1- Small, 2- Medium, 3 - Large");
            int number = Convert.ToInt32(Console.ReadLine());
            string choice;

           
                switch (number)
                {
                    case 1:
                    TotalCoffeeCost += 1;
                        break;

                    case 2:
                    TotalCoffeeCost += 2;
                    break;

                    case 3:
                    TotalCoffeeCost += 3;
                    break;


                default:
                        Console.WriteLine("That's not a valid choice.");
                        goto Start;
                }

        Decision:
            Console.WriteLine("Do you wanna keep going? Y or N.");
            choice = Console.ReadLine();
            switch(choice.ToUpper())
                {
                case "Y":
                    goto Start;

                case "N":
                    break;

                default:
                    Console.WriteLine("That choice is invalid.");
                    goto Decision;
            }
            Console.WriteLine("Your coffee total is {0}", TotalCoffeeCost);



        }
    }
}
