using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame {
    class GetUserInput {

        public static int IntInput()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return -1;
            }
        }

        public static bool BoolInput()
        {
            try
            {
                return Convert.ToBoolean(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        public static char CharInput()
        {
            try
            {
                return Convert.ToChar(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return '\0';
            }
        }
    }
}
