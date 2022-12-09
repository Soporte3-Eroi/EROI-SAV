namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVEmpresaCheq")]
    public partial class SAVEmpresaCheq
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
        [StringLength(20)]
        public string Plaza { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Saldo { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Deposito { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal DepositoSBC { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal PagoTransito { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal PagoFirme { get; set; }

        [StringLength(30)]
        public string FormatoCheque { get; set; }

        [StringLength(30)]
        public string FormatoChequeInterno { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumCheque { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumChequeIni { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumChequeMax { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumChequeAviso { get; set; }

        public DateTime? FechaConciliacionCobros { get; set; }

        public DateTime? FechaConciliacionPagos { get; set; }
    }
}
