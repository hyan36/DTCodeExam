using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.CodeExam.UnitTest
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void TestPing()
        {
            var client = new NumberServices.NumberServicesClient();
            Assert.IsTrue(client.Ping());
        }

        [TestMethod]
        public void TestNumberConversion()
        {
            var client = new NumberServices.NumberServicesClient();

            var response = client.Spell(new NumberServices.Request()
            {
                Name = "Haihao Yan",
                Number = 0.01m
            });

            Assert.AreEqual("Haihao Yan", response.Name);
            Assert.AreEqual("zero point zero one ", response.Number);
        }
    }
}
