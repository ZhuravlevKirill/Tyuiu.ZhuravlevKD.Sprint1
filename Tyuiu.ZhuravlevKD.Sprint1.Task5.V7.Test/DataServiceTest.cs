using Tyuiu.ZhuravlevKD.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task5.V7.Test;

public class DataServiceTest
{
    [Test]
    public void AngleToHoursMinutes()
    {
        DataService ds = new DataService();

        Assert.That(ds.AngleToHoursMinutes(30), Is.EqualTo(1));
        Assert.That(ds.AngleToHoursMinutes(90), Is.EqualTo(3));
        Assert.That(ds.AngleToHoursMinutes(150), Is.EqualTo(5));
        Assert.That(ds.AngleToHoursMinutes(359), Is.EqualTo(11));
    }
}