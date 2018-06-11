using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 Test1 = new Form1(); //chce stworzyc obiekt  z oknem
            Assert.AreEqual(Test1, null); //chcialbym przetestowac czy klasa sie tworzy i inicjalizje
        }
    }
}