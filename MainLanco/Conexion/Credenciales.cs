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
                
                var obj = new
                {
                    url = url,
                    user = user,
                    pass = pass
                };
                return obj;
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.Log("ClassLibrary: Error en el método ConexionStringHana. " + ex.GetType().ToString() + " " + ex.Message);

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
                }
                return conf;
            }
            catch (Exception e)
            {
                var logger = new Logger();
                logger.Log("Error en el método readFile. No se pudo completar la lectura del archivo de configuración" + e.Message);
                return conf = null;
            }
        }
    }
}
