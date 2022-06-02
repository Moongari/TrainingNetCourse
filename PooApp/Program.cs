using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PooApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var personne1 = new Personne("Albert", 30);
            //personne1.Afficher();

            //var personne2 = new Personne() { nom = "TOTO", age = 34, emploi = "Docteur" };
            //// on ne peut pas car l'accesseur est definit comme init
            ////personne2.nom = "Albert";
            //personne2.Age = 30;
            //personne2.Afficher();



            //var etudiant1 = new Etudiant("Ronaldo", 23);
            //var etudiant2 = new Etudiant("Noor",43,"Eleve ingenieur" );
            //var etudiant3 = new Etudiant("Ahmed", 34, "eleve ingenieur");
            //etudiant3.professeurPrincipal = new Personne() { nom = "Abdellah", age = 45, emploi = "Professeur de Physique nucleaire" };
            //etudiant1.Afficher();
            //Console.WriteLine();
            //etudiant2.Afficher();
            //Console.WriteLine();
            //etudiant3.Afficher();

            Dictionary<string, float> notes = new Dictionary<string, float>() {
                { "Maths",5.5f},
                { "Geo", 3.5f },
                { "Histoire", 6.5f } ,
                { "SVT",8.7f},
                { "Sport",9f}
            };

            var enfant1 = new Personne("Sophie", 7,null);
            enfant1.Afficher();


        }
    }
}
