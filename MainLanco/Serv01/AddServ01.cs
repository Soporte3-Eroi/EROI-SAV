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
    public class AddServ01
    {
        public static void Serv01()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "Serv01", new { }).Result;

            foreach(dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now;
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var Serv01 = new SAVServ01()
                    {
                        Reporte = value.Reporte,
                        Obra = value.Obra,
                        Fecha = value.Fecha == null ? value.Fecha : utileria.convHoraTiempo2(value.Fecha), //Data time
                        ReporteFecha = value.ReporteFecha,
                        ObraClave = value.ObraClave,
                        ObraNombre = value.ObraNombre,
                        Cliente = value.Cliente,
                        ClienteNombre = value.ClienteNombre,
                        Premezcladora = value.Premezcladora,
                        PremezcladoraNombre = value.PremezcladoraNombre,
                        Muestreador = value.Muestreador,
                        MuestreadorNombre = value.MuestreadorNombre,
                        Resistencia = value.Resistencia,
                        Tipo = value.Tipo,
                        Calidad = value.Calidad,
                        Agregado = value.Agregado,
                        Revenimiento1 = value.Revenimiento1,
                        Revenimiento2 = value.Revenimiento2,
                        Volumen = value.Volumen,
                        Observaciones = value.Observaciones,
                        Capturo = value.Capturo,
                        FechaAlta = value.FechaAlta == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta), //date time
                        FechaAltaHora = value.FechaAltaHora == null ? value.FechaAltaHora : utileria.convHoraTiempo2(value.FechaAltaHora), //datetime
                        CapturoCambio = value.CapturoCambio,
                        UltimoCambio = value.UltimoCambio == null ? value.UltimoCambio : utileria.convHoraTiempo2(value.UltimoCambio), //date time
                        UltimoCambioHora = value.UltimoCambioHora == null ? value.UltimoCambioHora : utileria.convHoraTiempo2(value.UltimoCambioHora), //datetime
                        DiasCilindro1 = value.DiasCilindro1,
                        DiasCilindro2 = value.DiasCilindro2,
                        Planta = value.Planta,
                        PlantaNombre = value.PlantaNombre,
                        ObraServicio = Convert.ToInt32(value.ObraServicio),
                        Impresiones = value.Impresiones,
                        FolioVisita = Convert.ToInt32(value.FolioVisita),
                        DiasCilindro5 = value.DiasCilindro5,
                        DiasCilindro6 = value.DiasCilindro6,
                        TipoNombre = value.TipoNombre,
                        CapturaWeb = value.CapturaWeb == "1" ? true : false,
                        AgendaMensajeria = value.AgendaMensajeria,
                        Temperatura = value.Temperatura,
                        Informe = value.Informe == "" ? null : value.Informe

                    };
                    Console.WriteLine("************************************");

                    Business n = new Business();
                    int resp = n.agregaServ01(Serv01);

                    //Se actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Reporte = value.Reporte
                    };


                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("Serv01 actualizado" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("Serv01 registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaServ01", res).Wait();

                        Console.WriteLine("Serv01 registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("Serv01 actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaServ01", res).Wait();

                        Console.WriteLine("Serv01 actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar Serv01: " + e.Message);
                }
            }
        }
    }
}
