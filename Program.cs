using System;

namespace MagiqueNumber
{
    class Program
    {


        static int nbrOfLife = 5;
        static int nbreMagique = 8;
        static bool isValidMagiqueNumber = false;


        static int DemanderNombre()
        {
            if (nbrOfLife == 5)
            {
                Console.Write($"========= NOMBRE MAGIQUE ========== ");
                Console.WriteLine();
                Console.Write($"========= Devinez le chiffre entre 0 et 10 ========== ");
            }
           

            int valeurSaisie = 0;


            while (valeurSaisie == 0 )
            {
               
                Console.WriteLine();
                Console.Write($"Hello, veuillez saisir un nombre :  ");

                string number = Console.ReadLine();

                try
                {
                    bool isValidNumber = int.TryParse(number, out valeurSaisie);

                    if (!isValidNumber)
                    {
                        Console.WriteLine("vous n'avez pas saisie un nombre");
                    }else if(valeurSaisie == 0 || valeurSaisie < 0)
                    {
                        Console.WriteLine("vous devez entrer un nombre superieur a 0 ");
                    }

                    //valeurSaisie = int.Parse(number);

                    Console.WriteLine($"Nombre saisie {valeurSaisie} ");

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


        static void Main(string[] args)
        {


            while (!isValidMagiqueNumber)
            {
                //DemanderNombre();
                DevinerleNombre(DemanderNombre());
            }
            

        }
    }
}
