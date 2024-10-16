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
        public CalculatorForm()
        {
            InitializeComponent();
        }

        // 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, .
        private void numericAndDecimal_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            isOperationPerformed = false;
            isOperatorUsed = false;

            if (button.Text == "0")
            {
                if (isZeroWholeUsed) return;

                if (!isDecimalUsed || (!isDecimalUsed && !isOperatorUsed))
                {
                    textBoxPresentValue.Text += "0";
                    isZeroWholeUsed = true;
                    return;
                }
                
            }

            if (button.Text == ".")
            {

                if (isDecimalUsed) return;  // avoid appending multiple decimal points

                // if textbox is empty or contains only ., . = 0. (if no other entry)
                if (textBoxPresentValue.Text.Length == 0 || textBoxPresentValue.Text == ".")
                {
                    textBoxPresentValue.Text = "0.";
                    isDecimalUsed = true; 
                    return;
                }

                // if the last char is any of the operator, . = 0. (if no other entry)
                if (textBoxPresentValue.Text.Length > 0)    
                {
                    char lastChar = textBoxPresentValue.Text[textBoxPresentValue.Text.Length - 1];

                    if ("+-*/%".Contains(lastChar))
                    {
                        textBoxPresentValue.Text += "0.";
                        isDecimalUsed = true;
                        return;
                    };
                }
     
                isDecimalUsed = true;
                isZeroWholeUsed = false;
            }

            textBoxPresentValue.Text += button.Text;
        }

        // /, *, -, +, %
        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            isOperationPerformed = false;
            isDecimalUsed = false;
            isZeroWholeUsed = false;
            isOperatorUsed = true;

            if (textBoxPresentValue.Text.Length == 0 && button.Text != "-") return; // allow negative value as the first value

            if (textBoxPresentValue.Text.Length > 0)    // avoid appending multiple operators
            {
                char lastChar = textBoxPresentValue.Text[textBoxPresentValue.Text.Length - 1];

                if ("+-*/%".Contains(lastChar)) textBoxPresentValue.Text = textBoxPresentValue.Text.Remove(textBoxPresentValue.Text.Length - 1);
            }

            textBoxPresentValue.Text += button.Text;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (isOperationPerformed == true) return;           // avoid passing value from current to previous textBox after an operation
                if (textBoxPresentValue.Text == "Error") return;    // avoid passing value from current to previous textBox after an operation with an Error

                textBoxPreviousValue.Text = textBoxPresentValue.Text;
                
                if (textBoxPresentValue.Text.Contains("/0")) throw new DivideByZeroException(); // checks if the expression is divided by 0

                var result = new DataTable().Compute(textBoxPresentValue.Text, null); // evaluate mathematical expression

                double convertedResult = Convert.ToDouble(result);

                textBoxPresentValue.Text = convertedResult.ToString();

                ucHistoryForm.listBoxHistory.Items.Add(textBoxPreviousValue.Text + " = " + convertedResult);

                isOperationPerformed = true;
                isDecimalUsed = false;
                isZeroWholeUsed = false;
                isOperatorUsed = false;
            }
            catch (DivideByZeroException)
            {
                textBoxPresentValue.Text = "Error";

                ucHistoryForm.listBoxHistory.Items.Add(textBoxPreviousValue.Text + " = Error");
            }
            catch (Exception)
            {
                textBoxPresentValue.Text = "Error";

                ucHistoryForm.listBoxHistory.Items.Add(textBoxPreviousValue.Text + " = Error");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPreviousValue.Text = "";
            textBoxPresentValue.Text = "";
            result = 0;
            operation = "";
            isOperationPerformed = false;
            isDecimalUsed = false;
            isOperatorUsed = false;
            isZeroWholeUsed = false;
        }
        private void buttonClearRecentEntry_Click(object sender, EventArgs e)
        {
            if (textBoxPresentValue.Text == "Error") textBoxPresentValue.Text = "";

            if (textBoxPresentValue.Text.Length > 0)
            {
                char lastChar = textBoxPresentValue.Text[textBoxPresentValue.Text.Length - 1];

                textBoxPresentValue.Text = textBoxPresentValue.Text.Remove(textBoxPresentValue.Text.Length - 1, 1);

                if (lastChar == '.')
                {
                    isDecimalUsed = false;
                    isZeroWholeUsed = true;
                }
            };
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
