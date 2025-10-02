using Tyuiu.MalcevDV.Sprint1.Task1.V16.Lib;
namespace Tyuiu.MalcevDV.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            int x = 1;
            var res = ds.CalculatePerimetrCircle(x);
            Assert.AreEqual(6.283, res);
        }
    }
}
