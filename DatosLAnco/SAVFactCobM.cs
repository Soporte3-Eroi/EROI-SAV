namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVFactCobM")]
    public partial class SAVFactCobM
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CobroMultiple { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Cliente { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal Monto { get; set; }

        [Key]
        [Column(Order = 3)]
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
        [Column(Order = 4)]
        [StringLength(20)]
        public string Estatus { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime Hora { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal TipoCambio { get; set; }

        [StringLength(40)]
        public string CuentaNombre { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(25)]
        public string BancoDeposito { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        [StringLength(20)]
        public string BancoCuenta { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(7)]
        public string Moneda { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Facturas { get; set; }

        [StringLength(100)]
        public string Comentarios { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal SubTotal { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal IVA { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal Total { get; set; }

        [StringLength(60)]
        public string ClienteNombre { get; set; }

        [StringLength(20)]
        public string CapturoCambio { get; set; }

        public DateTime? UltimoCambio { get; set; }

        public DateTime? FacturaFechaDesde { get; set; }

        public DateTime? FacturaFechaHasta { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Impresiones { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal Anticipo { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AnticipoFolio { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool AnticipoAcred { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CobroMultipleP { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(6)]
        public string Serie { get; set; }

        [StringLength(6)]
        public string SerieCFD { get; set; }

        public int? CobroCFD { get; set; }

        public int? CFDIVersion { get; set; }

        [StringLength(50)]
        public string UUID { get; set; }

        [StringLength(10)]
        public string UsoCFDI { get; set; }

        [StringLength(10)]
        public string FormadePago { get; set; }

        [StringLength(7)]
        public string Tipo { get; set; }

        [StringLength(20)]
        public string CodigoSAT { get; set; }

        [StringLength(10)]
        public string UnidadSAT { get; set; }

        [StringLength(250)]
        public string TotalLetra { get; set; }

        public DateTime? FechaAlta { get; set; }

        [StringLength(6)]
        public string Obra { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumAsientos { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "money")]
        public decimal Cargos { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "money")]
        public decimal Abonos { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool IntContable { get; set; }

        public DateTime? IntContableFecha { get; set; }

        public DateTime? IntContableHora { get; set; }

        [StringLength(20)]
        public string IntContableCapturo { get; set; }

        public int? IntContablePoliza { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "money")]
        public decimal IntContableTotal { get; set; }

        [StringLength(10)]
        public string CancelacionMotivoClave { get; set; }

        [StringLength(50)]
        public string CancelacionUUIDRelacion { get; set; }

        public int? CobroMultipleSustituye { get; set; }

        public DateTime? CancelacionFecha { get; set; }

        [StringLength(20)]
        public string CancelacionCapturo { get; set; }

        [StringLength(30)]
        public string CancelacionMotivo { get; set; }

        [StringLength(80)]
        public string CancelacionMotivo2 { get; set; }
    }
}
