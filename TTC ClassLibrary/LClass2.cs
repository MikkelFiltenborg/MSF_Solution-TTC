using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTC_ClassLibrary
{
    public class DancerPoints
    {
        ///MSF
        ///15-02-2022
        ///Danse konkurrencen Logisk

        //Initiere 2 fields, Navn og Point.
        public string Navn;
        public int Point;

        //Fields bliver forbundet med string og int.
        public DancerPoints(string navn, int point)
        {
            Navn = navn;
            Point = point;
        }

        //Overloader + operatoren med objekter deltager1 og deltager2.
        public static DancerPoints operator +(DancerPoints deltager1, DancerPoints deltager2)
        {
            int totalpoint = deltager1.Point + deltager2.Point;

            string deltagere = $"{deltager1.Navn} & {deltager2.Navn} ";

            //Opretter et objekt som sammenlægger deltagere og totalpoint.
            DancerPoints resultat = new DancerPoints(deltagere, totalpoint);

            return resultat;

        }
    }
}
