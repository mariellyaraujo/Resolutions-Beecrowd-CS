﻿using System;
using System.Globalization;

namespace beecrowd {
    class URI1073 {

        public static void Main (string[] args) {

            int y = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= y; i++) {
        
            if (i % 2 == 0) {
                Console.WriteLine($"{i}^2 = {i * i}");
            }

        }

        }
    }
}
