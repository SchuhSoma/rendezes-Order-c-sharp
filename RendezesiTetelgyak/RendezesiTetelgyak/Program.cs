using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendezesiTetelgyak
{
    class Program
    {
        static int[] GyakorloTMB = new int[12];
        static string[] Nevek = new string[4];
        static int[] Fizetesek = new int[4];
        static string[] KategoriaTMB = new string[11];
        static int[] TuleloTMB = new int[11];
        static int[] EltuntekTMB = new int[11];
        static void Main(string[] args)
        {   
            GyakorloTombFeltoltese(); Console.WriteLine("\n---------------------------------------------------\n");
            GyakorloTombKiir(); Console.WriteLine("\n---------------------------------------------------\n");
            GyakorloTombRendezem(); Console.WriteLine("\n---------------------------------------------------\n");
            GyakorloTombCsokkenoSorrendben();
            
            NevekFizetesekFeltoltesKiiratas(); Console.WriteLine("\n---------------------------------------------------\n");
            FizetesSzerintiRendezes(); Console.WriteLine("\n---------------------------------------------------\n");
            NevekSzerintiRendezes(); 
            
            TitinicRendezest(); Console.WriteLine("\n---------------------------------------------------\n");
            RendezniTitanicotEltuntekSzerint();
            Console.ReadKey();
        }

        private static void RendezniTitanicotEltuntekSzerint()
        {
            Console.WriteLine("Titanic eltüntjeinek rendezése");
            int CsereEltuntek;
            int CsereTulelok;
            string CsereKategoria;
            for (int i = 0; i < EltuntekTMB.Length-1; i++)
            {
                for (int j = 0; j < EltuntekTMB.Length-1; j++)
                {
                    if(EltuntekTMB[j]>EltuntekTMB[j+1])
                    {
                        CsereEltuntek = EltuntekTMB[j];
                        EltuntekTMB[j] = EltuntekTMB[j + 1];
                        EltuntekTMB[j + 1] = CsereEltuntek;

                        CsereTulelok = TuleloTMB[j];
                        TuleloTMB[j] = TuleloTMB[j + 1];
                        TuleloTMB[j + 1] = CsereTulelok;

                        CsereKategoria = KategoriaTMB[j];
                        KategoriaTMB[j] = KategoriaTMB[j + 1];
                        KategoriaTMB[j + 1] = CsereKategoria;
                    }
                }
            }
            for (int k = 0; k < KategoriaTMB.Length; k++)
            {
                Console.WriteLine("\tKategorai: {0,-25} -> túlélők száma: {1,-3} --> eltüntek száma: {2,-3}", KategoriaTMB[k], TuleloTMB[k], EltuntekTMB[k]);
            }
        }

        private static void TitinicRendezest()
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

        private static void NevekSzerintiRendezes()
        {
            Nevek = new string[] { "Peti", "Dani", "Géza", "Jani" };
            Console.WriteLine("Nevek szeriti rendezes");
            string CsereNev;
            for (int i = 0; i < Nevek.Length-1; i++)
            {
                for (int j = i+1; j < Nevek.Length; j++)
                {
                    if(Nevek[i].CompareTo(Nevek[j])==1)
                    {
                        CsereNev = Nevek[i];
                        Nevek[i] = Nevek[j];
                        Nevek[j] = CsereNev;
                    }
                    
                }
            }
            for (int k = 0; k < Nevek.Length; k++)
            {
                Console.WriteLine("\t{0}",Nevek[k]);
            }
        }

        private static void FizetesSzerintiRendezes()
        {
            Console.WriteLine("Fizetes Szerinti rendezes mövekvő sorrendben");
            int CsereFizetes;
            string CsereNev;
            for (int i = 0; i < Fizetesek.Length-1; i++)
            {
                for (int j = 0; j < Fizetesek.Length-1; j++)
                {
                    if(Fizetesek[j]>Fizetesek[j+1])
                    {
                        CsereFizetes = Fizetesek[j];
                        Fizetesek[j] = Fizetesek[j + 1];
                        Fizetesek[j + 1] = CsereFizetes;

                        CsereNev = Nevek[j];
                        Nevek[j] = Nevek[j + 1];
                        Nevek[j + 1] = CsereNev;
                    }
                }
            }
            Console.WriteLine("\tNevek : Fizetések");
            for (int k = 0; k < Nevek.Length; k++)
            {
                Console.WriteLine("\t{0,-5} : {1}", Nevek[k], Fizetesek[k]);
            }
        }

        private static void NevekFizetesekFeltoltesKiiratas()
        {
            Console.WriteLine("Nevek, magassag tömb feltöltése");
            Nevek = new string[] { "Peti", "Dani", "Géza", "Jani" };
            Fizetesek = new int[] { 178, 195, 162, 187 };
            Console.WriteLine("\tNevek : Fizetések");
            for (int i = 0; i < Nevek.Length; i++)
            {
                Console.WriteLine("\t{0,-5} : {1}", Nevek[i],Fizetesek[i]);
            }
        }

        private static void GyakorloTombCsokkenoSorrendben()
        {
            Console.WriteLine("Gyakorló tömb csükkenő sorrendben való kiírása");
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

        private static void GyakorloTombRendezem()
        {
            Console.WriteLine("gyakorló tömb növekvő sorrendbe való rendezése");
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
                Console.WriteLine("\t{0}", GyakorloTMB[k]);
            }
        }

        private static void GyakorloTombKiir()
        {
            Console.WriteLine("Gyakorló tömb elemeinek kiiratása");
            for (int i = 0; i < GyakorloTMB.Length; i++)
            {
                Console.WriteLine("\t{0}",GyakorloTMB[i]);
            }
        }

        private static void GyakorloTombFeltoltese()
        {
            Console.WriteLine("Gyakorló tömb feltöltése");
            GyakorloTMB = new int[] { 12, 18, 19, 2, 3, -4, 15, -6, 6, 17, 21, -123 };
        }
    }
}
