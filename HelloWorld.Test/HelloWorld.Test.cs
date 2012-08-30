using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using HelloWorldApp;

namespace ConsoleApplication.Test
{
    [TestFixture]
	public class HelloWorldTest
	{
        [Test]
        public void SayHelloWorld_Expect_HelloWorld()
        {
            var hw = new HelloWorld();

            var output = hw.SayHelloWorld();

            Assert.AreEqual("HelloWorld", output);
        }
	}
}
