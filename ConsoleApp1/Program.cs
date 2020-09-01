using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"D:\file";
            string [] dirs = Directory.GetDirectories(rootPath);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }



            Console.ReadKey();
        }
    }
}
