using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static bool polindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C: \Users\hp\Desktop\Testing\text.txt");
            string s = sr.ReadToEnd();
            sr.Close();
            if (polindrome(s)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
