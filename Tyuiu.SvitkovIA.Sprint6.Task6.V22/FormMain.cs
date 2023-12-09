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
using Tyuiu.SvitkovIA.Sprint6.Task6.V22.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_SIA_Click_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SIA.ShowDialog();
            openFilePath = openFileDialogTask_SIA.FileName;
            textBoxOut_SIA.Text = File.ReadAllText(openFilePath);
            groupBoxIn_SIA.Text = groupBoxOut_SIA.Text  + ""  + openFileDialogTask_SIA.FileName;
            buttonPushMe_SIA_Click.Enabled = true;

        }

        private void buttonPushMe_SIA_Click_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxOut_SIA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SIA_Click_Click(object sender, EventArgs e)
        {
            FormAbout_SIA formAbout =  new FormAbout_SIA();
            formAbout.ShowDialog();
        }
    }
}
    
