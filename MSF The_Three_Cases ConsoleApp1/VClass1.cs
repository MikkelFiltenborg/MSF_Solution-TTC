using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTC_ClassLibrary;


namespace MSF_The_Three_Cases_ConsoleApp1
{
    public class VClass1
    {
        ///MSF
        ///11-02-2022
        ///Fodbold - fan support på lægterne Visuel
        
        public static void FodboldV()
        {
            //Beder brugeren om at indtaste hvor mange afleveringer fodboldholdet har lavet.
            Console.WriteLine("Hvor mange afleveringer lavede fodboldholdet?");
            Console.Write("\nSkriv her: ");

            //Integer input. Antal afleveringer.
            int afleveringer = Convert.ToInt32(Console.ReadLine());

            //Beder brugeren om at indtaste om fodboldholdet har scoret mål.
            Console.WriteLine("\nHvis dit hold har scoret mål bedes du skrive mål." +
                "\nHvis ikke, tryk på ENTER for at fortsætte.");
            Console.Write("\nSkriv her: ");

            //String input. Mål værdi.
            string mål = Console.ReadLine();
            string målcheck = mål.ToLower();

            //Renser konsollen for tekst.
            Console.Clear();

            //Kalder resultatet fra den logiske del og udskriver det.
            string resultat = LClass1.FodboldL(målcheck, afleveringer);
            Console.WriteLine(resultat);

            //Stopper programmet indtil et tastetryk forekommer og fjerner derefter den forrige tekst i konsollen.
            Console.ReadKey();
            Console.Clear();
        }
    }
}
