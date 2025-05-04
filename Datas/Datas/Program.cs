using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Manipulação de datas
            //var data = new DateTime(2025, 05, 03, 15, 34, 15);
            //var data = DateTime.Now;
            //Console.WriteLine(data);
            //Console.WriteLine(data.Year);
            //Console.WriteLine(data.Month);
            //Console.WriteLine(data.Day);
            //Console.WriteLine(data.Hour);
            //Console.WriteLine(data.Minute);
            //Console.WriteLine(data.Second);
            //Console.WriteLine(data.DayOfWeek);

            var data = DateTime.Now;
            var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data); // Customizada
            var formatada2 = String.Format("{0:t}", data); // Somente h:mm 
            var formatada3 = String.Format("{0:T}", data); // Somente h:mm:s
            var formatada4 = String.Format("{0:d}", data); // Somente dd/MM/yyyy 
            var formatada5 = String.Format("{0:D}", data); // Data completa
            var formatada6 = String.Format("{0:r}", data); // padrão usado pela maioria dos sistemas
            var formatada7 = String.Format("{0:s}", data); // padrão usado pelo mongoDB
            var formatada8 = String.Format("{0:u}", data); // padrão usado pelo JSON

            //Console.WriteLine("Customizada: " + formatada);
            //Console.WriteLine("{0:t} " + formatada2);
            //Console.WriteLine("{0:T} " + formatada3);
            //Console.WriteLine("{0:d} " + formatada4);
            //Console.WriteLine("{0:D} " + formatada5);
            //Console.WriteLine("{0:r} " + formatada6);
            //Console.WriteLine("{0:s} " + formatada7);
            //Console.WriteLine("{0:u} " + formatada8);

            //Console.WriteLine();

            //Console.WriteLine("Add days: " + data.AddDays(-12));
            //Console.WriteLine("Add months: " + data.AddMonths(3));
            //Console.WriteLine("Add years: " + data.AddYears(5));

            //Console.WriteLine();

            //var pt = new CultureInfo("pt-PT");
            //var br = new CultureInfo("pt-BR");
            //var en = new CultureInfo("en-US");
            //var de = new CultureInfo("de-DE");

            //Console.WriteLine();

            // Ao invés do 'String.Format' é mais comumente usado este padrão:
            //Console.WriteLine("Portugal: " + DateTime.Now.ToString("D", pt));
            //Console.WriteLine("Brasil: " + DateTime.Now.ToString("D", br));
            //Console.WriteLine("EUA: " + DateTime.Now.ToString("D", en));
            //Console.WriteLine("Dinamarca: " + DateTime.Now.ToString("D", de));

            //Console.WriteLine();

            // Quando precisamos exibir a data para mais de um país é importante
            // que deixemos essa data no formato padrão ou seja UTC:
            //var utcDate = DateTime.UtcNow;
            //Console.WriteLine("UTC: " + utcDate);

            // E quando formos exibir convertamos para a data do país local:
            //Console.WriteLine("Local: " + utcDate.ToLocalTime());

            //var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            //Console.WriteLine(timeZoneAustralia);

            //var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);
            //Console.WriteLine(horaAustralia);

            //var timezones = TimeZoneInfo.GetSystemTimeZones();
            //foreach(var timezone in timezones)
            //{
            //    Console.WriteLine(timezone.Id);
            //    Console.WriteLine(timezone);
            //    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            //    Console.WriteLine("--------------------------------");
            //}

            // Trabalhando com data e hora

            var timeSpan = new TimeSpan();
            Console.WriteLine("TimeSpan vazio: " + timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine("NanoSegundos: " + timeSpanNanoSegundos);
            
            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine("Hora, minuto, segundo: " + timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(5, 12, 8, 45);
            Console.WriteLine("Dia, hora, minuto, segundo: " + timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(5, 12, 8, 45, 15);
            Console.WriteLine("Dia, hora, minuto, segundo, milissegundo: " + timeSpanDiaHoraMinutoSegundoMilissegundo);

            // O TimeSpan nos possibilita trabalhar com calculos de data e hora:
            Console.WriteLine("TimeSpan - TimeSpan: " + (timeSpanDiaHoraMinutoSegundoMilissegundo - timeSpanDiaHoraMinutoSegundo));
            Console.WriteLine("Dias: " + timeSpanDiaHoraMinutoSegundoMilissegundo.Days);
            Console.WriteLine("TimeSpan adicionar tempo: " + timeSpanDiaHoraMinutoSegundoMilissegundo.Add(new TimeSpan(12, 0, 0)));

            Console.WriteLine("Quantidade de dias no mês: " + DateTime.DaysInMonth(2025, 5));
            Console.WriteLine("É horário de verão: " + DateTime.Now.IsDaylightSavingTime());
            Console.WriteLine("É fim de semana: " + IsWeekend(DateTime.Now.DayOfWeek));
        }

        // Metodo para saber se é fim de semana ou não
        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}
