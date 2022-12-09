namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVProveedorPagoI")]
    public partial class SAVProveedorPagoI
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
        public int FolioPagoInterno { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(60)]
        public string ProveedorNombre { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string Concepto { get; set; }

        [StringLength(100)]
        public string Detalle { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Total { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(15)]
        public string Estatus { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Procesado { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal TipoCambio { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string EmpresaCheq { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string Banco { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(20)]
        public string Cuenta { get; set; }

        [StringLength(10)]
        public string NumCheque { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool PorComprobar { get; set; }

        public int? FolioPagoInterno2 { get; set; }
    }
}
