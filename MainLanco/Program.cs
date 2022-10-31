using MainLanco.Conexion;
using MainLanco.eRoi;
using MainLanco.Utilerias;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inicio!");
                Business.addCliente();
                //APIeRoi.updateCliente().Wait();

                //APIeRoi.folioAeRoi();
                //fileRegistro.enviarRegistrosXHora();

                //APIeRoi.addObra();
                //APIeRoi.updateObra();
                AddRemC.RemC();
                AddRemCA.RemCA();
                AddRemD.RemD();
                AddFactC.FactC();
                AddFactCA.FactCA();
                AddFactCFD.FactCFD();
                AddFactD.FactD();
                AddObraServicioProg.SAVObraServicioProg();

                Console.WriteLine("Fin!");
            }
            catch (Exception ex)
            {
                newLog.GenerarTXT("Excepción: " + ex.Message + " " + ex.GetType().ToString());
            }
        }
    }

}
