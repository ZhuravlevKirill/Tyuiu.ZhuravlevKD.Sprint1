using System;
using NUnit.Framework;

using Tyuiu.ZhuravlevKD.Sprint1.Task0.V0.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task0.V0.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}