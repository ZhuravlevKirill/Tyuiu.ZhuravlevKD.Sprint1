using Tyuiu.ZhuravlevKD.Sprint1.Task1.V4.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task1.V4.Test;

public class DataServiceTest
{
    [Test]
    public void Calculate()
    {
        DataService ds = new DataService();

        double result = ds.Calculate(2, 4);

        Assert.That(result, Is.EqualTo(12));
    }
}