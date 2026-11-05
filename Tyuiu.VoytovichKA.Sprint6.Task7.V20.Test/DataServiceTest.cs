using Tyuiu.VoytovichKA.Sprint6.Task7.V20.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            string inpath = Path.Combine(Directory.GetCurrentDirectory(), "TestFile.csv");
            int[,] res = ds.GetMatrix(inpath);
            int[,] check = {
                { -1, -3, 111, 3, -12}, 
                { -5, 18, 111, -19, -7}, 
                { 4, 17, 111, -18, 0 }, 
            }
            ;
            CollectionAssert.AreEqual(res, check);
        }
    }
}
