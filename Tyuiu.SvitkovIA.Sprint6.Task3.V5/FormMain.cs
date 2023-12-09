using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SvitkovIA.Sprint6.Task3.V5.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task3.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[,] { { 30, -20, 7, -8, 9 }, { 32, 17, -14, -7, 33 },
                { 19, -19, -13, 14, -20}, { 11, 30, -1, 26, 6 }, { 30, -15, -20, -5, 15 } };

        private void buttonNamedHelp_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУБ-23-2  Свитков И.А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_SIA(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonNamedDone_SIA_Click_Click(object sender, EventArgs e)
        {
            
            int[,] result = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;
            dataGridViewMatrixx_SIA.RowCount = rows;
            dataGridViewMatrixx_SIA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixx_SIA.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixx_SIA.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }

            }

        }

        private void dataGridView1_SIA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}


    
                