﻿using System;

namespace blok_kode_dan_cakupan_variabel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int value = 0;

            if (flag)
            {
                value = 10;
                Console.WriteLine("Inside of code block: " + value);
            }
            Console.WriteLine("Outside of code block: " + value);
        }
    }
}
