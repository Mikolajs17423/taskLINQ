using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class ExtnestionMethods
    {
        public static bool IsCorrectIndex(this string str)
        {
            //s2323
            return str[0] == 's' && str.Length == 5;
        }



    }
}
