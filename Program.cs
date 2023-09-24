using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What's your name?");
            Console.Write("Type in your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.Write("Type in your last name: ");
            string myLastName;
            myLastName = Console.ReadLine();

            Console.WriteLine("How old are you " + myFirstName + "?");
            Console.Write("Type in your age: ");
            string myAge;
            myAge = Console.ReadLine();

            Console.WriteLine("What kind of food do you like " + myFirstName + "?");
            Console.Write("Type in your fav food: ");
            string favFood;
            favFood = Console.ReadLine();

            Console.WriteLine("Hey, " + myFirstName + " " + myLastName + " you are " + myAge + " years old and you've told me you really like to eat " + favFood + "!");
            
            Console.WriteLine("Is this info correct?");
            Console.Write("Answer true or false: ");
            string answer = Console.ReadLine();           
            if (answer == "true" || answer == "True")
            {
                Console.WriteLine("Good that all of the info is correct, i hope you have a nice day " + myFirstName + "!");
            }
            else if (answer == "false" || answer == "False")
            {
                Console.WriteLine("Im sorry to hear that, you have to speak up more.");
            }
            else
            {
                Console.WriteLine("I don't understand you, please type true or false.");
            }
            
        }
    }
}