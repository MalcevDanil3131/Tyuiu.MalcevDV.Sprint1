using Tyuiu.MalcevDV.Sprint1.Task7.V21.Lib;
namespace Tyuiu.MalcevDV.Sprint1.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.2;
            double y = 0.8;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-27.118, res);
           
        }
    }
}
