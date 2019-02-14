using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "Newfile.txt";
            string fldr = @"C:\Users\hp\Desktop\Test\NewFolder";
            string newfldr = @"C:\Users\hp\Desktop\Test\Secondfldr";
            string path = Path.Combine(fldr, filename);
            string newpath = Path.Combine(newfldr, filename);
            File.Copy(path, newpath, true);
            File.Delete(path);
            Console.WriteLine("File is copied and original file is deleted succesfully");
        }
    }
}
