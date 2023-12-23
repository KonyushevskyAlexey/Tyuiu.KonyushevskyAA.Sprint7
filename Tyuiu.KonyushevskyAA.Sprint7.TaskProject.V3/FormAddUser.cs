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
    public partial class FormAddUser : Form
    {

        FormMain  fmain;
        public FormAddUser(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonAddNewUser_KAA_Click(object sender, EventArgs e)
        {
            fmain.dataGridViewMain_KAA.Rows.Add(textBoxID_KAA.Text, textBoxUserName_KAA.Text, textBoxAddress_KAA.Text, textBoxJob_KAA.Text, textBoxItem_KAA.Text, textBoxPhone_KAA.Text, textBoxTime_KAA.Text, textBoxAudience_KAA.Text);
            fmain.buttonDelete_KAA.Enabled = true;
            this.Close();

        }
    }
}
