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

    
    public partial class FormEditUser : Form
    {

        FormMain fmain;
        public FormEditUser(FormMain fm )
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = fmain.dataGridViewMain_KAA.CurrentRow.Index;
            fmain.dataGridViewMain_KAA.Rows[a].Cells[0].Value = textBoxID_KAA.Text;
            fmain.dataGridViewMain_KAA.Rows[a].Cells[1].Value = textBoxUserName_KAA.Text;
            fmain.dataGridViewMain_KAA.Rows[a].Cells[2].Value = textBoxAddress_KAA.Text;
            fmain.dataGridViewMain_KAA.Rows[a].Cells[3].Value = textBoxJob_KAA.Text;
            fmain.dataGridViewMain_KAA.Rows[a].Cells[4].Value = textBoxItem_KAA.Text;
            fmain.dataGridViewMain_KAA.Rows[a].Cells[5].Value = textBoxPhone_KAA.Text;
            fmain.dataGridViewMain_KAA.Rows[a].Cells[6].Value = textBoxTime_KAA.Text;
            fmain.dataGridViewMain_KAA.Rows[a].Cells[7].Value = textBoxAudience_KAA.Text;
            this.Close();

        }
    }
}
