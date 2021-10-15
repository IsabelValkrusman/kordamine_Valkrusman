using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_Valkrusman
{
    class kordamine
    {
        static void Main(string[] args)
        {

            //3 ülesanne- Sorteeri sisestatud perekonnanimede loend tähestikulises järjekorras ja kuva see.

            Console.Write("Sisestage perekona nimed  { 0 } ): ", sep);
            string[] pnimi = Console.ReadLine().Split(sep);

            Console.Clear();
            List list = new List(pnimi);
            list.Sort();
            Console.Write(String.Join(sep.ToString(), list));











            //1 ülesanne- Leidke 10x10 ruutmaatriksi elementide summa ja korrutis.

            //  Random r = new Random();
            //  Console.Write("Sisestage arv ")

            //int[,] A = new int[4, 4];
            // for (int i = 0; i < 4; i++)
            // {
            //     for (int j = 0; j < 4; j++)
            //    {
            //         A[i, j] = r.Next(10);
            //      }
            //  }

            //  for (int i = 0; i < 4; i++)
            //  {
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("{0} ", A[i, j]);
            //   }
            //      Console.WriteLine("\n");
            // }

            //  int count = 0;
            // for (int i = 0; i < 4; i++)
            //  {
            //      if (A[i, i] % 2 == 0)
            //          count++;
            // }

            // if (count == 0)
            //    Console.WriteLine("viga");







            //2 ülesanne Esitatakse kolm kolmnurka nende külgedega (a, b, c). Leidke suurima perimeetri või suurima alaga kolmnurk. Kas see jääb alati samaks kolmnurgaks?


          //  int[] A = new int[3];
          //  int[] B = new int[3];
          //  int[] C = new int[3];
           // A = CreateValue(A);
          //  B = CreateValue(B);
          //  C = CreateValue(C);
         //   int[] esimene = SquarePerimeter(A);
         //   int[] teine = SquarePerimeter(B);
          //  int[] kolmas = SquarePerimeter(C);
          //  Console.WriteLine($"ruut : A {esimene[0]}, B {teine[0]}, C {kolmas[0]}");
          //  Console.WriteLine($"periimeter : A {esimene[1]}, B {teine[1]}, C {kolmas[1]}");
      
        
     
         //   int periimeter = 0;
        //    int ruut = 0;
         //   int[] vastus = new int[2];
        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        periimeter += myArray[i];
        //        ruut = myArray[i];
        //    }
        //    vastus[1] = periimeter;
        //    vastus[0] = ruut;
       







            Console.ReadKey();
        }
    }
}