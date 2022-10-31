namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVFactCA")]
    public partial class SAVFactCA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Factura { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FacturaAnticipo { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal Total { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(7)]
        public string Moneda { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Paridad { get; set; }

        [StringLength(50)]
        public string UUID { get; set; }
    }
}
