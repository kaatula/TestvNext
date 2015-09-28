using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hello, Linux world");

            Console.ForegroundColor = color;
        }
    }
}
