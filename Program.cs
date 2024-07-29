using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            long n = int.Parse(Console.ReadLine());
            long res = factorial(n);
            Console.WriteLine($"Factorial of a number is: {res}\n");

            Console.WriteLine("Fibonacci series");
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int result = fibonacci(num);
            Console.WriteLine($"Fibonacci of a number is: {result}\n");

            string s = "Hello World";
            string s_reverse = reversed(s);
            Console.WriteLine($"Reversed of a string {s} is {s_reverse}");

            Console.ReadLine();
        }

        //RECURSION
        //this will stack all the methods and then go until your if (stopping/base) condition is met, and then it'll stop, execute the stack, and then give you the result (and it'll do this however many times you need it to depending/specified based on your base condition)
        //if you don't putyour base condition first, then the recursion won't work because it can't be executed the part that you need it to be executed when you call it recursively because, there won't be any specificaion for what should be done for he recursive call!!
        // i.e. e.g. - you start the factorial at 5, and then go all the way to 1 and then that's the stack
        public static long factorial(long n)
        {
            if (n == 1)     //base aka. stopping condition
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);  //recursive aka. general case
            }
        }

        public static int fibonacci(int n)
        {
            if (n == 1 || n == 0)    //base aka. stopping condition
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2); //general formula for the fibonacci number sequence
                                                            //general aka. recursive case
            }
        }

        public static string reversed(string s) //s="Hello World" (for this case purposes)
        {
            if (s.Length == 0)
            {
                return s;
            }
            else
            {
                return reversed(s.Substring(1)) + s[0];
            }
        }

    }

    /*
     * lab hints: n>m,,,,,u go all the way down and stuff
     */



    /* STACKS BASICS
     * 
     * LIFO = Last in, First out
     * 
     * ***on top is where you push to!
     * 
     * stack = starts with the top method (the first one)
     *  and then you have the next and next and next, etc.
     *      top one is the first part of the stack, ok?
     */
}
