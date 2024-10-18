using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIccCalculator
{
    public partial class CalculatorForm : Form
    {
        static double result = 0;
        static string operation = "";
        static bool isOperationPerformed = false;
        static bool isDecimalUsed = false;
        static bool isZeroWholeUsed = false;
        static bool isOperatorUsed = false;

        private CalculatorClass calculatorClass;

        public CalculatorForm()
        {
            InitializeComponent();
            calculatorClass = new CalculatorClass();
        }

        // 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, .
        private void numericAndDecimal_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBoxPresentValue.Text = calculatorClass.HandleNumberAndDecimal(button.Text, textBoxPresentValue.Text);

            calculatorClass.PresentValue = textBoxPresentValue.Text;
        }

        // /, *, -, +, %
        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBoxPresentValue.Text = calculatorClass.HandleOperator(button.Text, textBoxPresentValue.Text);

            calculatorClass.PresentValue = textBoxPresentValue.Text;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            // avoid passing value from current to previous textBox after an operation
            if (textBoxPresentValue.Text == "Error" || textBoxPresentValue.Text == "Not Divisible by Zero" || textBoxPresentValue.Text == "Overflow") return; 

            textBoxPreviousValue.Text = textBoxPresentValue.Text;

            string result = calculatorClass.CalculateResult(textBoxPresentValue.Text);

            textBoxPresentValue.Text = result;

            ucHistoryForm.listBoxHistory.Items.Add(textBoxPreviousValue.Text + " = " + result);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            calculatorClass.Clear();
            textBoxPreviousValue.Text = calculatorClass.PreviousValue;
            textBoxPresentValue.Text = calculatorClass.PresentValue;
        }
        private void buttonClearRecentEntry_Click(object sender, EventArgs e)
        {
            calculatorClass.ClearRecentEntry();
            textBoxPresentValue.Text = calculatorClass.PresentValue;
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            buttonCalculator.Visible = false;
            buttonHistory.Visible = true;
            ucHistoryForm.Visible = false;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            buttonCalculator.Visible = true;
            buttonHistory.Visible = false;
            ucHistoryForm.Visible = true;
        }
    }
}
