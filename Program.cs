using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25___04_Unterricht
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Wir werden mit einem Würfel mit 6 Seite spielen");
            //Random Würfel = new Random();
            //Console.WriteLine("Wollen Sie spielen?");
            //string entscheidung = Console.ReadLine();
            //if (entscheidung == "j")
            //{
            //}
            //Random r = new Random();
            //while (true)
            //{
            //    int Zufallszahl = r.Next(1, 7);
            //    Console.WriteLine(Zufallszahl);
            //    Console.ReadKey();
            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    int Zufallszahl = r.Next(1, 7);
            //    Console.WriteLine(Zufallszahl);
            //}


            //int Zufallszahl;
            //Console.WriteLine("Anzahl der Wieerholung A=");
            //int Anzahl = Convert.ToInt32(Console.ReadLine());
            //int Summe = 0;


            //for (int i = 0; i < Anzahl; i++)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("");
            //    Console.WriteLine((i+1)+":");
            //    Zufallszahl = r.Next(1, 7);
            //    Console.WriteLine(Zufallszahl);
            //    Summe += Zufallszahl;
            //    Console.WriteLine("Zahl=" + Zufallszahl + " Summe=" + Summe);
            //}
            //double Erwartungswert = (double)Summe / (double)Anzahl;
            //Console.WriteLine("Erwartungswert:" + Erwartungswert);
            //Cast: mit (double)Summe wird an dieser Stelle Summe als double verwndet


            //int Summe = 0;
            //Console.WriteLine("Wie viel wollen Sie die Würfel werfen?");
            //int Anzahl = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < Anzahl; i++)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("");
            //    Console.WriteLine((i + 1) + ":");
            //    int Zufallszahl = r.Next(1, 3);
            //    if (Zufallszahl == 1)
            //    {
            //        Zufallszahl = 6;
            //        Console.WriteLine(Zufallszahl);
            //    }
            //    else if (Zufallszahl == 2)
            //    {
            //        Zufallszahl = r.Next(1, 6);
            //        Console.WriteLine(Zufallszahl);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Falsche Angabe");
            //    }
            //    Summe += Zufallszahl;
            //    Console.WriteLine("Zahl=" + Zufallszahl + " Summe=" + Summe);

            //}
            //double Erwartungswert = (double)Summe / (double)Anzahl;
            //Console.WriteLine("Erwartungswert:" + Erwartungswert);

            // WEITERE ANWENDUNGEN VON RANDOM
            Random r = new Random(21);
            for (int i = 0; i < 100; i++) 
            {
                Console.WriteLine(100*r.NextDouble());
            }

            // ZAHLENSYSTEME
            // Dezimalsystem ( 10en-System)
            // 1324 = 1*10^3 + 3*10^2 + 2*10^1 + 4*10^0
            // -------------------------------------------------
            // Binarsystem (2en-System)
            // b = 2, z(i) E {0,1}
            // 1011 = 1*2^3 + 0*2^2 + 1*2^1 + 1*2^0 
            //      = 11(10)
            // 73(10 (normal))-> 1001001(2) (1*2^6 + 1*2^3 + 1*2^0)
            //---------------------------------------------------------
            // Mathoben
            //    Math.Pow(3,2) = 3^2=9
            //    y=f(x)=3x+1



        }

    }
}
