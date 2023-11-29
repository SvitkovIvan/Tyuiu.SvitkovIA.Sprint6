namespace Tyuiu.SvitkovIA.Sprint6.Task1.V19
{
    partial class FormMain
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
            this.textBoxResult_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxNamedOne_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxNameddOne_SIA = new System.Windows.Forms.TextBox();
            this.buttonNamedOne_SIA = new System.Windows.Forms.Button();
            this.buttonNamedTwo_SIA = new System.Windows.Forms.Button();
            this.groupBoxNameddOne_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_SIA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_SIA = new System.Windows.Forms.TextBox();
            this.textBoxNamedThree_SIA = new System.Windows.Forms.TextBox();
            this.textBoxNameedOne_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxNameedOne_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxNaamedOne_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxNamedOne_SIA.SuspendLayout();
            this.groupBoxNameddOne_SIA.SuspendLayout();
            this.groupBoxNameedOne_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxResult_SIA
            // 
            this.textBoxResult_SIA.Location = new System.Drawing.Point(6, 55);
            this.textBoxResult_SIA.Multiline = true;
            this.textBoxResult_SIA.Name = "textBoxResult_SIA";
            this.textBoxResult_SIA.ReadOnly = true;
            this.textBoxResult_SIA.Size = new System.Drawing.Size(284, 326);
            this.textBoxResult_SIA.TabIndex = 0;
            this.textBoxResult_SIA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxNamedOne_SIA
            // 
            this.groupBoxNamedOne_SIA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxNamedOne_SIA.Controls.Add(this.textBoxNameddOne_SIA);
            this.groupBoxNamedOne_SIA.Controls.Add(this.textBoxResult_SIA);
            this.groupBoxNamedOne_SIA.Location = new System.Drawing.Point(492, 23);
            this.groupBoxNamedOne_SIA.Name = "groupBoxNamedOne_SIA";
            this.groupBoxNamedOne_SIA.Size = new System.Drawing.Size(296, 387);
            this.groupBoxNamedOne_SIA.TabIndex = 1;
            this.groupBoxNamedOne_SIA.TabStop = false;
            this.groupBoxNamedOne_SIA.Text = "Вывод данных";
            this.groupBoxNamedOne_SIA.Enter += new System.EventHandler(this.groupBoxNamedOne_SIA_Enter);
            // 
            // textBoxNameddOne_SIA
            // 
            this.textBoxNameddOne_SIA.Location = new System.Drawing.Point(6, 27);
            this.textBoxNameddOne_SIA.Name = "textBoxNameddOne_SIA";
            this.textBoxNameddOne_SIA.Size = new System.Drawing.Size(83, 22);
            this.textBoxNameddOne_SIA.TabIndex = 1;
            this.textBoxNameddOne_SIA.Text = "Результат:";
            // 
            // buttonNamedOne_SIA
            // 
            this.buttonNamedOne_SIA.BackColor = System.Drawing.Color.Lime;
            this.buttonNamedOne_SIA.Location = new System.Drawing.Point(384, 325);
            this.buttonNamedOne_SIA.Name = "buttonNamedOne_SIA";
            this.buttonNamedOne_SIA.Size = new System.Drawing.Size(102, 73);
            this.buttonNamedOne_SIA.TabIndex = 2;
            this.buttonNamedOne_SIA.Text = "Выполнить";
            this.buttonNamedOne_SIA.UseVisualStyleBackColor = false;
            // 
            // buttonNamedTwo_SIA
            // 
            this.buttonNamedTwo_SIA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNamedTwo_SIA.Location = new System.Drawing.Point(271, 325);
            this.buttonNamedTwo_SIA.Name = "buttonNamedTwo_SIA";
            this.buttonNamedTwo_SIA.Size = new System.Drawing.Size(107, 73);
            this.buttonNamedTwo_SIA.TabIndex = 3;
            this.buttonNamedTwo_SIA.Text = "Справка";
            this.buttonNamedTwo_SIA.UseVisualStyleBackColor = false;
            // 
            // groupBoxNameddOne_SIA
            // 
            this.groupBoxNameddOne_SIA.Controls.Add(this.textBoxNameedOne_SIA);
            this.groupBoxNameddOne_SIA.Controls.Add(this.textBoxNamedThree_SIA);
            this.groupBoxNameddOne_SIA.Controls.Add(this.textBoxStopStep_SIA);
            this.groupBoxNameddOne_SIA.Controls.Add(this.textBoxStartStep_SIA);
            this.groupBoxNameddOne_SIA.Location = new System.Drawing.Point(12, 325);
            this.groupBoxNameddOne_SIA.Name = "groupBoxNameddOne_SIA";
            this.groupBoxNameddOne_SIA.Size = new System.Drawing.Size(253, 73);
            this.groupBoxNameddOne_SIA.TabIndex = 4;
            this.groupBoxNameddOne_SIA.TabStop = false;
            this.groupBoxNameddOne_SIA.Text = "Ввод данных:";
            // 
            // textBoxStartStep_SIA
            // 
            this.textBoxStartStep_SIA.Location = new System.Drawing.Point(13, 45);
            this.textBoxStartStep_SIA.Name = "textBoxStartStep_SIA";
            this.textBoxStartStep_SIA.ReadOnly = true;
            this.textBoxStartStep_SIA.Size = new System.Drawing.Size(114, 22);
            this.textBoxStartStep_SIA.TabIndex = 5;
            this.textBoxStartStep_SIA.Text = "-5";
            this.textBoxStartStep_SIA.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxStopStep_SIA
            // 
            this.textBoxStopStep_SIA.Location = new System.Drawing.Point(133, 45);
            this.textBoxStopStep_SIA.Name = "textBoxStopStep_SIA";
            this.textBoxStopStep_SIA.ReadOnly = true;
            this.textBoxStopStep_SIA.Size = new System.Drawing.Size(114, 22);
            this.textBoxStopStep_SIA.TabIndex = 6;
            this.textBoxStopStep_SIA.Text = "5";
            // 
            // textBoxNamedThree_SIA
            // 
            this.textBoxNamedThree_SIA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNamedThree_SIA.Location = new System.Drawing.Point(13, 21);
            this.textBoxNamedThree_SIA.Name = "textBoxNamedThree_SIA";
            this.textBoxNamedThree_SIA.Size = new System.Drawing.Size(85, 22);
            this.textBoxNamedThree_SIA.TabIndex = 5;
            this.textBoxNamedThree_SIA.Text = "Старт шага:";
            // 
            // textBoxNameedOne_SIA
            // 
            this.textBoxNameedOne_SIA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNameedOne_SIA.Location = new System.Drawing.Point(133, 21);
            this.textBoxNameedOne_SIA.Name = "textBoxNameedOne_SIA";
            this.textBoxNameedOne_SIA.Size = new System.Drawing.Size(114, 22);
            this.textBoxNameedOne_SIA.TabIndex = 6;
            this.textBoxNameedOne_SIA.Text = "Конец шага:";
            // 
            // groupBoxNameedOne_SIA
            // 
            this.groupBoxNameedOne_SIA.Controls.Add(this.textBoxNaamedOne_SIA);
            this.groupBoxNameedOne_SIA.Location = new System.Drawing.Point(10, 23);
            this.groupBoxNameedOne_SIA.Name = "groupBoxNameedOne_SIA";
            this.groupBoxNameedOne_SIA.Size = new System.Drawing.Size(474, 296);
            this.groupBoxNameedOne_SIA.TabIndex = 5;
            this.groupBoxNameedOne_SIA.TabStop = false;
            this.groupBoxNameedOne_SIA.Text = "Условие";
            // 
            // textBoxNaamedOne_SIA
            // 
            this.textBoxNaamedOne_SIA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNaamedOne_SIA.Location = new System.Drawing.Point(6, 21);
            this.textBoxNaamedOne_SIA.Multiline = true;
            this.textBoxNaamedOne_SIA.Name = "textBoxNaamedOne_SIA";
            this.textBoxNaamedOne_SIA.Size = new System.Drawing.Size(348, 56);
            this.textBoxNaamedOne_SIA.TabIndex = 0;
            this.textBoxNaamedOne_SIA.Text = "Протабулировать функцию (Cos(x)+(Cos(x)/x+2))-3*x) на заданном диапазоне.Результа" +
    "т вывести в таблице.";
            this.textBoxNaamedOne_SIA.TextChanged += new System.EventHandler(this.textBoxNaamedOne_SIA_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 426);
            this.Controls.Add(this.groupBoxNameedOne_SIA);
            this.Controls.Add(this.groupBoxNameddOne_SIA);
            this.Controls.Add(this.buttonNamedTwo_SIA);
            this.Controls.Add(this.buttonNamedOne_SIA);
            this.Controls.Add(this.groupBoxNamedOne_SIA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 19 | Свитков И. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxNamedOne_SIA.ResumeLayout(false);
            this.groupBoxNamedOne_SIA.PerformLayout();
            this.groupBoxNameddOne_SIA.ResumeLayout(false);
            this.groupBoxNameddOne_SIA.PerformLayout();
            this.groupBoxNameedOne_SIA.ResumeLayout(false);
            this.groupBoxNameedOne_SIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult_SIA;
        private System.Windows.Forms.GroupBox groupBoxNamedOne_SIA;
        private System.Windows.Forms.TextBox textBoxNameddOne_SIA;
        private System.Windows.Forms.Button buttonNamedOne_SIA;
        private System.Windows.Forms.Button buttonNamedTwo_SIA;
        private System.Windows.Forms.GroupBox groupBoxNameddOne_SIA;
        private System.Windows.Forms.TextBox textBoxStopStep_SIA;
        private System.Windows.Forms.TextBox textBoxStartStep_SIA;
        private System.Windows.Forms.TextBox textBoxNamedThree_SIA;
        private System.Windows.Forms.TextBox textBoxNameedOne_SIA;
        private System.Windows.Forms.GroupBox groupBoxNameedOne_SIA;
        private System.Windows.Forms.TextBox textBoxNaamedOne_SIA;
    }
}

