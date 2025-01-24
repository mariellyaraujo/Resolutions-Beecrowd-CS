using System;

namespace beecrowd {
    class URI1049 {

        public static void Main(string[] args) {

            string A = Console.ReadLine();
            string B = Console.ReadLine();
            string C = Console.ReadLine();

            if (A == "vertebrado") {

                if (B == "ave") {

                    if (C == "carnivoro") {
                        Console.WriteLine("aguia");

                    } else if (C == "onivoro") {
                        Console.WriteLine("pomba");
                    }

                } else if (B == "mamifero") {

                    if (C == "onivoro") {
                        Console.WriteLine("homem");

                    } else if (C == "herbivoro") {
                        Console.WriteLine("vaca");
                    }
                    

                }

            } else if (A == "invertebrado") {
                
                if (B == "inseto") {

                    if (C == "hematofago") {
                        Console.WriteLine("pulga");

                    } else if (C == "herbivoro") {
                        Console.WriteLine("lagarta");
                    }

                } else if (B == "anelideo") {

                    if (C == "hematofago") {
                        Console.WriteLine("sanguessuga");

                    } else if (C == "onivoro") {
                        Console.WriteLine("minhoca");
                    }
                    

                }
            }
        }
    }
}
