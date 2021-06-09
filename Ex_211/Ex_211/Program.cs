using System;
using System.Collections.Generic;
using System.IO;
using Ex_211.Entities;

namespace Ex_211 {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\ianael\Documents\curso_csharp\Ex_211\in.txt";

            HashSet<LogRecord> set = new HashSet<LogRecord>();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }

            } catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
