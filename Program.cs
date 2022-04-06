using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_framework_4_8.Models;

namespace Training_framework_4_8
{
    class Program
    {

       

        static void Main(string[] args)
        {



            

            var controleSalary = new ControleSalary();
            var job = new LevelJob();
            ControleSalary.personneHandler = job.accountByName;
            personneHandler += job.verifyYourAccount;
            personneHandler += AccountJobByPersonne;


            controleSalary.ProcessControl(personneHandler);


            Console.ReadLine();



        }


        static void AccountJobByPersonne(Personne per)
        {
            Console.WriteLine("Account Personne" + "Salary :" +per.salary +" - " + per.FirstName );
        }
    }
    
}
