using System;
using MyWindowsApp.ServiceReference1;
using System.Windows.Forms;

// Author : Manoj.Karnatapu
// Purpose : To Create a C# Windows Forms Application & Consuming WebServices.

// For Reference, Check MyWindowsApp inside the MyConsoleApp in the same Repository.

namespace MyWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            AlgebraMathematicsSoapClient obj = new AlgebraMathematicsSoapClient();
            int n = Convert.ToInt32(textBox1.Text);

            textBox2.Text = obj.Factorial(n).ToString();

        }
    }
}
