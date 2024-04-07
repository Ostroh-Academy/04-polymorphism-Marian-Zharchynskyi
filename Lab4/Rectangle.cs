using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Rectangle
    {
        protected double a1;
        protected double a2;
        protected double b1;
        protected double b2;

        public Rectangle(double a1, double a2, double b1, double b2)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.b1 = b1;
            this.b2 = b2;
        }

        public Rectangle()
        {
            Console.WriteLine("Enter value for a1:");
            a1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for a2:");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for b1:");
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for b2:");
            b2 = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"a1= {a1} \n" +
                $"a2 = {a2} \n" +
                $"b1 = {b1} \n" +
                $"b2 = {b2} \n";
        }

        public virtual bool IsPointInside()
        {
            Console.WriteLine("Enter values of x1 and x2");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());

            if (x1 >= b1 && x1 <= a1 && x2 >= b2 && x2 <= a2)
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
