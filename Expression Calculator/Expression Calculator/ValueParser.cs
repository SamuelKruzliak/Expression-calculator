using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Calculator
{
    class ValueParser
    {
        static public List<double> values = new List<double>();
        static public List<char> operators = new List<char>();

        static public void getValues(string expression)
        {
            char[] operator_list = new char[] { '+', '-', '*', '/', '(', ')' };
            bool isoperator;

            for (int i = 0; i < expression.Length; i++)
            {
                isoperator = operator_list.Any(p => p == expression[i]);

                if (isoperator)
                {
                    if (expression[i] != '-')
                    {
                        values.Add(double.Parse(expression.Substring(0, i)));
                    }
                    else
                    {
                        values.Add(double.Parse(expression.Substring(0, i)) * -1);
                    }
                    operators.Add(expression[i]);
                    expression = expression.Remove(0, i + 1);
                    i = 0;
                }
            }
            values.Add(double.Parse(expression));
            Logic.getResult();
        }
    }
}
