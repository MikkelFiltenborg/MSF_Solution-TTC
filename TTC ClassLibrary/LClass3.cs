using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTC_ClassLibrary;

namespace TTC_ClassLibrary
{
    public class LClass3
    {
        ///MSF
        ///xx-02-2022
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
        public static bool PasswordL_Compare(string brugernavn, string password)
        {

            if (brugernavn.ToLower() != password.ToLower())
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
        public static bool PasswordL_Login(string password, string brugernavn)
        {
            bool login = LClass3.PasswordL_Compare(brugernavn, password) &&
                LClass3.PasswordL_Capital(password) &&
                LClass3.PasswordL_Length(password) &&
                LClass3.PasswordL_Number(password) &&
                LClass3.PasswordL_Space(password) &&
                LClass3.PasswordL_Char(password);

            if(login == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public static bool BrugernavnL_Check(string brugernavn)
        {
            string data = "";

            if (brugernavn == data) 
            {
                return true;
            }
            
            else
            {
                return false;
            }
        }
    }
}
