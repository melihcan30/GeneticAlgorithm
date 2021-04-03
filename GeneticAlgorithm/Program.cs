//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace GeneticAlgorithm
//{
//    class Program
//    {
//        static int[] CheesArray = new int[getNumber()];

//        static char[] Alfabe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

//        static int counter = CheesArray.Count();
//        static void Main(string[] args)
//        {
//            List<string[]> ApproachList = new List<string[]>();

//            for (int i = 0; i < Math.Pow(counter, counter); i++)
//            {
//                if (IsAllDifferentAndNotCross(CheesArray))
//                {
//                    int k = 0;
//                    string[] TempArray = new string[counter];
//                    foreach (int item in CheesArray)
//                    {
//                        k++;
//                        TempArray[k - 1] = (k) + Alfabe[item].ToString();
//                        Console.Write(TempArray[k - 1] + "  ");

//                    }

//                    Console.WriteLine();

//                    ApproachList.Add(TempArray.Clone() as string[]);

//                }

//                CheesArray[counter - 1]++;

//                SetArray();
//            }

//            Console.WriteLine("Toplamda " + ApproachList.Count() + " Farklı Kombinasyon Var");

//            Console.ReadLine();

//        }

//        static Boolean IsAllDifferentAndNotCross(int[] CheesArray)
//        {
//            for (int i = 0; i < counter; i++)
//            {
//                for (int j = i + 1; j < counter; j++)
//                {
//                    if (CheesArray[i] == CheesArray[j] || (CheesArray[i] - i) == (CheesArray[j] - j) || (CheesArray[i] + i) == (CheesArray[j] + j))
//                        return false;
//                }

//            }

//            return true;
//        }

//        static void SetArray()
//        {
//            for (int j = 0; j < counter; j++)
//            {
//                if (CheesArray[j] == counter)
//                {
//                    if (j == 0)
//                        break;
//                    CheesArray[j] = 0;
//                    CheesArray[j - 1]++;
//                    break;
//                }
//            }

//            foreach (int item in CheesArray)
//                if (item == counter)
//                    if (CheesArray[0] != counter)
//                        SetArray();
//        }

//        static int getNumber()
//        {
//            Console.WriteLine("Bir sayı giriniz: ");
//            return int.Parse(Console.ReadLine());
//        }

//    }
//}
