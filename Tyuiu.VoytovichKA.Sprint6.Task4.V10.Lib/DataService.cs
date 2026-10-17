using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VoytovichKA.Sprint6.Task4.V10.Lib
{
    public class DataService : ISprint6Task4V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            double y;
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (5 * x + 2.5) / (Math.Sin(x) + 3) + 2 * x + Math.Cos(x);
                if (double.IsNaN(y)) y = 0;
                else y = Math.Round(y, 2);
                res[i] = y;
                i++;
            }
            return res;
        }
    }
}
