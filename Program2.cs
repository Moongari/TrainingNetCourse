using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateurPhrasesAleatoire
{

    /// <summary>
    /// JEU DU PENDU 
    /// </summary>
    internal class Program2
    {

        static void AfficherMot(string mot,List<char> lettre)
        {
            
            int nbrOfLetters = mot.Length;
            string underscore = "_ ";
            Char[] charMot = new Char[nbrOfLetters];
            charMot = mot.ToCharArray(0, nbrOfLetters);

            for (int i = 0; i < charMot.Length; i++)
            {
                if(lettre.Contains(charMot[i]))
                {
                    
                    Console.Write(" " + charMot[i] + " ");
                }
                else
                {
                    Console.Write(" " + underscore + " ");
                }
            }
         

            //for (int i = 0; i < nbrOfLetters; i++)
            //{
            //    Console.Write(" " + underscore +" ");
            //}
            Console.WriteLine("");

        }

        static void DevinerMot(string mot)
        {
           // AfficherMot(mot);
        }


        static char DemanderUneLettre()
        {
            String lettre=String.Empty;
            char resulLettre = new char();
            while (true)

            {
                Console.WriteLine("VEUILLEZ ENTRE UNE LETTRE ");
                lettre = Console.ReadLine();
                lettre = lettre.Trim().ToUpper();

                if (lettre.Length > 1)
                {
                    Console.WriteLine("Vous ne pouvez saisir qu'une seule lettre !!");
                }
                else
                {
                    resulLettre = lettre[0];
                    break;
                }

                
            }
            

            return resulLettre;

        }


        static void Main(String[] args)
        {
            string mot = "CHIEN";

            //DevinerMot(mot);
            DemanderUneLettre();
            //AfficherMot(mot,new List<char> {'E','I','N'});
        }
    }
}
