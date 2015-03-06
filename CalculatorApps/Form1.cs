using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aButton_Click(object sender, EventArgs e)
        {


            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int sum = firstNumber + secondNumber;
            sumTextBox.Text = sum.ToString();


            int a = Convert.ToInt32(Txt_1.Text);
            int b = Convert.ToInt32(Txt_2.Text);

            Ans.Text = a + b;

        }

        private void sButton_Click(object sender, EventArgs e)
        {

        }

        private void dButton_Click(object sender, EventArgs e)
        {

        }

        private void mButton_Click(object sender, EventArgs e)
        {

        }
    }
}
