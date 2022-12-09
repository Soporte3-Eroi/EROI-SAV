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
    public class AddProveedoresMS
    {
        public static void ProveedorMS()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;



            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "ProveedorMS", new { }).Result;


            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var ProveedorMS = new SAVProveedorMS()
                    {
                        Proveedor = value.Proveedor,
                        Fecha = value.Fecha == null ? utileria.convHoraTiempo2(value.Fecha) : value.Fecha, //date
                        Hora = value.Hora == null ? utileria.convHoraTiempo2(value.Hora) : value.Hora,//date
                        Concepto = value.Concepto,
                        Cargo = value.Cargo,
                        Abono = value.Abono,
                        Capturo = value.Capturo,
                        Monto = value.Monto,
                        Moneda = value.Moneda,
                        TipoCambio = value.TipoCambio,
                        Obra = value.Obra,
                        Tipo = value.Tipo,
                        Folio = value.Folio,
                        Factura = value.Factura,
                        NCredito = value.NCredito,
                        FolioPago = value.FolioPago,
                        ObraClave = value.ObraClave,
                        Empresa = value.Empresa
                    };

                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaProveedorMS(ProveedorMS);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Proveedor = value.Proveedor

                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("ProveedorMS Actualizado" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("ProveedorMS registrado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedorMS", res).Wait();

                        Console.WriteLine("ProveedorMS registrado en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("ProveedorMS actualizado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedorMS", res).Wait();

                        Console.WriteLine("ProveedorMS actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar ProveedorMS: " + e.Message);
                }
            }
        }
    }
}
