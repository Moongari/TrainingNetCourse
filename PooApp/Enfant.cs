using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApp
{
    public class Enfant : Etudiant
    {

        string classEcole = "";
        public Enfant(string nom, int age, string infoEtude = null, Personne professeur = null) : base(nom, age, infoEtude, professeur)
        {
            this.classEcole = infoEtude;
        }


        public override void Afficher()
        {

            this.AfficherNomEtAge();

            if (classEcole == null)
            {
                Console.WriteLine("  Aucun niveau d'etude spécifié");
            }
            else
            {
                Console.WriteLine("  en classe de  : " + classEcole);
            }

            this.PossedeUnProfesseurPrincipal();
        }
    }
}
