using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApp
{
    public class Personne
    {
        static int nombreDePersonnes = 0;


        //il est possible grace a C#9 d'initialiser une valeur au moment de la construction de l'objet
        //mais il n'est pas possible de la setter par la suite.
        public string nom { get; set; }
        public int age { get; set; }
        public string emploi { get; set; }
        int numeroPersonne;


        public int Age
        {
            get { return age; }

            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }

        }

        public Personne()
        {
            nombreDePersonnes++;
            this.numeroPersonne = nombreDePersonnes;
        }



        /// <summary>
        /// appel d'un second constructeur avec le mots this
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="age"></param>
        public Personne(String nom, int age) : this(nom, age, "(non definit)")
        {

        }

        /// <summary>
        /// appel du constructeur par defaut
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="age"></param>
        /// <param name="emploi"></param>
        public Personne(string nom, int age, string emploi = null) : this()
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;

            nombreDePersonnes++;

            this.numeroPersonne = nombreDePersonnes;
        }

        public  void Afficher()
        {

            AfficherNomEtAge();

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


        protected  void AfficherNomEtAge()
        {
            Console.WriteLine("PERSONNE N°" + numeroPersonne);
            Console.WriteLine("  NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
        }

    }
}
