using System;
using System.Data;
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

        public string HandleNumberAndDecimal(string input, string currentValue)
        {
            if (currentValue == "Error") return currentValue;

            if (input == "0")
            {
                if (isZeroWholeUsed) return currentValue; // avoid appending whole 0

                // enable using whole 0 again before/after an operator
                if (!isDecimalUsed || (!isDecimalUsed && !isOperatorUsed))
                {
                    currentValue += "0";
                    isZeroWholeUsed = true;
                    return currentValue;
                }
            }

            if (input == ".")
            {
                if (isDecimalUsed) return currentValue; // avoid appending multiple decimal points

                // if textbox is empty or contains only ., . = 0. (if no other entry)
                if (currentValue.Length == 0 || currentValue == ".")
                {
                    currentValue = "0.";
                    isDecimalUsed = true;
                    return currentValue;
                }

                // if the last char is any of the operator, . = 0. (if no other entry)
                if (currentValue.Length > 0)
                {
                    char lastChar = currentValue[currentValue.Length - 1];

                    if ("+-*/%".Contains(lastChar))
                    {
                        currentValue += "0.";
                        isDecimalUsed = true;
                        return currentValue;
                    };
                }

                isDecimalUsed = true;
                isZeroWholeUsed = false;
            }

            isOperationPerformed = false;
            isOperatorUsed = false;

            currentValue += input;

            return currentValue;
        }

        public string HandleOperator(string input, string currentValue)
        {
            if (currentValue == "Error") return currentValue;

            // avoid appending multiple operators and enable overwrite
            if (currentValue.Length > 0)
            {
                char lastChar = currentValue[currentValue.Length - 1];

                if ("+-*/%".Contains(lastChar)) currentValue = currentValue.Substring(0, currentValue.Length - 1);
            }

            isOperationPerformed = false;
            isDecimalUsed = false;
            isZeroWholeUsed = false;
            isOperatorUsed = true;

            currentValue += input;

            // remove any operator (first char) after clicking -
            if (currentValue.Length <= 1 && input != "-") currentValue = "";

            return currentValue;
        }

        public string CalculateResult(string currentValue)
        {
            try
            {
                if (currentValue.Contains("/0")) throw new DivideByZeroException(); // checks if the expression is divided by 0

                var result = new DataTable().Compute(currentValue, null); // evaluate mathematical expression
                return result.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Not Divisible by Zero";
            }
            catch (OverflowException)
            {
                return "Overflow";
            }
            catch (Exception)
            {
                return "Error";
            }
        }

        public void Clear()
        {
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
            if (PresentValue == "Error" || PresentValue == "Not Divisible by Zeror" || PresentValue == "Overflow") PresentValue = "";

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
