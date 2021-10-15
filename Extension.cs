using System;
using System.Collections.Generic;
using System.Text;

namespace Homework16._10
{
    static class Extension
    {

        public static int Sum(this Advertisement ad1, Advertisement ad2)
        {
            int sum= ad1.Price + ad2.Price;
            return sum;
        }
    }
}
