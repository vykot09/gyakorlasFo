using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikValodiPrijekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //int32.TryParse használata
            /* 
             int szam = -89;
             bool egeszSzam = true;
             do
             {
                 Console.Write("kérek egy számot: ");
                 egeszSzam = Int32.TryParse(Console.ReadLine(), out szam);
             } while (!egeszSzam);







          /*   Console.Write("kérek egy számot: ");

             bool egeszszam = Int32.TryParse(Console.ReadLine(), out szam);

             Console.WriteLine($"A bekért szám: {szam}");*/


            //23.feladat
            /* string kimenet = "";

             Console.Write("Kérek egy pozitiv egész számot: ");
             int szam = Int32.Parse(Console.ReadLine());

             kimenet += szam + " = ";

             while (szam % 2 == 0)
             {
                 kimenet += 2 + " * ";
                 szam = szam / 2;
             }

             kimenet += " = " + szam;

             Console.WriteLine(kimenet);*/

            //25.feladat

            /* string kimenet = "";

             Console.Write("Kérek egy pozitiv egész számot: ");
             int szam = Int32.Parse(Console.ReadLine());

             kimenet += szam + " = ";
             int egesz = 0;
             int tort = szam;



             while (szam - 3 >= 0) ;
             {
                 szam = szam - 3;
                 egesz++;
                 tort = szam ;

             }

             kimenet += egesz + " * 3 + " + tort;


             Console.WriteLine(kimenet);
             */

            //24.feladat
            /*    string alma = "";

                while (alma != "alma")
                {
                    Console.Write("Kérek egy gyümölcsöt: ");
                    alma = Console.ReadLine();
                }

                Console.WriteLine("Az alma egy gyümölcs!");*/


            //28-29.feladat
            /* string kimenet = ""; 

             Console.Write("Kérek egys számot: ");
             int szam = Int32.Parse(Console.ReadLine());

             kimenet += szam + " = ";
             int meddig = ((int)Math.Floor(Math.Sqrt(szam))) + 1;

             for (int i = 2; i < meddig; i++)
             {
                 if (szam % i == 0)
                 {
                     if (szam == i)
                     {
                         kimenet += i;
                     }
                     else
                     {
                         kimenet += i + " * ";
                         szam = szam / i;
                         i--;
                     }

                 }
             }

             Console.WriteLine(kimenet);*/

            //32.feladat

            /*    Console.Write("Kérek egy pozitiv egesz szamot számot: ");
                int szam = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine($"{szam} * {i} = {szam * i}");

                }*/

            //33.feladat
            /*   Console.Write("Kérek egy pozitiv egesz szamot számot: ");
               int szam = Int32.Parse(Console.ReadLine());

               for (int i = 1; i < szam + 1; i++)
               {
                   for (int j = 1; j < szam; j++)
                   {
                       Console.SetCursorPosition(3 * (j - 1) + 1, i);
                       Console.Write($"{i * j}")
                   }
               }
               */

            //34.feladat

            for (int i = 10; i < 100; i++)
            {
                for (int j = 10; j < 100; j++)
                {

                }
                for (int k = 10; k < 100; k++)
                {

                }
            }




                Console.ReadKey(true);
        }
    }
}
