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

using Tyuiu.SvitkovIA.Sprint6.Task7.V28.Lib;

namespace Tyuiu.SvitkovIA.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_SIA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SIA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_SIA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();

        }

        private void buttonOpenFile_SIA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SIA.ShowDialog();
            openFilePath = openFileDialogTask_SIA.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_SIA.ColumnCount = colums;
            dataGridViewInMatrix_SIA.RowCount = rows;
            dataGridViewOutMatrix_SIA.ColumnCount = colums;
            dataGridViewOutMatrix_SIA.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInMatrix_SIA.Columns[i].Width = 25;
                dataGridViewOutMatrix_SIA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInMatrix_SIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SIA.Enabled = true;


        }

        private void buttonDone_SIA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutMatrix_SIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_SIA.Enabled = true;
        }

        private void buttonSaveFile_SIA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SIA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SIA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SIA.ShowDialog();

            string path = saveFileDialogMatrix_SIA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_SIA.RowCount;
            int columns = dataGridViewOutMatrix_SIA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_SIA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_SIA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }


        private void buttonDone_SIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_SIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_SIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

        private void buttonOpenFile_SIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix_SIA.ColumnCount = 50;
            dataGridViewOutMatrix_SIA.ColumnCount = 50;

            dataGridViewInMatrix_SIA.RowCount = 50;
            dataGridViewOutMatrix_SIA.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_SIA.Columns[i].Width = 25;
                dataGridViewOutMatrix_SIA.Columns[i].Width = 25;
            }
        }
    }
}

      
