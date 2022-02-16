using System;
using System.Windows.Forms;
using ManojLibrary;

// Author : Manoj.Karnatapu
// Purpose : Creating a Layered Architecture for given
//           Business Requirements In Windows Desktop Application.

// For Reference, Check Day18Project1 in the same Repository.

namespace WindowsDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int result = Algebra.Factorial(n);
            textBox2.Text = result.ToString();

            Console.ReadLine();
        }
    }
}
