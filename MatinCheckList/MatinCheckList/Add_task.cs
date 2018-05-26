using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatinCheckList
{
    public partial class Add_task : Form
    {
        public Add_task()
        {
            InitializeComponent();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            Tehtava t = new Tehtava(tb_topic.Text, tb_info.Text, tb_ass.Text, (taskImportance) cb_imp.SelectedIndex);
            MessageBox.Show("Task: " + tb_topic.Text + " added");
            this.Close();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
