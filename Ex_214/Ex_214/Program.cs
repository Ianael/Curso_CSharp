using System;
using System.IO;
using System.Collections.Generic;

namespace Ex_214 {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, int> votos = new Dictionary<string, int>();
            string path = @"C:\Users\ianael\Documents\curso_csharp\Ex_214\in.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int vote = int.Parse(line[1]);

                        if (votos.ContainsKey(candidate)) {
                            votos[candidate] += vote; //Ramal: 4572
                        }else{
                            votos[candidate] = vote;
                        }
                    }
                }

                Console.WriteLine();
                foreach (var v in votos) {
                    Console.WriteLine(v.Key + ": " + v.Value);
                }
            } catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
