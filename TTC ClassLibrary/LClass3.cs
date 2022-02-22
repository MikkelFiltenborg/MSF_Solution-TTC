using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTC_ClassLibrary
{
    public class LClass3
    {
        ///MSF
        ///xx-02-2022
        ///Oprettelse af gyldigt Password Logik
        
        //Checker om Passworded anvender mindst 12 tegn.
        public static bool PasswordL_Length(string Password)
        {
            if(Password.Length >= 12)
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
        public static bool PasswordL_Capital(string Password)
        {
            if (Password.Equals(Password.ToLower()) || Password.Equals(Password.ToUpper()))
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
        public static bool PasswordL_Char(string Password)
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (!char.IsLetterOrDigit(Password[i]) == true)
                {
                    //Godkendt.
                    return true;
                }
            }
            //Ikke godkendt.
            return false;

        }

        //Checker om Passworded anvender tal i starten eller slutningen.
        public static bool PasswordL_Number(string Password)
        {
            int i = Password.Length;
            if (char.IsDigit(Password[0]) ||char.IsDigit(Password[i - 1]) == true)
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
        public static bool PasswordL_Space(string Password)
        {
            if (Password.Contains(" "))
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
        public static bool PasswordL_Compare(string Brugernavn, string Password)
        {

            if(Brugernavn.ToLower() != Password.ToLower())
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
}
