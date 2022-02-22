using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTC_ClassLibrary
{
    public class LClass2
    {
        ///MSF
        ///15-02-2022
        ///Danse Konkurrence Logik

        //Metoden for at lave sætningen "Navn1 & Navn2".
        public string DansL(string Navn1, string Navn2)
        {
            //Boolean erklare NavnCheck som falsk.
            bool NavnCheck = false;

            //Checker om Navn1 og Navn2 ikke indeholder tekst, hvis ja vil bool'en fortsat være erklaret falsk.
            if(string.IsNullOrWhiteSpace(Navn1) && string.IsNullOrWhiteSpace(Navn2))
            {
                NavnCheck = false;
            }

            //Erklare NavnCheck som sandt hvis både Navn1 og Navn2 ikke passer på lætningen i den overstående if erklaring.
            else 
            { 
                NavnCheck = true;
            }

            //Kontrollere om NavnCheck er true.
            if (NavnCheck == true)
            {
                //Laver en string ved navn Deltagere og sætter Navn1 og Navn2 sammen med et & tegn imemmel.
                string Deltagere = (Navn1 + " & " + Navn2);
                return Deltagere;
            }

            //Giver en fejlmeddelse hvis NavnCheck er falsk.
            else
            {
                return ("Du skal indtaste et navn.");
            }
        }

        //Metoden for at lægge Point1 og Point2 sammen.
        public int DansL(int Point1, int Point2)
        {
            //Lægger værdien af DancePoint oven i Point og gemmer det i DancePoint.
            return Point1 + Point2;
        }

        //Metoden for at sammensætte Navnene og pointene til en sætning.
        public string DansL(string Deltagere, int Resultat)
        {
            //Udskriver detalger1 og deltager2 efterfulgt af DancePoint værdien.
            return (Deltagere + " " + Resultat);
        }
    }
}
