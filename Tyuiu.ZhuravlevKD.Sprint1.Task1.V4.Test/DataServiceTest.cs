using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZhuravlevKD.Sprint1.Task1.V4.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task1.V4.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void Calculate()
    {
        DataService ds = new DataService();

        double x = 2;
        double y = 4;

        double result = ds.Calculate(x, y);

        Assert.AreEqual(12, result);
    }
}