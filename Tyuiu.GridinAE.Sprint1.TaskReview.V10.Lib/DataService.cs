namespace Tyuiu.GridinAE.Sprint1.TaskReview.V10.Lib;
public class DataService
{
    public double Calc(double x) => Math.Round(2 * (1 / Math.Tan(3 * x)) - (Math.Log(Math.Cos(x)) / Math.Log(1 + x * x)), 3);
}
