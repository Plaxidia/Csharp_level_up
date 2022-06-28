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
            int []  arr = { 1, 2, 3 ,10,14,0 };
            //Console.WriteLine(arr[1]);//2
            int sum = arr[2] + arr[1];//5
            Console.WriteLine(sum);
            for (int i =0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            foreach(var num in arr)
            {
                Console.WriteLine("for each loop");
                Console.WriteLine(num);
            }
        }
    }
}
