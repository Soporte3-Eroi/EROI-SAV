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
    public class AddFactD
    {
        public static void FactD()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;

            dynamic resApi = APIeRoi.CallApi("Get", "FactD", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                //var context = new pruebaEntities();
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();


                    var FactD = new SAVFactD()
                    {
                        Factura = value.Factura,
                        Orden =value.Orden,
                        Tipo = value.Tipo,
                        Clave = value.Clave,
                        Descripcion = value.Descripcion,
                        Monto = value.Monto,
                        Descuento = value.Descuento,
                        Comentario = value.Comentario,
                        Cantidad = value.Cantidad,
                        DescripcionAdicional = value.DescripcionAdicional,
                        PorcIva = value.PorcIva,
                        Desc1 = value.Desc1,
                        Unidad = value.Unidad,
                        FolioServicioProg = value.FolioServicioProg,
                        PorcIvaRetencion = value.PorcIvaRetencion,
                        PorcISRRetencion = value.PorcISRRetencion,
                        DescuentoIncluido = value.DescuentoIncluido,
                        DescuentoIncluidoCIva = value.DescuentoIncluidoCIva,
                        SubTotal = value.SubTotal,
                        Iva = value.Iva,
                        IvaRetencion = value.IvaRetencion,
                        ISRRetencion = value.ISRRetencion,
                        TotalR = value.TotalR,
                        SubTotalIva0 = value.SubTotalIva0,
                        SubTotalIva8 = value.SubTotalIva8,
                        SubTotalIva16 = value.SubTotalIva16

                    };

                    //Console.WriteLine("Paso el objeto");
                    //dynamic json = JsonConvert.SerializeObject(Cliente);

                    //var item = JsonConvert.DeserializeObject<SAVCliente>(json);
                    Business n = new Business();
                    int resp = n.agregaFactD(FactD);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Clave = value.Remision
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("FactD Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("FactD registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactD", res).Wait();

                        Console.WriteLine("FactD registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("FactD actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactD", res).Wait();

                        Console.WriteLine("FactD actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar FactD: " + e.Message);
                }
            }
        }
    }
}
