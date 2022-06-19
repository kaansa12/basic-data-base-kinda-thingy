using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_DBase
{
    public partial class Form2 : Form
    {
        public bool canpass = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void done_bt_Click(object sender, EventArgs e)
        {
            if(username.Text == "kaan"&&passcode.Text == "1234")
            {
               canpass = true;
                this.Hide();

            }
            else
            {
                username.Text = "false sign up request";
            }
        }
    }
}
