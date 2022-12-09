namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVProveedorPagoD")]
    public partial class SAVProveedorPagoD
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolioPago { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string Factura { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(60)]
        public string ProveedorNombre { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Monto { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string EmpresaCheq { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string Banco { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string Cuenta { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string Estatus { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(20)]
        public string Giro { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(20)]
        public string Zona { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime FechaFactura { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        [StringLength(6)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(20)]
        public string Movimiento { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(20)]
        public string Concepto { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal TipoCambio { get; set; }

        [StringLength(10)]
        public string NumCheque { get; set; }
    }
}
