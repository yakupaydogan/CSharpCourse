using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            ///IPerson person = new Customer(); // interface ve abstractları (soyut nesneleri) kendi başına newlenmez..
            //Demo();

            ICustomerDal[] customerDals =  {new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal()};
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadKey();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Yakup",
                LastName = "Aydoğan",
                Address = "Ankara"
            };

            Employee employee = new Employee
            {
                Id = 2,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Departmant = "Computer Sciences"
            };

            personManager.Add(customer);
            //personManager.Add(new Customer { Id = 1, FirstName = "Yakup", LastName = "Aydoğan", Address = "Ankara" });
        }

        interface IPerson // soyut nesne  
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson //somut nesne
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class Employee : IPerson // implemente etmek
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departnmant { get; set; }
        }

        class PersonManager // iş katmanı sınıflarımız için kullanırız..
        {

            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
//Uygulamanın bağımlılıklarını minimize etmek i.in interfaceler kullanırız...