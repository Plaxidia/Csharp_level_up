using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program :Animal
    {
        static void Main(string[] args)
        {

        }

        string Animal.getName()
        {
            return "crazy awsome animal name";
        }
    }
    interface Animal
    {
        // can not run the implementation of a fucntion inside the interface.
        // everything(methods) are  abstract
        //it is a good way of organising the code
        string getName( );
    }
}
