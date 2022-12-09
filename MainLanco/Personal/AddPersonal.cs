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
    public class AddPersonal
    {
        public static void Personal()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;

            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "SAVEROI", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var Personal = new SAVPersonal()
                    {
                        Clave = value.Clave,
                        Nombre = value.Nombre,
                        Apellido1 = value.Apellido1,
                        Apellido2 = value.Apellido2,
                        Tipo = value.Tipo,
                        Direccion = value.Direccion,
                        Colonia = value.Colonia,
                        CP = value.CP,
                        Ciudad = value.Ciudad,
                        Estado = value.Estado,
                        Pais = value.Pais,
                        TelefonoCasa = value.TelefonoCasa,
                        Celular = value.Celular,
                        Beeper = value.Beeper,
                        Email = value.Email,
                        Capturo = value.Capturo,
                        FechaAlta = value.FechaAlta == null ? value.FechaAlta : utileria.convHoraTiempo2(value.FechaAlta), //datetime 
                        FechaAltaHora = value.FechaAltaHora == null ? value.FechaAltaHora : utileria.convHoraTiempo2(value.FechaAltaHora), //datetime
                        CapturoCambio = value.CapturoCambio,  
                        UltimoCambio = value.UltimoCambio == null ? value.UltimoCambio : utileria.convHoraTiempo2(value.UltimoCambio),//datetimne
                        UltimoCambioHora = value.UltimoCambioHora == null ? value.UltimoCambioHora : utileria.convHoraTiempo2(value.UltimoCambioHora),//date
                        Departamento = value.Departamento,
                        FechaIngreso = value.FechaIngreso == null ? value.FechaIngreso : utileria.convHoraTiempo2(value.FechaIngreso),  //datetime
                        FechaEgreso = value.FechaEgreso == null ? value.FechaEgreso : utileria.convHoraTiempo2(value.FechaEgreso),    //datetime
                        Estatus = value.Estatus,
                        SueldoBase = value.SueldoBase,
                        FechaNacimiento = value.FechaNacimiento == null ? value.FechaNacimiento : utileria.convHoraTiempo2(value.FechaNacimiento),    //Datetime
                        CredencialElector = value.CredencialElector,
                        LicenciaManejo = value.LicenciaManejo,
                        CURP = value.CURP,
                        RFC = value.RFC,
                        HorarioDesde = value.HorarioDesde == null ? value.HorarioDesde : utileria.convHoraTiempo2(value.HorarioDesde), //datetime
                        HorarioHasta = value.HorarioHasta == null ? value.HorarioHasta : utileria.convHoraTiempo2(value.HorarioHasta), //datetime
                        Horario = value.Horario,
                        HorarioSabado = value.HorarioSabado,
                        HorarioSabadoDesde = value.HorarioSabadoDesde == null ? value.HorarioSabadoDesde : utileria.convHoraTiempo2(value.HorarioSabadoDesde),//date
                        HorarioSabadoHasta = value.HorarioSabadoHasta == null ? value.HorarioSabadoHasta : utileria.convHoraTiempo2(value.HorarioSabadoHasta),//date
                        HorarioDomingo = value.HorarioDomingo,
                        HorarioDomingoDesde = value.HorarioDomingoDesde == null ? value.HorarioDomingoDesde : utileria.convHoraTiempo2(value.HorarioDomingoDesde),//date
                        HorarioDomingoHasta = value.HorarioDomingoHasta == null ? value.HorarioDomingoHasta : utileria.convHoraTiempo2(value.HorarioDomingoHasta),//date
                        Visitas = value.Visitas,
                        Pago = value.Pago,
                        Nota = value.Nota,
                        Empresa = value.Empresa,
                        AutorizaGastos = value.AutorizaGastos,
                        Presupuestos = value.Presupuestos,
                    };

                    Console.WriteLine("*******************************");
                    Business n = new Business();
                    int resp = n.agregaPersonal(Personal);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Clave = value.Clave,
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("Personal Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("Personal registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "SAVEROI", res).Wait(); //DUDA

                        Console.WriteLine("Personal registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("Personal actualizado en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "SAVEROI", res).Wait();  //DUDA

                        Console.WriteLine("Personal actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar Personal: " + e.Message);
                }
            }
        }
    }
}
