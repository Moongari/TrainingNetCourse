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
        private static String  alphabet = "abcdefghijklmnopqrstuvwxyz";
        private static int longueurMax = alphabet.Length;

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
        public static int DemanderNombreEntre(string question, int min, int max , int choix = 3)
        {
            int iMin = 5;
            int iMax = 10;
            int valeurSaisie = DemanderNombre(question);


            alphabet = WithCaracteresAndNumber(choix);
            alphabet = WithCaracteresAndNumberSpecialCaractere(choix);

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
            if (reponse.ToLower() == "oui")
            {
                isMajuscule = true;
                return true;
            }else
            {
                isMajuscule = false;
                return false;
            }
        }


        public static string WithCaracteresAndNumber(int choix)
        {
            if(choix == 1)
            {
                alphabet = alphabet + "0123456789";
                return alphabet;
            }

            return alphabet;
        }


        public static string WithCaracteresAndNumberSpecialCaractere(int choix)
        {
            if (choix == 3)
            {
                alphabet = alphabet + "0123456789" + "@&!#?";
                return alphabet;
            }

            return alphabet;
        }




        public static void generateurPassword(int longueur)
        {
            String chaineAleatoire = string.Empty;
            int longueurMax = alphabet.Length;
            Char[] myTabChar = alphabet.ToCharArray();

            HashSet<char> mychaine = new HashSet<char>();
            Random random = new Random();


          

            for (int i = 0; i < 10; i++)
            {

                while (mychaine.Count < longueur)
                {
                    int index = random.Next(0, longueurMax);
                    mychaine.Add(alphabet[index]);
                }



                foreach (var item in mychaine)
                {
                    if (isMajuscule)
                    {
                        chaineAleatoire += item;
                        chaineAleatoire = chaineAleatoire.ToUpper();
                    }
                    else
                    {
                        chaineAleatoire += item;
                    }


                }
                Console.WriteLine("PWD: " + chaineAleatoire);
                mychaine.Clear();

                chaineAleatoire = String.Empty;
            }
        }


    }
}
