using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Exam06
{
    class PR1:LogicBase
    {
        public PR1(int n)
        {
            JmlhBaris = 3 * n +(n-1);
            JmlhKolom = 3 * n +(n-1);
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);

        }

        private void IsiArray(int n)
        {
            for (int b = 0; b < JmlhBaris; b++)
            {
                for (int k = 0; k < JmlhKolom; k++)
                {
                    if (b + k >= n + n - 1 && k - b <= n + n - 1 && b < n)
                    {
                        Array2D[b, k] = "*";
                        Array2D[k, b] = "*";
                        Array2D[JmlhBaris - b - 1, k] = "*";
                        Array2D[JmlhKolom-k-1 ,JmlhBaris-b-1] = "*";
                    }
                }
            }
        }
    }
}
