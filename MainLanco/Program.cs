using MainLanco.Conexion;
using MainLanco.eRoi;
using MainLanco.Utilerias;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using MainLanco;

namespace MainLanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("!------------- Inicio del programa ---------------!");
                Credenciales crd = new Credenciales();
                dynamic objs = crd.credenciales();
                string user = objs.user;
                string pass = objs.pass;

                if (objs.Obra == "SI")
                {
                    Console.WriteLine("*------------------- Tabla obras! -------------------*");
                    AddObra.Obra(); //Funcional **Listo
                    Console.WriteLine("-------------------- Fin Obra -------------------");
                    
                }

                if (objs.Cliente == "SI")
                {
                    Console.WriteLine("*----------------- Tabla cliente!--------------------*");
                    AddCliente1.Clientes(); //Funcional ***Listo
                    Console.WriteLine("------------------- Fin Cliente -------------------");
                }

                if (objs.RemC == "SI")
                {
                    Console.WriteLine("*----------------- Tabla REM-C! ---------------------*");
                    AddRemC.RemC(); //FUNCIONAL ***Listo3
                    Console.WriteLine("-------------------- Fin Rem-C -------------------");
                }

                if (objs.RemD == "SI")
                {
                    Console.WriteLine("*----------------- Tabla REM-D! ---------------------*");
                    AddRemD.RemD(); // FUNCIONAL  **Listo
                    Console.WriteLine("-------------------- Fin Rem-D -------------------");
                }

                if (objs.RemCA == "SI")
                {
                    Console.WriteLine("-------------------- Tabla Rem-CA -------------------*");
                    AddRemCA.RemCA(); // **Listo
                    Console.WriteLine("-------------------- Fin Rem-CA -------------------");
                }

                if (objs.FactC == "SI")
                {
                    Console.WriteLine("*------------------- Tabla FACT-C! ------------------*");
                    AddFactC.FactC(); //FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin Fact-C -------------------");
                }

                if (objs.FactCA == "SI")
                {
                    Console.WriteLine("*------------------- Tabla FACT-CA! -----------------*");
                    AddFactCA.FactCA(); // FUNCIONAL ***Listo
                    Console.WriteLine("-------------------- Fin Fact-CA -------------------");
                }

                if (objs.FactCFD == "SI")
                {
                    Console.WriteLine("*------------------- Tabla FACT-CFD! ----------------*");
                    AddFactCFD.FactCFD(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin Fact-CFD -------------------");
                }

                if (objs.FactD == "SI")
                {
                    Console.WriteLine("*------------------- Tabla FACT-D! ------------------*");
                    AddFactD.FactD(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin Fact-D -------------------");
                }

                if (objs.ObraServicioProg == "SI")
                {
                    Console.WriteLine("*------------------- Tabla OBRASERVICOPROG! ---------*");
                    AddObraServicioProg.SAVObraServicioProg(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin ObraServicioProg -------------------");
                }

                if (objs.Serv01 == "SI")
                {
                    Console.WriteLine("*------------------- Tabla Serv01! ------------------*");
                    AddServ01.Serv01(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin Serv01 -------------------");
                }

                if (objs.Personal == "SI")
                {
                    Console.WriteLine("*------------------- Tabla Personal! ------------------*");
                    AddPersonal.Personal(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin Personal -------------------");
                }

                if (objs.Proveedor == "SI")
                {
                    Console.WriteLine("*------------------- Tabla Proveedores! ------------------*");
                    AddProveedores.Proveedor(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin Proveedores -------------------");
                }

                if (objs.ProveedorMS == "SI")
                {
                    Console.WriteLine("*------------------- Tabla ProveedoresMS! ------------------*");
                    AddProveedoresMS.ProveedorMS(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin ProveedoresMS! -------------------");
                }

                if (objs.ProveedorPagoC == "SI")
                {
                    Console.WriteLine("*------------------- Tabla ProveedoresPagoC! ------------------*");
                    AddProveedoresPagoC.ProveedorPagoC(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin ProveedoresPagoC! -------------------");
                }

                if (objs.ProveedorPagoD == "SI")
                {
                    Console.WriteLine("*------------------- Tabla ProveedoresPagoD! ------------------*");
                    AddProveedoresPagoD.ProveedorPagoD(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin ProveedoresPagoD! -------------------");
                }

                if (objs.ProveedorPagoI == "SI")
                {
                    Console.WriteLine("*------------------- Tabla ProveedoresPagoI! ------------------*");
                    AddProveedoresPagoI.ProveedorPagoI(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin ProveedoresPagoI! -------------------");
                }

                if (objs.ProveedorPagoR == "SI")
                {
                    Console.WriteLine("*------------------- Tabla ProveedoresPagoR! ------------------*");
                    AddProveedoresPagoR.ProveedorPagoR(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin ProveedoresPagoR! -------------------");
                }

                if (objs.FactCob == "SI")
                {
                    Console.WriteLine("*------------------- Tabla FactCob! ------------------*");
                    AddFactCob.FactCob(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin FactCob! -------------------");
                }

                if (objs.FactCobM == "SI")
                {
                    Console.WriteLine("*------------------- Tabla FactCobM! ------------------*");
                    AddFactCobM.FactCobM(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin FactCobM! -------------------");
                }

                if (objs.FactCobMCFD == "SI")
                {
                    Console.WriteLine("*------------------- Tabla FactCobMCFD! ------------------*");
                    AddFactCobMCFD.FactCobMCFD(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin FactCobMCFD! -------------------");
                }

                if (objs.FactCobMP == "SI")
                {
                    Console.WriteLine("*------------------- Tabla FactCobMP! ------------------*");
                    AddFactCobMP.FactCobMP(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin FactCobMP! -------------------");
                }

                if (objs.FactCobMPD == "SI")
                {
                    Console.WriteLine("*------------------- Tabla FactCobMPD! ------------------*");
                    AddFactCobMPD.FactCobMPD(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin FactCobMPD! -------------------");
                }

                if (objs.EmpresaCheq == "SI")
                {
                    Console.WriteLine("*------------------- Tabla EmpresaCheq! ------------------*");
                    AddEmpresaCheq.EmpresaCheq(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin EmpresaCheq! -------------------");
                }

                if (objs.EmpresaCheqM == "SI")
                {
                    Console.WriteLine("*------------------- Tabla EmpresaCheqM! ------------------*");
                    AddEmpresaCheqM.EmpresaCheqM(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin EmpresaCheqM! -------------------");
                }

                if (objs.EmpresaCheqMD == "SI")
                {
                    Console.WriteLine("*------------------- Tabla EmpresaCheqMD! ------------------*");
                    AddEmpresaCheqMD.EmpresaCheqMD(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin EmpresaCheqMD! -------------------");
                }

                if (objs.EmpresaCheqMT == "SI")
                {
                    Console.WriteLine("*------------------- Tabla EmpresaCheqMT! ------------------*");
                    AddEmpresaCheqMT.EmpresaCheqMT(); // FUNCIONAL **Listo
                    Console.WriteLine("-------------------- Fin EmpresaCheqMT! -------------------");
                }
                // APIeRoi.updateCliente().Wait();
                //APIeRoi.folioAeRoi();
                //fileRegistro.enviarRegistrosXHora();
                Console.WriteLine(" ----------------- Finalizo con éxito! -------------- ");
                Console.Read();

            }
            catch (Exception ex)
            {
                newLog.GenerarTXT("Excepción: " + ex.Message + " " + ex.GetType().ToString());
            }
        }
    }

}
