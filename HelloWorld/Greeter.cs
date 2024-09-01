using System.Collections.Generic;

namespace HelloWorld
{
    /// <summary>
    /// Class which generates greetings
    /// </summary>
    public class Greeter
    {
        public string MyOwnName { get; set; }
        public Greeter(string myOwnName = null)
        {
            MyOwnName = myOwnName;
        }
        public string HelloCSharpWorld()
        {
            return "Hello C# World!";
        }

        public string WelcomeUserToCSharp(string name)
        {
            return $"Hello {name}, and welcome to C#";
        }

        public string[] GreetEverybody(string[] names)
        {
            string[] greetings = new string[names.Length];

            for (int nameCounter = 0; nameCounter < names.Length; nameCounter++)
            {
                    greetings[nameCounter] = $"Hello, {names[nameCounter]}";
            }
            return greetings;
        }

        public string[] GreetEverybodyAndMePersonally(string[] names)
        {
            string[] greetings = new string[names.Length];

            for (int nameCounter = 0; nameCounter < names.Length; nameCounter++)
            {
                string name = names[nameCounter];
                if (name == MyOwnName)
                {
                    greetings[nameCounter] = $"Welcome back, {name}";
                }
                else
                {
                    greetings[nameCounter] = $"Hello, {name}";
                }
            }
            return greetings;            
        }

        public string[] GreetEverybodyAndMePersonallyConciseCode(string[] names)
        {
            List<string> greetings = new List<string>();

            foreach (var name in names)
            {
                //Ternary operator:
                //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
                greetings.Add(name == MyOwnName ? $"Welcome back {name}" : $"Hello, {name}");
            }
            return greetings.ToArray();
        }
    }
}