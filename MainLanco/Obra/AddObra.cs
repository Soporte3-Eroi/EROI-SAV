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
    public class AddObra
    {
        public static void Obra()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "Obras", new { }).Result;


            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now;
                    dbModel db = new dbModel();
                    
                    Standars utileria = new Standars();

                    var Obra = new SAVObra()
                    {
                        Obra = value.Clave,
                        Nombre = value.Nombre,
                        ObraClave = value.ObraClave,
                        Direccion = value.Direccion,
                        Colonia = value.Colonia,
                        CP = value.CP,
                        Ciudad = value.Ciudad,
                        Estado = value.Estado,
                        Pais = value.Pais == "" ? "NA" : value.Pais,
                        Telefono = value.Telefono,
                        EncargadoObra = value.EncargadoObra,
                        EncargadoObraTel = value.EncargadoObraTel,
                        EncargadoPago = value.EncargadoPago,
                        EncargadoPagoTel = value.EncargadoPagoTel,
                        DiasRevision = value.DiasRevision,
                        HoraRevision = value.HoraRevision,
                        DiasCobro = value.DiasCobro,
                        HorasCobro = value.HorasCobro,
                        ReportarInc = value.ReportarInc,
                        ReportarIncTel = value.ReportarIncTel,
                        NombreReporte = value.NombreReporte,
                        ConsignadoA = value.ConsignadoA,
                        FacturarA = value.FacturarA,
                        Cliente = value.Cliente, // == null ? "nan" : value.Cliente
                        ClienteNombre = value.ClienteNombre,
                        NumCopias = Convert.ToInt16(value.NumCopias),
                        FechaAlta = utileria.convHoraTiempo2(value.FechaAlta),
                        FechaAltaHora = utileria.convHoraTiempo2(value.FechaAltaHora),
                        Capturo = value.Capturo,
                        CapturoCambio = value.CapturoCambio,
                        UltimoCambio = utileria.convHoraTiempo2(value.UltimoCambio),
                        UltimoCambioHora = utileria.convHoraTiempo2(value.UltimoCambioHora),
                        CodigoArea = value.CodigoArea,
                        Servicio = Convert.ToInt32(value.Servicio),
                        Muestra = Convert.ToInt32(value.Muestra),
                        Revenimiento = Convert.ToInt32(value.Revenimiento),
                        RFC = value.RFC,
                        Giro = value.Giro,
                        Zona = value.Zona,
                        Familia = value.Familia,
                        Delegacion = value.Delegacion, // == null ? "nan" : value.Delegacion
                        Descuento = Convert.ToDecimal(value.Descuento),
                        Activa = utileria.convBoolStr(value.Activa),
                        UltimaRemision = utileria.convHoraTiempo2(value.UltimaRemision),
                        UltimaFactura = utileria.convHoraTiempo2(value.UltimaFactura),
                        Serv01Secuencia = Convert.ToInt32(value.Serv01Secuencia),
                        FolioServicioProg = Convert.ToInt32(value.FolioServicioProg),
                        Saldo = utileria.convDecimal(value.Saldo),
                        NC = utileria.convDecimal(value.NC),
                        Email = value.Email,
                        SaldoAnterior = utileria.convDecimal(value.SaldoAnterior),
                        SaldoLimitePago = utileria.convHoraTiempo2(value.SaldoLimitePago),
                        GeneroECFecha = utileria.convHoraTiempo2(value.GeneroECFecha),
                        GeneroECCapturo = value.GeneroECCapturo,
                        EnvioEmail = utileria.convBoolStr(value.EnvioEmail),
                        GeneroECDesde = utileria.convHoraTiempo2(value.GeneroECDesde),
                        GeneroECHasta = utileria.convHoraTiempo2(value.GeneroECHasta),

                        HtmlMail = utileria.convBoolStr(value.HtmlMail),
                        UltimoMov = utileria.convHoraTiempo2(value.UltimoMov),
                        Aux1 = value.Aux1,
                        Aux2 = value.Aux2,
                        Ubicacion = value.Ubicacion,
                        Horario = value.Horario,
                        HorarioDesde = utileria.convHoraTiempo3(value.HorarioDesde),
                        HorarioHasta = utileria.convHoraTiempo3(value.HorarioHasta),
                        HorarioSabado = value.HorarioSabado,
                        HorarioSabadoDesde = utileria.convHoraTiempo3(value.HorarioSabadoDesde),
                        HorarioSabadoHasta = utileria.convHoraTiempo3(value.HorarioSabadoHasta),
                        HorarioDomingo = value.HorarioDomingo,
                        HorarioDomingoDesde = utileria.convHoraTiempo3(value.HorarioDomingoDesde),
                        HorarioDomingoHasta = utileria.convHoraTiempo3(value.HorarioDomingoHasta),
                        UltimoCobro = utileria.convHoraTiempo2(value.UltimoCobro),
                        Reg1 = utileria.convBoolStr(value.Reg1),
                        Serv01Copias = Convert.ToInt16(value.Serv01Copias),
                        Serv02Secuencia = Convert.ToInt32(value.Serv02Secuencia),
                        Viga = Convert.ToInt32(value.Viga),
                        Mortero = Convert.ToInt32(value.Mortero),
                        Enviado = Convert.ToInt32(value.Enviado),
                        Serv03Ensaye = Convert.ToInt32(value.Serv03Ensaye),
                        Serv04Ensaye = Convert.ToInt32(value.Serv04Ensaye),
                        Pasaje = Convert.ToDecimal(value.Pasaje),
                        Corazon = Convert.ToInt32(value.Corazon),
                        Arteza = Convert.ToInt32(value.Arteza),
                        Ruta = value.Ruta,
                        RevisionFacturas = value.RevisionFacturas,
                        RevisionPeriodicidad = value.RevisionPeriodicidad,
                        RevisionPeriodicidadDia1 = value.RevisionPeriodicidadDia1,
                        RevisionPeriodicidadDia2 = value.RevisionPeriodicidadDia2,
                        RevisionHorario = value.RevisionHorario,
                        ReportesEntrega = value.ReportesEntrega,
                        ReportesPeriodicidad = value.ReportesPeriodicidad,
                        ReportesPeriodicidadDia1 = value.ReportesPeriodicidadDia1,
                        ReportesPeriodicidadDia2 = value.ReportesPeriodicidadDia2,
                        ReportesHorario = value.ReportesHorario,
                        Presupuesto = value.Presupuesto,
                        PresupuestoPeriodicidad = value.PresupuestoPeriodicidad,
                        PresupuestoPeriodicidadDia1 = value.PresupuestoPeriodicidadDia1,
                        PresupuestoPeriodicidadDia2 = value.PresupuestoPeriodicidadDia2,
                        PresupuestoHorario = value.PresupuestoHorario,
                        Cobranza = value.Cobranza,
                        CobranzaPeriodicidad = value.CobranzaPeriodicidad,
                        CobranzaPeriodicidadDia1 = value.CobranzaPeriodicidadDia1,
                        CobranzaPeriodicidadDia2 = value.CobranzaPeriodicidadDia2,
                        CobranzaHorario = value.CobranzaHorario,
                        CobranzaPlazo = Convert.ToInt16(value.CobranzaPlazo),
                        CobranzaActiva = utileria.convBoolStr(value.CobranzaActiva),
                        PVCobroSeparado = utileria.convBoolStr(value.PVCobroSeparado),
                        TipoCobro = value.TipoCobro, // == "" ? "NAN" : value.TipoCobro
                        ConcretoC = Convert.ToInt16(value.ConcretoC),
                        VigaC = Convert.ToInt16(value.VigaC),
                        MorteroC = Convert.ToInt16(value.MorteroC),
                        CorazonC = Convert.ToInt16(value.CorazonC),
                        ArtezaC = Convert.ToInt16(value.ArtezaC),
                        Cerrada = utileria.convBoolStr(value.Cerrada),
                        IgualaMensualDesde = utileria.convHoraTiempo2(value.IgualaMensualDesde),
                        IgualaMensualHasta = utileria.convHoraTiempo2(value.IgualaMensualHasta),
                        IgualaMensualUltMov = utileria.convHoraTiempo2(value.IgualaMensualUltMov),
                        IgualaMensualUltCorrida = Convert.ToInt32(value.IgualaMensualUltCorrida),
                        IgualaSemanalCobroMuestras = utileria.convBoolStr(value.IgualaSemanalCobroMuestras),
                        Horario2 = value.Horario2,
                        HorarioDesde2 = utileria.convHoraTiempo3(value.HorarioDesde2),
                        HorarioHasta2 = utileria.convHoraTiempo3(value.HorarioHasta2),
                        HorarioSabado2 = value.HorarioSabado2,
                        HorarioSabadoDesde2 = utileria.convHoraTiempo3(value.HorarioSabadoDesde2),
                        HorarioSabadoHasta2 = utileria.convHoraTiempo3(value.HorarioSabadoHasta2),
                        HorarioDomingo2 = value.HorarioDomingo2,
                        HorarioDomingoDesde2 = utileria.convHoraTiempo3(value.HorarioDomingoDesde2),
                        HorarioDomingoHasta2 = utileria.convHoraTiempo3(value.HorarioDomingoHasta2),
                        DescuentoAutomatico = utileria.convBoolStr(value.DescuentoAutomatico),
                        ServiciosPendRemisionar = Convert.ToDecimal(value.ServiciosPendRemisionar),
                        Observaciones = value.Observaciones,
                        DiasDesc = value.DiasDesc,
                        FacturaElectronica = utileria.convBoolStr(value.FacturaElectronica),
                        NombreF = value.NombreF,
                        DireccionF = value.DireccionF,
                        NumExteriorF = value.NumExteriorF,
                        NumInteriorF = value.NumInteriorF,
                        ColoniaF = value.ColoniaF,
                        DelegacionF = value.DelegacionF,
                        CPF = value.CPF,
                        CiudadF = value.CiudadF,
                        EstadoF = value.EstadoF,
                        PaisF = value.PaisF,
                        EmailF = value.EmailF,
                        CalaCobroSeparado = utileria.convBoolStr(value.CalaCobroSeparado),
                        MetododePago = value.MetododePago,
                        NumCtaPago = value.NumCtaPago,
                        EmailC = value.EmailC,
                        Aux3 = value.Aux3,
                        Aux4 = value.Aux4,
                        LimiteCredito = Convert.ToDecimal(value.LimiteCredito),
                        OCFecha = utileria.convHoraTiempo2(value.OCFecha),
                        OCObservaciones = value.OCObservaciones,
                        FormadePago = value.FormadePago,
                        UsoCFDI = value.UsoCFDI,
                        AuxMP = "NA",
                        ServEspSecuencia = Convert.ToInt32(value.ServEspSecuencia),
                        ServEsp = value.ServEsp,
                        SerieF = value.SerieF,
                        RegimenFiscalClave = value.RegimenFiscalClave



                    };
                    Console.WriteLine("/ **************************************** /");
                    Business n = new Business();
                    int resp = n.agregaObra(Obra);

                    //Actuliza en Erois
                    var res = new
                    {
                        Res = "OK",
                        Clave = value.Clave,
                        ClaveLanco= value.Clave
                    };

                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("Obra Actualizada" + response);
                    if(resp == 1)
                    {
                        Console.WriteLine("Obra registrada en DB");
                        Console.WriteLine("---------------------");

                        APIeRoi.CallApi("POST", "ActualizaObras", res).Wait();

                        Console.WriteLine("Obra registrada eb eRoi");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("Obra actualizada en DB");
                        Console.WriteLine("----------------------");

                        APIeRoi.CallApi("POST", "ActualizaObras", res).Wait();

                        Console.WriteLine("Obra actualizado en eRoi");
                    }
                    else
                    {
                        Console.WriteLine("No se registro / Actualizo en DB");
                        Console.WriteLine("--------------------------------");

                        Console.WriteLine("No se registro / Actualizo en eRoi");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    newLog.GenerarTXT("Excepcion en agregar Obra" + e.Message);
                }
            
           
            }

       
        }


    }

}
