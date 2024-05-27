namespace Lab4Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FigureFactory factory = new FigureFactory();

            do
            {
                Console.WriteLine("Enter '0' if you want to work with Rectangle and '1' - with Parallelepiped");
                int userSelect = Convert.ToInt32(Console.ReadLine());

          
                  Figure figure = factory.CreateFigure(userSelect);

                  Console.WriteLine(figure.ToString());

                  if (figure.IsPointInside())
                  {
                      Console.WriteLine("This point lies on this figure");
                  }
                  else
                  {
                      Console.WriteLine("This point not lies on this figure");
                  }
                
            } while (true);

        }
    }
}
