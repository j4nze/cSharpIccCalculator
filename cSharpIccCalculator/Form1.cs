using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIccCalculator
{
    public partial class CalculatorForm : Form
    {
        double result = 0;
        string operation = "";
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
 
        private void numericValues_click(object sender, EventArgs e)
        {

        }

        private void operations_click(object sender, EventArgs e)
        {
            
        }
        
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                case "%":
                    break;
                default:
                    break;
            }

            textBoxPreviousEntry.Text = textBoxCurrentEntry.Text;
            operation = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPreviousEntry.Text = "";
            textBoxCurrentEntry.Text = "0";
            result = 0;
            operation = "";
        }
        private void buttonClearRecentEntry_Click(object sender, EventArgs e)
        {
            if (textBoxCurrentEntry.Text.Length > 0)
            {
                textBoxCurrentEntry.Text = textBoxCurrentEntry.Text.Remove(textBoxCurrentEntry.TextLength - 1, 1);
            }

            if (textBoxCurrentEntry.Text == "") textBoxCurrentEntry.Text = "0";
        }
    }
}
