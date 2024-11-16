using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string currentOperator;
        private double firstNumber;

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            displayBox.Text += button.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            currentOperator = button.Text;
            firstNumber = Convert.ToDouble(displayBox.Text);

            displayBox.Clear();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(displayBox.Text);
            double results = 0;

            switch (currentOperator) {
                case "+":
                    results = firstNumber + secondNumber;

                    break;

                case "-":
                    results = firstNumber - secondNumber;

                    break;

                case "X":
                    results = firstNumber * secondNumber;

                    break;

                case "/":
                    if (firstNumber != 0 && secondNumber != 0)
                    {
                        results = firstNumber / secondNumber;
                    }
                    else
                    {
                        results = 0; break;
                    }

                    break;
            }

            displayBox.Text = results.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            displayBox.Clear();

        }
    }
}
