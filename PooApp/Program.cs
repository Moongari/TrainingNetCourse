using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PooApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine($"========LINQ TO Object============");
            var listEtudiant = new List<Etudiant>();
            listEtudiant.Add(new Etudiant() { Name = "Billy", Age = 34, Id = 1 });
            listEtudiant.Add(new Etudiant() { Name = "Arnold", Age = 45, Id = 2 });
            listEtudiant.Add(new Etudiant() { Name = "Albert", Age = 12, Id = 3 });
            listEtudiant.Add(new Etudiant() { Name = "Suzy", Age = 23, Id = 4 });
            listEtudiant.Add(new Etudiant() { Name = "Karine", Age = 46, Id = 5 });
            listEtudiant.Add(new Etudiant() { Name = "Ahmed", Age = 45, Id = 6 });

            IEnumerable<Etudiant> EtudiantMajeur = from person in listEtudiant
                                                   where(person.Age > 18)
                                                   orderby person.Name ascending
                                                   select person;


            IEnumerable<Etudiant> EtudiantCommenceParA = from person in listEtudiant
                                                   where (person.Name.StartsWith("A"))
                                                   orderby person.Name ascending
                                                   select person;

            IEnumerable<Etudiant> EtudiantAgeComprisEntre = from person in listEtudiant
                                                         where (person.Age >30 && person.Age<=45)
                                                         orderby person.Name ascending
                                                         select person;


            var listEtudiantAgeSup30EtInf45 = listEtudiant.Where(e => e.Age >30 && e.Age<=45)
                .OrderByDescending(e => e.Age).ToList();


            



            foreach (var item in EtudiantMajeur)
            {
                Console.WriteLine($"les etudiants majeurs sont : {item.Name} :  {item.Id}");
            }

            Console.WriteLine();

            foreach (var item in EtudiantCommenceParA)
            {
                Console.WriteLine($"les etudiants dont le prenom commence par A : {item.Name} :  {item.Id}");
            }


            Console.WriteLine();
            foreach (var item in listEtudiantAgeSup30EtInf45)
            {
                Console.WriteLine($"les etudiants age compris entre [30 et 45]: {item.Name} , AGE:  {item.Age}");
            }

            Console.WriteLine($"========LINQ TO XML============");

            // lecture d'une fichier XML avec Linq
            XElement xmldoc = XElement.Load("C:\\Users\\moungamo\\source\\repos\\PooApp\\PooApp\\contact.xml");
            IEnumerable<XElement> contacts = xmldoc.Elements("contact");

            var req1 = from c in contacts
                       where Int32.Parse(c.Element("age").Value)>40
                       orderby c.Attribute("id").Value ascending
                       select c;

            foreach (var item in req1)
            {
                Console.WriteLine($"ID {item.Attribute("id").Value}");
                Console.WriteLine($"nom {item.Element("nom").Value}");
                Console.WriteLine($"Age {item.Element("age").Value}");
            }


        }
    }
}
