using DatosLAnco;
using MainLanco.Utilerias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco.Conexion
{
    public partial class Business
    {

        //public int agregaObra(SAVObra item)
        //{
        //    try
        //    {
        //        var obra = db.SAVObra.SingleOrDefault(c => c.Obra == item.Obra);


        //        if (obra == null)
        //        {
        //                var idObra = db.SAVFolio.First();
        //                idObra.Obra = idObra.Obra + 1;
        //            try
        //            {
        //                db.SAVObra.Add(item);

        //                db.SaveChanges();

        //                return 1;
        //            }
        //            catch (DbEntityValidationException dbEx)
        //            {
        //                foreach (var validationErrors in dbEx.EntityValidationErrors)
        //                {
        //                    foreach (var validationError in validationErrors.ValidationErrors)
        //                    {
        //                        Trace.TraceInformation("Property2: {0} Error: {1}",
        //                            validationError.PropertyName,
        //                            validationError.ErrorMessage);
        //                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);
        //                    }
        //                }
        //                return 0;
        //            }
        //        }

        //        dynamic response = JsonConvert.SerializeObject(obra);
        //        newLog.GenerarTXT("ObraActualizado" + response);

        //        //obra.Obra = item.Obra;
        //        obra.Nombre = item.Nombre;
        //        obra.ObraClave = item.ObraClave;
        //        obra.Direccion = item.Direccion;
        //        obra.Colonia = item.Colonia;
        //        obra.CP = item.CP;
        //        obra.Ciudad = item.Ciudad;
        //        obra.Estado = item.Estado;
        //        obra.Pais = item.Pais;
        //        obra.Telefono = item.Telefono;
        //        obra.EncargadoObra = item.EncargadoObra;
        //        obra.EncargadoObraTel = item.EncargadoObraTel;
        //        obra.EncargadoPago = item.EncargadoPago;
        //        obra.EncargadoPagoTel = item.EncargadoPagoTel;
        //        obra.DiasRevision = item.DiasRevision;
        //        obra.HoraRevision = item.HoraRevision;
        //        obra.DiasCobro = item.DiasCobro;
        //        obra.HorasCobro = item.HorasCobro;
        //        obra.ReportarInc = item.ReportarInc;
        //        obra.ReportarIncTel = item.ReportarIncTel;
        //        obra.NombreReporte = item.NombreReporte;
        //        obra.ConsignadoA = item.ConsignadoA;
        //        obra.FacturarA = item.FacturarA;
        //        obra.Cliente = item.Cliente;
        //        obra.ClienteNombre = item.ClienteNombre;
        //        obra.NumCopias = item.NumCopias;
        //        obra.FechaAlta = item.FechaAlta;
        //        obra.FechaAltaHora = item.FechaAltaHora;
        //        obra.Capturo = item.Capturo;
        //        obra.CapturoCambio = item.CapturoCambio;
        //        obra.UltimoCambio = item.UltimoCambio;
        //        obra.UltimoCambioHora = item.UltimoCambioHora;
        //        obra.CodigoArea = item.CodigoArea;
        //        obra.Servicio = item.Servicio;
        //        obra.Muestra = item.Muestra;
        //        obra.Revenimiento = item.Revenimiento;
        //        obra.RFC = item.RFC;
        //        obra.Giro = item.Giro;
        //        obra.Zona = item.Zona;
        //        obra.Familia = item.Familia;
        //        obra.Delegacion = item.Delegacion;
        //        obra.Descuento = item.Descuento;
        //        obra.Activa = item.Activa;
        //        obra.UltimaRemision = item.UltimaRemision;
        //        obra.UltimaFactura = item.UltimaFactura;
        //        obra.Serv01Secuencia = item.Serv01Secuencia;
        //        obra.FolioServicioProg = item.FolioServicioProg;
        //        obra.Saldo = item.Saldo;
        //        obra.NC = item.NC;
        //        obra.Email = item.Email;
        //        obra.SaldoAnterior = item.SaldoAnterior;
        //        obra.SaldoLimitePago = item.SaldoLimitePago;
        //        obra.GeneroECFecha = item.GeneroECFecha;
        //        obra.GeneroECCapturo = item.GeneroECCapturo;
        //        obra.EnvioEmail = item.EnvioEmail;
        //        obra.GeneroECDesde = item.GeneroECDesde;
        //        obra.GeneroECHasta = item.GeneroECHasta;
        //        obra.HtmlMail = item.HtmlMail;
        //        obra.UltimoMov = item.UltimoMov;
        //        obra.Aux1 = item.Aux1;
        //        obra.Aux2 = item.Aux2;
        //        obra.Ubicacion = item.Ubicacion;
        //        obra.Horario = item.Horario;
        //        obra.HorarioDesde = item.HorarioDesde;
        //        obra.HorarioHasta = item.HorarioHasta;
        //        obra.HorarioSabado = item.HorarioSabado;
        //        obra.HorarioSabadoDesde = item.HorarioSabadoDesde;
        //        obra.HorarioSabadoHasta = item.HorarioSabadoHasta;
        //        obra.HorarioDomingo = item.HorarioDomingo;
        //        obra.HorarioDomingoDesde = item.HorarioDomingoDesde;
        //        obra.HorarioDomingoHasta = item.HorarioDomingoHasta;
        //        obra.UltimoCobro = item.UltimoCobro;
        //        obra.Reg1 = item.Reg1;
        //        obra.Serv01Copias = item.Serv01Copias;
        //        obra.Serv02Secuencia = item.Serv02Secuencia;
        //        obra.Viga = item.Viga;
        //        obra.Mortero = item.Mortero;
        //        obra.Enviado = item.Enviado;
        //        obra.Serv03Ensaye = item.Serv03Ensaye;
        //        obra.Serv04Ensaye = item.Serv04Ensaye;
        //        obra.Pasaje = item.Pasaje;
        //        obra.Corazon = item.Corazon;
        //        obra.Arteza = item.Arteza;
        //        obra.Ruta = item.Ruta;
        //        obra.RevisionFacturas = item.RevisionFacturas;
        //        obra.RevisionPeriodicidad = item.RevisionPeriodicidad;
        //        obra.RevisionPeriodicidadDia1 = item.RevisionPeriodicidadDia1;
        //        obra.RevisionPeriodicidadDia2 = item.RevisionPeriodicidadDia2;
        //        obra.RevisionHorario = item.RevisionHorario;
        //        obra.ReportesEntrega = item.ReportesEntrega;
        //        obra.ReportesPeriodicidad = item.ReportesPeriodicidad;
        //        obra.ReportesPeriodicidadDia1 = item.ReportesPeriodicidadDia1;
        //        obra.ReportesPeriodicidadDia2 = item.ReportesPeriodicidadDia2;
        //        obra.ReportesHorario = item.ReportesHorario;
        //        obra.Presupuesto = item.Presupuesto;
        //        obra.PresupuestoPeriodicidad = item.PresupuestoPeriodicidad;
        //        obra.PresupuestoPeriodicidadDia1 = item.PresupuestoPeriodicidadDia1;
        //        obra.PresupuestoPeriodicidadDia2 = item.PresupuestoPeriodicidadDia2;
        //        obra.PresupuestoHorario = item.PresupuestoHorario;
        //        obra.Cobranza = item.Cobranza;
        //        obra.CobranzaPeriodicidad = item.CobranzaPeriodicidad;
        //        obra.CobranzaPeriodicidadDia1 = item.CobranzaPeriodicidadDia1;
        //        obra.CobranzaPeriodicidadDia2 = item.CobranzaPeriodicidadDia2;
        //        obra.CobranzaHorario = item.CobranzaHorario;
        //        obra.CobranzaPlazo = item.CobranzaPlazo;
        //        obra.CobranzaActiva = item.CobranzaActiva;
        //        obra.PVCobroSeparado = item.PVCobroSeparado;
        //        obra.TipoCobro = item.TipoCobro;
        //        obra.ConcretoC = item.ConcretoC;
        //        obra.VigaC = item.VigaC;
        //        obra.MorteroC = item.MorteroC;
        //        obra.CorazonC = item.CorazonC;
        //        obra.ArtezaC = item.ArtezaC;
        //        obra.Cerrada = item.Cerrada;
        //        obra.IgualaMensualDesde = item.IgualaMensualDesde;
        //        obra.IgualaMensualHasta = item.IgualaMensualHasta;
        //        obra.IgualaMensualUltMov = item.IgualaMensualUltMov;
        //        obra.IgualaMensualUltCorrida = item.IgualaMensualUltCorrida;
        //        obra.IgualaSemanalCobroMuestras = item.IgualaSemanalCobroMuestras;
        //        obra.Horario2 = item.Horario2;
        //        obra.HorarioDesde2 = item.HorarioDesde2;
        //        obra.HorarioHasta2 = item.HorarioHasta2;
        //        obra.HorarioSabado2 = item.HorarioSabado2;
        //        obra.HorarioSabadoDesde2 = item.HorarioSabadoDesde2;
        //        obra.HorarioSabadoHasta2 = item.HorarioSabadoHasta2;
        //        obra.HorarioDomingo2 = item.HorarioDomingo2;
        //        obra.HorarioDomingoDesde2 = item.HorarioDomingoDesde2;
        //        obra.HorarioDomingoHasta2 = item.HorarioDomingoHasta2;
        //        obra.DescuentoAutomatico = item.DescuentoAutomatico;
        //        obra.ServiciosPendRemisionar = item.ServiciosPendRemisionar;
        //        obra.Observaciones = item.Observaciones;
        //        obra.DiasDesc = item.DiasDesc;
        //        obra.FacturaElectronica = item.FacturaElectronica;
        //        obra.NombreF = item.NombreF;
        //        obra.DireccionF = item.DireccionF;
        //        obra.NumExteriorF = item.NumExteriorF;
        //        obra.NumInteriorF = item.NumInteriorF;
        //        obra.ColoniaF = item.ColoniaF;
        //        obra.DelegacionF = item.DelegacionF;
        //        obra.CPF = item.CPF;
        //        obra.CiudadF = item.CiudadF;
        //        obra.EstadoF = item.EstadoF;
        //        obra.PaisF = item.PaisF;
        //        obra.EmailF = item.EmailF;
        //        obra.CalaCobroSeparado = item.CalaCobroSeparado;
        //        obra.MetododePago = item.MetododePago;
        //        obra.NumCtaPago = item.NumCtaPago;
        //        obra.EmailC = item.EmailC;
        //        obra.Aux3 = item.Aux3;
        //        obra.Aux4 = item.Aux4;
        //        obra.LimiteCredito = item.LimiteCredito;
        //        obra.OCFecha = item.OCFecha;
        //        obra.OCObservaciones = item.OCObservaciones;
        //        obra.FormadePago = item.FormadePago;
        //        obra.UsoCFDI = item.UsoCFDI;
        //        obra.AuxMP = item.AuxMP;
        //        obra.ServEspSecuencia = item.ServEspSecuencia;
        //        obra.ServEsp = item.ServEsp;
        //        obra.SerieF = item.SerieF;
        //        obra.RegimenFiscalClave = item.RegimenFiscalClave;

        //        try
        //        {
        //            db.SaveChanges();
        //            return 2;
        //        }
        //        catch (DbEntityValidationException dbEx)
        //        {
        //            foreach (var validationErrors in dbEx.EntityValidationErrors)
        //            {
        //                foreach (var validationError in validationErrors.ValidationErrors)
        //                {
        //                    Trace.TraceInformation("Property: {0} Error: {1}",
        //                        validationError.PropertyName,
        //                        validationError.ErrorMessage);
        //                    newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);
        //                }
        //            }
        //            return 0;
        //        }
        //    }
        //    catch (DbEntityValidationException dbEx)
        //    {
        //        foreach (var validationErrors in dbEx.EntityValidationErrors)
        //        {
        //            foreach (var validationError in validationErrors.ValidationErrors)
        //            {
        //                Trace.TraceInformation("Property3: {0} Error: {1}",
        //                    validationError.PropertyName,
        //                    validationError.ErrorMessage);
        //                newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);
        //            }
        //        }
        //        return 0;
        //    }
        //}
    }
}
