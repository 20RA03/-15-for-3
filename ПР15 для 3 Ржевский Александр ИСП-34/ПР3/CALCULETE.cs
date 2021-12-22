using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР3
{
    public static class CALCULATE
    {
        public static string CountOfNumbers(this Array myarray)
        {

            List<int> maxColumnValue = new List<int>();

            for (int i = 0; i < myarray.RowLength; i++)
            {
                int tempmax = int.MinValue;

                for (int j = 0; j < myarray.ColumnLength; j++)
                {
                    if (myarray[j, i] > tempmax)
                    {
                        tempmax = myarray[j, i];
                    }

                    if (j == myarray.ColumnLength - 1)
                    {
                        maxColumnValue.Add(tempmax);
                    }
                }
            }
            return string.Join(" ", maxColumnValue);
        }
    }
}
