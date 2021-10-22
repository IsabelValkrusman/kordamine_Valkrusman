using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_Valkrusman
{
    class Class1
    {
      
        static void Saali_suurus()
        {
            Console.WriteLine("Vali saali suurus; 1,2,3");
            int suurus = int.Parse(Console.ReadLine());
            return suurus;

        }
        static int[,] saal = new int[,] { };
        static int kohad, read;

        static void Saali_taitmine(int suurus)
        {
            Random rnd = new Random();
            if (suurus==1)
            {
                kohad = 20;
                read = 10;
            }
            else if (suurus==2)
            {
                kohad = 20;read = 20;
            }
            else
            {
                kohad = 30;read = 20;
            }
            saal = new int 
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
            Console.Write("     ");
            for (int koht = 0; koht < kohad; koht++)
            {
                if (koht.ToString().Lenght == 2)
                { Console.Write("{0}", koht + 1); }
                else
                { Console.WriteLine("{0}", koht + 1); }

            }
            Console.WriteLine();
            for(int rida=0;rida<read;rida++)
            {
                Console.Write("rida" + (rida + 1).ToString() + ":");
                for (int koht=0; koht<kohad;koht++
  
            }
        }

        static bool Muuk()
        {
            Console.Write("Rida: ");
            int pileti_rida = int.Parse(Console.ReadLine());

            Console.WriteLine("mitu piletid:");
            mitu= int.Parse(Console.ReadLine());
            int[] ost = new int[] { };
            int p = kohad / 2;
       

            if (saal[pileti_rida,p]==0)
            {
                Console.WriteLine("koht{0} on vaba", p);
                return true;
            }
            else
            {
                Console.WriteLine("koht{0} on kinni", p);
                return false;
            }
        }
        

        static void Main(string[] args)
        {
            int suurus = Saali_suurus();
            int[,] saal = new int[20, 30];
            Random rnd = new Random();
            for (int rida = 0; rida < 20; rida++)
            {
                for (int koht = 0; koht < 30; koht++)
                {
                    saal[rida, koht] = rnd.Next(0, 2);
                }
            }
            for (int rida = 0; rida < 20; rida++)
            {
                for (int koht = 0; koht < 30; rida++)
                {
                    Console.WriteLine(saal[rida, koht]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
