namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVObraServicioProg")]
    public partial class SAVObraServicioProg
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Folio { get; set; }

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
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(6)]
        public string Cliente { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(60)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal Monto { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(7)]
        public string Moneda { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool Descuento { get; set; }

        [Column(TypeName = "text")]
        public string Comentario { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal Cantidad { get; set; }

        [StringLength(60)]
        public string DescripcionAdicional { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal PorcIva { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal Desc1 { get; set; }

        [StringLength(10)]
        public string Unidad { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool Cobrado { get; set; }

        [StringLength(10)]
        public string CobradoTipo { get; set; }

        [StringLength(6)]
        public string CobradoNumero { get; set; }

        public DateTime? CobradoFecha { get; set; }

        [StringLength(20)]
        public string CobradoCapturo { get; set; }

        [StringLength(20)]
        public string CapturoCambio { get; set; }

        public DateTime? UltimoCambio { get; set; }

        public DateTime? UltimoCambioHora { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool Consolida { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool Remisiona { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool Consolidacion { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool Agrupacion { get; set; }

        [StringLength(30)]
        public string Referencia { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(6)]
        public string Muestreador { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(60)]
        public string MuestreadorNombre { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool Seleccion { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CobroS { get; set; }

        public DateTime? CobroSFecha { get; set; }

        [StringLength(20)]
        public string CobroSFormaPago { get; set; }

        [StringLength(25)]
        public string CobroSBanco { get; set; }

        [StringLength(25)]
        public string CobroSCuenta { get; set; }

        [StringLength(25)]
        public string CobroSBancoDeposito { get; set; }

        [StringLength(20)]
        public string CobroSCapturo { get; set; }

        public int? FolioVisita { get; set; }

        [StringLength(20)]
        public string Origen { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool Cancelado { get; set; }

        public DateTime? CanceladoFecha { get; set; }

        [StringLength(20)]
        public string CanceladoCapturo { get; set; }

        [Key]
        [Column(Order = 23)]
        public decimal PorcIvaRetencion { get; set; }

        [Key]
        [Column(Order = 24)]
        public decimal PorcISRRetencion { get; set; }
    }
}
