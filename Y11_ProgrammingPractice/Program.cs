namespace Y11_ProgrammingPractice
{
    internal class Program
    {
        static void No1()
        {
            Random r = new Random();
            int dice1 = r.Next(1, 7);
            int dice2 = r.Next(1, 7);
            int total = dice1 + dice2;
            bool continueGame = true;
            while (continueGame)
            {
                Console.WriteLine($"Roll 1: {dice1}");
                Console.WriteLine($"Roll 2: {dice2}");
                Console.WriteLine($"Current score: {total}");
                if (total < 21)
                {
                    Console.WriteLine("Would you like to roll again?");
                    if (Console.ReadLine()!.ToLower() == "no")
                    {
                        continueGame = false;
                        if (total == 21)
                        {
                            Console.WriteLine("You won!");
                        }
                        else if (total > 21)
                        {
                            Console.WriteLine("You lost!");
                        }
                        else if (total < 21)
                        {
                            int newNum = r.Next(15, 22);
                            if (newNum > total)
                            {
                                Console.WriteLine("You lost!");
                            }
                            else
                            {
                                Console.WriteLine("You won!");
                            }
                        }
                    }
                    else
                    {
                        dice1 = r.Next(1, 7);
                        dice2 = r.Next(1, 7);
                        total += dice1 + dice2;
                    }
                }
                else
                {
                    Console.WriteLine("You lost!");
                    continueGame = false;
                }
            }
        }

        static int No2(int days)
        {
            int daysOver200 = 0;
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"Enter the number of visitors on day {i + 1}");
                int visitors = Convert.ToInt32(Console.ReadLine()!);                
                if (visitors > 200)
                {
                    daysOver200++;
                }
            }
            return daysOver200;
        }
        static void No3()
        {
            Console.WriteLine("Enter the total amount of the bill");
            double total = Convert.ToDouble(Console.ReadLine()!);
            int i = 1;
            while (total > 0)
            {
                Console.WriteLine($"How much is person {i} paying towards the bill?");
                total -= Convert.ToDouble(Console.ReadLine()!);
                if (total > 0)
                {
                    Console.WriteLine($"Amount left to pay: £{total}");
                }
                i++;
            }

            if (total == 0)
            {
                Console.WriteLine("Bill paid");

            }

            else if (total < 0)
            {
                Console.WriteLine($"Tip is {0 - total}");

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("emter");
            int daysOver200 = No2(Convert.ToInt32(Console.ReadLine()!));
            Console.WriteLine($"days over 200: {daysOver200}");
        }
    }
}
