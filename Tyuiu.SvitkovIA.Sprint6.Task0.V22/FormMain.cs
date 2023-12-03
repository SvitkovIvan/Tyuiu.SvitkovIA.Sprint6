﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SvitkovIA.Sprint6.Task0.V22.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task0.V22
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TextBox textBoxOutPut_SIA = new TextBox();
                TextBox textBoxVarX_SIA = new TextBox();
                textBoxOutPut_SIA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_SIA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_SIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУБ-23-2 Cвитков Иван Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
    