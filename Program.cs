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
        }

        static void chapter1()
        {
            Console.WriteLine("")
        }






    }

    // class Player
    // {
    //     public string name;
    //     public int coins = 0;
    //     public int health = 10;
    // }
}