namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVNCred")]
    public partial class SAVNCred
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string NCredito { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Cliente { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Fecha { get; set; }

        [StringLength(60)]
        public string Concepto { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PorcIVA { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal SubTotal { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal IVA { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Total { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Procesado { get; set; }

        [StringLength(15)]
        public string Estatus { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? UltimoCambio { get; set; }

        [Column(TypeName = "text")]
        public string TotalLetra { get; set; }

        [Column(TypeName = "text")]
        public string Comentario { get; set; }

        [StringLength(6)]
        public string Factura { get; set; }

        public DateTime? FechaAcred { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        [StringLength(6)]
        public string Obra { get; set; }

        [Column(TypeName = "text")]
        public string FacturarA { get; set; }

        [StringLength(60)]
        public string ClienteNombre { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }

        [StringLength(6)]
        public string Remision { get; set; }

        public DateTime? RemisionFecha { get; set; }

        public int? FacturaCobro { get; set; }

        public short? Impresiones { get; set; }

        [StringLength(60)]
        public string ObraNombre { get; set; }

        public DateTime? FacturaFecha { get; set; }

        [Column(TypeName = "money")]
        public decimal? FacturaMonto { get; set; }

        [StringLength(6)]
        public string ObraClave { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string Aplicacion { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short NCreditoOpcion { get; set; }

        [StringLength(20)]
        public string CapturoCambio { get; set; }

        [StringLength(6)]
        public string SerieCFD { get; set; }

        public int? NCreditoCFD { get; set; }

        [StringLength(30)]
        public string MetododePago { get; set; }

        [StringLength(20)]
        public string NumCtaPago { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        public DateTime? UltimoCambioHora { get; set; }

        [StringLength(10)]
        public string FormadePago { get; set; }

        [StringLength(10)]
        public string UsoCFDI { get; set; }

        public int? CFDIVersion { get; set; }

        [StringLength(50)]
        public string UUID { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IntContable { get; set; }

        public int? IntContablePoliza { get; set; }

        public int? IntContablePolizaC { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal RetencionIVA { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal RetencionISR { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal PorcIvaRetencion { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal PorcISRRetencion { get; set; }

        [StringLength(10)]
        public string CancelacionMotivoClave { get; set; }

        [StringLength(50)]
        public string CancelacionUUIDRelacion { get; set; }
    }
}
