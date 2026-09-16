using Tyuiu.VoytovichKA.Sprint6.Task0.V4.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task0.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBoxInput_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutput_VKA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_VKA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, выполнил студент группы НТм-25-1 Войтович Климентий Антонович", "Описание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxVarX_VKA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_VKA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar>=58) && (e.KeyChar !=',') && (e.KeyChar != 8))
            {
                e.Handled= true;
            }
        }
    }
}
