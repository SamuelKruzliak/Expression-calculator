
namespace Expression_Calculator
{
    class Logic : ValueParser
    {
        static public double result;
        static public double first_result;

        static public void getResult()
        {
            bool newSum = true;

            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '*')
                {
                    if (newSum)
                    {
                        first_result += values[i] * values[i + 1];
                        newSum = false;
                        ClearList(i, 1);
                    }
                    else
                    {
                        first_result *= values[i + 1];
                        ClearList(i + 1);
                    }
                }
                else if (operators[i] == '/')
                {
                    if (newSum)
                    {
                        first_result += values[i] / values[i + 1];
                        newSum = false;
                        ClearList(i, 1);
                    }
                    else
                    {
                        first_result /= values[i + 1];
                        ClearList(i + 1);
                    }
                }
                else
                {
                    newSum = true;
                }
            }
            AddUpList();
        }
        static void AddUpList()
        {
            for (int i = 0; i < values.Count; i++)
            {
                result += values[i];
            }
            result += first_result;
        }

        static void ClearList(int pos)
        {
            values[pos] = 0;
        }

        static void ClearList(int pos, int count)
        {
            values[pos] = 0;
            values[pos + 1] = 0;
        }
    }
}
