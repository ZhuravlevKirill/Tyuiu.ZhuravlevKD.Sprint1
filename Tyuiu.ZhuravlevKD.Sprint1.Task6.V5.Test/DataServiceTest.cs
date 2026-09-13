using Tyuiu.ZhuravlevKD.Sprint1.Task6.V5.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task6.V5.Test;

public class DataServiceTest
{
    [Test]
    public void WorkWithText()
    {
        DataService ds = new DataService();

        string result = ds.WorkWithText("казак дом шалаш");

        Assert.That(result, Is.EqualTo("казак шалаш"));
    }

    [Test]
    public void WorkWithText_DifferentCase()
    {
        DataService ds = new DataService();

        string result = ds.WorkWithText("Казак Шалаш машина");

        Assert.That(result, Is.EqualTo("Казак Шалаш"));
    }

    [Test]
    public void WorkWithText_NoPalindromes()
    {
        DataService ds = new DataService();

        string result = ds.WorkWithText("дом машина компьютер");

        Assert.That(result, Is.EqualTo(""));
    }
}