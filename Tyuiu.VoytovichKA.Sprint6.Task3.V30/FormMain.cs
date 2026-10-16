using Tyuiu.VoytovichKA.Sprint6.Task3.V30.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task3.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {{ -9, -4, 17, -1, -20},
            {-19,  18,  -4,   2,  14},
            {-12,  16,  -2,   7,  18},
            {-16,  15,   4, -12, -13},
            {-15,  -4, -16,   1, -14} };



        private void buttonExecute_VKA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.GetUpperBound(1) + 1;
            dataGridViewOutput_VKA.ColumnCount = columns;
            dataGridViewOutput_VKA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutput_VKA.Columns[i].Width = 25;

            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput_VKA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewInput_VKA.ColumnCount = columns;
            dataGridViewInput_VKA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_VKA.Columns[i].Width = 25;

            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_VKA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAbout_VKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3, выполнил студент группы НТм-25-1 Войтович Климентий Антонович", "Описание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
