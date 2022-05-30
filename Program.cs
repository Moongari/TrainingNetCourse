using GenerarteurMotDePasse;
using System;
using static GenerarteurMotDePasse.Outils;

namespace GenerateurMotDePasse
{
    class Program
    {
       


        static void Main(string[] args)
        {
            String question = "Indiquez la longueur du mot de passe souhaité :";

            int valeurSaisie = Outils.DemanderNombre(question);
          

            int interValValeur = Outils.DemanderNombreEntre(question, valeurSaisie,valeurSaisie);

            Console.WriteLine($"la valeur saisi est  :  {interValValeur}");
            
            
           
        }
    }
}
