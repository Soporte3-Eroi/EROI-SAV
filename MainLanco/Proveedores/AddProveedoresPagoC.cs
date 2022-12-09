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
    public class AddProveedoresPagoC
    {
        public static void ProveedorPagoC()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "ProveedorPagoC", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var ProveedorPagoC = new SAVProveedorPagoC()
                    {
                        Proveedor = value.Proveedor,
                        Empresa = value.Empresa,
                        Folio = value.Folio,
                        Factura = value.Factura,
                        ProveedorNombre = value.ProveedorNombre,
                        Concepto = value.Concepto,
                        Detalle = value.Detalle,
                        Total = value.Total,
                        FechaFactura = value.FechaFactura == null ? utileria.convHoraTiempo2(value.FechaFactura) : value.FechaFactura, //date
                        NCredito = value.NCredito,
                        Pagado = value.Pagado,
                        Saldo = value.Saldo,
                        Estatus = value.Estatus,
                        Capturo = value.Capturo,
                        FechaAlta = value.FechaAlta == null ? utileria.convHoraTiempo2(value.FechaAlta) : value.FechaAlta, //date
                        FechaAltaHora = value.FechaAltaHora == null ? utileria.convHoraTiempo2(value.FechaAltaHora) : value.FechaAltaHora,//date
                        Procesado = value.Procesado,
                        Giro = value.Giro,
                        Zona = value.Zona,
                        Obra = value.Obra,
                        LigaObra = value.LigaObra,
                        ObraClave = value.ObraClave,
                        CancelacionFecha = value.CancelacionFecha == null ? utileria.convHoraTiempo2(value.CancelacionFecha) : value.CancelacionFecha, //date
                        CancelacionCapturo = value.CancelacionCapturo,
                        CancelacionMotivo = value.CancelacionMotivo,
                        CancelacionSustituye = value.CancelacionSustituye,
                        Autorizacion = value.Autorizacion,
                        Plazo = value.Plazo,
                        ContraRecibo = value.ContraRecibo,
                        TipoCambio = value.TipoCambio,
                        SubContratista = value.SubContratista,
                        PreAutorizacion = value.PreAutorizacion,
                        RemisionCosto = value.RemisionCosto
                    };
                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaProveedorPagoC(ProveedorPagoC);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Proveedor = value.Proveedor

                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("ProveedorPagoC Actualizado" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("ProveedorPagoC registrado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedorPagoC", res).Wait();

                        Console.WriteLine("ProveedorPagoC registrado en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("ProveedorPagoC actualizado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedorPagoC", res).Wait();

                        Console.WriteLine("ProveedorPagoC actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar ProveedorPagoC: " + e.Message);
                }
            }
        }
    }
}
