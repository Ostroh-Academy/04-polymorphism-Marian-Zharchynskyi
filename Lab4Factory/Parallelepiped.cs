using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Factory
{
    public class Parallelepiped : Rectangle
    {
        private double a3;
        private double b3;

        public Parallelepiped(double a1, double a2, double b1, double b2, double a3, double b3)
            : base(a1, a2, b1, b2) 
        {
            this.a3 = a3;
            this.b3 = b3;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"a3 = {a3} \n" +
                $"b3 = {b3} \n";
        }

        public override bool IsPointInside()
        {
            Console.WriteLine("Enter values of x1, x2 and x3");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());

            return x1 >= b1 && x1 <= a1 && x2 >= b2 && x2 <= a2 && x3 >= b3 && x3 <= a3;
        }

    }
}
