﻿using System;
using System.Globalization;

namespace beecrowd {
    class URI1060 {

        public static void Main(string[] args) {

        double num;
        int positivos = 0;

        for (int i = 0; i < 6; i++) {
        
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (num >= 0) {
                positivos++;
            }

        }

        Console.WriteLine($"{positivos} valores positivos");
        }
    }
}
