using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SvitkovIA.Sprint6.Task1.V19.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task1.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        
        
        private void groupBoxData_SIA_Enter(object sender, EventArgs e)
        {

        }



        

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxNamedOne_SIA_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNaamedOne_SIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNamedInfo_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент  группы  АСОиУБ-23-2 Свитков И. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonNamedDone_SIA_Click(object sender, EventArgs e)
        {
            try
            {
                
                int startstep = Convert.ToInt32(textBoxStartStep_SIA.Text);
                int stopstep = Convert.ToInt32(textBoxStopStep_SIA.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                string str;
                double[] func = new double[len];
                func = ds.GetMassFunction(startstep, stopstep);
                textBoxResult_SIA.Text = "";
                textBoxResult_SIA.AppendText("+------------------------+" + Environment.NewLine);
                textBoxResult_SIA.AppendText("|    x     |     f(x)    |" + Environment.NewLine);
                textBoxResult_SIA.AppendText("+------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0, 6:d}    |  {1, 7:f2}    |", startstep, func[i]);
                    textBoxResult_SIA.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                textBoxResult_SIA.AppendText("+------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
