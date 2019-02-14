using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        public static void Arr(int[] a)                 //method to make new array
        {
            int[] d = new int[2 * a.Length];            //new array with doubled lengh of given array
            int j = 0;
            for (int i = 0; i < d.Length - 1; i += 2)
            {
                d[i] = a[j];                            //cycle to make elements of array
                d[i + 1] = a[j];
                j++;
            }
            for (int i = 0; i < d.Length; i++)
            {                                            //cycle to write elements of array in console
                Console.Write(d[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());      //size of array converted to integer from entered string
            int[] a = new int[n];                       //new array with given size
            string s = Console.ReadLine();
            a = s.Split(' ').Select(int.Parse).ToArray();   //making array from elements firstly splited by space from entered string and after converted to integer type
            Arr(a);                                     //call of method
        }
    }
}
