namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVFactC")]
    public partial class SAVFactC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Factura { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Cliente { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "text")]
        public string FacturarA { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal TipoCambio { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "numeric")]
        public decimal PorcIva { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        [Column(TypeName = "text")]
        public string Comentario { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal SubTotal { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal IVA { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal Total { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool Procesado { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(15)]
        public string Estatus { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal Pagado { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal Saldo { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Partidas { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? UltimoCambio { get; set; }

        [Column(TypeName = "text")]
        public string TotalLetra { get; set; }

        [StringLength(7)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal NCredito { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(20)]
        public string Vendedor { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(20)]
        public string Giro { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(20)]
        public string Zona { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool ConRFC { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool FacturaConsolidada { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Corrida { get; set; }

        public DateTime? Hora { get; set; }

        [StringLength(6)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool LigaObra { get; set; }

        [StringLength(6)]
        public string ObraClave { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "numeric")]
        public decimal Impresiones { get; set; }

        public DateTime? CancelacionFecha { get; set; }

        [StringLength(20)]
        public string CancelacionCapturo { get; set; }

        [Column(TypeName = "text")]
        public string ConsignadoA { get; set; }

        [Column(TypeName = "text")]
        public string ObraUbicacion { get; set; }

        [StringLength(30)]
        public string CancelacionMotivo { get; set; }

        [StringLength(6)]
        public string Remision { get; set; }

        public DateTime? RemisionFecha { get; set; }

        [StringLength(6)]
        public string CancelacionSustituye { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool Entregada { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AgendaMensajeria { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AgendaMensajeriaC { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "money")]
        public decimal NCargo { get; set; }

        [StringLength(6)]
        public string SerieCFD { get; set; }

        public int? FacturaCFD { get; set; }

        [StringLength(30)]
        public string MetododePago { get; set; }

        [StringLength(20)]
        public string NumCtaPago { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool NCreditoCompleta { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Plazo { get; set; }

        public DateTime? FechaVencimiento { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        public DateTime? UltimoCambioHora { get; set; }

        [StringLength(20)]
        public string CapturoCambio { get; set; }

        [StringLength(10)]
        public string FormadePago { get; set; }

        [StringLength(10)]
        public string UsoCFDI { get; set; }

        public int? CFDIVersion { get; set; }

        [StringLength(50)]
        public string UUID { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Parcialidades { get; set; }

        [StringLength(100)]
        public string FacturaSustituye { get; set; }

        [StringLength(40)]
        public string SolicitudCancelacionSAT { get; set; }

        [StringLength(40)]
        public string EstatusCancelacionSAT { get; set; }

        public DateTime? PreCancelacion { get; set; }

        [StringLength(20)]
        public string PreCancelacionCapturo { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool IntContable { get; set; }

        public int? IntContablePoliza { get; set; }

        public int? IntContablePolizaC { get; set; }

        [Key]
        [Column(Order = 31, TypeName = "money")]
        public decimal RetencionIVA { get; set; }

        [Key]
        [Column(Order = 32, TypeName = "money")]
        public decimal RetencionISR { get; set; }

        [StringLength(10)]
        public string CancelacionMotivoClave { get; set; }

        [StringLength(50)]
        public string CancelacionUUIDRelacion { get; set; }

        [Key]
        [Column(Order = 33, TypeName = "money")]
        public decimal DescuentoIncluido { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "money")]
        public decimal DescuentoIncluidoCIva { get; set; }

        [Key]
        [Column(Order = 35, TypeName = "money")]
        public decimal SubTotalIva0 { get; set; }

        [Key]
        [Column(Order = 36, TypeName = "money")]
        public decimal SubTotalIva8 { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "money")]
        public decimal SubTotalIva16 { get; set; }
    }
}
