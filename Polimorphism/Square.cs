

namespace Polimorphism
{


    public class Square : Figure
    {
        private int _side;
        private bool _isValid;
        public int Side 
        {
            get { return _side; }

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
                     _side = value;
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

            Console.WriteLine($"{Side * Side}");
        }


    }
}
