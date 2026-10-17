using Tyuiu.VoytovichKA.Sprint6.Task4.V10.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            int startValue = 0, endValue = 2;
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(startValue, endValue);
            double[] check = { 1.83, 4.49, 6.78 };
            CollectionAssert.AreEqual(res, check);
        }
    }
}
