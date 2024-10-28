using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cSharpIccCalculator
{
    class CalculatorHandler
    {
        public static string Expression = "";
        private static string Result = "";
        public static string Equation = "";

        private static bool isDecimalInEntryUsed = false;
        private static bool isOperatorInEntryUsed = false;
        private static bool isArithmeticOperationPerformed = false;
        private static bool isPercentageOperatorInEntry = false;

        public string PresentValue { get; set; } = "0";
        public string PreviousValue { get; set; } = "";

        public string NumberAndDecimal(string input)
        {
            try
            {
                // Perform Clear if the result is an error
                if (PresentValue == "Calculation Error"
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") Clear();

                if (isOperatorInEntryUsed)
                {
                    PresentValue = "";
                    isDecimalInEntryUsed = false;
                    isOperatorInEntryUsed = false;
                    isArithmeticOperationPerformed = false;
                } 

                if (isArithmeticOperationPerformed) Clear();

                if (input == "0")
                { 
                    if (LimitedDecimalFormat(PresentValue)) return PresentValue;

                    // determine when to append zero, specifically if zero is leading
                    if (PresentValue == "0") return PresentValue;
                    else PresentValue += "0";
                }
                else if (input == ".")
                {
                    if (!isDecimalInEntryUsed && (PresentValue.Length == 0 || !char.IsDigit(PresentValue[PresentValue.Length - 1])))
                    {
                        PresentValue += "0.";   // append 0. if clicking only decimal and the present value is empty
                        isDecimalInEntryUsed = true;
                    }
                    else if (!isDecimalInEntryUsed)
                    {
                        PresentValue += ".";    // append decimal if there is already a number
                        isDecimalInEntryUsed = true;
                    }
                }
                else
                {
                    if (LimitedDecimalFormat(PresentValue)) return PresentValue;

                    if (PresentValue == "0") PresentValue = input;  // overwrite 0 with a non zero value
                    else PresentValue += input; // append 0
                }

                PresentValue = ThousandSeparatorFormat(PresentValue);

                return PresentValue;
            }
            catch (Exception)
            {
                return PresentValue;
            }
        }

        public string Operator(string input)
        {
            try
            {
                // keep the previous value as is
                if (PresentValue == "Calculation Error"
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") return PreviousValue = Expression + " =";

                PresentValue = TrailingZeroDecimalFormat(Convert.ToDecimal(PresentValue)).ToString();
                PresentValue = ThousandSeparatorFormat(PresentValue);

                // flag the expression if it contains %
                if (input == "%") isPercentageOperatorInEntry = true;
                
                if (isArithmeticOperationPerformed)
                {
                    Expression = "";
                    Expression += Result;
                }
                else
                {
                    // determine if the last character of the expression is an operator and enable ovewrite
                    if (!string.IsNullOrEmpty(Expression) && isOperatorInEntryUsed)
                    {
                        char lastChar = Expression.Last();

                        if ("+-*/%".Contains(lastChar)) Expression = Expression.Substring(0, Expression.Length - 2);
                    }
                    else Expression += " " + PresentValue;
                }

                Expression += " " + input;
                PreviousValue = Expression;
                isDecimalInEntryUsed = false;
                isOperatorInEntryUsed = true;
                isArithmeticOperationPerformed = false;

                return PreviousValue;
            }
            catch (Exception)
            {
                return PreviousValue;
            }
        }

        public string Operation()
        {
            try
            {
                // Perform Clear if the result is an error
                if (PresentValue == "Calculation Error" 
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") Clear();

                if (!isArithmeticOperationPerformed)    // using equals without any operator
                {
                    PresentValue = TrailingZeroDecimalFormat(Convert.ToDecimal(PresentValue));
                    PresentValue = ThousandSeparatorFormat(PresentValue);
                    Expression += " " + PresentValue;
                }
                else Expression = Result;
                
                string cleanedExpression = Expression.Replace(" ", "").Replace(",", "");
                if (Expression.Contains("/ 0")) throw new DivideByZeroException();

                // perform percentage calculation if % exists in the expression
                if (isPercentageOperatorInEntry) cleanedExpression = PercentageOperation(cleanedExpression);

                // calculate the remaining expression using MDAS
                var result = new DataTable().Compute(cleanedExpression, null);
                decimal convertedResult = Convert.ToDecimal(result);
                
                Result = TrailingZeroDecimalFormat(convertedResult);
                PresentValue = TrailingZeroDecimalFormat(convertedResult);
                
                Result = ThousandSeparatorFormat(Result);
                PresentValue = ThousandSeparatorFormat(PresentValue);
                
                Equation = (Expression + " = " + Result).Trim();
                PreviousValue = (Expression + " =").Trim();
                isDecimalInEntryUsed = false;
                isOperatorInEntryUsed = false;
                isArithmeticOperationPerformed = true;
                
                return PresentValue;
            }
            catch (DivideByZeroException)
            {
                Equation = (Expression + " = Not Divisible by Zero").Trim();
                return PresentValue = "Not Divisible by Zero";
            }
            catch (OverflowException)
            {
                Equation = (Expression + " = Overflow").Trim();
                return PresentValue = "Overflow";
            }
            catch (Exception)
            {
                Equation = (Expression + " = Calculation Error").Trim();
                return PresentValue = "Calculation Error";
            }
        }

        private string PercentageOperation(string expression)
        {
            var matches = Regex.Matches(expression, @"(\d+(\.\d+)?)\s*%\s*(\d+(\.\d+)?)");  // determine percentage values to compute

            // find the matches
            foreach (Match match in matches)
            {
                decimal baseValue = decimal.Parse(match.Groups[1].Value);
                decimal percentage = decimal.Parse(match.Groups[3].Value);

                decimal percentageResult = (baseValue * percentage) / 100;  // percentage formula

                // replace the identified percentage values and replace it with the computed percentage value
                expression = expression.Replace(match.Value, percentageResult.ToString()); 
                isPercentageOperatorInEntry = false;
            }

            return expression;
        }

        public string PlusMinusSign(string input)
        {
            if (input == "Calculation Error"
                || input == "Not Divisible by Zero"
                || input == "Overflow") return input;

            double convertedPresentValue = Convert.ToDouble(input);
            convertedPresentValue = convertedPresentValue * -1; // enable - sign to be toggled 
            PresentValue = convertedPresentValue.ToString();
            PresentValue = TrailingZeroDecimalFormat(Convert.ToDecimal(PresentValue)).ToString();
            PresentValue = ThousandSeparatorFormat(PresentValue);
            return PresentValue;
        }
        
        private string ThousandSeparatorFormat(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "0";

            // decimal point check
            int decimalIndex = input.IndexOf('.');
            string wholePart;
            string decimalPart;

            // whole and decimal numbers separation
            if (decimalIndex >= 0)
            {
                wholePart = input.Substring(0, decimalIndex);
                decimalPart = input.Substring(decimalIndex);
            }
            else
            {
                wholePart = input;
                decimalPart = "";
            }

            // clean the entry (especially for NumberAndDecimal method)
            wholePart = wholePart.Replace(",", "");

            // check for empty integer
            if (string.IsNullOrWhiteSpace(wholePart)) return "0" + decimalPart;


            // apply thousand separator
            string formattedIntegerPart = string.Empty;
            int length = wholePart.Length;

            for (int i = 0; i < length; i++)
            {
                // append comma in every 3 digit
                if (i > 0 && (length - i) % 3 == 0) formattedIntegerPart += ",";

                formattedIntegerPart += wholePart[i];
            }

            // reattach decimal if it exists
            return formattedIntegerPart + decimalPart;
        }
        
        private string TrailingZeroDecimalFormat(decimal value, int limit = 15)
        {
            // apply 0.## format, removes unecessary zero/s (.0 or .10 = 1)
            decimal roundedValue = Math.Round(value, limit);
            return roundedValue.ToString("0.###############");
        }   // remove unecessary trailing zero/s

        private bool LimitedDecimalFormat(string value, int limit = 15)
        {
            int decimalIndex = value.IndexOf('.');
            bool hasDecimal = decimalIndex != -1;
            bool exceedsLimit = hasDecimal && (value.Length - decimalIndex - 1) >= limit;

            return hasDecimal && exceedsLimit;  // limit decimal numbers to 15 digits
        }

        public void Clear()
        {
            // Reset state
            PresentValue = "0";
            PreviousValue = "";
            Expression = "";
            Result = "";
            isDecimalInEntryUsed = false;
            isOperatorInEntryUsed = false;
            isArithmeticOperationPerformed = false;
            isPercentageOperatorInEntry = false;
        }

        public void ClearRecentEntry()
        {
            // Perform Clear if the result is an error
            if (PresentValue == "Calculation Error"
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow")
            {
                Clear();
                return;
            }

            if (isArithmeticOperationPerformed) PreviousValue = "";
            else
            {
                if (PresentValue.Length >= 1)
                {
                    // remove the last character
                    PresentValue = PresentValue.Substring(0, PresentValue.Length - 1);

                    // remove flag
                    if (!PresentValue.Contains(".")) isDecimalInEntryUsed = false;
                }

                // if present value reaches empty, put 0 to avoid blank present value
                if (PresentValue.Length == 0 || PresentValue == "-" || PresentValue == "+") PresentValue = "0";
            }

        }
    }
}