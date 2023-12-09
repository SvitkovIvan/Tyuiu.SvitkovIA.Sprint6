using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SvitkovIA.Sprint6.Task2.V30.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task2.V30
{
    public partial class FormMain_SIA : Form
    {
        public FormMain_SIA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();



        private void buttonNamedInfo_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2  выполнил студент группы АСОиУБ-23-2 Свитков И. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void dataGridViewNamedТабулирование_SIA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNamedDone_SIA_Click(object sender, EventArgs e)
        {
            try
            {
                
                int startStep = Convert.ToInt32(textBoxStartStep_SIA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SIA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);



                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewNamedТабулирование_SIA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart1.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }


    



        
   

      

    