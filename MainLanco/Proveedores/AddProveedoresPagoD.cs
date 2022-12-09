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
    public class AddProveedoresPagoD
    {
        public static void ProveedorPagoD()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "ProveedorPagoD", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var ProveedorPagoD = new SAVProveedorPagoD()
                    {
                        Proveedor = value.Proveedor,
                        Empresa = value.Empresa,
                        Folio = value.Folio,
                        FolioPago = value.FolioPago,
                        Factura = value.Factura,
                        ProveedorNombre = value.ProveedorNombre,
                        Monto = value.Monto,
                        EmpresaCheq = value.EmpresaCheq,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta,
                        Estatus = value.Estatus,
                        Fecha = value.Fecha == null ? utileria.convHoraTiempo2(value.Fecha) : value.Fecha,//date
                        Giro = value.Giro,
                        Zona = value.Zona,
                        FechaFactura = value.FechaFactura == null ? utileria.convHoraTiempo2(value.FechaFactura) : value.FechaFactura,
                        Capturo = value.Capturo,
                        FechaAlta = value.FechaAlta == null ? utileria.convHoraTiempo2(value.FechaAlta) : value.FechaAlta,
                        FechaAltaHora = value.FechaAltaHora == null ? utileria.convHoraTiempo2(value.FechaAltaHora) : value.FechaAltaHora,
                        Obra = value.Obra,
                        Movimiento = value.Movimiento,
                        Concepto = value.Concepto,
                        Autorizacion = value.Autorizacion,
                        TipoCambio = value.TipoCambio,
                        NumCheque = value.NumCheque
                    };
                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaProveedorPagoD(ProveedorPagoD);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Proveedor = value.Proveedor

                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("ProveedorPagoD Actualizado" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("ProveedorPagoD registrado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedorPagoD", res).Wait();

                        Console.WriteLine("ProveedorPagoD registrado en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("ProveedorPagoD actualizado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedorPagoD", res).Wait();

                        Console.WriteLine("ProveedorPagoD actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar ProveedorPagoD: " + e.Message);
                }
            }
        }
    }
}
