namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVPersonal")]
    public partial class SAVPersonal
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Clave { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string Apellido1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string Apellido2 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string Tipo { get; set; }

        [StringLength(60)]
        public string Direccion { get; set; }

        [StringLength(40)]
        public string Colonia { get; set; }

        [StringLength(10)]
        public string CP { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string Ciudad { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string Estado { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string Pais { get; set; }

        [StringLength(40)]
        public string TelefonoCasa { get; set; }

        [StringLength(40)]
        public string Celular { get; set; }

        [StringLength(40)]
        public string Beeper { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Capturo { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaAltaHora { get; set; }

        [StringLength(20)]
        public string CapturoCambio { get; set; }

        public DateTime? UltimoCambio { get; set; }

        public DateTime? UltimoCambioHora { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string Departamento { get; set; }

        public DateTime? FechaIngreso { get; set; }

        public DateTime? FechaEgreso { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string Estatus { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal SueldoBase { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime FechaNacimiento { get; set; }

        [StringLength(40)]
        public string CredencialElector { get; set; }

        [StringLength(40)]
        public string LicenciaManejo { get; set; }

        [StringLength(40)]
        public string CURP { get; set; }

        [StringLength(40)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime HorarioDesde { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime HorarioHasta { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(15)]
        public string Horario { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(15)]
        public string HorarioSabado { get; set; }

        [Key]
        [Column(Order = 16)]
        public DateTime HorarioSabadoDesde { get; set; }

        [Key]
        [Column(Order = 17)]
        public DateTime HorarioSabadoHasta { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(15)]
        public string HorarioDomingo { get; set; }

        [Key]
        [Column(Order = 19)]
        public DateTime HorarioDomingoDesde { get; set; }

        [Key]
        [Column(Order = 20)]
        public DateTime HorarioDomingoHasta { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool Visitas { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(10)]
        public string Pago { get; set; }

        [StringLength(150)]
        public string Nota { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(20)]
        public string Empresa { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool AutorizaGastos { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool Presupuestos { get; set; }
    }
}
