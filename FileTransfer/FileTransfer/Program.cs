using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("To move Config or XML files from downloads to trash please enter: \n 1 - Config \n 2 - XML");
            int userInput = Convert.ToInt32(Console.ReadLine());


            //string root = @"C:\Users\Tanner\Downloads";
            //var files = from file in
            //Directory.EnumerateFiles(root)
            //            select file;
            //Console.WriteLine("Files: {0}", files.Count<string>().ToString());
            //Console.WriteLine("List of Files");
            //foreach (var file in files)
            //{
            //    Console.WriteLine("{0}", file);
            //}


            Console.ReadLine();
        }
    }
}
