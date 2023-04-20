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
    public partial class irinasignin : Form
    {
        public irinasignin()
        {
            InitializeComponent();
        }
        public List<string> jijibecali = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            jijibecali.Clear();

            foreach (TextBox x in this.Controls.OfType<TextBox>())
            {
                Console.WriteLine(x.Text);
                jijibecali.Add(x.Text);
            }
            if (jijibecali[1] == jijibecali[2])
            {
                try
                {
                    var x = new System.Net.Mail.MailAddress(jijibecali[0]);
                    if(!DatabaseHelper.LoginVerify(jijibecali[0], jijibecali[1]))
                    {
                       // DatabaseHelper.CreeareCont()
                        DatabaseHelper.CreeareCont(jijibecali[5], jijibecali[4], jijibecali[0], jijibecali[1], jijibecali[3]);
                        MessageBox.Show("Cont creat cu succes!");
                    }
                    else
                    {
                        MessageBox.Show("Contul deja exista in Database");
                    }
                }
                catch
                {
                    MessageBox.Show("Nu ai pus un email valid");
                }
            }
            else
            {
                MessageBox.Show("Parolele introduse de tine nu se potrivesc");
            }
        }
    }
}
