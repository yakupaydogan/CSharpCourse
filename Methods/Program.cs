using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods //PascalCase proje isimleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Add();
            var result = Add2(20);
            Console.WriteLine(result);
           
            int num1 = 20;
            int num2 = 100;
            var result2 = Add3(ref num1, num2);
            // num1'in referansını tut demek ref keywordu //num1'in değeri atanması gerek
            // ref'in alternatifi out'ur //num1'in tanımlanmasına gerek yoktur.. //num1'in methodun içinde set edilmiş olması gerek 
            Console.WriteLine(result2);
            Console.WriteLine(num1);

            Console.WriteLine(Multiply(1, 2));
            Console.WriteLine(Multiply(2, 3,7)); 
            */

            Console.WriteLine(Add4(1,4,5,6,9));

            Console.Read();
        }

        static void Add() // Bir işlemi yap, veritabanına kaydet...
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int num1, int num2 = 30) //Kullanıcıya bir şey vermeliyim.. //default değerler en sonda olur..
        {
            var result = num1 + num2;
            return result;
        }
        static int Add3(ref int num1, int num2)
        {
            num1 = 30;
            return num1 + num2;
        }

        static int Multiply (int num1,  int num2)
        {
            return num1 * num2;
        }
        static int Multiply(int num1, int num2, int num3) //overloading
        {
            return num1*num2*num3;
        }
        static int Add4 (int number,params int[] nums)
        {
            return nums.Sum();
        }
    }
}
