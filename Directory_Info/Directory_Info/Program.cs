using System;
using System.Collections.Generic;
using System.IO;

namespace Directory_Info {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\ianael\Documents\curso_csharp\Directory_Info\ola.txt";

            try {
                /*IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //pode usar var
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }*/

                /*var files = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\Sou_Uma_Pasta"); //Cria pasta*/

                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
                Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetExtension: " + Path.GetExtension(path));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());
                


            } catch(IOException e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
