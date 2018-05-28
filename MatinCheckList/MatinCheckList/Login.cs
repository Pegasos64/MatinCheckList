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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            int err = Program.R.Login(tb_user.Text, tb_password.Text);
            if (err != -1)
            {
                MessageBox.Show("Kirjautuminen ei onnistunut. Virhekoodi: " + err);
            }else
            {
                MessageBox.Show("Kirjautuminen onnistui mainiosti!");
            }
            
        }
    }
}
