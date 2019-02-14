using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    class Student                               //new class of name Student
        {
            public string name;
            public string id;                       //variables of class
            public int year;

            public Student(string name1, string id1) //constructor with two parametrs
            {
                name = name1;
                id = id1;
                year = 0;
            }

            public string Accessname()              //method to access name of object
            {
                return name;
            }

            public string Accessid()                //method to access id of student
            {
                return id;
            }
            public void Show(Student a)             //method to show informations about student
            {
                year++;
                Console.WriteLine(a.Accessname() + " " + a.Accessid() + " " + year);
            }

        
        class Program
        {
            static void Main(string[] args)
            {
                string n = Console.ReadLine();
                string i = Console.ReadLine();
                Student a = new Student(n, i);      //new object of class
                Student b = new Student("Mukhambet", "18BD181818");
                a.Show(a);
                b.Show(b);
                a.Show(a);                          //call of function

            }
        }
       
    }
}
