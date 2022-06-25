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
            int numberfromfunction;
            numberfromfunction = myFunction();
            Console.WriteLine(" number returned by the function" + numberfromfunction);

                myFunction();
                //function is a block of statement to be executed
        }
    
       //static void myFunction()
       static int myFunction()
        {
            var myindex = 0;
            Console.WriteLine(myindex +=5);
            return myindex;
        }
    
    }
}
