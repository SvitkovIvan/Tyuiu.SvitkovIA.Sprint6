﻿namespace Tyuiu.SvitkovIA.Sprint6.Task4.V29
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
            this.chartNamedГрафик_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxNamedУсловие_SIA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNamedОписание_SIA = new System.Windows.Forms.Label();
            this.groupBoxNamedВвод_SIA = new System.Windows.Forms.GroupBox();
            this.labelNamedStart_SIA = new System.Windows.Forms.Label();
            this.labelNamedStop_SIA = new System.Windows.Forms.Label();
            this.textBoxСтарт_SIA = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNamedDone_SIA = new System.Windows.Forms.Button();
            this.buttonNamedSave_SIA = new System.Windows.Forms.Button();
            this.buttonNamedInfo_SIA = new System.Windows.Forms.Button();
            this.textBoxDataOutPut_SIA = new System.Windows.Forms.TextBox();
            this.labelNamedВывод_SIA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartNamedГрафик_SIA)).BeginInit();
            this.groupBoxNamedУсловие_SIA.SuspendLayout();
            this.groupBoxNamedВвод_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartNamedГрафик_SIA
            // 
            this.chartNamedГрафик_SIA.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chartNamedГрафик_SIA.ChartAreas.Add(chartArea1);
            this.chartNamedГрафик_SIA.Location = new System.Drawing.Point(520, 95);
            this.chartNamedГрафик_SIA.Name = "chartNamedГрафик_SIA";
            this.chartNamedГрафик_SIA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chartNamedГрафик_SIA.Series.Add(series1);
            this.chartNamedГрафик_SIA.Size = new System.Drawing.Size(626, 296);
            this.chartNamedГрафик_SIA.TabIndex = 0;
            this.chartNamedГрафик_SIA.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции ((2*x-3)/((Math.Cos(x)-2*x)) + 5*x-6)";
            this.chartNamedГрафик_SIA.Titles.Add(title1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // groupBoxNamedВвод_SIA
            // 
            this.groupBoxNamedВвод_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBoxNamedВвод_SIA.Controls.Add(this.textBox1);
            this.groupBoxNamedВвод_SIA.Controls.Add(this.textBoxСтарт_SIA);
            this.groupBoxNamedВвод_SIA.Controls.Add(this.labelNamedStop_SIA);
            this.groupBoxNamedВвод_SIA.Controls.Add(this.labelNamedStart_SIA);
            this.groupBoxNamedВвод_SIA.Location = new System.Drawing.Point(520, 12);
            this.groupBoxNamedВвод_SIA.Name = "groupBoxNamedВвод_SIA";
            this.groupBoxNamedВвод_SIA.Size = new System.Drawing.Size(246, 77);
            this.groupBoxNamedВвод_SIA.TabIndex = 2;
            this.groupBoxNamedВвод_SIA.TabStop = false;
            this.groupBoxNamedВвод_SIA.Text = "Ввод данных";
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
            // labelNamedStop_SIA
            // 
            this.labelNamedStop_SIA.AutoSize = true;
            this.labelNamedStop_SIA.Location = new System.Drawing.Point(146, 28);
            this.labelNamedStop_SIA.Name = "labelNamedStop_SIA";
            this.labelNamedStop_SIA.Size = new System.Drawing.Size(84, 16);
            this.labelNamedStop_SIA.TabIndex = 3;
            this.labelNamedStop_SIA.Text = "Конец шага:";
            // 
            // textBoxСтарт_SIA
            // 
            this.textBoxСтарт_SIA.Location = new System.Drawing.Point(16, 47);
            this.textBoxСтарт_SIA.Name = "textBoxСтарт_SIA";
            this.textBoxСтарт_SIA.ReadOnly = true;
            this.textBoxСтарт_SIA.Size = new System.Drawing.Size(80, 22);
            this.textBoxСтарт_SIA.TabIndex = 3;
            this.textBoxСтарт_SIA.Text = "-5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(81, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "5";
            // 
            // buttonNamedDone_SIA
            // 
            this.buttonNamedDone_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonNamedDone_SIA.Location = new System.Drawing.Point(784, 12);
            this.buttonNamedDone_SIA.Name = "buttonNamedDone_SIA";
            this.buttonNamedDone_SIA.Size = new System.Drawing.Size(111, 77);
            this.buttonNamedDone_SIA.TabIndex = 3;
            this.buttonNamedDone_SIA.Text = "Выполнить";
            this.buttonNamedDone_SIA.UseVisualStyleBackColor = false;
            // 
            // buttonNamedSave_SIA
            // 
            this.buttonNamedSave_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonNamedSave_SIA.Location = new System.Drawing.Point(901, 12);
            this.buttonNamedSave_SIA.Name = "buttonNamedSave_SIA";
            this.buttonNamedSave_SIA.Size = new System.Drawing.Size(116, 77);
            this.buttonNamedSave_SIA.TabIndex = 4;
            this.buttonNamedSave_SIA.Text = "Сохранить";
            this.buttonNamedSave_SIA.UseVisualStyleBackColor = false;
            // 
            // buttonNamedInfo_SIA
            // 
            this.buttonNamedInfo_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNamedInfo_SIA.Location = new System.Drawing.Point(1033, 12);
            this.buttonNamedInfo_SIA.Name = "buttonNamedInfo_SIA";
            this.buttonNamedInfo_SIA.Size = new System.Drawing.Size(113, 77);
            this.buttonNamedInfo_SIA.TabIndex = 5;
            this.buttonNamedInfo_SIA.Text = "Справка";
            this.buttonNamedInfo_SIA.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.buttonNamedInfo_SIA);
            this.Controls.Add(this.buttonNamedSave_SIA);
            this.Controls.Add(this.buttonNamedDone_SIA);
            this.Controls.Add(this.groupBoxNamedВвод_SIA);
            this.Controls.Add(this.groupBoxNamedУсловие_SIA);
            this.Controls.Add(this.chartNamedГрафик_SIA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMainNamed_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 29 | Свитков И. А.";
            ((System.ComponentModel.ISupportInitialize)(this.chartNamedГрафик_SIA)).EndInit();
            this.groupBoxNamedУсловие_SIA.ResumeLayout(false);
            this.groupBoxNamedУсловие_SIA.PerformLayout();
            this.groupBoxNamedВвод_SIA.ResumeLayout(false);
            this.groupBoxNamedВвод_SIA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartNamedГрафик_SIA;
        private System.Windows.Forms.GroupBox groupBoxNamedУсловие_SIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNamedОписание_SIA;
        private System.Windows.Forms.GroupBox groupBoxNamedВвод_SIA;
        private System.Windows.Forms.TextBox textBoxСтарт_SIA;
        private System.Windows.Forms.Label labelNamedStop_SIA;
        private System.Windows.Forms.Label labelNamedStart_SIA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNamedDone_SIA;
        private System.Windows.Forms.Button buttonNamedSave_SIA;
        private System.Windows.Forms.Button buttonNamedInfo_SIA;
        private System.Windows.Forms.TextBox textBoxDataOutPut_SIA;
        private System.Windows.Forms.Label labelNamedВывод_SIA;
    }
}
