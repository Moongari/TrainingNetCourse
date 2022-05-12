using System;

namespace MagiqueNumber
{
    class Program
    {


        static int nbrOfLife = 5;
        static int nbreMagique ;
        static bool isValidMagiqueNumber = false;


        static int DemanderNombre()
        {
            if (nbrOfLife == 5)
            {
                Console.Write($"========= NOMBRE MAGIQUE ========== ");
                Console.WriteLine();
                Console.Write($" Devinez le chiffre entre 0 et 10  ");
                Console.WriteLine();
                Console.Write($"= Vous avez {nbrOfLife} tentatives = ");
            }

            Random rnd = new Random();
            nbreMagique = rnd.Next(1, 10);


            int valeurSaisie = 0;


            while (valeurSaisie ==0)
            {
               
                Console.WriteLine();
                Console.Write($"Hello, veuillez saisir un nombre :  ");

                // recupere la valeur de l'utilisateur
                string number = Console.ReadLine();

                try
                {
                    bool isValidNumber = int.TryParse(number, out valeurSaisie);

                  

                    if (!isValidNumber)
                    {
                        Console.WriteLine("vous n'avez pas saisie un nombre");
                    }

                    // verification des saisies de l'utilisateur
                    VerifNbreSaisie(valeurSaisie);


                    Console.WriteLine($"Nombre saisie {VerifNbreSaisie(valeurSaisie)} ");

                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur :  Vous devez rentrer une valeur valide  ");
                }



            }

            return valeurSaisie;
        }

        static void DevinerleNombre(int number)
        {




            if (number == nbreMagique)
            {
                Console.WriteLine($"Bravo , vous avez deviner le nombre magique : {number}");
                isValidMagiqueNumber = true;
                
            }
            else
            {
                nbrOfLife--;
                Console.WriteLine($"Desolé, ce n'est pas le bon chiffre : {number} il vous reste : {nbrOfLife} tentative(s)");

                isValidMagiqueNumber = false;


            }


        }

        static int VerifNbreSaisie(int number)
        {
            if (number > 10)
            {
                Console.WriteLine($"votre chiffre ne doit pas depasser 10 => valeur saisie : {number}");
                return -1;
            }
            else if(number == 0 || number < 0)
            {
                Console.WriteLine("vous devez entrer un nombre superieur a 0 ");
                return -1;
            }

            return number;
        }

        static void Main(string[] args)
        {


            while (!isValidMagiqueNumber)
            {
                //DemanderNombre();
                DevinerleNombre(DemanderNombre());

                if (nbrOfLife == 0)
                {
                    Console.WriteLine($"Désolé , vous n'avez plus de tentative  : {nbrOfLife}");
                    Console.WriteLine($"Relancez le programme");
                    break;
                }

            }
            

        }
    }
}
