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
        public override void Method() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
    