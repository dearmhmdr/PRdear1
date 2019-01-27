using ExamBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam07
{
    class PT:LogicBase
    {
        public PT(int n)
        {
            JmlhBaris = n * n;
            JmlhKolom = n * n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci((n * 2) + (n - 2) * 2);
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb==bk)
                    {
                        int angka = 0;
                        int nangka = (n * 2) + (n - 2) * 2;
                        int stBrs = n * bb;
                        int stKlm = n * bk;
                        int enBrs = stBrs + n - 1;
                        int enKlm = stKlm + n - 1;
                        for (int b = stBrs; b <= enBrs; b++)
                        {
                            for (int k = stKlm; k <= enKlm; k++)
                            {
                                if (b==stBrs||k==enKlm)
                                {
                                    Array2D[b, k] = fibo[angka].ToString();
                                    angka++; 
                                }
                                else if (b==enBrs||k==stKlm)
                                {
                                    Array2D[b, k] = fibo[nangka-1].ToString();
                                    nangka--;
                                }
                            }
                        } 
                    }
                }
            }
        }
    }
}
