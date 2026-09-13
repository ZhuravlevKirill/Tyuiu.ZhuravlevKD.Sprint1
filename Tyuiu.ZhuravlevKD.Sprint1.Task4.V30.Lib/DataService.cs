using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task4.V30.Lib;

public class DataService : ISprint1Task4V30
{
    public double Calculate(double x, double y)
    {
        return (x + Math.Pow(y, 3)) / (Math.Pow(Math.E, 2) - y);
    }
}