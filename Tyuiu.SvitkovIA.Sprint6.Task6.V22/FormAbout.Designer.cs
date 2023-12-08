namespace Tyuiu.SvitkovIA.Sprint6.Task6.V22
{
    partial class FormAbout_SIA
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
            this.pictureBoxNamed_SIA = new System.Windows.Forms.PictureBox();
            this.labelNamedInfo_SIA = new System.Windows.Forms.Label();
            this.buttonOK_SIA_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNamed_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNamed_SIA
            // 
            this.pictureBoxNamed_SIA.BackgroundImage = global::Tyuiu.SvitkovIA.Sprint6.Task6.V22.Properties.Resources.Разработчик;
            this.pictureBoxNamed_SIA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxNamed_SIA.Name = "pictureBoxNamed_SIA";
            this.pictureBoxNamed_SIA.Size = new System.Drawing.Size(461, 302);
            this.pictureBoxNamed_SIA.TabIndex = 0;
            this.pictureBoxNamed_SIA.TabStop = false;
            // 
            // labelNamedInfo_SIA
            // 
            this.labelNamedInfo_SIA.AutoSize = true;
            this.labelNamedInfo_SIA.Location = new System.Drawing.Point(491, 12);
            this.labelNamedInfo_SIA.Name = "labelNamedInfo_SIA";
            this.labelNamedInfo_SIA.Size = new System.Drawing.Size(358, 144);
            this.labelNamedInfo_SIA.TabIndex = 1;
            this.labelNamedInfo_SIA.Text = "Разработчик: Свитков И.А.\r\nГруппа АСОиУБ-23-2\r\n\r\nПрограмма разработана в рамках и" +
    "зучения языка C#\r\n\r\nТИУ (с) 2023\r\nВШЦТ (с) 2023\r\n\r\nВнутреннее имя : Tyuiu.Svitko" +
    "vIA.Sprint6.Task6.V22";
            // 
            // buttonOK_SIA_Click
            // 
            this.buttonOK_SIA_Click.Location = new System.Drawing.Point(774, 282);
            this.buttonOK_SIA_Click.Name = "buttonOK_SIA_Click";
            this.buttonOK_SIA_Click.Size = new System.Drawing.Size(89, 32);
            this.buttonOK_SIA_Click.TabIndex = 2;
            this.buttonOK_SIA_Click.Text = "ОК";
            this.buttonOK_SIA_Click.UseVisualStyleBackColor = true;
            this.buttonOK_SIA_Click.Click += new System.EventHandler(this.buttonOK_SIA_Click_Click);
            // 
            // FormAbout_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 340);
            this.Controls.Add(this.buttonOK_SIA_Click);
            this.Controls.Add(this.labelNamedInfo_SIA);
            this.Controls.Add(this.pictureBoxNamed_SIA);
            this.Name = "FormAbout_SIA";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNamed_SIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNamed_SIA;
        private System.Windows.Forms.Label labelNamedInfo_SIA;
        private System.Windows.Forms.Button buttonOK_SIA_Click;
    }
}