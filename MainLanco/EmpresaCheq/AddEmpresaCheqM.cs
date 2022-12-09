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
    public class AddEmpresaCheqM
    {
        public static void EmpresaCheqM()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;



            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "EmpresaCheqM", new { }).Result;


            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var EmpresaCheqM = new SAVEmpresaCheqM()
                    {
                        Empresa = value.Empresa,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta,
                        Fecha = value.Fecha == null ? utileria.convHoraTiempo2(value.Fecha) : value.Fecha,
                        Hora = value.Hora == null ? utileria.convHoraTiempo2(value.Hora) : value.Hora,
                        Saldo = value.Saldo,
                        Deposito = value.Deposito,
                        DepositoSBC = value.DepositoSBC,
                        PagoTransito = value.PagoTransito,
                        PagoFirme = value.PagoFirme,
                        Capturo = value.Capturo,
                        Plaza = value.Plaza,
                        Comentario = value.Comentario,
                        DepositoPre = value.DepositoPre,
                        SaldoPre = value.SaldoPre
                        


                    };

                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaEmpresaCheqM(EmpresaCheqM);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Empresa = value.Empresa,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta

                    };

                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("EmpresaCheqM Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("EmpresaCheqM registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaEmpresaCheqM", res).Wait();

                        Console.WriteLine("EmpresaCheqM registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("EmpresaCheqM actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaEmpresaCheqM", res).Wait();

                        Console.WriteLine("EmpresaCheqM actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar EmpresaCheqM: " + e.Message);
                }
            }
        }
    }
}
