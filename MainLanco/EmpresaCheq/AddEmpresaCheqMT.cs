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
    public class AddEmpresaCheqMT
    {
        public static void EmpresaCheqMT()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;



            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "EmpresaCheqMT", new { }).Result;


            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var EmpresaCheqMT = new SAVEmpresaCheqMT()
                    {
                        Empresa = value.Empresa,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta,
                        Tipo = value.Tipo,
                        FolioTemporal = value.FolioTemporal,
                        Proveedor = value.Proveedor,
                        ProveedorNombre = value.ProveedorNombre,
                        FolioAdeudo = value.FolioAdeudo,
                        FolioPagoAdeudo = value.FolioPagoAdeudo,
                        FolioPagoInterno = value.FolioPagoInterno,
                        Monto = value.Monto,
                        Fecha = value.Fecha == null ? utileria.convHoraTiempo2(value.Fecha) : value.Fecha,//
                        Capturo = value.Capturo,
                        FechaAlta = value.FechaAlta == null ? utileria.convHoraTiempo2(value.FechaAlta) : value.FechaAlta,//
                        FechaAltaHora = value.FechaAltaHora == null ? utileria.convHoraTiempo2(value.FechaAltaHora) : value.FechaAltaHora,//
                        Concepto = value.Concepto,
                        Autorizacion = value.Autorizacion,
                        TipoCambio = value.TipoCambio,
                        Estatus = value.Estatus,
                        Detalle = value.Detalle,
                        Factura = value.Factura,
                        AdeudoTotal = value.AdeudoTotal,
                        AdeudoSaldo = value.AdeudoSaldo,
                        ChequesaNombre = value.ChequesaNombre,
                        NumCheque = value.NumCheque,
                        AdeudoNCredito = value.AdeudoNCredito,
                        Impresiones = value.Impresiones,
                        TipoPago = value.TipoPago,
                        PorComprobar = value.PorComprobar,
                        FolioPagoInterno2 = value.FolioPagoInterno2,
                        FormaPago = value.FormaPago,
                        Traspaso = value.Traspaso,
                        FolioPersonalGasto = value.FolioPersonalGasto,
                        ProveedorTipoPago = value.ProveedorTipoPago
                    };

                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaEmpresaCheqMT(EmpresaCheqMT);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        FolioTemporal = value.FolioTemporal
                    };

                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("EmpresaCheqMT Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("EmpresaCheqMT registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaEmpresaCheqMT", res).Wait();

                        Console.WriteLine("EmpresaCheqMT registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("EmpresaCheqMT actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaEmpresaCheqMT", res).Wait();

                        Console.WriteLine("EmpresaCheqMT actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar EmpresaCheqMT: " + e.Message);
                }
            }
        }
    }
}
