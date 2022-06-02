using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApp
{
    public class TableMultiplication  : IAffichable
    {
        int numero = 0;

        public TableMultiplication(int num)
        {
            this.numero = num;
        }


       

        public void Afficher()
        {
            Console.WriteLine($"Table de multiplication de : {numero}");
            for (int i = 0; i < 11; i++)
            {

                Console.WriteLine($" {i} * {numero} =  { i * numero}");

            }

            Console.WriteLine("================================");
        }
    }
}
