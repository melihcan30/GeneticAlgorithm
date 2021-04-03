using System;
using System.Collections.Generic;
using System.Text;



namespace kale
{
    public class Program
    {

        public bool YerMevcutMu(int satır, int sutun, int[,] boardMatrix)
        {
            // SatirKontrolu
            for (int i = 0; i < sutun; i++)
            {
                if (boardMatrix[satır, i] == 1) 
                    return false;
            }

            // satır kontrolü bitti
            Console.WriteLine("Aşamalar:");
            for (var b = 0; b < 8; b++)
            {

                for (var j = 0; j < 8; j++)
                {

                    Console.Write(boardMatrix[b, j]);
                    Console.Write("\t");

                }

                Console.WriteLine("\n\n");
            }
            return true;
        }

        public bool islem(int sutun, int kale, int[,] satrancTahtasi)
        {
            if (sutun >= kale) return true;

            for (int i = 0; i <= kale; i++)
            {
                Random rastgele = new Random();
                if (YerMevcutMu(i = rastgele.Next(0, 8), sutun, satrancTahtasi))
                {
                    satrancTahtasi[i, sutun] = 1;

                    if (islem(sutun +1, kale, satrancTahtasi))
                    {

                        return true; // sutun>= kale   
                    }
                    
                }

            }

            return false;
        }

        public static void Main(string[] args)
        {
            var A = new Program();
            Random rastgele = new Random();

            short kale = 8;
            int[,] satrancTahtasi = new int[kale, kale];

            if (A.islem(0, kale, satrancTahtasi))
            {
                Console.WriteLine("Cözüm: ");
                for (var i = 0; i < kale; i++)
                {
                    for (var j = 0; j < kale; j++)
                    {
                        Console.Write(satrancTahtasi[i, j]);
                        Console.Write("\t");
                    }
                    Console.WriteLine("\n");
                }
            }

        }

    }
}

