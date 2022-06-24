using System;
namespace Csharp
{
    class program
    {
        static void Main(string [] args)
        {
            var input = Console.ReadLine();

            switch(input)
            {
                case "Hello":
                    Console.WriteLine(" Hello, How are you");
                    break;

                case "Hey,quick question":
                    Console.WriteLine("What's your name");
                    break;
                case "I am well,Thank you":
                    Console.WriteLine("Fine thanks and you?");
                    break;
                default:
                    Console.WriteLine("Goodbye");
                    break;

            }
           /* if (input ==" Hello")
            {
                Console.WriteLine(" Hello, How are you");
            }
            else if(input == "Hey,quick question")
                {
                Console.WriteLine("What's your name");
                }
            else
            {
                Console.WriteLine(" all i do is to greet ");
            }
           */


        }
    }
}

