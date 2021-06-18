using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Tests
    {

        Program pg;

        [SetUp]
        public void Setup()
        {
            pg = new Program();
        }

        [Test]
        public void Test1()
        {
            pg.doSomething();
            Assert.Pass();
        }

    }
}
