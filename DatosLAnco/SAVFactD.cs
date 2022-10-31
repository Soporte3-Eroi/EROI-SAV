namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVFactD")]
    public partial class SAVFactD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Factura { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Orden { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(8)]
        public string Clave { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(60)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Monto { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Descuento { get; set; }

        [Column(TypeName = "text")]
        public string Comentario { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal Cantidad { get; set; }

        [StringLength(60)]
        public string DescripcionAdicional { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal PorcIva { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal Desc1 { get; set; }

        [StringLength(10)]
        public string Unidad { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolioServicioProg { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal PorcIvaRetencion { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal PorcISRRetencion { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal DescuentoIncluido { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal DescuentoIncluidoCIva { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal SubTotal { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal Iva { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal IvaRetencion { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal ISRRetencion { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal TotalR { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "money")]
        public decimal SubTotalIva0 { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "money")]
        public decimal SubTotalIva8 { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "money")]
        public decimal SubTotalIva16 { get; set; }
    }
}
