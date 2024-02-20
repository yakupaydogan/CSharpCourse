using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            int number1 = 2_147_483_647; // 32-bit
            long number2 = 9_223_372_036_854_775_807; //64-bit
            short number3 = 32_767; //16-bit 
            byte number4 = 255; //8-bit

            bool condition = false; 

            char character = 'A'; //string bir char dizisidir...

            double number5 = 15.6;
            decimal number6 = 10.6m;

            var number7 = 10;


            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Charcter is {0}", (int)character); //ASII karşılığı

            Console.Read();
        }
    }
    enum Days
    {
        Mondays, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        //Magic string yapmamk için...
    }
}
