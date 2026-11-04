using Tyuiu.VoytovichKA.Sprint6.Task5.V24.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task5.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask5V24.txt");

        private void buttonExecute_VKA_Click(object sender, EventArgs e)
        {
            dataGridView_VKA.ColumnCount = 2;
            dataGridView_VKA.Columns[0].Width = 20;
            dataGridView_VKA.Columns[1].Width = 50;

            this.chart_VKA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart_VKA.ChartAreas[0].AxisY.Title = "Ось Y";

            chart_VKA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            try
            {
                numsMass = ds.LoadFromDataFile(path);
            }
            catch
            {
                MessageBox.Show("Файл отсутствует в директории", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView_VKA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart_VKA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonAbout_VKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5, выполнил студент группы НТм-25-1 Войтович Климентий Антонович", "Описание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_VKA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
