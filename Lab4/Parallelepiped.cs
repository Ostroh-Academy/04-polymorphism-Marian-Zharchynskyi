using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Parallelepiped : Rectangle
    {
        private double a3;
        private double b3;

        public Parallelepiped()
            : base()
        {
            Console.WriteLine("\n Enter value for a3:\n");
            this.a3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Enter value for b3:\n");
            this.b3 = Convert.ToDouble(Console.ReadLine());
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

            if (x1 >= b1 && x1 <= a1 && x2 >= b2 && x2 <= a2 && x3 >= b3 && x3 <= a3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
