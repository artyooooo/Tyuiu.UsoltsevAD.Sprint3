using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.UsoltsevAD.Sprint3.Task4.V17.Lib
{
    public class DataService : ISprint3Task4V17
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                else
                {
                    res += (Math.Cos(i) / Math.Sin(i));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
