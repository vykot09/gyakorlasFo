using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoValodiCharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Feladat: 
            string kiir = "Hello world!";
            Console.WriteLine(kiir);*/

            /* 2. Feladat:
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek {nev}!");*/

            /* 3. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szam = Int32.Parse(Console.ReadLine());
            int szam = Convert.ToInt32(Console.ReadLine());
            double szam = Double.Parse(Console.ReadLine());
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A szám: {szam} kétszerese: {2 * szam}");*/

            /* 4. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            int osszeg = szamA + szamB;
            int kulonbseg = szamA - szamB;
            int szorzat = szamA * szamA;
            double hanyados = (double)szamA / szamB;

            Console.WriteLine($"A két szám: {szamA} és {szamB}: ");
            Console.WriteLine($"Összege: {osszeg}");
            Console.WriteLine($"Különbsége: {kulonbseg}");
            Console.WriteLine($"Szorzata: {szorzat}");
            Console.WriteLine($"Hányadosa: {hanyados}");*/

            /* 5. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA > szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else if (szamB > szamA)
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő!");
            }

            if (szamA >= szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }*/

            /* 6. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA <= szamB)
            {
                if (szamA <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamA}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }
            else
            {
                if (szamB <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamB}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }*/

            /* 7. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA + szamB > szamC && szamA + szamC > szamB && szamB + szamC > szamA)
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög szerkeszthető.");
            }
            else
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög nem szerkeszthető.");
            }*/

            /* 8. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA >= 0 && szamB >= 0)
            {
                double szamtani = ((double)szamA + szamB) / 2;
                double mertani = Math.Sqrt(szamA * szamB);
                Console.WriteLine($"A két szám: {szamA} és {szamB} számtani közepe: {szamtani}");
                Console.WriteLine($"A két szám: {szamA} és {szamB} mértani közepe: {mertani}");
            }
            else
            {
                Console.WriteLine("A feladat nem megoldható!");
            }*/

            //15. feladat

            /* Console.WriteLine("Kérem a potitiv egész szám");
             int bemenoszam = Int32.Parse(Console.ReadLine());
             /* string kiiratas = "";

              for (int i = 0; i <= bemenoszam; i++)
              {
                  kiiratas += i + " ";
              }
              Console.WriteLine(kiiratas); */

            /*for (int i = 0; i < bemenoszam; i++)
            {
                Console.Write(i + " ");
            }*/
            /*
                        Console.WriteLine("Kérem a potitiv egész szám");
                        int bemenoszam = Int32.Parse(Console.ReadLine());

                        int i = 1;
                        //Eköl tesztelő ciklus
                        while (i < bemenoszam)
                        {
                            Console.Write(i++ + " ");
                            // i = i + 1;
                            //i += 1;
                            //i++;
                        }
                        do
                        {
                           Console.Write(i + " ")7

                        } while (trueI < bemenoszam);*/

            //17.feladat
            // Console.WriteLine("Kérem a potitiv egész szám");
            //int bemenoszam = Int32.Parse(Console.ReadLine());
            // string kiiratas = "";




            /*for (int i = 0; i <= bemenoszam; i++)
            {
                kiiratas += "\t" + i + " \n";
            77}
            Console.WriteLine(kiiratas);
           int i = i;*/

            //17. feladat

            /*  Console.WriteLine("Kérem a potitiv egész szám: ");
              int bemenoszam = Int32.Parse(Console.ReadLine());


              Console.WriteLine($"{bemenoszam} egész osztoi: ");
              int i = 0;
              while(i <= bemenoszam)
              {
                  if (bemenoszam % i == 0)
                  {
                      Console.WriteLine(i);
                  }
                  i++;
              }*/

            //Plusz feladat: Pozitiv szám prime

            /*    Console.WriteLine("Kérem a potitiv egész szám: ");
                int d = Int32.Parse(Console.ReadLine());

                int szamlalo = 0;

                for (int i = 1; i < d + 1; i++)
                {
                    if (d % i == 0)
                    {
                        szamlalo++;

                    }
                    if (szamlalo == 2)
                    {
                        Console.WriteLine($"A bemenö szám {d} prim.");
                    }
                    else
                    {
                        Console.WriteLine($"A bemeno szám {d} nem prim");
                    }

                }
                */


            //18. feladat

            /*    Console.WriteLine("Kérem a pozitiv egész számot");
                int a = Int32.Parse(Console.ReadLine());

                int szamlalo = 0;
                int osztokosszege = 0;

                for (int i = 0; i < a + 1; i++)
                {
                    if (a % i == 0)
                    {
                        szamlalo++;
                        osztokosszege++;
                    }
                }
                if (szamlalo % i == 2)
                {
                    Console.WriteLine($"A bemeno szam {a} prim.");
                    Console.WriteLine($"Az osztoinak az összege {osztokosszege} ");
                }
                else
                {
                    Console.WriteLine($"A bemeno szam {a} nem prim.");
                    Console.WriteLine($"Az osztoinak az összege {osztokosszege} ");
                }
                */

            //19.fealdat

            /*   Console.WriteLine("Kérem a pozitiv egész számot");
               int a = Int32.Parse(Console.ReadLine());

               int i = 1;
               int osztokosszege = 0;

               while (i <= a)
               {
                   if (a % i == 0)
                   {
                       osztokosszege += i;
                   }
                   i++;
               }
               if (osztokosszege == 2 * a )
               {
                   Console.WriteLine($"A szám {a} tokeletes szám. ");
               }
               else
               {
                   Console.WriteLine($"A szám {a} nem tokeletes szám");
               }*/

            //20.feladat

            /* int a = -1;
             while (a <= 0 || a >= 10)
             {
                 Console.WriteLine("Kérem a hatvány alapját:");
                 a = Int32.Parse(Console.ReadLine());
             }
             int k = -1;
             while (k <= 0 || k >= 10)
             {
                 Console.WriteLine("Kérem a hatvány alapját:");
                 k = Int32.Parse(Console.ReadLine());
                 int hatvany = 1;
             }

             for (int i = 0; i < k; i++)
             {
                 hatvany *= a;
             }
             Console.Write($"A hatvány: {hatvany}");*/


            //21. feladat

            /*      int szam = 0

                    while (szam <= 0) ;
                {
                    Console.WriteLine($(Kérek, egy poziztv szam: *))
                    szam = Convert.ToInt32(Console.ReadLine());
                }*/

            /*
            int szam = -1;
            while (szam % 2 == 1 || szam % 2 == -1) ;
            {
                Console.WriteLine($"Kérem a pozitiv egesz szamot");
                int szam = Convert.ToInt32(Console.ReadLine())
            }*/

            //Plusz feladat: Primszamra lépjen ki a ciklusbol.

            /* int szam = 3;

             while (primszamE(szam))
             {
                 Console.Write("Kérek egy nem prim szammot: ");
                 szam = Convert.ToInt32(Console.ReadLine());
             }*/

            //22. feladat

            int szam = 0;
            int osszeg = 0;

            while (szam <= 10)
            {
                Console.WriteLine("Kérek egy 10-nél kissebb számot: ");
                szam = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"AZ eddig beolvasott megfelelo számok összege: {osszeg}");
                if (szam <= 10)
                {
                    osszeg += szam;
                    Console.WriteLine($"AZ eddig beolvasott megfelelo számok összege: {osszeg}");
                }
                else
                {
                    Console.WriteLine("Nem megfelelo szám!");
                }
            }
            Console.WriteLine($"A beolvasott számok összege: {osszeg}");


            Console.ReadKey(true);
        }

        static bool primszamE(int szam)
        {
            bool teljesul = true;

            int osztokszama = 0;

            for (int i = 0; i < szam ; i++)
            {
                if (szam % i == 0)
                {
                  //  osztokSzama++;
                }

            }
            if (osztokszama == 2)
            {
                return teljesul;
            }
            else
            {
                return !teljesul;
            }
        }
    }
}
