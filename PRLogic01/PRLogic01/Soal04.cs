using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    class Soal04
    {
        public Soal04()
        {
            Console.Write("Masukkan Nilai n: ");
            int n = int.Parse(Console.ReadLine());
            //baris
            for (int i = 0; i < n; i++)
            {
                //kolom
                for (int j = 0; j < n; j++)
                {
                    //Pindah Kolom
                    if (i == j || i + j == n - 1||j==(n-1)/2||i== (n - 1) / 2)
                    {
                        //Console.Write("\t{0}|{1}", i, j);
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                //pindah baris
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
