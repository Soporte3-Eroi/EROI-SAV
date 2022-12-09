namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAVServ01
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Reporte { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Obra { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ReporteFecha { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string ObraClave { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(60)]
        public string ObraNombre { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(6)]
        public string Cliente { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(60)]
        public string ClienteNombre { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(6)]
        public string Premezcladora { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(60)]
        public string PremezcladoraNombre { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(6)]
        public string Muestreador { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(60)]
        public string MuestreadorNombre { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Resistencia { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(10)]
        public string Tipo { get; set; }

        [StringLength(20)]
        public string Calidad { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Agregado { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Revenimiento1 { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Revenimiento2 { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal Volumen { get; set; }

        [Column(TypeName = "text")]
        public string Observaciones { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        [StringLength(20)]
        public string CapturoCambio { get; set; }

        public DateTime? UltimoCambio { get; set; }

        public DateTime? UltimoCambioHora { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DiasCilindro1 { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DiasCilindro2 { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(6)]
        public string Planta { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(60)]
        public string PlantaNombre { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObraServicio { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Impresiones { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FolioVisita { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DiasCilindro5 { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DiasCilindro6 { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(20)]
        public string TipoNombre { get; set; }

        [Key]
        [Column(Order = 28)]
        public bool CapturaWeb { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AgendaMensajeria { get; set; }

        [Key]
        [Column(Order = 30)]
        public decimal Temperatura { get; set; }

        [StringLength(10)]
        public string Informe { get; set; }
    }
}
