using MainLanco.Conexion;
using MainLanco.eRoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio!");

            //APIeRoi.addCliente().Wait();
            //APIeRoi.updateCliente().Wait();


            APIeRoi.addObra();

            //APIeRoi.updateObra();

            Console.WriteLine("Fin!");

            Console.WriteLine("Enter para cerrar!");
            Console.ReadLine();
        }
    }

}
