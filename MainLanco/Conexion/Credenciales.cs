using MainLanco.Utilerias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco.Conexion
{
    public class Credenciales
    {
        public dynamic credenciales()
        {
            var objs = new { };
            try
            {
                // Obtenemos el path relativo (en donde se encuentra la aplicacion)
                var outPutDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
                
                
                outPutDirectory = Path.Combine(outPutDirectory, "config\\config.json");
                // Convertimos el path en uno valido
                string file_path = new Uri(outPutDirectory).LocalPath;
                //    // Buscamos, leemos y convertimos a json el archivo
                
                
                dynamic json = readFile(file_path).Result;

                var url = json.Url;
                var user = json.User;
                var pass = json.Password;
                var fechaInicio = json.fecha_inicio;
                var fechaFin = json.fecha_fin;
                var Folio = json.SAVFolio; //TABLA DE FOLIOS DE TODAS LAS TABLAS....
                var Obra = json.Obra;
                var Cliente = json.SAVCliente;
                var RemC = json.SAVRemC;
                var RemD = json.SAVRemD;
                var RemCA = json.SAVRemCA;
                var FactC = json.SAVFactC;
                var FactCA = json.SAVFactCA;
                var FactCFD = json.SAVFactCFD;
                var FactD = json.SAVFactD;
                var ObraServicioProg = json.SAVObraServicioProg;
                var Serv01 = json.Serv01; //PENDIENTE
                var Personal = json.SAVPersonal; //PENDIENTE


                var obj = new
                {
                    url = url,
                    user = user,
                    pass = pass,
                    fecha_inicio = fechaInicio,
                    Fecha_fin = fechaFin,
                    Folio = Folio,
                    Obra = Obra,
                    Cliente = Cliente,
                    RemC = RemC,
                    RemD = RemD,
                    RemCA = RemCA,
                    FactC = FactC,
                    FactCA = FactCA,
                    FactCFD = FactCFD,
                    FactD = FactD,
                    ObraServicioProg = ObraServicioProg,
                    Serv01 = Serv01,
                    personal = Personal,

                };
                return obj;
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.Log("Credenciales: Error en el método credencials. " + ex.GetType().ToString() + "" + ex.Message);
                //newLog.GenerarTXT("Credenciales: Error en el método credenciales. " + ex.GetType().ToString() + " " + ex.Message);

                return objs;
            }
        }

        static async Task<dynamic> readFile(string filePath)
        {
            dynamic conf;
            try
            {

                using (StreamReader jsonStream = File.OpenText(filePath))
                {
                    TextReader leer = jsonStream;
                    string json1 = await leer.ReadToEndAsync();
                    conf = JsonConvert.DeserializeObject(json1);
                    jsonStream.Dispose();
                    leer.Dispose();
                }
                return conf;
            }
            catch (Exception e)
            {
                var logger = new Logger();
                logger.Log("Error en el método readFile. No se pudo completar la lectura del archivo de configuración" + e.Message);
                return conf = null;
                //newLog.GenerarTXT("Error en el método readFile. No se pudo completar la lectura del archivo de configuración" + e.Message);
            }
        }
    }
}
