using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.VoytovichKA.Sprint6.Task4.V10.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task4.V10
{
    public partial class FormMain_VKA : Form
    {
        public FormMain_VKA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonExecute_VKA_Click(object sender, EventArgs e)
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
                    this.chartFunction_VKA.Series[0].Points.AddXY(startStep, res[i]);
                    textBoxOutput_VKA.AppendText(res[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAbout_VKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4, выполнил студент группы НТм-25-1 Войтович Климентий Антонович", "Описание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_VKA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_VKA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask4.txt";
                File.WriteAllText(path, textBoxOutput_VKA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно. \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_VKA_Load(object sender, EventArgs e)
        {

        }
    }
}
