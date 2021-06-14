using System;
using System.Data;
using System.Linq;

namespace Exemplo_DataTable {
    class Program {

        static void Main(string[] args) {
            DataTable dt = new DataTable("Teste");

            dt.Columns.Add("Id", typeof(int));
            dt.Columns["Id"].AutoIncrement = true;
            //dt.Columns["Id"].AutoIncrementStep = 1; //Default já é 1
            //dt.Columns["Id"].Unique = true; //Não podem existir valores repetidos

            // Make the ID column the Primary Key column.
            //dt.PrimaryKey = new DataColumn[] {dt.Columns["Id"]};
            
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            
            DataRow row = dt.NewRow();

            //row["Id"] = "0";  //Já foi definido como auto incremento
            row["Name"] = "Ia";
            row["Email"] = "ia@yahoo.com.br";
            row["Date"] = "24/09/2021";

            dt.Rows.Add(row);

            string nome = (string)dt.Rows[0][1]; //Valor 0 da coluna 1
            Console.WriteLine(nome);
            Console.WriteLine();

            foreach (DataRow r in dt.Rows) {
                Console.WriteLine($"Id: {r["Id"]}\nNome: {r["Name"]}\nEmail: {r["Email"]}\nData: {r["Date"]}");
                Console.WriteLine();
                //Ou todos os itens:
                foreach(var item in r.ItemArray){
                    Console.WriteLine(item);
                }
            }

            //Usando delete ou fazendo alterações na tabela utilizar:
                //dt.AcceptChanges() para dar um "commit" nas mudanças
        }
    }
}
