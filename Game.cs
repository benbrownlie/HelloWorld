using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        string CombineWords(string word1, string word2 )
        {
            string result = word1 + word2;
            return result;
        }
        int SumTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        void PrintStats(string name, float playerHealth, int damage, int level, string role)
        {
            Console.WriteLine("\nWelcome " + role + name + ".");
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Role: " + role);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
        public void Run()
        {
            string newWord = CombineWords("Peanut", "butter");
            int number = SumTwoNumbers(2, 2);
            //gameover
            bool gameOver = false;
            while(gameOver == false )
            {
                //This variable is used to store health
                float playerHealth = 100.0f;
                //This value is used to heal the player
                float healthRegen = 20;
                //This value is used to store level
                bool maxLevelReached = false;
                int maxLevel = 100;
                int level = 1;
                bool ready = true;
                //This value is used to store damage
                int damage = 5;
                //default role
                string role = "none";

                //enemy data

                //Initial conversation
                Console.WriteLine("Hello, Welcome to my inn. What is your name friend?");
                string name = Console.ReadLine();
                Console.WriteLine("Welcome " + name + " ! " + "Please tell me, what are you? ");
                Console.WriteLine("Press 1. for Hunter");
                Console.WriteLine("Press 2. for Gatherer");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                //Role selection
                if (input == '1')
                {
                    playerHealth = playerHealth + 50;
                    role = "Hunter";
                    Console.WriteLine("\nWelcome " + role + " " + name + ".");
                    Console.WriteLine("Health: " + playerHealth);
                    Console.WriteLine("Level: " + level);
                    Console.WriteLine("Role: " + role);
                }

                if (input == '2')
                {
                    damage = damage + 5;
                    role = "Gatherer";
                    Console.WriteLine("\nWelcome " + role + " " + name + ".");
                    Console.WriteLine("Health: " + playerHealth);
                    Console.WriteLine("Level: " + level);
                    Console.WriteLine("Role: " + role);

                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("You are nothing");
                    
                }

                //loops test/gameOver test
                Console.WriteLine("\n*A cloaked figure brandishing a sword approaches you*");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Run");
                Console.WriteLine("3. Really run");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (input == '1')
                {
                    Console.Clear();
                    Console.WriteLine("*You raise your weapon*");
                    int figureHealth = 60;
                    int figureDamage = 10;
                    while (playerHealth > 0 && figureHealth > 0)
                    {
                        //figure stats
                        Console.WriteLine("\nPlayer Name: " + name);
                        Console.WriteLine("Health: " + playerHealth);
                        Console.WriteLine("Damage: " + damage);
                        Console.WriteLine("Level: " + level);
                        Console.WriteLine("Role: " + role);
                        //figure stats
                        Console.WriteLine("\nFigure");
                        Console.WriteLine("Figure Health: " + figureHealth);
                        Console.WriteLine("Figure Damage: " + figureDamage);
                        //player attack input
                        Console.WriteLine("\n1. Strike");
                        Console.WriteLine("2. Block");
                        input = Console.ReadKey().KeyChar;
                        if (input == '1')
                        {
                            figureHealth -= damage;
                            Console.WriteLine("*You slash the figure with your weapon*");
                            Console.WriteLine("*The figure took " + damage + " damage.");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else if (input == '2')
                        {
                            playerHealth -= figureDamage;
                            Console.WriteLine("*You raised your weapon to block the hit");
                            Console.WriteLine("*You took " + figureDamage + "damage*");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        if (figureHealth < 5)
                        {
                            Console.WriteLine("*The figure falls to the floor*");
                            Console.WriteLine("*You remove their cloak to reveal a terrible sight*");
                            Console.WriteLine("*You sprint to the nearest door and bust through*");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }

                else if (input == '2')
                {
                    playerHealth = 0;
                    damage = 10;
                    Console.WriteLine("*You are struck in the back*");
                    Console.WriteLine("You have died");
                    gameOver = true;
                    break;
                }

                else if (input == '3')
                {
                    Console.WriteLine("*You approach the exit. On it is a strange cypher. It reads How many coins are in my pocket*");
                    string guess = " ";
                    for(int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("You have " + (5 - i) + "tries remaining.");
                        guess = Console.ReadLine();
                        if (guess == "Yes")
                        {
                            Console.WriteLine("You have answered well...");
                            Console.WriteLine("*You walk through the now open exit*");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Try again...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        //failed cypher message
                        if (i == 5)
                        {
                            Console.WriteLine("You have failed, the cycle continues.");
                            Console.ReadKey();
                            Console.Clear();
                        }

                    }

                }







                //Create an application that gets the user's name
                //along with an additional input. Print the user's name and input
                //to the console along with their stats. Must use all data types.
            }
            
        }
    }
}
