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
        }
    }
}
