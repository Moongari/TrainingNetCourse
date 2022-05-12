using System;

namespace GenerateurMotDePasse
{
    class Program
    {

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
                    if (iLongueurPwd == 0 || iLongueurPwd<=longeurPwdMin)
                    {
                        Console.WriteLine($"Mot de passe valide d'un minimum de {longeurPwdMin} caracteres");
                        isLongeurValid = false;
                    }
                    else
                    {
                        Console.WriteLine($"Longueur Mot de passe valide de : {iLongueurPwd} caracteres");
                        isLongeurValid = true;
                    }
                  


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
