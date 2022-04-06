﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_framework_4_8.Models
{
    class ControleSalary
    {

        public delegate void PersonneHandler(Personne person);


        public void ProcessControl(PersonneHandler personneHandler)
        {

            Personne john = new Personne { FirstName = "John", LastName = "Rambo", Age = 45, Place = "Californie", Job = "Soldier", salary = 3420.45 };
            Personne Arthur = new Personne { FirstName = "Arthur", LastName = "Gilbert", Age = 67, Place = "Dakota", Job = "Juge", salary = 12490.50 };

            

            personneHandler(john);
            personneHandler(Arthur);

        }


    }
}
