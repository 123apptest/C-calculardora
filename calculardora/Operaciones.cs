using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculardora
{
    class Operaciones
    {
        public bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Suma(int a , int b)
        {
            return a + b;
        }
        public int Restar(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }

    }
}
