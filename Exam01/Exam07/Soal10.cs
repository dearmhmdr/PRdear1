using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Exam07
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
        {
            JmlhBaris = n * n;
            JmlhKolom = n * n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int angka = 0;
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == 0 || bk == 0 || bb == n - 1 || bk == n - 1)
                    {
                        int stBrs = n * bb;
                        int stKlm = n * bk;
                        int enBrs = stBrs + (n - 1);
                        int enKlm = stKlm + (n - 1);
                        angka = angka + 1;
                        for (int b = stBrs; b <= enBrs; b++)
                        {
                            for (int k = stKlm; k <= enKlm; k++)
                            {
                                if (k - b == stKlm-stBrs || k == stKlm || b == enBrs)
                                    Array2D[b, k] = angka.ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}
