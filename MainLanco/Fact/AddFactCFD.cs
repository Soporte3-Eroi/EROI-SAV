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
    public class AddFactCFD
    {
        public static void FactCFD()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;

            dynamic resApi = APIeRoi.CallApi("Get", "FactCFD", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                //var context = new pruebaEntities();
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();


                    var FactCFD = new SAVFactCFD()
                    {
                        Factura = value.Factura,
                        SerieCFD = value.SerieCFD,
                        FacturaCFD = value.FacturaCFD,
                        NombreCFD = value.NombreCFD,
                        CFDCancelado = value.CFDCancelado,
                        CFDSelloDigital = value.CFDSelloDigital,
                        CFDXML = value.CFDXML,
                        CFDCadenaOriginal = value.CFDCadenaOriginal,
                        CFDCertificado = value.CFDCertificado,
                        AprobacionNumero = value.AprobacionNumero,
                        AprobacionAge = value.AprobacionAge,
                        FacturaTotal = value.FacturaTotal,
                        FacturaIva = value.FacturaIva,
                        Capturo = value.Capturo,
                        FechaAlta = value.FechaAlta,
                        FechaAltaHora = value.FechaAltaHora,
                        CFDCanceladoFecha = value.CFDCanceladoFecha,
                        CFDCanceladoHora = value.CFDCanceladoHora,
                        RFC = value.RFC,
                        EnvioFTP = value.EnvioFTP,
                        CFDCertificadoSAT = value.CFDCertificadoSAT,
                        CFDSelloDigitalSAT = value.CFDSelloDigitalSAT,
                        TimbradoFolioFiscal = value.TimbradoFolioFiscal,
                        TimbradoFechaHora = value.TimbradoFechaHora,
                        TimbradoCodigoQR = value.TimbradoCodigoQR,
                        CFDIVersion = value.CFDIVersion,

                };

                    //Console.WriteLine("Paso el objeto");
                    //dynamic json = JsonConvert.SerializeObject(Cliente);

                    //var item = JsonConvert.DeserializeObject<SAVCliente>(json);
                    Business n = new Business();
                    int resp = n.agregaFactCFD(FactCFD);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Clave = value.Remision
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("FactCFD Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("FactCFD registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCFD", res).Wait();

                        Console.WriteLine("FactCFD registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("FactCFD actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaFactCFD", res).Wait();

                        Console.WriteLine("FactCFD actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar FactCFD: " + e.Message);
                }
            }
        }
    }
}
