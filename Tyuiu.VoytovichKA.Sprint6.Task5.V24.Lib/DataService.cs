using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VoytovichKA.Sprint6.Task5.V24.Lib
{
    public class DataService : ISprint6Task5V24
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.ReadLine() != null)
                {
                    len++;
                }
            }

            double[] res = new double[len];
            int count = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    res[count] = Convert.ToDouble(line);
                    count++;
                }
            }
            res = res.Where(val => val == 0).ToArray();

            return res;
        }
    }
}
