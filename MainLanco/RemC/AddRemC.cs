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
                //var context = new pruebaEntities();
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();
                    //string newId = "";
                    //if (dto)
                    //{
                    //    var idRemC = db.SAVRemC.First();
                    //    newId = (idRemC.SAVRemC + 1).ToString();

                    //    //Formatear id de 9101 a 009101
                    //    for (int i = 0; newId.Length <= 5; i++)
                    //    {
                    //        newId = "0" + newId;
                    //    }
                    //}
                    //else
                    //{
                    //    var idRemC = db.SAVRemC.First();
                    //    newId = (idRemC.Cliente).ToString();

                    //    //Formatear id de 9101 a 009101
                    //    for (int i = 0; newId.Length <= 5; i++)
                    //    {
                    //        newId = "0" + newId;
                    //    }
                    //}


                    var RemC = new SAVRemC()
                    {
                        Remision = value.Remision,
                        Cliente = value.Cliente,
                        FacturarA = value.FacturarA,
                        Fecha = value.Fecha,
                        TipoCambio = value.TipoCambio,
                        PorcIva = value.PorcIva,
                        Capturo = value.Capturo,
                        Comentario = value.Comentario,
                        SubTotal = value.SubTotal,
                        IVA = value.IVA,
                        Total = value.Total,
                        Procesado = value.Procesado,
                        Estatus = value.Estatus,
                        Pagado = value.Pagado,
                        Saldo = value.Saldo,
                        Partidas = value.Partidas,
                        FechaAlta = value.FechaAlta,
                        UltimoCambio = value.UltimoCambio,
                        TotalLetra = value.TotalLetra,
                        Tipo = value.Tipo,
                        NCredito = value.NCredito,
                        Vendedor = value.Vendedor,
                        Giro = value.Giro,
                        Zona = value.Zona,
                        RFC = value.RFC,
                        ConRFC = value.ConRFC,
                        FacturaConsolidada = value.FacturaConsolidada,
                        Corrida = value.Corrida,
                        Hora = value.Hora,
                        Obra = value.Obra,
                        LigaObra = value.LigaObra,
                        ObraClave = value.ObraClave,
                        Impresiones = value.Impresiones,
                        CancelacionFecha = value.CancelacionFecha,
                        CancelacionCapturo = value.CancelacionCapturo,
                        ConsignadoA = value.ConsignadoA,
                        ObraUbicacion = value.ObraUbicacion,
                        CancelacionMotivo = value.CancelacionMotivo,
                        Facturado = value.Facturado,
                        FacturadoFecha = value.FacturadoFecha,
                        FacturadoFactura = value.FacturadoFactura,
                        CancelacionSustituye = value.CancelacionSustituye,
                        Aux1 = value.Aux1,
                        Aux2 = value.Aux2,
                        AgendaMensajeria = value.AgendaMensajeria,
                        MetododePago = value.MetododePago,
                        NumCtaPago = value.NumCtaPago,
                        FacturadoFechaOriginal = value.FacturadoFechaOriginal,
                        FacturadoFacturaOriginal = value.FacturadoFacturaOriginal,
                        CapturoCambio = value.CapturoCambio,
                        FormadePago = value.FormadePago,
                        UsoCFDI = value.UsoCFDI,
                        RetencionIVA = value.RetencionIVA,
                        RetencionISR = value.RetencionISR,
                        FacturaSustituye = value.FacturaSustituye

                    };

                    //Console.WriteLine("Paso el objeto");
                    //dynamic json = JsonConvert.SerializeObject(Cliente);

                    //var item = JsonConvert.DeserializeObject<SAVCliente>(json);
                    Business n = new Business();
                    int resp = n.agregaRemC(RemC);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Clave = value.Remision,
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
                    newLog.GenerarTXT("Excepción en Agregar RemC: " + e.Message);
                }
            }
        }
    }
}
