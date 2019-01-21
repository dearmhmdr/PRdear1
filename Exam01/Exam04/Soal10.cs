using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Exam04
{
    class Soal10 : LogicBase
    {
        public Soal10(int n, int ulg)
        {
            JmlhBaris = n;
            JmlhKolom = n;
            int ulang = ulg;
            Array2D = new string[JmlhBaris, JmlhKolom * ulang - (ulang - 1)];
            IsiArray(ulang);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int ulang)
        {
            int[] asci = FunctionBase.ASCII1(JmlhBaris / 2 + 1);
            for (int ulg = 0; ulg < ulang; ulg++)
            {
                for (int b = 0; b < JmlhBaris/2+1; b++)
                {
                    int angka = 0;
                    for (int k = 0; k < JmlhKolom; k++)
                    {
                        if (b+k>=JmlhBaris/2&&k-b<=JmlhBaris/2)
                        {
                            Array2D[b, ((JmlhBaris * ulg) - ulg)+k] = Convert.ToChar(asci[angka]).ToString();
                            Array2D[JmlhBaris-b-1, (JmlhBaris * ulg) - ulg+k] = Convert.ToChar(asci[angka]).ToString();
                            if (k < JmlhKolom / 2)
                            {
                                angka = angka + 1;
                            }
                            else
                                angka = angka - 1;
                        }
                    }
                }
            }
        }

    }
}
