using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTC_ClassLibrary;

namespace MSF_The_Three_Cases_ConsoleApp1
{
    public class VClass2
    {
        ///MSF
        ///15-02-2022
        ///Danse konkurrencen Visuel

        public static void DansV()
        {
            //Erklare strings og integers.
            string Navn1 = "", Navn2 = "", Deltagere = "";
            int Point1 = 0, Point2 = 0, Resultat = 0;

            LClass2 DancePoint_obj = new LClass2();

            //Beder brugeren om at indtaste deltagerens navn og gemmer det i string navn.
            Console.WriteLine("Indtast venligst deltagerens navne.");
            Console.Write("\nDeltager 1: ");
            Navn1 = Console.ReadLine();
            Console.Write("\nDeltager 2: ");
            Navn2 = Console.ReadLine();

            //Renser konsollen.
            Console.Clear();

            //Beder brugeren om at indtaste hvor mange point deltageren fik og gemmer det i Point, efter at konvertere fra string til integer.
            Console.WriteLine("\nIndtast venligst deltagerens dance-points");
            Console.Write("\nDeltager 1: ");
            Point1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDeltager 2: ");
            Point2 = Convert.ToInt32(Console.ReadLine());
            
            //Renser konsollen.
            Console.Clear();

            //Kalder metoden DansL og kalder den Deltagere.
            Deltagere = DancePoint_obj.DansL(Navn1, Navn2);

            //Kalder metoden fra DansL og lægger værdien i Resultat.
            Resultat = DancePoint_obj.DansL(Point1, Point2);

            //Kalder metoden DansL og lægger den i Svar, hvorefter den udskrives.
            string Svar = DancePoint_obj.DansL(Deltagere, Resultat);
            Console.WriteLine(Svar);

            //Afventer et input fra brugeren så programmet ikke lukker uden at brugeren kan så scoren og navnene.
            Console.WriteLine("\n\nTryk på en tast for at retunere til menuen.");
            Console.ReadKey();
        }
    }
}