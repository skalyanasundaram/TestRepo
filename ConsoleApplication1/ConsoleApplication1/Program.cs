using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            WaitForKey();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello, World");
        }
        
        static void WaitForKey()
        {
            Console.ReadKey();
        }
    }
}
