namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVEmpresaCheqMT")]
    public partial class SAVEmpresaCheqMT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Banco { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string Cuenta { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolioTemporal { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(6)]
        public string Proveedor { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(60)]
        public string ProveedorNombre { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolioAdeudo { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolioPagoAdeudo { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolioPagoInterno { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal Monto { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime Fecha { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(20)]
        public string Concepto { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal TipoCambio { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(20)]
        public string Estatus { get; set; }

        [StringLength(100)]
        public string Detalle { get; set; }

        [StringLength(30)]
        public string Factura { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal AdeudoTotal { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal AdeudoSaldo { get; set; }

        [StringLength(100)]
        public string ChequesaNombre { get; set; }

        [StringLength(10)]
        public string NumCheque { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal AdeudoNCredito { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Impresiones { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(15)]
        public string TipoPago { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool PorComprobar { get; set; }

        public int? FolioPagoInterno2 { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(15)]
        public string FormaPago { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool Traspaso { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolioPersonalGasto { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(20)]
        public string ProveedorTipoPago { get; set; }
    }
}
