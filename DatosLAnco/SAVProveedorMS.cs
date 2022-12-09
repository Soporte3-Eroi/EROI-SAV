namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAVProveedorMS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Proveedor { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Hora { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(60)]
        public string Concepto { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Cargo { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Abono { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string Capturo { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal Monto { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(7)]
        public string Moneda { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal TipoCambio { get; set; }

        [StringLength(6)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(15)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Folio { get; set; }

        [StringLength(30)]
        public string Factura { get; set; }

        [StringLength(6)]
        public string NCredito { get; set; }

        public int? FolioPago { get; set; }

        [StringLength(6)]
        public string ObraClave { get; set; }

        [StringLength(20)]
        public string Empresa { get; set; }
    }
}
