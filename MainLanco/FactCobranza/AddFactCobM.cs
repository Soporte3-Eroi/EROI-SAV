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
    public class AddFactCobM
    {
        public static void FactCobM()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "FactCobM", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var FactCobM = new SAVFactCobM()
                    {
                        CobroMultiple = Convert.ToInt32(value.CobroMultiple),
                        Cliente = value.Cliente,
                        Monto = value.Monto,
                        FormadePago = value.FormadePago,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta,
                        Expira = value.Expira,
                        Autorizacion = value.Autorizacion,
                        Estatus = value.Estatus,
                        Fecha = value.Fecha == null ? utileria.convHoraTiempo2(value.Fecha) : value.Fecha,//date
                        Hora = value.Hora == null ? utileria.convHoraTiempo2(value.Hora) : value.Hora,//date
                        TipoCambio = value.TipoCambio,
                        CuentaNombre = value.CuentaNombre,
                        BancoDeposito = value.BancoDeposito,
                        Referencia = value.Referencia,
                        BancoCuenta = value.BancoCuenta,
                        Capturo = value.Capturo,
                        Moneda = value.Moneda,
                        Facturas = value.Facturas,
                        Comentarios = value.Comentarios,
                        SubTotal = value.SubTotal,
                        IVA = value.IVA,
                        Total = value.Total,
                        ClienteNombre = value.ClienteNombre,
                        CapturoCambio = value.CapturoCambio,
                        UltimoCambio = value.UltimoCambio,
                        FacturaFechaDesde = value.FacturaFechaDesde,
                        FacturaFechaHasta = value.FacturaFechaHasta,
                        Impresiones = value.Impresiones,
                        Anticipo = value.Anticipo,
                        AnticipoFolio = value.AnticipoFolio,
                        AnticipoAcred = value.AnticipoAcred,
                        CobroMultipleP = value.CobroMultipleP,
                        Serie = value.Serie,
                        SerieCFD = value.SerieCFD,
                        CobroCFD = value.CobroCFD,
                        CFDIVersion = value.CFDIVersion,
                        UUID = value.UUID,
                        UsoCFDI = value.UsoCFDI,
                        FormaPago = value.FormaPago,
                        Tipo = value.Tipo,
                        CodigoSAT = value.CodigoSAT,
                        UnidadSAT = value.UnidadSAT,
                        TotalLetra = value.TotalLetra,
                        FechaAlta = value.FechaAlta == null ? utileria.convHoraTiempo2(value.FechaAlta) : value.FechaAlta,//date
                        Obra = value.Obra,
                        RFC = value.RFC,
                        NumAsientos = value.NumAsientos,
                        Cargos = value.Cargos,
                        Abonos = value.Abonos,
                        IntContable = value.IntContable,
                        IntContableFecha = value.IntContableFecha == null ? utileria.convHoraTiempo2(value.IntContableFecha) : value.IntContableFecha,//DATE
                        IntContableHora = value.IntContableHora == null ? utileria.convHoraTiempo2(value.IntContableHora) : value.IntContableHora,//date
                        IntContableCapturo = value.IntContableCapturo,
                        IntContablePoliza = value.IntContablePoliza,
                        IntContableTotal = value.IntContableTotal,
                        CancelacionMotivoClave = value.CancelacionMotivoClave,
                        CancelacionUUIDRelacion = value.CancelacionUUIDRelacion,
                        CobroMultipleSustituye = value.CobroMultipleSustituye,
                        CancelacionFecha = value.CancelacionFecha == null ? utileria.convHoraTiempo2(value.CancelacionFecha) : value.CancelacionFecha,//DATE
                        CancelacionCapturo = value.CancelacionCapturo,
                        CancelacionMotivo = value.CancelacionMotivo,
                        CancelacionMotivo2 = value.CancelacionMotivo2
                    };
                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaFactCobM(FactCobM);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        CobroMultiple = value.CobroMultiple

                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("FactCobM Actualizado" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("FactCobM registrado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCobM", res).Wait();

                        Console.WriteLine("FactCobM registrado en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("FactCobM actualizado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCobM", res).Wait();

                        Console.WriteLine("FactCobM actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar FactCobM: " + e.Message);
                }
            }
        }
    }
}
