using Tyuiu.ZhuravlevKD.Sprint1.Task0.V5.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task0.V5.Test;

public class DataServiceTest

{
    [Test]
    public void Calculate()
    {
        DataService ds = new DataService();
        double result = ds.Calculate();
        Assert.AreEqual(12, result);
    }
}