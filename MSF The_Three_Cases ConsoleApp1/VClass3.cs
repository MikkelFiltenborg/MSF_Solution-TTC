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

        //Login.
        public static bool Login()
        {
            string bruger, password, filnavn = @"C:\Users\MikFil\Desktop\Login.txt";
            bool login;

            //Beder brugren om deres login.
            Console.WriteLine("Indtast venligst dit brugernavn");
            Console.Write("\nSkriv her: ");
            bruger = Console.ReadLine();

            Console.WriteLine("\nIndtast venligst dit password");
            Console.Write("\nSkriv her: ");
            password = Console.ReadLine();

            //Kalder metoden LoginL_Check.
            login = LClass3.LoginL_Check(bruger, filnavn, password);

            Console.Clear();

            //Hvis login = true, informeres brugeren om at deres login er bekræftet.
            if (login == true)
            {
                Console.WriteLine("Brugernavn godkendt");
                Thread.Sleep(500);
                Console.WriteLine("\nPassword godkendt");
                Thread.Sleep(1000);
                Console.Clear();
                return true;
            }

            //Hvis login = false, informere brugeren om at deres login ikke er korrekt.
            else
            {
                Console.WriteLine("Ugyldigt brugernavn eller password");
                Thread.Sleep(2000);
                return false;
            }
        }

        //Opret bruger.
        public static void NewUser()
        {
            string bruger = "", password, filnavn = @"C:\Users\MikFil\Desktop\Login.txt";
            bool login;

            //Hvis filen Password.txt ikke findes, bruges denne del.
            if (!File.Exists(filnavn))
            {
                Console.WriteLine("Brugernavnet [ Bruguer1 ] er oprettet.");

                //Password krav.
                Console.WriteLine("\nDit nye password skal opfylde følgende krav:" +
                            "\n - Tal må ikke være i starten eller slutningen" +
                            "\n - Skal indeholde både store og små bogstaver" +
                            "\n - Brugernawn of Password må ikke være ens" +
                            "\n - Skal indeholde minimum et special tegn" +
                            "\n - Må ikke indeholde nogen mellemrum" +
                            "\n - Skal indeholde minimum 12 tegn");

                Console.WriteLine("\nIndtast venligst et password");
                Console.Write("\nSkriv her: ");
                password = Console.ReadLine();

                Console.Clear();

                //Kalder metoden LoginL_Check.
                login = LClass3.LoginL_Check(bruger, filnavn, password);

                //Hvis login = true, informeres brugeren om at deres login er bekræftet.
                if (login == true)
                {
                    Console.WriteLine("Godkendt password");
                    Thread.Sleep(500);
                    Console.WriteLine("\nBruger1 oprettet");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                //Hvis login = false, informeres brugeren om at deres password ikke er gyldig da kravene ikke blev opfyldt.
                else
                {
                    Console.WriteLine("Ugyldigt password\nKrav ikke opfyldt");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
            }

            //Informere brugeren om at en brugere allerede findes, og derfor kan en ny bruger ikke oprettes.
            else
            {
                Console.WriteLine("En bruger findes i allerede\nNy bruger kan ikke oprettes");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        //Rediger password.
        public static void ChangePassword()
        {
            string bruger, password, nypassword, filnavn = @"C:\Users\MikFil\Desktop\Login.txt";
            bool login, passcheck, nypasscheck;

            //Beder brugeren om at indtaste deres login.
            Console.WriteLine("Indtast venligst dit brugernavn");
            Console.Write("\nSkriv her: ");
            bruger = Console.ReadLine();

            Console.WriteLine("\nIndtast venligst dit password for at ændre det.");
            Console.Write("\nSkriv her: ");
            password = Console.ReadLine();
            Console.Clear();

            //Kalder metoden LoginL_Check.
            login = LClass3.LoginL_Check(bruger, filnavn, password);

            //Informere brugeren at deres login er korrekt.
            if (login == true)
            {
                Console.Clear();
                Console.WriteLine("Brugernavn godkendt");
                Thread.Sleep(500);
                Console.WriteLine("\nPassword godkendt");
                Thread.Sleep(1000);
                Console.Clear();

                //Password krav.
                Console.WriteLine("Du kan nu ændre dit password");
                Console.WriteLine("\nDit nye password skal opfylde følgende krav:" +
                    "\n - Tal må ikke være i starten eller slutningen" +
                    "\n - Skal indeholde både store og små bogstaver" +
                    "\n - Brugernawn of Password må ikke være ens" +
                    "\n - Skal indeholde minimum et special tegn" +
                    "\n - Må ikke indeholde nogen mellemrum" +
                    "\n - Skal indeholde minimum 12 tegn");

                Console.Write("\nSkriv nyt password her: ");
                nypassword = Console.ReadLine();

                //Kalder metoden PasswordL_Capital.
                passcheck = LClass3.PasswordL_Capital(nypassword);

                //Kalder metoden PasswordL_NyCheck.
                nypasscheck = LClass3.PasswordL_NyCheck(password, nypassword);

                //Bruges kun hvis den bolske værdi fra både passcheck og nypasscheck = true.
                if (passcheck == true && nypasscheck == true)
                {
                    //Kalder metoden PasswordL_Overwrite.
                    LClass3.PasswordL_Overwrite(filnavn, password, nypassword);

                    Console.WriteLine("Dit password er nu ændret");
                    Thread.Sleep(1000);
                }

                //Informere brugeren at det nye password ikke overholder kravne.
                else
                {
                    Console.WriteLine("Dit nye password overholder ikke minimum krav");
                    Thread.Sleep(2000);
                }
            }

            //Informere brugeren at deres login ikke er korrekt.
            else
            {
                Console.WriteLine("Ugyldigt brugernavn eller password");
                Thread.Sleep(2000);
            }
        }
    }
}
