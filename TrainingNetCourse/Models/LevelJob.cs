using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_framework_4_8.Models
{
    class LevelJob
    {

        private readonly double maxLevel = 100000.00;

        private double[] plageOfAccount = { 345.00,2893.32,2330.78,6772,4500,4522,1234,4628};

        Dictionary<double,string> accountList = new Dictionary<double, string>();


        public double getMaxLevel { get { return maxLevel; }  }


        public void accountByName(Personne personne)
        {
            if (personne.salary < maxLevel)
            {
                accountList.Add(personne.salary, personne.FirstName);
                Console.WriteLine(  personne.FirstName + " added  correctly");
            }
            else
            {
                Console.WriteLine("Your account is very important Mr or Mrs" + personne.FirstName);
            }
           
        }



        public void verifyYourAccount(Personne personne)
        {
            Double situation = 0;

            Array.Sort(plageOfAccount);

            foreach(double acc in this.plageOfAccount)
            {

                situation = personne.salary > acc ? personne.salary : acc;

                if (situation > personne.salary) { break; }


                situation = personne.salary < acc ? acc: personne.salary;




            }

            if (situation > personne.salary)
            {
                Console.WriteLine(" situation  is  better than : " + situation + " your salary is " + personne.salary);
            }
            else
            {
                Console.WriteLine(" your salary  is  better than : " + situation + " your salary is " + personne.salary);

            }
        }


    }
}
