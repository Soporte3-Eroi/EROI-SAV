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
    public class AddEmpresaCheqMD
    {
        public static void EmpresaCheqMD()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;



            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "EmpresaCheqMD", new { }).Result;


            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var EmpresaCheqMD = new SAVEmpresaCheqMD()
                    {
                        Empresa = value.Empresa,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta,
                        Fecha = value.Fecha== null ? utileria.convHoraTiempo2(value.Fecha) : value.Fecha,//
                        Hora = value.Hora == null ? utileria.convHoraTiempo2(value.Hora) : value.Hora,//
                        FolioDeposito = value.FolioDeposito,
                        Monto = value.Monto,
                        Comentario = value.Comentario,
                        DepositoSBC = value.DepositoSBC,
                        Capturo = value.Capturo,
                        FechaAlta = value.FechaAlta == null ? utileria.convHoraTiempo2(value.FechaAlta) : value.FechaAlta,//
                        FechaAltaHora = value.FechaAltaHora == null ? utileria.convHoraTiempo2(value.FechaAltaHora) : value.FechaAltaHora,//
                        TipoDeposito = value.TipoDeposito,
                        CobroMultiple = value.CobroMultiple,
                        FolioAnticipo = value.FolioAnticipo,
                        Revisado = value.Revisado

                    };

                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaEmpresaCheqMD(EmpresaCheqMD);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Empresa = value.Empresa,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta 

                    };

                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("EmpresaCheqMD Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("EmpresaCheqMD registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaEmpresaCheqMD", res).Wait();

                        Console.WriteLine("EmpresaCheqMD registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("EmpresaCheqMD actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaEmpresaCheqMD", res).Wait();

                        Console.WriteLine("EmpresaCheqMD actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar EmpresaCheqMD: " + e.Message);
                }
            }
        }
    }
}
