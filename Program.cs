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
        static void AfficherTableau (List<string> t, bool ordreDescendant = false)
        {

            int maxNom = 0;
            string nom =string.Empty;
            if (!ordreDescendant)
            {
                foreach (var item in t)
                {
                    Console.WriteLine($" nom = {item}");
                    if(item.Length > maxNom) 
                    { 
                        maxNom = item.Length;
                        nom = item;
                    }


                }
                Console.WriteLine($"le nom le plus grand est {maxNom} : {nom}");
            }
            else
            {
                t.Reverse ();

                foreach (var item in t)
                {
                    Console.WriteLine($" nom = {item}");
                }
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

            //noms.Sort();
            var elementSupprimer = new List<string>();
            foreach (var item in noms)
            {
                if (item.EndsWith("a"))
                {
                    elementSupprimer.Add(item);
                }
            }

            foreach (var item in elementSupprimer)
            {
                noms.Remove(item);
            }



            AfficherTableau(noms);
        }


        /// <summary>
        /// Compare 2 listes
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        static void ComparaList(List<string> l1, List<string> l2)
        {
            string identique = "";
            for (int i = 0; i < l1.Count; i++)

            {

                identique = l1[i];

                for (int j = 0; j < l2.Count; j++)
                {
                    if(l2[j].Contains( identique))
                    {
                        identique = l2[j];
                        Console.WriteLine($"{identique}");
                        break;
                    }
                }

           

            }
           

        }


        /// <summary>
        /// Methode Recherche personne
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="nom"></param>
        static void RecherchePersonne(Dictionary<String, String> dic,string nom)
        {
            if (dic.ContainsKey(nom))
            {
                Console.WriteLine(dic[nom]);
            }
            else
            {
                Console.WriteLine($"la personne {nom} n'existe pas");
            }
        }

        /// <summary>
        /// Dictionnaire
        /// </summary>
        static void Dictionnaire()
        {
            var d = new Dictionary<string, string>();
            d.Add("Jean", "0645894578");
            d.Add("Paul", "0645894578");
            d.Add("Marie", "0645897878");
            d.Add("Albert", "0645889578");

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}- {item.Value}");
            }

            RecherchePersonne(d, "David");
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

            //EntrezNom();
            //var list1 = new List<string>() { "EleveCE1","Paul", "Pierre", "Jean", "Raymond","Albert","Riri" };
            //var list2 = new List<string>() { "EleveCE2","Paul", "Pierre", "Davido", "Jean","Albert" };
            //var list3 = new List<string>() { "EleveCM1", "Mohammed", "Yassine", "Sarah", "Ines", "Robbert" };

            //var eleves = new List<List<String>>();
            //eleves.Add(list1);
            //eleves.Add(list2);
            //eleves.Add(list3);

            //for (int i = 0; i < eleves.Count; i++)
            //{
            //    // parcour la liste en recuperant le premier element
            //    var eleve = eleves[i];
            //    Console.WriteLine($"{eleve[0]} - {eleve.Count} eleves");

            //    // on parcours de nouveau la liste eleve en partant de l'element a partir de l'indice 1 pour obtenir les eleves
            //    for (int j = 1; j < eleve.Count; j++)
            //    {
            //        Console.WriteLine($" Nom de l'eleve : {eleve[j]}");
            //    }
            //}
            // ComparaList(list1, list2);
            Dictionnaire();


        }
    }
}
