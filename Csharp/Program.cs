using System;
namespace Csharp
{
    class program
    {
        static void Main(string [] args)
        {
            /*
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
            if (input ==" Hello")
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
           
            //while loop
            var index = 0;
            while (index <10)
            {
                Console.WriteLine(index);
                index++;
            }
            */
            //do while loop,it fires or checks the block and then execute the condition
            var index = 0;
            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index < 10);
            
        }
    }
}

