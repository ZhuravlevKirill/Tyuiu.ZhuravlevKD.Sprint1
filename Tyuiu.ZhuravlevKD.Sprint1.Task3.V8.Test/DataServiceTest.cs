using Tyuiu.ZhuravlevKD.Sprint1.Task3.V8.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task3.V8.Test;

public class DataServiceTest
{
    [Test]
    public void Calculate()
    {
        DataService ds = new DataService();

        ds.Calculate();

        Assert.That(ds.Income, Is.EqualTo(41.0958904109589).Within(0.000001));
        Assert.That(ds.Total, Is.EqualTo(2541.0958904109589).Within(0.000001));
    }
}