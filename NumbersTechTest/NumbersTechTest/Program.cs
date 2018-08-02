﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersTechTest
{
   public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Startnumber = 1;
                int EndNumber = 100;
                //Creating instance for PrintNumbers
                PrintNumbers objPNumbers = new PrintNumbers();
                if(!objPNumbers.DisplayNumber(Startnumber, EndNumber))
                {
                    throw new Exception("Error: Unable to print numbers!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
