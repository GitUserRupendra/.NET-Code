using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
internal class All_Basics
    {
     static void Greet(string name)
 {
     Console.WriteLine("Good Morning " + name);
     
 }
  static float Average(int a, int b, int c)
 {
     float sum = a + b + c;
     return sum / 3;
 }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name :-");
            String name = Console.ReadLine();   
            Console.WriteLine("HeyHello"+name);
            Console.WriteLine("How many candies do you want?");
                String can = Console.ReadLine();
            Console.WriteLine("You will get 4 more candies : " +( Convert.ToInt32(can) + 4));

 // Run the  Greet Method:-
 Greet("Rupendra");

 // Run the Average Method:-
 Console.WriteLine("The average of 3 number is  "+Average(2,3,6));

 // OOPs - Classes and Objects
 Player rn = new Player();
 Console.WriteLine(rn.health);
 rn.setHealth(90);
 Console.WriteLine(rn.health);


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
