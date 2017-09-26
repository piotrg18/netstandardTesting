using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace TestLibrary
{
    public class TestLibrary
    {
        private WindsorContainer _container;

        public TestLibrary()
        {
            _container = new WindsorContainer();
            _container.Register(Component.For<ClassImpl>());
        }

        public T Resolve<T>(string dummy)  where T: class
        {
            Console.WriteLine("Resolve: " + dummy);
            return _container.Resolve<T>();
        }

        public Bag<int> Create() => new Bag<int>() { 1, 2, 3 };
    }
}
