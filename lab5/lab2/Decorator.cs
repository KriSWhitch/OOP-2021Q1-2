using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    abstract class Cake
    {
        public Cake(string n)
        {
            this.Name = n;
        }

        public string Name { get; protected set; }
        public abstract int GetCost();
    }

    class AppleCake : Cake
    {
        public AppleCake() : base("Яблочный пирог")
        { }
        public override int GetCost()
        {
            return 6;
        }
    }

    class ChocolateCake : Cake
    {
        public ChocolateCake()
            : base("Шоколадный пирог")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }

    abstract class CakeDecorator : Cake
    {
        protected Cake Cake;
        public CakeDecorator(string n, Cake Cake) : base(n)
        {
            this.Cake = Cake;
        }
    }

    class DeliveryCake : CakeDecorator
    {
        public DeliveryCake(Cake p)
            : base(p.Name + ", с доставкой", p)
        { }

        public override int GetCost()
        {
            return Cake.GetCost() + 5;
        }
    }

    class ThereCake : CakeDecorator
    {
        public ThereCake(Cake p)
            : base(p.Name + ", есть на месте", p)
        { }

        public override int GetCost()
        {
            return Cake.GetCost() - 1;
        }
    }

}
