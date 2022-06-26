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
            Car sportsCarobject = new Car();
            Car van= new Car();

            var carName = sportsCarobject.carName(" sports car");
            var vanName = van.carName(" Van");

            Console.WriteLine(carName);
            Console.WriteLine(vanName); 
        }

    }
    public class Car
    {
       public string carName(string carType)
        {
            return ($"This is a{carType} ");
        }

    }
}
