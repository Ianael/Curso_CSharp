using System;
using System.Threading.Tasks;

namespace TaskConsole {
    class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Cyan;

            #region Funcionamento simples de Tasks
            /*
            //Task t1 = new Task(Tarefa);
            //t1.Start();

            //Task t2 = Task.Run(Tarefa); //Inicializa com start
            //Task.Run(Tarefa);

            Task.Factory.StartNew(Tarefa);

            Task.Run(() => {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine("Tarefa Anon");
                }
            });

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Principal");
            }
            
            Console.ReadKey();
            */
            #endregion

            #region Tasks por array
            /*Task[] tasks = new Task[5];
            tasks[0] = Task.Run(Tarefa);*/
            /*
            Task[] tasks = {
                Task.Factory.StartNew(() => {
                    Console.WriteLine("Tarefa #0");
                }),

                Task.Factory.StartNew(() => {
                    Console.WriteLine("Tarefa #1");
                }),
                
                Task.Factory.StartNew(() => {
                    Console.WriteLine("Tarefa #2");
                })
            };
            //tasks[1].Start(); //-> Caso não utilize StartNew

            Task.WaitAll(tasks); //Executa tarefa(s) antes de continuar
            //Task.WaitAll(tasks[0], tasks[1], tasks[2]);

            Console.WriteLine("Principal");

            Console.ReadKey();
            */
            #endregion

            #region Ordenação de Tasks e Task com retorno
            //Task<int> t1 = Task.Factory.StartNew(() => DobraMeta(10));
            //Console.WriteLine(t1.Result);

            Task<int> t1 = Task.Factory.StartNew(() => {
                return new Random().Next(101);
            });

            Task<int> t2 = t1.ContinueWith((num) => {
                return num.Result * 2;
            });

            Task<string> t3 = t2.ContinueWith((num) => {
                return "O valor final é: " + num.Result.ToString();
            });

            Console.WriteLine("Valor Inicial: " + t1.Result + Environment.NewLine);

            Console.WriteLine(t3.Result);

            Console.ReadKey();
            #endregion
        }

        static int DobraMeta(int num) {
            return num * 2;
        }

        static void Tarefa() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Tarefa da Task");
            }
        }
    }
}
