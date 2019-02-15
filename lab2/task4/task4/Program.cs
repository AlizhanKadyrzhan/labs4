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
            string path = @"C:\Users\hp\Desktop\Test\NewFolder\" + filename;
            string path1 = @"C:\Users\hp\Desktop\Test\Secondfldr\" + filename;
            StreamWriter sw = new StreamWriter(path);
            sw.Close();
            // string path = Path.Combine(fldr, filename);
            // string newpath = Path.Combine(newfldr, filename);
            File.Copy(path, path1);
            File.Delete(path);
            Console.WriteLine("File is copied and original file is deleted succesfully");
        }
    }
}
