using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //Hangi classla çalışacaksam ona ait nesneyi oluşturuyorum öyle kullanıyorum..
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            // Classı kulllanabilmek için newlememiz lazım

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Yakup"; //burda set bloğu çalışır
            customer.LastName = "Aydoğan";
            customer.City = "Ankara";

            Customer customer2 = new Customer
            {
                Id = 2, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara"
            };

            Console.WriteLine(customer2.FirstName); //burda get bloğu çalışır
            Console.Read();
        }
    }
}

// Classlardaki amaç yapamak istediğimiz işlemleri gruplara ayırmak o grup üzerinden işlemlerimizi yapmak
//rahatlıklara o gruplara ulaşmak...
//Bir class içerisinde o classla ilgili methodları barındırır...