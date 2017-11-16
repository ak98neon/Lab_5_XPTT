using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_XPTT
{
    public partial class Form1 : Form
    {
        int a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(editA.Text);
                int res = MyDel(a);
            } catch (DivideByZeroException)
            {
                textBox1.Text = "Деление на 0 detected!!!";
            }
        }

        public int MyDel(int a)
        {
            return a/0;
        }
    }
}
