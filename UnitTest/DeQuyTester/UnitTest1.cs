using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bai1;
using Bai2;
using BaiTap3;
namespace DeQuyTester
{
    [TestClass]
    public class UnitTest1
    {
        private BaiTap3.Radix cs;
        [TestMethod]
        public void TestPower1()
        {
            double x, kq;
            int n;
            x = 2;
            n = 0;
            kq = 1;
            Assert.AreEqual(kq, DeQuy.Power(x, n));
        }
        [TestMethod]
        public void TestPower2()
        {
            double x, kq;
            int n;
            x = 2;
            n = 2;
            kq = 4;
            Assert.AreEqual(kq, DeQuy.Power(x, n));
        }
        [TestMethod]
        public void TestPower3()
        {
            double x, kq;
            int n;
            x = 2;
            n = -1;
            kq = 0.5;
            Assert.AreEqual(kq, DeQuy.Power(x, n));
        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                 @"D:\Visual Studio 2010\Projects\Bai1\Bai1\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            double x = double.Parse(TestContext.DataRow[0].ToString());
            int n = int.Parse(TestContext.DataRow[1].ToString());
            double kq = double.Parse(TestContext.DataRow[2].ToString());
            Assert.AreEqual(kq, DeQuy.Power(x, n));
        }
        //test bai 2

        Polynomial pol;
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PolynomialTrue()
        {
            int n;
            List<int> a;
            n = 3;
            a = new List<int>() { 1, 2, 3 };
            pol = new Polynomial(n, a);
        }

        [TestMethod]
        public void PolynomialFalse()
        {
            int n;
            List<int> a;
            n = 2;
            a = new List<int>() { 1, 2, 3 };
            pol = new Polynomial(n, a);
        }
        [TestMethod]
        public void CalTrue()
        {
            int n;
            List<int> a;
            n = 2;
            a = new List<int>() { 1, 2, 3 };
            pol = new Polynomial(n, a);
            double x = 1;
            int p = 6;
            Assert.AreEqual(p, pol.Cal(x));
        }
        //test bai3
        //test case 1: nhan so nguyen < 0, out: throw Incorrect value
        //test case 2: nhan so nguyen > 0, out: gan n = gia tri
        //test case 3: radix < 2 || radix > 16 => true , out:  Invalid Radix
        //test case 4: radix < 2 || radix > 16 => false, out: read data chuyen co so
        Radix coSo;
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RadixTrue()
        {
            int n = -5;
            coSo = new Radix(n);
        }
        [TestMethod]
        public void RadixFalse()
        {
            int n = 5;
            coSo = new Radix(n);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertDecimalTrue()
        {
            int rd = 1;
            cs = new BaiTap3.Radix(5);
            cs.ConvertDecimalToAnother(rd);
        }
        public TestContext TextRadix { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                 @"D:\Visual Studio 2010\Projects\Bai1\BaiTap3\DataChuyenCoSo.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void ConvertDecimalFalse()
        {
            int n = Int32.Parse(TestContext.DataRow[0].ToString());
            int k = Int32.Parse(TestContext.DataRow[1].ToString());
            String kq = TestContext.DataRow[2].ToString();
            cs = new BaiTap3.Radix(n);
            Assert.AreEqual(kq, cs.ConvertDecimalToAnother(k));

        }
    }
}
