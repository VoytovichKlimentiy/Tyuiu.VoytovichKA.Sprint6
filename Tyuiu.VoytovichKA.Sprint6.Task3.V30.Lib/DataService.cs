using tyuiu.cources.programming.interfaces.Sprint6;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.VoytovichKA.Sprint6.Task3.V30.Lib
{
    public class DataService : ISprint6Task3V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                    if (matrix[4, i] % 2 == 0) matrix[4, i] = 0;
            }
            return matrix;
        }
    }
}
