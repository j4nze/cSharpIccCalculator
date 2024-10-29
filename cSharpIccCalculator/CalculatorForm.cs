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
        private CalculatorHandler calcHandler;
        private HistoryHandler histHandler;

        public CalculatorForm()
        {
            InitializeComponent();
            calcHandler = new CalculatorHandler();
            histHandler = new HistoryHandler();
            this.KeyPreview = true;
            this.KeyPress += CalculatorForm_KeyPress;
            this.KeyDown += CalculatorForm_KeyDown;
        }

        // =============================================== INPUT/ OUTPUT HANDLER
        private void NumericAndDecimalHandler(string input)
        {
            customizedNoCaretTextBoxPresentValue.Text = calcHandler.NumberAndDecimal(input);
            calcHandler.PresentValue = customizedNoCaretTextBoxPresentValue.Text;
            textBoxPreviousValue.Text = calcHandler.PreviousValue;
        }   // 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, .
        private void OperatorHandler(string input)
        {
            textBoxPreviousValue.Text = calcHandler.Operator(input);
            customizedNoCaretTextBoxPresentValue.Text = calcHandler.PresentValue;
        }            // /, *, -, +, %
        private void PlusMinusSignHandler(string input)
        {
            customizedNoCaretTextBoxPresentValue.Text = calcHandler.PlusMinusSign(input);
            calcHandler.PresentValue = customizedNoCaretTextBoxPresentValue.Text;
        }       // +/-
        private void CalculationHandler()
        {
            if (calcHandler.PresentValue == "Calculation Error" 
                || calcHandler.PresentValue == "Not Divisible by Zero" 
                || calcHandler.PresentValue == "Overflow") ClearHandler();
            else
            {
                string result = calcHandler.Operation();
                textBoxPreviousValue.Text = (CalculatorHandler.Expression + " =").Trim();
                customizedNoCaretTextBoxPresentValue.Text = result;

                if (HistoryForm.isListEmpty)
                {
                    histHandler.ClearHistory(); // clear the list from handler to avoid reappearing old entries
                    HistoryForm.isListEmpty = false;
                }

                string entry = CalculatorHandler.Equation;
                ucHistoryForm.listBoxHistory.Items.Clear(); // clear the listbox items to put the new list (with new entry)
                histHandler.AddEntry(entry);
                ucHistoryForm.listBoxHistory.Items.AddRange(histHandler.GetHistory().ToArray());
                ucHistoryForm.buttonClearHistory.Visible = true;
            }
        }
        private void ClearHandler()
        {
            calcHandler.Clear();
            textBoxPreviousValue.Text = calcHandler.PreviousValue;
            customizedNoCaretTextBoxPresentValue.Text = calcHandler.PresentValue;
        }
        private void ClearRecentEntryHandler()
        {
            calcHandler.ClearRecentEntry();
            textBoxPreviousValue.Text = calcHandler.PreviousValue;
            customizedNoCaretTextBoxPresentValue.Text = calcHandler.PresentValue;
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
            customizedNoCaretTextBoxPresentValue.Focus();
        }
        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OperatorHandler(button.Text);
            customizedNoCaretTextBoxPresentValue.Focus();
        }
        private void customizedBorRadButtonPlusMinus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            PlusMinusSignHandler(customizedNoCaretTextBoxPresentValue.Text);
            customizedNoCaretTextBoxPresentValue.Focus();
        }
        private void customizedBorRadButtonEqual_Click(object sender, EventArgs e)
        {
            CalculationHandler();
            customizedNoCaretTextBoxPresentValue.Focus();
        }
        private void customizedBorRadButtonClear_Click(object sender, EventArgs e)
        {
            ClearHandler();
            customizedNoCaretTextBoxPresentValue.Focus();
        }
        private void customizedBorRadButtonClearRecentEntry_Click(object sender, EventArgs e)
        {
            ClearRecentEntryHandler();
            customizedNoCaretTextBoxPresentValue.Focus();
        }
        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            CalculatorDisplayHandler();
            customizedNoCaretTextBoxPresentValue.Focus();
        }
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            HistoryDisplayHandler();
            customizedNoCaretTextBoxPresentValue.Focus();
        }

        // ================================================ KEY EVENT
        private async void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                await NumberDecimalKeyEffect(e.KeyChar);
                NumericAndDecimalHandler(e.KeyChar.ToString());
            }
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '%')
            {
                await OperatorKeyEffect(e.KeyChar);
                OperatorHandler(e.KeyChar.ToString());
            }
            else if (e.KeyChar == '=')
            {
                EqualKeyEffect();
                CalculationHandler();
            }
            else if (char.ToLower(e.KeyChar) == 'c')
            {
                await HistoryCalculatorKeyEffect(buttonCalculator);
                CalculatorDisplayHandler();
            }
            else if (char.ToLower(e.KeyChar) == 'h')
            {
                await HistoryCalculatorKeyEffect(buttonHistory);
                HistoryDisplayHandler();
            }
            e.Handled = true;
        }
        private async void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                await ClearKeyEffect(customizedBorRadButtonClearEntry);
                ClearRecentEntryHandler();
            }

            if (e.KeyCode == Keys.Escape)
            {
                await ClearKeyEffect(customizedBorRadButtonClear);
                ClearHandler();
            }

            if (e.KeyCode == Keys.Enter)
            {
                EqualKeyEffect();
                CalculationHandler();
            }

            e.Handled = true;
        }

        // ================================================ KEY EFFECT
        private async Task NumberDecimalKeyEffect(char input)
        {
            Button button;

            switch (input)
            {
                case '1':
                    button = customizedBorRadButton1;
                    break;
                case '2':
                    button = customizedBorRadButton2;
                    break;
                case '3':
                    button = customizedBorRadButton3;
                    break;
                case '4':
                    button = customizedBorRadButton4;
                    break;
                case '5':
                    button = customizedBorRadButton5;
                    break;
                case '6':
                    button = customizedBorRadButton6;
                    break;
                case '7':
                    button = customizedBorRadButton7;
                    break;
                case '8':
                    button = customizedBorRadButton8;
                    break;
                case '9':
                    button = customizedBorRadButton9;
                    break;
                case '0':
                    button = customizedBorRadButton0;
                    break;
                case '.':
                    button = customizedBorRadButtonDecimal;
                    break;
                default:
                    button = null;
                    break;
            }

            if (button != null)
            {
                button.BackColor = Color.FromArgb(80, 90, 100);
                await Task.Delay(150);
                button.BackColor = Color.FromArgb(58, 65, 79);
            }
        }              // NUMBER/ DECIMAL
        private async Task OperatorKeyEffect(char input)
        {
            Button button;

            switch (input)
            {
                case '+':
                    button = customizedBorRadButtonAddition;
                    break;
                case '-':
                    button = customizedBorRadButtonSubtraction;
                    break;
                case '*':
                    button = customizedBorRadButtonMultiplication;
                    break;
                case '/':
                    button = customizedBorRadButtonDivision;
                    break;
                case '%':
                    button = customizedBorRadButtonPercent;
                    break;
                default:
                    button = null;
                    break;
            }

            if (button != null)
            {
                button.BackColor = Color.FromArgb(62, 68, 81);
                await Task.Delay(150);
                button.BackColor = Color.FromArgb(45, 50, 61);
            }
        }                   // OPERATOR
        private async void EqualKeyEffect()
        {
            customizedBorRadButtonEqual.BackColor = Color.FromArgb(36, 158, 95);
            await Task.Delay(150);
            customizedBorRadButtonEqual.BackColor = Color.FromArgb(6, 128, 65);
        }                                // EQUAL
        private async Task ClearKeyEffect(Button button)
        {
            if (button != null)
            {
                button.BackColor = Color.FromArgb(62, 68, 81);
                await Task.Delay(150);
                button.BackColor = Color.FromArgb(45, 50, 61);
            }
        }                   // CLEAR/ CLEAR RECENT
        private async Task HistoryCalculatorKeyEffect(Button button)
        {
            if (button != null)
            {
                button.BackColor = Color.FromArgb(80, 90, 100);
                await Task.Delay(150);
                button.BackColor = Color.FromArgb(58, 65, 79);
            }
        }       // HISTORY/ CALCULATOR
    }
}
