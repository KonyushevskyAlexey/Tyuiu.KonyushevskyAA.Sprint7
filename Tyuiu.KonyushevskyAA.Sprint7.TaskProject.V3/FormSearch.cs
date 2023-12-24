using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KonyushevskyAA.Sprint7.TaskProject.V3
{
    public partial class FormSearch_KAA : Form
    {

        FormMain fmain;
        public FormSearch_KAA(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonSearchTeacher_KAA_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < fmain.dataGridViewMain_KAA.RowCount; i++)
                {
                    fmain.dataGridViewMain_KAA.Rows[i].Selected = false;
                    for (int j = comboBoxSearch_KAA.SelectedIndex; j <= comboBoxSearch_KAA.SelectedIndex; j++)
                        if (fmain.dataGridViewMain_KAA.Rows[i].Cells[j].Value != null)
                            if (fmain.dataGridViewMain_KAA.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_KAA.Text))
                            {
                                fmain.dataGridViewMain_KAA.Rows[i].Selected = true;
                                break;
                            }
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка при поиске Преподавателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
