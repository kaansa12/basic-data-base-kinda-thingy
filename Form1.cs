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



    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();


        List<string> Data = new List<string>();

        int last_ID_Counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void add_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_BT_Click(object sender, EventArgs e)
        {
            add();
        }

        private void get_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void get_BT_Click(object sender, EventArgs e)
        {
            get_TB.Text = get(Convert.ToInt32(get_TB.Text));
        }

        private void add()
        {
            Data.Add(add_TB.Text);
            last_Added_ID_LB.Text = "Your "+add_TB.Text+"' ID is "  + last_ID_Counter.ToString();
            add_TB.Text = "";
            last_ID_Counter++;
        }

        private string get(int a)
        {
            string[] array = Data.ToArray();

            return array[a];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(form2.canpass != true)
            {
                form2.ShowDialog();
            }
            else
            {
                string[] array = Data.ToArray();
                list_Box.Items.AddRange(array);
            }
            


        }

        private void sign_out_BT_Click(object sender, EventArgs e)
        {
            if(form2.canpass == true) {
                form2.canpass = false;
                MessageBox.Show("succesfully signed out");
            }
            else
            {
                MessageBox.Show("You aren't signed in");
            }
            

        }

        private void sign_in_BT_Click(object sender, EventArgs e)
        {
            if (form2.canpass == true)
            {
                MessageBox.Show("you already signed in");
            }
            else
            {
                form2.ShowDialog();

            }
        }
    }
}
