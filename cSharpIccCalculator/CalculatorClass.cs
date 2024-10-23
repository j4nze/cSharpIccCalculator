using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace cSharpIccCalculator
{
    class CalculatorClass
    {
        public static string Expression = "";
        public static string Result = "";
        private static bool isZeroLeading = true;
        private static bool isDecimalInEntryUsed = false;
        private static bool isOperatorInEntryUsed = false;
        private static bool isOperationPerformed = false;


        public string PresentValue { get; set; } = "0";
        public string PreviousValue { get; set; } = "";

        public string HandleNumberAndDecimal(string input)
        {
            try
            {
                if (PresentValue == "Calculation Error"
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") return PresentValue;

                if (isOperatorInEntryUsed)
                {
                    PresentValue = "";
                    isZeroLeading = true;
                    isDecimalInEntryUsed = false;
                    isOperatorInEntryUsed = false;
                    isOperationPerformed = false;
                } 
                if (isOperationPerformed)
                {
                    PresentValue = "";
                    isZeroLeading = true;
                    isDecimalInEntryUsed = false;
                    isOperatorInEntryUsed = false;
                    isOperationPerformed = false;
                }

                if (input == "0")
                {
                    if (PresentValue == "0") return PresentValue;
                    else PresentValue += "0";
                }
                else if (input == ".")
                {
                    if (!isDecimalInEntryUsed)
                    {
                        PresentValue += ".";
                        isDecimalInEntryUsed = true;
                    }
                }
                else
                {
                    if (PresentValue == "0") PresentValue = input;
                    else PresentValue += input;
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
                if (PresentValue == "Calculation Error"
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") return PresentValue;

                if (Result.Length > 0) Expression += " " + Result;
                else Expression += " " + PresentValue;
                Expression += " " + input;
                PreviousValue = Expression;

                isZeroLeading = true;
                isDecimalInEntryUsed = false;
                isOperatorInEntryUsed = true;
                isOperationPerformed = false;

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
                if (PresentValue == "Calculation Error" 
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") return PresentValue;

                Expression += " " + PresentValue;

                if (Expression.Contains("/0")) throw new DivideByZeroException(); // checks if the expression is divided by 0

                var result = new DataTable().Compute(Expression, null);

                PresentValue = result.ToString();
                Result = result.ToString();

                isZeroLeading = true;
                isDecimalInEntryUsed = false;
                isOperatorInEntryUsed = false;
                isOperationPerformed = true;
                
                return PresentValue;
            }
            catch (DivideByZeroException)
            {
                return PresentValue = "Not Divisible by Zero";
            }
            catch (OverflowException)
            {
                return PresentValue = "Overflow";
            }
            catch (Exception)
            {
                return PresentValue = "Calculation Error";
            }
        }

        public void Clear()
        {
            PresentValue = "0";
            PreviousValue = "";
            Expression = "";
            Result = "";
            isZeroLeading = true;
            isDecimalInEntryUsed = false;
            isOperatorInEntryUsed = false;
            isOperationPerformed = false;
        }

        public void ClearRecentEntry()
        {
            if (PresentValue.Length > 0)
            {
                char lastChar = PresentValue[PresentValue.Length - 1];
                PresentValue = PresentValue.Substring(0, PresentValue.Length - 1);

                if (lastChar == '.')
                {
                    isDecimalInEntryUsed = false;
                }

                if (PresentValue.Length == 0 || PresentValue == "0")
                {
                    PresentValue = "0";
                    Expression = "";
                    isZeroLeading = true;
                    isDecimalInEntryUsed = false;
                    isOperatorInEntryUsed = false;
                    isOperationPerformed = false;
                }
            }
        }
    }
}
