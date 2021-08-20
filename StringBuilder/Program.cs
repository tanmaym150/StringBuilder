using System;
using System.Text;

namespace StringBuilderAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Append
            //add a string value to the end of the string
            StringBuilder sb = new StringBuilder("hello ",20);
            sb.Append("interns");
            Console.WriteLine(sb);//hello interns

            //AppendFormat
            StringBuilder sb1 = new StringBuilder("Your total amount is:");
            sb1.AppendFormat("{0:C} ", 70);
            Console.WriteLine(sb1);//Your total amount is:? 70.00

            //Insert
            //used to insert a string at a given position
            StringBuilder sb2 = new StringBuilder("hello ", 20);
            sb2.Insert(6, "interns");
            Console.WriteLine(sb2);//hello interns

            //Remove
            //used to remove specefied no of characters
            StringBuilder sb3 = new StringBuilder("hello people", 20);
            sb3.Remove(6, 6);
            Console.WriteLine(sb3);//hello

            //Replace
            //used to replace the characters
            sb3.Replace("hello", "hola");
            Console.WriteLine(sb3);//hola






        }
    }
}
