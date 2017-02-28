using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five_question
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Your name is " + input);
            Console.WriteLine("How old are you?");
            string input1 = Console.ReadLine();
            Console.WriteLine("Your age is " + input1);
            Console.WriteLine("What is your state of origin?");
            string input2 = Console.ReadLine();
            Console.WriteLine("You are from " + input2);
            Console.WriteLine("What is your favourite food?");
            string input3 = Console.ReadLine();
            Console.WriteLine("Your favourite food is " + input3);
            Console.WriteLine("What is your favourite colour?");
            string input4 = Console.ReadLine();
            Console.WriteLine("Your favourite colour is " + input4);
            Console.WriteLine("#----------------------------------#");
            Console.WriteLine("SUMMARY");
            Console.WriteLine("Your Name is " + input);
            Console.WriteLine("Your are " + input1);
            Console.WriteLine("You are from " + input2);
            Console.WriteLine("Your favourite food is " + input3);
            Console.WriteLine("Your favourite colour is " + input4);
            Console.WriteLine("****THANK YOU****");
            Console.ReadLine();
        }
    }
}
