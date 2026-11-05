namespace Tyuiu.VoytovichKA.Sprint6.Task6.V23
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
            groupBoxButtons_VKA = new GroupBox();
            buttonAbout_VKA = new Button();
            buttonExecute_VKA = new Button();
            buttonFile_VKA = new Button();
            groupBoxCondition_VKA = new GroupBox();
            textBoxCondition_VKA = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBoxOutput_VKA = new TextBox();
            groupBoxOutput_VKA = new GroupBox();
            textBoxInput_VKA = new TextBox();
            groupBoxInput_VKA = new GroupBox();
            openFileDialog_VKA = new OpenFileDialog();
            toolTipFile_VKA = new ToolTip(components);
            toolTipExecute_VKA = new ToolTip(components);
            toolTipAbout_VKA = new ToolTip(components);
            groupBoxButtons_VKA.SuspendLayout();
            groupBoxCondition_VKA.SuspendLayout();
            groupBoxOutput_VKA.SuspendLayout();
            groupBoxInput_VKA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxButtons_VKA
            // 
            groupBoxButtons_VKA.Controls.Add(buttonAbout_VKA);
            groupBoxButtons_VKA.Controls.Add(buttonExecute_VKA);
            groupBoxButtons_VKA.Controls.Add(buttonFile_VKA);
            groupBoxButtons_VKA.Dock = DockStyle.Top;
            groupBoxButtons_VKA.Location = new Point(0, 0);
            groupBoxButtons_VKA.Name = "groupBoxButtons_VKA";
            groupBoxButtons_VKA.Size = new Size(984, 92);
            groupBoxButtons_VKA.TabIndex = 0;
            groupBoxButtons_VKA.TabStop = false;
            // 
            // buttonAbout_VKA
            // 
            buttonAbout_VKA.Cursor = Cursors.Help;
            buttonAbout_VKA.Dock = DockStyle.Right;
            buttonAbout_VKA.Image = Properties.Resources.info;
            buttonAbout_VKA.Location = new Point(906, 19);
            buttonAbout_VKA.Name = "buttonAbout_VKA";
            buttonAbout_VKA.Size = new Size(75, 70);
            buttonAbout_VKA.TabIndex = 2;
            toolTipFile_VKA.SetToolTip(buttonAbout_VKA, "О проекте");
            buttonAbout_VKA.UseVisualStyleBackColor = true;
            buttonAbout_VKA.Click += buttonAbout_VKA_Click;
            // 
            // buttonExecute_VKA
            // 
            buttonExecute_VKA.Cursor = Cursors.Hand;
            buttonExecute_VKA.Dock = DockStyle.Left;
            buttonExecute_VKA.Enabled = false;
            buttonExecute_VKA.Image = Properties.Resources.fileNew;
            buttonExecute_VKA.Location = new Point(78, 19);
            buttonExecute_VKA.Name = "buttonExecute_VKA";
            buttonExecute_VKA.Size = new Size(75, 70);
            buttonExecute_VKA.TabIndex = 1;
            toolTipExecute_VKA.SetToolTip(buttonExecute_VKA, "Выполнить\r\nВыполнить программу согласно условию.");
            buttonExecute_VKA.UseVisualStyleBackColor = true;
            buttonExecute_VKA.Click += buttonExecute_VKA_Click;
            // 
            // buttonFile_VKA
            // 
            buttonFile_VKA.Cursor = Cursors.Hand;
            buttonFile_VKA.Dock = DockStyle.Left;
            buttonFile_VKA.Image = Properties.Resources.Folder;
            buttonFile_VKA.Location = new Point(3, 19);
            buttonFile_VKA.Name = "buttonFile_VKA";
            buttonFile_VKA.Size = new Size(75, 70);
            buttonFile_VKA.TabIndex = 0;
            toolTipAbout_VKA.SetToolTip(buttonFile_VKA, "Открыть файл\r\nВыберите нужный файл в формате .txt для обработки.");
            buttonFile_VKA.UseVisualStyleBackColor = true;
            buttonFile_VKA.Click += buttonFile_VKA_Click;
            // 
            // groupBoxCondition_VKA
            // 
            groupBoxCondition_VKA.Controls.Add(textBoxCondition_VKA);
            groupBoxCondition_VKA.Dock = DockStyle.Top;
            groupBoxCondition_VKA.Location = new Point(0, 92);
            groupBoxCondition_VKA.Name = "groupBoxCondition_VKA";
            groupBoxCondition_VKA.Size = new Size(984, 97);
            groupBoxCondition_VKA.TabIndex = 1;
            groupBoxCondition_VKA.TabStop = false;
            groupBoxCondition_VKA.Text = "Условие";
            // 
            // textBoxCondition_VKA
            // 
            textBoxCondition_VKA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCondition_VKA.Location = new Point(6, 22);
            textBoxCondition_VKA.Multiline = true;
            textBoxCondition_VKA.Name = "textBoxCondition_VKA";
            textBoxCondition_VKA.ReadOnly = true;
            textBoxCondition_VKA.Size = new Size(966, 69);
            textBoxCondition_VKA.TabIndex = 0;
            textBoxCondition_VKA.Text = "Дан файл, который может находиться в любом месте на диске. Загрузить файл. Вывести слова, в которых встречается s в результирующую строку и вывести её.";
            textBoxCondition_VKA.TextChanged += textBoxCondition_VKA_TextChanged;
            // 
            // textBoxOutput_VKA
            // 
            textBoxOutput_VKA.Dock = DockStyle.Fill;
            textBoxOutput_VKA.Location = new Point(3, 19);
            textBoxOutput_VKA.Multiline = true;
            textBoxOutput_VKA.Name = "textBoxOutput_VKA";
            textBoxOutput_VKA.ReadOnly = true;
            textBoxOutput_VKA.Size = new Size(474, 350);
            textBoxOutput_VKA.TabIndex = 0;
            // 
            // groupBoxOutput_VKA
            // 
            groupBoxOutput_VKA.Controls.Add(textBoxOutput_VKA);
            groupBoxOutput_VKA.Dock = DockStyle.Fill;
            groupBoxOutput_VKA.Location = new Point(504, 189);
            groupBoxOutput_VKA.Name = "groupBoxOutput_VKA";
            groupBoxOutput_VKA.Size = new Size(480, 372);
            groupBoxOutput_VKA.TabIndex = 3;
            groupBoxOutput_VKA.TabStop = false;
            groupBoxOutput_VKA.Text = "Вывод:";
            // 
            // textBoxInput_VKA
            // 
            textBoxInput_VKA.Dock = DockStyle.Fill;
            textBoxInput_VKA.Location = new Point(3, 19);
            textBoxInput_VKA.Multiline = true;
            textBoxInput_VKA.Name = "textBoxInput_VKA";
            textBoxInput_VKA.ReadOnly = true;
            textBoxInput_VKA.Size = new Size(498, 350);
            textBoxInput_VKA.TabIndex = 0;
            // 
            // groupBoxInput_VKA
            // 
            groupBoxInput_VKA.Controls.Add(textBoxInput_VKA);
            groupBoxInput_VKA.Dock = DockStyle.Left;
            groupBoxInput_VKA.Location = new Point(0, 189);
            groupBoxInput_VKA.Name = "groupBoxInput_VKA";
            groupBoxInput_VKA.Size = new Size(504, 372);
            groupBoxInput_VKA.TabIndex = 2;
            groupBoxInput_VKA.TabStop = false;
            groupBoxInput_VKA.Text = "Ввод:";
            // 
            // openFileDialog_VKA
            // 
            openFileDialog_VKA.FileName = "openFileDialog_VKA";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(groupBoxOutput_VKA);
            Controls.Add(groupBoxInput_VKA);
            Controls.Add(groupBoxCondition_VKA);
            Controls.Add(groupBoxButtons_VKA);
            MinimumSize = new Size(1000, 600);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 23 | Войтович К.А.";
            Load += FormMain_Load;
            groupBoxButtons_VKA.ResumeLayout(false);
            groupBoxCondition_VKA.ResumeLayout(false);
            groupBoxCondition_VKA.PerformLayout();
            groupBoxOutput_VKA.ResumeLayout(false);
            groupBoxOutput_VKA.PerformLayout();
            groupBoxInput_VKA.ResumeLayout(false);
            groupBoxInput_VKA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxButtons_VKA;
        private GroupBox groupBoxCondition_VKA;
        private TextBox textBoxCondition_VKA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBoxOutput_VKA;
        private GroupBox groupBoxOutput_VKA;
        private TextBox textBoxInput_VKA;
        private GroupBox groupBoxInput_VKA;
        private Button buttonAbout_VKA;
        private Button buttonExecute_VKA;
        private Button buttonFile_VKA;
        private OpenFileDialog openFileDialog_VKA;
        private ToolTip toolTipExecute_VKA;
        private ToolTip toolTipFile_VKA;
        private ToolTip toolTipAbout_VKA;
    }
}
