using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int[] rastgeleSayi = new int[10];
            for (int i = 0; i < rastgeleSayi.Lenght; i++)
            {
                rastgeleSayi[i] = r.Next(1, 10);
                Console.WriteLine(rastgeleSayi[i]);
            }
            int puan1 = 0;
            int puan2 = 0;
            for (int i = 0; i < rastgeleSayi.Length; i++)
            {
                Console.WriteLine("1.oyuncu tahmini");
                int tahmin1 = Convert.ToInt32(Console.ReadLine());
                if (tahmin1 == rastgeleSayi[i])

                {
                    puan1 += 10;

                }

                else
                {
                    if (rastgeleSayi[i] > tahmin1)
                    {
                        puan1 += 10 - (rastgeleSayi[i]);
                    }
                    else
                    {
                        puan1 += 10 - (tahmin1 - rastgeleSayi[i]);
                    }
                    Console.WriteLine("yanlış tahmin");
                    Console.WriteLine(rastgeleSayi);
                    Console.WriteLine("puanınız: " + puan1);

                } Console.Clear();

                Console.WriteLine("2.oyuncu tahmini");
                int tahmin2 = Convert.ToInt32(Console.ReadLine());
                if (tahmin2 == rastgeleSayi[i])
                {
                    puan2 += 10;
                }
                else
                {
                    if (rastgeleSayi[i] > tahmin2)
                    {
                        puan2 += 10 - (rastgeleSayi[i] - tahmin2);
                    }
                    else
                    {

                        puan2 += 10 - (tahmin2 - rastgeleSayi[i]);


                    }
                    Console.Clear();

                }
                Console.Clear();
                Console.WriteLine("1.oyuncunun puanı: "+  puan1);
                Console.WriteLine("2.oyuncunun puanı: "+  puan2);
                Console.ReadKey();



            }

        }

    }

