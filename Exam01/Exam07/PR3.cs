using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam07
{
    class PR3:LogicBase
    {
        public PR3(int n)
        {
            JmlhBaris = n * 2 + 1;
            JmlhKolom = (n * 2) + (n * 2 - 1);
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int angka = 1;
                
                int stBrs = 0;
                int enBrs= JmlhBaris - 1 - (bgn * 2);
                int stKlm = bgn * 2;
                int enKLm = JmlhKolom - 1 - (bgn * 2);
                int nangka = (((enBrs+1-stBrs) +(enKLm+1-stKlm)) * 2 - 4)-(enKLm+1-stKlm-2);
                for (int b = stBrs; b <= enBrs; b++)
                {
                    for (int k = stKlm; k <= enKLm; k++)
                    {
                        if (b== enBrs|| k==stKlm)
                        {
                            Array2D[b, k] = angka++.ToString();
                        }
                        else if (k==enKLm)
                        {
                            Array2D[b, k] = nangka--.ToString();
                        }
                    }
                }
            }

        }
    }
}
