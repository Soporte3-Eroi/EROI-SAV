namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVFactCobMCFD")]
    public partial class SAVFactCobMCFD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Serie { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CobroMultiple { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string SerieCFD { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CobroCFD { get; set; }

        [StringLength(50)]
        public string NombreCFD { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool CFDCancelado { get; set; }

        [Column(TypeName = "text")]
        public string CFDSelloDigital { get; set; }

        [Column(TypeName = "text")]
        public string CFDXML { get; set; }

        [Column(TypeName = "text")]
        public string CFDCadenaOriginal { get; set; }

        [StringLength(80)]
        public string CFDCertificado { get; set; }

        public int? AprobacionNumero { get; set; }

        public int? AprobacionAge { get; set; }

        [Column(TypeName = "money")]
        public decimal? CobroTotal { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        public DateTime? CFDCanceladoFecha { get; set; }

        public DateTime? CFDCanceladoHora { get; set; }

        [StringLength(15)]
        public string EnvioFTP { get; set; }

        [StringLength(40)]
        public string CFDCertificadoSAT { get; set; }

        [Column(TypeName = "text")]
        public string CFDSelloDigitalSAT { get; set; }

        [StringLength(50)]
        public string TimbradoFolioFiscal { get; set; }

        [StringLength(20)]
        public string TimbradoFechaHora { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal CobroIva { get; set; }

        [Column(TypeName = "image")]
        public byte[] TimbradoCodigoQR { get; set; }

        public int? CFDIVersion { get; set; }
    }
}
