using DatosLAnco;
using MainLanco.Utilerias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MainLanco.Conexion
{
    public partial class Business
    {
        public int agregaCliente(SAVCliente item)
        {
            var Cliente = db.SAVCliente.SingleOrDefault ( c => c.Clave == item.Clave );

            if (Cliente != null)
            {
                //Cliente.Clave = item.Clave,
                Cliente.Empresa = item.Empresa;
                Cliente.Contacto = item.Contacto;
                Cliente.Direccion = item.Direccion;
                Cliente.Colonia = item.Colonia;
                Cliente.CP = item.CP;
                Cliente.Ciudad = item.Ciudad;
                Cliente.Estado = item.Estado;
                Cliente.Pais = item.Pais;
                Cliente.TelefonoOficina = item.TelefonoOficina;
                Cliente.TelefonoCasa = item.TelefonoCasa;
                Cliente.Fax = item.Fax;
                Cliente.Email = item.Email;
                Cliente.RFC = item.RFC;
                Cliente.Saldo = item.Saldo;
                Cliente.Bloqueado = item.Bloqueado;
                Cliente.FechaAlta = item.FechaAlta;
                Cliente.UltimoCambio = item.UltimoCambio;
                Cliente.UltimoMov = item.UltimoMov;
                Cliente.Status = item.Status;
                Cliente.Beeper = item.Beeper;
                Cliente.NC = item.NC;
                Cliente.CodigoArea = item.CodigoArea;
                Cliente.Giro = item.Giro;
                Cliente.Zona = item.Zona;
                Cliente.AuxA1 = item.AuxA1;
                Cliente.AuxA2 = item.AuxA2;
                Cliente.AuxN1 = item.AuxN1;
                Cliente.AuxN2 = item.AuxN2;
                Cliente.Recomendo = item.Recomendo;
                Cliente.Celular = item.Celular;
                Cliente.Web = item.Web;
                Cliente.NombreComercial = item.NombreComercial;
                Cliente.FacturarA = item.FacturarA;
                Cliente.Capturo = item.Capturo;
                Cliente.CapturoCambio = item.CapturoCambio;
                Cliente.EntreCalle1 = item.EntreCalle1;
                Cliente.EntreCalle2 = item.EntreCalle2;
                Cliente.FechaAltaHora = item.FechaAltaHora;
                Cliente.UltimoCambioHora = item.UltimoCambioHora;
                Cliente.Estatus = item.Estatus;
                Cliente.Delegacion = item.Delegacion;
                Cliente.SaldoAnterior = item.SaldoAnterior;
                Cliente.SaldoLimitePago = item.SaldoLimitePago;
                Cliente.GeneroECFecha = item.GeneroECFecha;
                Cliente.GeneroECCapturo = item.GeneroECCapturo;
                Cliente.EnvioEmail = item.EnvioEmail;
                Cliente.GeneroECDesde = item.GeneroECDesde;
                Cliente.GeneroECHasta = item.GeneroECHasta;
                Cliente.Htmlmail = item.Htmlmail;
                Cliente.UltimaRemision = item.UltimaRemision;
                Cliente.UltimaFactura = item.UltimaFactura;
                Cliente.Activa = item.Activa;
                Cliente.UltimoCobro = item.UltimoCobro;
                Cliente.Anticipo = item.Anticipo;
                Cliente.Ruta = item.Ruta;
                Cliente.Llamada = item.Llamada;
                Cliente.Asignado = item.Asignado;
                Cliente.ServiciosPendRemisionar = item.ServiciosPendRemisionar;
                Cliente.MetododePago = item.MetododePago;
                Cliente.NumCtaPago = item.NumCtaPago;
                Cliente.FormadePago = item.FormadePago;
                Cliente.UsoCFDI = item.UsoCFDI;
                Cliente.AuxMP = item.AuxMP;
                Cliente.CLIENTE_ID = item.CLIENTE_ID;
                Cliente.CuentaOficina = item.CuentaOficina;
                Cliente.Cuenta = item.Cuenta;
                Cliente.SubCuenta = item.SubCuenta;
                Cliente.CuentaOficina2 = item.CuentaOficina2;
                Cliente.Cuenta2 = item.Cuenta2;
                Cliente.SubCuenta2 = item.SubCuenta2;
                Cliente.RegimenFiscalClave = item.RegimenFiscalClave;

                try
                {
                    db.SaveChanges();   
                    dynamic response = JsonConvert.SerializeObject(Cliente);
                    newLog.GenerarTXT("ClienteActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach(var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach(var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveCliente = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Clave) > claveCliente.Cliente)
                {
                    claveCliente.Cliente = Int32.Parse(item.Clave); //AQUI TENGO DUDA
                }

                db.SAVCliente.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(Cliente);
                newLog.GenerarTXT("ClienteRegistrado" + response);

                return 1;
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach( var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property2: {0} Error: {1}",
                            validationError.PropertyName,
                            validationError.PropertyName);
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);
                    }
                }
                return 0;
            }
        }
        public int agregaObra(SAVObra item)
        {
           var Obra = db.SAVObra.SingleOrDefault(c => c.Obra == item.Obra);
                

            if (Obra != null)
            {

                Obra.Obra = item.Obra;
                Obra.Nombre = item.Nombre;
                Obra.ObraClave = item.ObraClave;
                Obra.Direccion = item.Direccion;
                Obra.Colonia = item.Colonia;
                Obra.CP = item.CP;
                Obra.Ciudad = item.Ciudad;
                Obra.Estado = item.Estado;
                Obra.Pais = item.Pais;
                Obra.Telefono = item.Telefono;
                Obra.EncargadoObra = item.EncargadoObra;
                Obra.EncargadoObraTel = item.EncargadoObraTel;
                Obra.EncargadoPago = item.EncargadoPago;
                Obra.EncargadoPagoTel = item.EncargadoPagoTel;
                Obra.DiasRevision = item.DiasRevision;
                Obra.HoraRevision = item.HoraRevision;
                Obra.DiasCobro = item.DiasCobro;
                Obra.HorasCobro = item.HorasCobro;
                Obra.ReportarInc = item.ReportarInc;
                Obra.ReportarIncTel = item.ReportarIncTel;
                Obra.NombreReporte = item.NombreReporte;
                Obra.ConsignadoA = item.ConsignadoA;
                Obra.FacturarA = item.FacturarA;
                Obra.Cliente = item.Cliente;
                Obra.ClienteNombre = item.ClienteNombre;
                Obra.NumCopias = item.NumCopias;
                Obra.FechaAlta = item.FechaAlta;
                Obra.FechaAltaHora = item.FechaAltaHora;
                Obra.Capturo = item.Capturo;
                Obra.CapturoCambio = item.CapturoCambio;
                Obra.UltimoCambio = item.UltimoCambio;
                Obra.UltimoCambioHora = item.UltimoCambioHora;
                Obra.CodigoArea = item.CodigoArea;
                Obra.Servicio = item.Servicio;
                Obra.Muestra = item.Muestra;
                Obra.Revenimiento = item.Revenimiento;
                Obra.RFC = item.RFC;
                Obra.Giro = item.Giro;
                Obra.Zona = item.Zona;
                Obra.Familia = item.Familia;
                Obra.Delegacion = item.Delegacion;
                Obra.Descuento = item.Descuento;
                Obra.Activa = item.Activa;
                Obra.UltimaRemision = item.UltimaRemision;
                Obra.UltimaFactura = item.UltimaFactura;
                Obra.Serv01Secuencia = item.Serv01Secuencia;
                Obra.FolioServicioProg = item.FolioServicioProg;
                Obra.Saldo = item.Saldo;
                Obra.NC = item.NC;
                Obra.Email = item.Email;
                Obra.SaldoAnterior = item.SaldoAnterior;
                Obra.SaldoLimitePago = item.SaldoLimitePago;
                Obra.GeneroECFecha = item.GeneroECFecha;
                Obra.GeneroECCapturo = item.GeneroECCapturo;
                Obra.EnvioEmail = item.EnvioEmail;
                Obra.GeneroECDesde = item.GeneroECDesde;
                Obra.GeneroECHasta = item.GeneroECHasta;
                Obra.HtmlMail = item.HtmlMail;
                Obra.UltimoMov = item.UltimoMov;
                Obra.Aux1 = item.Aux1;
                Obra.Aux2 = item.Aux2;
                Obra.Ubicacion = item.Ubicacion;
                Obra.Horario = item.Horario;
                Obra.HorarioDesde = item.HorarioDesde;
                Obra.HorarioHasta = item.HorarioHasta;
                Obra.HorarioSabado = item.HorarioSabado;
                Obra.HorarioSabadoDesde = item.HorarioSabadoDesde;
                Obra.HorarioSabadoHasta = item.HorarioSabadoHasta;
                Obra.HorarioDomingo = item.HorarioDomingo;
                Obra.HorarioDomingoDesde = item.HorarioDomingoDesde;
                Obra.HorarioDomingoHasta = item.HorarioDomingoHasta;
                Obra.UltimoCobro = item.UltimoCobro;
                Obra.Reg1 = item.Reg1;
                Obra.Serv01Copias = item.Serv01Copias;
                Obra.Serv02Secuencia = item.Serv02Secuencia;
                Obra.Viga = item.Viga;
                Obra.Mortero = item.Mortero;
                Obra.Enviado = item.Enviado;
                Obra.Serv03Ensaye = item.Serv03Ensaye;
                Obra.Serv04Ensaye = item.Serv04Ensaye;
                Obra.Pasaje = item.Pasaje;
                Obra.Corazon = item.Corazon;
                Obra.Arteza = item.Arteza;
                Obra.Ruta = item.Ruta;
                Obra.RevisionFacturas = item.RevisionFacturas;
                Obra.RevisionPeriodicidad = item.RevisionPeriodicidad;
                Obra.RevisionPeriodicidadDia1 = item.RevisionPeriodicidadDia1;
                Obra.RevisionPeriodicidadDia2 = item.RevisionPeriodicidadDia2;
                Obra.RevisionHorario = item.RevisionHorario;
                Obra.ReportesEntrega = item.ReportesEntrega;
                Obra.ReportesPeriodicidad = item.ReportesPeriodicidad;
                Obra.ReportesPeriodicidadDia1 = item.ReportesPeriodicidadDia1;
                Obra.ReportesPeriodicidadDia2 = item.ReportesPeriodicidadDia2;
                Obra.ReportesHorario = item.ReportesHorario;
                Obra.Presupuesto = item.Presupuesto;
                Obra.PresupuestoPeriodicidad = item.PresupuestoPeriodicidad;
                Obra.PresupuestoPeriodicidadDia1 = item.PresupuestoPeriodicidadDia1;
                Obra.PresupuestoPeriodicidadDia2 = item.PresupuestoPeriodicidadDia2;
                Obra.PresupuestoHorario = item.PresupuestoHorario;
                Obra.Cobranza = item.Cobranza;
                Obra.CobranzaPeriodicidad = item.CobranzaPeriodicidad;
                Obra.CobranzaPeriodicidadDia1 = item.CobranzaPeriodicidadDia1;
                Obra.CobranzaPeriodicidadDia2 = item.CobranzaPeriodicidadDia2;
                Obra.CobranzaHorario = item.CobranzaHorario;
                Obra.CobranzaPlazo = item.CobranzaPlazo;
                Obra.CobranzaActiva = item.CobranzaActiva;
                Obra.PVCobroSeparado = item.PVCobroSeparado;
                Obra.TipoCobro = item.TipoCobro;
                Obra.ConcretoC = item.ConcretoC;
                Obra.VigaC = item.VigaC;
                Obra.MorteroC = item.MorteroC;
                Obra.CorazonC = item.CorazonC;
                Obra.ArtezaC = item.ArtezaC;
                Obra.Cerrada = item.Cerrada;
                Obra.IgualaMensualDesde = item.IgualaMensualDesde;
                Obra.IgualaMensualHasta = item.IgualaMensualHasta;
                Obra.IgualaMensualUltMov = item.IgualaMensualUltMov;
                Obra.IgualaMensualUltCorrida = item.IgualaMensualUltCorrida;
                Obra.IgualaSemanalCobroMuestras = item.IgualaSemanalCobroMuestras;
                Obra.Horario2 = item.Horario2;
                Obra.HorarioDesde2 = item.HorarioDesde2;
                Obra.HorarioHasta2 = item.HorarioHasta2;
                Obra.HorarioSabado2 = item.HorarioSabado2;
                Obra.HorarioSabadoDesde2 = item.HorarioSabadoDesde2;
                Obra.HorarioSabadoHasta2 = item.HorarioSabadoHasta2;
                Obra.HorarioDomingo2 = item.HorarioDomingo2;
                Obra.HorarioDomingoDesde2 = item.HorarioDomingoDesde2;
                Obra.HorarioDomingoHasta2 = item.HorarioDomingoHasta2;
                Obra.DescuentoAutomatico = item.DescuentoAutomatico;
                Obra.ServiciosPendRemisionar = item.ServiciosPendRemisionar;
                Obra.Observaciones = item.Observaciones;
                Obra.DiasDesc = item.DiasDesc;
                Obra.FacturaElectronica = item.FacturaElectronica;
                Obra.NombreF = item.NombreF;
                Obra.DireccionF = item.DireccionF;
                Obra.NumExteriorF = item.NumExteriorF;
                Obra.NumInteriorF = item.NumInteriorF;
                Obra.ColoniaF = item.ColoniaF;
                Obra.DelegacionF = item.DelegacionF;
                Obra.CPF = item.CPF;
                Obra.CiudadF = item.CiudadF;
                Obra.EstadoF = item.EstadoF;
                Obra.PaisF = item.PaisF;
                Obra.EmailF = item.EmailF;
                Obra.CalaCobroSeparado = item.CalaCobroSeparado;
                Obra.MetododePago = item.MetododePago;
                Obra.NumCtaPago = item.NumCtaPago;
                Obra.EmailC = item.EmailC;
                Obra.Aux3 = item.Aux3;
                Obra.Aux4 = item.Aux4;
                Obra.LimiteCredito = item.LimiteCredito;
                Obra.OCFecha = item.OCFecha;
                Obra.OCObservaciones = item.OCObservaciones;
                Obra.FormadePago = item.FormadePago;
                Obra.UsoCFDI = item.UsoCFDI;
                Obra.AuxMP = item.AuxMP;
                Obra.ServEspSecuencia = item.ServEspSecuencia;
                Obra.ServEsp = item.ServEsp;
                Obra.SerieF = item.SerieF;
                Obra.RegimenFiscalClave = item.RegimenFiscalClave;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(Obra);
                    newLog.GenerarTXT("ObraActualiza" + response);

                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach(var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}",
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);
                        }
                       
                    }
                    return 0;
                }
                
            }
            try
            {
                var claveObra = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Obra) > claveObra.Obra)
                {
                    claveObra.Obra = Int32.Parse(item.Obra);
                }

                db.SAVObra.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(Obra);
                newLog.GenerarTXT("ObraRegistrada" + response);

                return 1;
            }
            catch (DbEntityValidationException dbEX)
            {
                foreach (var validationErrors in dbEX.EntityValidationErrors)
                {
                    foreach ( var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property2: {0} Error: {1}",
                            validationError.PropertyName,
                            validationError?.ErrorMessage);
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);
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
                RemC.FacturaSustituye = item.FacturaSustituye;
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
                var claveRemC = db.SAVFolio.First();

                // Actualiza el consecutivo
                if (Int32.Parse(item.Remision) > claveRemC.Remision)
                {
                    claveRemC.Remision = Int32.Parse(item.Remision);
                }

                db.SAVRemC.Add(item);
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
                        Trace.TraceInformation("Property2: {0} Error: {1}",
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                        newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + " " + validationError.ErrorMessage);

                    }
                }
                return 0;
            }
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

                // Actualiza el consecutivo
                var claveRemC = db.SAVFolio.First();

                if (Int32.Parse(item.Remision) > claveRemC.Remision)
                {
                    claveRemC.Remision = Int32.Parse(item.Remision);
                }
                db.SAVRemCA.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(item);
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
                var claveRemD = db.SAVFolio.First();

                // Actualiza el consecutivo
                if (Int32.Parse(item.Remision) > claveRemD.Remision)
                {
                    claveRemD.Remision = Int32.Parse(item.Remision);
                }

                db.SAVRemD.Add(item);
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
        }
        public int agregaFactC(SAVFactC item)
        {
            var FactC = db.SAVFactC.SingleOrDefault(c => c.Factura == item.Factura);

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
                // Actualiza el consecutivo
                var claveFactC = db.SAVFolio.First();

                if (Int32.Parse(item.Factura) > claveFactC.Factura)
                {
                    claveFactC.Factura = Int32.Parse(item.Factura);
                }

                db.SAVFactC.Add(item);
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
        }
        public int agregaFactCA(SAVFactCA item)
        {
            var FactCA = db.SAVFactCA.SingleOrDefault(c => c.Factura == item.Factura && c.FacturaAnticipo == item.FacturaAnticipo);

            if (FactCA != null)
            {

                //FactCA.Factura = item.Factura;
                //FactCA.FacturaAnticipo = item.FacturaAnticipo;
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
                // Actualiza el consecutivo
                var claveFactCA = db.SAVFolio.First();

                if (Int32.Parse(item.Factura) > claveFactCA.Factura)
                {
                    claveFactCA.Factura = Int32.Parse(item.Factura);
                }

                db.SAVFactCA.Add(item);

                db.SaveChanges();
                dynamic response = JsonConvert.SerializeObject(FactCA);
                newLog.GenerarTXT("FactCA Registrada" + response);

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
                // Actualiza el consecutivo
                var claveFactCFD = db.SAVFolio.First();

                if (Int32.Parse(item.Factura) > claveFactCFD.Factura)
                {
                    claveFactCFD.Factura = Int32.Parse(item.Factura);
                }

                db.SAVFactCFD.Add(item);
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
                // Actualiza el consecutivo
                var claveFactD = db.SAVFolio.First();

                if (Int32.Parse(item.Factura) > claveFactD.Factura)
                {
                    claveFactD.Factura = Int32.Parse(item.Factura);
                }

                db.SAVFactD.Add(item);

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
                // Actualiza el consecutivo //
                var claveObraServicioProg = db.SAVFolio.First();

                if (Int32.Parse(item.Obra) > claveObraServicioProg.Obra)
                {
                    claveObraServicioProg.Obra = Int32.Parse(item.Obra);
                }
                db.SAVObraServicioProg.Add(item);

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
        }
        public int agregaServ01(SAVServ01 item)
        {
            var Serv01 = db.SAVServ01.SingleOrDefault(c => c.Reporte == item.Reporte);

            if (Serv01 != null)
            {
                //Serv01.Reporte = item.Reporte;
                Serv01.Obra = item.Obra;
                Serv01.Fecha = item.Fecha;
                Serv01.ReporteFecha = item.ReporteFecha;
                Serv01.ObraClave = item.ObraClave;
                Serv01.ObraNombre = item.ObraNombre;
                Serv01.Cliente = item.Cliente;
                Serv01.ClienteNombre = item.ClienteNombre;
                Serv01.Premezcladora = item.Premezcladora;
                Serv01.PremezcladoraNombre = item.PremezcladoraNombre;
                Serv01.Muestreador = item.Muestreador;
                Serv01.MuestreadorNombre = item.MuestreadorNombre;
                Serv01.Resistencia = item.Resistencia;
                Serv01.Tipo = item.Tipo;
                Serv01.Calidad = item.Calidad;
                Serv01.Agregado = item.Agregado;
                Serv01.Revenimiento1 = item.Revenimiento1;
                Serv01.Revenimiento2 = item.Revenimiento2;
                Serv01.Volumen = item.Volumen;
                Serv01.Observaciones = item.Observaciones;
                Serv01.Capturo = item.Capturo;
                Serv01.FechaAlta = item.FechaAlta;
                Serv01.FechaAltaHora = item.FechaAltaHora;
                Serv01.CapturoCambio = item.CapturoCambio;
                Serv01.UltimoCambio = item.UltimoCambio;
                Serv01.UltimoCambioHora = item.UltimoCambioHora;
                Serv01.DiasCilindro1 = item.DiasCilindro1;
                Serv01.DiasCilindro2 = item.DiasCilindro2;
                Serv01.Planta = item.Planta;
                Serv01.PlantaNombre = item.PlantaNombre;
                Serv01.ObraServicio = item.ObraServicio;
                Serv01.Impresiones = item.Impresiones;
                Serv01.FolioVisita = item.FolioVisita;
                Serv01.DiasCilindro5 = item.DiasCilindro5;
                Serv01.DiasCilindro6 = item.DiasCilindro6;
                Serv01.TipoNombre = item.TipoNombre;
                Serv01.CapturaWeb = item.CapturaWeb;
                Serv01.AgendaMensajeria = item.AgendaMensajeria;
                Serv01.Temperatura = item.Temperatura;
                Serv01.Informe = item.Informe;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(Serv01);
                    newLog.GenerarTXT("Serv01Actualiza" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach(var validationError in validationErrors.ValidationErrors)
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
                var claveServ01 = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Reporte) > claveServ01.Serv01)
                {
                    claveServ01.Serv01 = Int32.Parse(item.Reporte);
                }

                db.SAVServ01.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(Serv01);
                newLog.GenerarTXT("Serv01" + response);

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

        public int agregaPersonal(SAVPersonal item)
        {
            var Personal = db.SAVPersonal.SingleOrDefault(c => c.Clave == item.Clave);

            if (Personal != null)
            {
                //Personal.Clave = item.Clave;
                Personal.Nombre = item.Nombre;
                Personal.Apellido1 = item.Apellido1;
                Personal.Apellido2 = item.Apellido2;
                Personal.Tipo = item.Tipo;
                Personal.Direccion = item.Direccion;
                Personal.Colonia = item.Colonia;
                Personal.CP = item.CP;
                Personal.Ciudad = item.Ciudad;
                Personal.Estado = item.Estado;//**************************************************
                Personal.Pais = item.Pais;
                Personal.TelefonoCasa = item.TelefonoCasa;
                Personal.Celular = item.Celular;
                Personal.Beeper = item.Beeper;
                Personal.Email = item.Email;
                Personal.Capturo = item.Capturo;
                Personal.FechaAlta = item.FechaAlta;
                Personal.FechaAltaHora = item.FechaAltaHora;
                Personal.CapturoCambio = item.CapturoCambio;
                Personal.UltimoCambio = item.UltimoCambio;
                Personal.UltimoCambioHora = item.UltimoCambioHora;
                Personal.Departamento = item.Departamento;
                Personal.FechaIngreso = item.FechaIngreso;
                Personal.FechaEgreso = item.FechaEgreso;
                Personal.Estatus = item.Estatus;
                Personal.SueldoBase = item.SueldoBase;
                Personal.FechaNacimiento = item.FechaNacimiento;
                Personal.CredencialElector = item.CredencialElector;
                Personal.LicenciaManejo = item.LicenciaManejo;
                Personal.CURP = item.CURP;
                Personal.RFC = item.RFC;
                Personal.HorarioDesde = item.HorarioDesde;
                Personal.HorarioHasta = item.HorarioHasta;
                Personal.Horario = item.Horario;
                Personal.HorarioSabado = item.HorarioSabado;
                Personal.HorarioSabadoDesde = item.HorarioSabadoDesde;
                Personal.HorarioSabadoHasta = item.HorarioSabadoHasta;
                Personal.HorarioDomingo = item.HorarioDomingo;
                Personal.HorarioDomingoDesde = item.HorarioDomingoDesde;
                Personal.HorarioDomingoHasta = item.HorarioDomingoHasta;
                Personal.Visitas = item.Visitas;
                Personal.Pago = item.Pago;
                Personal.Nota = item.Nota;
                Personal.Empresa = item.Empresa;
                Personal.AutorizaGastos = item.AutorizaGastos;
                Personal.Presupuestos = item.Presupuestos;


                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(Personal);
                    newLog.GenerarTXT("ClienteActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var clavePersonal = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Clave) > clavePersonal.Personal)
                {
                    clavePersonal.Personal = Int32.Parse(item.Clave); //AQUI TENGO DUDA
                }

                db.SAVPersonal.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(Personal);
                newLog.GenerarTXT("ClienteRegistrado" + response);

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

        public int agregaProveedor(SAVProveedor item)
        {
            var Proveedor = db.SAVProveedor.SingleOrDefault(c => c.Clave == item.Clave);

            if (Proveedor != null)
            {
                //Proveedor.Clave = item.Clave;
                Proveedor.Empresa = item.Empresa;
                Proveedor.Contacto = item.Contacto;
                Proveedor.Direccion = item.Direccion;
                Proveedor.Colonia = item.Colonia;
                Proveedor.CP = item.CP;
                Proveedor.Ciudad = item.Ciudad;
                Proveedor.Estado = item.Estado;
                Proveedor.Pais = item.Pais;
                Proveedor.TelefonoOficina = item.TelefonoOficina;
                Proveedor.TelefonoCasa = item.TelefonoCasa;
                Proveedor.Fax = item.Fax;
                Proveedor.Email = item.Email;
                Proveedor.RFC = item.RFC;
                Proveedor.Saldo = item.Saldo;
                Proveedor.Bloqueado = item.Bloqueado;
                Proveedor.FechaAlta = item.FechaAlta;
                Proveedor.UltimoCambio = item.UltimoCambio;
                Proveedor.UltimoMov = item.UltimoMov;
                Proveedor.Status = item.Status;
                Proveedor.Beeper = item.Beeper;
                Proveedor.NC = item.NC;
                Proveedor.CodigoArea = item.CodigoArea;
                Proveedor.Giro = item.Giro;
                Proveedor.Zona = item.Zona;
                Proveedor.AuxA1 = item.AuxA1;
                Proveedor.AuxA2 = item.AuxA2;
                Proveedor.AuxN1 = item.AuxN1;
                Proveedor.AuxN2 = item.AuxN2;
                Proveedor.Recomendo = item.Recomendo;
                Proveedor.Celular = item.Celular;
                Proveedor.Web = item.Web;
                Proveedor.NombreComercial = item.NombreComercial;
                Proveedor.Capturo = item.Capturo;
                Proveedor.CapturoCambio = item.CapturoCambio;
                Proveedor.EntreCalle1 = item.EntreCalle1;
                Proveedor.EntreCalle2 = item.EntreCalle2;
                Proveedor.FechaAltaHora = item.FechaAltaHora;
                Proveedor.UltimoCambioHora = item.UltimoCambioHora;
                Proveedor.Estatus = item.Estatus;
                Proveedor.Delegacion = item.Delegacion;
                Proveedor.SaldoAnterior = item.SaldoAnterior;
                Proveedor.SaldoLimitePago = item.SaldoLimitePago;
                Proveedor.GeneroECFecha = item.GeneroECFecha;
                Proveedor.GeneroECCapturo = item.GeneroECCapturo;
                Proveedor.EnvioEmail = item.EnvioEmail;
                Proveedor.GeneroECDesde = item.GeneroECDesde;
                Proveedor.GeneroECHasta = item.GeneroECHasta;
                Proveedor.HtmlMail = item.HtmlMail;
                Proveedor.ChequesANombre = item.ChequesANombre;
                Proveedor.Plazo = item.Plazo;
                Proveedor.Tipo = item.Tipo;
                Proveedor.SubContratista = item.SubContratista;
                Proveedor.Almacen = item.Almacen;
                Proveedor.TipoPago = item.TipoPago;
                Proveedor.ModuloCompras = item.ModuloCompras;
                Proveedor.TipoRecepcion = item.TipoRecepcion;
                Proveedor.Moneda = item.Moneda;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(Proveedor);
                    newLog.GenerarTXT("ProveedorActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveProveedor = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Clave) > claveProveedor.Proveedor)
                {
                    claveProveedor.Proveedor = Int32.Parse(item.Clave); 
                }

                db.SAVProveedor.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(Proveedor);
                newLog.GenerarTXT("ProveedorRegistrado" + response);

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

        public int agregaProveedorMS(SAVProveedorMS item)
        {
            var ProveedorMS = db.SAVProveedorMS.SingleOrDefault(c => c.Proveedor == item.Proveedor);

            if(ProveedorMS != null)
            {
                //ProveedorMS.Proveedor = item.Proveedor;
                ProveedorMS.Fecha = item.Fecha;
                ProveedorMS.Hora = item.Hora;
                ProveedorMS.Concepto = item.Concepto;
                ProveedorMS.Cargo = item.Cargo;
                ProveedorMS.Abono = item.Abono;
                ProveedorMS.Capturo = item.Capturo;
                ProveedorMS.Monto = item.Monto;
                ProveedorMS.Moneda = item.Moneda;
                ProveedorMS.TipoCambio = item.TipoCambio;
                ProveedorMS.Obra = item.Obra;
                ProveedorMS.Tipo = item.Tipo;
                ProveedorMS.Folio = item.Folio;
                ProveedorMS.Factura = item.Factura;
                ProveedorMS.NCredito = item.NCredito;
                ProveedorMS.FolioPago = item.FolioPago;
                ProveedorMS.ObraClave = item.ObraClave;
                ProveedorMS.Empresa = item.Empresa;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(ProveedorMS);
                    newLog.GenerarTXT("ProveedorMSActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveProveedorMS = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Proveedor) > claveProveedorMS.Proveedor)
                {
                    claveProveedorMS.Proveedor = Int32.Parse(item.Proveedor); //AQUI TENGO DUDA TAMPOCO ESTA EL CAMPO PROVEEDOR MS
                }

                db.SAVProveedorMS.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(ProveedorMS);
                newLog.GenerarTXT("ProveedorMSRegistrado" + response);

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

        public int agregaProveedorPagoC(SAVProveedorPagoC item)
        {
            var ProveedorPagoC = db.SAVProveedorPagoC.SingleOrDefault(c => c.Proveedor == item.Proveedor);

            if (ProveedorPagoC != null)
            {
                //ProveedorPagoC.Proveedor = item.Proveedor;
                ProveedorPagoC.Empresa = item.Empresa;
                ProveedorPagoC.Folio = item.Folio;
                ProveedorPagoC.Factura = item.Factura;
                ProveedorPagoC.ProveedorNombre = item.ProveedorNombre;
                ProveedorPagoC.Concepto = item.Concepto;
                ProveedorPagoC.Detalle = item.Detalle;
                ProveedorPagoC.Total = item.Total;
                ProveedorPagoC.FechaFactura = item.FechaFactura;
                ProveedorPagoC.NCredito = item.NCredito;
                ProveedorPagoC.Pagado = item.Pagado;
                ProveedorPagoC.Saldo = item.Saldo;
                ProveedorPagoC.Estatus = item.Estatus;
                ProveedorPagoC.Capturo = item.Capturo;
                ProveedorPagoC.FechaAlta = item.FechaAlta;
                ProveedorPagoC.FechaAltaHora = item.FechaAltaHora;
                ProveedorPagoC.Procesado = item.Procesado;
                ProveedorPagoC.Giro = item.Giro;
                ProveedorPagoC.Zona = item.Zona;
                ProveedorPagoC.Obra = item.Obra;
                ProveedorPagoC.LigaObra = item.LigaObra;
                ProveedorPagoC.ObraClave = item.ObraClave;
                ProveedorPagoC.CancelacionFecha = item.CancelacionFecha;
                ProveedorPagoC.CancelacionCapturo = item.CancelacionCapturo;
                ProveedorPagoC.CancelacionMotivo = item.CancelacionMotivo;
                ProveedorPagoC.CancelacionSustituye = item.CancelacionSustituye;
                ProveedorPagoC.Autorizacion = item.Autorizacion;
                ProveedorPagoC.Plazo = item.Plazo;
                ProveedorPagoC.ContraRecibo = item.ContraRecibo;
                ProveedorPagoC.TipoCambio = item.TipoCambio;
                ProveedorPagoC.SubContratista = item.SubContratista;
                ProveedorPagoC.PreAutorizacion = item.PreAutorizacion;
                ProveedorPagoC.RemisionCosto = item.RemisionCosto;
                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(ProveedorPagoC);
                    newLog.GenerarTXT("ProveedorPagoCActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }

            }
            try
            {
                var claveProveedorPagoC = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Proveedor) > claveProveedorPagoC.ProveedorPagoC)
                {
                    claveProveedorPagoC.ProveedorPagoC = Int32.Parse(item.Proveedor); 
                }

                db.SAVProveedorPagoC.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(ProveedorPagoC);
                newLog.GenerarTXT("ProveedorPagoCRegistrado" + response);

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
  
        public int agregaProveedorPagoD(SAVProveedorPagoD item)
        {
            var ProveedorPagoD = db.SAVProveedorPagoD.SingleOrDefault(c => c.Proveedor == item.Proveedor);

            if (ProveedorPagoD != null)
            {
                //ProveedorPagoD.Proveedor = item.Proveedor;
                ProveedorPagoD.Empresa = item.Empresa;
                ProveedorPagoD.Folio = item.Folio;
                ProveedorPagoD.FolioPago = item.FolioPago;
                ProveedorPagoD.Factura = item.Factura;
                ProveedorPagoD.ProveedorNombre = item.ProveedorNombre;
                ProveedorPagoD.Monto = item.Monto;
                ProveedorPagoD.EmpresaCheq = item.EmpresaCheq;
                ProveedorPagoD.Banco = item.Banco;
                ProveedorPagoD.Cuenta = item.Cuenta;
                ProveedorPagoD.Estatus = item.Estatus;
                ProveedorPagoD.Fecha = item.Fecha;
                ProveedorPagoD.Giro = item.Giro;
                ProveedorPagoD.Zona = item.Zona;
                ProveedorPagoD.FechaFactura = item.FechaFactura;
                ProveedorPagoD.Capturo = item.Capturo;
                ProveedorPagoD.FechaAlta = item.FechaAlta;
                ProveedorPagoD.FechaAltaHora = item.FechaAltaHora;
                ProveedorPagoD.Obra = item.Obra;
                ProveedorPagoD.Movimiento = item.Movimiento;
                ProveedorPagoD.Concepto = item.Concepto;
                ProveedorPagoD.Autorizacion = item.Autorizacion;
                ProveedorPagoD.TipoCambio = item.TipoCambio;
                ProveedorPagoD.NumCheque = item.NumCheque;
                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(ProveedorPagoD);
                    newLog.GenerarTXT("ProveedorPagoDActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }

            }
            try
            {
                var claveProveedorPagoD = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Proveedor) > claveProveedorPagoD.ProveedorPagoD)
                {
                    claveProveedorPagoD.ProveedorPagoD = Int32.Parse(item.Proveedor); 
                }

                db.SAVProveedorPagoD.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(ProveedorPagoD);
                newLog.GenerarTXT("ProveedorPagoDRegistrado" + response);

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

        public int agregaProveedorPagoI(SAVProveedorPagoI item)
        {
            var ProveedorPagoI = db.SAVProveedorPagoI.SingleOrDefault(c => c.Proveedor == item.Proveedor);

            if (ProveedorPagoI != null)
            {
                //ProveedorPagoI.Proveedor = item.Proveedor;
                ProveedorPagoI.Empresa = item.Empresa;
                ProveedorPagoI.FolioPagoInterno = item.FolioPagoInterno;
                ProveedorPagoI.ProveedorNombre = item.ProveedorNombre;
                ProveedorPagoI.Concepto = item.Concepto;
                ProveedorPagoI.Detalle = item.Detalle;
                ProveedorPagoI.Total = item.Total;
                ProveedorPagoI.Fecha = item.Fecha;
                ProveedorPagoI.Estatus = item.Estatus;
                ProveedorPagoI.Capturo = item.Capturo;
                ProveedorPagoI.FechaAlta = item.FechaAlta;
                ProveedorPagoI.FechaAltaHora = item.FechaAltaHora;
                ProveedorPagoI.Procesado = item.Procesado;
                ProveedorPagoI.Autorizacion = item.Autorizacion;
                ProveedorPagoI.TipoCambio = item.TipoCambio;
                ProveedorPagoI.EmpresaCheq = item.EmpresaCheq;
                ProveedorPagoI.Banco = item.Banco;
                ProveedorPagoI.Cuenta = item.Cuenta;
                ProveedorPagoI.NumCheque = item.NumCheque;
                ProveedorPagoI.PorComprobar = item.PorComprobar;
                ProveedorPagoI.FolioPagoInterno2 = item.FolioPagoInterno2;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(ProveedorPagoI);
                    newLog.GenerarTXT("ProveedorPagoIActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }

            }
            try
            {
                var claveProveedorPagoI= db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Proveedor) > claveProveedorPagoI.ProveedorPagoI)
                {
                    claveProveedorPagoI.ProveedorPagoI = Int32.Parse(item.Proveedor); 
                }

                db.SAVProveedorPagoI.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(ProveedorPagoI);
                newLog.GenerarTXT("ProveedorPagoIRegistrado" + response);

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

        public int agregaProveedorPagoR(SAVProveedorPagoR item)
        {
            var ProveedorPagoR = db.SAVProveedorPagoR.SingleOrDefault(c => c.Proveedor == item.Proveedor);

            if (ProveedorPagoR != null)
            {
                //ProveedorPagoR.Proveedor = item.Proveedor;
                ProveedorPagoR.Empresa = item.Empresa;
                ProveedorPagoR.Folio = item.Folio;
                ProveedorPagoR.Remision = item.Remision;
                ProveedorPagoR.Costo = item.Costo;
                ProveedorPagoR.PorcIva = item.PorcIva;
                ProveedorPagoR.Obra = item.Obra;
                ProveedorPagoR.ObraClave = item.ObraClave;
                ProveedorPagoR.Comentario = item.Comentario;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(ProveedorPagoR);
                    newLog.GenerarTXT("ProveedorPagoRActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveProveedorPagoR = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Proveedor) > claveProveedorPagoR.Proveedor) 
                {
                    claveProveedorPagoR.Proveedor = Int32.Parse(item.Proveedor); 
                }

                db.SAVProveedorPagoR.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(ProveedorPagoR);
                newLog.GenerarTXT("ProveedorPagoRRegistrado" + response);

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

        public int agregaFactCob(SAVFactCob item)
        {
            var FactCob = db.SAVFactCob.SingleOrDefault(c => c.Factura == item.Factura);

            if (FactCob != null)
            {
                //FactCob.Factura = item.Factura;
                FactCob.Cobro = item.Cobro;
                FactCob.Cliente = item.Cliente;
                FactCob.Monto = item.Monto;
                FactCob.FormaPago = item.FormaPago;
                FactCob.Banco = item.Banco;
                FactCob.Cuenta = item.Cuenta;
                FactCob.Expira = item.Expira;
                FactCob.Autorizacion = item.Autorizacion;
                FactCob.Estatus = item.Estatus;
                FactCob.Fecha = item.Fecha;
                FactCob.TipoCambio = item.TipoCambio;
                FactCob.CuentaNombre = item.CuentaNombre;
                FactCob.Giro = item.Giro;
                FactCob.Zona = item.Zona;
                FactCob.FechaFactura = item.FechaFactura;
                FactCob.Vendedor = item.Vendedor;
                FactCob.Corrida = item.Corrida;
                FactCob.BancoDeposito = item.BancoDeposito;
                FactCob.Capturo = item.Capturo;
                FactCob.Hora = item.Hora;
                FactCob.HoraFactura = item.HoraFactura;
                FactCob.PorcIVA = item.PorcIVA;
                FactCob.Obra = item.Obra;
                FactCob.Movimiento = item.Movimiento;
                FactCob.Referencia = item.Referencia;
                FactCob.Concepto = item.Concepto;
                FactCob.BancoCuenta = item.BancoCuenta;
                FactCob.Remision = item.Remision;
                FactCob.RemisionFecha = item.RemisionFecha;
                FactCob.CobroMultiple = item.CobroMultiple;
                FactCob.CapturoFecha = item.CapturoFecha;
                FactCob.CobroMultipleP = item.CobroMultipleP;
                FactCob.SerieCFD = item.SerieCFD;
                FactCob.FacturaCFD = item.FacturaCFD;
                FactCob.Recordatorio = item.Recordatorio;
                FactCob.Parcialidad = item.Parcialidad;
                FactCob.SaldoAnterior = item.SaldoAnterior;
                FactCob.SaldoPendiente = item.SaldoPendiente;
                FactCob.RFC = item.RFC;


                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(FactCob);
                    newLog.GenerarTXT("FactCobActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveFactCob = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (Int32.Parse(item.Factura) > claveFactCob.Factura) 
                {
                    claveFactCob.Factura = Int32.Parse(item.Factura);
                }

                db.SAVFactCob.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(FactCob);
                newLog.GenerarTXT("FactCobRegistrado" + response);

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


        public int agregaFactCobM(SAVFactCobM item)
        {
            var FactCobM = db.SAVFactCobM.SingleOrDefault(c => c.CobroMultiple == item.CobroMultiple);

            if (FactCobM != null)
            {
                //FactCobM.CobroMultiple = item.CobroMultiple;
                FactCobM.Cliente = item.Cliente;
                FactCobM.Monto = item.Monto;
                FactCobM.FormadePago = item.FormadePago;
                FactCobM.Banco = item.Banco;
                FactCobM.Cuenta = item.Cuenta;
                FactCobM.Expira = item.Expira;
                FactCobM.Autorizacion = item.Autorizacion;
                FactCobM.Estatus = item.Estatus;
                FactCobM.Fecha = item.Fecha;
                FactCobM.Hora = item.Hora;
                FactCobM.TipoCambio = item.TipoCambio;
                FactCobM.CuentaNombre = item.CuentaNombre;
                FactCobM.BancoDeposito = item.BancoDeposito;
                FactCobM.Referencia = item.Referencia;
                FactCobM.BancoCuenta = item.BancoCuenta;
                FactCobM.Capturo = item.Capturo;
                FactCobM.Moneda = item.Moneda;
                FactCobM.Facturas = item.Facturas;
                FactCobM.Comentarios = item.Comentarios;
                FactCobM.SubTotal = item.SubTotal;
                FactCobM.IVA = item.IVA;
                FactCobM.Total = item.Total;
                FactCobM.ClienteNombre = item.ClienteNombre;
                FactCobM.CapturoCambio = item.CapturoCambio;
                FactCobM.UltimoCambio = item.UltimoCambio;
                FactCobM.FacturaFechaDesde = item.FacturaFechaDesde;
                FactCobM.FacturaFechaHasta = item.FacturaFechaHasta;
                FactCobM.Impresiones = item.Impresiones;
                FactCobM.Anticipo = item.Anticipo;
                FactCobM.AnticipoFolio = item.AnticipoFolio;
                FactCobM.AnticipoAcred = item.AnticipoAcred;
                FactCobM.CobroMultipleP = item.CobroMultipleP;
                FactCobM.Serie = item.Serie;
                FactCobM.SerieCFD = item.SerieCFD;
                FactCobM.CobroCFD = item.CobroCFD;
                FactCobM.CFDIVersion = item.CFDIVersion;
                FactCobM.UUID = item.UUID;
                FactCobM.UsoCFDI = item.UsoCFDI;
                FactCobM.FormadePago = item.FormadePago;
                FactCobM.Tipo = item.Tipo;
                FactCobM.CodigoSAT = item.CodigoSAT;
                FactCobM.UnidadSAT = item.UnidadSAT;
                FactCobM.TotalLetra = item.TotalLetra;
                FactCobM.FechaAlta = item.FechaAlta;
                FactCobM.Obra = item.Obra;
                FactCobM.RFC = item.RFC;
                FactCobM.NumAsientos = item.NumAsientos;
                FactCobM.Cargos = item.Cargos;
                FactCobM.Abonos = item.Abonos;
                FactCobM.IntContable = item.IntContable;
                FactCobM.IntContableFecha = item.IntContableFecha;
                FactCobM.IntContableHora = item.IntContableHora;
                FactCobM.IntContableCapturo = item.IntContableCapturo;
                FactCobM.IntContablePoliza = item.IntContablePoliza;
                FactCobM.IntContableTotal = item.IntContableTotal;
                FactCobM.CancelacionMotivoClave = item.CancelacionMotivoClave;
                FactCobM.CancelacionUUIDRelacion = item.CancelacionUUIDRelacion;
                FactCobM.CobroMultipleSustituye = item.CobroMultipleSustituye;
                FactCobM.CancelacionFecha = item.CancelacionFecha;
                FactCobM.CancelacionCapturo = item.CancelacionCapturo;
                FactCobM.CancelacionMotivo = item.CancelacionMotivo;
                FactCobM.CancelacionMotivo2 = item.CancelacionMotivo2;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(FactCobM);
                    newLog.GenerarTXT("FactCobMActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveFactCobM = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (item.CobroMultiple > claveFactCobM.CobroMultiple) 
                {
                    claveFactCobM.CobroMultiple = item.CobroMultiple;
                }

                db.SAVFactCobM.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(FactCobM);
                newLog.GenerarTXT("FactCobMRegistrado" + response);

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

        public int agregaFactCobMCFD(SAVFactCobMCFD item)
        {
            var FactCobMCFD = db.SAVFactCobMCFD.SingleOrDefault(c => c.CobroMultiple == item.CobroMultiple);

            if (FactCobMCFD != null)
            {

                FactCobMCFD.Serie = item.Serie;
                //FactCobMCFD.CobroMultiple = item.CobroMultiple;
                FactCobMCFD.SerieCFD = item.SerieCFD;
                FactCobMCFD.CobroCFD = item.CobroCFD;
                FactCobMCFD.NombreCFD = item.NombreCFD;
                FactCobMCFD.CFDCancelado = item.CFDCancelado;
                FactCobMCFD.CFDSelloDigital = item.CFDSelloDigital;
                FactCobMCFD.CFDXML = item.CFDXML;
                FactCobMCFD.CFDCadenaOriginal = item.CFDCadenaOriginal;
                FactCobMCFD.CFDCertificado = item.CFDCertificado;
                FactCobMCFD.AprobacionNumero = item.AprobacionNumero;
                FactCobMCFD.AprobacionAge = item.AprobacionAge;
                FactCobMCFD.CobroTotal = item.CobroTotal;
                FactCobMCFD.Capturo = item.Capturo;
                FactCobMCFD.FechaAlta = item.FechaAlta;
                FactCobMCFD.FechaAltaHora = item.FechaAltaHora;
                FactCobMCFD.CFDCanceladoFecha = item.CFDCanceladoFecha;
                FactCobMCFD.CFDCanceladoHora = item.CFDCanceladoHora;
                FactCobMCFD.EnvioFTP = item.EnvioFTP;
                FactCobMCFD.CFDCertificadoSAT = item.CFDCertificadoSAT;
                FactCobMCFD.CFDSelloDigitalSAT = item.CFDSelloDigitalSAT;
                FactCobMCFD.TimbradoFolioFiscal = item.TimbradoFolioFiscal;
                FactCobMCFD.TimbradoFechaHora = item.TimbradoFechaHora;
                FactCobMCFD.CobroIva = item.CobroIva;
                FactCobMCFD.TimbradoCodigoQR = item.TimbradoCodigoQR;
                FactCobMCFD.CFDIVersion = item.CFDIVersion;
    
                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(FactCobMCFD);
                    newLog.GenerarTXT("FactCobMCFDActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveFactCobMCFD = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (item.CobroMultiple > claveFactCobMCFD.CobroMultiple) 
                {
                    claveFactCobMCFD.CobroMultiple = item.CobroMultiple;
                }

                db.SAVFactCobMCFD.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(FactCobMCFD);
                newLog.GenerarTXT("FactCobMCFDRegistrado" + response);

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
        public int agregaFactCobMP(SAVFactCobMP item)
        {
            var FactCobMP = db.SAVFactCobMP.SingleOrDefault(c => c.CobroMultipleP == item.CobroMultipleP);

            if (FactCobMP != null)
            {

                //FactCobMP.CobroMultipleP = item.CobroMultipleP;
                FactCobMP.Cliente = item.Cliente;
                FactCobMP.Monto = item.Monto;
                FactCobMP.FormaPago = item.FormaPago;
                FactCobMP.Banco = item.Banco;
                FactCobMP.Cuenta = item.Cuenta;
                FactCobMP.Expira = item.Expira;
                FactCobMP.Autorizacion = item.Autorizacion;
                FactCobMP.Estatus = item.Estatus;
                FactCobMP.Fecha = item.Fecha;
                FactCobMP.Hora = item.Hora;
                FactCobMP.TipoCambio = item.TipoCambio;
                FactCobMP.CuentaNombre = item.CuentaNombre;
                FactCobMP.BancoDeposito = item.BancoDeposito;
                FactCobMP.Referencia = item.Referencia;
                FactCobMP.BancoCuenta = item.BancoCuenta;
                FactCobMP.Capturo = item.Capturo;
                FactCobMP.Moneda = item.Moneda;
                FactCobMP.Facturas = item.Facturas;
                FactCobMP.Comentarios = item.Comentarios;
                FactCobMP.SubTotal = item.SubTotal;
                FactCobMP.IVA = item.IVA;
                FactCobMP.Total=item.Total;
                FactCobMP.ClienteNombre = item.ClienteNombre;
                FactCobMP.CapturoCambio = item.CapturoCambio;
                FactCobMP.UltimoCambio = item.UltimoCambio;
                FactCobMP.FacturaFechaDesde = item.FacturaFechaDesde;
                FactCobMP.FacturaFechaHasta = item.FacturaFechaHasta;
                FactCobMP.Impresiones = item.Impresiones;
                FactCobMP.Anticipo = item.Anticipo;
                FactCobMP.AnticipoFolio = item.AnticipoFolio;
                FactCobMP.AnticipoAcred = item.AnticipoAcred;
                FactCobMP.Ruta = item.Ruta;
                FactCobMP.Cobrador = item.Cobrador;
                FactCobMP.FechaAlta = item.FechaAlta;
                FactCobMP.FechaAltaHora = item.FechaAltaHora;
                FactCobMP.AcreditaCobro = item.AcreditaCobro;
                FactCobMP.AcreditaCorrida = item.AcreditaCorrida;
                FactCobMP.CFDIVersion = item.CFDIVersion;
                FactCobMP.UsoCFDI = item.UsoCFDI;
                FactCobMP.Obra = item.Obra;
                FactCobMP.RFC = item.RFC;
 
                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(FactCobMP);
                    newLog.GenerarTXT("FactCobMCFDActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveFactCobMP = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (item.CobroMultipleP > claveFactCobMP.CobroMultipleP) 
                {
                    claveFactCobMP.CobroMultipleP = item.CobroMultipleP;
                }

                db.SAVFactCobMP.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(FactCobMP);
                newLog.GenerarTXT("FactCobMPRegistrado" + response);

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

        public int agregaFactCobMPD(SAVFactCobMPD item)
        {
            var FactCobMPD = db.SAVFactCobMPD.SingleOrDefault(c => c.CobroMultipleP == item.CobroMultipleP);

            if (FactCobMPD != null)
            {
                //FactCobMPD.CobroMultipleP = item.CobroMultipleP;
                FactCobMPD.Factura = item.Factura;
                FactCobMPD.Cobro = item.Cobro;
                FactCobMPD.Cliente = item.Cliente;
                FactCobMPD.Monto = item.Monto;
                FactCobMPD.FacturaFecha = item.FacturaFecha;
                FactCobMPD.CobroFecha = item.CobroFecha;
                FactCobMPD.SaldoFactura = item.SaldoFactura;
                FactCobMPD.Obra = item.Obra;
                FactCobMPD.NCreditoAplicar = item.NCreditoAplicar;
                FactCobMPD.Descuento = item.Descuento;
                FactCobMPD.DescuentoMonto = item.DescuentoMonto;
                FactCobMPD.SerieCFD = item.SerieCFD;
                FactCobMPD.FacturaCFD = item.FacturaCFD;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(FactCobMPD);
                    newLog.GenerarTXT("FactCobMPDActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveFactCobMPD = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (item.CobroMultipleP > claveFactCobMPD.CobroMultipleP)
                {
                    claveFactCobMPD.CobroMultipleP = item.CobroMultipleP;
                }

                db.SAVFactCobMPD.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(FactCobMPD);
                newLog.GenerarTXT("FactCobMPDRegistrado" + response);

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
        public int agregaEmpresaCheq(SAVEmpresaCheq item)
        {
            var EmpresaCheq = db.SAVEmpresaCheq.SingleOrDefault(c => c.Empresa == item.Empresa);

            if (EmpresaCheq != null)
            {

                //EmpresaCheq.Empresa = item.Empresa;
                EmpresaCheq.Banco = item.Banco;
                EmpresaCheq.Cuenta = item.Cuenta;
                EmpresaCheq.Plaza = item.Plaza;
                EmpresaCheq.Saldo = item.Saldo;
                EmpresaCheq.Deposito = item.Deposito;
                EmpresaCheq.DepositoSBC = item.DepositoSBC;
                EmpresaCheq.PagoTransito = item.PagoTransito;
                EmpresaCheq.PagoFirme = item.PagoFirme;
                EmpresaCheq.FormatoCheque = item.FormatoCheque;
                EmpresaCheq.FormatoChequeInterno = item.FormatoChequeInterno;
                EmpresaCheq.NumCheque = item.NumCheque;
                EmpresaCheq.NumChequeIni = item.NumChequeIni;
                EmpresaCheq.NumChequeMax = item.NumChequeMax;
                EmpresaCheq.NumChequeAviso = item.NumChequeAviso;
                EmpresaCheq.FechaConciliacionCobros = item.FechaConciliacionCobros;
                EmpresaCheq.FechaConciliacionPagos = item.FechaConciliacionPagos;
                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(EmpresaCheq);
                    newLog.GenerarTXT("EmpresaCheqActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                //var claveEmpresaCheq = db.SAVFolio.First();

                ////Se actualiza el consecutivo
                //if (item.CobroMultipleP > claveEmpresaCheq.CobroMultipleP)
                //{
                //    claveEmpresaCheq.CobroMultipleP = item.CobroMultipleP;
                //}

                db.SAVEmpresaCheq.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(EmpresaCheq);
                newLog.GenerarTXT("EmpresaCheqRegistrado" + response);

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

        public int agregaEmpresaCheqM(SAVEmpresaCheqM item)
        {
            var EmpresaCheqM = db.SAVEmpresaCheqM.SingleOrDefault(c => c.Empresa == item.Empresa);

            if (EmpresaCheqM != null)
            {

                //EmpresaCheqM.Empresa = item.Empresa;
                EmpresaCheqM.Banco = item.Banco;
                EmpresaCheqM.Cuenta = item.Cuenta;
                EmpresaCheqM.Fecha = item.Fecha;
                EmpresaCheqM.Hora = item.Hora;
                EmpresaCheqM.Saldo = item.Saldo;
                EmpresaCheqM.Deposito = item.Deposito;
                EmpresaCheqM.DepositoSBC = item.DepositoSBC;
                EmpresaCheqM.PagoTransito = item.PagoTransito;
                EmpresaCheqM.PagoFirme = item.PagoFirme;
                EmpresaCheqM.Capturo = item.Capturo;
                EmpresaCheqM.Plaza = item.Plaza;
                EmpresaCheqM.Comentario = item.Comentario;
                EmpresaCheqM.DepositoPre = item.DepositoPre;
                EmpresaCheqM.SaldoPre = item.SaldoPre;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(EmpresaCheqM);
                    newLog.GenerarTXT("EmpresaCheqMActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                //var claveEmpresaCheq = db.SAVFolio.First();

                ////Se actualiza el consecutivo
                //if (item.CobroMultipleP > claveEmpresaCheq.CobroMultipleP)
                //{
                //    claveEmpresaCheq.CobroMultipleP = item.CobroMultipleP;
                //}

                db.SAVEmpresaCheqM.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(EmpresaCheqM);
                newLog.GenerarTXT("EmpresaCheqMRegistrado" + response);

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

        public int agregaEmpresaCheqMD(SAVEmpresaCheqMD item)
        {
            var EmpresaCheqMD = db.SAVEmpresaCheqMD.SingleOrDefault(c => c.FolioDeposito == item.FolioDeposito);

            if (EmpresaCheqMD != null)
            {

                EmpresaCheqMD.Empresa = item.Empresa;
                EmpresaCheqMD.Banco = item.Banco;
                EmpresaCheqMD.Cuenta = item.Cuenta;
                EmpresaCheqMD.Fecha = item.Fecha;
                EmpresaCheqMD.Hora = item.Hora;
                //EmpresaCheqMD.FolioDeposito = item.FolioDeposito;
                EmpresaCheqMD.Monto = item.Monto;   
                EmpresaCheqMD.Comentario = item.Comentario;
                EmpresaCheqMD.DepositoSBC = item.DepositoSBC;
                EmpresaCheqMD.Capturo = item.Capturo;
                EmpresaCheqMD.FechaAlta = item.FechaAlta;
                EmpresaCheqMD.FechaAltaHora = item.FechaAltaHora;
                EmpresaCheqMD.TipoDeposito = item.TipoDeposito;
                EmpresaCheqMD.CobroMultiple = item.CobroMultiple;
                EmpresaCheqMD.FolioAnticipo = item.FolioAnticipo;
                EmpresaCheqMD.Revisado = item.Revisado;

                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(EmpresaCheqMD);
                    newLog.GenerarTXT("EmpresaCheqMDActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveEmpresaCheqMD = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (item.FolioDeposito > claveEmpresaCheqMD.ProveedorCheqMD)
                {
                    claveEmpresaCheqMD.ProveedorCheqMD = item.FolioDeposito;
                }

                db.SAVEmpresaCheqMD.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(EmpresaCheqMD);
                newLog.GenerarTXT("EmpresaCheqMDRegistrado" + response);

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

        public int agregaEmpresaCheqMT(SAVEmpresaCheqMT item)
        {
            var EmpresaCheqMT = db.SAVEmpresaCheqMT.SingleOrDefault(c => c.FolioTemporal == item.FolioTemporal);

            if (EmpresaCheqMT != null)
            {

                EmpresaCheqMT.Empresa = item.Empresa;
                EmpresaCheqMT.Banco = item.Banco;
                EmpresaCheqMT.Cuenta = item.Cuenta;
                EmpresaCheqMT.Tipo = item.Tipo; 
                //EmpresaCheqMT.FolioTemporal = item.FolioTemporal;
                EmpresaCheqMT.Proveedor = item.Proveedor;
                EmpresaCheqMT.ProveedorNombre = item.ProveedorNombre;
                EmpresaCheqMT.FolioAdeudo = item.FolioAdeudo;
                EmpresaCheqMT.FolioPagoAdeudo = item.FolioAdeudo;
                EmpresaCheqMT.FolioPagoInterno = item.FolioPagoInterno;
                EmpresaCheqMT.Monto = item.Monto;
                EmpresaCheqMT.Fecha = item.Fecha;
                EmpresaCheqMT.Capturo = item.Capturo;
                EmpresaCheqMT.FechaAlta = item.FechaAlta;
                EmpresaCheqMT.FechaAltaHora = item.FechaAltaHora;
                EmpresaCheqMT.Concepto = item.Concepto;
                EmpresaCheqMT.Autorizacion = item.Autorizacion;
                EmpresaCheqMT.TipoCambio = item.TipoCambio;
                EmpresaCheqMT.Estatus = item.Estatus;
                EmpresaCheqMT.Detalle = item.Detalle;
                EmpresaCheqMT.Factura = item.Factura;
                EmpresaCheqMT.AdeudoTotal = item.AdeudoTotal;
                EmpresaCheqMT.AdeudoSaldo = item.AdeudoSaldo;
                EmpresaCheqMT.ChequesaNombre = item.ChequesaNombre;
                EmpresaCheqMT.NumCheque = item.NumCheque;
                EmpresaCheqMT.AdeudoNCredito = item.AdeudoNCredito;
                EmpresaCheqMT.Impresiones = item.Impresiones;
                EmpresaCheqMT.TipoPago = item.TipoPago;
                EmpresaCheqMT.PorComprobar = item.PorComprobar;
                EmpresaCheqMT.FolioPagoInterno2 = item.FolioPagoInterno2;
                EmpresaCheqMT.FormaPago = item.FormaPago;
                EmpresaCheqMT.Traspaso = item.Traspaso;
                EmpresaCheqMT.FolioPersonalGasto = item.FolioPersonalGasto;
                EmpresaCheqMT.ProveedorTipoPago = item.ProveedorTipoPago;


                try
                {
                    db.SaveChanges();
                    dynamic response = JsonConvert.SerializeObject(EmpresaCheqMT);
                    newLog.GenerarTXT("EmpresaCheqMDActualizado" + response);
                    return 2;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1]",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                            newLog.GenerarTXT("Propiedad name: " + validationError.PropertyName + "" + validationError.ErrorMessage);

                        }
                    }
                    return 0;
                }
            }
            try
            {
                var claveEmpresaCheqMT = db.SAVFolio.First();

                //Se actualiza el consecutivo
                if (item.FolioTemporal > claveEmpresaCheqMT.ProveedorCheqMT)
                {
                    claveEmpresaCheqMT.ProveedorCheqMT = item.FolioTemporal;
                }

                db.SAVEmpresaCheqMT.Add(item);
                db.SaveChanges();

                dynamic response = JsonConvert.SerializeObject(EmpresaCheqMT);
                newLog.GenerarTXT("EmpresaCheqMTRegistrado" + response);

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
    }

}
