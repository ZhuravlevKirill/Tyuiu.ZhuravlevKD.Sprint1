using Tyuiu.ZhuravlevKD.Sprint1.Task7.V1.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task7.V1.Test;

public class DataServiceTest
{
    [Test]
    public void Calculate()
    {
        DataService ds = new DataService();

        double result = ds.Calculate(1, 2, 1, 0);

        double expected = (2 + Math.Sqrt(2 * 2 + 4 * 1 * 1)) / (2 * 1)
                          - Math.Pow(1, 3) * 1
                          + Math.Pow(2, -2);

        Assert.That(result, Is.EqualTo(Math.Round(expected, 3)));
    }

    [Test]
    public void CalculateSecond()
    {
        DataService ds = new DataService();

        double result = ds.Calculate(2, 4, 1, 0);

        double expected = (4 + Math.Sqrt(4 * 4 + 4 * 2 * 1)) / (2 * 2)
                          - Math.Pow(2, 3) * 1
                          + Math.Pow(4, -2);

        Assert.That(result, Is.EqualTo(Math.Round(expected, 3)));
    }
}