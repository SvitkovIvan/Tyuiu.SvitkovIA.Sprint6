namespace Tyuiu.SvitkovIA.Sprint6.Task4.V29
{
    partial class FormMainNamed_SIA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartFunctionn_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxNamedУсловие_SIA = new System.Windows.Forms.GroupBox();
            this.labelNamedОписание_SIA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxNamedВвод_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SIA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SIA = new System.Windows.Forms.TextBox();
            this.labelNamedStop_SIA = new System.Windows.Forms.Label();
            this.labelNamedStart_SIA = new System.Windows.Forms.Label();
            this.buttonNamedDones_SIA = new System.Windows.Forms.Button();
            this.buttonNamedSaves_SIA = new System.Windows.Forms.Button();
            this.buttonNamedInform_SIA = new System.Windows.Forms.Button();
            this.textBoxDataOutPut_SIA = new System.Windows.Forms.TextBox();
            this.labelNamedВывод_SIA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionn_SIA)).BeginInit();
            this.groupBoxNamedУсловие_SIA.SuspendLayout();
            this.groupBoxNamedВвод_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFunctionn_SIA
            // 
            this.chartFunctionn_SIA.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chartFunctionn_SIA.ChartAreas.Add(chartArea1);
            this.chartFunctionn_SIA.Location = new System.Drawing.Point(520, 95);
            this.chartFunctionn_SIA.Name = "chartFunctionn_SIA";
            this.chartFunctionn_SIA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chartFunctionn_SIA.Series.Add(series1);
            this.chartFunctionn_SIA.Size = new System.Drawing.Size(626, 296);
            this.chartFunctionn_SIA.TabIndex = 0;
            this.chartFunctionn_SIA.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции ((2*x-3)/((Math.Cos(x)-2*x)) + 5*x-6)";
            this.chartFunctionn_SIA.Titles.Add(title1);
            // 
            // groupBoxNamedУсловие_SIA
            // 
            this.groupBoxNamedУсловие_SIA.BackColor = System.Drawing.Color.Yellow;
            this.groupBoxNamedУсловие_SIA.Controls.Add(this.labelNamedОписание_SIA);
            this.groupBoxNamedУсловие_SIA.Controls.Add(this.label1);
            this.groupBoxNamedУсловие_SIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNamedУсловие_SIA.Name = "groupBoxNamedУсловие_SIA";
            this.groupBoxNamedУсловие_SIA.Size = new System.Drawing.Size(488, 77);
            this.groupBoxNamedУсловие_SIA.TabIndex = 1;
            this.groupBoxNamedУсловие_SIA.TabStop = false;
            this.groupBoxNamedУсловие_SIA.Text = "Условие";
            // 
            // labelNamedОписание_SIA
            // 
            this.labelNamedОписание_SIA.AutoSize = true;
            this.labelNamedОписание_SIA.Location = new System.Drawing.Point(12, 18);
            this.labelNamedОписание_SIA.Name = "labelNamedОписание_SIA";
            this.labelNamedОписание_SIA.Size = new System.Drawing.Size(459, 48);
            this.labelNamedОписание_SIA.TabIndex = 3;
            this.labelNamedОписание_SIA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить\r\nв файл OutPutFileTask4V29.txt по на" +
    "жатию кнопки.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxNamedВвод_SIA
            // 
            this.groupBoxNamedВвод_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBoxNamedВвод_SIA.Controls.Add(this.textBoxStop_SIA);
            this.groupBoxNamedВвод_SIA.Controls.Add(this.textBoxStart_SIA);
            this.groupBoxNamedВвод_SIA.Controls.Add(this.labelNamedStop_SIA);
            this.groupBoxNamedВвод_SIA.Controls.Add(this.labelNamedStart_SIA);
            this.groupBoxNamedВвод_SIA.Location = new System.Drawing.Point(520, 12);
            this.groupBoxNamedВвод_SIA.Name = "groupBoxNamedВвод_SIA";
            this.groupBoxNamedВвод_SIA.Size = new System.Drawing.Size(246, 77);
            this.groupBoxNamedВвод_SIA.TabIndex = 2;
            this.groupBoxNamedВвод_SIA.TabStop = false;
            this.groupBoxNamedВвод_SIA.Text = "Ввод данных";
            // 
            // textBoxStop_SIA
            // 
            this.textBoxStop_SIA.Location = new System.Drawing.Point(149, 47);
            this.textBoxStop_SIA.Name = "textBoxStop_SIA";
            this.textBoxStop_SIA.Size = new System.Drawing.Size(81, 22);
            this.textBoxStop_SIA.TabIndex = 4;
            this.textBoxStop_SIA.Text = "5";
            // 
            // textBoxStart_SIA
            // 
            this.textBoxStart_SIA.Location = new System.Drawing.Point(16, 47);
            this.textBoxStart_SIA.Name = "textBoxStart_SIA";
            this.textBoxStart_SIA.Size = new System.Drawing.Size(80, 22);
            this.textBoxStart_SIA.TabIndex = 3;
            this.textBoxStart_SIA.Text = "-5";
            // 
            // labelNamedStop_SIA
            // 
            this.labelNamedStop_SIA.AutoSize = true;
            this.labelNamedStop_SIA.Location = new System.Drawing.Point(146, 28);
            this.labelNamedStop_SIA.Name = "labelNamedStop_SIA";
            this.labelNamedStop_SIA.Size = new System.Drawing.Size(84, 16);
            this.labelNamedStop_SIA.TabIndex = 3;
            this.labelNamedStop_SIA.Text = "Конец шага:";
            // 
            // labelNamedStart_SIA
            // 
            this.labelNamedStart_SIA.AutoSize = true;
            this.labelNamedStart_SIA.Location = new System.Drawing.Point(13, 28);
            this.labelNamedStart_SIA.Name = "labelNamedStart_SIA";
            this.labelNamedStart_SIA.Size = new System.Drawing.Size(83, 16);
            this.labelNamedStart_SIA.TabIndex = 0;
            this.labelNamedStart_SIA.Text = "Старт шага:";
            // 
            // buttonNamedDones_SIA
            // 
            this.buttonNamedDones_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonNamedDones_SIA.Location = new System.Drawing.Point(784, 12);
            this.buttonNamedDones_SIA.Name = "buttonNamedDones_SIA";
            this.buttonNamedDones_SIA.Size = new System.Drawing.Size(111, 77);
            this.buttonNamedDones_SIA.TabIndex = 3;
            this.buttonNamedDones_SIA.Text = "Выполнить";
            this.buttonNamedDones_SIA.UseVisualStyleBackColor = false;
            this.buttonNamedDones_SIA.Click += new System.EventHandler(this.buttonNamedDones_SIA_Click);
            // 
            // buttonNamedSaves_SIA
            // 
            this.buttonNamedSaves_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonNamedSaves_SIA.Location = new System.Drawing.Point(901, 12);
            this.buttonNamedSaves_SIA.Name = "buttonNamedSaves_SIA";
            this.buttonNamedSaves_SIA.Size = new System.Drawing.Size(116, 77);
            this.buttonNamedSaves_SIA.TabIndex = 4;
            this.buttonNamedSaves_SIA.Text = "Сохранить";
            this.buttonNamedSaves_SIA.UseVisualStyleBackColor = false;
            this.buttonNamedSaves_SIA.Click += new System.EventHandler(this.buttonNamedSaves_SIA_Click);
            // 
            // buttonNamedInform_SIA
            // 
            this.buttonNamedInform_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNamedInform_SIA.Location = new System.Drawing.Point(1033, 12);
            this.buttonNamedInform_SIA.Name = "buttonNamedInform_SIA";
            this.buttonNamedInform_SIA.Size = new System.Drawing.Size(113, 77);
            this.buttonNamedInform_SIA.TabIndex = 5;
            this.buttonNamedInform_SIA.Text = "Справка";
            this.buttonNamedInform_SIA.UseVisualStyleBackColor = false;
            this.buttonNamedInform_SIA.Click += new System.EventHandler(this.buttonNamedInform_SIA_Click);
            // 
            // textBoxDataOutPut_SIA
            // 
            this.textBoxDataOutPut_SIA.Location = new System.Drawing.Point(12, 107);
            this.textBoxDataOutPut_SIA.Multiline = true;
            this.textBoxDataOutPut_SIA.Name = "textBoxDataOutPut_SIA";
            this.textBoxDataOutPut_SIA.Size = new System.Drawing.Size(488, 284);
            this.textBoxDataOutPut_SIA.TabIndex = 6;
            // 
            // labelNamedВывод_SIA
            // 
            this.labelNamedВывод_SIA.AutoSize = true;
            this.labelNamedВывод_SIA.Location = new System.Drawing.Point(18, 88);
            this.labelNamedВывод_SIA.Name = "labelNamedВывод_SIA";
            this.labelNamedВывод_SIA.Size = new System.Drawing.Size(52, 16);
            this.labelNamedВывод_SIA.TabIndex = 7;
            this.labelNamedВывод_SIA.Text = "Вывод:";
            // 
            // FormMainNamed_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 403);
            this.Controls.Add(this.labelNamedВывод_SIA);
            this.Controls.Add(this.textBoxDataOutPut_SIA);
            this.Controls.Add(this.buttonNamedInform_SIA);
            this.Controls.Add(this.buttonNamedSaves_SIA);
            this.Controls.Add(this.buttonNamedDones_SIA);
            this.Controls.Add(this.groupBoxNamedВвод_SIA);
            this.Controls.Add(this.groupBoxNamedУсловие_SIA);
            this.Controls.Add(this.chartFunctionn_SIA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMainNamed_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 29 | Свитков И. А.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionn_SIA)).EndInit();
            this.groupBoxNamedУсловие_SIA.ResumeLayout(false);
            this.groupBoxNamedУсловие_SIA.PerformLayout();
            this.groupBoxNamedВвод_SIA.ResumeLayout(false);
            this.groupBoxNamedВвод_SIA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctionn_SIA;
        private System.Windows.Forms.GroupBox groupBoxNamedУсловие_SIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNamedОписание_SIA;
        private System.Windows.Forms.GroupBox groupBoxNamedВвод_SIA;
        private System.Windows.Forms.TextBox textBoxStart_SIA;
        private System.Windows.Forms.Label labelNamedStop_SIA;
        private System.Windows.Forms.Label labelNamedStart_SIA;
        private System.Windows.Forms.TextBox textBoxStop_SIA;
        private System.Windows.Forms.Button buttonNamedDones_SIA;
        private System.Windows.Forms.Button buttonNamedSaves_SIA;
        private System.Windows.Forms.Button buttonNamedInform_SIA;
        private System.Windows.Forms.TextBox textBoxDataOutPut_SIA;
        private System.Windows.Forms.Label labelNamedВывод_SIA;
    }
}

