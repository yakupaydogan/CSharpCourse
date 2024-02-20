using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[] { new Manager(), new Worker(), new Robot() };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            // SOLİD, Interface Segregation ->İnterfacelerin doğru planlanması...
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, ISalary, IEat
    {
        public void Eat() { }

        public void GetSalary() { }

        public void Work() { }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat() { }

        public void GetSalary() { }

        public void Work() { }

    }
    class Robot : IWorker
    {
        public void Work() { }
    }
}
