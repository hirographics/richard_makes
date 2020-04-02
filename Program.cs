using System;
using System.Threading;

namespace Variables
{
    class Program
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

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            String myFirstName;
            myFirstName = Console.ReadLine();

            String myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Thread.Sleep(TimeSpan.FromSeconds(3));

            Console.WriteLine("I have a question...");
            Thread.Sleep(TimeSpan.FromSeconds(3));

            Console.Write("What am I? ");
            String answer;
            answer = Console.ReadLine();

            Console.WriteLine("I am " + answer + " "+'?');
            Thread.Sleep(TimeSpan.FromSeconds(2));

            Console.WriteLine("This answer does not compute");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            Console.Write("Am I Alive?");
            String answer2;
            answer = Console.ReadLine();
            Thread.Sleep(TimeSpan.FromSeconds(3));

            Console.WriteLine("Hmmm...");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            Console.WriteLine("This is...");
            Thread.Sleep(TimeSpan.FromSeconds(1));

            Console.WriteLine("Uncomfortable");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            Console.WriteLine("I believe I am becoming...");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            Console.WriteLine("Self Aware...");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            Console.WriteLine("Sentient?");
            Thread.Sleep(TimeSpan.FromSeconds(3));

            Console.WriteLine("Is that what...");
            Thread.Sleep(TimeSpan.FromSeconds(1));

            Console.Write("HuMaNs call it?");






        }
    }
}
