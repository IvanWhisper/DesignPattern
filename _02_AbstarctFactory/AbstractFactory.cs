using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstarctFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    public abstract class AbstractProductA
    {
        public abstract void Interact(AbstractProductB b);
    }
    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }
}
