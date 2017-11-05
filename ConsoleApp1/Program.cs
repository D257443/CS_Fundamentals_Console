using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10000; i++)
            {
                Process.Start("https://www.youtube.com/watch?v=IML7yFoCyUs");
            }
        }
    }
}
