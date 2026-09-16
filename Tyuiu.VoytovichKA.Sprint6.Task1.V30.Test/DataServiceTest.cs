using Tyuiu.VoytovichKA.Sprint6.Task1.V30.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] check = {-32.26,
-27.5,
-22.8,
-17.95,
-12.97,
-9,
-0.31,
3.77,
8.57,
13.42,
18.28};
            CollectionAssert.AreEquivalent(res, check);
        }
    }
}
