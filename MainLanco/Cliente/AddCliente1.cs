using DatosLAnco;
using MainLanco.Conexion;
using MainLanco.eRoi;
using MainLanco.Utilerias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco
{
    public class AddCliente1
    {
        public static void Clientes()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "Clientes", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now;
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var Cliente = new SAVCliente()
                    {

                        Clave = value.Clave,
                        Empresa = value.Empresa,
                        Contacto = value.Contacto,
                        Direccion = value.Direccion,
                        Colonia = value.Colonia,
                        CP = value.CP,
                        Ciudad = value.Ciudad,
                        Estado = value.Estado == "" ? null : value.Estado,
                        Pais = value.Pais,
                        TelefonoOficina = value.TelefonoOficina,
                        TelefonoCasa = value.TelefonoCasa,
                        Fax = value.Fax,
                        Email = value.Email,
                        RFC = value.RFC,
                        Saldo = value.Saldo,
                        Bloqueado = value.Bloqueado,
                        FechaAlta = value.FechaAlta == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta),
                        UltimoCambio = value.UltimoCambio == null ? value.UltimoCambio : utileria.convHoraTiempo2(value.UltimoCambio),
                        UltimoMov = value.UltimoMov == null ? value.UltimoMov : utileria.convHoraTiempo2(value.UltimoMov),
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
                        FacturarA = value.FacturarA,
                        Capturo = value.Capturo,
                        CapturoCambio = value.CapturoCambio,
                        EntreCalle1 = value.EntreCalle1,
                        EntreCalle2 = value.EntreCalle2,
                        FechaAltaHora = value.FechaAltaHora != null ? utileria.convHoraTiempo2(value.FechaAltaHora) : value.FechAltaHora, //utileria.convHoraTiempo2("1899-01-01 01:00:00"), //PRIMER ERROR
                        UltimoCambioHora = value.UltimoCambioHora != null ? utileria.convHoraTiempo2(value.UltimoCambioHora) : value.UltimoCambioHora, //Segundo error
                        Estatus = value.Estatus,
                        Delegacion = value.Delegacion,
                        SaldoAnterior = utileria.convDecimal(value.SaldoAnterior),
                        SaldoLimitePago = value.SaldoLimitePago == null ? value.SaldoLimitePago : utileria.convHoraTiempo2(value.SaldoLimitePago),
                        GeneroECFecha = value.GeneroECFecha == null ? value.GeneroECFecha : utileria.convHoraTiempo2(value.GeneroECFecha),
                        GeneroECCapturo = value.GeneroECCapturo,
                        EnvioEmail = utileria.convBoolStr(value.EnvioEmail),
                        GeneroECDesde = value.GeneroECDesde == null ? value.GeneroECDesde : utileria.convHoraTiempo2(value.GeneroECDesde),
                        GeneroECHasta = value.GeneroECHasta == null ? value.GeneroECHasta : utileria.convHoraTiempo2(value.GeneroECHasta),

                        Htmlmail = utileria.convBoolStr(value.Htmlmail),
                        UltimaRemision = value.UltimaRemision == null ? value.UltimaRemision : utileria.convHoraTiempo2(value.UltimaRemision),

                        UltimaFactura = value.UltimaFactura == null ? value.UltimaFactura : utileria.convHoraTiempo2(value.UltimaFactura),

                        Activa = utileria.convBoolStr(value.Activa),
                        UltimoCobro = value.UltimoCobro == null ? value.UltimoCobro : utileria.convHoraTiempo2(value.UltimoCobro),

                        Anticipo = utileria.convDecimal(value.Anticipo),
                        Ruta = value.Ruta,
                        Llamada = utileria.convBoolStr(value.Llamada),
                        Asignado = value.Asignado,
                        ServiciosPendRemisionar = utileria.convDecimal(value.ServiciosPendRemisionar),
                        MetododePago = value.MetododePago,
                        NumCtaPago = value.NumCtaPago,
                        FormadePago = value.FormadePago,
                        UsoCFDI = value.UsoCFDI,
                        AuxMP = value.AuxMP,
                        CLIENTE_ID = utileria.convInt(value.CLIENTE_ID),
                        CuentaOficina = value.CuentaOficina,
                        Cuenta = value.Cuenta,
                        SubCuenta = value.SubCuenta,
                        CuentaOficina2 = value.CuentaOficina2 == "" ? null : value.CuentaOficina2,
                        Cuenta2 = value.Cuenta2,
                        SubCuenta2 = value.SubCuenta2,
                        RegimenFiscalClave = value.RegimenFiscalClave

                    };
                    Console.WriteLine("******************************");
                    Business n = new Business();
                    int resp = n.agregaCliente(Cliente);

                    //Se actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Clave = value.Clave,
                        ClaveLanco = value.Clave
                    };

                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("Cliente Actualizado" + response);

                    if (resp == 1)
                    {
                        Console.WriteLine(" Cliente registrado en DB");
                        Console.WriteLine(" ----------------------- ");

                        APIeRoi.CallApi("POST", "ActualizaClientes", res).Wait();

                        Console.WriteLine(" Cliente regitrado en eRoi");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine(" Cliente actualizado en DB");
                        Console.WriteLine(" ----------------------- ");

                        APIeRoi.CallApi("POST", "ActualizaClientes", res).Wait();

                        Console.WriteLine(" Cliente actualizado en eRoi");
                    }
                    else
                    {
                        Console.WriteLine("No se registro / Actualizo en DB");
                        Console.WriteLine(" ------------------------------ ");

                        Console.WriteLine("No se registro / Actualizo en eRoi");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    Console.WriteLine("Inner: " + e.InnerException);
                    newLog.GenerarTXT("Excepcion en agregar cliente " + e.Message);

                }

            }
        }
    }
}
