using System.Runtime.InteropServices.Marshalling;
using Tyuiu.VoytovichKA.Sprint6.Task7.V20;
using Tyuiu.VoytovichKA.Sprint6.Task7.V20.Lib;

namespace Tyuiu.VoytovichKA.Sprint6.Task7.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        static int rows, columns;
        DataService ds = new DataService();

        

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_VKA_Click(object sender, EventArgs e)
        {
            openFileDialog_VKA.Filter = ".csv-файл с разделителем ';' (*.csv)|*.csv";
            if (openFileDialog_VKA.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialog_VKA.FileName;
                int[,] arrayValues = new int[rows, columns];

                arrayValues = LoadFromFileData(openFilePath);
                dataGridViewInput_VKA.ColumnCount = columns;
                dataGridViewInput_VKA.RowCount = rows;
                dataGridViewOutput_VKA.ColumnCount = columns;
                dataGridViewOutput_VKA.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewInput_VKA.Columns[i].Width = 30;
                    dataGridViewOutput_VKA.Columns[i].Width = 30;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewInput_VKA.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                arrayValues = ds.GetMatrix(openFilePath);
                buttonExecute_VKA.Enabled = true;
            }
        }

        private void buttonAbout_VKA_Click(object sender, EventArgs e)
        {
            {
                FormAbout formAbout = new FormAbout();
                formAbout.ShowDialog();
            }
        }

        private void buttonExecute_VKA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_VKA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_VKA.Enabled = true;
        }

        private void buttonSaveFile_VKA_Click(object sender, EventArgs e)
        {
            saveFileDialog_VKA.FileName = "OutPutFileTask7.csv";
            saveFileDialog_VKA.InitialDirectory = Directory.GetCurrentDirectory();
            if (saveFileDialog_VKA.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog_VKA.FileName;

                FileInfo FI = new FileInfo(path);
                bool fileExists = FI.Exists;
                if (fileExists) File.Delete(path);

                int rows = dataGridViewOutput_VKA.RowCount;
                int columns = dataGridViewOutput_VKA.ColumnCount;

                string str = "";

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        if (c != columns - 1)
                        { str = str + dataGridViewOutput_VKA.Rows[r].Cells[c].Value + ";"; }
                        else
                        { str = str + dataGridViewOutput_VKA.Rows[r].Cells[c].Value; }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }
    }
}
