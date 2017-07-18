using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculator iphone = new Calculator();
            int result = iphone.Add(2, 3);
            Console.WriteLine(result);
        }
    }
}