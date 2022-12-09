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
    public class AddRemD
    {
        public static void RemD()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "RemD", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
             
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();


                    var RemD = new SAVRemD()
                    {
                        Remision = value.Remision,
                        Orden = value.Orden,
                        Tipo = value.Tipo,
                        Clave = value.Clave,
                        Descripcion = value.Descripcion,
                        Monto = value.Monto,
                        Descuento = value.Descuento == 1 ? true : false,
                        Comentario = value.Comentario,
                        Cantidad = value.Cantidad,
                        DescripcionAdicional = value.DescripcionAdicional,
                        PorcIva = value.PorcIva,
                        Desc1 = value.Desc1,
                        Unidad = value.Unidad,
                        FolioServicioProg = value.FolioServicioProg,
                        PorcIvaRetencion = value.PorcIvaRetencion,
                        PorcISRRetencion = value.PorcISRRetencion

                    };

                    Console.WriteLine("********************************");
                    Business n = new Business();
                    int resp = n.agregaRemD(RemD);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Remision = value.Remision,
                        ClaveLanco = RemD.Remision,
                        Orden = RemD.Orden
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("RemD Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("RemD registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaRemD", res).Wait();

                        Console.WriteLine("RemD registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("RemD actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaRemD", res).Wait();

                        Console.WriteLine("RemD actualizado en eROI");
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
                    Console.WriteLine("Error: "+e.Message);
                    newLog.GenerarTXT("Excepción en Agregar RemD: " + e.Message);
                }
            }
        }
    }
}
