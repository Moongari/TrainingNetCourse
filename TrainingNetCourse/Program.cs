using System;
using Training_framework_4_8.Models;

namespace premier_programme
{
    class Program
    {


     
        static int DemanderAge()
        {
            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write("Quel est ton age ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être négatif");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur: L'age ne doit pas être égal à 0");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur :  Vous devez rentrer un age valide.");
                }
            }
            return age_num;
        }



        static string DemanderNom()
        {
            // DEMANDE LE NOM
            string nom = "";
            while (nom == "")
            {
                Console.Write("Quel est votre nom ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    Console.WriteLine("Erreur: le nom ne doit pas être vide");
                }
            }

            return nom;


        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            // DEMANDE le nom
            string nom = DemanderNom();

            // DEMANDE L'AGE


            int age = DemanderAge();

            // AFFICHE LES RESULTATS
            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans");

            int age_prochain = age + 1;
            Console.WriteLine("bientôt vous aurez " + age_prochain + " ans");
            Console.WriteLine("test");



        //    var controleSalary = new ControleSalary();
        //    var job = new LevelJob();

        //    Action<Personne> personneHandler = job.accountByName;
        //    personneHandler += job.verifyYourAccount;
        //    personneHandler += AccountJobByPersonne;


        //    controleSalary.ProcessControl(personneHandler);


        //    Console.ReadLine();

        //}


        //static void AccountJobByPersonne(Personne per)
        //{
        //    Console.WriteLine("Account Personne" + "Salary :" + per.salary + " - " + per.FirstName);
        //}


    }
    }
}
