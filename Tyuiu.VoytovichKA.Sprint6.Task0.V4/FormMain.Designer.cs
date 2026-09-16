namespace Tyuiu.VoytovichKA.Sprint6.Task0.V4
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
            groupBoxCondition_VKA = new GroupBox();
            richTextBoxCondition_VKA = new RichTextBox();
            groupBoxOutput_VKA = new GroupBox();
            textBoxOutput_VKA = new TextBox();
            groupBoxInput_VKA = new GroupBox();
            labelVarX_VKA = new Label();
            textBoxVarX_VKA = new TextBox();
            buttonAbout = new Button();
            buttonExecute = new Button();
            pictureBoxFormula_VKA = new PictureBox();
            groupBoxCondition_VKA.SuspendLayout();
            groupBoxOutput_VKA.SuspendLayout();
            groupBoxInput_VKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VKA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_VKA
            // 
            groupBoxCondition_VKA.Controls.Add(richTextBoxCondition_VKA);
            groupBoxCondition_VKA.Location = new Point(12, 12);
            groupBoxCondition_VKA.Name = "groupBoxCondition_VKA";
            groupBoxCondition_VKA.Size = new Size(433, 250);
            groupBoxCondition_VKA.TabIndex = 0;
            groupBoxCondition_VKA.TabStop = false;
            groupBoxCondition_VKA.Text = "Условие";
            groupBoxCondition_VKA.Enter += groupBox1_Enter;
            // 
            // richTextBoxCondition_VKA
            // 
            richTextBoxCondition_VKA.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxCondition_VKA.Location = new Point(6, 31);
            richTextBoxCondition_VKA.Name = "richTextBoxCondition_VKA";
            richTextBoxCondition_VKA.ReadOnly = true;
            richTextBoxCondition_VKA.Size = new Size(421, 213);
            richTextBoxCondition_VKA.TabIndex = 1;
            richTextBoxCondition_VKA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxOutput_VKA
            // 
            groupBoxOutput_VKA.Controls.Add(textBoxOutput_VKA);
            groupBoxOutput_VKA.Location = new Point(451, 268);
            groupBoxOutput_VKA.Name = "groupBoxOutput_VKA";
            groupBoxOutput_VKA.Size = new Size(337, 109);
            groupBoxOutput_VKA.TabIndex = 1;
            groupBoxOutput_VKA.TabStop = false;
            groupBoxOutput_VKA.Text = "Вывод данных";
            // 
            // textBoxOutput_VKA
            // 
            textBoxOutput_VKA.Location = new Point(6, 53);
            textBoxOutput_VKA.Name = "textBoxOutput_VKA";
            textBoxOutput_VKA.ReadOnly = true;
            textBoxOutput_VKA.Size = new Size(98, 23);
            textBoxOutput_VKA.TabIndex = 1;
            // 
            // groupBoxInput_VKA
            // 
            groupBoxInput_VKA.Controls.Add(labelVarX_VKA);
            groupBoxInput_VKA.Controls.Add(textBoxVarX_VKA);
            groupBoxInput_VKA.Location = new Point(12, 268);
            groupBoxInput_VKA.Name = "groupBoxInput_VKA";
            groupBoxInput_VKA.Size = new Size(433, 109);
            groupBoxInput_VKA.TabIndex = 2;
            groupBoxInput_VKA.TabStop = false;
            groupBoxInput_VKA.Text = "Ввод данных";
            groupBoxInput_VKA.Enter += groupBoxInput_Enter;
            // 
            // labelVarX_VKA
            // 
            labelVarX_VKA.AutoSize = true;
            labelVarX_VKA.Location = new Point(6, 35);
            labelVarX_VKA.Name = "labelVarX_VKA";
            labelVarX_VKA.Size = new Size(89, 15);
            labelVarX_VKA.TabIndex = 1;
            labelVarX_VKA.Text = "Переменная X:";
            labelVarX_VKA.Click += label1_Click;
            // 
            // textBoxVarX_VKA
            // 
            textBoxVarX_VKA.Location = new Point(6, 53);
            textBoxVarX_VKA.Name = "textBoxVarX_VKA";
            textBoxVarX_VKA.Size = new Size(98, 23);
            textBoxVarX_VKA.TabIndex = 0;
            textBoxVarX_VKA.TextChanged += textBoxVarX_VKA_TextChanged;
            textBoxVarX_VKA.KeyPress += textBoxVarX_VKA_KeyPress;
            // 
            // buttonAbout
            // 
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Font = new Font("Segoe UI", 14F);
            buttonAbout.Location = new Point(451, 383);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(55, 55);
            buttonAbout.TabIndex = 3;
            buttonAbout.Text = "?";
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonExecute
            // 
            buttonExecute.FlatStyle = FlatStyle.System;
            buttonExecute.Font = new Font("Segoe UI", 14F);
            buttonExecute.Location = new Point(512, 383);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(276, 55);
            buttonExecute.TabIndex = 4;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // pictureBoxFormula_VKA
            // 
            pictureBoxFormula_VKA.Image = Properties.Resources.Screenshot_2026_09_16_213916;
            pictureBoxFormula_VKA.Location = new Point(451, 123);
            pictureBoxFormula_VKA.Name = "pictureBoxFormula_VKA";
            pictureBoxFormula_VKA.Size = new Size(337, 50);
            pictureBoxFormula_VKA.TabIndex = 5;
            pictureBoxFormula_VKA.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxFormula_VKA);
            Controls.Add(buttonExecute);
            Controls.Add(buttonAbout);
            Controls.Add(groupBoxInput_VKA);
            Controls.Add(groupBoxOutput_VKA);
            Controls.Add(groupBoxCondition_VKA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 4 | Войтович К.А.";
            Load += FormMain_Load;
            groupBoxCondition_VKA.ResumeLayout(false);
            groupBoxOutput_VKA.ResumeLayout(false);
            groupBoxOutput_VKA.PerformLayout();
            groupBoxInput_VKA.ResumeLayout(false);
            groupBoxInput_VKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_VKA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_VKA;
        private GroupBox groupBoxOutput_VKA;
        private GroupBox groupBoxInput_VKA;
        private Button buttonAbout;
        private Button buttonExecute;
        private TextBox textBoxVarX_VKA;
        private RichTextBox richTextBoxCondition_VKA;
        private PictureBox pictureBoxFormula_VKA;
        private TextBox textBoxOutput_VKA;
        private Label labelVarX_VKA;
    }
}
