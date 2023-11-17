using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5 {
    internal class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 5; i++) { 
                Console.WriteLine($"Iteration {i}");
                if (i % 2  == 0) Console.WriteLine($"\ni = {i} and result of division = {i / 0}\n");
            }

            Console.WriteLine("Hello world");
        }
    }
}
