﻿namespace Tyuiu.SvitkovIA.Sprint6.Task2.V30
{
    partial class FormMain_SIA
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxNamedУсловие_SIA = new System.Windows.Forms.GroupBox();
            this.labelNamedТекстусловия_SIA = new System.Windows.Forms.Label();
            this.groupBoxNamedВводданных_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxNamedStart_SIA = new System.Windows.Forms.TextBox();
            this.textBoxNamedStop_SIA = new System.Windows.Forms.TextBox();
            this.labelNamedСтарт_SIA = new System.Windows.Forms.Label();
            this.labelNamedКонец_SIA = new System.Windows.Forms.Label();
            this.buttonNamedСправка_SIA = new System.Windows.Forms.Button();
            this.buttonNamedВыполнить_SIA = new System.Windows.Forms.Button();
            this.groupBoxNamedВыводДанных_SIA = new System.Windows.Forms.GroupBox();
            this.labelNamedРезультат_SIA = new System.Windows.Forms.Label();
            this.dataGridViewNamedТабулирование_SIA = new System.Windows.Forms.DataGridView();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxNamedУсловие_SIA.SuspendLayout();
            this.groupBoxNamedВводданных_SIA.SuspendLayout();
            this.groupBoxNamedВыводДанных_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNamedТабулирование_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNamedУсловие_SIA
            // 
            this.groupBoxNamedУсловие_SIA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxNamedУсловие_SIA.Controls.Add(this.labelNamedТекстусловия_SIA);
            this.groupBoxNamedУсловие_SIA.Location = new System.Drawing.Point(12, 30);
            this.groupBoxNamedУсловие_SIA.Name = "groupBoxNamedУсловие_SIA";
            this.groupBoxNamedУсловие_SIA.Size = new System.Drawing.Size(573, 306);
            this.groupBoxNamedУсловие_SIA.TabIndex = 0;
            this.groupBoxNamedУсловие_SIA.TabStop = false;
            this.groupBoxNamedУсловие_SIA.Text = "Условие";
            // 
            // labelNamedТекстусловия_SIA
            // 
            this.labelNamedТекстусловия_SIA.AutoSize = true;
            this.labelNamedТекстусловия_SIA.Location = new System.Drawing.Point(3, 18);
            this.labelNamedТекстусловия_SIA.Name = "labelNamedТекстусловия_SIA";
            this.labelNamedТекстусловия_SIA.Size = new System.Drawing.Size(556, 16);
            this.labelNamedТекстусловия_SIA.TabIndex = 0;
            this.labelNamedТекстусловия_SIA.Text = "Протабулировать функцию на заданном промежутке и построить график функции.";
            this.labelNamedТекстусловия_SIA.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxNamedВводданных_SIA
            // 
            this.groupBoxNamedВводданных_SIA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxNamedВводданных_SIA.Controls.Add(this.labelNamedКонец_SIA);
            this.groupBoxNamedВводданных_SIA.Controls.Add(this.labelNamedСтарт_SIA);
            this.groupBoxNamedВводданных_SIA.Controls.Add(this.textBoxNamedStop_SIA);
            this.groupBoxNamedВводданных_SIA.Controls.Add(this.textBoxNamedStart_SIA);
            this.groupBoxNamedВводданных_SIA.Location = new System.Drawing.Point(12, 353);
            this.groupBoxNamedВводданных_SIA.Name = "groupBoxNamedВводданных_SIA";
            this.groupBoxNamedВводданных_SIA.Size = new System.Drawing.Size(332, 86);
            this.groupBoxNamedВводданных_SIA.TabIndex = 1;
            this.groupBoxNamedВводданных_SIA.TabStop = false;
            this.groupBoxNamedВводданных_SIA.Text = "Ввод данных";
            // 
            // textBoxNamedStart_SIA
            // 
            this.textBoxNamedStart_SIA.Location = new System.Drawing.Point(6, 49);
            this.textBoxNamedStart_SIA.Name = "textBoxNamedStart_SIA";
            this.textBoxNamedStart_SIA.Size = new System.Drawing.Size(124, 22);
            this.textBoxNamedStart_SIA.TabIndex = 0;
            this.textBoxNamedStart_SIA.Text = "-5";
            // 
            // textBoxNamedStop_SIA
            // 
            this.textBoxNamedStop_SIA.Location = new System.Drawing.Point(210, 49);
            this.textBoxNamedStop_SIA.Name = "textBoxNamedStop_SIA";
            this.textBoxNamedStop_SIA.Size = new System.Drawing.Size(120, 22);
            this.textBoxNamedStop_SIA.TabIndex = 2;
            this.textBoxNamedStop_SIA.Text = "5";
            this.textBoxNamedStop_SIA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelNamedСтарт_SIA
            // 
            this.labelNamedСтарт_SIA.AutoSize = true;
            this.labelNamedСтарт_SIA.Location = new System.Drawing.Point(6, 30);
            this.labelNamedСтарт_SIA.Name = "labelNamedСтарт_SIA";
            this.labelNamedСтарт_SIA.Size = new System.Drawing.Size(83, 16);
            this.labelNamedСтарт_SIA.TabIndex = 2;
            this.labelNamedСтарт_SIA.Text = "Старт шага:";
            this.labelNamedСтарт_SIA.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelNamedКонец_SIA
            // 
            this.labelNamedКонец_SIA.AutoSize = true;
            this.labelNamedКонец_SIA.Location = new System.Drawing.Point(207, 30);
            this.labelNamedКонец_SIA.Name = "labelNamedКонец_SIA";
            this.labelNamedКонец_SIA.Size = new System.Drawing.Size(84, 16);
            this.labelNamedКонец_SIA.TabIndex = 2;
            this.labelNamedКонец_SIA.Text = "Конец шага:";
            // 
            // buttonNamedСправка_SIA
            // 
            this.buttonNamedСправка_SIA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonNamedСправка_SIA.Location = new System.Drawing.Point(350, 353);
            this.buttonNamedСправка_SIA.Name = "buttonNamedСправка_SIA";
            this.buttonNamedСправка_SIA.Size = new System.Drawing.Size(97, 86);
            this.buttonNamedСправка_SIA.TabIndex = 2;
            this.buttonNamedСправка_SIA.Text = "Справка";
            this.buttonNamedСправка_SIA.UseVisualStyleBackColor = false;
            // 
            // buttonNamedВыполнить_SIA
            // 
            this.buttonNamedВыполнить_SIA.BackColor = System.Drawing.Color.Lime;
            this.buttonNamedВыполнить_SIA.Location = new System.Drawing.Point(453, 353);
            this.buttonNamedВыполнить_SIA.Name = "buttonNamedВыполнить_SIA";
            this.buttonNamedВыполнить_SIA.Size = new System.Drawing.Size(132, 85);
            this.buttonNamedВыполнить_SIA.TabIndex = 3;
            this.buttonNamedВыполнить_SIA.Text = "Выполнить";
            this.buttonNamedВыполнить_SIA.UseVisualStyleBackColor = false;
            // 
            // groupBoxNamedВыводДанных_SIA
            // 
            this.groupBoxNamedВыводДанных_SIA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxNamedВыводДанных_SIA.Controls.Add(this.chart1);
            this.groupBoxNamedВыводДанных_SIA.Controls.Add(this.dataGridViewNamedТабулирование_SIA);
            this.groupBoxNamedВыводДанных_SIA.Controls.Add(this.labelNamedРезультат_SIA);
            this.groupBoxNamedВыводДанных_SIA.Location = new System.Drawing.Point(596, 30);
            this.groupBoxNamedВыводДанных_SIA.Name = "groupBoxNamedВыводДанных_SIA";
            this.groupBoxNamedВыводДанных_SIA.Size = new System.Drawing.Size(484, 408);
            this.groupBoxNamedВыводДанных_SIA.TabIndex = 4;
            this.groupBoxNamedВыводДанных_SIA.TabStop = false;
            this.groupBoxNamedВыводДанных_SIA.Text = "Вывод данных";
            // 
            // labelNamedРезультат_SIA
            // 
            this.labelNamedРезультат_SIA.AutoSize = true;
            this.labelNamedРезультат_SIA.Location = new System.Drawing.Point(6, 29);
            this.labelNamedРезультат_SIA.Name = "labelNamedРезультат_SIA";
            this.labelNamedРезультат_SIA.Size = new System.Drawing.Size(80, 16);
            this.labelNamedРезультат_SIA.TabIndex = 0;
            this.labelNamedРезультат_SIA.Text = "Результат:";
            // 
            // dataGridViewNamedТабулирование_SIA
            // 
            this.dataGridViewNamedТабулирование_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNamedТабулирование_SIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F,
            this.X});
            this.dataGridViewNamedТабулирование_SIA.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewNamedТабулирование_SIA.Name = "dataGridViewNamedТабулирование_SIA";
            this.dataGridViewNamedТабулирование_SIA.RowHeadersVisible = false;
            this.dataGridViewNamedТабулирование_SIA.RowHeadersWidth = 51;
            this.dataGridViewNamedТабулирование_SIA.RowTemplate.Height = 24;
            this.dataGridViewNamedТабулирование_SIA.Size = new System.Drawing.Size(142, 346);
            this.dataGridViewNamedТабулирование_SIA.TabIndex = 1;
            this.dataGridViewNamedТабулирование_SIA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNamedТабулирование_SIA_CellContentClick);
            // 
            // F
            // 
            this.F.HeaderText = "X";
            this.F.Name = "F";
            this.F.Width = 50;
            // 
            // X
            // 
            this.X.HeaderText = "F(X)";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(178, 48);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTimeOffset;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(290, 346);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // FormMain_SIA
            // 
            this.ClientSize = new System.Drawing.Size(1150, 462);
            this.Controls.Add(this.groupBoxNamedВыводДанных_SIA);
            this.Controls.Add(this.buttonNamedВыполнить_SIA);
            this.Controls.Add(this.buttonNamedСправка_SIA);
            this.Controls.Add(this.groupBoxNamedВводданных_SIA);
            this.Controls.Add(this.groupBoxNamedУсловие_SIA);
            this.Name = "FormMain_SIA";
            this.Text = "Спринт 6 | Таск 2 | Вариант 30 | Свитков И. А.";
            this.groupBoxNamedУсловие_SIA.ResumeLayout(false);
            this.groupBoxNamedУсловие_SIA.PerformLayout();
            this.groupBoxNamedВводданных_SIA.ResumeLayout(false);
            this.groupBoxNamedВводданных_SIA.PerformLayout();
            this.groupBoxNamedВыводДанных_SIA.ResumeLayout(false);
            this.groupBoxNamedВыводДанных_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNamedТабулирование_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxNamedУсловие_SIA;
        private System.Windows.Forms.Label labelNamedТекстусловия_SIA;
        private System.Windows.Forms.GroupBox groupBoxNamedВводданных_SIA;
        private System.Windows.Forms.TextBox textBoxNamedStart_SIA;
        private System.Windows.Forms.TextBox textBoxNamedStop_SIA;
        private System.Windows.Forms.Label labelNamedСтарт_SIA;
        private System.Windows.Forms.Label labelNamedКонец_SIA;
        private System.Windows.Forms.Button buttonNamedСправка_SIA;
        private System.Windows.Forms.Button buttonNamedВыполнить_SIA;
        private System.Windows.Forms.GroupBox groupBoxNamedВыводДанных_SIA;
        private System.Windows.Forms.Label labelNamedРезультат_SIA;
        private System.Windows.Forms.DataGridView dataGridViewNamedТабулирование_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

