using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.VoytovichKA.Sprint6.Task2.V22.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task2.V22
{
    public partial class FormMain_VKA : Form
    {
        public FormMain_VKA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2, выполнил студент группы НТм-25-1 Войтович Климентий Антонович", "Описание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_VKA.Text);
                int endStep = Convert.ToInt32(textBoxEnd_VKA.Text);
                int len = ds.GetMassFunction(startStep, endStep).Length;
                string strLine;
                double[] res = ds.GetMassFunction(startStep, endStep);

                this.chartFunction_VKA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_VKA.ChartAreas[0].AxisY.Title = "Ось Y";
                this.chartFunction_VKA.Series[0].ChartType = SeriesChartType.Line;
                this.chartFunction_VKA.Series[0].MarkerStyle = MarkerStyle.Circle;
                this.chartFunction_VKA.Series[0].Name = "F(X)";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_VKA.Rows.Add(Convert.ToString(startStep), Convert.ToString(res[i]));
                    this.chartFunction_VKA.Series[0].Points.AddXY(startStep, res[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStart_VKA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnd_VKA_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExecute_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExecute.BackColor = Color.Gray;
        }

        private void buttonExecute_MouseEnter(object sender, EventArgs e)
        {
            buttonExecute.BackColor = Color.Green;
        }

        private void buttonExecute_MouseLeave(object sender, EventArgs e)
        {
            buttonExecute.BackColor = Color.MediumSpringGreen;
        }
    }
}
