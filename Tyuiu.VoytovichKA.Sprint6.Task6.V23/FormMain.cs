using System.Runtime.InteropServices.Marshalling;
using Tyuiu.VoytovichKA.Sprint6.Task6.V23.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task6.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxCondition_VKA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFile_VKA_Click(object sender, EventArgs e)
        {
            openFileDialog_VKA.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (openFileDialog_VKA.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialog_VKA.FileName;
                textBoxInput_VKA.Text = File.ReadAllText(openFilePath);
                groupBoxOutput_VKA.Text = groupBoxOutput_VKA.Text + " " + openFileDialog_VKA.FileName;
                buttonExecute_VKA.Enabled = true;
            }
        }

        private void buttonExecute_VKA_Click(object sender, EventArgs e)
        {
            textBoxOutput_VKA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_VKA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void textBoxCondition_VKA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
