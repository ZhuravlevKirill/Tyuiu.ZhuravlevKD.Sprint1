using Tyuiu.ZhuravlevKD.Sprint1.Task2.V27.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task2.V27.Test;

public class DataServiceTest
{
    [Test]
    public void Calculate()
    {
        DataService ds = new DataService();

        int result = ds.Calculate(5);

        Assert.That(result, Is.EqualTo(20));
    }
}