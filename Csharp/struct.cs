using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{   //struct are value types
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "My first car";
            Console.ReadLine();
            Console.WriteLine(car.Make);


        }
    }
    struct Car
    {
        public string Make { get; set; }
        public string Model { get; set; }   
    }
}
