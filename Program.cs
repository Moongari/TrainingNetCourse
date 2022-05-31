using System;

namespace collectionApp
{
    internal class Program

    {

        static void AfficherTableau (int[] t)
        {
          

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }


        }

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

        static void Main(string[] args)
        {
            const int TAILLE_TABLEAU = 20;
            Random r = new Random();
            
            int[] t = new int[TAILLE_TABLEAU];

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(0,100);
            }

            AfficherTableau(t);
            Console.WriteLine();
            ValeurMaximal(t);
            ValeurMinimal(t);



        }
    }
}
