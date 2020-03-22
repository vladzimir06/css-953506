using System;

namespace Lab1Ind1
{
    class Program
    {
        static int GetCard(Random a)
        {
            return a.Next(0, 12);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a; 
            a = b;
            b = temp;
        }

        static void Shuffle(Random a, ref int[] deck)
        {
            Random r = new Random();
            for (int i = 0; i < deck.Length; i++)
            {
                var randomIndex1 = a.Next(0, deck.Length);
                var randomIndex2 = a.Next(0, deck.Length);
                Swap(ref deck[randomIndex1], ref deck[randomIndex2]);
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Random rnd = new Random();
            int[] deck = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int player = 0, ai = 0, card = 0, playerAceCount = 0, aiAceCount = 0;
            char decision;

            Console.WriteLine("Welcome to 21! To win, you need to get the maximum score below 21. Good luck!\n");
            Shuffle(rnd, ref deck);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;


            do
            {
                Console.Clear();
                Console.WriteLine("Here's your first card: ");
                char ans;
                do
                {
                    card = deck[0];
                    if (card == 11)
                    {
                        playerAceCount++;
                    }
                    Shuffle(rnd, ref deck);


                    Console.WriteLine("Your card is {0}", card);
                    player += card;
                    Console.WriteLine($"Your score is: {player}");


                    if (player > 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You lost! Your score is above 21.");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (playerAceCount != 0)
                        {
                            Console.WriteLine("You have some spare aces. You can get rid of them to avoid overflow.\nDo you want to do this? Enter y or no.");
                            char aces = Convert.ToChar(Console.ReadLine());

                            if (aces == 'y')
                            {
                                Console.WriteLine(
                                    $"You have {playerAceCount} spare aces. How many would you like to get rid of?\nEnter your number: ");
                                int getrid = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < getrid; i++)
                                {
                                    player -= 10;
                                    playerAceCount--;
                                }

                            }
                            else if (aces == 'n')
                                break;


                        }
                        else
                            break;
                    }

                    Console.Write("Do you want to take another card? Enter y or n: ");
                    ans = Convert.ToChar(Console.ReadLine());

                } while (ans != 'n');

                Console.WriteLine("\n");

                if (player <= 21)
                {
                    Console.WriteLine("Your opponent's cards: ");
                    do
                    {
                        Shuffle(rnd, ref deck);
                        card = deck[0];
                        Console.WriteLine(card);
                        ai += card;
                        if (card == 11)
                        {
                            aiAceCount++;
                        }

                    } while (ai <= 17);

                    if (ai > 21)
                    {
                        if (aiAceCount != 0)
                        {
                            int shall = rnd.Next(0, 1);
                            switch (shall)
                            {
                                case 0:
                                {
                                    while (ai > 21 && aiAceCount > 0)
                                    {
                                        ai -= 10;
                                        aiAceCount--;
                                    }

                                    break;
                                }

                                case 1:
                                {
                                    break;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"The AI's score is: {ai}");


                    if (player > ai)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won! Congratulations!\n");
                    }
                    else if (player == ai)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Tie!\n");
                    }
                    else if (player < ai && ai <= 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You lost! Better luck next time!");
                    }
                    else if (player < ai && ai >= 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won! Your opponent's score is above 21! Congratulations!\n");
                    }
                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                player = ai = card = 0;
                Console.Write("Do you want to play one more time? Enter y or n: ");
                decision = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n\n");

            } while (decision != 'n');

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thank You!\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}