using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biologie;

namespace BioTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           Assert.IsTrue( Biologie.FunctiiPublice.adaugaClasa(1, "Clasa 10-a"));
        }
    }
}
