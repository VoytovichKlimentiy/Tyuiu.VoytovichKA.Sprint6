using Tyuiu.VoytovichKA.Sprint6.Task0.V4.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            int x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(4.1,res);
        }
    }
}
