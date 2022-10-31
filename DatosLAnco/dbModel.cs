using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DatosLAnco
{
    public partial class dbModel : DbContext
    {
        public dbModel()
            : base("name=dbModel")
        {
        }

        public virtual DbSet<SAVCliente> SAVCliente { get; set; }
        public virtual DbSet<SAVFolio> SAVFolio { get; set; }
        public virtual DbSet<SAVObra> SAVObra { get; set; }
        public virtual DbSet<SAVFactC> SAVFactC { get; set; }
        public virtual DbSet<SAVFactCA> SAVFactCA { get; set; }
        public virtual DbSet<SAVFactCFD> SAVFactCFD { get; set; }
        public virtual DbSet<SAVFactD> SAVFactD { get; set; }
        public virtual DbSet<SAVObraServicioProg> SAVObraServicioProg { get; set; }
        public virtual DbSet<SAVRemC> SAVRemC { get; set; }
        public virtual DbSet<SAVRemCA> SAVRemCA { get; set; }
        public virtual DbSet<SAVRemD> SAVRemD { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Clave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Contacto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Direccion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Colonia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Ciudad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Pais)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.TelefonoOficina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.TelefonoCasa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Fax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.RFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Beeper)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.NC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.CodigoArea)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Giro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Zona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.AuxA1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.AuxA2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.AuxN1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.AuxN2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Recomendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Celular)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Web)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.NombreComercial)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.FacturarA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.CapturoCambio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.EntreCalle1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.EntreCalle2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Delegacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.SaldoAnterior)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.GeneroECCapturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Anticipo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Ruta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Asignado)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.ServiciosPendRemisionar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.MetododePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.NumCtaPago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.FormadePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.UsoCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.AuxMP)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.CuentaOficina)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.SubCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.CuentaOficina2)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.Cuenta2)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.SubCuenta2)
                .IsUnicode(false);

            modelBuilder.Entity<SAVCliente>()
                .Property(e => e.RegimenFiscalClave)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFolio>()
                .Property(e => e.Sistema)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Nombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ObraClave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Direccion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Colonia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Ciudad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Pais)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Telefono)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.EncargadoObra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.EncargadoObraTel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.EncargadoPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.EncargadoPagoTel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.DiasRevision)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.HoraRevision)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.DiasCobro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.HorasCobro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ReportarInc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ReportarIncTel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.NombreReporte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ConsignadoA)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.FacturarA)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ClienteNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.CapturoCambio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.CodigoArea)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.RFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Giro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Zona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Familia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Delegacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.NC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.SaldoAnterior)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.GeneroECCapturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Aux1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Aux2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Ubicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Horario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.HorarioSabado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.HorarioDomingo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Pasaje)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Ruta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.RevisionFacturas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.RevisionPeriodicidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.RevisionPeriodicidadDia1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.RevisionPeriodicidadDia2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.RevisionHorario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ReportesEntrega)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ReportesPeriodicidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ReportesPeriodicidadDia1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ReportesPeriodicidadDia2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ReportesHorario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Presupuesto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.PresupuestoPeriodicidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.PresupuestoPeriodicidadDia1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.PresupuestoPeriodicidadDia2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.PresupuestoHorario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Cobranza)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.CobranzaPeriodicidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.CobranzaPeriodicidadDia1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.CobranzaPeriodicidadDia2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.CobranzaHorario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.TipoCobro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Horario2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.HorarioSabado2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.HorarioDomingo2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ServiciosPendRemisionar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.NombreF)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.DireccionF)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.NumExteriorF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.NumInteriorF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.ColoniaF)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.DelegacionF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.CPF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.CiudadF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.EstadoF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.PaisF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.EmailF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.MetododePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.NumCtaPago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.EmailC)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Aux3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.Aux4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.LimiteCredito)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.OCObservaciones)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.FormadePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.UsoCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.AuxMP)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.SerieF)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObra>()
                .Property(e => e.RegimenFiscalClave)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.FacturarA)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.TipoCambio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.PorcIva)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.IVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Pagado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.TotalLetra)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.NCredito)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Vendedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Giro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Zona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.RFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.ObraClave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Impresiones)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.CancelacionCapturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.ConsignadoA)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.ObraUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.CancelacionMotivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.Remision)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.CancelacionSustituye)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.NCargo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.SerieCFD)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.MetododePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.NumCtaPago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.CapturoCambio)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.FormadePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.UsoCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.FacturaSustituye)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.SolicitudCancelacionSAT)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.EstatusCancelacionSAT)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.PreCancelacionCapturo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.RetencionIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.RetencionISR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.CancelacionMotivoClave)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.CancelacionUUIDRelacion)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.DescuentoIncluido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.DescuentoIncluidoCIva)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.SubTotalIva0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.SubTotalIva8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactC>()
                .Property(e => e.SubTotalIva16)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCA>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCA>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCA>()
                .Property(e => e.Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCA>()
                .Property(e => e.Paridad)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCA>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.SerieCFD)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.NombreCFD)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.CFDSelloDigital)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.CFDXML)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.CFDCadenaOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.CFDCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.FacturaTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.FacturaIva)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.Capturo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.EnvioFTP)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.CFDCertificadoSAT)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.CFDSelloDigitalSAT)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.TimbradoFolioFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCFD>()
                .Property(e => e.TimbradoFechaHora)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.Clave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.Descripcion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.DescripcionAdicional)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.Desc1)
                .HasPrecision(18, 12);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.Unidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.PorcIvaRetencion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.PorcISRRetencion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.DescuentoIncluido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.DescuentoIncluidoCIva)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.Iva)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.IvaRetencion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.ISRRetencion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.TotalR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.SubTotalIva0)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.SubTotalIva8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactD>()
                .Property(e => e.SubTotalIva16)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Clave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Descripcion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Moneda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.DescripcionAdicional)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Unidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.CobradoTipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.CobradoNumero)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.CobradoCapturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.CapturoCambio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Muestreador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.MuestreadorNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.CobroSFormaPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.CobroSBanco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.CobroSCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.CobroSBancoDeposito)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.CobroSCapturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.Origen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.CanceladoCapturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.PorcIvaRetencion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVObraServicioProg>()
                .Property(e => e.PorcISRRetencion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Remision)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.FacturarA)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.TipoCambio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.PorcIva)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.IVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Pagado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.TotalLetra)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.NCredito)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Vendedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Giro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Zona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.RFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.ObraClave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Impresiones)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.CancelacionCapturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.ConsignadoA)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.ObraUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.CancelacionMotivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.FacturadoFactura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.CancelacionSustituye)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Aux1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.Aux2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.MetododePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.NumCtaPago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.FacturadoFacturaOriginal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.CapturoCambio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.FormadePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.UsoCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.RetencionIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.RetencionISR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemC>()
                .Property(e => e.FacturaSustituye)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemCA>()
                .Property(e => e.Remision)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemCA>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemCA>()
                .Property(e => e.Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemCA>()
                .Property(e => e.Paridad)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemCA>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.Remision)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.Clave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.Descripcion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.DescripcionAdicional)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.Desc1)
                .HasPrecision(18, 12);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.Unidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.PorcIvaRetencion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVRemD>()
                .Property(e => e.PorcISRRetencion)
                .HasPrecision(19, 4);
        }
    }
}
