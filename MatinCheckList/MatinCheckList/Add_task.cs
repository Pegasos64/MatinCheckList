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
        int i = 0;

        public Add_task()
        {
            InitializeComponent();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            if (errorCheck() == 1)
            {
                return;
            }
            Tehtava t = new Tehtava(tb_topic.Text, tb_info.Text, tb_ass.Text, (taskImportance) cb_imp.SelectedIndex);
            MessageBox.Show("Task: '" + tb_topic.Text + "' added");
            this.Close();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int errorCheck()
        {
            if (tb_topic.Text == "")
            {
                MessageBox.Show("Please add topic");
                return 1;
            }
            return 0;
        }

        private void Add_task_Load(object sender, EventArgs e)
        {
            cb_imp.SelectedIndex = 1;
            tb_ass.Text = "not assigned";
        }

        private void tb_ass_Click(object sender, EventArgs e)
        {
            tb_ass.SelectionStart = 0;
            tb_ass.SelectionLength = tb_ass.Text.Length;
        }
    }
}
