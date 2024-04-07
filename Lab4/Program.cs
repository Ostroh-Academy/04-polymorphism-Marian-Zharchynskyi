namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int userSelect;
                Console.WriteLine("Enter '0' if you want to work with Rectangle and '1' - with Parallelepiped");
                userSelect = Convert.ToInt32(Console.ReadLine());

                Rectangle figure = null;

                switch (userSelect)
                {
                    case 0:
                        Console.WriteLine("");
                        figure = new Rectangle();
                        break;

                    case 1:
                        Console.WriteLine("");
                        figure = new Parallelepiped();
                        break;

                    default:
                        Console.WriteLine("You entered wrong argument");
                        break;
                }

                Console.WriteLine(figure.ToString());

                if (figure.IsPointInside())
                {
                    Console.WriteLine("This point lies on this figure");
                }
                else { Console.WriteLine("This point not lies on this figure"); }
            } while(true);

        }
    }
}
