using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace Exam04
{
    class Soal09:LogicBase
    {
        public Soal09(int n, int ulg)
        {
            JmlhBaris = n;
            JmlhKolom = n;
            int ulang = ulg;
            Array2D = new string[JmlhBaris, JmlhKolom * ulang-(ulang-1)];
            IsiArray(ulang);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int ulang)
        {
            for ( int ulg = 0; ulg < ulang; ulg++)
            {


                for (int b = 0; b < JmlhBaris / 2 + 1; b++)
                {
                    int angka = 1;
                    for (int k = 0; k < JmlhKolom; k++)
                    {
                        if (b + k >= JmlhBaris / 2 && k - b <= JmlhBaris / 2)
                        {
                            Array2D[b, ((ulg * JmlhBaris) - (ulg)) + k] = angka.ToString();
                            Array2D[JmlhBaris - 1 - b, ((ulg * JmlhBaris) - (ulg)) + k] = angka.ToString();

                            if (k < JmlhKolom / 2)
                            {
                                angka = angka + 2;
                            }
                            else
                                angka = angka - 2;
                        }
                    }
                }
            }
        }
    }
}
