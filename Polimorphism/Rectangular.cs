
using System.Drawing;

namespace Polimorphism
{
    public class Rectangular : Figure
    {
        private int _width;
        private int _height;
        private bool _isValid;
        public int width
        {
            get { return _width; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Side menfi ola bilmez");
                    _isValid = false;
                }
                else if (value == 0)
                {
                    Console.WriteLine("Side deyeri mutleq teyin olunmalidir");
                    _isValid = false;
                }
                else
                {
                    _width = value;
                    _isValid = true;
                }
            } 
        }

        public int height
        {
            get { return height; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Side menfi ola bilmez");
                    _isValid = false;
                }
                else if (value == 0)
                {
                    Console.WriteLine("Side deyeri mutleq teyin olunmalidir");
                    _isValid = false;
                }
                else
                {
                    height = value;
                    _isValid = true;
                }
            }
        }



        public override void CalcArea()
        {
            if (!_isValid)
            {
                return;
            }

            Console.WriteLine($"{width * height}");

        }

    }
}
