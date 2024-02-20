using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = { new Person { FirstName = "Yakup"}, new Student { FirstName = "Engin"}, new Customer { FirstName = "Kevser" } };
            foreach (Person person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer : Person // bir nesneyi bir kere inheritancelanır
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Departman { get; set; }
        }
    }
}
