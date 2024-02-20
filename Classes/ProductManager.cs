using System;

namespace Classes
{
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }
}

// Classlardaki amaç yapamak istediğimiz işlemleri gruplara ayırmak o grup üzerinden işlemlerimizi yapmak
//rahatlıklara o gruplara ulaşmak...
//Bir class içerisinde o classla ilgili methodları barındırır...