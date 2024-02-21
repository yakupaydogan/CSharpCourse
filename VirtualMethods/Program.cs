using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MySql mySql = new MySql();
            mySql.Add();

            //İnterfacelerde amacımız imzaları oluşturmak ve onu implemente eden sınıfların bütün imzaları kullanılmasını sağlamak
            // inheritance olarakta kullanılabilir
        }
    }
    class DataBase
    {
        public virtual void Add() { Console.WriteLine("Added by default"); } // inheritancelarda yapılabilir, interfacelerde yapılamaz
        public virtual void Remove() { Console.WriteLine("Removed by default"); }
    }
    class SqlServer : DataBase
    {
        //Sql servera özgü metotlar varsa buraya
        // Temel operasyonlar var isteyen istediği operasyonları ezebilir...
        public override void Add()
        {
            Console.WriteLine("Added by SQL Code");
            //base.Add();
        }

    }
    class MySql : DataBase
    {
        // MySqle özgü metotlar varsa buraya
    }

}
