using System;

namespace Matriz {
    class Program {
        static void Main(string[] args) {
            /*
            double[,] mat = new double[3,4];
            
            Console.WriteLine(mat.Length); //length pega o total de elementos

            Console.WriteLine(mat.Rank); //número de dimensões da matriz

            Console.WriteLine(mat.GetLength(0)); //tamanho da 1 dimensão
            Console.WriteLine(mat.GetLength(1)); //tamanho da 2 dimensão
            */

            /*
            Console.Write("Matrix size: ");
            int n = int.Parse(Console.ReadLine());
            int[,] m = new int[n,n];

            sbyte count = 0;
            Console.WriteLine();
            for (int i=0; i<n; i++) {
                Console.Write("Line {0}: ", i);
                string[] s = Console.ReadLine().Split(' '); //Já inicializa com os valores

                for (int j=0; j<n; j++) {
                    m[i, j] = int.Parse(s[j]);
                    if (m[i, j] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine("");
            int[] diag = new int[n];
            for (int i = 0; i < n; i++) {
                diag[i] = m[i, i];
            }
            Console.Write("Main Diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(diag[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("There is {0} negative number(s)", count);
            */

            Console.Write("Number of lines: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Number of columns: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            Console.WriteLine();
            for (int i = 0; i < m; i++) {
                Console.Write("Line {0}: ", i);
                string[] s = Console.ReadLine().Split(' '); //Já inicializa com os valores

                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Complete Matrix: ");
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i,j] + " ");
                    if (j == n-1) {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Choose a number of the matrix: ");
            int find = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] == find) {
                        Console.WriteLine();
                        Console.WriteLine(" Pos [{0},{1}]: ", i, j);
                        
                        if(j > 0){
                            Console.WriteLine(" Left: " + mat[i, j-1]);
                        } 
                        if(j < n-1){
                            Console.WriteLine(" Right: " + mat[i, j+1]);
                        }
                        if(i > 0) {
                            Console.WriteLine(" Up: " + mat[i-1, j]);
                        }
                        if(i < m-1){
                            Console.WriteLine(" Down: " + mat[i+1, j]);
                        }
                    }
                }
            }
        }
    }
}
