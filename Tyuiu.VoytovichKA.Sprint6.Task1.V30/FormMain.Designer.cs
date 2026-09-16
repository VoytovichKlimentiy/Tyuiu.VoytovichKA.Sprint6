namespace Tyuiu.VoytovichKA.Sprint6.Task1.V30
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            richTextBoxCondition_VKA = new RichTextBox();
            groupBoxOutput_VKA = new GroupBox();
            labelRes_VKA = new Label();
            richTextBoxRes_VKA = new RichTextBox();
            groupBoxCondition_VKA = new GroupBox();
            pictureBoxFormula_VKA = new PictureBox();
            groupBoxInput_VKA = new GroupBox();
            labelEnd_VKA = new Label();
            textBoxEnd_VKA = new TextBox();
            labelStart_VKA = new Label();
            textBoxStart_VKA = new TextBox();
            buttonExecute = new Button();
            buttonAbout = new Button();
            groupBoxOutput_VKA.SuspendLayout();
            groupBoxCondition_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VKA).BeginInit();
            groupBoxInput_VKA.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxCondition_VKA
            // 
            richTextBoxCondition_VKA.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxCondition_VKA.Location = new Point(6, 31);
            richTextBoxCondition_VKA.Name = "richTextBoxCondition_VKA";
            richTextBoxCondition_VKA.ReadOnly = true;
            richTextBoxCondition_VKA.Size = new Size(421, 68);
            richTextBoxCondition_VKA.TabIndex = 1;
            richTextBoxCondition_VKA.Text = "Протабулировать функцию на заданном диапазоне.\nРезультат вывести в виде таблицы.\n\n";
            // 
            // groupBoxOutput_VKA
            // 
            groupBoxOutput_VKA.Controls.Add(labelRes_VKA);
            groupBoxOutput_VKA.Controls.Add(richTextBoxRes_VKA);
            groupBoxOutput_VKA.Location = new Point(451, 12);
            groupBoxOutput_VKA.Name = "groupBoxOutput_VKA";
            groupBoxOutput_VKA.Size = new Size(337, 365);
            groupBoxOutput_VKA.TabIndex = 7;
            groupBoxOutput_VKA.TabStop = false;
            groupBoxOutput_VKA.Text = "Вывод данных";
            groupBoxOutput_VKA.Enter += groupBoxOutput_VKA_Enter;
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
            // richTextBoxRes_VKA
            // 
            richTextBoxRes_VKA.BackColor = SystemColors.ScrollBar;
            richTextBoxRes_VKA.Font = new Font("Monospac821 BT", 9F);
            richTextBoxRes_VKA.Location = new Point(6, 47);
            richTextBoxRes_VKA.Name = "richTextBoxRes_VKA";
            richTextBoxRes_VKA.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBoxRes_VKA.Size = new Size(325, 312);
            richTextBoxRes_VKA.TabIndex = 0;
            richTextBoxRes_VKA.Text = "";
            // 
            // groupBoxCondition_VKA
            // 
            groupBoxCondition_VKA.Controls.Add(richTextBoxCondition_VKA);
            groupBoxCondition_VKA.Controls.Add(pictureBoxFormula_VKA);
            groupBoxCondition_VKA.Location = new Point(6, 12);
            groupBoxCondition_VKA.Name = "groupBoxCondition_VKA";
            groupBoxCondition_VKA.Size = new Size(433, 311);
            groupBoxCondition_VKA.TabIndex = 6;
            groupBoxCondition_VKA.TabStop = false;
            groupBoxCondition_VKA.Text = "Условие";
            // 
            // pictureBoxFormula_VKA
            // 
            pictureBoxFormula_VKA.Image = (Image)resources.GetObject("pictureBoxFormula_VKA.Image");
            pictureBoxFormula_VKA.Location = new Point(73, 131);
            pictureBoxFormula_VKA.Name = "pictureBoxFormula_VKA";
            pictureBoxFormula_VKA.Size = new Size(267, 50);
            pictureBoxFormula_VKA.TabIndex = 11;
            pictureBoxFormula_VKA.TabStop = false;
            // 
            // groupBoxInput_VKA
            // 
            groupBoxInput_VKA.Controls.Add(labelEnd_VKA);
            groupBoxInput_VKA.Controls.Add(textBoxEnd_VKA);
            groupBoxInput_VKA.Controls.Add(labelStart_VKA);
            groupBoxInput_VKA.Controls.Add(textBoxStart_VKA);
            groupBoxInput_VKA.Location = new Point(6, 329);
            groupBoxInput_VKA.Name = "groupBoxInput_VKA";
            groupBoxInput_VKA.Size = new Size(433, 109);
            groupBoxInput_VKA.TabIndex = 8;
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
            textBoxEnd_VKA.KeyPress += textBoxEnd_VKA_KeyPress_1;
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
            textBoxStart_VKA.KeyPress += textBoxStart_VKA_KeyPress;
            // 
            // buttonExecute
            // 
            buttonExecute.BackColor = Color.MediumSpringGreen;
            buttonExecute.Font = new Font("Segoe UI", 14F);
            buttonExecute.Location = new Point(512, 383);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(276, 55);
            buttonExecute.TabIndex = 10;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = false;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.SkyBlue;
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Font = new Font("Segoe UI", 14F);
            buttonAbout.Location = new Point(451, 383);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(55, 55);
            buttonAbout.TabIndex = 9;
            buttonAbout.Text = "?";
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutput_VKA);
            Controls.Add(groupBoxCondition_VKA);
            Controls.Add(groupBoxInput_VKA);
            Controls.Add(buttonExecute);
            Controls.Add(buttonAbout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 30 | Войтович К.А.";
            groupBoxOutput_VKA.ResumeLayout(false);
            groupBoxOutput_VKA.PerformLayout();
            groupBoxCondition_VKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VKA).EndInit();
            groupBoxInput_VKA.ResumeLayout(false);
            groupBoxInput_VKA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxCondition_VKA;
        private GroupBox groupBoxOutput_VKA;
        private GroupBox groupBoxCondition_VKA;
        private GroupBox groupBoxInput_VKA;
        private Label labelStart_VKA;
        private TextBox textBoxStart_VKA;
        private PictureBox pictureBoxFormula_VKA;
        private Button buttonExecute;
        private Button buttonAbout;
        private Label labelEnd_VKA;
        private TextBox textBoxEnd_VKA;
        private RichTextBox richTextBoxRes_VKA;
        private Label labelRes_VKA;
    }
}
