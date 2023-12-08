namespace Tyuiu.SvitkovIA.Sprint6.Task6.V22
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialogTask_SIA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipNamed_SIA = new System.Windows.Forms.ToolTip(this.components);
            this.buttonHelp_SIA_Click = new System.Windows.Forms.Button();
            this.buttonPushMe_SIA_Click = new System.Windows.Forms.Button();
            this.buttonOpen_SIA_Click = new System.Windows.Forms.Button();
            this.groupBoxIn_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxIn_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxOut_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxOut_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxNamedус_SIA = new System.Windows.Forms.GroupBox();
            this.labelNamedус_SIA = new System.Windows.Forms.Label();
            this.groupBoxIn_SIA.SuspendLayout();
            this.groupBoxOut_SIA.SuspendLayout();
            this.groupBoxNamedус_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogTask_SIA
            // 
            this.openFileDialogTask_SIA.FileName = "openFileDialogTask_SIA";
            // 
            // toolTipNamed_SIA
            // 
            this.toolTipNamed_SIA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipNamed_SIA.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_SIA_Click
            // 
            this.buttonHelp_SIA_Click.BackgroundImage = global::Tyuiu.SvitkovIA.Sprint6.Task6.V22.Properties.Resources.error_go;
            this.buttonHelp_SIA_Click.Location = new System.Drawing.Point(1128, 12);
            this.buttonHelp_SIA_Click.Name = "buttonHelp_SIA_Click";
            this.buttonHelp_SIA_Click.Size = new System.Drawing.Size(36, 33);
            this.buttonHelp_SIA_Click.TabIndex = 2;
            this.toolTipNamed_SIA.SetToolTip(this.buttonHelp_SIA_Click, "Сведение о программе");
            this.buttonHelp_SIA_Click.UseVisualStyleBackColor = true;
            this.buttonHelp_SIA_Click.Click += new System.EventHandler(this.buttonHelp_SIA_Click_Click);
            // 
            // buttonPushMe_SIA_Click
            // 
            this.buttonPushMe_SIA_Click.BackgroundImage = global::Tyuiu.SvitkovIA.Sprint6.Task6.V22.Properties.Resources.page_go;
            this.buttonPushMe_SIA_Click.Location = new System.Drawing.Point(69, 12);
            this.buttonPushMe_SIA_Click.Name = "buttonPushMe_SIA_Click";
            this.buttonPushMe_SIA_Click.Size = new System.Drawing.Size(36, 33);
            this.buttonPushMe_SIA_Click.TabIndex = 1;
            this.toolTipNamed_SIA.SetToolTip(this.buttonPushMe_SIA_Click, "Производит поиск в файле вхождений первого\r\nслова каждой строки в которых находят" +
        "ся эти слова");
            this.buttonPushMe_SIA_Click.UseVisualStyleBackColor = true;
            this.buttonPushMe_SIA_Click.Click += new System.EventHandler(this.buttonPushMe_SIA_Click_Click);
            // 
            // buttonOpen_SIA_Click
            // 
            this.buttonOpen_SIA_Click.BackgroundImage = global::Tyuiu.SvitkovIA.Sprint6.Task6.V22.Properties.Resources.folder_page;
            this.buttonOpen_SIA_Click.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen_SIA_Click.Name = "buttonOpen_SIA_Click";
            this.buttonOpen_SIA_Click.Size = new System.Drawing.Size(37, 33);
            this.buttonOpen_SIA_Click.TabIndex = 0;
            this.toolTipNamed_SIA.SetToolTip(this.buttonOpen_SIA_Click, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpen_SIA_Click.UseVisualStyleBackColor = true;
            this.buttonOpen_SIA_Click.Click += new System.EventHandler(this.buttonOpen_SIA_Click_Click);
            // 
            // groupBoxIn_SIA
            // 
            this.groupBoxIn_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBoxIn_SIA.Controls.Add(this.textBoxIn_SIA);
            this.groupBoxIn_SIA.Location = new System.Drawing.Point(12, 174);
            this.groupBoxIn_SIA.Name = "groupBoxIn_SIA";
            this.groupBoxIn_SIA.Size = new System.Drawing.Size(541, 343);
            this.groupBoxIn_SIA.TabIndex = 3;
            this.groupBoxIn_SIA.TabStop = false;
            this.groupBoxIn_SIA.Text = "Ввод:";
            // 
            // textBoxIn_SIA
            // 
            this.textBoxIn_SIA.Location = new System.Drawing.Point(16, 21);
            this.textBoxIn_SIA.Multiline = true;
            this.textBoxIn_SIA.Name = "textBoxIn_SIA";
            this.textBoxIn_SIA.Size = new System.Drawing.Size(519, 301);
            this.textBoxIn_SIA.TabIndex = 0;
            // 
            // groupBoxOut_SIA
            // 
            this.groupBoxOut_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBoxOut_SIA.Controls.Add(this.textBoxOut_SIA);
            this.groupBoxOut_SIA.Location = new System.Drawing.Point(592, 174);
            this.groupBoxOut_SIA.Name = "groupBoxOut_SIA";
            this.groupBoxOut_SIA.Size = new System.Drawing.Size(572, 343);
            this.groupBoxOut_SIA.TabIndex = 4;
            this.groupBoxOut_SIA.TabStop = false;
            this.groupBoxOut_SIA.Text = "Вывод:";
            // 
            // textBoxOut_SIA
            // 
            this.textBoxOut_SIA.Location = new System.Drawing.Point(17, 21);
            this.textBoxOut_SIA.Multiline = true;
            this.textBoxOut_SIA.Name = "textBoxOut_SIA";
            this.textBoxOut_SIA.Size = new System.Drawing.Size(549, 301);
            this.textBoxOut_SIA.TabIndex = 0;
            // 
            // groupBoxNamedус_SIA
            // 
            this.groupBoxNamedус_SIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxNamedус_SIA.Controls.Add(this.labelNamedус_SIA);
            this.groupBoxNamedус_SIA.Location = new System.Drawing.Point(28, 51);
            this.groupBoxNamedус_SIA.Name = "groupBoxNamedус_SIA";
            this.groupBoxNamedус_SIA.Size = new System.Drawing.Size(1087, 100);
            this.groupBoxNamedус_SIA.TabIndex = 1;
            this.groupBoxNamedус_SIA.TabStop = false;
            this.groupBoxNamedус_SIA.Text = "Условие:";
            // 
            // labelNamedус_SIA
            // 
            this.labelNamedус_SIA.AutoSize = true;
            this.labelNamedус_SIA.Location = new System.Drawing.Point(6, 18);
            this.labelNamedус_SIA.Name = "labelNamedус_SIA";
            this.labelNamedус_SIA.Size = new System.Drawing.Size(600, 48);
            this.labelNamedус_SIA.TabIndex = 0;
            this.labelNamedус_SIA.Text = resources.GetString("labelNamedус_SIA.Text");
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(1176, 529);
            this.Controls.Add(this.groupBoxNamedус_SIA);
            this.Controls.Add(this.groupBoxOut_SIA);
            this.Controls.Add(this.groupBoxIn_SIA);
            this.Controls.Add(this.buttonHelp_SIA_Click);
            this.Controls.Add(this.buttonPushMe_SIA_Click);
            this.Controls.Add(this.buttonOpen_SIA_Click);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 22 | Свитков И. А.";
            this.groupBoxIn_SIA.ResumeLayout(false);
            this.groupBoxIn_SIA.PerformLayout();
            this.groupBoxOut_SIA.ResumeLayout(false);
            this.groupBoxOut_SIA.PerformLayout();
            this.groupBoxNamedус_SIA.ResumeLayout(false);
            this.groupBoxNamedус_SIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNamedУсл_SIA;
        private System.Windows.Forms.Label labelNamedУсл_SIA;
        private System.Windows.Forms.Button button1;
        // private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SIA;
        private System.Windows.Forms.ToolTip toolTipNamed_SIA;
        private System.Windows.Forms.Button buttonOpen_SIA_Click;
        private System.Windows.Forms.Button buttonPushMe_SIA_Click;
        private System.Windows.Forms.Button buttonHelp_SIA_Click;
        private System.Windows.Forms.GroupBox groupBoxIn_SIA;
        private System.Windows.Forms.TextBox textBoxIn_SIA;
        private System.Windows.Forms.GroupBox groupBoxOut_SIA;
        private System.Windows.Forms.TextBox textBoxOut_SIA;
        private System.Windows.Forms.GroupBox groupBoxNamedус_SIA;
        private System.Windows.Forms.Label labelNamedус_SIA;
        // private System.Windows.Forms.ToolTip toolTip1;
    }
}

