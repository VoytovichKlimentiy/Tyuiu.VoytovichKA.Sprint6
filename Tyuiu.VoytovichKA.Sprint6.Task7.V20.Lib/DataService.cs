using System.ComponentModel;
using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VoytovichKA.Sprint6.Task7.V20.Lib
{
    public class DataService : ISprint6Task7V20
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rowRead, colRead;

            rowRead = lines.Length;
            colRead = lines[0].Split(';').Length;

            int[,] matrix = new int[rowRead, colRead];

            for (int r =  0; r < rowRead; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colRead; c++)
                {
                    matrix[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length;

            int xCol = 2;

            for (int r = 0; r < rows; r++)
            {
                for (int c = xCol; c <= xCol; c++)
                {
                    if (matrix[r, c] >= 1 && matrix[r, c] <= 20)
                    {
                        matrix[r, c] = 111;
                    }
                }
            }
            return matrix;
        }
    }
}
