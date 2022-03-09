using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TTC_ClassLibrary;

namespace MSF_The_Three_Cases_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///MSF
            ///11-02-2022
            ///Menu.

            //Erklare variablen Svar.
            string svar, valg;

            do
            {
                Console.Clear();

                //Hovedmenu.
                Console.WriteLine("Password programmet\n\nHer kan du\n" +
                    "\nLogin              - [ 1 ]" +
                    "\nOpret Bruger       - [ 2 ]" +
                    "\nAfslut programmet  - [ 0 ]");
                Console.Write("\nSkriv her: ");
                valg = Console.ReadLine();

                Console.Clear();

                switch (valg)
                {
                    //Login.
                    case "1":

                        //Kalder metoden Login.
                        bool login = VClass3.Login();

                        if (login == true)
                        {
                            //Do-While loop some køre menuen igennem ind til Svar indeholder 0
                            do
                            {
                                //Renser konsollen for tekst.
                                Console.Clear();

                                //Menuen hvor brugeren kan se valgmulighederne og indtaste deres valg som gemmes i Svar.
                                Console.WriteLine("Vælg et program\n" +
                                    "\nTast [ 1 ] for Fodbold kamp programmet" +
                                    "\nTast [ 2 ] for Danse konkurrence point beregner" +
                                    "\nTast [ 3 ] for Password redigering" +
                                    "\nTast [ 0 ] for at retunere til hovedmenuen");
                                Console.Write("\nSkriv her: ");
                                svar = Console.ReadLine();

                                //fjerner den forrige tekst fra konsollen.
                                Console.Clear();

                                //Switch case som diregere hvilken handling skal udføres som følge af brugerns valg.
                                switch (svar)
                                {
                                    //Informere brugeren om at programmet afsluttes, med en besked der vises i 2 sekunder før programmet lukker.
                                    case "0":
                                        Console.WriteLine("Retunere til hovedmenuen");
                                        Thread.Sleep(1000);
                                        break;

                                    //Dirigere programmet mod VClass1 og metoden ved navn FodboldV
                                    case "1":
                                        VClass1.FodboldV();
                                        break;

                                    //Dirigere programmet mod VClass2 og metoden ved navn DansV
                                    case "2":
                                        VClass2.DansV();
                                        break;

                                    //Dirigere programmet mod VClass3 og metoden ved navn ChangePassword
                                    case "3":
                                        VClass3.ChangePassword();
                                        break;

                                    //Informere brugeren om at indtastningen ikke stemmer med nogle af de gyldige valgmuligheder, og vender tilbage til menuens start efter 1 sekundt.
                                    default:
                                        Console.WriteLine("Ugyldig input.");
                                        Thread.Sleep(1000);
                                        break;
                                }
                            }
                            while (svar != "0");
                        }

                        //Skal være der for at koden kan have en returværdi når login = false.
                        else
                        {
                        }

                        break;

                    //Opret bruger og password.
                    case "2":
                        //Kalder metoden NewUser.
                        VClass3.NewUser();
                        break;

                    //Afslut program.
                    case "0":
                        Console.WriteLine("Programmet afslutter.");
                        Thread.Sleep(2000);
                        break;

                    //Fejlmeddelse.
                    default:
                        Console.WriteLine("Ugyldigt input.");
                        Thread.Sleep(1000);
                        break;
                }
            }
            while (valg != "0");
        }
    }
}
