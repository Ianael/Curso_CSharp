using System;
using System.Collections.Generic;

namespace Dictionary_SortedDictionary {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@mail.com";
            cookies["phone"] = "99546454";
            cookies["phone"] = "99878868";

            Console.WriteLine(cookies["phone"]); //Não aceita repetições, acita o último
            Console.WriteLine(cookies["email"]);
            
            cookies.Remove("email");

            if (cookies.ContainsKey("email")) {
                Console.WriteLine(cookies["email"]);
            } else {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine();
            Console.WriteLine("All Cookies: ");
            foreach (KeyValuePair<string, string> item in cookies) {//pode-se usar o tipo var tbm
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
