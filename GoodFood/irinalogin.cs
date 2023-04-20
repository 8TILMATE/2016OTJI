using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodFood
{
    public partial class irinalogin : Form
    {
        public irinalogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool x = DatabaseHelper.LoginVerify(textBox1.Text, textBox2.Text);
            if (x == false)
            {
                MessageBox.Show("something is off");
            }
            else
            {
                MessageBox.Show("You're in mate");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
