using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco.Utilerias
{
    public class Standars
    {
        public DateTime? convHoraTiempo2(dynamic fecha)
        {
            //fecha = "0000-00-00 00:00:00";
            //if (0000 <= 0)
            //{
            //    anio = 1899;
            //}
            //Console.WriteLine("fecha " + fecha);
            //fecha = "0000-00-00 00:00:00";
            //if (0000 <= 0)
            //    anio = 1899;
            //if(00 <= 0)
            //    mes = 01;
            //if(00 <= 0;
            //    day = 01;
            DateTime? d;
            DateTime? fechafor;

            DateTime Year;
            int year = 0;
            if (fecha == "0000-00-00")
            {
                d = null;
                fechafor = d;
                //Console.WriteLine("hora2 " + fechafor);

                return fechafor;
            }

            if (fecha != "0000-00-00 00:00:00")
            {
                Year = Convert.ToDateTime(fecha);
                year = Year.Year;
            }
            //Console.WriteLine("Imprime la fecha" + fecha);
            if (year == 1899 || fecha == "0000-00-00 00:00:00" || fecha == "0000-00-00 00:00:00.000000")
            {
                
                d = null;
                fechafor = d;
                //Console.WriteLine("hora2 " + fechafor);

                return fechafor;
            }
           
            DateTime? value = Convert.ToDateTime(fecha);
            fechafor = value;

            return fechafor;
        }
        public DateTime convHoraTiempo3(dynamic fecha)
        {
            

           
            if (fecha == "0000-00-00 00:00:00")
            {
                //Console.WriteLine("hora3 " + fecha);
                DateTime fe = Convert.ToDateTime("1899-12-30 00:00:00");
               

                return fe;
            }

            //DateTime val = Convert.ToDateTime(fecha);
            if (fecha == "0000-00-00 00:00:00.000000")
            {
               // Console.WriteLine("hora3 2" + fecha);
                DateTime fe = Convert.ToDateTime("1899-12-30 00:00:00.000000");
                //Console.WriteLine("hora4 " + fe);

                return fe;
            }

            if (fecha == "0000-00-00")
            {
                DateTime fe = Convert.ToDateTime("1899-12-30 00:00:00");
                return fe;
            }
           // Console.WriteLine("Conver3");
            DateTime value = Convert.ToDateTime(fecha);

            //Console.WriteLine("fecha " + fechafor);
            return value;
        }
        public bool convBoolStr(dynamic nro)
        {
            bool value = false;
            if (nro == "1")
            {
                value = true;
                return value;
            }
            else if (nro == null)
            {
                value = false;
                return value;
            }
            value = false;

            return value;
        }

        public decimal convDecimal(dynamic dec)
        {
            decimal val = dec == null ? 0 : Convert.ToDecimal(dec);
            return val;
        }
        public int convInt(dynamic num)
        {
            
            int value = 0;
            string numero = (string)num;
            if (numero == null || numero == "")
            {
                value = 0;
            }
            else {
                value = Int32.Parse(numero);
            }
            
            return value;
        }
    }
}
