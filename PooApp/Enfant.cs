using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApp
{
    public class Enfant : Etudiant
    {
        public Enfant(string nom, int age, string infoEtude = null, Personne professeur = null) : base(nom, age, infoEtude, professeur)
        {
        }


        public override void Afficher()
        {
            base.Afficher();
        }
    }
}
