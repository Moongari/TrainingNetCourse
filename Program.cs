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
            int longueurMax = alphabet.Length;
            
            
            String chaineAleatoire = string.Empty;

            Char[] myTabChar = alphabet.ToCharArray();

            HashSet<char> mychaine = new HashSet<char>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
               
                while (mychaine.Count < longueur)
                {
                    int index = random.Next(0, longueurMax);
                    mychaine.Add(alphabet[index]);
                }



                foreach (var item in mychaine)
                {
                    if (isMaj)
                    {
                        chaineAleatoire += item;
                        chaineAleatoire = chaineAleatoire.ToUpper();
                    }
                    else
                    {
                        chaineAleatoire += item;
                    }


                }
                Console.WriteLine("chaine: " + chaineAleatoire);
                mychaine.Clear();

                chaineAleatoire =String.Empty;
            }

            
            

            //Console.WriteLine("chaine: " + chaineAleatoire+ "-");

            //int valeurSaisie = Outils.DemanderNombre(question);


            //int interValValeur = Outils.DemanderNombreEntre(question, valeurSaisie,valeurSaisie);

            //Console.WriteLine($"la valeur saisi est  :  {interValValeur}");



        }
    }
}
