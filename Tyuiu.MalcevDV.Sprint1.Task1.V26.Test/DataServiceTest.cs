using Tyuiu.MalcevDV.Sprint1.Task1.V26.Lib;
namespace Tyuiu.MalcevDV.Sprint1.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.25, res);

        }
    }
}
