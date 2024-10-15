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
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false; 
        public CalculatorForm()
        {
            InitializeComponent();
        }

        // 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, .
        private void numericAndDecimal_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            isOperationPerformed = false;

            textBoxCurrentEntry.Text += button.Text;
        }

        // /, *, -, +, %
        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            isOperationPerformed = false;

            if (textBoxCurrentEntry.Text.Length == 0 && button.Text != "-") return; // allow negative value as the first value

            if (textBoxCurrentEntry.Text.Length > 0)    // avoid appending multiple operators
            {
                char lastChar = textBoxCurrentEntry.Text[textBoxCurrentEntry.Text.Length - 1];

                if ("+-*/%".Contains(lastChar)) textBoxCurrentEntry.Text = textBoxCurrentEntry.Text.Remove(textBoxCurrentEntry.Text.Length - 1);
            }

            textBoxCurrentEntry.Text += button.Text;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (isOperationPerformed == true) return;           // avoid passing value from current to previous textBox after an operation

                if (textBoxCurrentEntry.Text == "Error") return;    // avoid passing value from current to previous textBox after an operation with an Error

                textBoxPreviousEntry.Text = textBoxCurrentEntry.Text;
                
                if (textBoxCurrentEntry.Text.Contains("/0")) throw new DivideByZeroException(); // checks if the expression is divided by 0

                var result = new DataTable().Compute(textBoxCurrentEntry.Text, null); // evaluate mathematical expression

                textBoxCurrentEntry.Text = result.ToString();

                isOperationPerformed = true;    
            }
            catch (DivideByZeroException)
            {
                textBoxCurrentEntry.Text = "Error";
            }
            catch (Exception)
            {
                textBoxCurrentEntry.Text = "Error";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPreviousEntry.Text = "";
            textBoxCurrentEntry.Text = "";
            result = 0;
            operation = "";
            isOperationPerformed = false;
        }
        private void buttonClearRecentEntry_Click(object sender, EventArgs e)
        {
            if (textBoxCurrentEntry.Text == "Error") textBoxCurrentEntry.Text = "";

            if (textBoxCurrentEntry.Text.Length > 0) textBoxCurrentEntry.Text = textBoxCurrentEntry.Text.Remove(textBoxCurrentEntry.TextLength - 1, 1);

            if (textBoxCurrentEntry.Text == "") return;
        }
    }
}
