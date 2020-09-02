using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String userName = getName();
            Console.WriteLine("Hello, "+ userName);
            Console.ReadLine();
        }
        static string getName()
        {
            Console.WriteLine("hey! what's your name?");
            string name = Console.ReadLine();
            return name;
        }
    }
}
