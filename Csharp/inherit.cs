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
            Vehicle vehicle =new Vehicle();
            Van van = new Van();
            Car car = new Car();

            car.model = " BMW";
            //Console.WriteLine(Car);


        }

    }
   
   
    class Vehicle
    {
        public bool haswheels = true;
        public string Make;
        public string model;
    }
    class Van:Vehicle
    {
        public int seatRaws;
        public bool adjustableseats;
           
    }
    public class Car:Vehicle
    {
        public bool Stearing;
    }
}
