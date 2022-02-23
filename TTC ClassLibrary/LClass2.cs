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
        public string DansL(string navn1, string navn2)
        {
            //Boolean erklare NavnCheck som falsk.
            bool navncheck = false;

            //Checker om Navn1 og Navn2 ikke indeholder tekst, hvis ja vil bool'en fortsat være erklaret falsk.
            if(string.IsNullOrWhiteSpace(navn1) && string.IsNullOrWhiteSpace(navn2))
            {
                navncheck = false;
            }

            //Erklare NavnCheck som sandt hvis både Navn1 og Navn2 ikke passer på lætningen i den overstående if erklaring.
            else 
            { 
                navncheck = true;
            }

            //Kontrollere om NavnCheck er true.
            if (navncheck == true)
            {
                //Laver en string ved navn Deltagere og sætter Navn1 og Navn2 sammen med et & tegn imemmel.
                string deltagere = (navn1 + " & " + navn2);
                return deltagere;
            }

            //Giver en fejlmeddelse hvis NavnCheck er falsk.
            else
            {
                return ("Du skal indtaste et navn.");
            }
        }

        //Metoden for at lægge Point1 og Point2 sammen.
        public int DansL(int point1, int point2)
        {
            //Lægger værdien af DancePoint oven i Point og gemmer det i DancePoint.
            return point1 + point2;
        }

        //Metoden for at sammensætte Navnene og pointene til en sætning.
        public string DansL(string deltagere, int resultat)
        {
            //Udskriver detalger1 og deltager2 efterfulgt af DancePoint værdien.
            return (deltagere + " " + resultat);
        }
    }
}
