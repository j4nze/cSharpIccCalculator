using System;
using System.Data;
using System.Globalization;
using System.Linq;

namespace cSharpIccCalculator
{
    class CalculatorClass
    {
        private static double result = 0;
        private static string operation = "";
        private static bool isOperationPerformed = false;
        private static bool isDecimalUsed = false;
        private static bool isZeroWholeUsed = false;
        private static bool isOperatorUsed = false;

        public string PresentValue { get; set; }
        public string PreviousValue { get; set; }

        public string HandleNumberAndDecimal(string input)
        {
            try
            {
                if (PresentValue == "Number/ Decimal Error" 
                    || PresentValue == "Operator Error" 
                    || PresentValue == "Calculation Error" 
                    || PresentValue == "Not Divisible by Zero" 
                    || PresentValue == "Overflow") return PresentValue;

                if (input == "0")
                {
                    if (isZeroWholeUsed) return PresentValue; // avoid appending whole 0

                    // enable using whole 0 again before/after an operator
                    if (!isDecimalUsed || (!isDecimalUsed && !isOperatorUsed))
                    {
                        PresentValue += "0";
                        isZeroWholeUsed = true;
                        return PresentValue;
                    }
                }

                if (input == ".")
                {
                    if (isDecimalUsed) return PresentValue; // avoid appending multiple decimal points

                    // if textbox is empty or contains only ., . = 0. (if no other entry)
                    if (PresentValue.Length == 0 || PresentValue == ".")
                    {
                        PresentValue = "0.";
                        isDecimalUsed = true;
                        return PresentValue;
                    }

                    // if the last char is any of the operator, . = 0. (if no other entry)
                    if (PresentValue.Length > 0)
                    {
                        char lastChar = PresentValue[PresentValue.Length - 1];
                        if ("+-*/%".Contains(lastChar))
                        {
                            PresentValue += "0.";
                            isDecimalUsed = true;
                            return PresentValue;
                        };
                    }

                    isDecimalUsed = true;
                    isZeroWholeUsed = false;
                }

                isOperationPerformed = false;
                isOperatorUsed = false;

                PresentValue += input;

                return PresentValue;
            }
            catch (Exception)
            {
                return PresentValue = "Number/ Decimal Error";
            }
        }

        public string HandleOperator(string input)
        {
            try
            {
                if (PresentValue == "Number/ Decimal Error" 
                    || PresentValue == "Operator Error" 
                    || PresentValue == "Calculation Error" 
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") return PresentValue;

                if (string.IsNullOrEmpty(PresentValue)) PresentValue = "";

                // avoid appending multiple operators and enable overwrite
                if (PresentValue.Length > 0)
                {
                    char lastChar = PresentValue[PresentValue.Length - 1];

                    if ("+-*/%".Contains(lastChar)) PresentValue = PresentValue.Substring(0, PresentValue.Length - 1);
                }

                isOperationPerformed = false;
                isDecimalUsed = false;
                isZeroWholeUsed = false;
                isOperatorUsed = true;

                PresentValue += input;

                // remove any operator (first char) after clicking -
                if (PresentValue.Length <= 1 && input != "-") PresentValue = "";

                return PresentValue;
            }
            catch (Exception)
            {
                return PresentValue = "Operator Error";
            }
        }

        public string CalculateResult()
        {
            try
            {
                if (string.IsNullOrEmpty(PresentValue)) return PresentValue;

                // avoid passing value from current to previous textBox after an operation
                if (PresentValue == "Number/ Decimal Error" 
                    || PresentValue == "Operator Error" 
                    || PresentValue == "Calculation Error" 
                    || PresentValue == "Not Divisible by Zero"
                    || PresentValue == "Overflow") return PresentValue;

                // disable calculation if the last char is an operator
                if (PresentValue.Length > 0)
                {
                    char lastChar = PresentValue[PresentValue.Length - 1];

                    if ("+-*/%".Contains(lastChar)) return PresentValue;
                }

                PreviousValue = PresentValue;

                if (PresentValue.Contains("/0")) throw new DivideByZeroException(); // checks if the expression is divided by 0

                var result = new DataTable().Compute(PresentValue, null);

                PresentValue = result.ToString();

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
            if (string.IsNullOrEmpty(PresentValue)) PresentValue = "";

            PresentValue = "";
            PreviousValue = "";
            result = 0;
            operation = "";
            isOperationPerformed = false;
            isDecimalUsed = false;
            isOperatorUsed = false;
            isZeroWholeUsed = false;
        }

        public void ClearRecentEntry()
        {
            if (string.IsNullOrEmpty(PresentValue)) PresentValue = "";

            if (PresentValue == "Number/ Decimal Error"
                || PresentValue == "Operator Error"
                || PresentValue == "Calculation Error"
                || PresentValue == "Not Divisible by Zero"
                || PresentValue == "Overflow") PresentValue = "";
            else
            {
                if (PresentValue.Length > 0)
                {
                    char lastChar = PresentValue[PresentValue.Length - 1];
                    PresentValue = PresentValue.Substring(0, PresentValue.Length - 1);

                    if (lastChar == '.') isDecimalUsed = false;

                    if ("+-*/%".Contains(lastChar)) isDecimalUsed = true;

                    isZeroWholeUsed = true;
                }
            } 
        }
    }
}
