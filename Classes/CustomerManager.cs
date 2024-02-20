using System;

namespace Classes
{
    class CustomerManager //Manager katmanlı mimamride iş kodlarıma karşılık gelir..
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }
}

// Classlardaki amaç yapamak istediğimiz işlemleri gruplara ayırmak o grup üzerinden işlemlerimizi yapmak
//rahatlıklara o gruplara ulaşmak...
//Bir class içerisinde o classla ilgili methodları barındırır...