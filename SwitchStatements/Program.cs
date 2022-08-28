using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine(); // evaluate to a string

           switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a tough subject!");
                    break;
                case "Science":
                    Console.WriteLine("Science is a tough subject!");
                    break;
                case "English":
                    Console.WriteLine("English is an interesting subject!");
                    break;
                case "History":
                    Console.WriteLine("History is an interesting subject!");
                    break;
                case "Chemistry":
                    Console.WriteLine("Chemistry is an imprtant class!");
                    break;
                default:
                    Console.WriteLine($"Oh wow! I haven't taken that subject before. {subject} sounds fun!");
                    break;
            }
        }
    }
}

