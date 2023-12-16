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

            string dest = "C:\$Recycle.Bin";
            string[] files = Directory.GetFiles(@"C:\Users\Tanner\Downloads", "*.mp4", SearchOption.AllDirectories);
            foreach(var item in files)
            {
                Console.WriteLine(item.ToString());
            }



            //string root = @"c:\users\tanner\downloads";
            //var files = from file in
            //directory.enumeratefiles(root)
            //            select file;
            //console.writeline("files: {0}", files.count<string>().tostring());
            //console.writeline("list of files");
            //foreach (var file in files)
            //{
            //    console.writeline("{0}", file);
            //}


            Console.ReadLine();
        }
    }
}
