using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendezes_gyakorlas
{
    class Program
    {
        static int[] GyakorloTMB = new int[12];
        static string[] Nevek = new string[4];
        static int[] Magassag = new int[4];
        static string[] KategoriaTMB = new string[11];
        static int[] TuleloTMB = new int[11];
        static int[] EltuntekTMB = new int[11];
        static void Main(string[] args)
        {
            GyakTMBFeltoltes(); Console.WriteLine("\n-------------------------------------------\n");
            GyakorLoTMBKiiratas(); Console.WriteLine("\n-------------------------------------------\n");
            GyakorloTMBRendezes(); Console.WriteLine("\n-------------------------------------------\n");
            GyakorloTMBRendezeseCsokkenobe(); Console.WriteLine("\n-------------------------------------------\n");
            FeltoltomNevekMagassagTMB(); Console.WriteLine("\n-------------------------------------------\n");
            KiiratNevMagassag(); Console.WriteLine("\n-------------------------------------------\n");
            RendezveNevMagagassaggal(); Console.WriteLine("\n-------------------------------------------\n");
            FeltoltomTitanicot(); Console.WriteLine("\n-------------------------------------------\n");
            TitanicAdatokRendezese(); Console.WriteLine("\n-------------------------------------------\n");
            Console.ReadKey();
        }

        private static void TitanicAdatokRendezese()
        {
            Console.WriteLine("Titanic adatainak rendezése túlélők szerint");
            string CsereKategoria;
            int CsereEltuntek;
            int CsereTulelo;
            for (int i = 0; i < TuleloTMB.Length-1; i++)
            {
                for (int j = 0; j < TuleloTMB.Length-1; j++)
                {
                    if(TuleloTMB[j]>TuleloTMB[j+1])
                    {
                        CsereTulelo = TuleloTMB[j];
                        TuleloTMB[j] = TuleloTMB[j + 1];
                        TuleloTMB[j + 1] = CsereTulelo;

                        CsereKategoria = KategoriaTMB[j];
                        KategoriaTMB[j] = KategoriaTMB[j + 1];
                        KategoriaTMB[j + 1] = CsereKategoria;

                        CsereEltuntek = EltuntekTMB[j];
                        EltuntekTMB[j] = EltuntekTMB[j + 1];
                        EltuntekTMB[j + 1] = CsereEltuntek;
                    }
                }
            }
            Console.WriteLine("Titanic Kiíratás rendezve túlélők szerint");
            for (int i = 0; i < KategoriaTMB.Length; i++)
            {
                Console.WriteLine("\tKategorai: {0,-25} -> túlélők száma: {1,-3} --> eltüntek száma: {2,-3}", KategoriaTMB[i], TuleloTMB[i], EltuntekTMB[i]);
            }

        }

        private static void FeltoltomTitanicot()
        {
            Console.WriteLine("Titanic Feltöltése");
            KategoriaTMB = new string[] { "gyerekek-masodosztaly", "nok - elsoosztaly", "nok-hajon dolgozok", "nok-masodosztaly", "gyerekek-elsoosztaly", "nok-harmadosztaly", "gyerekek-harmadosztaly", "ferfiak-elsoosztaly", "ferfiak-legenyseg", "ferfiak-harmadosztaly", "ferfiak-masodosztaly" };
            TuleloTMB = new int[] { 24, 140, 20, 80, 5, 76, 27, 57, 192, 75, 14 };
            EltuntekTMB = new int[] { 0, 4, 3, 13, 1, 89, 52, 118, 693, 387, 154 };

            Console.WriteLine("Titanic Kiíratás");
            for (int i = 0; i < KategoriaTMB.Length; i++)
            {
                Console.WriteLine("\tKategorai: {0,-25} -> túlélők száma: {1,-3} --> eltüntek száma: {2,-3}", KategoriaTMB[i], TuleloTMB[i], EltuntekTMB[i]);
            }
        }

        private static void RendezveNevMagagassaggal()
        {
            Console.WriteLine("Rendezzük a neveket és a magasságokat a magasság szerint növekvő sorrendbe");
            int CsereMagassag;
            string CsereNev;
            for (int i = 0; i < Nevek.Length-1; i++)
            {
                for (int j = 0; j < Nevek.Length-1; j++)
                {
                    if(Magassag[j]>Magassag[j+1])
                    {
                        CsereMagassag = Magassag[j];
                        Magassag[j] = Magassag[j + 1];
                        Magassag[j + 1] = CsereMagassag;

                        CsereNev = Nevek[j];
                        Nevek[j] = Nevek[j + 1];
                        Nevek[j + 1] = CsereNev;
                    }
                }
            }
            for (int i = 0; i < Nevek.Length; i++)
            {
                Console.WriteLine("\t{0,-5} : {1} cm", Nevek[i], Magassag[i]);
            }
        }

        private static void KiiratNevMagassag()
        {
            Console.WriteLine("Kiiratom a neveket magassággal");
            for (int i = 0; i < Nevek.Length; i++)
            {
                Console.WriteLine("\t{0,-5} : {1} cm", Nevek[i],Magassag[i]);
            }
        }

        private static void FeltoltomNevekMagassagTMB()
        {
            Console.WriteLine("Nevek, magassag tömb feltöltése");
            Nevek = new string[] {"Peti","Dani","Géza","Jani" };
            Magassag = new int[] { 178,195,162,187};
        }

        private static void GyakorloTMBRendezeseCsokkenobe()
        {
            Console.WriteLine("(n-1)*(n-1)es rendezést használjuk");
            Console.WriteLine("Ez most növekvő sroorendbe rakta az elemeket azaz legnagyobbtól a legkisebbig");
            int CsereSzam;
            for (int i = 0; i < GyakorloTMB.Length - 1; i++)
            {
                for (int j = 0; j < GyakorloTMB.Length - 1; j++)
                {
                    if (GyakorloTMB[j] < GyakorloTMB[j + 1])
                    {
                        CsereSzam = GyakorloTMB[j];
                        GyakorloTMB[j] = GyakorloTMB[j + 1];
                        GyakorloTMB[j + 1] = CsereSzam;
                    }
                }
            }
            for (int k = 0; k < GyakorloTMB.Length; k++)
            {
                Console.WriteLine("\t{0}", GyakorloTMB[k]);
            }
        }

        private static void GyakorloTMBRendezes()
        {
            Console.WriteLine("(n-1)*(n-1)es rendezést használjuk");
            Console.WriteLine("Ez most növekvő sroorendbe rakta az elemeket azaz legkisebbtól a legnagyobbig");
            int CsereSzam;
            for (int i = 0; i < GyakorloTMB.Length-1; i++)
            {
                for (int j = 0; j < GyakorloTMB.Length-1; j++)
                {
                    if(GyakorloTMB[j]>GyakorloTMB[j+1])
                    {
                        CsereSzam = GyakorloTMB[j];
                        GyakorloTMB[j] = GyakorloTMB[j + 1];
                        GyakorloTMB[j + 1] = CsereSzam;
                    }
                }
            }
            for (int k = 0; k < GyakorloTMB.Length; k++)
            {
                Console.WriteLine("\t{0}",GyakorloTMB[k]);
            }

        }

        private static void GyakorLoTMBKiiratas()
        {
            Console.WriteLine("Gyakorló tömb kiiratása");
            for (int i = 0; i < GyakorloTMB.Length; i++)
            {
                Console.WriteLine("\t{0}" ,GyakorloTMB[i]);
            }
        }

        private static void GyakTMBFeltoltes()
        {
            Console.WriteLine("Gyakorló tömb feltöltése");
            GyakorloTMB = new int[] { 12, 18, 19, 2, 3, -4, 15, -6, 6,17,21,-123};
        }
    }
}
