using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_framework_4_8.Models
{
    class CompareSalary<T> where T : IComparable
    {


        public double Max(double a, double b)
        {
            return a > b ? a : b;

        }



        public T Max (T a , T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }


    }
}
