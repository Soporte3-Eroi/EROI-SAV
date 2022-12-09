namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVProveedorPagoC")]
    public partial class SAVProveedorPagoC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Proveedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Folio { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string Factura { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(60)]
        public string ProveedorNombre { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string Concepto { get; set; }

        [StringLength(100)]
        public string Detalle { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Total { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime FechaFactura { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal NCredito { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal Pagado { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal Saldo { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(15)]
        public string Estatus { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool Procesado { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(20)]
        public string Giro { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(20)]
        public string Zona { get; set; }

        [StringLength(6)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool LigaObra { get; set; }

        [StringLength(6)]
        public string ObraClave { get; set; }

        public DateTime? CancelacionFecha { get; set; }

        [StringLength(20)]
        public string CancelacionCapturo { get; set; }

        [StringLength(30)]
        public string CancelacionMotivo { get; set; }

        [StringLength(6)]
        public string CancelacionSustituye { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Plazo { get; set; }

        [StringLength(10)]
        public string ContraRecibo { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal TipoCambio { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool SubContratista { get; set; }

        [StringLength(20)]
        public string PreAutorizacion { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal RemisionCosto { get; set; }
    }
}
