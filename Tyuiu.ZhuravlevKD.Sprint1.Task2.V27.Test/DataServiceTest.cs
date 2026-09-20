using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZhuravlevKD.Sprint1.Task2.V27.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task2.V27.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void Calculate()
    {
        DataService ds = new DataService();

        int a = 5;

        int result = ds.Calculate(a);

        Assert.AreEqual(20, result);
    }
}