using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace cSharpIccCalculator
{
    class CalculatorClass
    {
        private static double result = 0;
        private static string operation = "";
        private static bool isZeroLeading = true;
        private static bool isDecimalInEntryUsed = false;
        private static bool isOperatorInEntryUsed = false;
        private static bool isOperationPerformed = false;
        private static bool passData = true;

        public string PresentValue { get; set; } = "0";
        public string PreviousValue { get; set; }

        public string HandleNumberAndDecimal(string input)
        {
            try
            {
                if (PresentValue == "Calculation Error" 
                    || PresentValue == "Not Divisible by Zero" 
                    || PresentValue == "Overflow") return PresentValue;

                if (input == "0")
                {
                    if (isOperatorInEntryUsed)
                    {
                        if (isZeroLeading)
                        {
                            if (!PresentValue.EndsWith("0")) PresentValue += "0";

                            isZeroLeading = true;       
                        } 
                        else
                        {
                            PresentValue += "0";
                            isZeroLeading = false;
                        }
                        isOperatorInEntryUsed = true;
                    }
                    else
                    {
                        if (isZeroLeading) isZeroLeading = true;
                        else
                        {
                            PresentValue += "0";
                            isZeroLeading = false;
                        }
                        isOperatorInEntryUsed = false;
                    }

                    isDecimalInEntryUsed = false;
                    isOperationPerformed = false;

                    return PresentValue;
                }
                else isZeroLeading = false;

                if (input == ".")
                {
                    string[] parts = PresentValue.Split(new char[] { '+', '-', '*', '/', '%' });
                    string lastSegment = parts.Last();

                    if (string.IsNullOrEmpty(lastSegment) || "+-*/%".Contains(lastSegment)) PresentValue += "0.";
                    else if (!lastSegment.Contains(".")) PresentValue += ".";

                    return PresentValue;
                }

                PresentValue += input;

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

                // avoid appending multiple operators and enable overwrite
                if (PresentValue.Length > 0)
                {
                    char lastChar = PresentValue[PresentValue.Length - 1];
                    if ("+-*/%".Contains(lastChar)) PresentValue = PresentValue.Substring(0, PresentValue.Length - 1);
                }

                isZeroLeading = true;
                isDecimalInEntryUsed = false;
                isOperatorInEntryUsed = true;
                isOperationPerformed = false;

                PresentValue += input;

                return PresentValue;
            }
            catch (Exception)
            {
                return PresentValue;
            }
        }

        public string CalculateResult()
        {
            try
            {
                if (PresentValue == "Calculation Error" 
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") return PresentValue;

                // disable calculation if the last char is an operator
                if (PresentValue.Length > 0)
                {
                    char lastChar = PresentValue[PresentValue.Length - 1];
                    if ("+-*/%".Contains(lastChar)) return PresentValue;
                }

                if (!isOperatorInEntryUsed) return PresentValue;

                PreviousValue = PresentValue;

                if (PresentValue.Contains("/0")) throw new DivideByZeroException(); // checks if the expression is divided by 0

                var result = new DataTable().Compute(PresentValue, null);

                PresentValue = result.ToString();

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
            result = 0;
            operation = "";
            isZeroLeading = true;
            isDecimalInEntryUsed = false;
            isOperatorInEntryUsed = false;
            isOperationPerformed = false;
        }

        public void ClearRecentEntry()
        {
            if (PresentValue == "Calculation Error"
                || PresentValue == "Not Divisible by Zero"
                || PresentValue == "Overflow")
            {
                PresentValue = "0";
                result = 0;
                operation = "";
                isZeroLeading = true;
                isDecimalInEntryUsed = false;
                isOperatorInEntryUsed = false;
                isOperationPerformed = false;
            }

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
                    result = 0;
                    operation = "";
                    isZeroLeading = true; 
                    isDecimalInEntryUsed = false;
                    isOperatorInEntryUsed = false;
                    isOperationPerformed = false;
                }
            }
        }
    }
}
