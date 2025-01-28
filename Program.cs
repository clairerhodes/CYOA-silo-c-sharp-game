// import statements
using System; // contains fundamental types and base class libraries (console, string, int32, dateTime, etc)
using System.Collections.Generic; // provides types that allow storage and managing multiple objects
using System.Linq; // allows you to manipulate data collections and perform operations (where, select, orderBy, etc)
using System.Text; // contains types for text manipulation, for building long strings efficiently
using System.Threading.Tasks; // allows async/await types


namespace Silo // namespace = container that prevents naming conflicts and helps structure code by grouping related elements together
{
    class Program // main logic of application
    {
        static void Main(string[] args) // main method: starting point of any c# console app that is called when you run the program
        {
            Start();
        }


    // start game and have it only start once
        static void Start()
        {
            Console.WriteLine("SILO"); // prints statement in terminal
            Console.WriteLine("Enter your name:");
            // Console.ReadLine(); // read user input, wait for user to input text and hit enter. stores text in a string
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome to the Silo, {playerName}!");
            Console.WriteLine("In a dystopian future, humanity lives in an underground silo, a massive self-sustaining structure that goes 100 floors deep into the Earth. The outside world is filled with toxic air, and the Earth is said to be uninhabitable.");
            Console.WriteLine(" ");
            Console.WriteLine("The rules are strict, and there’s little room for questioning authority.");
            Console.WriteLine("A mysterious council governs from the top, and anyone who questions the status quo risks being sent to the surface—a fate considered as good as death.");
            Console.WriteLine("However, something stirs beneath the surface. Whispers of rebellion, rumors of secret knowledge, and cryptic messages from those who’ve gone before have begun to circulate.");
            Console.WriteLine("You are one of the silo's inhabitants, and you’ve just stumbled upon a forbidden truth: the world outside may not be as deadly as you’ve been told.");
            
            FirstChoice();
        }

        static void FirstChoice()
        {
            Console.WriteLine("You’ve spent your entire life working in the silo’s Maintenance Sector.\n It’s a cold, sterile environment, filled with the constant hum of machinery.");
            Console.WriteLine("It’s a cold, sterile environment, filled with the constant hum of machinery.");
            Console.WriteLine("Today, as you’re fixing a ventilation shaft, something strange happens: you find a hidden compartment in the wall. Inside it is an old journal, weathered and partially decayed, but readable.");
            Console.WriteLine("Inside it is an old journal, weathered and partially decayed, but readable.");
            Console.WriteLine("The journal speaks of a time before the silo, a world above ground—an Earth where humanity lived freely.");
            Console.WriteLine("As you continue reading, you come across a disturbing note: \n 'The surface isn’t as bad as they say. But we must find a way to escape before they realize we know the truth.'");
            Console.WriteLine("Suddenly, a loud alarm rings through the silo. The message is clear: someone is coming. You shove the journal into your jacket and hide in the shadows.");
            Console.WriteLine("What will you do? Type '1', '2', or '3'. 'Quit' to end.");
            Console.WriteLine("1. Continue to hide and wait for intruders to leave.");
            Console.WriteLine("2. Leave the maintenance room and try to find someone you can trust with the journal.");
            Console.WriteLine("3. Confront the intruders head-on, demanding to know what they're doing in the restricted area");

            string choice = Console.ReadLine().ToLower();
            if (choice == "1")
            {
                Hide();
            }
            else if (choice == "2")
            {
                Trust();
            }
            else if (choice == "3")
            {
                Confront();
            }
            else if (choice == "quit")
            {
                Console.WriteLine("Exiting game...");
                Environment.Exit(0);
            }
            else {
                Console.WriteLine("Invalid choice. Please choose '1', '2', or '3'.");
                FirstChoice();
            }
        }

        static void Hide()
        {
            Console.WriteLine(" hide scenario  here ");
            Console.WriteLine("What will you do? Type '1', '2', or '3'. 'Quit' to end.");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // G();
            }
            else if (choice == "2")
            {
                // H();
            }
            else if (choice == "3")
            {
                // I();
            }
            else if (choice == "quit")
            {
                Console.WriteLine("Exiting game...");
                Environment.Exit(0);
            }
            else {
                Console.WriteLine("Invalid choice. Please choose '1', '2', or '3'.");
                Hide();
            }
        }

        static void Trust()
        {
            Console.WriteLine(" trust scenario here ");
            Console.WriteLine("What will you do? Type '1', '2', or '3'. 'Quit' to end.");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // D();
            }
            else if (choice == "2")
            {
                // E();
            }
            else if (choice == "3")
            {
                // F();
            }
            else if (choice == "quit")
            {
                Console.WriteLine("Exiting game...");
                Environment.Exit(0);
            }
            else {
                Console.WriteLine("Invalid choice. Please choose '1', '2', or '3'.");
                Trust();
            }
        }

        static void Confront()
        {
            Console.WriteLine(" Confront scenario here ");
            Console.WriteLine("What will you do? Type '1', '2', or '3'. 'Quit' to end.");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // A();
            }
            else if (choice == "2")
            {
                // B();
            }
            else if (choice == "3")
            {
                // C();
            }
            else if (choice == "quit")
            {
                Console.WriteLine("Exiting game...");
                Environment.Exit(0);
            }
            else {
                Console.WriteLine("Invalid choice. Please choose '1', '2', or '3'.");
                Confront();
            }
        }

        static void EndGame(string message)
        {
            Console.WriteLine("\nGame Over");
            Console.WriteLine(message);
            Console.WriteLine("\nWould you like to play again? (y/n)");
            string playAgain = Console.ReadLine();
            if (playAgain.ToLower() == "y")
            {
                Start();
            }
            else
            {
                Console.WriteLine("Thank you for playing!");
                Environment.Exit(0);
            }
        }


    }

    // class Player
    // {
    //     public string name;
    //     public int coins = 0;
    //     public int health = 10;
    // }
}