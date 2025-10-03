using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalcevDV.Sprint1.Task7.V21.Lib
{
    public class DataService : ISprint1Task7V21
    {
        public double Calculate(double x, double y)
        {
            double summand1 = Math.Pow(y, x) / ((Math.Cos(x) - (x / 3)));
            double summand2 = ((Math.Sin(x*x) + Math.Cos(y))*Math.Tan(x*y)) / (Math.Cos(x) - Math.Sin(y));
            return Math.Round(summand1 + summand2, 3);
        }
    }
}
