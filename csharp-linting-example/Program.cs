﻿// Copyright © TH Corp

namespace SampleApp
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> names = new List<string>() { "John", "Jane", "Doe" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
