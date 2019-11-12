using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasodikValodiCsharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine($"1 - 100 ig azok a számok melyek valódi osztóinak összege osztható héttl");
             for (int i = 0; i < 101; i++)
             {
                 if (osszeghettel(i))
                 {
                     Console.WriteLine($" {szam} valódi osztóinak száma osztható 7*el ");
                 }

             }*/


            /*int szam = 0
                while (szam) {
                Console.WriteLine($"Kérek egy egész sámot");
                szam = Convert.ToInt32(Console.ReadLine)
                    }
            if (osszegettel(szam)
            {
                Console.WriteLine($" {szam} valódi osztóinak száma osztható 7*el ");
            }
            Console.WriteLine($"{szam} valódi osztóinak a száma nem oszthaó ");
        } */

            Console.WriteLine("2 től 100 ig primszamokat: ");

            for (int i = 2; i < 101; i++)
            {
                if (PrimszamE(i))
                {
                    Console.WriteLine(i);
                }
            }




        Console.ReadKey(true);
    }
        //gyors megoldas
        static bool PrimszamE(int szam)
        {
            bool primE = true;
            int hatar = (int)Math.Floor(Math.Sqrt(szam)) + 1;

            for (int i = 0; i < hatar; i++)
            {
                if (szam % i == 0)
                {
                    primE = false;
                    break;
                }
            }
        } 



       /* static bool osszeghettel(int szam);
        int osszeg = 0;
        bool hettel = true;

        for (int i = 1; i < szam; i++)
			{
            if (szam % 1 == 0)
	           { 
                  osszeg == 1;

	           }
            }  
            if (osszeg % 7(=0))
	{
              hettel = false;
	}

    */
        
    }
}
