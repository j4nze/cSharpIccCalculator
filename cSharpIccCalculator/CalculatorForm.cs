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
        private CalculatorClass calculatorClass;
        private static bool isCalculationSuccess;
        public CalculatorForm()
        {
            InitializeComponent();
            calculatorClass = new CalculatorClass();
            this.KeyPreview = true;
            this.KeyDown += CalculatorForm_KeyDown;
            isCalculationSuccess = false;
        }

        // 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, .
        private void numericAndDecimal_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxPresentValue.Text = calculatorClass.HandleNumberAndDecimal(button.Text);
            calculatorClass.PresentValue = textBoxPresentValue.Text;
        }

        // /, *, -, +, %
        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxPresentValue.Text = calculatorClass.HandleOperator(button.Text);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textBoxPresentValue.Text.Length > 0)
            {
                char lastChar = textBoxPresentValue.Text[textBoxPresentValue.Text.Length - 1];
                if ("+-*/%".Contains(lastChar)) return;                  
            }

            if (textBoxPresentValue.Text == "0") return;

            string result = calculatorClass.CalculateResult();

            if (result == "Calculation Error" || result == "Not Divisible by Zero" || result == "Overflow")
            {
                if (!isCalculationSuccess || textBoxPresentValue.Text != result)
                {
                    textBoxPreviousValue.Text = calculatorClass.PreviousValue;
                    textBoxPresentValue.Text = result;
                    ucHistoryForm.listBoxHistory.Items.Add(textBoxPreviousValue.Text + " = " + result);
                    isCalculationSuccess = true;
                }
                return;
            }
            else
            {
                textBoxPreviousValue.Text = calculatorClass.PreviousValue;
                textBoxPresentValue.Text = result;
                ucHistoryForm.listBoxHistory.Items.Add(textBoxPreviousValue.Text + " = " + result);
                isCalculationSuccess = false;
            }
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

        private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ignore control characters (e.g., Enter, Backspace)
            if (char.IsControl(e.KeyChar)) return;

            // enable numeric and decimal keys
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                textBoxPresentValue.Text = calculatorClass.HandleNumberAndDecimal(e.KeyChar.ToString());
                e.Handled = true;
            }

            // enable operators (numeric pads with/ without shift key)
            if ("+-*/%".Contains(e.KeyChar))
            {
                textBoxPresentValue.Text = calculatorClass.HandleOperator(e.KeyChar.ToString());
                e.Handled = true;
            }

            // enable enter key as equals - no func
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxPresentValue.Text = calculatorClass.CalculateResult();
                e.Handled = true;
            }

            // enable escape key as clear - no func
            if (e.KeyChar == (char)Keys.Escape)
            {
                calculatorClass.Clear();
                textBoxPresentValue.Text = "";
                e.Handled = true;
            }
        }

        private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                calculatorClass.ClearRecentEntry();
                textBoxPresentValue.Text = calculatorClass.PresentValue;
                e.Handled = true;
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                calculatorClass.Clear();
                textBoxPreviousValue.Text = calculatorClass.PreviousValue;
                textBoxPresentValue.Text = calculatorClass.PresentValue;
                e.Handled = true; 
                return;
            }

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                string result = calculatorClass.CalculateResult();
                textBoxPreviousValue.Text = calculatorClass.PreviousValue;
                textBoxPresentValue.Text = result;
                ucHistoryForm.listBoxHistory.Items.Add(textBoxPreviousValue.Text + " = " + result);
                e.Handled = true;
                return;
            }
        }
    }
}
