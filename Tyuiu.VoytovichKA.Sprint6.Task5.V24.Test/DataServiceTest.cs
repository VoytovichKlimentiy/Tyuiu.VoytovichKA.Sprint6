using Tyuiu.VoytovichKA.Sprint6.Task5.V24.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task5.V24.Test
{
    [TestClass]
    public sealed class DataSeviceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "InputTest.txt");
            double[] res = ds.LoadFromDataFile(path);
            double[] check = { 0, 0, 0 };
            CollectionAssert.AreEqual(check, res);
        }
    }
}
