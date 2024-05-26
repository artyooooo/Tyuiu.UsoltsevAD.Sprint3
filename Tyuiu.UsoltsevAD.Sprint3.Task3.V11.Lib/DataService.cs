using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.UsoltsevAD.Sprint3.Task3.V11.Lib
{
    public class DataService : ISprint3Task3V11
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string res = "";
            foreach (char letter in value)
            {
                if (letter == replaceable)
                {
                    res += replacement;
                }
                else
                {
                    res += letter;
                }
            }
            return res;
        }
    }
}
