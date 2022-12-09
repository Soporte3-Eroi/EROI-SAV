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
    public class AddEmpresaCheq
    {
        public static void EmpresaCheq()
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            string url = ob.url;
            string user = ob.user;
            string pass = ob.pass;



            dynamic resToken = APIeRoi.Login(user, pass).Result;
            dynamic resApi = APIeRoi.CallApi("Get", "EmpresaCheq", new { }).Result;


            foreach (dynamic value in resApi.data)
            {
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();

                    var EmpresaCheq = new SAVEmpresaCheq()
                    {
                        Empresa = value.Empresa,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta,
                        Plaza = value.Plaza,
                        Saldo = value.Saldo,
                        Deposito = value.Deposito,
                        DepositoSBC = value.DepositoSBC,
                        PagoTransito = value.PagoTransito,
                        PagoFirme = value.PagoFirme,
                        FormatoCheque = value.FormatoCheque,
                        FormatoChequeInterno = value.FormatoChequeInterno,
                        NumCheque = value.NumCheque,
                        NumChequeIni = value.NumChequeIni,
                        NumChequeMax = value.NumChequeMax,
                        NumChequeAviso = value.NumChequeAviso,
                        FechaConciliacionCobros = value.FechaConciliacionCobros== null ? utileria.convHoraTiempo2(value.FechaConciliacionCobros) : value.FechaConciliacionCobros,//
                        FechaConciliacionPagos = value.FechaConciliacionPagos == null ? utileria.convHoraTiempo2(value.FechaConciliacionPagos) : value.FechaConciliacionPagos //
                    };

                    Console.WriteLine("-------------------------------");
                    Business n = new Business();
                    int resp = n.agregaEmpresaCheq(EmpresaCheq);

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Empresa = value.Empresa,
                        Banco = value.Banco,
                        Cuenta = value.Cuenta
                    };

                    dynamic response = JsonConvert.SerializeObject(res);
                    newLog.GenerarTXT("EmpresaCheq Actualizada" + response);

                    if (resp == 1)
                    {

                        Console.WriteLine("EmpresaCheq registrada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaEmpresaCheq", res).Wait();

                        Console.WriteLine("EmpresaCheq registrada en eROI");
                    }
                    else if (resp == 2)
                    {
                        Console.WriteLine("EmpresaCheq actualizada en DB");
                        Console.WriteLine("------------------------");

                        APIeRoi.CallApi("POST", "ActualizaEmpresaCheq", res).Wait();

                        Console.WriteLine("EmpresaCheq actualizado en eROI");
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
                    newLog.GenerarTXT("Excepción en Agregar EmpresaCheq: " + e.Message);
                }
            }
        }
    }
}
