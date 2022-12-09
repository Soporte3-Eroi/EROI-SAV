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
    public class AddFactC
    {
        public static void FactC()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;
            
            dynamic resToken = APIeRoi.Login(user, pass).Result;
            
            dynamic resApi = APIeRoi.CallApi("Get", "FactC", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                //var context = new pruebaEntities();
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    Console.WriteLine(value.FacturaCFD);
                    var FactC = new SAVFactC()
                    {
                        Factura = value.Factura,
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
                        Procesado = utileria.convBoolStr(value.Procesado),
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
                        ConRFC = utileria.convBoolStr(value.ConRFC),
                        FacturaConsolidada = utileria.convBoolStr(value.FacturaConsolidada),
                        Corrida = value.Corrida,
                        Hora = value.Hora == null ? value.Hora : utileria.convHoraTiempo2(value.Hora),
                        Obra = value.Obra,
                        LigaObra = utileria.convBoolStr(value.LigaObra),
                        ObraClave = value.ObraClave,
                        Impresiones = value.Impresiones,
                        CancelacionFecha = value.CancelacionFecha == null ? value.CancelacionFecha : utileria.convHoraTiempo2(value.CancelacionFecha),
                        CancelacionCapturo = value.CancelacionCapturo,
                        ConsignadoA = value.ConsignadoA,
                        ObraUbicacion = value.ObraUbicacion,
                        CancelacionMotivo = value.CancelacionMotivo,
                        Remision = value.Remision,
                        RemisionFecha = value.RemisionFecha == null ? value.RemisionFecha : utileria.convHoraTiempo2(value.RemisionFecha),
                        CancelacionSustituye = value.CancelacionSustituye,
                        Entregada = utileria.convBoolStr(value.Entregada),
                        AgendaMensajeria = value.AgendaMensajeria,
                        AgendaMensajeriaC = value.AgendaMensajeriaC,
                        NCargo = value.NCargo,
                        SerieCFD = value.SerieCFD,
                        FacturaCFD = utileria.convInt(value.FacturaCFD),
                        MetododePago = value.MetododePago,
                        NumCtaPago = value.NumCtaPago,
                        NCreditoCompleta = utileria.convBoolStr(value.NCreditoCompleta),
                        Plazo = value.Plazo,
                        FechaVencimiento = value.FechaVencimiento == null ? value.FechaVencimiento : utileria.convHoraTiempo2(value.FechaVencimiento),
                        FechaAltaHora = value.FechaAltaHora == null ? value.FechaAltaHora : utileria.convHoraTiempo2(value.FechaAltaHora),
                        UltimoCambioHora = value.UltimoCambioHora == null ? value.UltimoCambioHora : utileria.convHoraTiempo2(value.UltimoCambioHora),
                        CapturoCambio = value.CapturoCambio,
                        FormadePago = value.FormadePago,
                        UsoCFDI = value.UsoCFDI,
                        CFDIVersion = utileria.convInt(value.CFDIVersion),
                        UUID = value.UUID,
                        Parcialidades = value.Parcialidades,
                        FacturaSustituye = value.FacturaSustituye,
                        SolicitudCancelacionSAT = value.SolicitudCancelacionSAT,
                        EstatusCancelacionSAT = value.EstatusCancelacionSAT,
                        PreCancelacion = value.PreCancelacion == null ? value.PreCancelacion : utileria.convHoraTiempo2(value.PreCancelacion),
                        PreCancelacionCapturo = value.PreCancelacionCapturo,
                        IntContable = utileria.convBoolStr(value.IntContable),
                        IntContablePoliza = value.IntContablePoliza,
                        IntContablePolizaC = value.IntContablePolizaC,
                        RetencionIVA = value.RetencionIVA,
                        RetencionISR = value.RetencionISR,
                        CancelacionMotivoClave = value.CancelacionMotivoClave,
                        CancelacionUUIDRelacion = value.CancelacionUUIDRelacion,
                        DescuentoIncluido = value.DescuentoIncluido,
                        DescuentoIncluidoCIva = value.DescuentoIncluidoCIva,
                        SubTotalIva0 = value.SubTotalIva0,
                        SubTotalIva8 = value.SubTotalIva8,
                        SubTotalIva16 = value.SubTotalIva16

                        //Fecha = value.Fecha != null ? utileria.convHoraTiempo2(value.Fecha) : utileria.convHoraTiempo2("1899-12-30 01:00:00"), //SE PONDRA CUANDO ESTE NOT NULL
                        ////Fecha = value.Fecha != null ? utileria.convHoraTiempo2(value.Fecha) : null, //SE PONDRA CUANDO NO SEA NULL

                    };
                    //dynamic json = JsonConvert.SerializeObject(Cliente);

                    //var item = JsonConvert.DeserializeObject<SAVCliente>(json);
                    Console.WriteLine("******************************");
                    Business n = new Business();
                    int resp = n.agregaFactC(FactC);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Factura = value.Factura
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("FactC Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("FactC registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactC", res).Wait();

                        Console.WriteLine("FactC registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("FactC actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactC", res).Wait();

                        Console.WriteLine("FactC actualizado en eROI");
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
                    Console.WriteLine("Inner: "+ e.InnerException);
                    newLog.GenerarTXT("Excepción en Agregar FactC: " + e.Message);
                }
            }
        }
    }
}
