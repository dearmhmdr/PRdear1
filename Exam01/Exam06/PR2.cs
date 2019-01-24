using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;


namespace Exam06
{
    class PR2:LogicBase
    {
        public PR2(int n)
        {
            JmlhBaris = 3 + (n - 1);
            JmlhKolom = (n * 3 + (n * n - 1) / 2);
            Array2D = new String[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int angka = JmlhKolom-1;
            int deret = JmlhKolom-1;
            for (int bgn = 0; bgn < n; bgn++)
            {
                int stBrs = bgn;
                int enBrs = n + 1;
                int stKlm = (bgn * (3+n-1)) - (bgn * (bgn - 1) / 2);
                int enKlm = stKlm + n+1 - bgn;
                for (int b = stBrs; b <= enBrs; b++)
                {
                    angka = deret;
                    for (int k = stKlm; k <= enKlm; k++)
                    {
                        if (b+k==stKlm+enBrs||b==stBrs||k==stKlm)
                        {
                                Array2D[b, k] = angka.ToString();
                        }
                        angka--;
                    }
                }
                deret = angka;
            }
        }
    }
}
