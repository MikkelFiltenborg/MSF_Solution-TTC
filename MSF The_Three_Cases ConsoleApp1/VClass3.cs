using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MSF_The_Three_Cases_ConsoleApp1
{
    public class VClass3
    {
        ///MSF
        ///xx-02-2022
        ///Oprettelse af gyldigt Password Visuel

        public static void PasswordV()
        {
            string Brugernavn = "", Password = "", Valg = "";

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
                Valg = Console.ReadLine();

                Console.Clear();

                switch (Valg)
                {
                    //Login.
                    case "1":
                        Console.WriteLine("Indtast venligst dit brugernavn\nSkriv her: ");
                        Brugernavn = Console.ReadLine();

                        Console.WriteLine("Indtast venligst dit password\nSkriv her: ");
                        Password = Console.ReadLine();

                        if ()
                        {
                            Console.WriteLine();
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.ReadKey();
                        }

                        break;

                    //Opret password.
                    case "2":

                        break;

                    //Rediger Password.
                    case "3":

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
            } while (Valg != "0");
        }
    }
}
