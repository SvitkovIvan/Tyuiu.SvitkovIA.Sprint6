namespace Tyuiu.SvitkovIA.Sprint6.Task3.V5
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1_SIA = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHelp_SIA = new System.Windows.Forms.Button();
            this.buttonDone_SIA_Click = new System.Windows.Forms.Button();
            this.pictureBox_SIA = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_SIA)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox_SIA);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dataGridView1_SIA);
            this.groupBox3.Location = new System.Drawing.Point(24, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 374);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Условие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(592, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в третьем столбц" +
    "е.";
            // 
            // dataGridView1_SIA
            // 
            this.dataGridView1_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_SIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1_SIA.Location = new System.Drawing.Point(320, 42);
            this.dataGridView1_SIA.Name = "dataGridView1_SIA";
            this.dataGridView1_SIA.RowHeadersWidth = 51;
            this.dataGridView1_SIA.RowTemplate.Height = 24;
            this.dataGridView1_SIA.Size = new System.Drawing.Size(278, 313);
            this.dataGridView1_SIA.TabIndex = 0;
            this.dataGridView1_SIA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_SIA_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(666, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 125);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вывод данных";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Результат:";
            // 
            // buttonHelp_SIA
            // 
            this.buttonHelp_SIA.Location = new System.Drawing.Point(666, 354);
            this.buttonHelp_SIA.Name = "buttonHelp_SIA";
            this.buttonHelp_SIA.Size = new System.Drawing.Size(95, 47);
            this.buttonHelp_SIA.TabIndex = 2;
            this.buttonHelp_SIA.Text = "?";
            this.buttonHelp_SIA.UseVisualStyleBackColor = true;
            // 
            // buttonDone_SIA_Click
            // 
            this.buttonDone_SIA_Click.Location = new System.Drawing.Point(779, 354);
            this.buttonDone_SIA_Click.Name = "buttonDone_SIA_Click";
            this.buttonDone_SIA_Click.Size = new System.Drawing.Size(99, 47);
            this.buttonDone_SIA_Click.TabIndex = 3;
            this.buttonDone_SIA_Click.Text = "Выполнить";
            this.buttonDone_SIA_Click.UseVisualStyleBackColor = true;
            // 
            // pictureBox_SIA
            // 
            this.pictureBox_SIA.Image = global::Tyuiu.SvitkovIA.Sprint6.Task3.V5.Properties.Resources.В5;
            this.pictureBox_SIA.Location = new System.Drawing.Point(9, 42);
            this.pictureBox_SIA.Name = "pictureBox_SIA";
            this.pictureBox_SIA.Size = new System.Drawing.Size(288, 271);
            this.pictureBox_SIA.TabIndex = 4;
            this.pictureBox_SIA.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "30";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "-20";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "7";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "-8";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "9";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(899, 431);
            this.Controls.Add(this.buttonDone_SIA_Click);
            this.Controls.Add(this.buttonHelp_SIA);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Спринт 6 | Таск 3 | Вариант 5 | Свитков И. А.";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_SIA)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1_SIA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHelp_SIA;
        private System.Windows.Forms.Button buttonDone_SIA_Click;
        private System.Windows.Forms.PictureBox pictureBox_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

