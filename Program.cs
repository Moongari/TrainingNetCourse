using System;

namespace MagiqueNumber
{
    class Program
    {


        static int nbrOfLife = 5;


        static int DemanderNombre()
        {

            int valeurSaisie = 0;


            while (valeurSaisie == 0 )
            {
                Console.Write($"========= NOMBRE MAGIQUE ========== ");
                Console.WriteLine();
                Console.Write($"Hello, veuillez saisir un nombre :  ");

                string number = Console.ReadLine();

                try
                {
                    bool isValidNumber = int.TryParse(number, out valeurSaisie);

                    if (!isValidNumber)
                    {
                        Console.WriteLine("vous n'avez pas saisie un nombre");
                    }

                    valeurSaisie = int.Parse(number);

                    Console.WriteLine($"Nombre saisie {valeurSaisie} ");

                }
                catch (Exception)
                {

                    Console.WriteLine("Erreur :  Vous devez rentrer une valeur différente de 0 ");
                }



            }

            return valeurSaisie;
        }




        static void Main(string[] args)
        {


            DemanderNombre();


        }
    }
}
