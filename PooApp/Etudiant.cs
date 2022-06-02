using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApp
{
    public  class Etudiant : Personne
    {

        public string infoEtudes { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public int Id { get; set; }
        int numeroPersonne=0,idEtudiant;


        public Etudiant()
        {
            idEtudiant++;
            numeroPersonne = idEtudiant;
        }

        public Etudiant(string nom, int age, string infoEtude = null) : this()
        {
            this.nom = nom;
            this.age = age;
            this.infoEtudes = infoEtude;
        }


     



        public  override void Afficher()
        {

            AfficherNomEtAge();

            if (infoEtudes == null)
            {
                Console.WriteLine("  Aucun niveau d'etude spécifié");
            }
            else
            {
                Console.WriteLine("  niveau Etude : " + infoEtudes);
            }
        }

    }
}
