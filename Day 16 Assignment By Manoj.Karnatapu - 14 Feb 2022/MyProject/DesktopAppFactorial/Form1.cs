using System;
using System.Windows.Forms;
using ManojLibrary;
using PublicLibrary;

// Author : Manoj.Karnatapu
// Purpose : Creating desktop App, using ManojLibray.

// for Reference, check MyProject>DesktopAppFactorial. in the same Repository.
namespace DesktopAppFactorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            int factorial = Mathematics.Factorial(input);

            textBox2.Text = factorial.ToString();
        }
    }
}
