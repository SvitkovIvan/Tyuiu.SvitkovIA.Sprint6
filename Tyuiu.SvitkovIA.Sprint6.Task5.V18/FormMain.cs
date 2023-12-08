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
using Tyuiu.SvitkovIA.Sprint6.Task5.V18.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task5.V18
{
    public partial class FormMain : Form
    {


        public FormMain()
        {
            InitializeComponent();

        }
        DataService ds = new DataService();
        string path = @"C:\\Users\\Ванюшка\\Desktop\\repos\\Tyuiu.SvitkovIA.Sprint6\\Tyuiu.SvitkovIA.Sprint6.Task5.V18\\bin\\Debug\\InputFileTask5V18.txt";

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxResult_SIA_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxTask_SIA(object sender, EventArgs e)
        {

        }

        private void groupBoxData_SIA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNamedDone_SIA_Click(object sender, EventArgs e)
        {
            DataGridView dataGridViewResult_SIA = new DataGridView();
            dataGridViewResult_SIA.ColumnCount = 2;
            dataGridViewResult_SIA.Columns[0].Width = 40;
            dataGridViewResult_SIA.Columns[1].Width = 60;



            this.chartDiagramm_SIA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagramm_SIA.ChartAreas[0].AxisY.Title = "Ось Y";
            this.chartDiagramm_SIA.Series[0].Points.Clear();

            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);
            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewResult_SIA.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartDiagramm_SIA.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonNamedOpenn_SIA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\Ванюшка\Desktop\repos\Tyuiu.SvitkovIA.Sprint6\Tyuiu.SvitkovIA.Sprint6.Task5.V18\bin\Debug\InPutFileTask5V18.txt";

                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNamedHeelp_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-2 Свитков Иван Андреевич",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
              
        
