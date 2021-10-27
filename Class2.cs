using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_Valkrusman
{
    class Class2
    {
        static int Saali_suurus()
        {
            Console.WriteLine("Vali saali suurus: 1,2,3");
            int suurus = int.Parse(Console.ReadLine());
            return suurus;
        }
        static int[,] saal = new int[,] { };//täisarvudest  tekkib matritsa
        static int[] ost = new int[] { };//teeb massiivi
        static int kohad, read, mitu, mitu_veel;
        static void Saali_taitmine(int suurus)
        {
            Random rnd = new Random();// randoomsed kohad tulevad
            if (suurus == 1)
            { kohad = 20; read = 10; }// esimese saali kohad ja read
            else if (suurus == 2)
            { kohad = 20; read = 20; }//teise saali kohad ja read
            else
            { kohad = 30; read = 20; } // else kolmas saal
            saal = new int[read, kohad];
            for (int rida = 0; rida < read; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {
                    saal[rida, koht] = rnd.Next(0, 2);
                }
            }
        }
        static void Saal_ekraanile()
        {
            Console.Write("     ");// kirjutab suur vahe
            for (int koht = 0; koht < kohad; koht++)// inimene sisestab arvu, ja kui see on väiksem kui 'kohad' siis koht liidab juurde
            {
                if (koht.ToString().Length == 2)
                { Console.Write(" {0}", koht + 1); }// see millise koha valib klient, koguaeg hakkab tulema +1
                else
                { Console.Write("  {0}", koht + 1); }
            }

            Console.WriteLine();
            for (int rida = 0; rida < read; rida++)
            {
                Console.Write("Rida " + (rida + 1).ToString() + ":");
                for (int koht = 0; koht < kohad; koht++)
                {

                    Console.Write(saal[rida, koht] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void Muuk_ise()
        {
            Console.WriteLine("Rida:");
            int pileti_rida = int.Parse(Console.ReadLine());// kirjutad valid rea, kus tahad istuda
            Console.WriteLine("koht:");
            int pileti_koht = int.Parse(Console.ReadLine()); // valid koha kus tahad istuda
            if (saal[pileti_rida, pileti_koht] == 0)// alguses on 0 rida ja koht
            {
                saal[pileti_rida, pileti_koht] = 1;// tuleb koht millise valis klient
            }


        }
        static void Muuk()
        {
            Console.WriteLine("Rida:");
            int pileti_rida = int.Parse(Console.ReadLine());
            Console.WriteLine("Mitu piletid:");// küsimus kliendile
            mitu = int.Parse(Console.ReadLine());
            ost = new int[mitu];// kui palju soovid osta
            int p = (kohad - mitu) / 2;// kohti lahutame selle arvuga mille valis klient ja jagame kaheks
            bool t = false;
            int k = 0;// nulline tähtsus panime, kuna klient ise valib millise koha tahab valida
            do
            {
                if (saal[pileti_rida, p] == 0)
                {
                    ost[k] = p;
                    Console.WriteLine("koht {0} on vaba", p);// {0}-näitab milline koht on vaba ja p-
                    t = true;// kui koht on vaba siis see funktisoon ütleb, et see koht on vaba
                }
                else
                {
                    Console.WriteLine("koht {0} kinni", p);
                    t = false;//kui see koht pole vaba siis see funktsioon hakkab tööle ja edasi ei lähe
                    ost = new int[mitu];
                    k = 0;
                    p = (kohad - mitu) / 2;
                    break;// lõpetab Muuk
                }
                p = p + 1;// +1 kohale
                k++;
            } while (mitu != k);
            if (t == true)
            {
                Console.WriteLine("Sinu kohad on:");
                foreach (var koh in ost)//dubleerib massiivi iga kirje märgistuse osa ja seob selle märgistuse iga koopia vastava massiiviüksusega. 
                {
                    Console.WriteLine("{0}\n", koh);
                }
            }
            else
            {
                Console.WriteLine("Selles reas ei ole vabu kohti. Kas tahad teises reas otsida?");
            }
        }
        public static void Main(string[] args)
        {
            int suurus = Saali_suurus();
            Saali_taitmine(suurus);// valid saali (1,2,3)
            while (true)
            {
                Saal_ekraanile();
                Console.WriteLine("1-ise valik, 2-masin valik");
                int valik = int.Parse(Console.ReadLine());
                if(valik==1)
                {
                    Muuk_ise(); //kui klient valis 1 siis tuleb see ette, ja ta valib ise
                }
                else
                {
                    Muuk();// kui valis 2 siis masin valik tuleb 
                }

            }

            //Console.ReadLine();
        }
    }
}

