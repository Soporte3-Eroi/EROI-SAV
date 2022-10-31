using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco.Utilerias
{
    public class newLog
    {
        public static void GenerarTXT(string json)
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();
            DateTime date = new DateTime();
            date = DateTime.Now;
            string Date = Convert.ToDateTime(date).ToString("D");
            int contDte = Date.Length;
            //string Fecha = Convert.ToDateTime(date).ToString("HH-mm-ss");
            //string datetime = Date + " T " + Fecha;
            string datetime = Date;

            string rutaCarp = CurrentDirectory + "/Logs";
            string ruta = CurrentDirectory + "/Logs/" + datetime + ".txt";
            string rutaDate = datetime.Substring(0, contDte);
            //Console.WriteLine(rutaDate);
            //Console.ReadLine();

            if (!Directory.Exists(rutaCarp))
            {
                //Console.WriteLine("Creando el directorio: {0}", ruta);
                DirectoryInfo di = Directory.CreateDirectory(rutaCarp);
            }
            if (!File.Exists(ruta))
            {
                using (StreamWriter mylogs = File.AppendText(ruta))         //se crea la carpeta
                {

                    //se adiciona alguna información y la fecha


                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string strDate = Convert.ToDateTime(dateTime).ToString("G");

                    mylogs.WriteLine(strDate);

                    mylogs.WriteLine(json);
                    mylogs.Close();


                }
            }
            else
            {
                using (StreamWriter mylogs = File.AppendText(ruta))         //se crea el archivo
                {

                    //se adiciona alguna información y la fecha


                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string strDate = Convert.ToDateTime(dateTime).ToString("G");
                    mylogs.WriteLine();

                    mylogs.WriteLine(strDate);

                    mylogs.WriteLine(json);

                    mylogs.Close();
                }

            }

        }
        public DateTime obtenerHoraFile()
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();
            DateTime date = new DateTime();
            date = DateTime.Now;
            string Date = Convert.ToDateTime(date).ToString("D");
            string datetime = Date;
            string ruta = CurrentDirectory + "/Logs/" + datetime + ".txt";
            DateTime horaFile = new DateTime();
            using (FileStream myFile = File.OpenRead(ruta))
            {
                horaFile = File.GetLastWriteTime(ruta);
                //horaFile = Convert.ToString(values);
                //Console.WriteLine(values.ToString());
                myFile.Close();
            }

            return horaFile;
        }
    }
}
