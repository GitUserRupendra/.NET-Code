using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name :-");
            String name = Console.ReadLine();   
            Console.WriteLine("HeyHello"+name);
            Console.WriteLine("How many candies do you want?");
                String can = Console.ReadLine();
            Console.WriteLine("You will get 4 more candies : " +( Convert.ToInt32(can) + 4));

            Console.ReadLine();
            
            // This is comment,ignore it! 
            /* This is the multi line comment */
            //int number = 5; // integer variables
            //String s = "Name?";
            //Console.WriteLine("Hello World!");

            //Console.WriteLine("My jersey number is " + number);
            //Console.WriteLine("What is your " + s);

            //String scan = Console.ReadLine();
            //Console.WriteLine(scan);
            //Console.ReadLine();

            //Type Casting
            //There are two types of type casting
            //    1.Implicit Casting
            //    char to int to long to float to double

            //2.Explicit Casting

            //int x = (int)3.5;
            //double y = x;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.ReadLine();


            
        }
    }
}
