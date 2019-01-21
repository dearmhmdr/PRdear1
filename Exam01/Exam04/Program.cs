using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Logic 03 ---");
            //while
            Console.Write("Masukkan Nilai n: ");
            int n = int.Parse(Console.ReadLine());
            
Console.Write("Masukkan Nilai bangun: ");
            int ulang = int.Parse(Console.ReadLine());
            PR2 soal1 = new PR2(n,ulang);
            Console.WriteLine("Tekan Sembarang Tomobol");
            Console.ReadKey();
        }
    }
}
