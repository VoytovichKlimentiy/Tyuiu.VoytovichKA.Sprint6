using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VoytovichKA.Sprint6.Task2.V22.Lib
{
    public class DataService : ISprint6Task2V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double temp;
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 * x - 1 == 0)
                {
                    res[x] = 0;
                    continue;
                }
                temp = (2 * x - 3) / (Math.Cos(x) + x) + 5;
                res[count] = Math.Round(temp, 2);
                count++;
            }
            return res;
        }
    }
}
