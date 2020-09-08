using System;
using System.Runtime.CompilerServices;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;

            while (playAgain == true)
            {
                int ties = 0;
                int userWins = 0;
                int compWins = 0;

                Console.WriteLine("Let's play Rock, Paper, Scissors!");
                Console.Write("From 1 - 10, how many rounds should we play? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int userRounds))
                {
                    if (userRounds >= 1 && userRounds <= 10)
                    {
                        int roundsPlayed = 0;

                        while (roundsPlayed < userRounds)
                        {
                            Console.WriteLine("\nWhat will you choose?");
                            Console.WriteLine("Enter 1 for Rock, 2 for Paper, or 3 for Scissors.");
                            Console.Write("Your choice: ");
                            string input2 = Console.ReadLine();


                            if (int.TryParse(input2, out int userChoice))
                            {
                                if (userChoice >= 1 && userChoice <= 3)
                                {
                                    Random randomizer = new Random();
                                    int myChoice = randomizer.Next(1, 4);

                                    Console.WriteLine("\nOk, here we go!");
                                    Console.WriteLine("\nRock...");
                                    Console.WriteLine("\nPaper...");
                                    Console.WriteLine("\nScissors...");
                                    Console.WriteLine("\nSHOOT!!!");
                                    Console.WriteLine("");

                                    if (userChoice == myChoice)
                                    {
                                        if (userChoice == 1)
                                        {
                                            Console.WriteLine("We both chose Rock!");
                                        }
                                        else if (userChoice == 2)
                                        {
                                            Console.WriteLine("We both chose Paper!");
                                        }
                                        else if (userChoice == 3)
                                        {
                                            Console.WriteLine("We both chose Scissors!");
                                        }

                                        Console.WriteLine("That means it's a tie!");
                                        ties++;
                                        roundsPlayed++;
                                    }

                                    if (userChoice == 1 && myChoice == 2)
                                    {
                                        Console.WriteLine("You chose Rock, but I chose Paper!");
                                        Console.WriteLine("Paper covers Rock, I win!");
                                        compWins++;
                                        roundsPlayed++;
                                    }

                                    if (userChoice == 1 && myChoice == 3)
                                    {
                                        Console.WriteLine("You chose Rock, but I chose Scissors...");
                                        Console.WriteLine("Rock SMASHES Scissors! Looks like you won this round...");
                                        userWins++;
                                        roundsPlayed++;
                                    }

                                    if (userChoice == 2 && myChoice == 1)
                                    {
                                        Console.WriteLine("You chose Paper, but I chose Rock...");
                                        Console.WriteLine("Paper covers Rock, you win this time!");
                                        userWins++;
                                        roundsPlayed++;
                                    }

                                    if (userChoice == 2 && myChoice == 3)
                                    {
                                        Console.WriteLine("You chose Paper, but I chose Scissors!");
                                        Console.WriteLine("Scissors cuts Paper! I win!!!");
                                        compWins++;
                                        roundsPlayed++;
                                    }

                                    if (userChoice == 3 && myChoice == 1)
                                    {
                                        Console.WriteLine("You chose Scissors, but I chose Rock!");
                                        Console.WriteLine("Rock SMASHES Scissors! Looks like a win for me!");
                                        compWins++;
                                        roundsPlayed++;
                                    }

                                    if (userChoice == 3 && myChoice == 2)
                                    {
                                        Console.WriteLine("You chose Scissors, but I chose Paper!");
                                        Console.WriteLine("Scissors cuts Paper! You win this time...");
                                        userWins++;
                                        roundsPlayed++;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You didn't choose Rock, Paper, or Sicssors!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Let's try that again...");
                            }
                        }
                        Console.WriteLine("\nFINAL RESULTS:");
                        Console.WriteLine($"\nYou won {userWins} times, I won {compWins} times, and we tied {ties} times!");

                        if (userWins > compWins)
                        {
                            Console.WriteLine("\nYOU ARE THE CHAMPION!");
                        }
                        else if (userWins < compWins)
                        {
                            Console.WriteLine("\nI AM VICTORIOUS!");
                        }
                        else
                        {
                            Console.WriteLine("It appears as though we truly are equals!");
                            Console.WriteLine("Next time, I will surly win!");
                        }

                        bool answered = false;

                        while (answered == false)
                        {
                            Console.Write("\nThat was fun! Should we play again? (y / n) : ");
                            string input3 = Console.ReadLine();
                            Console.WriteLine("");

                            if (input3 == "n")
                            {
                                Console.WriteLine("Thanks for playing, see ya next time!");
                                answered = true;
                                playAgain = false;
                                break;
                            }
                            else if (input3 == "y")
                            {
                                Console.WriteLine("Alright! Bring it on!!!");
                                Console.WriteLine("");
                                answered = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Wait.. what? I'll ask you again...");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number of rounds.");
                        Console.WriteLine("Try again later!");
                        playAgain = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("That's not even a number!");
                    Console.WriteLine("Try again later!");
                    playAgain = false;
                    break;
                }
            }
        }
    }
}
