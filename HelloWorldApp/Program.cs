using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw = new HelloWorld();
            Console.WriteLine(hw.SayHelloWorld());
        }
    }
}
