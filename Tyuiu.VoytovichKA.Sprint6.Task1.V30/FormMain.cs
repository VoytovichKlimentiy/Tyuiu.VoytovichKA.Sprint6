using Tyuiu.VoytovichKA.Sprint6.Task1.V30.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task1.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBoxStart_VKA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_VKA.Text);
                int endStep = Convert.ToInt32(textBoxEnd_VKA.Text);
                int len = endStep - startStep;
                string strLine;
                double[] res = ds.GetMassFunction(startStep, endStep);
                richTextBoxRes_VKA.Text = "";
                richTextBoxRes_VKA.AppendText("+----------+-----------+" + Environment.NewLine);
                richTextBoxRes_VKA.AppendText("|    x     |    f(x)   |" + Environment.NewLine);
                richTextBoxRes_VKA.AppendText("+----------+-----------+" + Environment.NewLine);
                for (int i = 0; i <= len; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}   |", startStep, res[i]);
                    richTextBoxRes_VKA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                richTextBoxRes_VKA.AppendText("+----------+-----------+");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void textBoxStart_VKA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxEnd_VKA_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, выполнил студент группы НТм-25-1 Войтович Климентий Антонович", "Описание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxOutput_VKA_Enter(object sender, EventArgs e)
        {

        }
    }
}
