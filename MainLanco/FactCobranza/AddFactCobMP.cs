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
    public class AddFactCobMP
    {
        public static void FactCobMP()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;



            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "FactCobMP", new { }).Result;


            foreach (dynamic value in resApi.data)
            {
                try 
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var FactCobMP = new SAVFactCobMP()
                    {
   
                        CobroMultipleP = value.CobroMultiple,
                        Cliente = value.Cliente,
                        Monto = value.Monto,
                        FormaPago = value.FormaPago,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta,
                        Expira = value.Expira,
                        Autorizacion = value.Autorizacion,
                        Estatus = value.Estatus,
                        Fecha = value.Fecha == null ? utileria.convHoraTiempo2(value.Fecha) : value.Fecha,//
                        Hora = value.Hora == null ? utileria.convHoraTiempo2(value.Hora) : value.Hora,//
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
                        UltimoCambio = value.UltimoCambio == null ? utileria.convHoraTiempo2(value.UltimoCambio) : value.UltimoCambio,//
                        FacturaFechaDesde = value.FacturaFechaDesde == null ? utileria.convHoraTiempo2(value.FacturaFechaDesde) : value.FacturaFechaDesde,//
                        FacturaFechaHasta = value.FacturaFechaHasta == null ? utileria.convHoraTiempo2(value.FacturaFechaHasta) : value.FacturaFechaHasta,//
                        Impresiones = value.Impresiones,
                        Anticipo = value.Anticipo,
                        AnticipoFolio = value.AnticipoFolio,
                        AnticipoAcred = value.AnticipoAcred,
                        Ruta = value.Ruta,
                        Cobrador = value.Cobrador,
                        FechaAlta = value.FechaAlta == null ? utileria.convHoraTiempo2(value.FechaAlta) : value.FechaAlta,//
                        FechaAltaHora = value.FechaAltaHora == null ? utileria.convHoraTiempo2(value.FechaAltaHora) : value.FechaAltaHora,//
                        AcreditaCobro = value.AcreditaCobro,
                        AcreditaCorrida = value.AcreditaCorrida,
                        CFDIVersion = value.CFDIVersion,
                        UsoCFDI = value.UsoCFDI,
                        Obra = value.Obra,
                        RFC = value.RFC,
                    };
                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaFactCobMP(FactCobMP);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        CobroMultipleP = value.CobroMultipleP

                    };

                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("FactCobMP Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("FactCobMP registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCobMP", res).Wait();

                        Console.WriteLine("FactCobMP registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("FactCobMP actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCobMP", res).Wait();

                        Console.WriteLine("FactCobMP actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar FactCobMP: " + e.Message);
                }
            }
        }
    }
}
