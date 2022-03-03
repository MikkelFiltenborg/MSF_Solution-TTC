using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTC_ClassLibrary;
using System.Threading;
using System.IO;

namespace MSF_The_Three_Cases_ConsoleApp1
{
    public class VClass3
    {
        ///MSF
        ///21-02-2022
        ///Oprettelse af gyldigt Password Visuel

        public static void PasswordV()
        {
            string bruger = "", password, nypassword, valg, filnavn = @"C:\Users\MikFil\Desktop\Password.txt";
            bool login, passcheck, nypasscheck;

            do
            {
                Console.Clear();

                //Password menu.
                Console.WriteLine("Password programmet\n\nHer kan du\n" +
                    "Login              - [ 1 ]\n" +
                    "Opret Password     - [ 2 ]\n" +
                    "Rediger Password   - [ 3 ]\n" +
                    "Retuner til menuen - [ 0 ]\n");
                Console.Write("Tast her: ");
                valg = Console.ReadLine();

                Console.Clear();

                switch (valg)
                {
                    //Login.
                    case "1":
                        Console.WriteLine("Indtast venligst dit brugernavn");
                        Console.Write("Skriv her: ");
                        bruger = Console.ReadLine();

                        Console.WriteLine("\nIndtast venligst dit password");
                        Console.Write("Skriv her: ");
                        password = Console.ReadLine();

                        login = LClass3.LoginL_Check(bruger, filnavn, password);

                        Console.Clear();

                        if (login == true)
                        {

                            Console.WriteLine("Brugernavn Godkendt\n");
                            Thread.Sleep(500);
                            Console.WriteLine("Godkendt password");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }

                        else if (login == false)
                        {
                            Console.WriteLine(login);
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine("Ugyldigt brugernavn eller password");
                            Thread.Sleep(2000);
                        }
                        break;

                    //Opret bruger og password.
                    case "2":
                        Console.WriteLine("Brugernavnet er allerede oprettet.\n");

                        Console.WriteLine("Dit nye password skal opfylde følgende krav:\n" +
                                    " - Tal må ikke være i starten eller slutningen\n" +
                                    " - Skal indeholde både store og små bogstaver\n" +
                                    " - Brugernawn of Password må ikke være ens\n" +
                                    " - Skal indeholde minimum et special tegn\n" +
                                    " - Må ikke indeholde nogen mellemrum\n" +
                                    " - Skal indeholde minimum 12 tegn\n");

                        Console.WriteLine("Indtast venligst et password");
                        Console.Write("Skriv her: ");
                        password = Console.ReadLine();
                        Console.Clear();

                        login = LClass3.LoginL_Check(bruger, filnavn, password);

                        if (login == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Godkendt password\n");
                            Thread.Sleep(500);
                            Console.WriteLine("Bruger1 oprettet");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }

                        else
                        {
                            Console.WriteLine("Ugyldigt password\nKrav ikke opfyldt");
                            Thread.Sleep(2000);
                        }
                        break;

                    //Rediger Password.
                    case "3":
                        Console.WriteLine("Indtast venligst dit brugernavn");
                        Console.Write("Skriv her: ");
                        bruger = Console.ReadLine();

                        Console.WriteLine("\nIndtast venligst dit password for at ændre det.");
                        Console.Write("Skriv her: ");
                        password = Console.ReadLine();
                        Console.Clear();

                        login = LClass3.LoginL_Check(bruger, filnavn, password);

                        if (login == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Brugernavn Godkendt\n");
                            Thread.Sleep(500);
                            Console.WriteLine("Godkendt password");
                            Thread.Sleep(1000);
                            Console.Clear();

                            Console.WriteLine("Du kan nu ændre dit password\n");
                            Console.WriteLine("Dit nye password skal opfylde følgende krav:\n" +
                                " - Tal må ikke være i starten eller slutningen\n" +
                                " - Skal indeholde både store og små bogstaver\n" +
                                " - Brugernawn of Password må ikke være ens\n" +
                                " - Skal indeholde minimum et special tegn\n" +
                                " - Må ikke indeholde nogen mellemrum\n" +
                                " - Skal indeholde minimum 12 tegn\n");

                            Console.Write("Skriv nyt password her: ");
                            nypassword = Console.ReadLine();

                            passcheck = LClass3.PasswordL_Capital(nypassword);

                            nypasscheck = LClass3.PasswordL_NyCheck(password, nypassword);

                            if (passcheck == true && nypassword != password)
                            {
                                Console.WriteLine("Dit password er nu ændret");
                                Thread.Sleep(2000);

                                //overwrite previous password.
                            }

                            else
                            {
                                Console.WriteLine("Dit password overholder ikke minimum krav");
                                Thread.Sleep(2000);
                            }
                        }

                        else
                        {
                            Console.WriteLine("Ugyldigt brugernavn eller password");
                            Thread.Sleep(2000);
                        }
                        break;

                    //Retuner til menuen.
                    case "0":
                        break;

                    //Fejlmeddelse
                    default:
                        Console.WriteLine("Ugyldigt input.");
                        Thread.Sleep(1000);
                        break;
                }
            } while (valg != "0");
        }
    }
}
