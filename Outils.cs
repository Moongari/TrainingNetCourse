using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarteurMotDePasse
{
     static class Outils
    {


        public static bool isMajuscule { get; set; }

        /// <summary>
        /// Verification sur la valeur saisi n'est pas 0 ou null
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static int? DemanderNombrePositifNotNull(String question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }



        /// <summary>
        /// Function recursive qui permet egalement de boucler si le resultat ne correspond pas .
        /// </summary>
        /// <param name="question"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int DemanderNombreEntre(string question, int min, int max)
        {
            int iMin = 5;
            int iMax = 10;
            int valeurSaisie = DemanderNombre(question);



            if (valeurSaisie >= iMin && valeurSaisie <= iMax)
            {

                return valeurSaisie;
            }

            Console.WriteLine($"Vous devez entrer une valeur comprise entre {iMin} et {iMax}");
            return DemanderNombreEntre(question, min, max);


        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static int DemanderNombre(string question)
        {
         

            int iLongueurPwd = 0;


            while (true)
            {

                Console.WriteLine(question);
                Console.WriteLine();
                string longueurMotDePasse = Console.ReadLine();


                try
                {
                    WithMajuscule();
                    iLongueurPwd = int.Parse(longueurMotDePasse);



                    return iLongueurPwd;
                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur vous n'avez pas saisie une valeur correct, seul les chiffres sont valides");
                }


            }



        }



        public static bool WithMajuscule()
        {
            Console.WriteLine("Voulez vous integrer des majuscules OUI/NON");
            
            String reponse = Console.ReadLine();
            if (reponse == "OUI")
            {
                isMajuscule = true;
                return true;
            }else
            {
                isMajuscule = false;
                return false;
            }
        }


    }
}
