using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTC_ClassLibrary
{
    public class LClass1
    {
        ///MSF
        ///11-02-2022
        ///Fodbold - fan support på lægterne Logik

        public static string FodboldL(string Målcheck, int Afleveringer)
        {
            //Finder ud af hvad brugeren har indtastet og giver et passende respons.
            if (Målcheck != "mål")
            {
                //Checker om der er mindre end 1 aflevering.
                if (Afleveringer < 1)
                {
                    return ("shh");
                }

                //Checker om der er 1 eller mere og mindre end 10 afleveringer.
                else if (Afleveringer >= 1 && Afleveringer < 10)
                {
                    string Huh = "";

                    //Gentager udskriften Huh! ind til i har samme numeriske værdi som afleveringer.
                    for (int i = 0; i < Afleveringer; i++)
                    {
                        Huh = Huh + "Huh! ";
                    }
                    return Huh;
                }

                //Checker om der er 10 eller flere afleveringer.
                else if (Afleveringer >= 10)
                {
                    return("High Five - Jubel!!!");
                }

                //Informere brugeren at det indtastede input er ugyldigt og fortæller, at de kan retunere til selektionen ved et tastetryk.
                else
                {
                    return ("Ugyldig Input \n Tryk på en tast for at komme tilbage til selektionen");
                }
            }

            //Udskriver sætningen Olé Olé Olé hvis brugeren indtaster ordet mål.
            else if (Målcheck == "mål")
            {
                return("Olé Olé Olé");
            }

            //Informere brugeren at det indtastede input er ugyldigt og fortæller, at de kan retunere til selektionen ved et tastetryk.
            else
            {
                return("Ugyldig Input \n Tryk på en tast for at komme tilbage til selektionen");
            }
        }
    }
}
