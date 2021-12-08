﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar.Foo
{
    public class Foo
    {
        public int GetInt()
        {
            return 0;
        }

        public void sum(int param1, double param2)
        { }

        public Foo(int param)
        { }

        public Foo(int p1, double p2)
        { }

        public Foo()
        { }
    }
}

namespace FooBar.Bar
{
    public interface INumber
    {
        INumber Object { get; set; }
    }

    public class Bar
    {
        public INumber GetInterface()
        {
            return null;
        }

        public void SetInterface(INumber myBoolean)
        { }

        public Bar(INumber myInt)
        { }

        protected INumber GetProtectedInterface()
        {
            return null;
        }
    }
}
