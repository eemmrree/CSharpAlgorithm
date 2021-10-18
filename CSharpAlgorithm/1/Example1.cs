using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithm
{
    class Example1
    {
        //1'den 10'a kadar olan sayıların küplerinin toplamı
        static void Main(string[] args)
        {
            #region Çözüm1

            double toplamSonuc1 = 0;
            for (int i = 1; i < 11; i++)
            {
                //toplamSonuc += i * i * i;
                toplamSonuc1 += Math.Pow(i, 3);
            }
            Console.WriteLine(toplamSonuc1);
            #endregion

            #region Çözüm2

            double toplamSonuc2 = 0;
            int sayac2 = 1;
            while (sayac2 <= 10)
            {
                toplamSonuc2 += Math.Pow(sayac2, 3);
                //if (sayac2 ==10)
                //    break;

                sayac2++;

            }
            Console.WriteLine(toplamSonuc2);

            #endregion

            #region Çözüm3

            double toplamSonuc3 = 0;
            int sayac3 = 1;
            do
            {
                toplamSonuc3 += Math.Pow(sayac3, 3);
                //if (sayac==10)
                //    break;
                sayac3++;
            } while (sayac3 <= 10);

            Console.WriteLine(toplamSonuc3);

            #endregion

            #region Çözüm4
            double toplamSonuc4 = 0;
            int sayac4 = 1;
            string sonuc = "";
            while (sayac4<=10)
            {
                toplamSonuc4 += Math.Pow(sayac4, 3);
                if (sayac4!=10)
                    sonuc += $"{sayac4}³ + ";
                else
                    sonuc += $"{sayac4}³ = {toplamSonuc4} ";
                sayac4++;
            }
            Console.WriteLine(sonuc);

            #endregion
        }
    }
}
