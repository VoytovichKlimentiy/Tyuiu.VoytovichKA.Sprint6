namespace Tyuiu.VoytovichKA.Sprint6.Task7.V20
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonAboutOK_VKA = new Button();
            textBoxAbout_VKA = new TextBox();
            pictureBoxAbout_VKA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_VKA).BeginInit();
            SuspendLayout();
            // 
            // buttonAboutOK_VKA
            // 
            buttonAboutOK_VKA.Location = new Point(375, 179);
            buttonAboutOK_VKA.Name = "buttonAboutOK_VKA";
            buttonAboutOK_VKA.Size = new Size(103, 23);
            buttonAboutOK_VKA.TabIndex = 0;
            buttonAboutOK_VKA.Text = "ОК";
            buttonAboutOK_VKA.UseVisualStyleBackColor = true;
            buttonAboutOK_VKA.Click += buttonAboutOK_VKA_Click;
            // 
            // textBoxAbout_VKA
            // 
            textBoxAbout_VKA.Location = new Point(165, 22);
            textBoxAbout_VKA.Multiline = true;
            textBoxAbout_VKA.Name = "textBoxAbout_VKA";
            textBoxAbout_VKA.ReadOnly = true;
            textBoxAbout_VKA.Size = new Size(313, 151);
            textBoxAbout_VKA.TabIndex = 1;
            textBoxAbout_VKA.Text = resources.GetString("textBoxAbout_VKA.Text");
            // 
            // pictureBoxAbout_VKA
            // 
            pictureBoxAbout_VKA.Image = Task7.V20.Properties.Resources.iconPerson;
            pictureBoxAbout_VKA.Location = new Point(12, 22);
            pictureBoxAbout_VKA.Name = "pictureBoxAbout_VKA";
            pictureBoxAbout_VKA.Size = new Size(147, 177);
            pictureBoxAbout_VKA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAbout_VKA.TabIndex = 2;
            pictureBoxAbout_VKA.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 211);
            ControlBox = false;
            Controls.Add(pictureBoxAbout_VKA);
            Controls.Add(textBoxAbout_VKA);
            Controls.Add(buttonAboutOK_VKA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_VKA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAboutOK_VKA;
        private TextBox textBoxAbout_VKA;
        private PictureBox pictureBoxAbout_VKA;
    }
}