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
        static void Main(string[] args)
        {
            No1();
        }
    }
}
