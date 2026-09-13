using Tyuiu.ZhuravlevKD.Sprint1.Task4.V30.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task4.V30.Test;

public class DataServiceTest
{
    [Test]
    public void Calculate()
    {
        DataService ds = new DataService();

        double result = ds.Calculate(2, 1);

        double expected = (2 + Math.Pow(1, 3)) / (Math.Pow(Math.E, 2) - 1);

        Assert.That(result, Is.EqualTo(expected).Within(0.000001));
    }
}