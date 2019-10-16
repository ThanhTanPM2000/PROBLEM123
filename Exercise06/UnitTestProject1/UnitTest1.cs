using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise06;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            QuanLy acc = new QuanLy(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(QuanLy));
            Assert.AreEqual(200000, acc.Balance());
        }

        [TestMethod]
        public void TestWithdraw()
        {
            QuanLy acc = new QuanLy(200000);
            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(QuanLy));
            Assert.AreEqual(400000, acc.WithDraw(200000));
        }

        [TestMethod]
        public void TestWithDeposit()
        {
            QuanLy acc = new QuanLy(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(QuanLy));
            Assert.AreEqual(100000, acc.Deposit(100000));
        }


    }
}
