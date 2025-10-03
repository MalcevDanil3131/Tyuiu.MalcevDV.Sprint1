using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalcevDV.Sprint1.Task4.V14.Lib
{
    public class DataService : ISprint1Task4V14
    {
        public double Calculate(double x, double y)
        {
           double result = (Math.Sqrt(7 + Math.Abs(x - y))) / (3 * x * y * y);
            return Math.Round(result, 3);
        }
    }
}
