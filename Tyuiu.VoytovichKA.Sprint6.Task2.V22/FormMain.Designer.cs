namespace Tyuiu.VoytovichKA.Sprint6.Task2.V22
{
    partial class FormMain_VKA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_VKA));
            groupBoxOutput_VKA = new GroupBox();
            chartFunction_VKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_VKA = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnFX = new DataGridViewTextBoxColumn();
            labelRes_VKA = new Label();
            groupBoxCondition_VKA = new GroupBox();
            richTextBoxCondition_VKA = new RichTextBox();
            pictureBoxFormula_VKA = new PictureBox();
            groupBoxInput_VKA = new GroupBox();
            labelEnd_VKA = new Label();
            textBoxEnd_VKA = new TextBox();
            labelStart_VKA = new Label();
            textBoxStart_VKA = new TextBox();
            buttonExecute = new Button();
            buttonAbout = new Button();
            groupBoxOutput_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VKA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_VKA).BeginInit();
            groupBoxCondition_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VKA).BeginInit();
            groupBoxInput_VKA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOutput_VKA
            // 
            groupBoxOutput_VKA.Controls.Add(chartFunction_VKA);
            groupBoxOutput_VKA.Controls.Add(dataGridViewFunction_VKA);
            groupBoxOutput_VKA.Controls.Add(labelRes_VKA);
            groupBoxOutput_VKA.Location = new Point(355, 12);
            groupBoxOutput_VKA.Name = "groupBoxOutput_VKA";
            groupBoxOutput_VKA.Size = new Size(797, 426);
            groupBoxOutput_VKA.TabIndex = 12;
            groupBoxOutput_VKA.TabStop = false;
            groupBoxOutput_VKA.Text = "Вывод данных";
            // 
            // chartFunction_VKA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_VKA.ChartAreas.Add(chartArea1);
            chartFunction_VKA.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_VKA.Legends.Add(legend1);
            chartFunction_VKA.Location = new Point(115, 47);
            chartFunction_VKA.Name = "chartFunction_VKA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_VKA.Series.Add(series1);
            chartFunction_VKA.Size = new Size(676, 373);
            chartFunction_VKA.TabIndex = 17;
            chartFunction_VKA.Text = "chartFunction_VKA";
            // 
            // dataGridViewFunction_VKA
            // 
            dataGridViewFunction_VKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_VKA.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnFX });
            dataGridViewFunction_VKA.Location = new Point(6, 47);
            dataGridViewFunction_VKA.Name = "dataGridViewFunction_VKA";
            dataGridViewFunction_VKA.RowHeadersVisible = false;
            dataGridViewFunction_VKA.Size = new Size(103, 373);
            dataGridViewFunction_VKA.TabIndex = 16;
            dataGridViewFunction_VKA.CellContentClick += dataGridViewFunction_CellContentClick;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.Name = "ColumnX";
            ColumnX.Width = 50;
            // 
            // ColumnFX
            // 
            ColumnFX.HeaderText = "F(X)";
            ColumnFX.Name = "ColumnFX";
            ColumnFX.Width = 50;
            // 
            // labelRes_VKA
            // 
            labelRes_VKA.AutoSize = true;
            labelRes_VKA.Location = new Point(6, 29);
            labelRes_VKA.Name = "labelRes_VKA";
            labelRes_VKA.Size = new Size(63, 15);
            labelRes_VKA.TabIndex = 2;
            labelRes_VKA.Text = "Результат:";
            // 
            // groupBoxCondition_VKA
            // 
            groupBoxCondition_VKA.Controls.Add(richTextBoxCondition_VKA);
            groupBoxCondition_VKA.Controls.Add(pictureBoxFormula_VKA);
            groupBoxCondition_VKA.Location = new Point(9, 12);
            groupBoxCondition_VKA.Name = "groupBoxCondition_VKA";
            groupBoxCondition_VKA.Size = new Size(340, 311);
            groupBoxCondition_VKA.TabIndex = 11;
            groupBoxCondition_VKA.TabStop = false;
            groupBoxCondition_VKA.Text = "Условие";
            // 
            // richTextBoxCondition_VKA
            // 
            richTextBoxCondition_VKA.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxCondition_VKA.Location = new Point(6, 31);
            richTextBoxCondition_VKA.Name = "richTextBoxCondition_VKA";
            richTextBoxCondition_VKA.ReadOnly = true;
            richTextBoxCondition_VKA.Size = new Size(328, 68);
            richTextBoxCondition_VKA.TabIndex = 1;
            richTextBoxCondition_VKA.Text = "Протабулировать функцию на заданном диапазоне.\nРезультат вывести в DataGridView и построить график функции.\n\n\n";
            // 
            // pictureBoxFormula_VKA
            // 
            pictureBoxFormula_VKA.Image = (Image)resources.GetObject("pictureBoxFormula_VKA.Image");
            pictureBoxFormula_VKA.Location = new Point(38, 155);
            pictureBoxFormula_VKA.Name = "pictureBoxFormula_VKA";
            pictureBoxFormula_VKA.Size = new Size(265, 50);
            pictureBoxFormula_VKA.TabIndex = 11;
            pictureBoxFormula_VKA.TabStop = false;
            // 
            // groupBoxInput_VKA
            // 
            groupBoxInput_VKA.Controls.Add(labelEnd_VKA);
            groupBoxInput_VKA.Controls.Add(textBoxEnd_VKA);
            groupBoxInput_VKA.Controls.Add(labelStart_VKA);
            groupBoxInput_VKA.Controls.Add(textBoxStart_VKA);
            groupBoxInput_VKA.Location = new Point(9, 329);
            groupBoxInput_VKA.Name = "groupBoxInput_VKA";
            groupBoxInput_VKA.Size = new Size(226, 109);
            groupBoxInput_VKA.TabIndex = 13;
            groupBoxInput_VKA.TabStop = false;
            groupBoxInput_VKA.Text = "Ввод данных";
            // 
            // labelEnd_VKA
            // 
            labelEnd_VKA.AutoSize = true;
            labelEnd_VKA.Location = new Point(110, 35);
            labelEnd_VKA.Name = "labelEnd_VKA";
            labelEnd_VKA.Size = new Size(75, 15);
            labelEnd_VKA.TabIndex = 3;
            labelEnd_VKA.Text = "Конец шага:";
            // 
            // textBoxEnd_VKA
            // 
            textBoxEnd_VKA.Location = new Point(110, 53);
            textBoxEnd_VKA.Name = "textBoxEnd_VKA";
            textBoxEnd_VKA.Size = new Size(98, 23);
            textBoxEnd_VKA.TabIndex = 2;
            textBoxEnd_VKA.TextChanged += textBoxEnd_VKA_TextChanged;
            // 
            // labelStart_VKA
            // 
            labelStart_VKA.AutoSize = true;
            labelStart_VKA.Location = new Point(6, 35);
            labelStart_VKA.Name = "labelStart_VKA";
            labelStart_VKA.Size = new Size(72, 15);
            labelStart_VKA.TabIndex = 1;
            labelStart_VKA.Text = "Старт шага:";
            // 
            // textBoxStart_VKA
            // 
            textBoxStart_VKA.Location = new Point(6, 53);
            textBoxStart_VKA.Name = "textBoxStart_VKA";
            textBoxStart_VKA.Size = new Size(98, 23);
            textBoxStart_VKA.TabIndex = 0;
            textBoxStart_VKA.TextChanged += textBoxStart_VKA_TextChanged;
            // 
            // buttonExecute
            // 
            buttonExecute.BackColor = Color.MediumSpringGreen;
            buttonExecute.Font = new Font("Segoe UI", 12F);
            buttonExecute.Location = new Point(250, 383);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(99, 55);
            buttonExecute.TabIndex = 15;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = false;
            buttonExecute.Click += buttonExecute_Click;
            buttonExecute.MouseDown += buttonExecute_MouseDown;
            buttonExecute.MouseEnter += buttonExecute_MouseEnter;
            buttonExecute.MouseLeave += buttonExecute_MouseLeave;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.SkyBlue;
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Font = new Font("Segoe UI", 10F);
            buttonAbout.Location = new Point(250, 329);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(99, 48);
            buttonAbout.TabIndex = 14;
            buttonAbout.Text = "Справка";
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // FormMain_VKA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 450);
            Controls.Add(groupBoxOutput_VKA);
            Controls.Add(groupBoxCondition_VKA);
            Controls.Add(groupBoxInput_VKA);
            Controls.Add(buttonExecute);
            Controls.Add(buttonAbout);
            Name = "FormMain_VKA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 22 | Войтович К.А.";
            groupBoxOutput_VKA.ResumeLayout(false);
            groupBoxOutput_VKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VKA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_VKA).EndInit();
            groupBoxCondition_VKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VKA).EndInit();
            groupBoxInput_VKA.ResumeLayout(false);
            groupBoxInput_VKA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOutput_VKA;
        private Label labelRes_VKA;
        private GroupBox groupBoxCondition_VKA;
        private RichTextBox richTextBoxCondition_VKA;
        private PictureBox pictureBoxFormula_VKA;
        private GroupBox groupBoxInput_VKA;
        private Label labelEnd_VKA;
        private TextBox textBoxEnd_VKA;
        private Label labelStart_VKA;
        private TextBox textBoxStart_VKA;
        private Button buttonExecute;
        private Button buttonAbout;
        private DataGridView dataGridViewFunction_VKA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VKA;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnFX;
    }
}
