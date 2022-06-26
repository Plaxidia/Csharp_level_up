using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
      class Program
        {
            static void Main(string[] args)
            {
          
            //Car.carName("Static van");
            Program programobj = new Program();
            programobj.Secretfunction();
            }
        
        void Secretfunction()
        {
            Console.WriteLine(" You found me ");
        }

    }
    public class Car
        {
            public static string carName(string carType)
            {
                return ($"This is a{carType} ");
            }

        }
    
}
