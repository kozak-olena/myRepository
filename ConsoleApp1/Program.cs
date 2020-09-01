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

            var docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var dirName = $@"{docPath}\test";

            DirectoryInfo di = Directory.CreateDirectory(dirName);
            Console.WriteLine($"Full name: {di.FullName}, Name: {di.Name}, Parent: {di.Parent}");

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Directory exists");
            }
            else
            {
                Console.WriteLine("Directory does not exist");
            }


            Console.ReadKey();
        }
    }
}
