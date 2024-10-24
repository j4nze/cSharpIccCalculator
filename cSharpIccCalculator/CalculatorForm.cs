using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIccCalculator
{
    public partial class CalculatorForm : Form
    {
        private CalculatorClass calculatorClass;

        public CalculatorForm()
        {
            InitializeComponent();
            calculatorClass = new CalculatorClass();
            this.KeyPreview = true;
            this.KeyPress += CalculatorForm_KeyPress;
            this.KeyDown += CalculatorForm_KeyDown;
            customizedNoCaretTextBoxPresentValue.SelectionStart = customizedNoCaretTextBoxPresentValue.Text.Length;
            customizedNoCaretTextBoxPresentValue.SelectionLength = customizedNoCaretTextBoxPresentValue.Text.Length;
           
        }

        // 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, .
        private void NumericAndDecimalHandler(string input)
        {
            customizedNoCaretTextBoxPresentValue.Text = calculatorClass.HandleNumberAndDecimal(input);
            calculatorClass.PresentValue = customizedNoCaretTextBoxPresentValue.Text;
            textBoxPreviousValue.Text = calculatorClass.PreviousValue;
        }
        // /, *, -, +, %
        private void OperatorHandler(string input)
        {
            textBoxPreviousValue.Text = calculatorClass.HandleOperator(input);
            customizedNoCaretTextBoxPresentValue.Text = calculatorClass.PresentValue;
        }
        private void CalculationHandler()
        {
            if (calculatorClass.PresentValue == "Calculation Error" 
                || calculatorClass.PresentValue == "Not Divisible by Zero" 
                || calculatorClass.PresentValue == "Overflow") ClearHandler();
            else
            {
                string result = calculatorClass.CalculateResult();
                textBoxPreviousValue.Text = (CalculatorClass.Expression + " =").Trim();
                customizedNoCaretTextBoxPresentValue.Text = result;
                ucHistoryForm.listBoxHistory.Items.Add(CalculatorClass.Equation);
            }

        }
        private void ClearHandler()
        {
            calculatorClass.Clear();
            textBoxPreviousValue.Text = calculatorClass.PreviousValue;
            customizedNoCaretTextBoxPresentValue.Text = calculatorClass.PresentValue;
        }
        private void ClearRecentEntryHandler()
        {
            calculatorClass.ClearRecentEntry();
            textBoxPreviousValue.Text = calculatorClass.PreviousValue;
            customizedNoCaretTextBoxPresentValue.Text = calculatorClass.PresentValue;
        }
        private void CalculatorDisplayHandler()
        {
            buttonCalculator.Visible = false;
            buttonHistory.Visible = true;
            ucHistoryForm.Visible = false;
        }
        private void HistoryDisplayHandler()
        {
            buttonCalculator.Visible = true;
            buttonHistory.Visible = false;
            ucHistoryForm.Visible = true;
        }
        
        
        //  ============================================== CLICK EVENT
        private void numericAndDecimal_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            NumericAndDecimalHandler(button.Text);
        }
        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OperatorHandler(button.Text);
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            CalculationHandler();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearHandler();
        }
        private void buttonClearRecentEntry_Click(object sender, EventArgs e)
        {
            ClearRecentEntryHandler();
        }
        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            CalculatorDisplayHandler();
        }
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            HistoryDisplayHandler();
        }

        // ================================================ KEY EVENT
        private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                NumericAndDecimalHandler(e.KeyChar.ToString());
            }
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '%')
            {
                OperatorHandler(e.KeyChar.ToString());
            }
            else if (e.KeyChar == '=')
            {
                e.Handled = true;
                CalculationHandler();
            }
            else if (char.ToLower(e.KeyChar) == 'c')
            {
                CalculatorDisplayHandler();
            }
            else if (char.ToLower(e.KeyChar) == 'h')
            {
                HistoryDisplayHandler();
            }
        }
        private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                ClearRecentEntryHandler();
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                ClearHandler();
                e.Handled |= true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                CalculationHandler();
                e.Handled = true;
            }
        }

        private void textBoxPresentValue_TextChanged(object sender, EventArgs e)
        {
            customizedNoCaretTextBoxPresentValue.SelectionStart = customizedNoCaretTextBoxPresentValue.Text.Length;
            customizedNoCaretTextBoxPresentValue.SelectionLength = customizedNoCaretTextBoxPresentValue.Text.Length;
        }
        //protected override void OnShown(EventArgs e)
        //{
        //    base.OnShown(e);
        //    this.Focus();
        //}
    }
}
