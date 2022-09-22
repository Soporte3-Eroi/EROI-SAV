using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco.Utilerias
{
    public class Logger : LogBase
    {
        private String CurrentDirectory
        {
            get;
            set;
        }

        private String FileName
        {
            get;
            set;
        }

        private String FilePath
        {
            get;
            set;
        }

        public Logger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            String ruta = this.CurrentDirectory + "/logs";
            //string ruta = @"D:\dev\proyCs\archivos\directorio_nuevo";
            if (!Directory.Exists(ruta))
            {
                //Console.WriteLine("Creando el directorio: {0}", ruta);
                DirectoryInfo di = Directory.CreateDirectory(ruta);
            }

            this.FileName = "Log " + setRangoSemana(DateTime.Now) + ".txt";
            this.FilePath = ruta + "/" + this.FileName;

        }
        string setRangoSemana(DateTime fecha)
        {
            var noSemana = numeroSemana(fecha);
            //Validación para verificar si es la ultima semana del anio
            var semana = primerDíaSemana(noSemana == 52 ? fecha.AddYears(-1).Year : fecha.Year, noSemana, CultureInfo.CurrentCulture);
            var lunes = semana.AddDays(1);
            var domingo = semana.AddDays(7);
            return lunes.ToString("yyyy-MM-dd") + " " + domingo.ToString("yyyy-MM-dd");
        }

        int numeroSemana(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        static DateTime primerDíaSemana(int year, int weekOfYear, System.Globalization.CultureInfo ci)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = (int)ci.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;
            DateTime firstWeekDay = jan1.AddDays(daysOffset);
            int firstWeek = ci.Calendar.GetWeekOfYear(jan1, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
            if ((firstWeek <= 1 || firstWeek >= 52) && daysOffset >= -3)
            {
                weekOfYear -= 1;
            }
            return firstWeekDay.AddDays(weekOfYear * 7);
        }
        public override void Log(string Messsage)
        {

            //System.Console.WriteLine("Logged : {0}", Messsage);

            using (System.IO.StreamWriter w = System.IO.File.AppendText(this.FilePath))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("  :{0}", Messsage);
                w.WriteLine("-----------------------------------------------");
            }
        }
    }
}
