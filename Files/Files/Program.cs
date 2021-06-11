using System;
using System.IO;
using System.Collections.Generic;

namespace Files {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\ianael\Documents\curso_csharp\Files\File.txt";
            string targetPath = @"C:\Users\ianael\Documents\curso_csharp\Files\Out.txt";
            //StreamReader sr = null;
            try {
                /*FileInfo fs = new FileInfo(sourcePath);
                fs.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string s in lines) {
                    Console.WriteLine(s);
                }*/

                /*sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }*/

                //Fecha arquivo automaticamente
                /* using (FileStream fs = new FileStream(path, FileMode.Open)) {
                     using (StreamReader sr = new StreamReader(fs)) {
                         while (!sr.EndOfStream) {
                             string line = sr.ReadLine();
                             Console.WriteLine(line);
                         }
                     }
                 }*/

                /*using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }*/

                string[] lines = File.ReadAllLines(path);

                using (StreamWriter sw = File.AppendText(targetPath)) { //append abre e escreve
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }catch(IOException e) {
                Console.WriteLine("ERROR: "+ e.Message);
            } /*finally {
                if (sr != null) {
                    sr.Close();
                }
                //if (fs != null) fs.Close();
               
            }*/
        }
    }
}
