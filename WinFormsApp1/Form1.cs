using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] mass = { { "adm", "adm" }, { "kik", "kik" }, { "varax", "rur" }, { "jojo", "top" }, { "kick", "butovski" } };
            int a = 0;
            for (int i = 0; i <= 4; i++)
            {
                
                if (textBox1.Text == mass[i, 0] && textBox2.Text == mass[i, 1])
                {
                    a = i + 2;
                    MessageBox.Show("U`re welcome!");
                    break;
                }
                

            }

            if (a < 1)
            {
                MessageBox.Show("Incorrect login/password. Try again!");
            }



        }
    }
}
