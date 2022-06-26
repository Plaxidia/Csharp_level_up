using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car =new Car();
            car.setTitle( " My first car");
            Console.WriteLine(car.getTitle);
        }

    }
    class Car
    {
        private string title;
        public string getTitle()
        {
            return title;
        }
        public void setTitle( string value)
        {
            title = value;
            
        }

    }
    
}
