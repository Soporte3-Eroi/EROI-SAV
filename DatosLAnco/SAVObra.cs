namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVObra")]
    public partial class SAVObra
    {
        [Key]
        [StringLength(6)]
        public string Obra { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(6)]
        public string ObraClave { get; set; }

        [StringLength(60)]
        public string Direccion { get; set; }

        [StringLength(40)]
        public string Colonia { get; set; }

        [StringLength(10)]
        public string CP { get; set; }

        [Required]
        [StringLength(20)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }

        [Required]
        [StringLength(20)]
        public string Pais { get; set; }

        [StringLength(40)]
        public string Telefono { get; set; }

        [StringLength(60)]
        public string EncargadoObra { get; set; }

        [StringLength(40)]
        public string EncargadoObraTel { get; set; }

        [StringLength(60)]
        public string EncargadoPago { get; set; }

        [StringLength(40)]
        public string EncargadoPagoTel { get; set; }

        [StringLength(20)]
        public string DiasRevision { get; set; }

        [StringLength(20)]
        public string HoraRevision { get; set; }

        [StringLength(20)]
        public string DiasCobro { get; set; }

        [StringLength(20)]
        public string HorasCobro { get; set; }

        [StringLength(60)]
        public string ReportarInc { get; set; }

        [StringLength(40)]
        public string ReportarIncTel { get; set; }

        [StringLength(150)]
        public string NombreReporte { get; set; }

        [Column(TypeName = "text")]
        public string ConsignadoA { get; set; }

        [Column(TypeName = "text")]
        public string FacturarA { get; set; }

        [Required]
        [StringLength(6)]
        public string Cliente { get; set; }

        [Required]
        [StringLength(60)]
        public string ClienteNombre { get; set; }

        public short? NumCopias { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        [StringLength(20)]
        public string CapturoCambio { get; set; }

        public DateTime? UltimoCambio { get; set; }

        public DateTime? UltimoCambioHora { get; set; }

        [StringLength(10)]
        public string CodigoArea { get; set; }

        public int Servicio { get; set; }

        public int Muestra { get; set; }

        public int Revenimiento { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }

        [Required]
        [StringLength(20)]
        public string Giro { get; set; }

        [Required]
        [StringLength(20)]
        public string Zona { get; set; }

        [StringLength(20)]
        public string Familia { get; set; }

        [StringLength(20)]
        public string Delegacion { get; set; }

        public decimal Descuento { get; set; }

        public bool Activa { get; set; }

        public DateTime? UltimaRemision { get; set; }

        public DateTime? UltimaFactura { get; set; }

        public int Serv01Secuencia { get; set; }

        public int FolioServicioProg { get; set; }

        [Column(TypeName = "money")]
        public decimal Saldo { get; set; }

        [Column(TypeName = "money")]
        public decimal NC { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [Column(TypeName = "money")]
        public decimal SaldoAnterior { get; set; }

        public DateTime? SaldoLimitePago { get; set; }

        public DateTime? GeneroECFecha { get; set; }

        [StringLength(20)]
        public string GeneroECCapturo { get; set; }

        public bool EnvioEmail { get; set; }

        public DateTime? GeneroECDesde { get; set; }

        public DateTime? GeneroECHasta { get; set; }

        public bool HtmlMail { get; set; }

        public DateTime? UltimoMov { get; set; }

        [StringLength(30)]
        public string Aux1 { get; set; }

        [StringLength(30)]
        public string Aux2 { get; set; }

        [Required]
        [StringLength(10)]
        public string Ubicacion { get; set; }

        [Required]
        [StringLength(15)]
        public string Horario { get; set; }

        public DateTime HorarioDesde { get; set; }

        public DateTime HorarioHasta { get; set; }

        [Required]
        [StringLength(15)]
        public string HorarioSabado { get; set; }

        public DateTime HorarioSabadoDesde { get; set; }

        public DateTime HorarioSabadoHasta { get; set; }

        [Required]
        [StringLength(15)]
        public string HorarioDomingo { get; set; }

        public DateTime HorarioDomingoDesde { get; set; }

        public DateTime HorarioDomingoHasta { get; set; }

        public DateTime? UltimoCobro { get; set; }

        public bool Reg1 { get; set; }

        public short Serv01Copias { get; set; }

        public int Serv02Secuencia { get; set; }

        public int Viga { get; set; }

        public int Mortero { get; set; }

        public int Enviado { get; set; }

        public int Serv03Ensaye { get; set; }

        public int Serv04Ensaye { get; set; }

        [Column(TypeName = "money")]
        public decimal Pasaje { get; set; }

        public int Corazon { get; set; }

        public int Arteza { get; set; }

        [Required]
        [StringLength(30)]
        public string Ruta { get; set; }

        [Required]
        [StringLength(10)]
        public string RevisionFacturas { get; set; }

        [Required]
        [StringLength(15)]
        public string RevisionPeriodicidad { get; set; }

        [Required]
        [StringLength(15)]
        public string RevisionPeriodicidadDia1 { get; set; }

        [Required]
        [StringLength(10)]
        public string RevisionPeriodicidadDia2 { get; set; }

        [StringLength(40)]
        public string RevisionHorario { get; set; }

        [Required]
        [StringLength(10)]
        public string ReportesEntrega { get; set; }

        [Required]
        [StringLength(15)]
        public string ReportesPeriodicidad { get; set; }

        [Required]
        [StringLength(15)]
        public string ReportesPeriodicidadDia1 { get; set; }

        [Required]
        [StringLength(10)]
        public string ReportesPeriodicidadDia2 { get; set; }

        [StringLength(40)]
        public string ReportesHorario { get; set; }

        [Required]
        [StringLength(10)]
        public string Presupuesto { get; set; }

        [Required]
        [StringLength(15)]
        public string PresupuestoPeriodicidad { get; set; }

        [Required]
        [StringLength(15)]
        public string PresupuestoPeriodicidadDia1 { get; set; }

        [Required]
        [StringLength(10)]
        public string PresupuestoPeriodicidadDia2 { get; set; }

        [StringLength(40)]
        public string PresupuestoHorario { get; set; }

        [Required]
        [StringLength(10)]
        public string Cobranza { get; set; }

        [Required]
        [StringLength(15)]
        public string CobranzaPeriodicidad { get; set; }

        [Required]
        [StringLength(15)]
        public string CobranzaPeriodicidadDia1 { get; set; }

        [Required]
        [StringLength(10)]
        public string CobranzaPeriodicidadDia2 { get; set; }

        [StringLength(40)]
        public string CobranzaHorario { get; set; }

        public short CobranzaPlazo { get; set; }

        public bool CobranzaActiva { get; set; }

        public bool PVCobroSeparado { get; set; }

        [Required]
        [StringLength(15)]
        public string TipoCobro { get; set; }

        public short ConcretoC { get; set; }

        public short VigaC { get; set; }

        public short MorteroC { get; set; }

        public short CorazonC { get; set; }

        public short ArtezaC { get; set; }

        public bool Cerrada { get; set; }

        public DateTime? IgualaMensualDesde { get; set; }

        public DateTime? IgualaMensualHasta { get; set; }

        public DateTime? IgualaMensualUltMov { get; set; }

        public int IgualaMensualUltCorrida { get; set; }

        public bool IgualaSemanalCobroMuestras { get; set; }

        [Required]
        [StringLength(15)]
        public string Horario2 { get; set; }

        public DateTime HorarioDesde2 { get; set; }

        public DateTime HorarioHasta2 { get; set; }

        [Required]
        [StringLength(15)]
        public string HorarioSabado2 { get; set; }

        public DateTime HorarioSabadoDesde2 { get; set; }

        public DateTime HorarioSabadoHasta2 { get; set; }

        [Required]
        [StringLength(15)]
        public string HorarioDomingo2 { get; set; }

        public DateTime HorarioDomingoDesde2 { get; set; }

        public DateTime HorarioDomingoHasta2 { get; set; }

        public bool DescuentoAutomatico { get; set; }

        [Column(TypeName = "money")]
        public decimal ServiciosPendRemisionar { get; set; }

        [Column(TypeName = "text")]
        public string Observaciones { get; set; }

        public int DiasDesc { get; set; }

        public bool FacturaElectronica { get; set; }

        [StringLength(150)]
        public string NombreF { get; set; }

        [StringLength(150)]
        public string DireccionF { get; set; }

        [StringLength(15)]
        public string NumExteriorF { get; set; }

        [StringLength(15)]
        public string NumInteriorF { get; set; }

        [StringLength(60)]
        public string ColoniaF { get; set; }

        [StringLength(20)]
        public string DelegacionF { get; set; }

        [StringLength(10)]
        public string CPF { get; set; }

        [StringLength(20)]
        public string CiudadF { get; set; }

        [StringLength(20)]
        public string EstadoF { get; set; }

        [StringLength(20)]
        public string PaisF { get; set; }

        [StringLength(60)]
        public string EmailF { get; set; }

        public bool CalaCobroSeparado { get; set; }

        [StringLength(30)]
        public string MetododePago { get; set; }

        [StringLength(20)]
        public string NumCtaPago { get; set; }

        [StringLength(60)]
        public string EmailC { get; set; }

        [StringLength(30)]
        public string Aux3 { get; set; }

        [StringLength(30)]
        public string Aux4 { get; set; }

        [Column(TypeName = "money")]
        public decimal LimiteCredito { get; set; }

        public DateTime? OCFecha { get; set; }

        [StringLength(100)]
        public string OCObservaciones { get; set; }

        [StringLength(10)]
        public string FormadePago { get; set; }

        [StringLength(10)]
        public string UsoCFDI { get; set; }

        [StringLength(30)]
        public string AuxMP { get; set; }

        public int ServEspSecuencia { get; set; }

        public int ServEsp { get; set; }

        [StringLength(100)]
        public string SerieF { get; set; }

        [StringLength(255)]
        public string RegimenFiscalClave { get; set; }
    }
}
