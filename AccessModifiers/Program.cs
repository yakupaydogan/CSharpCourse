using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
       public int id;
    }
    class Employee
    {
        public void Save()
        {
            Customer customer = new Customer();
            customer.id = 1;
        }
    }
    class Course
    {
        public string Name { get; set; }
    }
}
//private erişim bildirgeci sadece tanımlandığı blokta kullanılablir..,
//protected privateden farkı inheritance edildiği sınıflardada kullanılabilir...
// internal classların default erişim bildirgeci  --- Aynı Asembly içerisinde referans ihitiyacı olmadan kullanabilrisiniz.  
// public farkı bir asemblydende ulaşabilmek için kullanılır.referans verildiği zaman...