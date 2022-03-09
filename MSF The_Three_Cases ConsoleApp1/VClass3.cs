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
            string bruger, password, filnavn = @"C:\Users\MikFil\Desktop\Password.txt";
            bool login;

            Console.WriteLine("Indtast venligst dit brugernavn");
            Console.Write("\nSkriv her: ");
            bruger = Console.ReadLine();

            Console.WriteLine("\nIndtast venligst dit password");
            Console.Write("\nSkriv her: ");
            password = Console.ReadLine();

            login = LClass3.LoginL_Check(bruger, filnavn, password);

            Console.Clear();

            if (login == true)
            {

                Console.WriteLine("Brugernavn Godkendt\n");
                Thread.Sleep(500);
                Console.WriteLine("Password godkendt");
                Thread.Sleep(1000);
                Console.Clear();
                return true;
            }

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
            string bruger = "", password, filnavn = @"C:\Users\MikFil\Desktop\Password.txt";
            bool login;

            if (!File.Exists(filnavn))
            {
                Console.WriteLine("Brugernavnet [ Bruguer1 ] er oprettet.\n");

                Console.WriteLine("Dit nye password skal opfylde følgende krav:\n" +
                            " - Tal må ikke være i starten eller slutningen\n" +
                            " - Skal indeholde både store og små bogstaver\n" +
                            " - Brugernawn of Password må ikke være ens\n" +
                            " - Skal indeholde minimum et special tegn\n" +
                            " - Må ikke indeholde nogen mellemrum\n" +
                            " - Skal indeholde minimum 12 tegn\n");

                Console.WriteLine("Indtast venligst et password");
                Console.Write("\nSkriv her: ");
                password = Console.ReadLine();
                Console.Clear();

                login = LClass3.LoginL_Check(bruger, filnavn, password);

                if (login == true)
                {
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
                    Console.Clear();
                }
            }

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
            string bruger, password, nypassword, filnavn = @"C:\Users\MikFil\Desktop\Password.txt";
            bool login, passcheck, nypasscheck;

            Console.WriteLine("Indtast venligst dit brugernavn");
            Console.Write("\nSkriv her: ");
            bruger = Console.ReadLine();

            Console.WriteLine("\nIndtast venligst dit password for at ændre det.");
            Console.Write("\nSkriv her: ");
            password = Console.ReadLine();
            Console.Clear();

            login = LClass3.LoginL_Check(bruger, filnavn, password);

            if (login == true)
            {
                Console.Clear();
                Console.WriteLine("Brugernavn Godkendt\n");
                Thread.Sleep(500);
                Console.WriteLine("Password godkendt");
                Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine("Du kan nu ændre dit password");
                Console.WriteLine("\nDit nye password skal opfylde følgende krav:" +
                    " - \nTal må ikke være i starten eller slutningen" +
                    " - \nSkal indeholde både store og små bogstaver" +
                    " - \nBrugernawn of Password må ikke være ens" +
                    " - \nSkal indeholde minimum et special tegn" +
                    " - \nMå ikke indeholde nogen mellemrum" +
                    " - \nSkal indeholde minimum 12 tegn");

                Console.Write("\nSkriv nyt password her: ");
                nypassword = Console.ReadLine();

                passcheck = LClass3.PasswordL_Capital(nypassword);

                nypasscheck = LClass3.PasswordL_NyCheck(password, nypassword);

                if (passcheck == true && nypasscheck == true)
                {
                    //overwrite previous password.
                    LClass3.PasswordL_Overwrite(filnavn, password, nypassword);

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
                Console.WriteLine("Ugyldigt brugernavn eller password");
                Thread.Sleep(2000);
            }
        }
    }
}
