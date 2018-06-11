using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Tests
{
    [TestClass()]
    public class PodliczanieTests
    {
        [TestMethod()]
        public void dodawanieTest()
        {
            string sol = Podliczanie.mnozenie(5, 5);
            Assert.AreEqual("25", sol);
        }
    }
}