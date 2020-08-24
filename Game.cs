using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //This variable is used to store health
            float health = 100.0f;
            //This value is used to heal the player
            float healthRegen = 20;
            //This value is used to store level
            bool maxLevelReached = false;
            int maxLevel = 100;
            int level = 1;
            bool ready = true;
            //This value is used to store damage
            int damage = 5;


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
                health = health + 50;
                string role = "Hunter";
                Console.WriteLine("\nWelcome Hunter " + name);
                Console.WriteLine("Health: " + health);
                Console.WriteLine("Level: " + level);
                Console.WriteLine("Role: " + role);
            }

            if (input == '2')
            {
                string role = "Gatherer";
                Console.WriteLine("\nWelcome Gatherer " + name);
                Console.WriteLine("Health: " + health);
                Console.WriteLine("Level: " + level);
                Console.WriteLine("Role: " + role);

            }


            //Create an application that gets the user's name
            //along with an additional input. Print the user's name and input
            //to the console along with their stats. Must use all data types.
        }
    }
}
