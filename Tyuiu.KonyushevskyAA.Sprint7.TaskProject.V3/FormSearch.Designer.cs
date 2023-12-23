
namespace Tyuiu.KonyushevskyAA.Sprint7.TaskProject.V3
{
    partial class FormSearch_KAA
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
            this.comboBoxSearch_KAA = new System.Windows.Forms.ComboBox();
            this.textBoxSearch_KAA = new System.Windows.Forms.TextBox();
            this.labelPoisk_KAA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchTeacher_KAA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSearch_KAA
            // 
            this.comboBoxSearch_KAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch_KAA.FormattingEnabled = true;
            this.comboBoxSearch_KAA.Items.AddRange(new object[] {
            "Номер",
            "ФИО",
            "Адресс",
            "Должность",
            "Предмет",
            "Номер Телефона ",
            "Количество Часов ",
            "Номер Аудитооии "});
            this.comboBoxSearch_KAA.Location = new System.Drawing.Point(142, 72);
            this.comboBoxSearch_KAA.Name = "comboBoxSearch_KAA";
            this.comboBoxSearch_KAA.Size = new System.Drawing.Size(177, 21);
            this.comboBoxSearch_KAA.TabIndex = 0;
            this.comboBoxSearch_KAA.TabStop = false;
            // 
            // textBoxSearch_KAA
            // 
            this.textBoxSearch_KAA.Location = new System.Drawing.Point(142, 132);
            this.textBoxSearch_KAA.Multiline = true;
            this.textBoxSearch_KAA.Name = "textBoxSearch_KAA";
            this.textBoxSearch_KAA.Size = new System.Drawing.Size(177, 26);
            this.textBoxSearch_KAA.TabIndex = 1;
            // 
            // labelPoisk_KAA
            // 
            this.labelPoisk_KAA.AutoSize = true;
            this.labelPoisk_KAA.Location = new System.Drawing.Point(54, 75);
            this.labelPoisk_KAA.Name = "labelPoisk_KAA";
            this.labelPoisk_KAA.Size = new System.Drawing.Size(62, 13);
            this.labelPoisk_KAA.TabIndex = 2;
            this.labelPoisk_KAA.Text = "Искать по ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск ";
            // 
            // buttonSearchTeacher_KAA
            // 
            this.buttonSearchTeacher_KAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSearchTeacher_KAA.Location = new System.Drawing.Point(191, 204);
            this.buttonSearchTeacher_KAA.Name = "buttonSearchTeacher_KAA";
            this.buttonSearchTeacher_KAA.Size = new System.Drawing.Size(128, 52);
            this.buttonSearchTeacher_KAA.TabIndex = 4;
            this.buttonSearchTeacher_KAA.Text = "Найти";
            this.buttonSearchTeacher_KAA.UseVisualStyleBackColor = false;
            this.buttonSearchTeacher_KAA.Click += new System.EventHandler(this.buttonSearchTeacher_KAA_Click);
            // 
            // FormSearch_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 268);
            this.Controls.Add(this.buttonSearchTeacher_KAA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPoisk_KAA);
            this.Controls.Add(this.textBoxSearch_KAA);
            this.Controls.Add(this.comboBoxSearch_KAA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 324);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(376, 324);
            this.Name = "FormSearch_KAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найти Преподавателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearch_KAA;
        private System.Windows.Forms.TextBox textBoxSearch_KAA;
        private System.Windows.Forms.Label labelPoisk_KAA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchTeacher_KAA;
    }
}