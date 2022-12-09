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
        public virtual DbSet<SAVEmpresaCheq> SAVEmpresaCheq { get; set; }
        public virtual DbSet<SAVEmpresaCheqM> SAVEmpresaCheqM { get; set; }
        public virtual DbSet<SAVEmpresaCheqMD> SAVEmpresaCheqMD { get; set; }
        public virtual DbSet<SAVEmpresaCheqMT> SAVEmpresaCheqMT { get; set; }
        public virtual DbSet<SAVFactC> SAVFactC { get; set; }
        public virtual DbSet<SAVFactCA> SAVFactCA { get; set; }
        public virtual DbSet<SAVFactCFD> SAVFactCFD { get; set; }
        public virtual DbSet<SAVFactCob> SAVFactCob { get; set; }
        public virtual DbSet<SAVFactCobM> SAVFactCobM { get; set; }
        public virtual DbSet<SAVFactCobMCFD> SAVFactCobMCFD { get; set; }
        public virtual DbSet<SAVFactCobMP> SAVFactCobMP { get; set; }
        public virtual DbSet<SAVFactCobMPD> SAVFactCobMPD { get; set; }
        public virtual DbSet<SAVFactD> SAVFactD { get; set; }
        public virtual DbSet<SAVNCred> SAVNCred { get; set; }
        public virtual DbSet<SAVObraServicioProg> SAVObraServicioProg { get; set; }
        public virtual DbSet<SAVPersonal> SAVPersonal { get; set; }
        public virtual DbSet<SAVProveedor> SAVProveedor { get; set; }
        public virtual DbSet<SAVProveedorMS> SAVProveedorMS { get; set; }
        public virtual DbSet<SAVProveedorPagoC> SAVProveedorPagoC { get; set; }
        public virtual DbSet<SAVProveedorPagoD> SAVProveedorPagoD { get; set; }
        public virtual DbSet<SAVProveedorPagoI> SAVProveedorPagoI { get; set; }
        public virtual DbSet<SAVProveedorPagoR> SAVProveedorPagoR { get; set; }
        public virtual DbSet<SAVRemC> SAVRemC { get; set; }
        public virtual DbSet<SAVRemCA> SAVRemCA { get; set; }
        public virtual DbSet<SAVRemD> SAVRemD { get; set; }
        public virtual DbSet<SAVServ01> SAVServ01 { get; set; }

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

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.Plaza)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.Deposito)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.DepositoSBC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.PagoTransito)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.PagoFirme)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.FormatoCheque)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheq>()
                .Property(e => e.FormatoChequeInterno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.Deposito)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.DepositoSBC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.PagoTransito)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.PagoFirme)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.Plaza)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.Comentario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.DepositoPre)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqM>()
                .Property(e => e.SaldoPre)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqMD>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMD>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMD>()
                .Property(e => e.Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMD>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqMD>()
                .Property(e => e.Comentario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMD>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMD>()
                .Property(e => e.TipoDeposito)
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.ProveedorNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.TipoCambio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Detalle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.AdeudoTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.AdeudoSaldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.ChequesaNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.NumCheque)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.AdeudoNCredito)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.TipoPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.FormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVEmpresaCheqMT>()
                .Property(e => e.ProveedorTipoPago)
                .IsFixedLength()
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

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.FormaPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Expira)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.TipoCambio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.CuentaNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Giro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Zona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Vendedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.BancoDeposito)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.PorcIVA)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.BancoCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.Remision)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.SerieCFD)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.SaldoAnterior)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.SaldoPendiente)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCob>()
                .Property(e => e.RFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.FormaPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Expira)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.TipoCambio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.CuentaNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.BancoDeposito)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.BancoCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Capturo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.IVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.ClienteNombre)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.CapturoCambio)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Anticipo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.SerieCFD)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.UsoCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.FormadePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.CodigoSAT)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.UnidadSAT)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.TotalLetra)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.RFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Cargos)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.Abonos)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.IntContableCapturo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.IntContableTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.CancelacionMotivoClave)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.CancelacionUUIDRelacion)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.CancelacionCapturo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.CancelacionMotivo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobM>()
                .Property(e => e.CancelacionMotivo2)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.SerieCFD)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.NombreCFD)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.CFDSelloDigital)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.CFDXML)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.CFDCadenaOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.CFDCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.CobroTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.Capturo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.EnvioFTP)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.CFDCertificadoSAT)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.CFDSelloDigitalSAT)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.TimbradoFolioFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.TimbradoFechaHora)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMCFD>()
                .Property(e => e.CobroIva)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.FormaPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Expira)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.TipoCambio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.CuentaNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.BancoDeposito)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.BancoCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Capturo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.IVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.ClienteNombre)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.CapturoCambio)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Anticipo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Ruta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Cobrador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.UsoCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMP>()
                .Property(e => e.RFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMPD>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMPD>()
                .Property(e => e.Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMPD>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMPD>()
                .Property(e => e.SaldoFactura)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMPD>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVFactCobMPD>()
                .Property(e => e.DescuentoMonto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVFactCobMPD>()
                .Property(e => e.SerieCFD)
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

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.NCredito)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.PorcIVA)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.IVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.TotalLetra)
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.FacturarA)
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.ClienteNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.RFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Remision)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.ObraNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.FacturaMonto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.ObraClave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.Aplicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.CapturoCambio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.SerieCFD)
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.MetododePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.NumCtaPago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.FormadePago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.UsoCFDI)
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.RetencionIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.RetencionISR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.PorcIvaRetencion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.PorcISRRetencion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.CancelacionMotivoClave)
                .IsUnicode(false);

            modelBuilder.Entity<SAVNCred>()
                .Property(e => e.CancelacionUUIDRelacion)
                .IsUnicode(false);

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

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Apellido1)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Apellido2)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Pais)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.TelefonoCasa)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Beeper)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Capturo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.CapturoCambio)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Departamento)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.SueldoBase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.CredencialElector)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.LicenciaManejo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Horario)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.HorarioSabado)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.HorarioDomingo)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Pago)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Nota)
                .IsUnicode(false);

            modelBuilder.Entity<SAVPersonal>()
                .Property(e => e.Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Clave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Contacto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Direccion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Colonia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Ciudad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Pais)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.TelefonoOficina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.TelefonoCasa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Fax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.RFC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Beeper)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.NC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.CodigoArea)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Giro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Zona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.AuxA1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.AuxA2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.AuxN1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.AuxN2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Recomendo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Celular)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Web)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.NombreComercial)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.CapturoCambio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.EntreCalle1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.EntreCalle2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Delegacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.SaldoAnterior)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.GeneroECCapturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.ChequesANombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.TipoPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.TipoRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedor>()
                .Property(e => e.Moneda)
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Cargo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Abono)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Moneda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.TipoCambio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.NCredito)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.ObraClave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorMS>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.ProveedorNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Detalle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.NCredito)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Pagado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Giro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Zona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.ObraClave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.CancelacionCapturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.CancelacionMotivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.CancelacionSustituye)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.ContraRecibo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.TipoCambio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.PreAutorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoC>()
                .Property(e => e.RemisionCosto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.ProveedorNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.EmpresaCheq)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Giro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Zona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.TipoCambio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoD>()
                .Property(e => e.NumCheque)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.ProveedorNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.Concepto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.Detalle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.TipoCambio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.EmpresaCheq)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.Cuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoI>()
                .Property(e => e.NumCheque)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoR>()
                .Property(e => e.Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoR>()
                .Property(e => e.Empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoR>()
                .Property(e => e.Remision)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoR>()
                .Property(e => e.Costo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoR>()
                .Property(e => e.PorcIva)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SAVProveedorPagoR>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoR>()
                .Property(e => e.ObraClave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVProveedorPagoR>()
                .Property(e => e.Comentario)
                .IsFixedLength()
                .IsUnicode(false);

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

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Reporte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Obra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.ObraClave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.ObraNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.ClienteNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Premezcladora)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.PremezcladoraNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Muestreador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.MuestreadorNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Calidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Volumen)
                .HasPrecision(6, 2);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Capturo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.CapturoCambio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Planta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.PlantaNombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.TipoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Temperatura)
                .HasPrecision(6, 2);

            modelBuilder.Entity<SAVServ01>()
                .Property(e => e.Informe)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
