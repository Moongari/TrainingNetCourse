using System;
using System.Collections.Generic;

namespace GenerateurPhrasesAleatoire
{
    internal class Program


    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        static string ObtenirElementAleatoir(string[] t)
        {
            Random rnd = new Random();
            int aleatoire = rnd.Next(0, t.Length);

            return t[aleatoire];
        }


        static void Main(string[] args)
        {
            // sujet verbe complement

            var sujets = new string[] { "un lapin", "une grand-mere", "un chat", "un ours", "un cheval" ,"Henri IV","le gardien"};

            var verbes = new string[] { "mange", "dort", "tue", "se bat avec", "s'accroche à", "néttoie", "regarde" };

            var complements = new string[] { "un arbre", "un livre", "le soleil", "une piscine", "avec une souris", " une poule", "avec une girafe", "avec un serpent" };

            var listphrase = new List<String>();

            const int NB_PHRASES = 100;
            int iDoublons = 0;
            while(NB_PHRASES <= 100)
            {

            
                var sujet = ObtenirElementAleatoir(sujets);
                var verbe = ObtenirElementAleatoir(verbes);
                var complement = ObtenirElementAleatoir(complements);
                var phrase = sujet + " " + verbe + " " + complement;
                phrase = phrase.Replace("avec ", "sur ");

                if (!listphrase.Contains(phrase))
                {
                    listphrase.Add(phrase);
                }
                else
                {
                    iDoublons++;    
                }

                if (NB_PHRASES.Equals(listphrase.Count))
                {
                    break;
                }

            }


            int count = 0;
            foreach (var ph in listphrase)
            {

                Console.WriteLine($"PHASE ={count}  :  {ph}");
                count++;
            }

            Console.WriteLine($"Doublons eviter : {iDoublons}" );
        }

    }
    
}
