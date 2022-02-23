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
            string navn1 = "", navn2 = "", deltagere = "";
            int point1 = 0, point2 = 0, resultat = 0;

            LClass2 dancepoint_obj = new LClass2();

            //Beder brugeren om at indtaste deltagerens navn og gemmer det i string navn.
            Console.WriteLine("Indtast venligst deltagerens navne.");
            Console.Write("\nDeltager 1: ");
            navn1 = Console.ReadLine();
            Console.Write("\nDeltager 2: ");
            navn2 = Console.ReadLine();

            //Renser konsollen.
            Console.Clear();

            //Beder brugeren om at indtaste hvor mange point deltageren fik og gemmer det i Point, efter at konvertere fra string til integer.
            Console.WriteLine("\nIndtast venligst deltagerens dance-points");
            Console.Write("\nDeltager 1: ");
            point1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDeltager 2: ");
            point2 = Convert.ToInt32(Console.ReadLine());
            
            //Renser konsollen.
            Console.Clear();

            //Kalder metoden DansL og kalder den Deltagere.
            deltagere = dancepoint_obj.DansL(navn1, navn2);

            //Kalder metoden fra DansL og lægger værdien i Resultat.
            resultat = dancepoint_obj.DansL(point1, point2);

            //Kalder metoden DansL og lægger den i Svar, hvorefter den udskrives.
            string svar = dancepoint_obj.DansL(deltagere, resultat);
            Console.WriteLine(svar);

            //Afventer et input fra brugeren så programmet ikke lukker uden at brugeren kan så scoren og navnene.
            Console.WriteLine("\n\nTryk på en tast for at retunere til menuen.");
            Console.ReadKey();
        }
    }
}