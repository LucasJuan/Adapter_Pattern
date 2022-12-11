using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adapter_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Tests
{
    [TestClass()]
    public class AdapterTests
    {
        [TestMethod()]
        public void AdapterTest()
        {
            Adaptee adaptee = new Adaptee();
            var target = new Adapter(adaptee);
            var result = target.GetRequest();
            Assert.AreEqual<string>(result, "This is 'Specific request.'");
           
        }
    }
}