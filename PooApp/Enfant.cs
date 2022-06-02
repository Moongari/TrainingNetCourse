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
        Dictionary<String,float> notes = new Dictionary<String,float>();
        public Enfant(string nom, int age, Dictionary<String, float> notes,string infoEtude = null, Personne professeur = null) : base(nom, age, infoEtude, professeur)
        {
            this.classEcole = infoEtude;
            this.notes = notes;
        }


        new public  void Afficher()
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

            foreach (var item in notes)
            {
                Console.WriteLine($" Cours de {item.Key} - note :{item.Value}/10");
            }

            var MatiereMoyenA = notes.Where(x => (x.Value >5) && (x.Key.StartsWith("M")))
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key).ToList();

            Console.WriteLine("tu as la moyen dans les matieres suivantes ");
            Console.WriteLine("===================================");
            foreach (var item in MatiereMoyenA)
            {
            
            
                Console.WriteLine($"            { item }    ");
             
            }
            Console.WriteLine("===================================");
        }
    }
}
