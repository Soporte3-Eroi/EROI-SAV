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
    public class AddFactCobMPD
    {
        public static void FactCobMPD()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;



            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "FactCobMPD", new { }).Result;


            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var FactCobMPD = new SAVFactCobMPD()
                    {
                        CobroMultipleP = value.CobroMultipleP,
                        Factura = value.Factura,
                        Cobro = value.Cobro,
                        Cliente = value.Cliente,
                        Monto = value.Monto,
                        FacturaFecha = value.FacturaFecha == null ? utileria.convHoraTiempo2(value.FacturaFecha) : value.FacturaFecha,//
                        CobroFecha = value.CobroFecha == null ? utileria.convHoraTiempo2(value.CobroFecha) : value.CobroFecha,//
                        SaldoFactura = value.SaldoFactura,
                        Obra = value.Obra,
                        NCreditoAplicar = value.NCreditoAplicar,
                        Descuento = value.Descuento,
                        DescuentoMonto = value.DescuentoMonto,
                        SerieCFD = value.SerieCFD,
                        FacturaCFD = value.FacturaCFD

                    };

                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaFactCobMPD(FactCobMPD);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        CobroMultipleP = value.CobroMultipleP

                    };

                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("FactCobMPD Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("FactCobMPD registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCobMPD", res).Wait();

                        Console.WriteLine("FactCobMPD registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("FactCobMPD actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCobMPD", res).Wait();

                        Console.WriteLine("FactCobMPD actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar FactCobMPD: " + e.Message);
                }
            }
        }
    }
}
