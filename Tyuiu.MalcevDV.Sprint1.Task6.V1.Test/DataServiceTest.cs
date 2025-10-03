using Tyuiu.MalcevDV.Sprint1.Task6.V1.Lib;
namespace Tyuiu.MalcevDV.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string symbol = "g";
            string expected = "103";
            var res = ds.SymbolCode(symbol);
            Assert.AreEqual(expected, res);
        }
    }
}
