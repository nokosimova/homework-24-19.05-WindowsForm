using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void calcWindow_TextChanged(object sender, EventArgs e)
        {

        }
        private void num0_Click(object sender, EventArgs e)
        {

            if (calcWindow.Text != "0") calcWindow.Text = calcWindow.Text + "0";
        }
        private void num1_Click(object sender, EventArgs e)
        {
            if (calcWindow.Text == "0") calcWindow.Text = "";
            calcWindow.Text = calcWindow.Text + '1';
        }
        private void num2_Click(object sender, EventArgs e)
        {
            if (calcWindow.Text == "0") calcWindow.Text = "";
            calcWindow.Text = calcWindow.Text + '2';
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (calcWindow.Text == "0") calcWindow.Text = "";
            calcWindow.Text = calcWindow.Text + '3';
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (calcWindow.Text == "0") calcWindow.Text = "";
            calcWindow.Text = calcWindow.Text + '4';
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (calcWindow.Text == "0") calcWindow.Text = "";
            calcWindow.Text = calcWindow.Text + '5';
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (calcWindow.Text == "0") calcWindow.Text = "";
            calcWindow.Text = calcWindow.Text + '6';
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (calcWindow.Text == "0") calcWindow.Text = "";
            calcWindow.Text = calcWindow.Text + '7';
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (calcWindow.Text == "0") calcWindow.Text = "";
            calcWindow.Text = calcWindow.Text + '8';
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (calcWindow.Text == "0") calcWindow.Text = "";
            calcWindow.Text = calcWindow.Text + '9';
        }
    }
}
