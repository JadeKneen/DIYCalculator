using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicCalculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button30_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((resultsBox.Text == "0")||(operation_pressed))
                resultsBox.Clear();
            Button b = (Button)sender;
            resultsBox.Text = resultsBox.Text + b.Text;

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            resultsBox.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(resultsBox.Text);
            operation_pressed = true;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    resultsBox.Text = (value + Double.Parse(resultsBox.Text)).ToString();
                    break;
                case "-":
                    resultsBox.Text = (value - Double.Parse(resultsBox.Text)).ToString();
                    break;
                case "/":
                    resultsBox.Text = (value / Double.Parse(resultsBox.Text)).ToString();
                    break;
                case "*":
                    resultsBox.Text = (value * Double.Parse(resultsBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;
        }
    }
}
