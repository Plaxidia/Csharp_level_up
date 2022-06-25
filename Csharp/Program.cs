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
           
            //do while loop,it fires or checks the block and then execute the condition
            var index = 0;
            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index < 10);
           
            // for loop
            for (var index =0; index <10; index++)
            {
                Console.WriteLine(index);
            }
             
            //strings 
            var index = 0;
            var Name = " Hove";
            while (index < 10)
            {
                Console.WriteLine(" they call me " + Name + "number "+ index);
                index++;
            }
            */

            //lets practice
            //personal Greeter
            //1.must allow the user to play as much as they want
            //2. must greet  differently depending on the age
            //3.must tell the user how many years untill the reach 100 years old


            //var input = Console.ReadLine();
            bool isRunning = true;
            while (isRunning)
            {
                string name;
                int age;

                Console.WriteLine("welcome! whats your name");
                name = Console.ReadLine();

                Console.WriteLine($"Hello { name}, What is your age?");
                var myage = Console.ReadLine();
                age = Convert.ToInt32(myage);

                switch(age)
                {
                    case var theAge when theAge < 10:
                        {
                                Console.WriteLine("Hello Baby,you are too young to play this game.");
                                 break;
                        }
                    case var theAge when theAge < 18 && theAge >= 10:
                        {
                            Console.WriteLine(" You are too young to play this game ,go home.");
                            break;
                        }
                    case var theAge when theAge < 70 && theAge >= 18:
                        {
                            Console.WriteLine(" Thanks for entering your information ,enjoy the game.");
                            break;
                        }
                    case var theAge when theAge < 100 && theAge >= 70:
                        {
                            Console.WriteLine(" Thanks for entering your information ,but you are too old for the game game.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine(" Thanks ,Not an usual age.");
                            break;
                        }
                }
                Console.WriteLine($"You are {100 -age} years until you are 100.");
                Console.WriteLine(" Do you want to run again");
                string isRunningResponse = Console.ReadLine();
                if (isRunningResponse == "no")
                {
                    isRunning = false;
                }
            }
        }
    }
}

