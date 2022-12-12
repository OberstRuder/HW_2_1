using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_2
{
    internal class Customers
    {
        public static string _costumer;
        
        public static void NewCustomer() 
        {
            Console.WriteLine("Enter first and last name");
            _costumer = Console.ReadLine();
            CostumerChecker();
        }

        private static void CostumerChecker()
        {
            string[] text = _costumer.Split(' ');
            if (text.Length < 2)
            {
                Console.WriteLine("Error, not full name");
                NewCustomer();
            }
            else if (text.Length > 2)
            {
                Console.WriteLine("Error, too many words");
                NewCustomer();
            }
        }


    }
}
