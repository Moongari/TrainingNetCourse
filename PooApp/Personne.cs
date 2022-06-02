using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApp
{
    class Personne
    {
        static int nombreDePersonnes = 0;

        public string nom;
        int age;
        string emploi;
        int numeroPersonne;








        /// <summary>
        /// appel d'un second constructeur avec le mots this
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="age"></param>
        public Personne(String nom, int age) : this(nom,age, "(non definit)") 
        { 
        
        }

        public Personne(string nom, int age, string emploi = null)
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;

            nombreDePersonnes++;

            this.numeroPersonne = nombreDePersonnes;
        }

        public void Afficher()
        {
            Console.WriteLine("PERSONNE N°" + numeroPersonne);
            Console.WriteLine("  NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
            if (emploi == null)
            {
                Console.WriteLine("  Aucun emploi spécifié");
            }
            else
            {
                Console.WriteLine("  EMPLOI : " + emploi);
            }
        }

        public static void AfficherNombreDePersonnes()
        {
            Console.WriteLine("Nombre total de personnes : " + nombreDePersonnes);
        }


        }
    }
