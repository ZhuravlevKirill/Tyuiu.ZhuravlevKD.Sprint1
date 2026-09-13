using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task3.V8.Lib;

public class DataService : ISprint1Task3V8
{
    public double Income { get; private set; }
    public double Total { get; private set; }

    public void Calculate()
    {
        double deposit = 2500;
        int days = 30;
        double percent = 20;

        Income = deposit * percent / 100 * days / 365;
        Total = deposit + Income;
    }
}