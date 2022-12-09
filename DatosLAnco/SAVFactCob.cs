namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVFactCob")]
    public partial class SAVFactCob
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Factura { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cobro { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string Cliente { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal Monto { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string FormaPago { get; set; }

        [StringLength(25)]
        public string Banco { get; set; }

        [StringLength(25)]
        public string Cuenta { get; set; }

        [StringLength(4)]
        public string Expira { get; set; }

        [StringLength(10)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string Estatus { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal TipoCambio { get; set; }

        [StringLength(40)]
        public string CuentaNombre { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string Giro { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string Zona { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime FechaFactura { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string Vendedor { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Corrida { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(25)]
        public string BancoDeposito { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        public DateTime? Hora { get; set; }

        public DateTime? HoraFactura { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PorcIVA { get; set; }

        [StringLength(6)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(20)]
        public string Movimiento { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        [StringLength(60)]
        public string Concepto { get; set; }

        [StringLength(20)]
        public string BancoCuenta { get; set; }

        [StringLength(6)]
        public string Remision { get; set; }

        public DateTime? RemisionFecha { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CobroMultiple { get; set; }

        public DateTime? CapturoFecha { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CobroMultipleP { get; set; }

        [StringLength(6)]
        public string SerieCFD { get; set; }

        public int? FacturaCFD { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool Recordatorio { get; set; }

        public int? Parcialidad { get; set; }

        [Column(TypeName = "money")]
        public decimal? SaldoAnterior { get; set; }

        [Column(TypeName = "money")]
        public decimal? SaldoPendiente { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }
    }
}
