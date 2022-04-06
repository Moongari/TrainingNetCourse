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




            // une lambda expression  c'est args=> expression
            // number=> number * number

            // utilisation d'un delegate de type Func a qui on passe un int entrée et retourne un int
            Func<int, int> square = number => number * number;


            Console.WriteLine(square(34));

            // si il n'y a pas d'argument ()=> ....
            // x => ....
            // (x,y,z) => ......

            const int factor = 5;
            Func<int, int> addition = n => n + factor;
            var result = addition(34);

            Console.WriteLine(result);







            Console.ReadLine();



        }


       
    }
    
}
