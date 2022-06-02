﻿using System;
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
        public int AgeEtudiant { get; set; }
        public int Id { get; set; }
        int numeroPersonne=0,idEtudiant;

        public Personne professeurPrincipal { get; set; }


        

        public Etudiant(string nom, int age, string infoEtude = null, Personne professeur = null) : base(nom,age,"Etudiant")
        {
            idEtudiant++;
            numeroPersonne = idEtudiant;
            this.nom = nom;
            this.AgeEtudiant = age;
            this.infoEtudes = infoEtude;
            this.professeurPrincipal = professeur;
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

            if(professeurPrincipal != null)
            {
                professeurPrincipal.Afficher();
            }
            else
            {
                Console.WriteLine("  vous n'avez pas de professeur principal");
            }
        }

    }
}
