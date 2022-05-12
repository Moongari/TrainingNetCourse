using System;

namespace GenerateurMotDePasse
{
    class Program
    {


        /// <summary>
        /// Function recursive qui permet egalement de boucler si le resultat ne correspond pas .
        /// </summary>
        /// <param name="question"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static int DemanderNombreEntre(string question, int min, int max)
        {
            int iMin = 5;
            int iMax = 10;
           
            int nombre = DemanderNombre(question);
            if (nombre >= iMin && nombre <= iMax)
            {
                return nombre;
            }
            else
            {
                Console.WriteLine($"Vous devez entrer une valeur comprise entre {iMin} et {iMax}");

            }

            return DemanderNombreEntre(question,min,max);


        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static int DemanderNombre(string question)
        {
            bool isLongeurValid = false;
            int longeurPwdMin = 5;
            int iLongueurPwd = 0;


            while (!isLongeurValid)
            {

                Console.WriteLine(question);
                Console.WriteLine();
                string longueurMotDePasse = Console.ReadLine();


                try
                {
                    iLongueurPwd = int.Parse(longueurMotDePasse);
                    //if (iLongueurPwd == 0 || iLongueurPwd <= longeurPwdMin)
                    //{
                    //    Console.WriteLine($"Mot de passe valide d'un minimum de {longeurPwdMin} caracteres");
                    //    isLongeurValid = false;
                    //}
                    //else
                    //{
                    //    Console.WriteLine($"Longueur Mot de passe valide de : {iLongueurPwd} caracteres");
                    //    isLongeurValid = true;
                    //}



                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur vous n'avez pas saisie une valeur correct, seul les chiffres sont valides");
                }


            }


            return 0;
        }


        static void Main(string[] args)
        {
            DemanderNombre("Indiquez la longueur du mot de passe souhaité :");
           
        }
    }
}
