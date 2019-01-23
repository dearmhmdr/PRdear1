using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Exam06
{
    class Soal10:LogicBase
    {
        public Soal10(int n)
        {
            JmlhBaris = n;
            JmlhKolom = n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            for (int b = 0; b < JmlhBaris; b++)
            {
                for (int k = 0; k <= b; k++)
                {
                    if (b % 2 == 0)
                    {
                        Array2D[b, k] = (b+1).ToString();
                    }
                    else
                        Array2D[b, JmlhKolom - 1 - k] = (b+1).ToString();
                }
            }
        }
    }
}
