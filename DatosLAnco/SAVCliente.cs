namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVCliente")]
    public partial class SAVCliente
    {
        [Key]
        [StringLength(6)]
        public string Clave { get; set; }

        [Required]
        [StringLength(60)]
        public string Empresa { get; set; }

        [Required]
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

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }

        [Column(TypeName = "money")]
        public decimal Saldo { get; set; }

        public bool Bloqueado { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? UltimoCambio { get; set; }

        public DateTime? UltimoMov { get; set; }

        [Required]
        [StringLength(15)]
        public string Status { get; set; }

        [StringLength(20)]
        public string Beeper { get; set; }

        [Column(TypeName = "money")]
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

        [Required]
        [StringLength(8)]
        public string FacturarA { get; set; }

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

        [Column(TypeName = "money")]
        public decimal SaldoAnterior { get; set; }

        public DateTime? SaldoLimitePago { get; set; }

        public DateTime? GeneroECFecha { get; set; }

        [StringLength(20)]
        public string GeneroECCapturo { get; set; }

        public bool EnvioEmail { get; set; }

        public DateTime? GeneroECDesde { get; set; }

        public DateTime? GeneroECHasta { get; set; }

        public bool Htmlmail { get; set; }

        public DateTime? UltimaRemision { get; set; }

        public DateTime? UltimaFactura { get; set; }

        public bool Activa { get; set; }

        public DateTime? UltimoCobro { get; set; }

        [Column(TypeName = "money")]
        public decimal Anticipo { get; set; }

        [Required]
        [StringLength(30)]
        public string Ruta { get; set; }

        public bool Llamada { get; set; }

        [Required]
        [StringLength(40)]
        public string Asignado { get; set; }

        [Column(TypeName = "money")]
        public decimal ServiciosPendRemisionar { get; set; }

        [StringLength(30)]
        public string MetododePago { get; set; }

        [StringLength(20)]
        public string NumCtaPago { get; set; }

        [StringLength(10)]
        public string FormadePago { get; set; }

        [StringLength(10)]
        public string UsoCFDI { get; set; }

        [StringLength(30)]
        public string AuxMP { get; set; }

        public int? CLIENTE_ID { get; set; }

        [StringLength(10)]
        public string CuentaOficina { get; set; }

        [StringLength(20)]
        public string Cuenta { get; set; }

        [StringLength(20)]
        public string SubCuenta { get; set; }

        [StringLength(10)]
        public string CuentaOficina2 { get; set; }

        [StringLength(20)]
        public string Cuenta2 { get; set; }

        [StringLength(20)]
        public string SubCuenta2 { get; set; }
    }
}
