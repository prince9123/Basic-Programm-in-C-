﻿using System;

namespace data
{
    internal class Data1Base
    {
        private static void Main(string[] args)
        {
            byte a = 0;

            // byte is 8 bit 
            // unsigned value
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            a = 254;

            // It overflows here because
            // byte can hold values from
            // 0 to 255
            a++;
            Console.WriteLine(a);

            // Looping back within the range
            a++;
            Console.WriteLine(a);
        }
    }
}