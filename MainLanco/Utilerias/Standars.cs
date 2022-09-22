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
        public DateTime? convHoraTiempo(dynamic fecha)
        {
            //Console.WriteLine("hora1 " + fecha);

            DateTime? d;
            string value = fecha;
            DateTime? fechafor = fecha == "0000-00-00" ? d = null : Convert.ToDateTime(value);
            //Console.WriteLine("fecha " + fechafor);

            return fechafor;
        }
        public DateTime? convHoraTiempo2(dynamic fecha)
        {
            //Console.WriteLine("fecha " + fecha);

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

            if (year == 1899 || fecha == "0000-00-00 00:00:00")
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
            //Console.WriteLine("hora3 " + fecha);

            //DateTime val = Convert.ToDateTime(fecha);
            if (fecha == "0000-00-00 00:00:00")
            {
                DateTime fe = Convert.ToDateTime("1899-12-30 00:00:00");
                //Console.WriteLine("hora4 " + fe);

                return fe;
            }

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
            int value = num == null ? 0 : Int32.Parse(num);
            return value;
        }
    }
}
