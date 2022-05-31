using System;
using System.Collections.Generic;

namespace collectionApp
{
    internal class Program

    {
        /// <summary>
        /// affiche tableau
        /// </summary>
        /// <param name="t"></param>
        static void AfficherTableau (List<string> t)
        {


            foreach (var item in t)
            {
                Console.WriteLine($" nom = {item}");
            }


        }
        /// <summary>
        /// valeur maximale
        /// </summary>
        /// <param name="t"></param>
        static void ValeurMaximal(int[] t)
        {
            
             Array.Sort(t);
            int max = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if(t[i] > max)
                {
                    max = t[i];
                }
            }
            Console.WriteLine("valeur maximale : " + max);
            Console.WriteLine("valeur maximale : "+t[19]);


        }
        /// <summary>
        /// Valeur Minimal
        /// </summary>
        /// <param name="t"></param>
        static void ValeurMinimal(int[] t)
        {

            Array.Sort(t);
            int min = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = t[i];
                }
            }
            Console.WriteLine("valeur minimale : " + min);
            Console.WriteLine("valeur minimale : " + t[0]);


        }




        static void EntrezNom()
        {
            var noms = new List<string>();
            while (true)
            {
                Console.Write("Veuillez saisir un nom : ");
                string nom = Console.ReadLine();


                if(nom == "")
                {
                    break;
                }

                

                if (!noms.Contains(nom))
                {
                    noms.Add(nom);
                }
                else
                {
                    Console.WriteLine($"ce {nom} est deja contenu dans la liste");
                }


               

            }

            noms.Sort();

            AfficherTableau(noms);
        }






        static void Main(string[] args)
        {
            //const int TAILLE_TABLEAU = 20;
            //Random r = new Random();
            
            //int[] t = new int[TAILLE_TABLEAU];

            //for (int i = 0; i < t.Length; i++)
            //{
            //    t[i] = r.Next(0,100);
            //}

            //AfficherTableau(t);
            //Console.WriteLine();
            //ValeurMaximal(t);
            //ValeurMinimal(t);

            EntrezNom();


        }
    }
}
