using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    class Program
    {
        static bool Prime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader str = new StreamReader(@"C:\Users\hp\Desktop\Test\text.txt");
            string s = str.ReadToEnd(); // string s = Console.ReadLine();
            int[] a = s.Split().Select(int.Parse).ToArray();
            List<int> l = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (Prime(a[i]) == true) l.Add(a[i]);
            }
            StreamWriter stw = new StreamWriter(@"C:\Users\hp\Desktop\Test\Output.txt");
            for (int i = 0; i < l.Count; i++)
            {
                stw.Write(l[i] + " ");

            }
            stw.Close();
            /* for(int i = 0; i < l.Count; i++)
             {
                 Console.Write(l[i] + " ");
             }*/


        }
    }
}
