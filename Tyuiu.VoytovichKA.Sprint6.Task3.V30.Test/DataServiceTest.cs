using Tyuiu.VoytovichKA.Sprint6.Task3.V30.Lib;
namespace Tyuiu.VoytovichKA.Sprint6.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            int[,] arr = {{ -9, -4, 17, -1, -20},
 {-19,  18,  -4,   2,  14},
 {-12,  16,  -2,   7,  18},
 {-16,  15,   4, -12, -13},
 {-15,  -4, -16,   1, -14} };
            int[,] res = ds.Calculate(arr);
            int[,] check = {{ -9, -4, 17, -1, -20},
 {-19, 18, -4, 2, 14},
 {-12, 16, -2, 7, 18},
 {-16, 15, 4, -12, -13},
 {-15, 0, 0, 1, 0} };
            CollectionAssert.AreEqual(check, res);
        }
    }
}
