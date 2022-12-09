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
    public class AddObraServicioProg
    {
        public static void SAVObraServicioProg()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

           
            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "ObraServicioProg", new { }).Result;

           

            foreach (dynamic value in resApi.data)
            {
                //var context = new pruebaEntities();
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();


                    var ObraServicioProg = new SAVObraServicioProg()
                    {
                        Obra = value.Obra,
                        Folio = value.Folio,
                        Tipo = value.Tipo,
                        Clave = value.Clave,
                        Fecha = value.Fecha,
                        Cliente = value.Cliente,
                        Descripcion = value.Descripcion,
                        Monto = value.Monto,
                        Moneda = value.Moneda,
                        Descuento = value.Descuento == "1" ? true : false,
                        Comentario = value.Comentario ,
                        Cantidad = value.Cantidad,
                        DescripcionAdicional = value.DescripcionAdicional,
                        PorcIva = value.PorcIva,
                        Desc1 = value.Desc1,
                        Unidad = value.Unidad,
                        Capturo = value.Capturo,
                        FechaAlta = value.FechaAlta == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta),
                        FechaAltaHora = value.FechaAltaHora == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta),
                        Cobrado = value.Cobrado == "1" ? true : false,
                        CobradoTipo = value.CobradoTipo,
                        CobradoNumero = value.CobradoNumero,
                        CobradoFecha = value.CobradoFecha == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta),
                        CobradoCapturo = value.CobradoCapturo,
                        CapturoCambio = value.CapturoCambio,
                        UltimoCambio = value.UltimoCambio == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta),
                        UltimoCambioHora = value.UltimoCambioHora == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta),
                        Consolida = value.Consolida == "1" ? true : false,
                        Remisiona = value.Remisiona == "1" ? true : false,
                        Consolidacion = value.Consolidacion == "1" ? true : false,
                        Agrupacion = value.Agrupacion == "1" ? true : false,
                        Referencia = value.Referencia,
                        Muestreador = value.Muestreador,
                        MuestreadorNombre = value.MuestreadorNombre,
                        Seleccion = value.Seleccion == "1" ? true : false,
                        CobroS = value.CobroS,
                        CobroSFecha = value.CobroSFecha == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta),
                        CobroSFormaPago = value.CobroSFormaPago,
                        CobroSBanco = value.CobroSBanco,
                        CobroSCuenta = value.CobroSCuenta,
                        CobroSBancoDeposito = value.CobroSBancoDeposito,
                        CobroSCapturo = value.CobroSCapturo,
                        FolioVisita = value.FolioVisita,
                        Origen = value.Origen,
                        Cancelado = value.Cancelado == "1" ? true : false,
                        CanceladoFecha = value.CanceladoFecha == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta),
                        CanceladoCapturo = value.CanceladoCapturo,
                        PorcIvaRetencion = value.PorcIvaRetencion,
                        PorcISRRetencion = value.PorcISRRetencion

                };

                    Console.WriteLine("**********************************");
                    Business n = new Business();
                    int resp = n.agregaObraServicioProg(ObraServicioProg);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                   
                        Obra = value.Obra,
                        Folio = value.Folio
                        
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("ObraServicioProg Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("ObraServicioProg registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaObraServicioProg", res).Wait();

                        Console.WriteLine("ObraServicioProg registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("ObraServicioProg actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaObraServicioProg", res).Wait();

                        Console.WriteLine("ObraServicioProg actualizado en eROI");
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
                    Console.WriteLine("Error: "+e.Message);
                    newLog.GenerarTXT("Excepción en Agregar ObraServicioProg: " + e.Message);
                }
            }
        }
    }
}
