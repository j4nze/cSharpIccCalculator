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

                if (LimitedDecimalFormat(PresentValue)) return PresentValue;

                if (input == "0")
                { 
                    
                    if (PresentValue == "0") return PresentValue;       // determine when to append zero, specifically if zero is leading
                    else PresentValue += "0";
                }
                else if (input == ".")
                {
                    if (!isDecimalInEntryUsed) PresentValue += ".";     // append decimal if its not used

                    isDecimalInEntryUsed = true;
                }
                else
                {
                    if (PresentValue == "0") PresentValue = input;      // overwrite 0 with a non zero value
                    else PresentValue += input;                         // append 0 (non leading)
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
                if (PresentValue == "Calculation Error" 
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") Clear();

                // using equals without any operator
                if (!isArithmeticOperationPerformed)    
                {
                    PresentValue = TrailingZeroDecimalFormat(Convert.ToDecimal(PresentValue));
                    PresentValue = ThousandSeparatorFormat(PresentValue);
                    Expression += " " + PresentValue;
                }
                else Expression = Result;
                
                string cleanedExpression = Expression.Replace(" ", "").Replace(",", "");
                if (Expression.Contains("/ 0")) throw new DivideByZeroException();                              // detect if expression has divisible by 0

                if (isPercentageOperatorInEntry) cleanedExpression = PercentageOperation(cleanedExpression);    // perform percentage calculation if % exists in the expression

                var result = new DataTable().Compute(cleanedExpression, null);                                  // calculate the expression using MDAS
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
                decimal baseValue = decimal.Parse(match.Groups[1].Value);                   // 1st value
                decimal percentage = decimal.Parse(match.Groups[3].Value);                  // 2nd value

                decimal percentageResult = (baseValue * percentage) / 100;                  // percentage formula

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

            bool lastCharIsDecimal = false;

            if (input.EndsWith(".")) lastCharIsDecimal = true;

            decimal convertedPresentValue = Convert.ToDecimal(input);
            convertedPresentValue = convertedPresentValue * -1;     // enable - sign to be toggled 
            PresentValue = convertedPresentValue.ToString();

            if (lastCharIsDecimal) PresentValue += ".";             // reattach decimal point

            PresentValue = ThousandSeparatorFormat(PresentValue);
            return PresentValue;
        }
        
        private string ThousandSeparatorFormat(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input == "-")
                return "0";

            bool isNegative = input.StartsWith("-");                                // detect negative sign
            string absoluteValue;

            if (isNegative) absoluteValue = input.Substring(1);                     // remove negative sign
            else absoluteValue = input;
         
            int decimalIndex = absoluteValue.IndexOf('.');                          // decimal point check
            string wholePart;
            string decimalPart;

            // whole and decimal number/s separation
            if (decimalIndex >= 0)
            {
                wholePart = absoluteValue.Substring(0, decimalIndex);
                decimalPart = absoluteValue.Substring(decimalIndex);
            }
            else
            {
                wholePart = absoluteValue;
                decimalPart = "";
            }

            wholePart = wholePart.Replace(",", "");                                 // clean the entry

            if (string.IsNullOrWhiteSpace(wholePart)) return "0" + decimalPart;     // check for empty integer

            string formattedIntegerPart = long.Parse(wholePart).ToString("#,##0");  // apply thousand separator

            string formattedValue = formattedIntegerPart + decimalPart;             // reattach decimal value
            
            if (isNegative) return "-" + formattedValue;                            // reattach negative sign if original value is negative
            
            return formattedValue;  
        }
        
        private string TrailingZeroDecimalFormat(decimal input)
        {
            string formattedString = "0.###############";   // apply custom string format, removes unecessary zero/s (.0 or .10 = 1)
            formattedString = input.ToString(formattedString);
            return formattedString;  
        }   // remove unecessary trailing zero/s

        private bool LimitedDecimalFormat(string value)
        {
            int decimalIndex = value.IndexOf('.');
            bool hasDecimal = decimalIndex != -1;
            bool exceedsLimit = hasDecimal && (value.Length - decimalIndex - 1) >= 15;   // limit decimal numbers to 15 digits

            return hasDecimal && exceedsLimit;  
        }

        public void Clear()
        {
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
                    PresentValue = PresentValue.Substring(0, PresentValue.Length - 1);      // remove the last character
                    PresentValue = ThousandSeparatorFormat(PresentValue);

                    if (!PresentValue.Contains(".")) isDecimalInEntryUsed = false;          // remove flag
                }

                // if present value length is empty or only has - (from negation), put 0 to avoid blank present value
                if (PresentValue.Length == 0 || PresentValue == "-") PresentValue = "0";    
            }

        }
    }
}