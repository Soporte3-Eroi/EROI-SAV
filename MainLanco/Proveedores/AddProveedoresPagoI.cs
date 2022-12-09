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
    public class AddProveedoresPagoI
    {
        public static void ProveedorPagoI()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "ProveedorPagoI", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var ProveedorPagoI = new SAVProveedorPagoI()
                    {
                        Proveedor = value.Proveedor,
                        Empresa = value.Empresa,
                        FolioPagoInterno = value.FolioPagoInterno,
                        ProveedorNombre = value.ProveedorNombre,
                        Concepto = value.Concepto,
                        Detalle = value.Detalle,
                        Total = value.Total,
                        Fecha = value.Fecha == null ? utileria.convHoraTiempo2(value.Fecha) : value.Fecha,
                        Estatus = value.Estatus,
                        Capturo = value.Capturo,
                        FechaAlta = value.FechaAlta == null ? utileria.convHoraTiempo2(value.FechaAlta) : value.FechaAlta,
                        FechaAltaHora = value.FechaAltaHora == null ? utileria.convHoraTiempo2(value.FechaAltaHora) : value.FechaAltaHora,
                        Procesado = value.Procesado,
                        Autorizacion = value.Autorizacion,
                        TipoCambio = value.TipoCambio,
                        EmpresaCheq = value.EmpresaCheq,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta,
                        NumCheque = value.NumCheque,
                        PorComprobar = value.PorComprobar,
                        FolioPagoInterno2 = value.FolioPagoInterno2
                    };
                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaProveedorPagoI(ProveedorPagoI);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Proveedor = value.Proveedor

                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("ProveedorPagoI Actualizado" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("ProveedorPagoI registrado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedorPagoI", res).Wait();

                        Console.WriteLine("ProveedorPagoI registrado en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("ProveedorPagoI actualizado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedorPagoI", res).Wait();

                        Console.WriteLine("ProveedorPagoI actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar ProveedorPagoI: " + e.Message);
                }
            }
        }
    }
}
