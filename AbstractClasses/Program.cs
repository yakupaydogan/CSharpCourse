using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses //AAbsractlarda classdır... interfacelerle virtual metodların birleşimi gibi düşünülebilir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataBase dataBase = new DataBase(); //ABSTRACT classlar newlenemez
            DataBase dataBase = new Oracle();
            dataBase.Add();
            dataBase.Remove();

            DataBase dataBase2 = new SqlServer();
            dataBase2.Add();
            dataBase2.Remove();

            Console.Read();
        }
    }

    abstract class DataBase
    {
        public void Add() //Tamamlanmış metot
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Remove(); //Tammalanmamış metod 
        //abstract metot aslında içi dolu olmayan virtual metottur..
    }
    class SqlServer : DataBase
    {
        public override void Remove()
        {
            Console.WriteLine("Removed by SQL Code");
        }
    }
    class Oracle : DataBase
    {
        public override void Remove()
        {
            Console.WriteLine("Removed by Oracle");
        }
    }
}
