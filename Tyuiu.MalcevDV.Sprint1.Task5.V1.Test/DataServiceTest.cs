using Tyuiu.MalcevDV.Sprint1.Task5.V1.Lib;
namespace Tyuiu.MalcevDV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 3.5;
            double y1 = 2.7;
            double x2 = 8.1;
            double y2 = 6.3;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(6, res);
        }
    }
}
