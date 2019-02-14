using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static prime(int k)
        {
            if (k < 2) return false;
            for (int i = 2; i < k; i++)
            {
                if (k / i == 0) return false;
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int res = 0;
            string[] num = Console.ReadLine().Split;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(num(i)); 
            }
            for (int i = 0; i < n; i++)
            {
                if (prime(arr[i]) == true) res++;  
            }
            Console.Writeline(res);
            for(int i = 0; i < n; i++)
            {
                if (prime(arr[i]) == true) Console.Write(arr[i] + " ");
            }

        }
    }
}
