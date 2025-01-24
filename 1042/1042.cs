using System;
using System.Collections.Generic;

namespace beecrowd {
    class URI1042 {

        public static void Main (string[] args) {
         
            List<int> _numerosOrd = new List<int>();
            List<int> _numerosOrg = new List<int>();

            string[] ent = Console.ReadLine().Split(' ');

            int A = int.Parse(ent[0]);
            int B = int.Parse(ent[1]);
            int C = int.Parse(ent[2]);

            _numerosOrd.Add(A);
            _numerosOrd.Add(B);
            _numerosOrd.Add(C);

            _numerosOrg.Add(A);
            _numerosOrg.Add(B);
            _numerosOrg.Add(C);

            _numerosOrd.Sort();

            foreach (var itemOrdenado in _numerosOrd){
                Console.WriteLine(itemOrdenado);
            }

            Console.WriteLine();

            foreach (var itemOrdenado in _numerosOrg){
                Console.WriteLine(itemOrdenado);
            }
        }
    }
}
