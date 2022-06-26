using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{ //access modifiers allows to set specific restrictions on specific types
    public class Program
    {
        static void Main(string[] args)
        {
            Van van = new Van();
            
        }

    }
    class Vehicle
    {

        private int a = 0;//accessed within the block,can not be inherited
        protected int b = 1;//only accessible where the class is inherited
        public int c = 2;//can be accessed globaly
    }
    class Van :Vehicle
    {
        void vmain()
        {
           Van van =new Van();  
          
        }
    }
}
