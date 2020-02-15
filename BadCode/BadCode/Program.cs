using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCode
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true){Console.WriteLine("Please write numbers to add, like this: x,y"); string userTextNumberStuff = Console.ReadLine(); if (userTextNumberStuff == "quit"){Environment.Exit(0);}else{string[] userTextNumberStringArray = userTextNumberStuff.Split(',');int userTextNumber1 = Convert.ToInt32(userTextNumberStringArray[0]);int userSecondNumber = Convert.ToInt32(userTextNumberStringArray[1]);int addition = userTextNumber1 + userSecondNumber; if (userTextNumber1 == userSecondNumber) { Console.WriteLine((userTextNumber1 + userSecondNumber) * 3); } else { Console.WriteLine(addition); } }

            }

        }
    }
}
