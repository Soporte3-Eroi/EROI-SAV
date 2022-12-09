namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVProveedor")]
    public partial class SAVProveedor
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Clave { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string Empresa { get; set; }

        [StringLength(60)]
        public string Contacto { get; set; }

        [StringLength(60)]
        public string Direccion { get; set; }

        [StringLength(40)]
        public string Colonia { get; set; }

        [StringLength(10)]
        public string CP { get; set; }

        [StringLength(20)]
        public string Ciudad { get; set; }

        [StringLength(20)]
        public string Estado { get; set; }

        [StringLength(20)]
        public string Pais { get; set; }

        [StringLength(40)]
        public string TelefonoOficina { get; set; }

        [StringLength(40)]
        public string TelefonoCasa { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal Saldo { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Bloqueado { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? UltimoCambio { get; set; }

        public DateTime? UltimoMov { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(15)]
        public string Status { get; set; }

        [StringLength(20)]
        public string Beeper { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal NC { get; set; }

        [StringLength(15)]
        public string CodigoArea { get; set; }

        [StringLength(20)]
        public string Giro { get; set; }

        [StringLength(20)]
        public string Zona { get; set; }

        [StringLength(10)]
        public string AuxA1 { get; set; }

        [StringLength(10)]
        public string AuxA2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AuxN1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AuxN2 { get; set; }

        [StringLength(30)]
        public string Recomendo { get; set; }

        [StringLength(20)]
        public string Celular { get; set; }

        [StringLength(60)]
        public string Web { get; set; }

        [StringLength(60)]
        public string NombreComercial { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        [StringLength(20)]
        public string CapturoCambio { get; set; }

        [StringLength(60)]
        public string EntreCalle1 { get; set; }

        [StringLength(60)]
        public string EntreCalle2 { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        public DateTime? UltimoCambioHora { get; set; }

        [StringLength(20)]
        public string Estatus { get; set; }

        [StringLength(20)]
        public string Delegacion { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal SaldoAnterior { get; set; }

        public DateTime? SaldoLimitePago { get; set; }

        public DateTime? GeneroECFecha { get; set; }

        [StringLength(20)]
        public string GeneroECCapturo { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool EnvioEmail { get; set; }

        public DateTime? GeneroECDesde { get; set; }

        public DateTime? GeneroECHasta { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool HtmlMail { get; set; }

        [StringLength(100)]
        public string ChequesANombre { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Plazo { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(10)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool SubContratista { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool Almacen { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(20)]
        public string TipoPago { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool ModuloCompras { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(20)]
        public string TipoRecepcion { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(7)]
        public string Moneda { get; set; }
    }
}
