using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTC_ClassLibrary;
using System.Threading;

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
            string navn1, navn2, svar;
            int point1, point2;

            do
            {
                //Danse konkurrence menu.
                Console.WriteLine("Danse konkurrencen" +
                    "\n\nHer kan du" +
                    "\nBeregn dansernes point  - [ 1 ]" +
                    "\nRetuner til menuen      - [ 0 ]");
                Console.Write("\nSkriv her: ");
                svar = Console.ReadLine();

                Console.Clear();

                switch (svar)
                {
                    case "0":
                        //Informere brugeren om at de retunere til menuen
                        Console.WriteLine("Retunere til menuen");
                        Thread.Sleep(1000);
                        break;

                    case "1":
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

                        //Opretter to objekter, deltager1 og deltager2.
                        DancerPoints deltager1 = new DancerPoints(navn1, point1);
                        DancerPoints deltager2 = new DancerPoints(navn2, point2);

                        //Obejkt resultat sammenlægger deltager1 og deltager2 via operator overload +.
                        DancerPoints resultat = deltager1 + deltager2;

                        //udskriver resultatet for Navn + Point.
                        Console.WriteLine(resultat.Navn + resultat.Point);

                        //Afventer et input fra brugeren så programmet ikke lukker uden at brugeren kan så scoren og navnene.
                        Console.WriteLine("\n\nTryk på en tast for at retunere til menuen.");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
            while (svar != "0");
        }
    }
}