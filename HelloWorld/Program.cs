using System;

namespace HelloWorld
{
    class Program
    {
        //All non-UI functionality moved into this class
        private static Greeter _greeter = new Greeter("Joan");

        private static void Main(string[] args)
        {
            Exercise_1_2();
            Exercise_1_4();
            Exercise_1_9(args);
            Exercise_1_10(args);

        }
        private static void Exercise_1_2()
        {
            Console.WriteLine(_greeter.HelloCSharpWorld());
        }

        private static void Exercise_1_4()
        {
            Console.WriteLine("Enter your name");
            string username = Console.ReadLine();
            Console.WriteLine(_greeter.WelcomeUserToCSharp(username));
        }

        private static void Exercise_1_9(string[] args)
        {
            if (args.Length == 0) { WriteInstructions(); return; }
            foreach (var arg in _greeter.GreetEverybodyAndMePersonally(args))
            {
                Console.WriteLine(arg);
            }
        }

        private static void Exercise_1_10(string[] names)
        {
            if (names.Length == 0) { WriteInstructions(); return; }
            _greeter.GreetEverybodyAndMePersonally(names);
        }
        private static void WriteInstructions()
        {
            Console.WriteLine("Hello World greeter program");
            Console.WriteLine("Usage: HelloWorld.exe [name 1] [name 2] ... [name n]");
            Console.WriteLine("Example use: HelloWorld.exe Ian Janet John Barbara");
        }
    }
}
