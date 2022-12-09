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
    public class AddFactCA
    {
        public static void FactCA()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "FactCA", new { }).Result;


            foreach (dynamic value in resApi.data)
            {
                //var context = new pruebaEntities();
                try
                {
                  
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var FactCA = new SAVFactCA()
                    {
                        Factura = value.Factura,
                        FacturaAnticipo = value.FacturaAnticipo,
                        Fecha = value.Fecha== null ? utileria.convHoraTiempo2(value.Fecha) : value.Fecha, //utileria.convHoraTiempo2(value.Fecha) //
                        //Fecha = value.Fecha != null ? utileria.convHoraTiempo2(value.Fecha) : utileria.convHoraTiempo2("1899-12-30 01:00:00"),
                        ////Fecha = value.Fecha != null ? utileria.convHoraTiempo2(value.Fecha) : null,
                        Total = value.Total,
                        Moneda = value.Moneda,
                        Paridad = value.Paridad,
                        UUID = value.UUID

                    };

                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaFactCA(FactCA);
                    
                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Factura = value.Factura,
                        FacturaAnticipo = value.FacturaAnticipo
               
                    };
                
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("FactCA Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("FactCA registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCA", res).Wait();

                        Console.WriteLine("FactCA registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("FactCA actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCA", res).Wait();

                        Console.WriteLine("FactCA actualizado en eROI");
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
                    Console.WriteLine("Error: " + e.Message);
                    newLog.GenerarTXT("Excepción en Agregar FactCA: " + e.Message);
                }
            }
        }
    }
}
