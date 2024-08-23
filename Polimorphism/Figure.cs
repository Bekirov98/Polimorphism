

namespace Polimorphism
{
    public abstract class Figure
    {

        public virtual void CalcArea() { }
        


        public static Figure CreateFigure()
        {
            Console.Write("Choose: 1.Square 2.Rectangular 3.Quit ");
            int choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Square square = new Square();
                Console.Write("Enter side length: ");
                square.Side = int.Parse(Console.ReadLine());
                return square;
            }
            else if (choose == 2)
            {
                Rectangular rectangular = new Rectangular();
                Console.Write("Enter width: ");
                rectangular.width = int.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                rectangular.height = int.Parse(Console.ReadLine());
                return rectangular;
            }
            else if (choose == 3)
            {
                  Console.WriteLine("Bye!");
                return null;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return null;
            }
        }
    }
}
