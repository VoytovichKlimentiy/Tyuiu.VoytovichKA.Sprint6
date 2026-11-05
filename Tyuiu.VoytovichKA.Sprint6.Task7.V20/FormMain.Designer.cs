namespace Tyuiu.VoytovichKA.Sprint6.Task7.V20
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            openFileDialog_VKA = new OpenFileDialog();
            toolTipFile_VKA = new ToolTip(components);
            buttonAbout_VKA = new Button();
            toolTipExecute_VKA = new ToolTip(components);
            buttonExecute_VKA = new Button();
            toolTipAbout_VKA = new ToolTip(components);
            buttonOpenFile_VKA = new Button();
            panelControls_VKA = new Panel();
            buttonSaveFile_VKA = new Button();
            groupBoxCondition_VKA = new GroupBox();
            textBoxCondition_VKA = new TextBox();
            toolTipSave_VKA = new ToolTip(components);
            groupBoxInput_VKA = new GroupBox();
            dataGridViewInput_VKA = new DataGridView();
            groupBoxOutput_VKA = new GroupBox();
            dataGridViewOutput_VKA = new DataGridView();
            saveFileDialog_VKA = new SaveFileDialog();
            panelControls_VKA.SuspendLayout();
            groupBoxCondition_VKA.SuspendLayout();
            groupBoxInput_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_VKA).BeginInit();
            groupBoxOutput_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_VKA).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog_VKA
            // 
            openFileDialog_VKA.FileName = "openFileDialog_VKA";
            // 
            // buttonAbout_VKA
            // 
            buttonAbout_VKA.Cursor = Cursors.Help;
            buttonAbout_VKA.Dock = DockStyle.Right;
            buttonAbout_VKA.Image = Properties.Resources.info;
            buttonAbout_VKA.Location = new Point(909, 0);
            buttonAbout_VKA.Name = "buttonAbout_VKA";
            buttonAbout_VKA.Size = new Size(75, 68);
            buttonAbout_VKA.TabIndex = 5;
            toolTipFile_VKA.SetToolTip(buttonAbout_VKA, "О проекте");
            buttonAbout_VKA.UseVisualStyleBackColor = true;
            buttonAbout_VKA.Click += buttonAbout_VKA_Click;
            // 
            // buttonExecute_VKA
            // 
            buttonExecute_VKA.Cursor = Cursors.Hand;
            buttonExecute_VKA.Dock = DockStyle.Left;
            buttonExecute_VKA.Enabled = false;
            buttonExecute_VKA.Image = Properties.Resources.confirm;
            buttonExecute_VKA.Location = new Point(75, 0);
            buttonExecute_VKA.Name = "buttonExecute_VKA";
            buttonExecute_VKA.Size = new Size(75, 68);
            buttonExecute_VKA.TabIndex = 4;
            toolTipExecute_VKA.SetToolTip(buttonExecute_VKA, "Выполнить\r\nВыполнить программу согласно условию.");
            buttonExecute_VKA.UseVisualStyleBackColor = true;
            buttonExecute_VKA.Click += buttonExecute_VKA_Click;
            // 
            // buttonOpenFile_VKA
            // 
            buttonOpenFile_VKA.Cursor = Cursors.Hand;
            buttonOpenFile_VKA.Dock = DockStyle.Left;
            buttonOpenFile_VKA.Image = Properties.Resources.Folder;
            buttonOpenFile_VKA.Location = new Point(0, 0);
            buttonOpenFile_VKA.Name = "buttonOpenFile_VKA";
            buttonOpenFile_VKA.Size = new Size(75, 68);
            buttonOpenFile_VKA.TabIndex = 3;
            toolTipAbout_VKA.SetToolTip(buttonOpenFile_VKA, "Открыть файл\r\nВыберите нужный файл в формате .txt для обработки.");
            buttonOpenFile_VKA.UseVisualStyleBackColor = true;
            buttonOpenFile_VKA.Click += buttonOpenFile_VKA_Click;
            // 
            // panelControls_VKA
            // 
            panelControls_VKA.Controls.Add(buttonSaveFile_VKA);
            panelControls_VKA.Controls.Add(buttonAbout_VKA);
            panelControls_VKA.Controls.Add(buttonExecute_VKA);
            panelControls_VKA.Controls.Add(buttonOpenFile_VKA);
            panelControls_VKA.Dock = DockStyle.Top;
            panelControls_VKA.Location = new Point(0, 0);
            panelControls_VKA.Name = "panelControls_VKA";
            panelControls_VKA.Size = new Size(984, 68);
            panelControls_VKA.TabIndex = 4;
            // 
            // buttonSaveFile_VKA
            // 
            buttonSaveFile_VKA.Cursor = Cursors.Hand;
            buttonSaveFile_VKA.Dock = DockStyle.Left;
            buttonSaveFile_VKA.Enabled = false;
            buttonSaveFile_VKA.Image = Properties.Resources.fileNew;
            buttonSaveFile_VKA.Location = new Point(150, 0);
            buttonSaveFile_VKA.Name = "buttonSaveFile_VKA";
            buttonSaveFile_VKA.Size = new Size(75, 68);
            buttonSaveFile_VKA.TabIndex = 6;
            toolTipSave_VKA.SetToolTip(buttonSaveFile_VKA, "Сохранить\r\nСохранить результат в файл.");
            buttonSaveFile_VKA.UseVisualStyleBackColor = true;
            buttonSaveFile_VKA.Click += buttonSaveFile_VKA_Click;
            // 
            // groupBoxCondition_VKA
            // 
            groupBoxCondition_VKA.Controls.Add(textBoxCondition_VKA);
            groupBoxCondition_VKA.Dock = DockStyle.Top;
            groupBoxCondition_VKA.Location = new Point(0, 68);
            groupBoxCondition_VKA.Name = "groupBoxCondition_VKA";
            groupBoxCondition_VKA.Size = new Size(984, 68);
            groupBoxCondition_VKA.TabIndex = 5;
            groupBoxCondition_VKA.TabStop = false;
            groupBoxCondition_VKA.Text = "Условие";
            // 
            // textBoxCondition_VKA
            // 
            textBoxCondition_VKA.Dock = DockStyle.Fill;
            textBoxCondition_VKA.Location = new Point(3, 19);
            textBoxCondition_VKA.Multiline = true;
            textBoxCondition_VKA.Name = "textBoxCondition_VKA";
            textBoxCondition_VKA.ReadOnly = true;
            textBoxCondition_VKA.Size = new Size(978, 46);
            textBoxCondition_VKA.TabIndex = 0;
            textBoxCondition_VKA.Text = resources.GetString("textBoxCondition_VKA.Text");
            // 
            // groupBoxInput_VKA
            // 
            groupBoxInput_VKA.Controls.Add(dataGridViewInput_VKA);
            groupBoxInput_VKA.Dock = DockStyle.Left;
            groupBoxInput_VKA.Location = new Point(0, 136);
            groupBoxInput_VKA.Name = "groupBoxInput_VKA";
            groupBoxInput_VKA.Size = new Size(483, 425);
            groupBoxInput_VKA.TabIndex = 6;
            groupBoxInput_VKA.TabStop = false;
            groupBoxInput_VKA.Text = "Ввод:";
            // 
            // dataGridViewInput_VKA
            // 
            dataGridViewInput_VKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_VKA.ColumnHeadersVisible = false;
            dataGridViewInput_VKA.Dock = DockStyle.Fill;
            dataGridViewInput_VKA.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewInput_VKA.Location = new Point(3, 19);
            dataGridViewInput_VKA.Name = "dataGridViewInput_VKA";
            dataGridViewInput_VKA.ReadOnly = true;
            dataGridViewInput_VKA.RowHeadersVisible = false;
            dataGridViewInput_VKA.ShowEditingIcon = false;
            dataGridViewInput_VKA.Size = new Size(477, 403);
            dataGridViewInput_VKA.TabIndex = 0;
            // 
            // groupBoxOutput_VKA
            // 
            groupBoxOutput_VKA.Controls.Add(dataGridViewOutput_VKA);
            groupBoxOutput_VKA.Dock = DockStyle.Fill;
            groupBoxOutput_VKA.Location = new Point(483, 136);
            groupBoxOutput_VKA.Name = "groupBoxOutput_VKA";
            groupBoxOutput_VKA.Size = new Size(501, 425);
            groupBoxOutput_VKA.TabIndex = 7;
            groupBoxOutput_VKA.TabStop = false;
            groupBoxOutput_VKA.Text = "Вывод:";
            // 
            // dataGridViewOutput_VKA
            // 
            dataGridViewOutput_VKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_VKA.ColumnHeadersVisible = false;
            dataGridViewOutput_VKA.Dock = DockStyle.Fill;
            dataGridViewOutput_VKA.Location = new Point(3, 19);
            dataGridViewOutput_VKA.Name = "dataGridViewOutput_VKA";
            dataGridViewOutput_VKA.ReadOnly = true;
            dataGridViewOutput_VKA.RowHeadersVisible = false;
            dataGridViewOutput_VKA.Size = new Size(495, 403);
            dataGridViewOutput_VKA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(groupBoxOutput_VKA);
            Controls.Add(groupBoxInput_VKA);
            Controls.Add(groupBoxCondition_VKA);
            Controls.Add(panelControls_VKA);
            MinimumSize = new Size(1000, 600);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 20 | Войтович К.А.";
            Load += FormMain_Load;
            panelControls_VKA.ResumeLayout(false);
            groupBoxCondition_VKA.ResumeLayout(false);
            groupBoxCondition_VKA.PerformLayout();
            groupBoxInput_VKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_VKA).EndInit();
            groupBoxOutput_VKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_VKA).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private OpenFileDialog openFileDialog_VKA;
        private ToolTip toolTipExecute_VKA;
        private ToolTip toolTipFile_VKA;
        private ToolTip toolTipAbout_VKA;
        private Panel panelControls_VKA;
        private Button buttonAbout_VKA;
        private Button buttonExecute_VKA;
        private Button buttonOpenFile_VKA;
        private GroupBox groupBoxCondition_VKA;
        private Button buttonSaveFile_VKA;
        private TextBox textBoxCondition_VKA;
        private ToolTip toolTipSave_VKA;
        private GroupBox groupBoxInput_VKA;
        private GroupBox groupBoxOutput_VKA;
        private DataGridView dataGridViewInput_VKA;
        private DataGridView dataGridViewOutput_VKA;
        private SaveFileDialog saveFileDialog_VKA;
    }
}
