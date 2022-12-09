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
    public class AddFactCob
    {
        public static void FactCob()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "FactCob", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var FactCob = new SAVFactCob()
                    {
                        Factura = value.Factura,
                        Cobro = value.Cobro,
                        Cliente = value.Cliente,
                        Monto = value.Monto,
                        FormaPago = value.FormaPago,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta,
                        Expira = value.Expira,
                        Autorizacion = value.Autorizacion,
                        Estatus = value.Estatus,
                        Fecha = value.Fecha == null ? utileria.convHoraTiempo2(value.Fecha) : value.Fecha,//date
                        TipoCambio = value.TipoCambio,
                        CuentaNombre = value.CuentaNombre,
                        Giro = value.Giro,
                        Zona = value.Zona,
                        FechaFactura = value.FechaFactura == null ? utileria.convHoraTiempo2(value.FechaFactura) : value.FechaFactura ,//date
                        Vendedor = value.Vendedor,
                        Corrida = value.Corrida,
                        BancoDeposito = value.BancoDeposito,
                        Capturo = value.Capturo,
                        Hora = value.Hora == null ? utileria.convHoraTiempo2(value.Hora) : value.Hora,//date
                        HoraFactura = value.HoraFactura == null ? utileria.convHoraTiempo2(value.HoraFactura) : value.HoraFactura,//date
                        PorcIVA = value.PorcIVA,
                        Obra = value.Obra,
                        Movimiento = value.Movimiento,
                        Referencia = value.Referencia,
                        Concepto = value.Concepto,
                        BancoCuenta = value.BancoCuenta,
                        Remision = value.Remision,
                        RemisionFecha = value.RemisionFecha == null ? utileria.convHoraTiempo2(value.RemisionFecha) : value.RemisionFecha,//date
                        CobroMultiple = value.CobroMultiple,
                        CapturoFecha = value.CapturoFecha == null ? utileria.convHoraTiempo2(value.CapturoFecha) : value.CapturoFecha,//date
                        CobroMultipleP = value.CobroMultipleP,
                        SerieCFD = value.SerieCFD,
                        FacturaCFD = value.FacturaCFD,
                        Recordatorio = value.Recordatorio,
                        Parcialidad = value.Parcialidad,
                        SaldoAnterior = value.SaldoAnterior,
                        SaldoPendiente = value.SaldoPendiente,
                        RFC = value.RFC
                    };
                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaFactCob(FactCob);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Factura = value.Factura

                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("FactCob Actualizado" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("FactCob registrado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCob", res).Wait();

                        Console.WriteLine("FactCob registrado en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("FactCob actualizado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCob", res).Wait();

                        Console.WriteLine("FactCob actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar FactCob: " + e.Message);
                }
            }
        }
    }
}
