using System;
using System.Globalization;
using System.IO;

namespace Ex_192 {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\ianael\Documents\curso_csharp\Ex_192\itens.txt";
            string target = @"C:\Users\ianael\Documents\curso_csharp\Ex_192\out\summary.txt";
            
            try {
                string[] lines = File.ReadAllLines(path);
                /*using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        lines = sr.ReadLine().Split(';');
                    }
                }*/

                using (StreamWriter sw = File.AppendText(target)) {
                    foreach (string s in lines) {
                        string[] field = s.Split(',');
                        string name = field[0];
                        double price = double.Parse(field[1], CultureInfo.InvariantCulture);
                        int qnt = int.Parse(field[2]);

                        sw.WriteLine(name  + "," + (price*qnt).ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

            } catch(IOException e) {
                Console.WriteLine("Error: " + e.Message);
            } catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }



        }
    }
}
