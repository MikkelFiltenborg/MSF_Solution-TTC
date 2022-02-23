using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTC_ClassLibrary;
using System.Threading;

namespace MSF_The_Three_Cases_ConsoleApp1
{
    public class VClass3
    {
        ///MSF
        ///21-02-2022
        ///Oprettelse af gyldigt Password Visuel

        public static void PasswordV()
        {
            string brugernavn = "", password = "", nypassword = "", valg = "";
            bool navncheck = false, passcheck = false, login = false;

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
                        brugernavn = Console.ReadLine();

                        if (navncheck == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Brugernavn Godkendt");
                            Thread.Sleep(1000);
                            Console.Clear();

                            Console.WriteLine("Indtast venligst dit password");
                            Console.Write("Skriv her: ");
                            password = Console.ReadLine();

                            if (passcheck == true)
                            {
                                Console.WriteLine("\nGodkendt password");
                                Console.ReadKey();
                            }

                            else
                            {
                                Console.WriteLine("\nUgyldigt brugernavn eller password");
                                Console.ReadKey();
                            }
                        }

                        else
                        {
                            Console.WriteLine("Ugyldigt brugernavn eller password");
                            Thread.Sleep(2000);
                        }
                        break;

                    //Opret password.
                    case "2":
                        Console.WriteLine("Indtast venligst dit brugernavn");
                        Console.Write("Skriv her: ");
                        brugernavn = Console.ReadLine();
                        Console.Clear();

                        navncheck = LClass3.BrugernavnL_Check(brugernavn);

                        if (navncheck == true)
                        {
                            Console.WriteLine("Brugernavn Godkendt");
                            Thread.Sleep(1000);
                            Console.Clear();

                            Console.WriteLine("Dit nye password skal opfylde følgende krav:\n" +
                                    " - Tal må ikke være i starten eller slutningen" +
                                    " - Skal indeholde både store og små bogstaver" +
                                    " - Brugernawn of Password må ikke være ens" +
                                    " - Skal indeholde minimum et special tegn" +
                                    " - Må ikke indeholde nogen mellemrum" +
                                    " - Skal indeholde minimum 12 tegn\n");

                            Console.WriteLine("Indtast venligst dit password");
                            Console.Write("Skriv her: ");
                            password = Console.ReadLine();
                            Console.Clear();

                            login = LClass3.PasswordL_Login(password, brugernavn);

                            if (login == true)
                            {
                                Console.WriteLine("\nGodkendt password");
                                Thread.Sleep(1000);
                            }

                            else
                            {
                                Console.WriteLine("\nIKKE GODKENDT password");
                                Thread.Sleep(1000);
                            }
                        }

                        else
                        {
                            Console.WriteLine("IKKE GODKENDT brugernavn");
                            Thread.Sleep(2000);
                        }
                        break;

                    //Rediger Password.
                    case "3":
                        Console.WriteLine("Indtast venligst dit brugernavn");
                        Console.Write("Skriv her: ");
                        brugernavn = Console.ReadLine();
                        Console.Clear();

                        navncheck = LClass3.BrugernavnL_Check(brugernavn);

                        if (navncheck == true)
                        {
                            Console.WriteLine("Brugernavn Godkendt");
                            Thread.Sleep(1000);
                            Console.Clear();
                            
                            Console.WriteLine("Indtast venligst dit password for at ændre det.");
                            Console.Write("Skriv her: ");
                            password = Console.ReadLine();
                            Console.Clear();

                            login = LClass3.PasswordL_Login(password, brugernavn);

                            if (login == true)
                            {
                                Console.WriteLine("\nGodkendt password");
                                Thread.Sleep(1000);
                                Console.WriteLine("Du kan nu ændre dit password\n");
                                Console.WriteLine("Dit nye password skal opfylde følgende krav:\n" +
                                    " - Tal må ikke være i starten eller slutningen" +
                                    " - Skal indeholde både store og små bogstaver" +
                                    " - Brugernawn of Password må ikke være ens" +
                                    " - Skal indeholde minimum et special tegn" +
                                    " - Må ikke indeholde nogen mellemrum" +
                                    " - Skal indeholde minimum 12 tegn\n");

                                Console.Write("Skriv nyt password her: ");
                                nypassword = Console.ReadLine();

                                login = LClass3.PasswordL_Login(password, brugernavn);

                                Console.Clear();

                                if(login == true)
                                {
                                    //overwrite previous password.
                                    Console.WriteLine("Dit password er nu ændret");
                                    Thread.Sleep(1000);
                                }

                                else
                                {
                                    Console.WriteLine("Dit password overholder ikke minimum krav");
                                    Thread.Sleep(2000);
                                }
                            }

                            else
                            {
                                Console.WriteLine("\nIKKE GODKENDT password");
                                Thread.Sleep(1000);
                            }
                        }

                        else
                        {
                            Console.WriteLine("IKKE GODKENDT brugernavn");
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
