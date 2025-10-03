using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalcevDV.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "0";

            return ((int)value[0]).ToString();
        }
    }
}
 