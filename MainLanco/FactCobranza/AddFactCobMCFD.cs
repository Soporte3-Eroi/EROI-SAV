using DatosLAnco;
using MainLanco.Conexion;
using MainLanco.eRoi;
using MainLanco.Utilerias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco
{
    public class AddFactCobMCFD
    {
        public static void FactCobMCFD()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "FactCobMCFD", new { }).Result;


            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();


                    var FactCobMCFD = new SAVFactCobMCFD()
                    {
                        Serie = value.Serie,
                        CobroMultiple = value.CobroMultiple,
                        SerieCFD = value.SerieCFD,
                        CobroCFD = value.CobroCFD,
                        NombreCFD = value.NombreCFD,
                        CFDCancelado = value.CFDCancelado,
                        CFDSelloDigital = value.CFDSelloDigital,
                        CFDXML = value.CFDXML,
                        CFDCadenaOriginal = value.CFDCadenaOriginal,
                        CFDCertificado = value.CFDCertificado,
                        AprobacionNumero = value.AprobacionNumero,
                        AprobacionAge = value.AprobacionAge,
                        CobroTotal = value.CobroTotal,
                        Capturo = value.Capturo,
                        FechaAlta = value.FechaAlta == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta),//
                        FechaAltaHora = value.FechaAltaHora == null ? value.FechaAltaHora : utileria.convHoraTiempo2(value.FechaAltaHora),//
                        CFDCanceladoFecha = value.CFDCanceladoFecha == null ? value.CFDCanceladoFecha : utileria.convHoraTiempo2(value.CFDCanceladoFecha),//
                        CFDCanceladoHora = value.CFDCanceladoHora == null ? value.CFDCanceladoHora : utileria.convHoraTiempo2(value.CFDCanceladoHora),//
                        EnvioFTP = value.EnvioFTP,
                        CFDCertificadoSAT = value.CFDCertificadoSAT,
                        CFDSelloDigitalSAT = value.CFDSelloDigitalSAT,
                        TimbradoFolioFiscal = value.TimbradoFolioFiscal,
                        TimbradoFechaHora = value.TimbradoFechaHora,
                        CobroIva = value.CobroIva,
                        TimbradoCodigoQR = value.TimbradoCodigoQR,
                        CFDIVersion = value.CFDIVersion
                    };
                    Console.WriteLine("*******************************");
                    Business n = new Business();
                    int resp = n.agregaFactCobMCFD(FactCobMCFD);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        CobroMultiple = value.CobroMultiple
       
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("FactCobMCFD Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("FactCobMCFD registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCobMCFD", res).Wait();

                        Console.WriteLine("FactCobMCFD registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("FactCobMCFD actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCobMCFD", res).Wait();

                        Console.WriteLine("FactCobMCFD actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar FactCobMCFD: " + e.Message);
                }
            }
        }
    }
}
