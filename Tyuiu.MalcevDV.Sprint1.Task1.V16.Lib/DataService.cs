using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalcevDV.Sprint1.Task1.V16.Lib
{
    public class DataService : ISprint1Task2V16
    {
        public double CalculatePerimetrCircle(int value)
        {
            double perimeter = 2 * Math.PI * value;
            double roundedPerimeter = Math.Round(perimeter, 3);
            return roundedPerimeter;
        }
    }
}
