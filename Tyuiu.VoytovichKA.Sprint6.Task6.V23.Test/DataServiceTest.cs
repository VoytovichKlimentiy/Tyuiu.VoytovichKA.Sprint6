using Tyuiu.VoytovichKA.Sprint6.Task6.V23.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask6V23.txt");
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual("ainUD vngvDXy iKDOjtfsPmw LTJkHL", res);
        }
    }
}
