using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayer
{
    class Program
    {
        static void Lab1()
        {
            string[] personuppgifter = { "", "", "", "", "", "" };
            //string[] personuppgifter = new string [5];

            Console.Write("Mata in ditt förnamn ");
            personuppgifter[0] = Console.ReadLine();
            Console.Write("Mata in ditt efternamn ");
            personuppgifter[1] = Console.ReadLine();
            Console.Write("Mata in din adress ");
            personuppgifter[2] = Console.ReadLine();
            Console.Write("Mata in din postort ");
            personuppgifter[3] = Console.ReadLine();
            Console.Write("Mata in din telefon ");
            personuppgifter[4] = Console.ReadLine();
            Console.WriteLine("Du har matat in följande uppgifter ");
            Console.WriteLine(personuppgifter[0]);
            Console.WriteLine(personuppgifter[1]);
            Console.WriteLine(personuppgifter[2]);
            Console.WriteLine(personuppgifter[3]);
            Console.WriteLine(personuppgifter[4]);
            Console.WriteLine("Stämmer det?");
            Console.ReadLine();
        }

        static void Lab2()
        {
            int[] allaTal = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Mata in ett tal ");
                allaTal[i] = int.Parse(Console.ReadLine());
            }

            int maxTal = 0;

            for (int i2 = 0; i2 < allaTal.Length; i2++)
            {
                if (allaTal[i2] > maxTal)
                {
                    maxTal = allaTal[i2];
                }

            }
            Console.WriteLine("Största värdet är " + maxTal);
            Console.ReadLine();
        }

        static void Lab3()
        {
            Console.Write("Hur många tal vill du mata in?");
            int antalTal = int.Parse(Console.ReadLine());
            int[] allaTal = new int[antalTal];
            for (int i = 0; i < antalTal; i++)
            {
                Console.Write("Mata in ett tal ");
                allaTal[i] = int.Parse(Console.ReadLine());
            }
            int maxTal = 0;

            for (int i2 = 1; i2 < allaTal.Length; i2++)
            {
                if (allaTal[i2] > maxTal)
                {
                    maxTal = allaTal[i2];
                }

            }
            Console.WriteLine("Största värdet är " + maxTal);
            Console.ReadLine();

        }

        static void Lab4()
        {
            int[] allaTal = new int[5];
            int returVarde;
            //Loopar igenom och om inmatat tal är udda ändras det till 0, annars
            //lagras talet
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Mata in ett heltal ");
                returVarde = int.Parse(Console.ReadLine());
                if (returVarde % 2 != 0)
                {
                    allaTal[i] = returVarde;
                }
                else
                {
                    allaTal[i] = 0;
                }
            }
            //Skriver ut resultatet till skärmen
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(allaTal[i]);
            }
            Console.ReadLine();
        }

        static void Lab5()
        {
            Console.Write("Ange hur många mätningar du vill göra:");
            int antal = Convert.ToInt32(Console.ReadLine());
            double[] matningar = new double[antal];
            double maxvarde = 0;
            int raknare = 0;
            double medelvarde = 0;
            double summa = 0;
            while (raknare < antal)
            {
                Console.Write("Mata in tempmätning:");
                matningar[raknare] = Convert.ToDouble(Console.ReadLine());
                if (matningar[raknare] > maxvarde)
                {
                    maxvarde = matningar[raknare];
                }
                summa = (matningar[raknare] + summa);
                raknare++;
            }
            medelvarde = (summa / antal);
            Console.WriteLine("Det högst mätta temperaturen är: " 
                + maxvarde + ", och medelvärdet på samtliga temperaturer är: " 
                + medelvarde);
            
             Console.ReadLine();
        }


        //static string books = "Böcker";
        //static string datorer = "Datorer";
        //static string mat = "Mat";
        //static string skor = "Dojor";
        //static string bilar = "Bilar";

        static string[] categories = {"Böcker", "Datorer", "Mat", "Dojor", "Bilar", "Pennor" };

        static void LagerSaldo()
        {
            Console.WriteLine("Ange vilken kategori du vill köra lagersaldo på");
            string namn = Console.ReadLine();

            //bool existsInList = false;
            //foreach (var cat in categories)
            //    if (cat == namn) existsInList = true;

            if (categories.Contains(namn))
            //if(existsInList)
            {
                Console.WriteLine("Lagersaldoberäkning börjar...");
            }
            else
            {
                Console.WriteLine("Ogiltig kategori");
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Hur många decimaltal vill du mata in?");
            int antalNummer = Convert.ToInt32(Console.ReadLine());

            decimal[] decimalTalen = new decimal[antalNummer];
            for(int i = 0; i < antalNummer; i++)
            {
                Console.Write($"Mata in decimaltal {i}");
                decimalTalen[i] = Convert.ToDecimal(Console.ReadLine());
            }


            Lab1();
            Lab2();
            Lab3();
            Lab4();
            Lab5();
            Console.WriteLine("Välj kategori");

            for (int counter = 0; counter < categories.Length; counter++)
            {
                Console.WriteLine(categories[counter]);
            }

            
            

            

            foreach (string cat in categories)
                Console.WriteLine(cat);
                


            //Console.WriteLine(books);
            //Console.WriteLine(datorer);
            //Console.WriteLine(mat);
            //Console.WriteLine(skor);
            //Console.WriteLine(bilar);
            Console.ReadLine();
        }
    }
}
