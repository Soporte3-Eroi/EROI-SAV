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
        public int agregaCliente(SAVCliente item)
        {
            var cliente = db.SAVCliente.SingleOrDefault(c => c.Clave == item.Clave);

            if (cliente != null)
            {
                dynamic response = JsonConvert.SerializeObject(cliente);
                newLog.GenerarTXT("ClienteActualizado" + response);

                //Clave = item.Clave,
                cliente.Empresa = item.Empresa;
                cliente.Contacto = item.Contacto;
                cliente.Direccion = item.Direccion;
                cliente.Colonia = item.Colonia;
                cliente.CP = item.CP;
                cliente.Ciudad = item.Ciudad;
                cliente.Estado = item.Estado;
                cliente.Pais = item.Pais;
                cliente.TelefonoOficina = item.TelefonoOficina;
                cliente.TelefonoCasa = item.TelefonoCasa;
                cliente.Fax = item.Fax;
                cliente.Email = item.Email;
                cliente.RFC = item.RFC;
                cliente.Saldo = item.Saldo;
                cliente.Bloqueado = item.Bloqueado;
                cliente.FechaAlta = item.FechaAlta;
                cliente.UltimoCambio = item.UltimoCambio;
                cliente.UltimoMov = item.UltimoMov;
                cliente.Status = item.Status;
                cliente.Beeper = item.Beeper;
                cliente.NC = item.NC;
                cliente.CodigoArea = item.CodigoArea;
                cliente.Giro = item.Giro;
                cliente.Zona = item.Zona;
                cliente.AuxA1 = item.AuxA1;
                cliente.AuxA2 = item.AuxA2;
                cliente.AuxN1 = item.AuxN1;
                cliente.AuxN2 = item.AuxN2;
                cliente.Recomendo = item.Recomendo;
                cliente.Celular = item.Celular;
                cliente.Web = item.Web;
                cliente.NombreComercial = item.NombreComercial;
                cliente.FacturarA = item.FacturarA;
                cliente.Capturo = item.Capturo;
                cliente.CapturoCambio = item.CapturoCambio;
                cliente.EntreCalle1 = item.EntreCalle1;
                cliente.EntreCalle2 = item.EntreCalle2;
                cliente.FechaAltaHora = item.FechaAltaHora;
                cliente.UltimoCambioHora = item.UltimoCambioHora;
                cliente.Estatus = item.Estatus;
                cliente.Delegacion = item.Delegacion;
                cliente.SaldoAnterior = item.SaldoAnterior;
                cliente.SaldoLimitePago = item.SaldoLimitePago;
                cliente.GeneroECFecha = item.GeneroECFecha;
                cliente.GeneroECCapturo = item.GeneroECCapturo;
                cliente.EnvioEmail = item.EnvioEmail;
                cliente.GeneroECDesde = item.GeneroECDesde;
                cliente.GeneroECHasta = item.GeneroECHasta;
                cliente.Htmlmail = item.Htmlmail;
                cliente.UltimaRemision = item.UltimaRemision;
                cliente.UltimaFactura = item.UltimaFactura;
                cliente.Activa = item.Activa;
                cliente.UltimoCobro = item.UltimoCobro;
                cliente.Anticipo = item.Anticipo;
                cliente.Ruta = item.Ruta;
                cliente.Llamada = item.Llamada;
                cliente.Asignado = item.Asignado;
                cliente.ServiciosPendRemisionar = item.ServiciosPendRemisionar;
                cliente.MetododePago = item.MetododePago;
                cliente.NumCtaPago = item.NumCtaPago;
                cliente.FormadePago = item.FormadePago;
                cliente.UsoCFDI = item.UsoCFDI;
                cliente.AuxMP = item.AuxMP;
                cliente.CLIENTE_ID = item.CLIENTE_ID;
                cliente.CuentaOficina = item.CuentaOficina;
                cliente.Cuenta = item.Cuenta;
                cliente.SubCuenta = item.SubCuenta;
                cliente.CuentaOficina2 = item.CuentaOficina2;
                cliente.Cuenta2 = item.Cuenta2;
                cliente.SubCuenta2 = item.SubCuenta2;
                cliente.RegimenFiscalClave = item.RegimenFiscalClave;

                try
                {
                    db.SaveChanges();
                    return 2;
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
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }

            
            try
            {
                var claveCliente = db.SAVFolio.First();
                claveCliente.Cliente = claveCliente.Cliente + 1;

                db.SAVCliente.Add(item);
                db.SaveChanges();

                return 1;
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property2: {0} Error: {1}",
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                    }
                }
                return 0;
            }
        }
        public int registroObra(SAVObra item)
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
                    SerieF = item.SerieF,
                    RegimenFiscalClave = item.RegimenFiscalClave
                };
                int result = agregaObra(obra);


                if (result == 0)
                {
                    return 0;
                }
                else if (result == 2)
                {
                    return 2;
                }
                return 1;
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property2: {0} Error: {1}",
                            validationError.PropertyName,   
                            validationError.ErrorMessage);
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);
                    }
                }
                return 0;
            }
            
        }
        public int agregaRemC(SAVRemC item)
        {
            var RemC = db.SAVRemC.SingleOrDefault(c => c.Remision == item.Remision);

            if (RemC != null)
            {
                
                //RemC.Remision = item.Remision;
                RemC.Cliente = item.Cliente;
                RemC.FacturarA = item.FacturarA;
                RemC.Fecha = item.Fecha;
                RemC.TipoCambio = item.TipoCambio;
                RemC.PorcIva = item.PorcIva;
                RemC.Capturo = item.Capturo;
                RemC.Comentario = item.Comentario;
                RemC.SubTotal = item.SubTotal;
                RemC.IVA = item.IVA;
                RemC.Total = item.Total;
                RemC.Procesado = item.Procesado;
                RemC.Estatus = item.Estatus;
                RemC.Pagado = item.Pagado;
                RemC.Saldo = item.Saldo;
                RemC.Partidas = item.Partidas;
                RemC.FechaAlta = item.FechaAlta;
                RemC.UltimoCambio = item.UltimoCambio;
                RemC.TotalLetra = item.TotalLetra;
                RemC.Tipo = item.Tipo;
                RemC.NCredito = item.NCredito;
                RemC.Vendedor = item.Vendedor;
                RemC.Giro = item.Giro;
                RemC.Zona = item.Zona;
                RemC.RFC = item.RFC;
                RemC.ConRFC = item.ConRFC;
                RemC.FacturaConsolidada = item.FacturaConsolidada;
                RemC.Corrida = item.Corrida;
                RemC.Hora = item.Hora;
                RemC.Obra = item.Obra;
                RemC.LigaObra = item.LigaObra;
                RemC.ObraClave = item.ObraClave;
                RemC.Impresiones = item.Impresiones;
                RemC.CancelacionFecha = item.CancelacionFecha;
                RemC.CancelacionCapturo = item.CancelacionCapturo;
                RemC.ConsignadoA = item.ConsignadoA;
                RemC.ObraUbicacion = item.ObraUbicacion;
                RemC.CancelacionMotivo = item.CancelacionMotivo;
                RemC.Facturado = item.Facturado;
                RemC.FacturadoFecha = item.FacturadoFecha;
                RemC.FacturadoFactura = item.FacturadoFactura;
                RemC.CancelacionSustituye = item.CancelacionSustituye;
                RemC.Aux1 = item.Aux1;
                RemC.Aux2 = item.Aux2;
                RemC.AgendaMensajeria = item.AgendaMensajeria;
                RemC.MetododePago = item.MetododePago;
                RemC.NumCtaPago = item.NumCtaPago;
                RemC.FacturadoFechaOriginal = item.FacturadoFechaOriginal;
                RemC.FacturadoFacturaOriginal = item.FacturadoFacturaOriginal;
                RemC.CapturoCambio = item.CapturoCambio;
                RemC.FormadePago = item.FormadePago;
                RemC.UsoCFDI = item.UsoCFDI;
                RemC.RetencionIVA = item.RetencionIVA;
                RemC.RetencionISR = item.RetencionISR;
                RemC.FacturaSustituye =item.FacturaSustituye;
                RemC.FacturaSustituye = item.FacturaSustituye;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(RemC);
                    newLog.GenerarTXT("RemCActualiza" + response);
                    return 2;
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
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                RemC.Remision = item.Remision;
                RemC.Cliente = item.Cliente;
                RemC.FacturarA = item.FacturarA;
                RemC.Fecha = item.Fecha;
                RemC.TipoCambio = item.TipoCambio;
                RemC.PorcIva = item.PorcIva;
                RemC.Capturo = item.Capturo;
                RemC.Comentario = item.Comentario;
                RemC.SubTotal = item.SubTotal;
                RemC.IVA = item.IVA;
                RemC.Total = item.Total;
                RemC.Procesado = item.Procesado;
                RemC.Estatus = item.Estatus;
                RemC.Pagado = item.Pagado;
                RemC.Saldo = item.Saldo;
                RemC.Partidas = item.Partidas;
                RemC.FechaAlta = item.FechaAlta;
                RemC.UltimoCambio = item.UltimoCambio;
                RemC.TotalLetra = item.TotalLetra;
                RemC.Tipo = item.Tipo;
                RemC.NCredito = item.NCredito;
                RemC.Vendedor = item.Vendedor;
                RemC.Giro = item.Giro;
                RemC.Zona = item.Zona;
                RemC.RFC = item.RFC;
                RemC.ConRFC = item.ConRFC;
                RemC.FacturaConsolidada = item.FacturaConsolidada;
                RemC.Corrida = item.Corrida;
                RemC.Hora = item.Hora;
                RemC.Obra = item.Obra;
                RemC.LigaObra = item.LigaObra;
                RemC.ObraClave = item.ObraClave;
                RemC.Impresiones = item.Impresiones;
                RemC.CancelacionFecha = item.CancelacionFecha;
                RemC.CancelacionCapturo = item.CancelacionCapturo;
                RemC.ConsignadoA = item.ConsignadoA;
                RemC.ObraUbicacion = item.ObraUbicacion;
                RemC.CancelacionMotivo = item.CancelacionMotivo;
                RemC.Facturado = item.Facturado;
                RemC.FacturadoFecha = item.FacturadoFecha;
                RemC.FacturadoFactura = item.FacturadoFactura;
                RemC.CancelacionSustituye = item.CancelacionSustituye;
                RemC.Aux1 = item.Aux1;
                RemC.Aux2 = item.Aux2;
                RemC.AgendaMensajeria = item.AgendaMensajeria;
                RemC.MetododePago = item.MetododePago;
                RemC.NumCtaPago = item.NumCtaPago;
                RemC.FacturadoFechaOriginal = item.FacturadoFechaOriginal;
                RemC.FacturadoFacturaOriginal = item.FacturadoFacturaOriginal;
                RemC.CapturoCambio = item.CapturoCambio;
                RemC.FormadePago = item.FormadePago;
                RemC.UsoCFDI = item.UsoCFDI;
                RemC.RetencionIVA = item.RetencionIVA;
                RemC.RetencionISR = item.RetencionISR;
                RemC.FacturaSustituye = item.FacturaSustituye;
                RemC.FacturaSustituye = item.FacturaSustituye;
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(RemC);
                newLog.GenerarTXT("RemCRegistrada" + response);

                return 1;
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
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                    }
                }
                return 0;
            }
            //try
            //{
            //    var claveRemC = db.SAVRemC.First();
            //    claveRemC.Cliente = claveRemC.Cliente + 1;

            //    db.SAVRemC.Add(item);
            //    db.SaveChanges();

            //    return 1;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property2: {0} Error: {1}",
            //                validationError.PropertyName,
            //                validationError.ErrorMessage);
            //            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

            //        }
            //    }
            //    return 0;
            //}
        }
        public int agregaRemCA(SAVRemCA item)
        {
            var RemCA = db.SAVRemCA.SingleOrDefault(c => c.Remision == item.Remision);

            if (RemCA != null)
            {

                //RemCA.Remision = item.Remision;
                RemCA.FacturaAnticipo = item.FacturaAnticipo;
                RemCA.Fecha = item.Fecha;
                RemCA.Total = item.Total;
                RemCA.Moneda = item.Moneda;
                RemCA.Paridad = item.Paridad;
                RemCA.UUID = item.UUID;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(RemCA);
                    newLog.GenerarTXT("RemCAActualiza" + response);
                    return 2;
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
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                RemCA.Remision = item.Remision;
                RemCA.FacturaAnticipo = item.FacturaAnticipo;
                RemCA.Fecha = item.Fecha;
                RemCA.Total = item.Total;
                RemCA.Moneda = item.Moneda;
                RemCA.Paridad = item.Paridad;
                RemCA.UUID = item.UUID;

                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(RemCA);
                newLog.GenerarTXT("RemCARegistrada" + response);

                return 1;
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
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                    }
                }
                return 0;
            }
            //try
            //{
            //    var claveRemC = db.SAVRemC.First();
            //    claveRemC.Cliente = claveRemC.Cliente + 1;

            //    db.SAVRemC.Add(item);
            //    db.SaveChanges();

            //    return 1;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property2: {0} Error: {1}",
            //                validationError.PropertyName,
            //                validationError.ErrorMessage);
            //            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

            //        }
            //    }
            //    return 0;
            //}
        }
        public int agregaRemD(SAVRemD item)
        {
            var RemD = db.SAVRemD.SingleOrDefault(c => c.Remision == item.Remision && c.Orden == item.Orden);

            if (RemD != null)
            {
                //RemD.Remision = item.Remision;
                //RemD.Orden = item.Orden;
                RemD.Tipo = item.Tipo;
                RemD.Clave = item.Clave;
                RemD.Descripcion = item.Descripcion;
                RemD.Monto = item.Monto;
                RemD.Descuento = item.Descuento;
                RemD.Comentario = item.Comentario;
                RemD.Cantidad = item.Cantidad;
                RemD.DescripcionAdicional = item.DescripcionAdicional;
                RemD.PorcIva = item.PorcIva;
                RemD.Desc1 = item.Desc1;
                RemD.Unidad = item.Unidad;
                RemD.FolioServicioProg = item.FolioServicioProg;
                RemD.PorcIvaRetencion = item.PorcIvaRetencion;
                RemD.PorcISRRetencion = item.PorcISRRetencion;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(RemD);
                    newLog.GenerarTXT("RemDActualiza" + response);
                    return 2;
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
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                RemD.Remision = item.Remision;
                RemD.Orden = item.Orden;
                RemD.Tipo = item.Tipo;
                RemD.Clave = item.Clave;
                RemD.Descripcion = item.Descripcion;
                RemD.Monto = item.Monto;
                RemD.Descuento = item.Descuento;
                RemD.Comentario = item.Comentario;
                RemD.Cantidad = item.Cantidad;
                RemD.DescripcionAdicional = item.DescripcionAdicional;
                RemD.PorcIva = item.PorcIva;
                RemD.Desc1 = item.Desc1;
                RemD.Unidad = item.Unidad;
                RemD.FolioServicioProg = item.FolioServicioProg;
                RemD.PorcIvaRetencion = item.PorcIvaRetencion;
                RemD.PorcISRRetencion = item.PorcISRRetencion;

                db.SaveChanges();
                dynamic response = JsonConvert.SerializeObject(RemD);
                newLog.GenerarTXT("RemDRegistrada" + response);

                return 1;
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
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                    }
                }
                return 0;
            }
            //try
            //{
            //    var claveRemC = db.SAVRemC.First();
            //    claveRemC.Cliente = claveRemC.Cliente + 1;

            //    db.SAVRemC.Add(item);
            //    db.SaveChanges();

            //    return 1;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property2: {0} Error: {1}",
            //                validationError.PropertyName,
            //                validationError.ErrorMessage);
            //            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

            //        }
            //    }
            //    return 0;
            //}
        }
        public int agregaFactC(SAVFactC item)
        {
            var FactC = db.SAVFactC.SingleOrDefault(c => c.Remision == item.Remision);

            if (FactC != null)
            {

                //FactC.Factura = item.Factura;
                FactC.Cliente = item.Cliente;
                FactC.FacturarA = item.FacturarA;
                FactC.Fecha = item.Fecha;
                FactC.TipoCambio = item.TipoCambio;
                FactC.PorcIva = item.PorcIva;
                FactC.Capturo = item.Capturo;
                FactC.Comentario = item.Comentario;
                FactC.SubTotal = item.SubTotal;
                FactC.IVA = item.IVA;
                FactC.Total = item.Total;
                FactC.Procesado = item.Procesado;
                FactC.Estatus = item.Estatus;
                FactC.Pagado = item.Pagado;
                FactC.Saldo = item.Saldo;
                FactC.Partidas = item.Partidas;
                FactC.FechaAlta = item.FechaAlta;
                FactC.UltimoCambio = item.UltimoCambio;
                FactC.TotalLetra = item.TotalLetra;
                FactC.Tipo = item.Tipo;
                FactC.NCredito = item.NCredito;
                FactC.Vendedor = item.Vendedor;
                FactC.Giro = item.Giro;
                FactC.Zona = item.Zona;
                FactC.RFC = item.RFC;
                FactC.ConRFC = item.ConRFC;
                FactC.FacturaConsolidada = item.FacturaConsolidada;
                FactC.Corrida = item.Corrida;
                FactC.Hora = item.Hora;
                FactC.Obra = item.Obra;
                FactC.LigaObra = item.LigaObra;
                FactC.ObraClave = item.ObraClave;
                FactC.Impresiones = item.Impresiones;
                FactC.CancelacionFecha = item.CancelacionFecha;
                FactC.CancelacionCapturo = item.CancelacionCapturo;
                FactC.ConsignadoA = item.ConsignadoA;
                FactC.ObraUbicacion = item.ObraUbicacion;
                FactC.CancelacionMotivo = item.CancelacionMotivo;
                FactC.Remision = item.Remision;
                FactC.RemisionFecha = item.RemisionFecha;
                FactC.CancelacionSustituye = item.CancelacionSustituye;
                FactC.Entregada = item.Entregada;
                FactC.AgendaMensajeria = item.AgendaMensajeria;
                FactC.AgendaMensajeriaC = item.AgendaMensajeriaC;
                FactC.NCargo = item.NCargo;
                FactC.SerieCFD = item.SerieCFD;
                FactC.FacturaCFD = item.FacturaCFD;
                FactC.MetododePago = item.MetododePago;
                FactC.NumCtaPago = item.NumCtaPago;
                FactC.NCreditoCompleta = item.NCreditoCompleta;
                FactC.Plazo = item.Plazo;
                FactC.FechaVencimiento = item.FechaVencimiento;
                FactC.FechaAltaHora = item.FechaAltaHora;
                FactC.UltimoCambioHora = item.UltimoCambioHora;
                FactC.CapturoCambio = item.CapturoCambio;
                FactC.FormadePago = item.FormadePago;
                FactC.UsoCFDI = item.UsoCFDI;
                FactC.CFDIVersion = item.CFDIVersion;
                FactC.UUID = item.UUID;
                FactC.Parcialidades = item.Parcialidades;
                FactC.FacturaSustituye = item.FacturaSustituye;
                FactC.SolicitudCancelacionSAT = item.SolicitudCancelacionSAT;
                FactC.EstatusCancelacionSAT = item.EstatusCancelacionSAT;
                FactC.PreCancelacion = item.PreCancelacion;
                FactC.PreCancelacionCapturo = item.PreCancelacionCapturo;
                FactC.IntContable = item.IntContable;
                FactC.IntContablePoliza = item.IntContablePoliza;
                FactC.IntContablePolizaC = item.IntContablePolizaC;
                FactC.RetencionIVA = item.RetencionIVA;
                FactC.RetencionISR = item.RetencionISR;
                FactC.CancelacionMotivoClave = item.CancelacionMotivoClave;
                FactC.CancelacionUUIDRelacion = item.CancelacionUUIDRelacion;
                FactC.DescuentoIncluido = item.DescuentoIncluido;
                FactC.DescuentoIncluidoCIva = item.DescuentoIncluidoCIva;
                FactC.SubTotalIva0 = item.SubTotalIva0;
                FactC.SubTotalIva8 = item.SubTotalIva8;
                FactC.SubTotalIva16 = item.SubTotalIva16;


                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(FactC);
                    newLog.GenerarTXT("FactC Actualiza" + response);
                    return 2;
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
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                FactC.Factura = item.Factura;
                FactC.Cliente = item.Cliente;
                FactC.FacturarA = item.FacturarA;
                FactC.Fecha = item.Fecha;
                FactC.TipoCambio = item.TipoCambio;
                FactC.PorcIva = item.PorcIva;
                FactC.Capturo = item.Capturo;
                FactC.Comentario = item.Comentario;
                FactC.SubTotal = item.SubTotal;
                FactC.IVA = item.IVA;
                FactC.Total = item.Total;
                FactC.Procesado = item.Procesado;
                FactC.Estatus = item.Estatus;
                FactC.Pagado = item.Pagado;
                FactC.Saldo = item.Saldo;
                FactC.Partidas = item.Partidas;
                FactC.FechaAlta = item.FechaAlta;
                FactC.UltimoCambio = item.UltimoCambio;
                FactC.TotalLetra = item.TotalLetra;
                FactC.Tipo = item.Tipo;
                FactC.NCredito = item.NCredito;
                FactC.Vendedor = item.Vendedor;
                FactC.Giro = item.Giro;
                FactC.Zona = item.Zona;
                FactC.RFC = item.RFC;
                FactC.ConRFC = item.ConRFC;
                FactC.FacturaConsolidada = item.FacturaConsolidada;
                FactC.Corrida = item.Corrida;
                FactC.Hora = item.Hora;
                FactC.Obra = item.Obra;
                FactC.LigaObra = item.LigaObra;
                FactC.ObraClave = item.ObraClave;
                FactC.Impresiones = item.Impresiones;
                FactC.CancelacionFecha = item.CancelacionFecha;
                FactC.CancelacionCapturo = item.CancelacionCapturo;
                FactC.ConsignadoA = item.ConsignadoA;
                FactC.ObraUbicacion = item.ObraUbicacion;
                FactC.CancelacionMotivo = item.CancelacionMotivo;
                FactC.Remision = item.Remision;
                FactC.RemisionFecha = item.RemisionFecha;
                FactC.CancelacionSustituye = item.CancelacionSustituye;
                FactC.Entregada = item.Entregada;
                FactC.AgendaMensajeria = item.AgendaMensajeria;
                FactC.AgendaMensajeriaC = item.AgendaMensajeriaC;
                FactC.NCargo = item.NCargo;
                FactC.SerieCFD = item.SerieCFD;
                FactC.FacturaCFD = item.FacturaCFD;
                FactC.MetododePago = item.MetododePago;
                FactC.NumCtaPago = item.NumCtaPago;
                FactC.NCreditoCompleta = item.NCreditoCompleta;
                FactC.Plazo = item.Plazo;
                FactC.FechaVencimiento = item.FechaVencimiento;
                FactC.FechaAltaHora = item.FechaAltaHora;
                FactC.UltimoCambioHora = item.UltimoCambioHora;
                FactC.CapturoCambio = item.CapturoCambio;
                FactC.FormadePago = item.FormadePago;
                FactC.UsoCFDI = item.UsoCFDI;
                FactC.CFDIVersion = item.CFDIVersion;
                FactC.UUID = item.UUID;
                FactC.Parcialidades = item.Parcialidades;
                FactC.FacturaSustituye = item.FacturaSustituye;
                FactC.SolicitudCancelacionSAT = item.SolicitudCancelacionSAT;
                FactC.EstatusCancelacionSAT = item.EstatusCancelacionSAT;
                FactC.PreCancelacion = item.PreCancelacion;
                FactC.PreCancelacionCapturo = item.PreCancelacionCapturo;
                FactC.IntContable = item.IntContable;
                FactC.IntContablePoliza = item.IntContablePoliza;
                FactC.IntContablePolizaC = item.IntContablePolizaC;
                FactC.RetencionIVA = item.RetencionIVA;
                FactC.RetencionISR = item.RetencionISR;
                FactC.CancelacionMotivoClave = item.CancelacionMotivoClave;
                FactC.CancelacionUUIDRelacion = item.CancelacionUUIDRelacion;
                FactC.DescuentoIncluido = item.DescuentoIncluido;
                FactC.DescuentoIncluidoCIva = item.DescuentoIncluidoCIva;
                FactC.SubTotalIva0 = item.SubTotalIva0;
                FactC.SubTotalIva8 = item.SubTotalIva8;
                FactC.SubTotalIva16 = item.SubTotalIva16;

                db.SaveChanges();
                dynamic response = JsonConvert.SerializeObject(FactC);
                newLog.GenerarTXT("FactC Registrada" + response);

                return 1;
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
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                    }
                }
                return 0;
            }
            //try
            //{
            //    var claveRemC = db.SAVRemC.First();
            //    claveRemC.Cliente = claveRemC.Cliente + 1;

            //    db.SAVRemC.Add(item);
            //    db.SaveChanges();

            //    return 1;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property2: {0} Error: {1}",
            //                validationError.PropertyName,
            //                validationError.ErrorMessage);
            //            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

            //        }
            //    }
            //    return 0;
            //}
        }
        public int agregaFactCA(SAVFactCA item)
        {
            var FactCA = db.SAVFactCA.SingleOrDefault(c => c.Factura == item.Factura);

            if (FactCA != null)
            {

                //FactCA.Factura = item.Factura;
                FactCA.FacturaAnticipo = item.FacturaAnticipo;
                FactCA.Fecha = item.Fecha;
                FactCA.Total = item.Total;
                FactCA.Moneda = item.Moneda;
                FactCA.Paridad = item.Paridad;
                FactCA.UUID = item.UUID;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(FactCA);
                    newLog.GenerarTXT("FactCA Actualiza" + response);
                    return 2;
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
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                FactCA.Factura = item.Factura;
                FactCA.FacturaAnticipo = item.FacturaAnticipo;
                FactCA.Fecha = item.Fecha;
                FactCA.Total = item.Total;
                FactCA.Moneda = item.Moneda;
                FactCA.Paridad = item.Paridad;
                FactCA.UUID = item.UUID;

                db.SaveChanges();
                dynamic response = JsonConvert.SerializeObject(FactCA);
                newLog.GenerarTXT("FactC Registrada" + response);

                return 1;
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
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                    }
                }
                return 0;
            }
            //try
            //{
            //    var claveRemC = db.SAVRemC.First();
            //    claveRemC.Cliente = claveRemC.Cliente + 1;

            //    db.SAVRemC.Add(item);
            //    db.SaveChanges();

            //    return 1;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property2: {0} Error: {1}",
            //                validationError.PropertyName,
            //                validationError.ErrorMessage);
            //            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

            //        }
            //    }
            //    return 0;
            //}
        }
        public int agregaFactCFD(SAVFactCFD item)
        {
            var FactCFD = db.SAVFactCFD.SingleOrDefault(c => c.Factura == item.Factura);

            if (FactCFD != null)
            {
                //FactCFD.Factura = item.Factura;
                FactCFD.SerieCFD = item.SerieCFD;
                FactCFD.FacturaCFD = item.FacturaCFD;
                FactCFD.NombreCFD = item.NombreCFD;
                FactCFD.CFDCancelado = item.CFDCancelado;
                FactCFD.CFDSelloDigital = item.CFDSelloDigital;
                FactCFD.CFDXML = item.CFDXML;
                FactCFD.CFDCadenaOriginal = item.CFDCadenaOriginal;
                FactCFD.CFDCertificado = item.CFDCertificado;
                FactCFD.AprobacionNumero = item.AprobacionNumero;
                FactCFD.AprobacionAge = item.AprobacionAge;
                FactCFD.FacturaTotal = item.FacturaTotal;
                FactCFD.FacturaIva = item.FacturaIva;
                FactCFD.Capturo = item.Capturo;
                FactCFD.FechaAlta = item.FechaAlta;
                FactCFD.FechaAltaHora = item.FechaAltaHora;
                FactCFD.CFDCanceladoFecha = item.CFDCanceladoFecha;
                FactCFD.CFDCanceladoHora = item.CFDCanceladoHora;
                FactCFD.RFC = item.RFC;
                FactCFD.EnvioFTP = item.EnvioFTP;
                FactCFD.CFDCertificadoSAT = item.CFDCertificadoSAT;
                FactCFD.CFDSelloDigitalSAT = item.CFDSelloDigitalSAT;
                FactCFD.TimbradoFolioFiscal = item.TimbradoFolioFiscal;
                FactCFD.TimbradoFechaHora = item.TimbradoFechaHora;
                FactCFD.TimbradoCodigoQR = item.TimbradoCodigoQR;
                FactCFD.CFDIVersion = item.CFDIVersion;


                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(FactCFD);
                    newLog.GenerarTXT("FactCFD Actualiza" + response);
                    return 2;
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
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                FactCFD.Factura = item.Factura;
                FactCFD.SerieCFD = item.SerieCFD;
                FactCFD.FacturaCFD = item.FacturaCFD;
                FactCFD.NombreCFD = item.NombreCFD;
                FactCFD.CFDCancelado = item.CFDCancelado;
                FactCFD.CFDSelloDigital = item.CFDSelloDigital;
                FactCFD.CFDXML = item.CFDXML;
                FactCFD.CFDCadenaOriginal = item.CFDCadenaOriginal;
                FactCFD.CFDCertificado = item.CFDCertificado;
                FactCFD.AprobacionNumero = item.AprobacionNumero;
                FactCFD.AprobacionAge = item.AprobacionAge;
                FactCFD.FacturaTotal = item.FacturaTotal;
                FactCFD.FacturaIva = item.FacturaIva;
                FactCFD.Capturo = item.Capturo;
                FactCFD.FechaAlta = item.FechaAlta;
                FactCFD.FechaAltaHora = item.FechaAltaHora;
                FactCFD.CFDCanceladoFecha = item.CFDCanceladoFecha;
                FactCFD.CFDCanceladoHora = item.CFDCanceladoHora;
                FactCFD.RFC = item.RFC;
                FactCFD.EnvioFTP = item.EnvioFTP;
                FactCFD.CFDCertificadoSAT = item.CFDCertificadoSAT;
                FactCFD.CFDSelloDigitalSAT = item.CFDSelloDigitalSAT;
                FactCFD.TimbradoFolioFiscal = item.TimbradoFolioFiscal;
                FactCFD.TimbradoFechaHora = item.TimbradoFechaHora;
                FactCFD.TimbradoCodigoQR = item.TimbradoCodigoQR;
                FactCFD.CFDIVersion = item.CFDIVersion;

                db.SaveChanges();
                dynamic response = JsonConvert.SerializeObject(FactCFD);
                newLog.GenerarTXT("FactCFD Registrada" + response);

                return 1;
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
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                    }
                }
                return 0;
            }
            //try
            //{
            //    var claveRemC = db.SAVRemC.First();
            //    claveRemC.Cliente = claveRemC.Cliente + 1;

            //    db.SAVRemC.Add(item);
            //    db.SaveChanges();

            //    return 1;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property2: {0} Error: {1}",
            //                validationError.PropertyName,
            //                validationError.ErrorMessage);
            //            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

            //        }
            //    }
            //    return 0;
            //}
        }
        public int agregaFactD(SAVFactD item)
        {
            var FactD = db.SAVFactD.SingleOrDefault(c => c.Factura == item.Factura && c.Orden == item.Orden);

            if (FactD != null)
            {
                //FactD.Factura = item.Factura;
                //FactD.Orden = item.Orden;
                FactD.Tipo = item.Tipo;
                FactD.Clave = item.Clave;
                FactD.Descripcion = item.Descripcion;
                FactD.Monto = item.Monto;
                FactD.Descuento = item.Descuento;
                FactD.Comentario = item.Comentario;
                FactD.Cantidad = item.Cantidad;
                FactD.DescripcionAdicional = item.DescripcionAdicional;
                FactD.PorcIva = item.PorcIva;
                FactD.Desc1 = item.Desc1;
                FactD.Unidad = item.Unidad;
                FactD.FolioServicioProg = item.FolioServicioProg;
                FactD.PorcIvaRetencion = item.PorcIvaRetencion;
                FactD.PorcISRRetencion = item.PorcISRRetencion;
                FactD.DescuentoIncluido = item.DescuentoIncluido;
                FactD.DescuentoIncluidoCIva = item.DescuentoIncluidoCIva;
                FactD.SubTotal = item.SubTotal;
                FactD.Iva = item.Iva;
                FactD.IvaRetencion = item.IvaRetencion;
                FactD.ISRRetencion = item.ISRRetencion;
                FactD.TotalR = item.TotalR;
                FactD.SubTotalIva0 = item.SubTotalIva0;
                FactD.SubTotalIva8 = item.SubTotalIva8;
                FactD.SubTotalIva16 = item.SubTotalIva16;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(FactD);
                    newLog.GenerarTXT("FactD Actualiza" + response);
                    return 2;
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
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                FactD.Factura = item.Factura;
                FactD.Orden = item.Orden;
                FactD.Tipo = item.Tipo;
                FactD.Clave = item.Clave;
                FactD.Descripcion = item.Descripcion;
                FactD.Monto = item.Monto;
                FactD.Descuento = item.Descuento;
                FactD.Comentario = item.Comentario;
                FactD.Cantidad = item.Cantidad;
                FactD.DescripcionAdicional = item.DescripcionAdicional;
                FactD.PorcIva = item.PorcIva;
                FactD.Desc1 = item.Desc1;
                FactD.Unidad = item.Unidad;
                FactD.FolioServicioProg = item.FolioServicioProg;
                FactD.PorcIvaRetencion = item.PorcIvaRetencion;
                FactD.PorcISRRetencion = item.PorcISRRetencion;
                FactD.DescuentoIncluido = item.DescuentoIncluido;
                FactD.DescuentoIncluidoCIva = item.DescuentoIncluidoCIva;
                FactD.SubTotal = item.SubTotal;
                FactD.Iva = item.Iva;
                FactD.IvaRetencion = item.IvaRetencion;
                FactD.ISRRetencion = item.ISRRetencion;
                FactD.TotalR = item.TotalR;
                FactD.SubTotalIva0 = item.SubTotalIva0;
                FactD.SubTotalIva8 = item.SubTotalIva8;
                FactD.SubTotalIva16 = item.SubTotalIva16;

                db.SaveChanges();
                dynamic response = JsonConvert.SerializeObject(FactD);
                newLog.GenerarTXT("FactD Registrada" + response);

                return 1;
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
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                    }
                }
                return 0;
            }
            //try
            //{
            //    var claveRemC = db.SAVRemC.First();
            //    claveRemC.Cliente = claveRemC.Cliente + 1;

            //    db.SAVRemC.Add(item);
            //    db.SaveChanges();

            //    return 1;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property2: {0} Error: {1}",
            //                validationError.PropertyName,
            //                validationError.ErrorMessage);
            //            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

            //        }
            //    }
            //    return 0;
            //}
        }
        public int agregaObraServicioProg(SAVObraServicioProg item)
        {
            var ObraServicioProg = db.SAVObraServicioProg.SingleOrDefault(c => c.Obra == item.Obra && c.Folio == item.Folio);

            if (ObraServicioProg != null)
            {
                //ObraServicioProg.Obra = item.Obra;
                //ObraServicioProg.Folio = item.Folio;
                ObraServicioProg.Tipo = item.Tipo;
                ObraServicioProg.Clave = item.Clave;
                ObraServicioProg.Fecha = item.Fecha;
                ObraServicioProg.Cliente = item.Cliente;
                ObraServicioProg.Descripcion = item.Descripcion;
                ObraServicioProg.Monto = item.Monto;
                ObraServicioProg.Moneda = item.Moneda;
                ObraServicioProg.Descuento = item.Descuento;
                ObraServicioProg.Comentario = item.Comentario;
                ObraServicioProg.Cantidad = item.Cantidad;
                ObraServicioProg.DescripcionAdicional = item.DescripcionAdicional;
                ObraServicioProg.PorcIva = item.PorcIva;
                ObraServicioProg.Desc1 = item.Desc1;
                ObraServicioProg.Unidad = item.Unidad;
                ObraServicioProg.Capturo = item.Capturo;
                ObraServicioProg.FechaAlta = item.FechaAlta;
                ObraServicioProg.FechaAltaHora = item.FechaAltaHora;
                ObraServicioProg.Cobrado = item.Cobrado;
                ObraServicioProg.CobradoTipo = item.CobradoTipo;
                ObraServicioProg.CobradoNumero = item.CobradoNumero;
                ObraServicioProg.CobradoFecha = item.CobradoFecha;
                ObraServicioProg.CobradoCapturo = item.CobradoCapturo;
                ObraServicioProg.CapturoCambio = item.CapturoCambio;
                ObraServicioProg.UltimoCambio = item.UltimoCambio;
                ObraServicioProg.UltimoCambioHora = item.UltimoCambioHora;
                ObraServicioProg.Consolida = item.Consolida;
                ObraServicioProg.Remisiona = item.Remisiona;
                ObraServicioProg.Consolidacion = item.Consolidacion;
                ObraServicioProg.Agrupacion = item.Agrupacion;
                ObraServicioProg.Referencia = item.Referencia;
                ObraServicioProg.Muestreador = item.Muestreador;
                ObraServicioProg.MuestreadorNombre = item.MuestreadorNombre;
                ObraServicioProg.Seleccion = item.Seleccion;
                ObraServicioProg.CobroS = item.CobroS;
                ObraServicioProg.CobroSFecha = item.CobroSFecha;
                ObraServicioProg.CobroSFormaPago = item.CobroSFormaPago;
                ObraServicioProg.CobroSBanco = item.CobroSBanco;
                ObraServicioProg.CobroSCuenta = item.CobroSCuenta;
                ObraServicioProg.CobroSBancoDeposito = item.CobroSBancoDeposito;
                ObraServicioProg.CobroSCapturo = item.CobroSCapturo;
                ObraServicioProg.FolioVisita = item.FolioVisita;
                ObraServicioProg.Origen = item.Origen;
                ObraServicioProg.Cancelado = item.Cancelado;
                ObraServicioProg.CanceladoFecha = item.CanceladoFecha;
                ObraServicioProg.CanceladoCapturo = item.CanceladoCapturo;
                ObraServicioProg.PorcIvaRetencion = item.PorcIvaRetencion;
                ObraServicioProg.PorcISRRetencion = item.PorcISRRetencion;


                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(ObraServicioProg);
                    newLog.GenerarTXT("ObraServicioProg Actualiza" + response);
                    return 2;
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
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                ObraServicioProg.Obra = item.Obra;
                ObraServicioProg.Folio = item.Folio;
                ObraServicioProg.Tipo = item.Tipo;
                ObraServicioProg.Clave = item.Clave;
                ObraServicioProg.Fecha = item.Fecha;
                ObraServicioProg.Cliente = item.Cliente;
                ObraServicioProg.Descripcion = item.Descripcion;
                ObraServicioProg.Monto = item.Monto;
                ObraServicioProg.Moneda = item.Moneda;
                ObraServicioProg.Descuento = item.Descuento;
                ObraServicioProg.Comentario = item.Comentario;
                ObraServicioProg.Cantidad = item.Cantidad;
                ObraServicioProg.DescripcionAdicional = item.DescripcionAdicional;
                ObraServicioProg.PorcIva = item.PorcIva;
                ObraServicioProg.Desc1 = item.Desc1;
                ObraServicioProg.Unidad = item.Unidad;
                ObraServicioProg.Capturo = item.Capturo;
                ObraServicioProg.FechaAlta = item.FechaAlta;
                ObraServicioProg.FechaAltaHora = item.FechaAltaHora;
                ObraServicioProg.Cobrado = item.Cobrado;
                ObraServicioProg.CobradoTipo = item.CobradoTipo;
                ObraServicioProg.CobradoNumero = item.CobradoNumero;
                ObraServicioProg.CobradoFecha = item.CobradoFecha;
                ObraServicioProg.CobradoCapturo = item.CobradoCapturo;
                ObraServicioProg.CapturoCambio = item.CapturoCambio;
                ObraServicioProg.UltimoCambio = item.UltimoCambio;
                ObraServicioProg.UltimoCambioHora = item.UltimoCambioHora;
                ObraServicioProg.Consolida = item.Consolida;
                ObraServicioProg.Remisiona = item.Remisiona;
                ObraServicioProg.Consolidacion = item.Consolidacion;
                ObraServicioProg.Agrupacion = item.Agrupacion;
                ObraServicioProg.Referencia = item.Referencia;
                ObraServicioProg.Muestreador = item.Muestreador;
                ObraServicioProg.MuestreadorNombre = item.MuestreadorNombre;
                ObraServicioProg.Seleccion = item.Seleccion;
                ObraServicioProg.CobroS = item.CobroS;
                ObraServicioProg.CobroSFecha = item.CobroSFecha;
                ObraServicioProg.CobroSFormaPago = item.CobroSFormaPago;
                ObraServicioProg.CobroSBanco = item.CobroSBanco;
                ObraServicioProg.CobroSCuenta = item.CobroSCuenta;
                ObraServicioProg.CobroSBancoDeposito = item.CobroSBancoDeposito;
                ObraServicioProg.CobroSCapturo = item.CobroSCapturo;
                ObraServicioProg.FolioVisita = item.FolioVisita;
                ObraServicioProg.Origen = item.Origen;
                ObraServicioProg.Cancelado = item.Cancelado;
                ObraServicioProg.CanceladoFecha = item.CanceladoFecha;
                ObraServicioProg.CanceladoCapturo = item.CanceladoCapturo;
                ObraServicioProg.PorcIvaRetencion = item.PorcIvaRetencion;
                ObraServicioProg.PorcISRRetencion = item.PorcISRRetencion;

                db.SaveChanges();
                dynamic response = JsonConvert.SerializeObject(ObraServicioProg);
                newLog.GenerarTXT("ObraServicioProg Registrada" + response);

                return 1;
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
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                    }
                }
                return 0;
            }
            //try
            //{
            //    var claveRemC = db.SAVRemC.First();
            //    claveRemC.Cliente = claveRemC.Cliente + 1;

            //    db.SAVRemC.Add(item);
            //    db.SaveChanges();

            //    return 1;
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property2: {0} Error: {1}",
            //                validationError.PropertyName,
            //                validationError.ErrorMessage);
            //            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

            //        }
            //    }
            //    return 0;
            //}
        }
    }
}
