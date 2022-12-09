namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVEmpresaCheqMD")]
    public partial class SAVEmpresaCheqMD
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
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolioDeposito { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Monto { get; set; }

        [StringLength(60)]
        public string Comentario { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool DepositoSBC { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string TipoDeposito { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CobroMultiple { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolioAnticipo { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool Revisado { get; set; }
    }
}
