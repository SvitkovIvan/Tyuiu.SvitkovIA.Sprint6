﻿namespace Tyuiu.SvitkovIA.Sprint6.Task5.V18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDiagramm_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxNamedУсловие_SIA = new System.Windows.Forms.GroupBox();
            this.labelNamedУсловие_SIA = new System.Windows.Forms.Label();
            this.buttonNamedDone_SIA = new System.Windows.Forms.Button();
            this.buttonNamedOpenn_SIA = new System.Windows.Forms.Button();
            this.buttonNamedHeelp_SIA = new System.Windows.Forms.Button();
            this.panelNamedOutPut_SIA = new System.Windows.Forms.Panel();
            this.labelNamedOutPut_SIA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagramm_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDiagramm_SIA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiagramm_SIA.ChartAreas.Add(chartArea2);
            this.chartDiagramm_SIA.Location = new System.Drawing.Point(280, 92);
            this.chartDiagramm_SIA.Name = "chartDiagramm_SIA";
            this.chartDiagramm_SIA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartDiagramm_SIA.Series.Add(series2);
            this.chartDiagramm_SIA.Size = new System.Drawing.Size(622, 346);
            this.chartDiagramm_SIA.TabIndex = 0;
            this.chartDiagramm_SIA.Text = "chart1";
            // 
            // groupBoxNamedУсловие_SIA
            // 
            this.groupBoxNamedУсловие_SIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNamedУсловие_SIA.Name = "groupBoxNamedУсловие_SIA";
            this.groupBoxNamedУсловие_SIA.Size = new System.Drawing.Size(500, 74);
            this.groupBoxNamedУсловие_SIA.TabIndex = 1;
            this.groupBoxNamedУсловие_SIA.TabStop = false;
            this.groupBoxNamedУсловие_SIA.Text = "Условие:";
            // 
            // labelNamedУсловие_SIA
            // 
            this.labelNamedУсловие_SIA.AutoSize = true;
            this.labelNamedУсловие_SIA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelNamedУсловие_SIA.Location = new System.Drawing.Point(18, 30);
            this.labelNamedУсловие_SIA.Name = "labelNamedУсловие_SIA";
            this.labelNamedУсловие_SIA.Size = new System.Drawing.Size(488, 48);
            this.labelNamedУсловие_SIA.TabIndex = 2;
            this.labelNamedУсловие_SIA.Text = "Прочитать данные из файла InPutFileTask5V18.txt. Вывести в dataGridView. \r\nВывест" +
    "и все вещественные числа.  \r\nПостроить диаграмму по этим значениям. ";
            // 
            // buttonNamedDone_SIA
            // 
            this.buttonNamedDone_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNamedDone_SIA.Location = new System.Drawing.Point(533, 12);
            this.buttonNamedDone_SIA.Name = "buttonNamedDone_SIA";
            this.buttonNamedDone_SIA.Size = new System.Drawing.Size(106, 74);
            this.buttonNamedDone_SIA.TabIndex = 3;
            this.buttonNamedDone_SIA.Text = "Выполнить";
            this.buttonNamedDone_SIA.UseVisualStyleBackColor = false;
            this.buttonNamedDone_SIA.Click += new System.EventHandler(this.buttonNamedDone_SIA_Click);
            // 
            // buttonNamedOpenn_SIA
            // 
            this.buttonNamedOpenn_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNamedOpenn_SIA.Location = new System.Drawing.Point(656, 12);
            this.buttonNamedOpenn_SIA.Name = "buttonNamedOpenn_SIA";
            this.buttonNamedOpenn_SIA.Size = new System.Drawing.Size(112, 74);
            this.buttonNamedOpenn_SIA.TabIndex = 4;
            this.buttonNamedOpenn_SIA.Text = "Открыть файл";
            this.buttonNamedOpenn_SIA.UseVisualStyleBackColor = false;
            this.buttonNamedOpenn_SIA.Click += new System.EventHandler(this.buttonNamedOpenn_SIA_Click);
            // 
            // buttonNamedHeelp_SIA
            // 
            this.buttonNamedHeelp_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonNamedHeelp_SIA.Location = new System.Drawing.Point(789, 12);
            this.buttonNamedHeelp_SIA.Name = "buttonNamedHeelp_SIA";
            this.buttonNamedHeelp_SIA.Size = new System.Drawing.Size(113, 74);
            this.buttonNamedHeelp_SIA.TabIndex = 5;
            this.buttonNamedHeelp_SIA.Text = "Справка";
            this.buttonNamedHeelp_SIA.UseVisualStyleBackColor = false;
            this.buttonNamedHeelp_SIA.Click += new System.EventHandler(this.buttonNamedHeelp_SIA_Click);
            // 
            // panelNamedOutPut_SIA
            // 
            this.panelNamedOutPut_SIA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelNamedOutPut_SIA.Location = new System.Drawing.Point(12, 110);
            this.panelNamedOutPut_SIA.Name = "panelNamedOutPut_SIA";
            this.panelNamedOutPut_SIA.Size = new System.Drawing.Size(253, 328);
            this.panelNamedOutPut_SIA.TabIndex = 6;
            // 
            // labelNamedOutPut_SIA
            // 
            this.labelNamedOutPut_SIA.AutoSize = true;
            this.labelNamedOutPut_SIA.Location = new System.Drawing.Point(18, 92);
            this.labelNamedOutPut_SIA.Name = "labelNamedOutPut_SIA";
            this.labelNamedOutPut_SIA.Size = new System.Drawing.Size(102, 16);
            this.labelNamedOutPut_SIA.TabIndex = 0;
            this.labelNamedOutPut_SIA.Text = "Вывод данных:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.labelNamedOutPut_SIA);
            this.Controls.Add(this.panelNamedOutPut_SIA);
            this.Controls.Add(this.buttonNamedHeelp_SIA);
            this.Controls.Add(this.buttonNamedOpenn_SIA);
            this.Controls.Add(this.buttonNamedDone_SIA);
            this.Controls.Add(this.labelNamedУсловие_SIA);
            this.Controls.Add(this.groupBoxNamedУсловие_SIA);
            this.Controls.Add(this.chartDiagramm_SIA);
            this.Name = "FormMain";
            this.Text = "Cпринт 6 | Таск 5 | Вариант 18 | Свитков И. А.";
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagramm_SIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagramm_SIA;
        private System.Windows.Forms.GroupBox groupBoxNamedУсловие_SIA;
        private System.Windows.Forms.Label labelNamedУсловие_SIA;
        private System.Windows.Forms.Button buttonNamedDone_SIA;
        private System.Windows.Forms.Button buttonNamedOpenn_SIA;
        private System.Windows.Forms.Button buttonNamedHeelp_SIA;
        private System.Windows.Forms.Panel panelNamedOutPut_SIA;
        private System.Windows.Forms.Label labelNamedOutPut_SIA;
    }
}

