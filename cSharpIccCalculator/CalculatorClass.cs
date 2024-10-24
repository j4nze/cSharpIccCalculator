using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cSharpIccCalculator
{
    class CalculatorClass
    {
        public static string Expression = "";
        private static string Result = "";
        public static string Equation = "";

        private static bool isDecimalInEntryUsed = false;
        private static bool isArithmeticOperatorInEntryUsed = false;
        private static bool isArithmeticOperationPerformed = false;
        private static bool isPercentageOperationPerformed = false;

        public string PresentValue { get; set; } = "0";
        public string PreviousValue { get; set; } = "";

        public string HandleNumberAndDecimal(string input)
        {
            try
            {
                // Perform Clear if the result is an error
                if (PresentValue == "Calculation Error"
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") Clear();

                if (isArithmeticOperationPerformed && Result == "0")
                {
                    PreviousValue = "";
                    Expression = "";
                    Equation = "";
                }

                if (isArithmeticOperatorInEntryUsed)
                {
                    PresentValue = "";
                    isDecimalInEntryUsed = false;
                    isArithmeticOperatorInEntryUsed = false;
                    isArithmeticOperationPerformed = false;
                    isPercentageOperationPerformed = false;
                } 
                if (isArithmeticOperationPerformed) Clear();


                if (input == "0")
                {
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
                    if (PresentValue == "0") PresentValue = input;  // overwrite 0 with a non zero value
                    else PresentValue += input; // append 0
                }
                return PresentValue;
            }
            catch (Exception)
            {
                return PresentValue;
            }
        }

        public string HandleOperator(string input)
        {
            try
            {
                // keep the previous value as is
                if (PresentValue == "Calculation Error"
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") return PreviousValue = Expression + " =";

                // flag the expression if it contains %
                if (input == "%") isPercentageOperationPerformed = false;
                else isPercentageOperationPerformed = true;

                if (isArithmeticOperationPerformed)
                {
                    Expression = "";
                    Expression += Result;
                }
                else
                {
                    // determine if the last character of the expression is an operator and enable ovewrite
                    if (!string.IsNullOrEmpty(Expression) && isArithmeticOperatorInEntryUsed)
                    {
                        char lastChar = Expression.Last();

                        if ("+-*/%".Contains(lastChar)) Expression = Expression.Substring(0, Expression.Length - 2);
                    }
                    else Expression += " " + PresentValue;

                    isArithmeticOperationPerformed = false;
                }

                Expression += " " + input;
                PreviousValue = Expression;
                isDecimalInEntryUsed = false;
                isArithmeticOperatorInEntryUsed = true;
                isArithmeticOperationPerformed = false;

                return PreviousValue;
            }
            catch (Exception)
            {
                return PreviousValue;
            }
        }

        public string CalculateResult()
        {
            try
            {
                // Perform Clear if the result is an error
                if (PresentValue == "Calculation Error" 
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") Clear();

                if (!isArithmeticOperationPerformed) Expression += " " + PresentValue;
                else Expression = Result;

                if (Expression.Contains("/ 0")) throw new DivideByZeroException();

                string cleanedExpression = Expression.Replace(" ", "");

                // perform percentage calculation if % exists in the expression
                if (cleanedExpression.Contains("%")) cleanedExpression = PercentageCalculation(cleanedExpression);  

                // calculate the remaining expression using MDAS
                var result = new DataTable().Compute(cleanedExpression, null);
                decimal convertedResult = Convert.ToDecimal(result);

                // format the result by removing unecessary decimal (.0)
                PresentValue = convertedResult % 1 == 0 ? ((int)convertedResult).ToString() : convertedResult.ToString();
                
                Result = result.ToString();
                Equation = (Expression + " = " + Result).Trim();
                PreviousValue = (Expression + " =").Trim();
                isDecimalInEntryUsed = false;
                isArithmeticOperatorInEntryUsed = false;
                isArithmeticOperationPerformed = true;
                
                return PresentValue;
            }
            catch (DivideByZeroException)
            {
                Equation = Expression + " = Not Divisible by Zero";
                return PresentValue = "Not Divisible by Zero";
            }
            catch (OverflowException)
            {
                Equation = Expression + " = Overflow";
                return PresentValue = "Overflow";
            }
            catch (Exception)
            {
                Equation = Expression + " = Calculation Error";
                return PresentValue = "Calculation Error";
            }
        }

        private string PercentageCalculation(string expression)
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
                isPercentageOperationPerformed = true;
            }

            return expression;
        }

        public void Clear()
        {
            // Reset state
            PresentValue = "0";
            PreviousValue = "";
            Expression = "";
            Result = "";
            isDecimalInEntryUsed = false;
            isArithmeticOperatorInEntryUsed = false;
            isArithmeticOperationPerformed = false;
            isPercentageOperationPerformed = false;
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

            if (string.IsNullOrEmpty(PreviousValue))
            {
                if (!isArithmeticOperationPerformed || !isPercentageOperationPerformed)
                {
                    if (PresentValue.Length >= 1)
                    {
                        // remove the last character
                        PresentValue = PresentValue.Substring(0, PresentValue.Length - 1);

                        // disable flag
                        if (!PresentValue.Contains(".")) isDecimalInEntryUsed = false;
                    }

                    // if present value reaches empty, put 0 to avoid blank present value
                    if (PresentValue.Length == 0) PresentValue = "0";
                } 
            }
            else
            {
                // Clear previous value and expression
                PreviousValue = "";
                Expression = "";
            }
        }
    }
}
