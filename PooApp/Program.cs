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

            var personne1 = new Personne("Albert", 30);
            personne1.Afficher();

            var personne2 = new Personne() { nom = "TOTO", age = 34, emploi = "Docteur" };
            // on ne peut pas car l'accesseur est definit comme init
            //personne2.nom = "Albert";
            personne2.Afficher();


        }
    }
}
