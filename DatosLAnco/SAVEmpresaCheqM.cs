namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVEmpresaCheqM")]
    public partial class SAVEmpresaCheqM
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
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Hora { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Saldo { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Deposito { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal DepositoSBC { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal PagoTransito { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal PagoFirme { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string Plaza { get; set; }

        [StringLength(60)]
        public string Comentario { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal DepositoPre { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal SaldoPre { get; set; }
    }
}
