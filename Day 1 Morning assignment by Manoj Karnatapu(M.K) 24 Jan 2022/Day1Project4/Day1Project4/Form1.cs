using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(textBox1.Text);
            int secondNumber = Convert.ToInt32(textBox2.Text);

            int p = 1;

            for (int i = 1; i <= secondNumber; i++)
                p *= firstNumber; 

            textBox3.Text = p.ToString();
        }

    }
}
