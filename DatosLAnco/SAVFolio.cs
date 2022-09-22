namespace DatosLAnco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAVFolio")]
    public partial class SAVFolio
    {
        [Key]
        [StringLength(3)]
        public string Sistema { get; set; }

        public int Cliente { get; set; }

        public int Servicio { get; set; }

        public int Factura { get; set; }

        public int Cobro { get; set; }

        public int NCredito { get; set; }

        public int Muestreador { get; set; }

        public int CompaniaP { get; set; }

        public int PlantaP { get; set; }

        public int Obra { get; set; }

        public int Solicitud { get; set; }

        public int Remision { get; set; }

        public int Presupuesto { get; set; }

        public int Serv01 { get; set; }

        public int Proveedor { get; set; }

        public int ProveedorPagoC { get; set; }

        public int ProveedorPagoD { get; set; }

        public int ProveedorCheqMT { get; set; }

        public int ProveedorPagoI { get; set; }

        public int ProveedorCheqMD { get; set; }

        public int Personal { get; set; }

        public int PersonalVisita { get; set; }

        public int PersonalGasto { get; set; }

        public int FolioProducto { get; set; }

        public int FolioRecepcion { get; set; }

        public int FolioEnvio { get; set; }

        public int FolioRecepcionA { get; set; }

        public int FolioEnvioA { get; set; }

        public int Serv01AE { get; set; }

        public int ClienteSIS { get; set; }

        public int Serv03 { get; set; }

        public int Serv04 { get; set; }

        public int Serv05 { get; set; }

        public int Serv06 { get; set; }

        public int CobroMultiple { get; set; }

        public int FolioAnticipo { get; set; }

        public int CobroSProg { get; set; }

        public int Serv07 { get; set; }

        public int Prestamo { get; set; }

        public int PrestamoPago { get; set; }

        public int Contrato { get; set; }

        public int Serv08 { get; set; }

        public int AgendaMensajeria { get; set; }

        public int CobranzaTel { get; set; }

        public int VisitaIgualaSemanal { get; set; }

        public int CorridaIgualaSemanal { get; set; }

        public int FolioMensajeVisita { get; set; }

        public int CorridaIgualaMensual { get; set; }

        public int Serv09 { get; set; }

        public int SubContratoC { get; set; }

        public int SubContratoD { get; set; }

        public int FolioMensajeSubContrato { get; set; }

        public int NCargo { get; set; }

        public int CobroMultipleP { get; set; }

        public int FacturaE { get; set; }

        public int PersonalPremioC { get; set; }

        public int ServEsp { get; set; }

        public int FormatoEsp { get; set; }

        public int FolioOrdCompra { get; set; }
    }
}
