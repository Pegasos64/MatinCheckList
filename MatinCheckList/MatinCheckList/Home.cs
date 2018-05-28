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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            Add_task add_window = new Add_task();
            add_window.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.L.Close();
        }
    }
}
