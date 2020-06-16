using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedPrac
{
    class Parent
    {
        public virtual void Method() { }
    }

    class Child : Parent
    {
        public sealed override void Method() { }
    }

    class GrandChild : Child
    {
        // public override void Method() { }
    }

    abstract class Parent2
    {
        public abstract void Method();
    }

    class Child2 : Parent2
    {
        public override void Method()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
    