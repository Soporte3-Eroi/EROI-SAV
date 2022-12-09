using DatosLAnco;
using MainLanco.Conexion;
using MainLanco.eRoi;
using MainLanco.Utilerias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco
{
    public class AddProveedores
    {
        public static void Proveedor()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "Proveedor", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var Proveedor = new SAVProveedor()
                    {
                        Clave = value.Clave,
                        Empresa = value.Empresa,
                        Contacto = value.Contacto,
                        Direccion = value.Direccion,
                        Colonia = value.Colonia,
                        CP = value.CP,
                        Ciudad = value.Ciudad,
                        Estado = value.Estado,
                        Pais = value.Pais,
                        TelefonoOficina = value.TelefonoOficina,
                        TelefonoCasa = value.TelefonoCasa,
                        Fax = value.Fax,
                        Email = value.Email,
                        RFC = value.RFC,
                        Saldo = value.Saldo,
                        Bloqueado = value.Bloqueado,
                        FechaAlta = value.FechaAlta == null ? utileria.convHoraTiempo2(value.FechaAlta) : value.FechaAlta, //date
                        UltimoCambio = value.UltimoCambio == null ? utileria.convHoraTiempo2(value.UltimoCambio) : value.UltimoCambio,//date
                        UltimoMov = value.UltimoMov == null ? utileria.convHoraTiempo2(value.UltimoMov) : value.UltimoMov,//date
                        Status = value.Status,
                        Beeper = value.Beeper,
                        NC = value.NC,
                        CodigoArea = value.CodigoArea,
                        Giro = value.Giro,
                        Zona = value.Zona,
                        AuxA1 = value.AuxA1,
                        AuxA2 = value.AuxA2,
                        AuxN1 = value.AuxN1,
                        AuxN2 = value.AuxN2,
                        Recomendo = value.Recomendo,
                        Celular = value.Celular,
                        Web = value.Web,
                        NombreComercial = value.NombreComercial,
                        Capturo = value.Capturo,
                        CapturoCambio = value.CapturoCambio,
                        EntreCalle1 = value.EntreCalle1,
                        EntreCalle2 = value.EntreCalle2,
                        FechaAltaHora = value.FechaAltaHora == null ? utileria.convHoraTiempo2(value.FechaAltaHora) : value.FechaAltaHora,//date
                        UltimoCambioHora = value.UltimoCambioHora == null ? utileria.convHoraTiempo2(value.UltimoCambioHora) : value.UltimoCambioHora,//date
                        Estatus = value.Estatus,
                        Delegacion = value.Delegacion,
                        SaldoAnterior = value.SaldoAnterior,
                        SaldoLimitePago = value.SaldoLimitePago,
                        GeneroECFecha = value.GeneroECFecha == null ? utileria.convHoraTiempo2(value.GeneroECFecha) : value.GeneroECFecha,//date
                        GeneroECCapturo = value.GeneroECCapturo == null ? utileria.convHoraTiempo2(value.GeneroECCapturo) : value.GeneroECCapturo,//date
                        EnvioEmail = value.EnvioEmail,
                        GeneroECDesde = value.GeneroECDesde == null ? utileria.convHoraTiempo2(value.GeneroECDesde) : value.GeneroECDesde,//date
                        GeneroECHasta = value.GeneroECHasta == null ? utileria.convHoraTiempo2(value.GeneroECHasta) : value.GeneroECHasta,//date
                        HtmlMail = value.HtmlMail,
                        ChequesANombre = value.ChequesANombre,
                        Plazo = value.Plazo,
                        Tipo = value.Tipo,
                        SubContratista = value.SubContratista,
                        Almacen = value.Almacen,
                        TipoPago = value.TipoPago,
                        ModuloCompras = value.ModuloCompras,
                        TipoRecepcion = value.TipoRecepcion,
                        Moneda = value.Moneda
                    };
                    Console.WriteLine("*******************************");
                    Business n = new Business();
                    int resp = n.agregaProveedor(Proveedor);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Clave = value.Clave
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("FactD Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("Proveedor registrado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedor", res).Wait();

                        Console.WriteLine("Proveedor registrado en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("Proveedor actualizado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaProveedor", res).Wait();

                        Console.WriteLine("Proveedor actualizado en eROI");
                    }
                    else
                    {
                        Console.WriteLine("No se registro/actualizo en DB");
                        Console.WriteLine("------------------------");

                        Console.WriteLine("No se registro/actualizo en eROI");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    newLog.GenerarTXT("Excepción en Agregar Proveedor: " + e.Message);
                }
            }
        }
    }
}
