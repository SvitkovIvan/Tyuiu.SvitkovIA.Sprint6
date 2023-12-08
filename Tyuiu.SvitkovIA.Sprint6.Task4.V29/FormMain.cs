using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.SvitkovIA.Sprint6.Task4.V29.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.SvitkovIA.Sprint6.Task4.V29
{
    public partial class FormMainNamed_SIA : Form
    {
        public FormMainNamed_SIA()
        {
            InitializeComponent();
            chartFunction_SIA = new Chart();
        }

        DataService ds = new DataService();
        Chart chartFunction_SIA;


        private void buttonNamedDones_SIA_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox textBoxStartV_SIA = new TextBox();
                TextBox textBoxStopV_SIA = new TextBox();
                TextBox textBoxDataOutPut_SIA = new TextBox();


                int startValue = Convert.ToInt32(textBoxStartV_SIA.Text);
                int stopValue = Convert.ToInt32(textBoxStopV_SIA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);



                this.chartFunction_SIA.Titles.Add("График функции (2x-3)/((Math.Cos(x)-2x)) + 5*x-6");

                this.chartFunction_SIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SIA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxDataOutPut_SIA.Text = "";

                chartFunction_SIA.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_SIA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxDataOutPut_SIA.AppendText(valueArray[i].ToString() + Environment.NewLine);
                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNamedSaves_SIA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V29.txt";
                File.WriteAllText(path, textBoxDataOutPut_SIA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void groupBoxDataInPut_SIA_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNamedInform_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУБ-23-2 Свитков Иван Андреевич", "Сообщение");
        }

    }
}
        
    
