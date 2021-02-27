using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspdotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "John Doe";
            s1.Score = 8;
            Console.WriteLine("type the password");
            string input = Console.ReadLine();
            if (s1.check(input))
            {
                Console.WriteLine("your in");
            }
            else
            {
                Console.WriteLine("wrong password");
            }
        }
    }

    class Student
    {
        public string Name;
        public int Score;
        private string passcode = ".6`3pa/$n9e]r=B[RqUq";
        public bool check(string pass)
        {
            return passcode == pass;
        }
    }
}
