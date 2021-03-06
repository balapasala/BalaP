﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersTechTest
{
    public class PrintNumbers
    {
        public bool DisplayNumber(int startNumber, int maxNumbers)
        {
            try
            {
                for (int i = startNumber; i <= maxNumbers; i++)
                {                 
                    if (!isPrimeOrCompositeNumberCheck(i))
                    {                     
                       
                            Console.WriteLine(i);
                        
                    }                  
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool isPrimeNumberCheck(int value)
        {
            try
            {
                int count = 0;
                for (int i = 1; i <= value; i++)
                {
                    if (value % i == 0)
                    {

                        count = count + 1;
                    }

                }

                if (count == 2)
                {

                    Console.WriteLine("prime");
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }

        }

        public bool isCompositeNumberCheck(int value)
        {
            try
            {
                int count = 0;
                for (int i = 1; i <= value; i++)
                {
                    if (value % i == 0)
                    {

                        count = count + 1;
                    }

                }

                if (count > 2)
                {

                    Console.WriteLine("composite");
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }

        }


        public bool isPrimeOrCompositeNumberCheck(int value)
        {
            try
            {
                int count = 0;
                for (int i = 1; i <= value; i++)
                {
                    if (value % i == 0)
                    {

                        count = count + 1;
                    }
                    if(count>2)
                    {
                        break;
                    }

                }

                if (count == 2)
                {
                    Console.WriteLine("prime");
                    return true;
                }
                else if(count > 2)
                {
                    Console.WriteLine("composite");
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }

        }

    }
}
