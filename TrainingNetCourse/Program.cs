using System;
using System.Text.RegularExpressions;
using Training_framework_4_8.Models;

namespace premier_programme
{
    class Program
    {


        static string regex = "\\D";
        static bool isInvalidNom = false;



        static int DemanderAge(string nom)
        {
            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write("votre nom est : " + nom + " Quel est  l' age de la personne  ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être négatif");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur: L'age ne doit pas être égal à 0");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur :  Vous devez rentrer un age valide.");
                }
            }
            return age_num;
        }



        static bool isValidName(string nom)
        {

            bool match = Regex.IsMatch(nom, regex);

            if (!match)
            {

                Console.WriteLine("Vous ne pouvez pas saisir de nombre");
                isInvalidNom = true;

            }
            else
            {
                isInvalidNom = false;
            }

            return isInvalidNom;
        }



        static string DemanderNom(int idPersonne)
        {
            // DEMANDE LE NOM


            string nom = "";

            while (nom == "" || isInvalidNom)
            {
                Console.Write("quel est le nom  de la personne " + idPersonne + "?");
                //Console.Write("Quel est votre nom ? ");

                nom = Console.ReadLine();
                nom = nom.Trim();


                // controle si le nom entré n'est pas un chiffre
                isValidName(nom);



                if (nom == "")
                {
                    Console.WriteLine("Erreur: le nom ne doit pas être vide");

                }


            }

            return nom;


        }



        static bool isPersonneMajor(int age)
        {
            bool isMajor = false;

            return age >= 18 ? isMajor = true : isMajor = false;
        }


        // definition d'un parametre optionnel taille
        static void AfficherResultat(string nom, int age,float taille =0)
        {
            Console.WriteLine();
            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans");
            Console.WriteLine("bientôt vous aurez " + (age + 1) + " ans");

            if(isPersonneMajor(age)) { Console.WriteLine(nom + " vous etes majeur : " + age); } else { Console.WriteLine(nom + " vous etes mineur : " + age); }

            if (taille > 0)
            {
                Console.WriteLine(nom + "vous mesurez " + taille + "m de hauteur.");
            }
    
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            // DEMANDE le nom
            string nom = DemanderNom(1);
            string nom2 = DemanderNom(2);


            // DEMANDE L'AGE


            int age = DemanderAge(nom);
            int age2 = DemanderAge(nom2);

            // AFFICHE LES RESULTATS


            AfficherResultat(nom, age,1.8f);
            AfficherResultat(nom2, age2);


          

        }
    }
}
