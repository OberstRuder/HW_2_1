using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_2
{
    internal class Goods
    {
        static Goods() => _random = new();

        private static Random _random;

        public static string[] _goodsList = new string[20];

        public static void GoodList()
        {

            for (int i = 0; i < _goodsList.Length; i++)
            {
                _goodsList[i] = (i+1).ToString()+ "\t" + GoodType() + "\t" + GoodCollor() + "\t" + GoodSize();
                Console.WriteLine(_goodsList[i]);
            }
            Console.WriteLine();

        }

        private static string GoodType()
        {
            switch (_random.Next(5))
            {
                case 0:
                    return "T-shirt";
                case 1:
                    return "Shirt";
                case 2:
                    return "Pants";
                case 3:
                    return "Shorts";
                case 4:
                    return "Dress";
                default:
                    return "error";
            }

        }

        private static string GoodSize()
        {
            switch (_random.Next(5))
            {
                case 0:
                    return "XS";
                case 1:
                    return "S";
                case 2:
                    return "M";
                case 3:
                    return "L";
                case 4:
                    return "XL";
                default:
                    return "error";
            }
        }

        private static string GoodCollor()
        {
            switch (_random.Next(5))
            {
                case 0:
                    return "Yellow";
                case 1:
                    return "Red";
                case 2:
                    return "Black";
                case 3:
                    return "White";
                case 4:
                    return "Blue";
                default:
                    return "error";
            }

        }
    }
}
