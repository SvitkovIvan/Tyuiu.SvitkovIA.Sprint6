namespace Tyuiu.SvitkovIA.Sprint6.Task7.V28
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
            this.pictureBoxAva_SIA = new System.Windows.Forms.PictureBox();
            this.labelAbout_SIA = new System.Windows.Forms.Label();
            this.buttonOK_SIA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAva_SIA
            // 
            this.pictureBoxAva_SIA.BackColor = System.Drawing.Color.White;
            this.pictureBoxAva_SIA.BackgroundImage = global::Tyuiu.SvitkovIA.Sprint6.Task7.V28.Properties.Resources.Разработчик;
            this.pictureBoxAva_SIA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAva_SIA.Name = "pictureBoxAva_SIA";
            this.pictureBoxAva_SIA.Size = new System.Drawing.Size(460, 397);
            this.pictureBoxAva_SIA.TabIndex = 0;
            this.pictureBoxAva_SIA.TabStop = false;
            // 
            // labelAbout_SIA
            // 
            this.labelAbout_SIA.AutoSize = true;
            this.labelAbout_SIA.Location = new System.Drawing.Point(493, 96);
            this.labelAbout_SIA.Name = "labelAbout_SIA";
            this.labelAbout_SIA.Size = new System.Drawing.Size(361, 144);
            this.labelAbout_SIA.TabIndex = 1;
            this.labelAbout_SIA.Text = "Разработчик: Свитков И.А.\r\nГруппа: АСОиУБ-23-2.\r\n\r\nПрограмма разработана в рамках" +
    " изучения языка C#.\r\n\r\nТИУ (с) 2023.\r\nВШЦТ (с) 2023.\r\n\r\nВнутреннее имя Tyuiu.Svi" +
    "tkovIA.Sprint6.Task7.V28";
            // 
            // buttonOK_SIA
            // 
            this.buttonOK_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOK_SIA.Location = new System.Drawing.Point(779, 357);
            this.buttonOK_SIA.Name = "buttonOK_SIA";
            this.buttonOK_SIA.Size = new System.Drawing.Size(103, 52);
            this.buttonOK_SIA.TabIndex = 2;
            this.buttonOK_SIA.Text = "ОК";
            this.buttonOK_SIA.UseVisualStyleBackColor = false;
            this.buttonOK_SIA.Click += new System.EventHandler(this.buttonOK_SIA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 428);
            this.Controls.Add(this.buttonOK_SIA);
            this.Controls.Add(this.labelAbout_SIA);
            this.Controls.Add(this.pictureBoxAva_SIA);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_SIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAva_SIA;
        private System.Windows.Forms.Label labelAbout_SIA;
        private System.Windows.Forms.Button buttonOK_SIA;
    }
}