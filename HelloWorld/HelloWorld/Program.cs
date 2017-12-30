using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Console;

namespace HelloWorld
{
    //A Simple Program to display the words Hello World
    class Program
    {
        static void Main(string[] args)
        {
            //Code from Learn C# in one day and learn it well
            string userName = "";

            int userAge = 0;

            int currentYear = 0;

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            Console.Write("Please enter your age: ");

            userAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the current year: ");

            currentYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}.", userName, userAge, currentYear - userAge);

            Console.Read();

            /* //Commented out the initial logic for learning to work with the Console
            int userAge = 30;

            Console.WriteLine("My Age = " + userAge);

            Console.WriteLine("Hello World");

            Console.WriteLine("Hello");

            Console.WriteLine("How are you?");

            Console.WriteLine("Hello ");

            Console.WriteLine("How are you");

            Console.WriteLine("Hello\nWorld");

            Console.WriteLine("\\");

            Console.WriteLine("I am 5' 9\" tall");


            //Take a user's input
            string userInput = Console.ReadLine();
            
            Console.WriteLine(userInput);
             

            Console.Read();
            */
        }
    }
}
