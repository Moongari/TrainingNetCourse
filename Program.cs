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

            String question2 = "Voulez vous un mot de passe avec:\n" +
                "1- Uniquement des caracteres en minuscules \n" +
                "2- Uniquement des caracteres en Majuscules \n" +
                "3- Des caracteres et des chiffres \n" +
                "4- Des caracteres ,chifffres, et caracteres spéciaux ";

          
          

            Outils.generateurPassword(longueur);
         

            
            

            //Console.WriteLine("chaine: " + chaineAleatoire+ "-");

            //int valeurSaisie = Outils.DemanderNombre(question);


            //int interValValeur = Outils.DemanderNombreEntre(question, valeurSaisie,valeurSaisie);

            //Console.WriteLine($"la valeur saisi est  :  {interValValeur}");



        }
    }
}
