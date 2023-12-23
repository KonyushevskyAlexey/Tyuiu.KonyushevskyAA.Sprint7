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

using Tyuiu.KonyushevskyAA.Sprint7.TaskProject.V3.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint7.TaskProject.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


          openFileDialogTask_KAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
          saveFileDialogTask_KAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.";

        }

        static int rows;
        static int columns;
        static string OpenFilePath;

        DataService ds = new DataService();

        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;

        }

        private void buttoninfo_KAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpen_KAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAA.ShowDialog();
            OpenFilePath = openFileDialogTask_KAA.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(OpenFilePath);

            arrayValues = ds.GetBase(OpenFilePath);

            
        }

        private void buttonAdd_KAA_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser(this);
            formAddUser.ShowDialog();
            buttonBaza_KAA.Enabled = false;

                
        }

        private void buttonSave_KAA_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_KAA.FileName = "TeachersDatabase.csv";
            saveFileDialogTask_KAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_KAA.ShowDialog();

            string path = saveFileDialogTask_KAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMain_KAA.RowCount;
            int columns = dataGridViewMain_KAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMain_KAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMain_KAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonBaza_KAA_Click(object sender, EventArgs e)
        {
           dataGridViewMain_KAA.ColumnCount = columns;
            dataGridViewMain_KAA.RowCount = rows;

            dataGridViewMain_KAA.Columns[0].HeaderText = "Номер";
            dataGridViewMain_KAA.Columns[1].HeaderText = "ФИО";
            dataGridViewMain_KAA.Columns[2].HeaderText = "Адресс";
            dataGridViewMain_KAA.Columns[3].HeaderText = "Должность";
            dataGridViewMain_KAA.Columns[4].HeaderText = "Предмет";
            dataGridViewMain_KAA.Columns[5].HeaderText = "Номер Телефона";
            dataGridViewMain_KAA.Columns[6].HeaderText = "Количество Часов";
            dataGridViewMain_KAA.Columns[7].HeaderText = "Номер Аудитории";

            dataGridViewMain_KAA.Columns[0].Width = 50;
            dataGridViewMain_KAA.Columns[1].Width = 200;
            dataGridViewMain_KAA.Columns[2].Width = 130;
            dataGridViewMain_KAA.Columns[3].Width = 150;
            dataGridViewMain_KAA.Columns[4].Width = 100;
            dataGridViewMain_KAA.Columns[5].Width = 100;
            dataGridViewMain_KAA.Columns[6].Width = 50;
            dataGridViewMain_KAA.Columns[7].Width = 50;


            dataGridViewMain_KAA.Rows[0].ReadOnly = true;
            dataGridViewMain_KAA.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(OpenFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                   dataGridViewMain_KAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetBase(OpenFilePath);
            
        }

        private void buttonDelete_KAA_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain_KAA.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewMain_KAA.CurrentRow.Index;
                    dataGridViewMain_KAA.Rows.Remove(dataGridViewMain_KAA.Rows[a]);
                    if (dataGridViewMain_KAA.Rows.Count == 1)
                    {
                        dataGridViewMain_KAA.Rows.Clear();
                    }
                }
                if (dataGridViewMain_KAA.Rows.Count <= 1)
                {
                    buttonDelete_KAA.Enabled = false;
                    buttonEdit_KAA.Enabled = false;
                    buttonFind_KAA.Enabled = false;
                }
                if (dataGridViewMain_KAA.Rows.Count > 1)
                {
                    buttonDelete_KAA.Enabled = true;
                }
                buttonBaza_KAA.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении преподавателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_KAA_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewMain_KAA.CurrentRow.Index;
                FormEditUser fed = new FormEditUser(this);
                fed.textBoxID_KAA.Text = dataGridViewMain_KAA.Rows[a].Cells[0].Value.ToString();
                fed.textBoxUserName_KAA.Text = dataGridViewMain_KAA.Rows[a].Cells[1].Value.ToString();
                fed.textBoxAddress_KAA.Text = dataGridViewMain_KAA.Rows[a].Cells[2].Value.ToString();
                fed.textBoxJob_KAA.Text = dataGridViewMain_KAA.Rows[a].Cells[3].Value.ToString();
                fed.textBoxItem_KAA.Text = dataGridViewMain_KAA.Rows[a].Cells[4].Value.ToString();
                fed.textBoxPhone_KAA.Text = dataGridViewMain_KAA.Rows[a].Cells[5].Value.ToString();
                fed.textBoxTime_KAA.Text = dataGridViewMain_KAA.Rows[a].Cells[6].Value.ToString();
                fed.textBoxAudience_KAA.Text = dataGridViewMain_KAA.Rows[a].Cells[7].Value.ToString();
                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании данных ", "Ошибка  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFind_KAA_Click(object sender, EventArgs e)
        {
            FormSearch_KAA formSearch = new FormSearch_KAA(this);
            formSearch.ShowDialog();
        }
    }
}
