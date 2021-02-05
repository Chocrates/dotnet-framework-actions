using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Add add = new Add();
            Console.WriteLine(add.add(1, 3));
            Console.WriteLine("Test");
        }
    }
}
