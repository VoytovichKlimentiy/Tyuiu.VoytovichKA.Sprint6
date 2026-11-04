namespace Tyuiu.VoytovichKA.Sprint6.Task5.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxOutput_VKA = new GroupBox();
            dataGridView_VKA = new DataGridView();
            groupBoxMain_VKA = new GroupBox();
            groupBoxCondition_VKA = new GroupBox();
            buttonOpen_VKA = new Button();
            buttonAbout_VKA = new Button();
            buttonExecute_VKA = new Button();
            textBox1 = new TextBox();
            chart_VKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutput_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_VKA).BeginInit();
            groupBoxMain_VKA.SuspendLayout();
            groupBoxCondition_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_VKA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOutput_VKA
            // 
            groupBoxOutput_VKA.AutoSize = true;
            groupBoxOutput_VKA.Controls.Add(dataGridView_VKA);
            groupBoxOutput_VKA.Dock = DockStyle.Left;
            groupBoxOutput_VKA.Location = new Point(0, 118);
            groupBoxOutput_VKA.Name = "groupBoxOutput_VKA";
            groupBoxOutput_VKA.Size = new Size(165, 448);
            groupBoxOutput_VKA.TabIndex = 5;
            groupBoxOutput_VKA.TabStop = false;
            groupBoxOutput_VKA.Text = "Вывод:";
            // 
            // dataGridView_VKA
            // 
            dataGridView_VKA.AllowUserToAddRows = false;
            dataGridView_VKA.AllowUserToDeleteRows = false;
            dataGridView_VKA.AllowUserToResizeColumns = false;
            dataGridView_VKA.AllowUserToResizeRows = false;
            dataGridView_VKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_VKA.Dock = DockStyle.Left;
            dataGridView_VKA.Location = new Point(3, 19);
            dataGridView_VKA.Name = "dataGridView_VKA";
            dataGridView_VKA.Size = new Size(159, 426);
            dataGridView_VKA.TabIndex = 0;
            // 
            // groupBoxMain_VKA
            // 
            groupBoxMain_VKA.AutoSize = true;
            groupBoxMain_VKA.Controls.Add(groupBoxCondition_VKA);
            groupBoxMain_VKA.Dock = DockStyle.Top;
            groupBoxMain_VKA.Location = new Point(0, 0);
            groupBoxMain_VKA.Name = "groupBoxMain_VKA";
            groupBoxMain_VKA.Size = new Size(842, 118);
            groupBoxMain_VKA.TabIndex = 4;
            groupBoxMain_VKA.TabStop = false;
            // 
            // groupBoxCondition_VKA
            // 
            groupBoxCondition_VKA.AutoSize = true;
            groupBoxCondition_VKA.Controls.Add(buttonOpen_VKA);
            groupBoxCondition_VKA.Controls.Add(buttonAbout_VKA);
            groupBoxCondition_VKA.Controls.Add(buttonExecute_VKA);
            groupBoxCondition_VKA.Controls.Add(textBox1);
            groupBoxCondition_VKA.Dock = DockStyle.Top;
            groupBoxCondition_VKA.Location = new Point(3, 19);
            groupBoxCondition_VKA.Name = "groupBoxCondition_VKA";
            groupBoxCondition_VKA.Size = new Size(836, 96);
            groupBoxCondition_VKA.TabIndex = 27;
            groupBoxCondition_VKA.TabStop = false;
            groupBoxCondition_VKA.Text = "Условие";
            // 
            // buttonOpen_VKA
            // 
            buttonOpen_VKA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_VKA.BackColor = Color.DodgerBlue;
            buttonOpen_VKA.Cursor = Cursors.Hand;
            buttonOpen_VKA.Font = new Font("Segoe UI", 12F);
            buttonOpen_VKA.Location = new Point(630, 19);
            buttonOpen_VKA.Name = "buttonOpen_VKA";
            buttonOpen_VKA.Size = new Size(99, 55);
            buttonOpen_VKA.TabIndex = 28;
            buttonOpen_VKA.Text = "Открыть файл";
            buttonOpen_VKA.UseVisualStyleBackColor = false;
            buttonOpen_VKA.Click += buttonOpen_VKA_Click;
            // 
            // buttonAbout_VKA
            // 
            buttonAbout_VKA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_VKA.BackColor = Color.SkyBlue;
            buttonAbout_VKA.Cursor = Cursors.Help;
            buttonAbout_VKA.FlatStyle = FlatStyle.Flat;
            buttonAbout_VKA.Font = new Font("Segoe UI", 10F);
            buttonAbout_VKA.Location = new Point(742, 19);
            buttonAbout_VKA.Name = "buttonAbout_VKA";
            buttonAbout_VKA.Size = new Size(85, 53);
            buttonAbout_VKA.TabIndex = 27;
            buttonAbout_VKA.Text = "Справка";
            buttonAbout_VKA.UseVisualStyleBackColor = false;
            buttonAbout_VKA.Click += buttonAbout_VKA_Click;
            // 
            // buttonExecute_VKA
            // 
            buttonExecute_VKA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExecute_VKA.BackColor = Color.MediumSpringGreen;
            buttonExecute_VKA.Cursor = Cursors.Hand;
            buttonExecute_VKA.Font = new Font("Segoe UI", 12F);
            buttonExecute_VKA.Location = new Point(518, 19);
            buttonExecute_VKA.Name = "buttonExecute_VKA";
            buttonExecute_VKA.Size = new Size(99, 55);
            buttonExecute_VKA.TabIndex = 26;
            buttonExecute_VKA.Text = "Выполнить";
            buttonExecute_VKA.UseVisualStyleBackColor = false;
            buttonExecute_VKA.Click += buttonExecute_VKA_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(404, 55);
            textBox1.TabIndex = 7;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V24.txt. Вывести в dataGridView все элементы, равные 0. Построить диаграмму по этим значениям.";
            // 
            // chart_VKA
            // 
            chartArea2.Name = "ChartArea1";
            chart_VKA.ChartAreas.Add(chartArea2);
            chart_VKA.Dock = DockStyle.Bottom;
            legend2.Name = "Legend1";
            chart_VKA.Legends.Add(legend2);
            chart_VKA.Location = new Point(165, 124);
            chart_VKA.Name = "chart_VKA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_VKA.Series.Add(series2);
            chart_VKA.Size = new Size(677, 442);
            chart_VKA.TabIndex = 6;
            chart_VKA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 566);
            Controls.Add(chart_VKA);
            Controls.Add(groupBoxOutput_VKA);
            Controls.Add(groupBoxMain_VKA);
            MinimumSize = new Size(800, 600);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 24 | Войтович К.А.";
            groupBoxOutput_VKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_VKA).EndInit();
            groupBoxMain_VKA.ResumeLayout(false);
            groupBoxMain_VKA.PerformLayout();
            groupBoxCondition_VKA.ResumeLayout(false);
            groupBoxCondition_VKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_VKA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxOutput_VKA;
        private GroupBox groupBoxMain_VKA;
        private GroupBox groupBoxCondition_VKA;
        private TextBox textBox1;
        private Button buttonOpen_VKA;
        private Button buttonAbout_VKA;
        private Button buttonExecute_VKA;
        private DataGridView dataGridView_VKA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_VKA;
    }
}
