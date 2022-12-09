namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVProveedorPagoR")]
    public partial class SAVProveedorPagoR
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
        [StringLength(6)]
        public string Remision { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Costo { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal PorcIva { get; set; }

        [StringLength(6)]
        public string Obra { get; set; }

        [StringLength(6)]
        public string ObraClave { get; set; }

        [StringLength(50)]
        public string Comentario { get; set; }
    }
}
