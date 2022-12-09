using DatosLAnco;
using MainLanco.Conexion;
using MainLanco.eRoi;
using MainLanco.Utilerias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco
{
    public class AddRemCA
    {
        public static void RemCA()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;

            dynamic resApi = APIeRoi.CallApi("Get", "RemCA", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                //var context = new pruebaEntities();
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();


                    var RemCA = new SAVRemCA()
                    {
                        Remision = value.Remision,
                        FacturaAnticipo = value.FacturaAnticipo,
                        Fecha = value.Fecha == null ? value.Fecha : utileria.convHoraTiempo2(value.Fecha),
                        Total = value.Total,
                        Moneda = value.Moneda,
                        Paridad = value.Paridad,
                        UUID = value.UUID

                    };

                    Console.WriteLine(" ************************** ");

                    Business n = new Business();
                    int resp = n.agregaRemCA(RemCA);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Remision = value.Remision,
                        FacturaAnticipo = RemCA.FacturaAnticipo
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("RemCA Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("RemCA registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaRemCA", res).Wait();

                        Console.WriteLine("RemCA registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("RemCA actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaRemCA", res).Wait();

                        Console.WriteLine("RemCA actualizado en eROI");
                    }
                    else
                    {
                        Console.WriteLine("No se registro/actualizo en DB");
                        Console.WriteLine("------------------------");

                        Console.WriteLine("No se registro/actualizo en eROI");
                    }
                }
                catch (Exception e)
                {
                    newLog.GenerarTXT("Excepción en Agregar RemCA: " + e.Message);
                }
            }
        }
    }
}
