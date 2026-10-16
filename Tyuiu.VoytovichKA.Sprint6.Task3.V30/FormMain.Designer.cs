namespace Tyuiu.VoytovichKA.Sprint6.Task3.V30
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
            groupBoxOutput_VKA = new GroupBox();
            dataGridViewOutput_VKA = new DataGridView();
            labelResult_VKA = new Label();
            buttonExecute_VKA = new Button();
            buttonAbout_VKA = new Button();
            groupBoxInput_VKA = new GroupBox();
            richTextBoxInput_VKA = new RichTextBox();
            labelInput_VKA = new Label();
            dataGridViewInput_VKA = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBoxOutput_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_VKA).BeginInit();
            groupBoxInput_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_VKA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOutput_VKA
            // 
            groupBoxOutput_VKA.Controls.Add(dataGridViewOutput_VKA);
            groupBoxOutput_VKA.Controls.Add(labelResult_VKA);
            groupBoxOutput_VKA.Location = new Point(401, 12);
            groupBoxOutput_VKA.Name = "groupBoxOutput_VKA";
            groupBoxOutput_VKA.Size = new Size(221, 255);
            groupBoxOutput_VKA.TabIndex = 0;
            groupBoxOutput_VKA.TabStop = false;
            groupBoxOutput_VKA.Text = "Вывод данных";
            // 
            // dataGridViewOutput_VKA
            // 
            dataGridViewOutput_VKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_VKA.ColumnHeadersVisible = false;
            dataGridViewOutput_VKA.Location = new Point(6, 44);
            dataGridViewOutput_VKA.Name = "dataGridViewOutput_VKA";
            dataGridViewOutput_VKA.ReadOnly = true;
            dataGridViewOutput_VKA.RowHeadersVisible = false;
            dataGridViewOutput_VKA.Size = new Size(197, 205);
            dataGridViewOutput_VKA.TabIndex = 4;
            // 
            // labelResult_VKA
            // 
            labelResult_VKA.AutoSize = true;
            labelResult_VKA.Location = new Point(6, 24);
            labelResult_VKA.Name = "labelResult_VKA";
            labelResult_VKA.Size = new Size(63, 15);
            labelResult_VKA.TabIndex = 1;
            labelResult_VKA.Text = "Результат:";
            // 
            // buttonExecute_VKA
            // 
            buttonExecute_VKA.FlatStyle = FlatStyle.System;
            buttonExecute_VKA.Location = new Point(432, 273);
            buttonExecute_VKA.Name = "buttonExecute_VKA";
            buttonExecute_VKA.Size = new Size(190, 25);
            buttonExecute_VKA.TabIndex = 1;
            buttonExecute_VKA.Text = "Выполнить";
            buttonExecute_VKA.UseVisualStyleBackColor = true;
            buttonExecute_VKA.Click += buttonExecute_VKA_Click;
            // 
            // buttonAbout_VKA
            // 
            buttonAbout_VKA.Location = new Point(401, 273);
            buttonAbout_VKA.Name = "buttonAbout_VKA";
            buttonAbout_VKA.Size = new Size(25, 25);
            buttonAbout_VKA.TabIndex = 2;
            buttonAbout_VKA.Text = "?";
            buttonAbout_VKA.UseVisualStyleBackColor = true;
            buttonAbout_VKA.Click += buttonAbout_VKA_Click;
            // 
            // groupBoxInput_VKA
            // 
            groupBoxInput_VKA.Controls.Add(richTextBoxInput_VKA);
            groupBoxInput_VKA.Controls.Add(labelInput_VKA);
            groupBoxInput_VKA.Controls.Add(dataGridViewInput_VKA);
            groupBoxInput_VKA.Location = new Point(12, 12);
            groupBoxInput_VKA.Name = "groupBoxInput_VKA";
            groupBoxInput_VKA.Size = new Size(383, 255);
            groupBoxInput_VKA.TabIndex = 3;
            groupBoxInput_VKA.TabStop = false;
            groupBoxInput_VKA.Text = "Условие";
            // 
            // richTextBoxInput_VKA
            // 
            richTextBoxInput_VKA.BorderStyle = BorderStyle.None;
            richTextBoxInput_VKA.Location = new Point(6, 26);
            richTextBoxInput_VKA.Name = "richTextBoxInput_VKA";
            richTextBoxInput_VKA.ReadOnly = true;
            richTextBoxInput_VKA.Size = new Size(168, 223);
            richTextBoxInput_VKA.TabIndex = 7;
            richTextBoxInput_VKA.Text = "Дана матрица 5 на 5\n-9  -4  17  -1 -20\n-19  18  -4   2  14\n-12  16  -2   7  18\n-16  15   4 -12 -13\n-15  -4 -16   1 -14\n\nЗаменить чётные значения в пятой строке на 0.";
            // 
            // labelInput_VKA
            // 
            labelInput_VKA.AutoSize = true;
            labelInput_VKA.Location = new Point(180, 26);
            labelInput_VKA.Name = "labelInput_VKA";
            labelInput_VKA.Size = new Size(59, 15);
            labelInput_VKA.TabIndex = 5;
            labelInput_VKA.Text = "Матрица:";
            // 
            // dataGridViewInput_VKA
            // 
            dataGridViewInput_VKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_VKA.ColumnHeadersVisible = false;
            dataGridViewInput_VKA.Location = new Point(180, 44);
            dataGridViewInput_VKA.Name = "dataGridViewInput_VKA";
            dataGridViewInput_VKA.ReadOnly = true;
            dataGridViewInput_VKA.RowHeadersVisible = false;
            dataGridViewInput_VKA.Size = new Size(197, 205);
            dataGridViewInput_VKA.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 310);
            Controls.Add(groupBoxInput_VKA);
            Controls.Add(buttonAbout_VKA);
            Controls.Add(buttonExecute_VKA);
            Controls.Add(groupBoxOutput_VKA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 30 | Войтович К.А.";
            Load += FormMain_Load;
            groupBoxOutput_VKA.ResumeLayout(false);
            groupBoxOutput_VKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_VKA).EndInit();
            groupBoxInput_VKA.ResumeLayout(false);
            groupBoxInput_VKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_VKA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOutput_VKA;
        private Label labelResult_VKA;
        private Button buttonExecute_VKA;
        private Button buttonAbout_VKA;
        private GroupBox groupBoxInput_VKA;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridViewOutput_VKA;
        private Label labelInput_VKA;
        private DataGridView dataGridViewInput_VKA;
        private RichTextBox richTextBoxInput_VKA;
    }
}
