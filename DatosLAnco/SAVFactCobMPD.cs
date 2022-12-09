namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVFactCobMPD")]
    public partial class SAVFactCobMPD
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CobroMultipleP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Factura { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cobro { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string Cliente { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Monto { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FacturaFecha { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime CobroFecha { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal SaldoFactura { get; set; }

        [StringLength(6)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool NCreditoAplicar { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Descuento { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal DescuentoMonto { get; set; }

        [StringLength(6)]
        public string SerieCFD { get; set; }

        public int? FacturaCFD { get; set; }
    }
}
