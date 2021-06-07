using System;
using System.Globalization;

namespace DateTimeIana {
    class Program {
        //public struct DateTime : IComparable, IComparable<DateTime>, IConvertible, IEquatable<DateTime>, IFormattable, System.Runtime.Serialization.ISerializable
        static void Main(string[] args) {
            //DATETIME:
            /*
            DateTime d = DateTime.Now;

            Console.WriteLine(d);
            Console.WriteLine(d.Ticks); //1 tick = 100ns

            DateTime d1 = new DateTime(2018, 11, 25); // ano/mes/dia
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2018, 11, 25, 20 , 45, 3); // ano/mes/dia - h:min:s
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500); // ano/mes/dia - h:min:s:mil
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Today; //Data atual com horário zerado
            Console.WriteLine(d4);

            DateTime d5 = DateTime.UtcNow; //Data atual Greenwich
            Console.WriteLine(d5);

            DateTime d6 = DateTime.Parse("2000-08-15"); //Tbm funciona com 15/08/2000
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d7);

            //Cria próprio padrão
            DateTime d8 = DateTime.ParseExact("2000-08-15 13:05:58", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d8);
            */

            //TIMESTAMP
            /*
            TimeSpan t1 = new TimeSpan();
            Console.WriteLine(t1);

            TimeSpan t2 = new TimeSpan(0, 1, 30); //h:min:s
            Console.WriteLine(t2);
            Console.WriteLine(t2.Ticks);

            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(1, 0, 1, 30); //d:h:min:s
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(1, 0, 1, 30, 500); //d:h:min:s:mil
            Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromDays(1.5); //Equivalente a 1 dia e meio
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromHours(1.5); //Também pode-se usar Minutes, Seconds, Milliseconds e Ticks(este n pode ser "quebrado")
            Console.WriteLine(t7);
            */

            //OPERAÇÕES:
            /*
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Milliseconds: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Seconds: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("14) ToLongDateString: " + d.ToLongDateString());
            Console.WriteLine("15) ToLongTimeString: " + d.ToLongTimeString());
            Console.WriteLine("16) ToShortDateString: " + d.ToShortDateString());
            Console.WriteLine("17) ToShortTimeString: " + d.ToShortTimeString());
            Console.WriteLine("18) ToString: " + d.ToString());
            Console.WriteLine("19) ToString('yyyy-MM-dd HH:mm:ss'): " + d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("20) ToString('yyyy-MM-dd HH:mm:ss.fff'): " + d.ToString("yyyy-MM-dd HH:mm:ss.fff")); //fff - milisegundos

            DateTime d2 = d.AddHours(2);
            Console.WriteLine();
            Console.WriteLine("Mais 2h: " + d2);
            Console.WriteLine("Diferença: " + d2.Subtract(d));
            */

            /*TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(2,3,5,7,11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days); //inteiro -Total é o número quebrado
            Console.WriteLine("Total Days: " + t.TotalDays); //Também pode-se usar horas, min, mili, sec e ticks
            */

            TimeSpan t1 = new TimeSpan(1,30,10);
            Console.WriteLine(t1);
            TimeSpan t2 = new TimeSpan(0,10,5);
            Console.WriteLine(t2);

            TimeSpan sum = t1.Add(t2);
            Console.WriteLine("Soma: " + sum);

            TimeSpan dif = t1.Subtract(t2);
            Console.WriteLine("Subtração: " + dif);

            TimeSpan mult = t2.Multiply(2);
            Console.WriteLine("Multiplicação de t2: " + mult);

            TimeSpan div = t1.Divide(2);
            Console.WriteLine("Divisão de t por 2: " + div);
        }
    }
}
