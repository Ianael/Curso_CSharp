using System;

namespace Strings {
    class Program {
        static void Main(string[] args) {

            string original = "Olá, sou a frase ORIGINAL! ";
            Console.WriteLine("Original: - " + original + "-");

            string s1 = original.ToUpper();
            Console.WriteLine("ToUpper: - " + s1 + "-");

            string s2 = original.ToLower();
            Console.WriteLine("ToLower: - " + s2 + "-");

            string s3 = original.Trim();
            Console.WriteLine("Trim: - " + s3 + "-");

            int n1 = original.IndexOf("a");
            Console.WriteLine("IndexOf('a'): " + n1);

            int n2 = original.LastIndexOf("a");
            Console.WriteLine("LastIndexOf('a'): " + n2);

            string s4 = original.Substring(4);
            Console.WriteLine("Substring(4): " + s4);

            string s5 = original.Substring(4, 6);
            Console.WriteLine("Substring(4, 6): " + s5);

            string s6 = original.Replace('a', 'e');
            Console.WriteLine("Replace('a', 'e'): " + s6);

            string s7 = original.Replace("ORIGINAL", "IMPOSTORA");
            Console.WriteLine("Replace('ORIGINAL', 'IMPOSTORA'): " + s7);

            bool b1 = string.IsNullOrEmpty(original);
            Console.WriteLine("IsNullOrEmpty: " + b1); //""

            bool b2 = string.IsNullOrWhiteSpace(original);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2); //"   "
        }
    }
}
