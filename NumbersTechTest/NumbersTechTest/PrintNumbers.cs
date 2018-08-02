using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersTechTest
{
    public class PrintNumbers
    {
        public bool DisplayNumber(int maxNumbers)
        {
            try
            {
                for (int i = 1; i <= maxNumbers; i++)
                {
                    Console.WriteLine(i);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
