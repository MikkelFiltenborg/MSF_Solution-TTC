using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTC_ClassLibrary;

namespace TTC_ClassLibrary
{
    public class LClass3
    {
        ///MSF
        ///23-02-2022
        ///Oprettelse af gyldigt Password Logik

        //Checker om Passworded anvender mindst 12 tegn.
        public static bool PasswordL_Length(string password)
        {
            if (password.Length >= 12)
            {
                //Godkendt.
                return true;
            }

            else
            {
                //Ikke godkendt.
                return false;
            }
        }

        //Checker om Passworded anvender både store og små bogstaver.
        public static bool PasswordL_Capital(string password)
        {
            if (password.Equals(password.ToLower()) || password.Equals(password.ToUpper()))
            {
                //Ikke godkendt.
                return false;
            }
            else
            {
                //Godkendt.
                return true;
            }
        }

        //Checker om Passworded anvender mindst 1 specialtegn.
        public static bool PasswordL_Char(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]) == true)
                {
                    //Godkendt.
                    return true;
                }
            }
            //Ikke godkendt.
            return false;

        }

        //Checker om Passworded anvender tal i starten eller slutningen.
        public static bool PasswordL_Number(string password)
        {
            int i = password.Length;
            if (char.IsDigit(password[0]) || char.IsDigit(password[i - 1]) == true)
            {
                //Ikke godkendt.
                return false;
            }

            else
            {
                //Godkendt.
                return true;
            }
        }

        //Checker om Passworded anvender mellemrum.
        public static bool PasswordL_Space(string password)
        {
            if (password.Contains(" "))
            {
                //Ikke godkendt.
                return false;
            }

            else
            {
                //Godkendt.
                return true;
            }

        }

        //Checker om Passworded og Brugernavnet er ens, når bogstaver ikke er case sensitive.
        public static bool PasswordL_Compare(string password)
        {
            //Skal kalde brugernavn fra password.txt
            string bruger = "Bruger1";

            if (bruger.ToLower() != password.ToLower())
            {
                //Godkendt.
                return true;
            }

            else
            {
                //Ikke godkendt.
                return false;
            }
        }

        //Login check.
        public static bool PasswordL_Check(string password)
        {
            //Password krav kontrol.
            bool login = LClass3.PasswordL_Compare(password) &&
                LClass3.PasswordL_Capital(password) &&
                LClass3.PasswordL_Length(password) &&
                LClass3.PasswordL_Number(password) &&
                LClass3.PasswordL_Space(password) &&
                LClass3.PasswordL_Char(password);

            if (login == true)
            {
                //Godkendt.
                return true;
            }

            else
            {
                //Ikke godkendt.
                return false;
            }
        }

        //Password til Nypassword check.
        public static bool PasswordL_NyCheck(string password, string nypassword)
        {
            if (password.ToLower() != nypassword.ToLower())
            {
                //Godkendt.
                return true;
            }

            else
            {
                //Ikke godkendt.
                return false;
            }
        }

        //Login kontrol.
        public static bool LoginL_Check(string bruger, string filnavn, string password)
        {
            bool passwordcheck;

            //Checker password fil oprettelse og validitet.
            if (!File.Exists(filnavn))
            {
                //Password krav kontrol
                passwordcheck = LClass3.PasswordL_Check(password);

                if (passwordcheck == true)
                {
                    //Opretter og gemmer tekst i .txt fil.
                    using (StreamWriter writer = File.CreateText(filnavn))
                    {
                        writer.Write("Bruger1\n" + password);
                    }
                    //Godkendt.
                    return true;
                }

                else
                {
                    //Ikke godkendt.
                    return false;
                }
            }

            //Checker login validitet.
            else
            {
                //log = bruger (linjeskift) password, filinhold trukket fra .txt filen.
                string login = bruger + "\n" + password, filindhold = File.ReadAllText(filnavn);

                if (login == filindhold)
                {
                    //Godkendt.
                    return true;
                }

                else
                {
                    //Ikke godkendt.
                    return false;
                }
            }
        }

        //Password Overwrite.
        public static bool PasswordL_Overwrite (string filnavn, string password, string nypassword)
        {
            //Kalder PasswordL_NyCheck og gemmer den bolske værdi i nypasscheck.
            bool nypasscheck = LClass3.PasswordL_NyCheck(password, nypassword);

            //Bruges hvis nypasscheck = true.
            if (nypasscheck == true)
            {
                //Læser teksten fra filen og gemmer dem i indhold.
                string[] indhold = File.ReadAllLines(filnavn);

                //Gemmer det første ord fra indhold i bruger.
                string bruger = indhold[0];

                //Gemmer til filen Password.txt med bruger (linjeskift) nypassword.
                using (StreamWriter writer = File.CreateText(filnavn))
                {
                    writer.Write(bruger + "\n" + nypassword);
                }

                //Godkendt.
                return true;
            }

            //Bruges hvis nypasscheck = false.
            else
            {
                //Ikke godkendt.
                return false;
            }
        }
    }
}
