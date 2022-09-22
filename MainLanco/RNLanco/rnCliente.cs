using DatosLAnco;
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
        public async Task<bool> registroCliente(SAVCliente item)
        {
            var cliente = new SAVCliente()
            {
                Clave = item.Clave,
                Empresa = item.Empresa,
                Contacto = item.Contacto,
                Direccion = item.Direccion,
                Colonia = item.Colonia,
                CP = item.CP,
                Ciudad = item.Ciudad,
                Estado = item.Estado,
                Pais = item.Pais,
                TelefonoOficina = item.TelefonoOficina,
                TelefonoCasa = item.TelefonoCasa,
                Fax = item.Fax,
                Email = item.Email,
                RFC = item.RFC,
                Saldo = item.Saldo,
                Bloqueado = item.Bloqueado,
                FechaAlta = item.FechaAlta,
                UltimoCambio = item.UltimoCambio,
                UltimoMov = item.UltimoMov,
                Status = item.Status,
                Beeper = item.Beeper,
                NC = item.NC,
                CodigoArea = item.CodigoArea,
                Giro = item.Giro,
                Zona = item.Zona,
                AuxA1 = item.AuxA1,
                AuxA2 = item.AuxA2,
                AuxN1 = item.AuxN1,
                AuxN2 = item.AuxN2,
                Recomendo = item.Recomendo,
                Celular = item.Celular,
                Web = item.Web,
                NombreComercial = item.NombreComercial,
                FacturarA = item.FacturarA,
                Capturo = item.Capturo,
                CapturoCambio = item.CapturoCambio,
                EntreCalle1 = item.EntreCalle1,
                EntreCalle2 = item.EntreCalle2,
                FechaAltaHora = item.FechaAltaHora,
                UltimoCambioHora = item.UltimoCambioHora,
                Estatus = item.Estatus,
                Delegacion = item.Delegacion,
                SaldoAnterior = item.SaldoAnterior,
                SaldoLimitePago = item.SaldoLimitePago,
                GeneroECFecha = item.GeneroECFecha,
                GeneroECCapturo = item.GeneroECCapturo,
                EnvioEmail = item.EnvioEmail,
                GeneroECDesde = item.GeneroECDesde,
                GeneroECHasta = item.GeneroECHasta,
                Htmlmail = item.Htmlmail,
                UltimaRemision = item.UltimaRemision,
                UltimaFactura = item.UltimaFactura,
                Activa = item.Activa,
                UltimoCobro = item.UltimoCobro,
                Anticipo = item.Anticipo,
                Ruta = item.Ruta,
                Llamada = item.Llamada,
                Asignado = item.Asignado,
                ServiciosPendRemisionar = item.ServiciosPendRemisionar,
                MetododePago = item.MetododePago,
                NumCtaPago = item.NumCtaPago,
                FormadePago = item.FormadePago,
                UsoCFDI = item.UsoCFDI,
                AuxMP = item.AuxMP,
                CLIENTE_ID = item.CLIENTE_ID,
                CuentaOficina = item.CuentaOficina,
                Cuenta = item.Cuenta,
                SubCuenta = item.SubCuenta,
                CuentaOficina2 = item.CuentaOficina2,
                Cuenta2 = item.Cuenta2,
                SubCuenta2 = item.SubCuenta2

            };
            var result = await agregaCliente(cliente);

            if(!result)
            return false;

            return true;
        }

        public bool registroObra(SAVObra item)
        {
            try
            {
                var obra = new SAVObra()
                {
                    Obra = item.Obra,
                    Nombre = item.Nombre,
                    ObraClave = item.ObraClave,
                    Direccion = item.Direccion,
                    Colonia = item.Colonia,
                    CP = item.CP,
                    Ciudad = item.Ciudad,
                    Estado = item.Estado,
                    Pais = item.Pais,
                    Telefono = item.Telefono,
                    EncargadoObra = item.EncargadoObra,
                    EncargadoObraTel = item.EncargadoObraTel,
                    EncargadoPago = item.EncargadoPago,
                    EncargadoPagoTel = item.EncargadoPagoTel,
                    DiasRevision = item.DiasRevision,
                    HoraRevision = item.HoraRevision,
                    DiasCobro = item.DiasCobro,
                    HorasCobro = item.HorasCobro,
                    ReportarInc = item.ReportarInc,
                    ReportarIncTel = item.ReportarIncTel,
                    NombreReporte = item.NombreReporte,
                    ConsignadoA = item.ConsignadoA,
                    FacturarA = item.FacturarA,
                    Cliente = item.Cliente,
                    ClienteNombre = item.ClienteNombre,
                    NumCopias = item.NumCopias,
                    FechaAlta = item.FechaAlta,
                    FechaAltaHora = item.FechaAltaHora,
                    Capturo = item.Capturo,
                    CapturoCambio = item.CapturoCambio,
                    UltimoCambio = item.UltimoCambio,
                    UltimoCambioHora = item.UltimoCambioHora,
                    CodigoArea = item.CodigoArea,
                    Servicio = item.Servicio,
                    Muestra = item.Muestra,
                    Revenimiento = item.Revenimiento,
                    RFC = item.RFC,
                    Giro = item.Giro,
                    Zona = item.Zona,
                    Familia = item.Familia,
                    Delegacion = item.Delegacion,
                    Descuento = item.Descuento,
                    Activa = item.Activa,
                    UltimaRemision = item.UltimaRemision,
                    UltimaFactura = item.UltimaFactura,
                    Serv01Secuencia = item.Serv01Secuencia,
                    FolioServicioProg = item.FolioServicioProg,
                    Saldo = item.Saldo,
                    NC = item.NC,
                    Email = item.Email,
                    SaldoAnterior = item.SaldoAnterior,
                    SaldoLimitePago = item.SaldoLimitePago,
                    GeneroECFecha = item.GeneroECFecha,
                    GeneroECCapturo = item.GeneroECCapturo,
                    EnvioEmail = item.EnvioEmail,
                    GeneroECDesde = item.GeneroECDesde,
                    GeneroECHasta = item.GeneroECHasta,
                    HtmlMail = item.HtmlMail,
                    UltimoMov = item.UltimoMov,
                    Aux1 = item.Aux1,
                    Aux2 = item.Aux2,
                    Ubicacion = item.Ubicacion,
                    Horario = item.Horario,
                    HorarioDesde = item.HorarioDesde,
                    HorarioHasta = item.HorarioHasta,
                    HorarioSabado = item.HorarioSabado,
                    HorarioSabadoDesde = item.HorarioSabadoDesde,
                    HorarioSabadoHasta = item.HorarioSabadoHasta,
                    HorarioDomingo = item.HorarioDomingo,
                    HorarioDomingoDesde = item.HorarioDomingoDesde,
                    HorarioDomingoHasta = item.HorarioDomingoHasta,
                    UltimoCobro = item.UltimoCobro,
                    Reg1 = item.Reg1,
                    Serv01Copias = item.Serv01Copias,
                    Serv02Secuencia = item.Serv02Secuencia,
                    Viga = item.Viga,
                    Mortero = item.Mortero,
                    Enviado = item.Enviado,
                    Serv03Ensaye = item.Serv03Ensaye,
                    Serv04Ensaye = item.Serv04Ensaye,
                    Pasaje = item.Pasaje,
                    Corazon = item.Corazon,
                    Arteza = item.Arteza,
                    Ruta = item.Ruta,
                    RevisionFacturas = item.RevisionFacturas,
                    RevisionPeriodicidad = item.RevisionPeriodicidad,
                    RevisionPeriodicidadDia1 = item.RevisionPeriodicidadDia1,
                    RevisionPeriodicidadDia2 = item.RevisionPeriodicidadDia2,
                    RevisionHorario = item.RevisionHorario,
                    ReportesEntrega = item.ReportesEntrega,
                    ReportesPeriodicidad = item.ReportesPeriodicidad,
                    ReportesPeriodicidadDia1 = item.ReportesPeriodicidadDia1,
                    ReportesPeriodicidadDia2 = item.ReportesPeriodicidadDia2,
                    ReportesHorario = item.ReportesHorario,
                    Presupuesto = item.Presupuesto,
                    PresupuestoPeriodicidad = item.PresupuestoPeriodicidad,
                    PresupuestoPeriodicidadDia1 = item.PresupuestoPeriodicidadDia1,
                    PresupuestoPeriodicidadDia2 = item.PresupuestoPeriodicidadDia2,
                    PresupuestoHorario = item.PresupuestoHorario,
                    Cobranza = item.Cobranza,
                    CobranzaPeriodicidad = item.CobranzaPeriodicidad,
                    CobranzaPeriodicidadDia1 = item.CobranzaPeriodicidadDia1,
                    CobranzaPeriodicidadDia2 = item.CobranzaPeriodicidadDia2,
                    CobranzaHorario = item.CobranzaHorario,
                    CobranzaPlazo = item.CobranzaPlazo,
                    CobranzaActiva = item.CobranzaActiva,
                    PVCobroSeparado = item.PVCobroSeparado,
                    TipoCobro = item.TipoCobro,
                    ConcretoC = item.ConcretoC,
                    VigaC = item.VigaC,
                    MorteroC = item.MorteroC,
                    CorazonC = item.CorazonC,
                    ArtezaC = item.ArtezaC,
                    Cerrada = item.Cerrada,
                    IgualaMensualDesde = item.IgualaMensualDesde,
                    IgualaMensualHasta = item.IgualaMensualHasta,
                    IgualaMensualUltMov = item.IgualaMensualUltMov,
                    IgualaMensualUltCorrida = item.IgualaMensualUltCorrida,
                    IgualaSemanalCobroMuestras = item.IgualaSemanalCobroMuestras,
                    Horario2 = item.Horario2,
                    HorarioDesde2 = item.HorarioDesde2,
                    HorarioHasta2 = item.HorarioHasta2,
                    HorarioSabado2 = item.HorarioSabado2,
                    HorarioSabadoDesde2 = item.HorarioSabadoDesde2,
                    HorarioSabadoHasta2 = item.HorarioSabadoHasta2,
                    HorarioDomingo2 = item.HorarioDomingo2,
                    HorarioDomingoDesde2 = item.HorarioDomingoDesde2,
                    HorarioDomingoHasta2 = item.HorarioDomingoHasta2,
                    DescuentoAutomatico = item.DescuentoAutomatico,
                    ServiciosPendRemisionar = item.ServiciosPendRemisionar,
                    Observaciones = item.Observaciones,
                    DiasDesc = item.DiasDesc,
                    FacturaElectronica = item.FacturaElectronica,
                    NombreF = item.NombreF,
                    DireccionF = item.DireccionF,
                    NumExteriorF = item.NumExteriorF,
                    NumInteriorF = item.NumInteriorF,
                    ColoniaF = item.ColoniaF,
                    DelegacionF = item.DelegacionF,
                    CPF = item.CPF,
                    CiudadF = item.CiudadF,
                    EstadoF = item.EstadoF,
                    PaisF = item.PaisF,
                    EmailF = item.EmailF,
                    CalaCobroSeparado = item.CalaCobroSeparado,
                    MetododePago = item.MetododePago,
                    NumCtaPago = item.NumCtaPago,
                    EmailC = item.EmailC,
                    Aux3 = item.Aux3,
                    Aux4 = item.Aux4,
                    LimiteCredito = item.LimiteCredito,
                    OCFecha = item.OCFecha,
                    OCObservaciones = item.OCObservaciones,
                    FormadePago = item.FormadePago,
                    UsoCFDI = item.UsoCFDI,
                    AuxMP = item.AuxMP,
                    ServEspSecuencia = item.ServEspSecuencia,
                    ServEsp = item.ServEsp,
                    SerieF = item.SerieF
                };
                bool result = agregaObra(obra);

                if (!result)
                    return false;

                return true;
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                            validationError.PropertyName,   
                            validationError.ErrorMessage);
                    }
                }
                return false;
            }
            
        }

    }
}
