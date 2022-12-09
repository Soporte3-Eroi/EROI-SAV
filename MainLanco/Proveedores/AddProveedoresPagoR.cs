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
    public class AddProveedoresPagoR
    {
        public static void ProveedorPagoR()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "ProveedorPagoR", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var ProveedorPagoR = new SAVProveedorPagoR()
                    {
                        Proveedor = value.Proveedor,
                        Empresa = value.Empresa,
                        Folio = value.Folio,
                        Remision = value.Remision,
                        Costo = value.Costo,
                        PorcIva = value.PorcIva,
                        Obra = value.Obra,
                        ObraClave = value.ObraClave,
                        Comentario = value.Comentario
                    };
                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaProveedorPagoR(ProveedorPagoR);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Proveedor = value.Proveedor

                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("ProveedorPagoR Actualizado" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("ProveedorPagoR registrado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedorPagoR", res).Wait();

                        Console.WriteLine("ProveedorPagoR registrado en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("ProveedorPagoR actualizado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedorPagoR", res).Wait();

                        Console.WriteLine("ProveedorPagoR actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar ProveedorPagoR: " + e.Message);
                }
            }
        }
    }
}
