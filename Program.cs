using GenerarteurMotDePasse;
using System;
using System.Collections.Generic;
using static GenerarteurMotDePasse.Outils;

namespace GenerateurMotDePasse
{
    class Program
    {
       


        static void Main(string[] args)
        {
            String question = "Indiquez la longueur du mot de passe souhaité :";
            int longueur = (int)Outils.DemanderNombrePositifNotNull(question);
            bool isMaj = Outils.isMajuscule;

            String alphabet = "abcdefghijklmnopqrstuvwxyz1234567890";

            Outils.generateurPassword(longueur);
         

            
            

            //Console.WriteLine("chaine: " + chaineAleatoire+ "-");

            //int valeurSaisie = Outils.DemanderNombre(question);


            //int interValValeur = Outils.DemanderNombreEntre(question, valeurSaisie,valeurSaisie);

            //Console.WriteLine($"la valeur saisi est  :  {interValValeur}");



        }
    }
}
