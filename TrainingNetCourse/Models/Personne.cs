using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_framework_4_8.Models
{
    class Personne
    {

        public string Place { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public string Job { get; set; }
        public double salary { get; set; }





        public static Personne identityPersonne(String name)
        {
            return new Personne();
        }


        public Personne()
        {

        }
     

   


    }
}
