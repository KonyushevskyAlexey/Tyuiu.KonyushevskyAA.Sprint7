
namespace Tyuiu.KonyushevskyAA.Sprint7.TaskProject.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelleft_KAA = new System.Windows.Forms.Panel();
            this.groupBoxBaza_KAA = new System.Windows.Forms.GroupBox();
            this.buttonDelete_KAA = new System.Windows.Forms.Button();
            this.buttonFind_KAA = new System.Windows.Forms.Button();
            this.buttonEdit_KAA = new System.Windows.Forms.Button();
            this.buttonAdd_KAA = new System.Windows.Forms.Button();
            this.buttonBaza_KAA = new System.Windows.Forms.Button();
            this.buttonSave_KAA = new System.Windows.Forms.Button();
            this.buttonOpen_KAA = new System.Windows.Forms.Button();
            this.paneltop_KAA = new System.Windows.Forms.Panel();
            this.buttoninfo_KAA = new System.Windows.Forms.Button();
            this.panelcenter_KAA = new System.Windows.Forms.Panel();
            this.dataGridViewMain_KAA = new System.Windows.Forms.DataGridView();
            this.toolTip_KAA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask_KAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_KAA = new System.Windows.Forms.SaveFileDialog();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartTime_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelleft_KAA.SuspendLayout();
            this.groupBoxBaza_KAA.SuspendLayout();
            this.paneltop_KAA.SuspendLayout();
            this.panelcenter_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain_KAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelleft_KAA
            // 
            this.panelleft_KAA.Controls.Add(this.groupBoxBaza_KAA);
            this.panelleft_KAA.Controls.Add(this.buttonSave_KAA);
            this.panelleft_KAA.Controls.Add(this.buttonOpen_KAA);
            this.panelleft_KAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft_KAA.Location = new System.Drawing.Point(0, 0);
            this.panelleft_KAA.Name = "panelleft_KAA";
            this.panelleft_KAA.Size = new System.Drawing.Size(335, 633);
            this.panelleft_KAA.TabIndex = 0;
            // 
            // groupBoxBaza_KAA
            // 
            this.groupBoxBaza_KAA.Controls.Add(this.buttonDelete_KAA);
            this.groupBoxBaza_KAA.Controls.Add(this.buttonFind_KAA);
            this.groupBoxBaza_KAA.Controls.Add(this.buttonEdit_KAA);
            this.groupBoxBaza_KAA.Controls.Add(this.buttonAdd_KAA);
            this.groupBoxBaza_KAA.Controls.Add(this.buttonBaza_KAA);
            this.groupBoxBaza_KAA.Location = new System.Drawing.Point(13, 107);
            this.groupBoxBaza_KAA.Name = "groupBoxBaza_KAA";
            this.groupBoxBaza_KAA.Size = new System.Drawing.Size(317, 366);
            this.groupBoxBaza_KAA.TabIndex = 2;
            this.groupBoxBaza_KAA.TabStop = false;
            this.groupBoxBaza_KAA.Text = "Работа с базой преподавателей ";
            // 
            // buttonDelete_KAA
            // 
            this.buttonDelete_KAA.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonDelete_KAA.Location = new System.Drawing.Point(7, 321);
            this.buttonDelete_KAA.Name = "buttonDelete_KAA";
            this.buttonDelete_KAA.Size = new System.Drawing.Size(298, 39);
            this.buttonDelete_KAA.TabIndex = 3;
            this.buttonDelete_KAA.Text = "Удалить Преподавателя";
            this.buttonDelete_KAA.UseVisualStyleBackColor = false;
            this.buttonDelete_KAA.Click += new System.EventHandler(this.buttonDelete_KAA_Click);
            // 
            // buttonFind_KAA
            // 
            this.buttonFind_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonFind_KAA.Image")));
            this.buttonFind_KAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFind_KAA.Location = new System.Drawing.Point(6, 106);
            this.buttonFind_KAA.Name = "buttonFind_KAA";
            this.buttonFind_KAA.Size = new System.Drawing.Size(298, 43);
            this.buttonFind_KAA.TabIndex = 2;
            this.buttonFind_KAA.Text = "Найти Преподавателя";
            this.buttonFind_KAA.UseVisualStyleBackColor = true;
            this.buttonFind_KAA.Click += new System.EventHandler(this.buttonFind_KAA_Click);
            // 
            // buttonEdit_KAA
            // 
            this.buttonEdit_KAA.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEdit_KAA.Location = new System.Drawing.Point(7, 249);
            this.buttonEdit_KAA.Name = "buttonEdit_KAA";
            this.buttonEdit_KAA.Size = new System.Drawing.Size(297, 53);
            this.buttonEdit_KAA.TabIndex = 1;
            this.buttonEdit_KAA.Text = "Редактировать Преподавателя";
            this.buttonEdit_KAA.UseVisualStyleBackColor = false;
            this.buttonEdit_KAA.Click += new System.EventHandler(this.buttonEdit_KAA_Click);
            // 
            // buttonAdd_KAA
            // 
            this.buttonAdd_KAA.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAdd_KAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd_KAA.Location = new System.Drawing.Point(7, 175);
            this.buttonAdd_KAA.Name = "buttonAdd_KAA";
            this.buttonAdd_KAA.Size = new System.Drawing.Size(297, 52);
            this.buttonAdd_KAA.TabIndex = 1;
            this.buttonAdd_KAA.Text = "Добавить Преподавателя ";
            this.buttonAdd_KAA.UseVisualStyleBackColor = false;
            this.buttonAdd_KAA.Click += new System.EventHandler(this.buttonAdd_KAA_Click);
            // 
            // buttonBaza_KAA
            // 
            this.buttonBaza_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonBaza_KAA.Image")));
            this.buttonBaza_KAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBaza_KAA.Location = new System.Drawing.Point(7, 45);
            this.buttonBaza_KAA.Name = "buttonBaza_KAA";
            this.buttonBaza_KAA.Size = new System.Drawing.Size(297, 42);
            this.buttonBaza_KAA.TabIndex = 0;
            this.buttonBaza_KAA.Text = "Работа с Базой\r\n";
            this.buttonBaza_KAA.UseVisualStyleBackColor = true;
            this.buttonBaza_KAA.Click += new System.EventHandler(this.buttonBaza_KAA_Click);
            // 
            // buttonSave_KAA
            // 
            this.buttonSave_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_KAA.Image")));
            this.buttonSave_KAA.Location = new System.Drawing.Point(169, 26);
            this.buttonSave_KAA.Name = "buttonSave_KAA";
            this.buttonSave_KAA.Size = new System.Drawing.Size(113, 74);
            this.buttonSave_KAA.TabIndex = 1;
            this.buttonSave_KAA.UseVisualStyleBackColor = true;
            this.buttonSave_KAA.Click += new System.EventHandler(this.buttonSave_KAA_Click);
            // 
            // buttonOpen_KAA
            // 
            this.buttonOpen_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_KAA.Image")));
            this.buttonOpen_KAA.Location = new System.Drawing.Point(26, 25);
            this.buttonOpen_KAA.Name = "buttonOpen_KAA";
            this.buttonOpen_KAA.Size = new System.Drawing.Size(113, 75);
            this.buttonOpen_KAA.TabIndex = 0;
            this.buttonOpen_KAA.UseVisualStyleBackColor = true;
            this.buttonOpen_KAA.Click += new System.EventHandler(this.buttonOpen_KAA_Click);
            // 
            // paneltop_KAA
            // 
            this.paneltop_KAA.Controls.Add(this.buttoninfo_KAA);
            this.paneltop_KAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop_KAA.Location = new System.Drawing.Point(335, 0);
            this.paneltop_KAA.Name = "paneltop_KAA";
            this.paneltop_KAA.Size = new System.Drawing.Size(888, 100);
            this.paneltop_KAA.TabIndex = 1;
            // 
            // buttoninfo_KAA
            // 
            this.buttoninfo_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoninfo_KAA.Image = ((System.Drawing.Image)(resources.GetObject("buttoninfo_KAA.Image")));
            this.buttoninfo_KAA.Location = new System.Drawing.Point(756, 25);
            this.buttoninfo_KAA.Name = "buttoninfo_KAA";
            this.buttoninfo_KAA.Size = new System.Drawing.Size(81, 48);
            this.buttoninfo_KAA.TabIndex = 0;
            this.buttoninfo_KAA.UseVisualStyleBackColor = true;
            this.buttoninfo_KAA.Click += new System.EventHandler(this.buttoninfo_KAA_Click);
            // 
            // panelcenter_KAA
            // 
            this.panelcenter_KAA.Controls.Add(this.dataGridViewMain_KAA);
            this.panelcenter_KAA.Location = new System.Drawing.Point(335, 100);
            this.panelcenter_KAA.Name = "panelcenter_KAA";
            this.panelcenter_KAA.Size = new System.Drawing.Size(745, 285);
            this.panelcenter_KAA.TabIndex = 2;
            // 
            // dataGridViewMain_KAA
            // 
            this.dataGridViewMain_KAA.AllowUserToAddRows = false;
            this.dataGridViewMain_KAA.AllowUserToDeleteRows = false;
            this.dataGridViewMain_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain_KAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridViewMain_KAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMain_KAA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMain_KAA.Name = "dataGridViewMain_KAA";
            this.dataGridViewMain_KAA.ReadOnly = true;
            this.dataGridViewMain_KAA.RowHeadersVisible = false;
            this.dataGridViewMain_KAA.RowHeadersWidth = 62;
            this.dataGridViewMain_KAA.Size = new System.Drawing.Size(745, 275);
            this.dataGridViewMain_KAA.TabIndex = 0;
            // 
            // openFileDialogTask_KAA
            // 
            this.openFileDialogTask_KAA.FileName = "openFileDialog1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Адресс";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Должность";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Предмет";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Номер Телефона";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Количество Часов ";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Номер Аудитории";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // chartTime_KAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTime_KAA.ChartAreas.Add(chartArea1);
            this.chartTime_KAA.Location = new System.Drawing.Point(341, 394);
            this.chartTime_KAA.Name = "chartTime_KAA";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartTime_KAA.Series.Add(series1);
            this.chartTime_KAA.Size = new System.Drawing.Size(724, 227);
            this.chartTime_KAA.TabIndex = 3;
            this.chartTime_KAA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 633);
            this.Controls.Add(this.chartTime_KAA);
            this.Controls.Add(this.panelcenter_KAA);
            this.Controls.Add(this.paneltop_KAA);
            this.Controls.Add(this.panelleft_KAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.panelleft_KAA.ResumeLayout(false);
            this.groupBoxBaza_KAA.ResumeLayout(false);
            this.paneltop_KAA.ResumeLayout(false);
            this.panelcenter_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain_KAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft_KAA;
        private System.Windows.Forms.Panel paneltop_KAA;
        private System.Windows.Forms.Panel panelcenter_KAA;
        private System.Windows.Forms.Button buttoninfo_KAA;
        private System.Windows.Forms.Button buttonSave_KAA;
        private System.Windows.Forms.Button buttonOpen_KAA;
        public System.Windows.Forms.DataGridView dataGridViewMain_KAA;
        private System.Windows.Forms.GroupBox groupBoxBaza_KAA;
        public System.Windows.Forms.Button buttonDelete_KAA;
        public System.Windows.Forms.Button buttonFind_KAA;
        public System.Windows.Forms.Button buttonEdit_KAA;
        public System.Windows.Forms.Button buttonAdd_KAA;
        public System.Windows.Forms.Button buttonBaza_KAA;
        private System.Windows.Forms.ToolTip toolTip_KAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_KAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTime_KAA;
    }
}

