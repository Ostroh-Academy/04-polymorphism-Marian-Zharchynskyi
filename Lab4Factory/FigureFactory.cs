using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Factory
{
    public class FigureFactory
    {
        public Figure CreateFigure(int type)
        {
            switch (type)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("Enter values for Rectangle:");
                    Console.WriteLine("Enter value for a1:");
                    double a1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter value for a2:");
                    double a2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter value for b1:");
                    double b1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter value for b2:");
                    double b2 = Convert.ToDouble(Console.ReadLine());

                    return new Rectangle(a1, a2, b1, b2);

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Enter values for Parallelepiped:");
                    Console.WriteLine("Enter value for a1:");
                    double a1p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter value for a2:");
                    double a2p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter value for b1:");
                    double b1p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter value for b2:");
                    double b2p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter value for a3:");
                    double a3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter value for b3:");
                    double b3 = Convert.ToDouble(Console.ReadLine());

                    return new Parallelepiped(a1p, a2p, b1p, b2p, a3, b3);

                default:
                    throw new ArgumentException("Invalid type");
            }
        }
    }
}
