using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstarctFactory
{
    class Client
    {
        private AbstractProductA AbstractProductA;
        private AbstractProductB AbstractProductB;
        public Client(AbstractFactory factory)
        {
            AbstractProductA = factory.CreateProductA();
            AbstractProductB = factory.CreateProductB();
        }
        public void Run()
        {
            AbstractProductB.Interact(AbstractProductA);
            AbstractProductA.Interact(AbstractProductB);
        }
    }
    class ProductA1 : AbstractProductA
    {
        public override void Interact(AbstractProductB b)
        {
            Console.WriteLine(this.GetType().Name + "interact with" + b.GetType().Name);
        }
    }
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + "interact with" + a.GetType().Name);
        }
    }
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
