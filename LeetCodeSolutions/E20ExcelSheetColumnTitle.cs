using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int columnNumber)
        {
            string ret = "";
            while (columnNumber>0)
            {
                columnNumber--;
                int numb = columnNumber % 26;
                ret = (char)('A' + numb) + ret;
                columnNumber /= 26;
            }
            return ret;
        }
    }
}
