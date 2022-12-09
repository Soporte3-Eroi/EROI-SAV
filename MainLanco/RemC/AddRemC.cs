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
    public class AddRemC
    {
        public static void RemC()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "RemC", new { }).Result;
            
            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();
                    

                    var RemC = new SAVRemC()
                    {
                        Remision = value.Remision,
                        Cliente = value.Cliente,
                        FacturarA = value.FacturarA,
                        Fecha = value.Fecha == null ? value.Fecha : utileria.convHoraTiempo2(value.Fecha),
                        TipoCambio = value.TipoCambio,
                        PorcIva = value.PorcIva,
                        Capturo = value.Capturo,
                        Comentario = value.Comentario,
                        SubTotal = value.SubTotal,
                        IVA = value.IVA,
                        Total = value.Total,
                        Procesado = value.Procesado == "1" ? true : false,
                        Estatus = value.Estatus,
                        Pagado = value.Pagado,
                        Saldo = value.Saldo,
                        Partidas = value.Partidas,
                        FechaAlta = value.FechaAlta == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta),
                        UltimoCambio = value.UltimoCambio == null ? value.UltimoCambio : utileria.convHoraTiempo2(value.UltimoCambio),
                        TotalLetra = value.TotalLetra,
                        Tipo = value.Tipo,
                        NCredito = value.NCredito,
                        Vendedor = value.Vendedor,
                        Giro = value.Giro,
                        Zona = value.Zona,
                        RFC = value.RFC,
                        ConRFC = value.ConRFC == "1" ? true : false,
                        FacturaConsolidada = value.FacturaConsolidada == "1" ? true : false,
                        Corrida = value.Corrida,
                        Hora = value.Hora == null ? value.Hora : utileria.convHoraTiempo2(value.Hora), //AQUI ESTA EL ERROR
                        Obra = value.Obra,
                        LigaObra = value.LigaObra == "1" ? true : false,
                        ObraClave = value.ObraClave,
                        Impresiones = value.Impresiones,
                        CancelacionFecha = value.CancelacionFecha == null ? value.CancelacionFecha : utileria.convHoraTiempo2(value.CancelacionFecha),
                        CancelacionCapturo = value.CancelacionCapturo,
                        ConsignadoA = value.ConsignadoA,
                        ObraUbicacion = value.ObraUbicacion,
                        CancelacionMotivo = value.CancelacionMotivo,
                        Facturado = value.Facturado == "1" ? true : false,
                        FacturadoFecha = value.FacturadoFecha == null ? value.FacturadoFecha : utileria.convHoraTiempo2(value.FacturadoFecha),
                        FacturadoFactura = value.FacturadoFactura,
                        CancelacionSustituye = value.CancelacionSustituye,
                        Aux1 = value.Aux1,
                        Aux2 = value.Aux2,
                        AgendaMensajeria = value.AgendaMensajeria,
                        MetododePago = value.MetododePago,
                        NumCtaPago = value.NumCtaPago,
                        FacturadoFechaOriginal = value.FacturadoFechaOriginal == null ? value.FacturadoFechaOriginal : utileria.convHoraTiempo2(value.FacturadoFechaOriginal),
                        FacturadoFacturaOriginal = value.FacturadoFacturaOriginal,
                        CapturoCambio = value.CapturoCambio,
                        FormadePago = value.FormadePago,
                        UsoCFDI = value.UsoCFDI,
                        RetencionIVA = value.RetencionIVA,
                        RetencionISR = value.RetencionISR,
                        FacturaSustituye = value.FacturaSustituye

                    };

                    Console.WriteLine("********************************");

                    Business n = new Business();
                    int resp = n.agregaRemC(RemC);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Remision = value.Remision,
                        ClaveLanco = RemC.Remision
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("RemCActualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("RemC registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaRemC", res).Wait();

                        Console.WriteLine("RemC registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("RemC actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaRemC", res).Wait();

                        Console.WriteLine("RemC actualizado en eROI");
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
                    Console.WriteLine("Error: "+ e.Message);
                    newLog.GenerarTXT("Excepción en Agregar RemC: " + e.Message);
                }
            }
        }
    }
}
