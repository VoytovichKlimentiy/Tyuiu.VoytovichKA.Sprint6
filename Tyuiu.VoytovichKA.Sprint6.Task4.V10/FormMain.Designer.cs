namespace Tyuiu.VoytovichKA.Sprint6.Task4.V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_VKA));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxMain_VKA = new GroupBox();
            groupBoxCondition_VKA = new GroupBox();
            textBox1 = new TextBox();
            pictureBoxFormula_VKA = new PictureBox();
            groupBoxInput_VKA = new GroupBox();
            buttonSave_VKA = new Button();
            buttonAbout_VKA = new Button();
            labelEnd_VKA = new Label();
            textBoxEnd_VKA = new TextBox();
            buttonExecute_VKA = new Button();
            labelStart_VKA = new Label();
            textBoxStart_VKA = new TextBox();
            chartFunction_VKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutput_VKA = new GroupBox();
            textBoxOutput_VKA = new TextBox();
            groupBoxMain_VKA.SuspendLayout();
            groupBoxCondition_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VKA).BeginInit();
            groupBoxInput_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VKA).BeginInit();
            groupBoxOutput_VKA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain_VKA
            // 
            groupBoxMain_VKA.AutoSize = true;
            groupBoxMain_VKA.Controls.Add(groupBoxCondition_VKA);
            groupBoxMain_VKA.Controls.Add(groupBoxInput_VKA);
            groupBoxMain_VKA.Dock = DockStyle.Top;
            groupBoxMain_VKA.Location = new Point(0, 0);
            groupBoxMain_VKA.Name = "groupBoxMain_VKA";
            groupBoxMain_VKA.Size = new Size(984, 130);
            groupBoxMain_VKA.TabIndex = 0;
            groupBoxMain_VKA.TabStop = false;
            // 
            // groupBoxCondition_VKA
            // 
            groupBoxCondition_VKA.AutoSize = true;
            groupBoxCondition_VKA.Controls.Add(textBox1);
            groupBoxCondition_VKA.Controls.Add(pictureBoxFormula_VKA);
            groupBoxCondition_VKA.Dock = DockStyle.Fill;
            groupBoxCondition_VKA.Location = new Point(3, 19);
            groupBoxCondition_VKA.Name = "groupBoxCondition_VKA";
            groupBoxCondition_VKA.Size = new Size(432, 108);
            groupBoxCondition_VKA.TabIndex = 27;
            groupBoxCondition_VKA.TabStop = false;
            groupBoxCondition_VKA.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(405, 34);
            textBox1.TabIndex = 7;
            textBox1.Text = "Протабулировать функцию F(x) на заданном диапазоне, при делении на ноль вернуть значение 0. Округлить до двух знаков после запятой.";
            // 
            // pictureBoxFormula_VKA
            // 
            pictureBoxFormula_VKA.Image = (Image)resources.GetObject("pictureBoxFormula_VKA.Image");
            pictureBoxFormula_VKA.Location = new Point(8, 51);
            pictureBoxFormula_VKA.Name = "pictureBoxFormula_VKA";
            pictureBoxFormula_VKA.Size = new Size(263, 35);
            pictureBoxFormula_VKA.TabIndex = 6;
            pictureBoxFormula_VKA.TabStop = false;
            // 
            // groupBoxInput_VKA
            // 
            groupBoxInput_VKA.AutoSize = true;
            groupBoxInput_VKA.Controls.Add(buttonSave_VKA);
            groupBoxInput_VKA.Controls.Add(buttonAbout_VKA);
            groupBoxInput_VKA.Controls.Add(labelEnd_VKA);
            groupBoxInput_VKA.Controls.Add(textBoxEnd_VKA);
            groupBoxInput_VKA.Controls.Add(buttonExecute_VKA);
            groupBoxInput_VKA.Controls.Add(labelStart_VKA);
            groupBoxInput_VKA.Controls.Add(textBoxStart_VKA);
            groupBoxInput_VKA.Dock = DockStyle.Right;
            groupBoxInput_VKA.Location = new Point(435, 19);
            groupBoxInput_VKA.Name = "groupBoxInput_VKA";
            groupBoxInput_VKA.Size = new Size(546, 108);
            groupBoxInput_VKA.TabIndex = 26;
            groupBoxInput_VKA.TabStop = false;
            groupBoxInput_VKA.Text = "Ввод данных";
            // 
            // buttonSave_VKA
            // 
            buttonSave_VKA.BackColor = Color.DodgerBlue;
            buttonSave_VKA.Cursor = Cursors.Hand;
            buttonSave_VKA.Font = new Font("Segoe UI", 12F);
            buttonSave_VKA.Location = new Point(343, 22);
            buttonSave_VKA.Name = "buttonSave_VKA";
            buttonSave_VKA.Size = new Size(99, 55);
            buttonSave_VKA.TabIndex = 25;
            buttonSave_VKA.Text = "Сохранить";
            buttonSave_VKA.UseVisualStyleBackColor = false;
            buttonSave_VKA.Click += buttonSave_VKA_Click;
            // 
            // buttonAbout_VKA
            // 
            buttonAbout_VKA.BackColor = Color.SkyBlue;
            buttonAbout_VKA.Cursor = Cursors.Help;
            buttonAbout_VKA.FlatStyle = FlatStyle.Flat;
            buttonAbout_VKA.Font = new Font("Segoe UI", 10F);
            buttonAbout_VKA.Location = new Point(455, 22);
            buttonAbout_VKA.Name = "buttonAbout_VKA";
            buttonAbout_VKA.Size = new Size(85, 53);
            buttonAbout_VKA.TabIndex = 24;
            buttonAbout_VKA.Text = "Справка";
            buttonAbout_VKA.UseVisualStyleBackColor = false;
            buttonAbout_VKA.Click += buttonAbout_VKA_Click;
            // 
            // labelEnd_VKA
            // 
            labelEnd_VKA.AutoSize = true;
            labelEnd_VKA.Location = new Point(127, 34);
            labelEnd_VKA.Name = "labelEnd_VKA";
            labelEnd_VKA.Size = new Size(75, 15);
            labelEnd_VKA.TabIndex = 22;
            labelEnd_VKA.Text = "Конец шага:";
            // 
            // textBoxEnd_VKA
            // 
            textBoxEnd_VKA.Location = new Point(127, 52);
            textBoxEnd_VKA.Name = "textBoxEnd_VKA";
            textBoxEnd_VKA.Size = new Size(98, 23);
            textBoxEnd_VKA.TabIndex = 21;
            // 
            // buttonExecute_VKA
            // 
            buttonExecute_VKA.BackColor = Color.MediumSpringGreen;
            buttonExecute_VKA.Cursor = Cursors.Hand;
            buttonExecute_VKA.Font = new Font("Segoe UI", 12F);
            buttonExecute_VKA.Location = new Point(231, 22);
            buttonExecute_VKA.Name = "buttonExecute_VKA";
            buttonExecute_VKA.Size = new Size(99, 55);
            buttonExecute_VKA.TabIndex = 23;
            buttonExecute_VKA.Text = "Выполнить";
            buttonExecute_VKA.UseVisualStyleBackColor = false;
            buttonExecute_VKA.Click += buttonExecute_VKA_Click;
            // 
            // labelStart_VKA
            // 
            labelStart_VKA.AutoSize = true;
            labelStart_VKA.Location = new Point(23, 34);
            labelStart_VKA.Name = "labelStart_VKA";
            labelStart_VKA.Size = new Size(72, 15);
            labelStart_VKA.TabIndex = 20;
            labelStart_VKA.Text = "Старт шага:";
            // 
            // textBoxStart_VKA
            // 
            textBoxStart_VKA.Location = new Point(23, 52);
            textBoxStart_VKA.Name = "textBoxStart_VKA";
            textBoxStart_VKA.Size = new Size(98, 23);
            textBoxStart_VKA.TabIndex = 19;
            // 
            // chartFunction_VKA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_VKA.ChartAreas.Add(chartArea1);
            chartFunction_VKA.Dock = DockStyle.Right;
            legend1.Name = "Legend1";
            chartFunction_VKA.Legends.Add(legend1);
            chartFunction_VKA.Location = new Point(223, 130);
            chartFunction_VKA.Name = "chartFunction_VKA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_VKA.Series.Add(series1);
            chartFunction_VKA.Size = new Size(761, 331);
            chartFunction_VKA.TabIndex = 2;
            chartFunction_VKA.Text = "chart1";
            title1.Name = "TitleFunc";
            title1.Text = "График заданной функции";
            chartFunction_VKA.Titles.Add(title1);
            // 
            // groupBoxOutput_VKA
            // 
            groupBoxOutput_VKA.AutoSize = true;
            groupBoxOutput_VKA.Controls.Add(textBoxOutput_VKA);
            groupBoxOutput_VKA.Dock = DockStyle.Left;
            groupBoxOutput_VKA.Location = new Point(0, 130);
            groupBoxOutput_VKA.Name = "groupBoxOutput_VKA";
            groupBoxOutput_VKA.Size = new Size(214, 331);
            groupBoxOutput_VKA.TabIndex = 3;
            groupBoxOutput_VKA.TabStop = false;
            groupBoxOutput_VKA.Text = "Вывод:";
            // 
            // textBoxOutput_VKA
            // 
            textBoxOutput_VKA.Dock = DockStyle.Left;
            textBoxOutput_VKA.Location = new Point(3, 19);
            textBoxOutput_VKA.Multiline = true;
            textBoxOutput_VKA.Name = "textBoxOutput_VKA";
            textBoxOutput_VKA.ReadOnly = true;
            textBoxOutput_VKA.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_VKA.Size = new Size(208, 309);
            textBoxOutput_VKA.TabIndex = 0;
            textBoxOutput_VKA.TextChanged += textBox2_TextChanged;
            // 
            // FormMain_VKA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(groupBoxOutput_VKA);
            Controls.Add(chartFunction_VKA);
            Controls.Add(groupBoxMain_VKA);
            MinimumSize = new Size(975, 400);
            Name = "FormMain_VKA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 10 | Войтович К.А.";
            groupBoxMain_VKA.ResumeLayout(false);
            groupBoxMain_VKA.PerformLayout();
            groupBoxCondition_VKA.ResumeLayout(false);
            groupBoxCondition_VKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VKA).EndInit();
            groupBoxInput_VKA.ResumeLayout(false);
            groupBoxInput_VKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VKA).EndInit();
            groupBoxOutput_VKA.ResumeLayout(false);
            groupBoxOutput_VKA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxMain_VKA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VKA;
        private PictureBox pictureBoxFormula_VKA;
        private TextBox textBox1;
        private GroupBox groupBoxOutput_VKA;
        private TextBox textBoxOutput_VKA;
        private Button buttonSave_VKA;
        private Button buttonAbout_VKA;
        private Label labelEnd_VKA;
        private TextBox textBoxEnd_VKA;
        private Button buttonExecute_VKA;
        private Label labelStart_VKA;
        private TextBox textBoxStart_VKA;
        private GroupBox groupBoxInput_VKA;
        private GroupBox groupBoxCondition_VKA;
    }
}
