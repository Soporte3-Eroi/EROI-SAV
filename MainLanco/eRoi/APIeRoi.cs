﻿using DatosLAnco;
using MainLanco.Conexion;
using MainLanco.Utilerias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MainLanco.eRoi
{
    public class APIeRoi
    {
        public string Res { get; set; }
        public string Clave { get; set; }
        public string ClaveLanco { get; set; }

        //public static string url = "https://lanco.eroi.com.mx/qas/index.php?r=api/";
        public static string url = "";
        public static string token = "";
        //public static string user = "1034_01";
        public static string user = "";
        //public static string pass = "1034_01";
        public static string pass = "";

        public static async Task addCliente()
        {
            await Clientes(true);
        }
        public static async Task updateCliente()
        {
            await Clientes(false);
        }
        public static void addObra()
        {
            Obras(true);
        }
        public static void updateObra()
        {
            Obras(false);
        }
        public static async Task Clientes(bool dto)
        {
            Credenciales crd = new Credenciales();
            dynamic ob = crd.credenciales();
            url = ob.url;
            user = ob.user;
            pass = ob.pass;

            dynamic resToken = await Login(user, pass);

            dynamic resApi = CallApi("Get", "Clientes", new { }).Result;

            foreach (dynamic value in resApi.data)
            {
                //var context = new pruebaEntities();
                try
                {
                    DateTime? Alta = DateTime.Now; //Lineas
                    dbModel db = new dbModel();
                    Standars utileria = new Standars();
                    string newId = "";
                    if (dto)
                    {
                        var idCliente = db.SAVFolio.First();
                        newId = (idCliente.Cliente + 1).ToString();

                        //Formatear id de 9101 a 009101
                        for (int i = 0; newId.Length <= 5; i++)
                        {
                            newId = "0" + newId;
                        }
                    }
                    else
                    {
                        var idCliente = db.SAVFolio.First();
                        newId = (idCliente.Cliente).ToString();

                        //Formatear id de 9101 a 009101
                        for (int i = 0; newId.Length <= 5; i++)
                        {
                            newId = "0" + newId;
                        }
                    }
                    

                    var Cliente = new SAVCliente()
                    {
                        Clave = newId,
                        Empresa = value.Empresa,
                        Contacto = value.Contacto,
                        Direccion = value.Direccion,
                        Colonia = value.Colonia,
                        CP = value.CP,
                        Ciudad = value.Ciudad,
                        Estado = value.Estado,
                        Pais = value.Pais,
                        TelefonoOficina = value.TelefonoOficina,
                        TelefonoCasa = value.TelefonoCasa,
                        Fax = value.Fax,
                        Email = value.Email,
                        RFC = value.RFC,
                        Saldo = value.Saldo,
                        Bloqueado = value.Bloqueado,
                        FechaAlta = Alta,
                        UltimoCambio = Alta,
                        UltimoMov = Alta,
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
                        FechaAltaHora = utileria.convHoraTiempo(value.FechaAltaHora),
                        UltimoCambioHora = utileria.convHoraTiempo(value.UltimoCambioHora),

                        Estatus = value.Estatus,
                        Delegacion = value.Delegacion,
                        SaldoAnterior = utileria.convDecimal(value.SaldoAnterior),

                        SaldoLimitePago = utileria.convHoraTiempo(value.SaldoLimitePago),

                        GeneroECFecha = utileria.convHoraTiempo(value.GeneroECFecha),

                        GeneroECCapturo = value.GeneroECCapturo,
                        EnvioEmail = utileria.convBoolStr(value.EnvioEmail),
                        GeneroECDesde = value.GeneroECDesd,

                        GeneroECHasta = utileria.convHoraTiempo(value.GeneroECHasta),

                        Htmlmail = utileria.convBoolStr(value.Htmlmail),
                        UltimaRemision = utileria.convHoraTiempo(value.UltimaRemision),

                        UltimaFactura = utileria.convHoraTiempo(value.UltimaFactura),

                        Activa = utileria.convBoolStr(value.Activa),
                        UltimoCobro = utileria.convHoraTiempo2(value.UltimoCobro),

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
                        CuentaOficina2 = value.CuentaOficina2,
                        Cuenta2 = value.Cuenta2,
                        SubCuenta2 = value.SubCuenta2
                        //RegimenFiscalClave = value.RegimenFiscalClave
                    };

                    Console.WriteLine("Paso el objeto");
                    dynamic json = JsonConvert.SerializeObject(Cliente);

                    var item = JsonConvert.DeserializeObject<SAVCliente>(json);
                    Business n = new Business();
                    bool resp = n.registroCliente(item).Result;

                    // Actualiza en Eroi
                    var res = new
                    {
                        Res = "OK",
                        Clave = value.Clave,
                        ClaveLanco = newId
                    };
                    dynamic response = JsonConvert.SerializeObject(res);
                    Logger logger = new Logger();
                    logger.Log("ClienteActualizado" + response);

                    if (resp)
                    {
                        
                        Console.WriteLine("Cliente registrado en DB");
                        Console.WriteLine("------------------------");

                        await CallApi("POST", "ActualizaClientes", res);

                        Console.WriteLine("Cliente registrado en eROI");
                    }
                    else
                    {
                        Console.WriteLine("Cliente actualizado en DB");
                        Console.WriteLine("------------------------");

                        await CallApi("POST", "ActualizaClientes", res);

                        Console.WriteLine("Cliente actualizado en eROI");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error" + e.Message);
                }
            }
        }

        public static void Obras(bool dto)
        {
            try
            {
                Credenciales crd = new Credenciales();
                dynamic ob = crd.credenciales();
                url = ob.url;
                user = ob.user;
                pass = ob.pass;

                dynamic resToken = Login(user, pass).Result;

                dynamic resApi = CallApi("Get", "Obras", new { }).Result;

                foreach (dynamic value in resApi.data)
                {

                    try
                    {
                        DateTime? Alta = DateTime.Now; //Lineas
                        dbModel db = new dbModel();
                        Standars utileria = new Standars();

                        string newId = "";
                        if (dto)
                        {
                            var idObra = db.SAVFolio.First();
                            newId = (idObra.Obra + 1).ToString();

                            //Formatear id de 9101 a 009101
                            for (int i = 0; newId.Length <= 5; i++)
                            {
                                newId = "0" + newId;
                            }
                        }
                        else
                        {
                            var idObra = db.SAVFolio.First();
                            newId = (idObra.Obra).ToString();

                            //Formatear id de 9101 a 009101
                            for (int i = 0; newId.Length <= 5; i++)
                            {
                                newId = "0" + newId;
                            }
                        }

                        var Obra = new SAVObra()
                        {
                            Obra = newId,
                            Nombre = value.Nombre,
                            ObraClave = value.ObraClave,
                            Direccion = value.Direccion,
                            Colonia = value.Colonia,
                            CP = value.CP,
                            Ciudad = value.Ciudad,
                            Estado = value.Estado,
                            Pais = value.Pais,
                            Telefono = value.Telefono,
                            EncargadoObra = value.EncargadoObra,
                            EncargadoObraTel = value.EncargadoObraTel,
                            EncargadoPago = value.EncargadoPago,
                            EncargadoPagoTel = value.EncargadoPagoTel,
                            DiasRevision = value.DiasRevision,
                            HoraRevision = value.HoraRevision,
                            DiasCobro = value.DiasCobro,
                            HorasCobro = value.HorasCobro,
                            ReportarInc = value.ReportarInc,
                            ReportarIncTel = value.ReportarIncTel,
                            NombreReporte = value.NombreReporte,
                            ConsignadoA = value.ConsignadoA,
                            FacturarA = value.FacturarA,
                            Cliente = value.Cliente, // == null ? "nan" : value.Cliente
                            ClienteNombre = value.ClienteNombre,
                            NumCopias = Convert.ToInt16(value.NumCopias),
                            FechaAlta = Alta,
                            FechaAltaHora = Alta,
                            Capturo = value.Capturo,
                            CapturoCambio = value.CapturoCambio,
                            UltimoCambio = utileria.convHoraTiempo2(value.UltimoCambio),
                            UltimoCambioHora = utileria.convHoraTiempo2(value.UltimoCambioHora),
                            CodigoArea = value.CodigoArea,
                            Servicio = Convert.ToInt32(value.Servicio),
                            Muestra = Convert.ToInt32(value.Muestra),
                            Revenimiento = Convert.ToInt32(value.Revenimiento),
                            RFC = value.RFC,
                            Giro = value.Giro,
                            Zona = value.Zona,
                            Familia = value.Familia,
                            Delegacion = value.Delegacion == null ? "nan" : value.Delegacion,
                            Descuento = Convert.ToDecimal(value.Descuento),
                            Activa = utileria.convBoolStr(value.Activa),
                            UltimaRemision = utileria.convHoraTiempo2(value.UltimaRemision),
                            UltimaFactura = utileria.convHoraTiempo2(value.UltimaFactura),
                            Serv01Secuencia = Convert.ToInt32(value.Serv01Secuencia),
                            FolioServicioProg = Convert.ToInt32(value.FolioServicioProg),
                            Saldo = utileria.convDecimal(value.Saldo),
                            NC = utileria.convDecimal(value.NC),
                            Email = value.Email,
                            SaldoAnterior = utileria.convDecimal(value.SaldoAnterior),
                            SaldoLimitePago = utileria.convHoraTiempo2(value.SaldoLimitePago),
                            GeneroECFecha = utileria.convHoraTiempo2(value.GeneroECFecha),
                            GeneroECCapturo = value.GeneroECCapturo,
                            EnvioEmail = utileria.convBoolStr(value.EnvioEmail),
                            GeneroECDesde = utileria.convHoraTiempo2(value.GeneroECDesde),
                            GeneroECHasta = utileria.convHoraTiempo2(value.GeneroECHasta),

                            HtmlMail = utileria.convBoolStr(value.HtmlMail),
                            UltimoMov = utileria.convHoraTiempo2(value.UltimoMov),
                            Aux1 = value.Aux1,
                            Aux2 = value.Aux2,
                            Ubicacion = value.Ubicacion,
                            Horario = value.Horario,
                            HorarioDesde = utileria.convHoraTiempo3(value.HorarioDesde),
                            HorarioHasta = utileria.convHoraTiempo3(value.HorarioHasta),
                            HorarioSabado = value.HorarioSabado,
                            HorarioSabadoDesde = utileria.convHoraTiempo3(value.HorarioSabadoDesde),
                            HorarioSabadoHasta = utileria.convHoraTiempo3(value.HorarioSabadoHasta),
                            HorarioDomingo = value.HorarioDomingo,
                            HorarioDomingoDesde = utileria.convHoraTiempo3(value.HorarioDomingoDesde),
                            HorarioDomingoHasta = utileria.convHoraTiempo3(value.HorarioDomingoHasta),
                            UltimoCobro = utileria.convHoraTiempo2(value.UltimoCobro),
                            Reg1 = utileria.convBoolStr(value.Reg1),
                            Serv01Copias = Convert.ToInt16(value.Serv01Copias),
                            Serv02Secuencia = Convert.ToInt32(value.Serv02Secuencia),
                            Viga = Convert.ToInt32(value.Viga),
                            Mortero = Convert.ToInt32(value.Mortero),
                            Enviado = Convert.ToInt32(value.Enviado),
                            Serv03Ensaye = Convert.ToInt32(value.Serv03Ensaye),
                            Serv04Ensaye = Convert.ToInt32(value.Serv04Ensaye),
                            Pasaje = Convert.ToDecimal(value.Pasaje),
                            Corazon = Convert.ToInt32(value.Corazon),
                            Arteza = Convert.ToInt32(value.Arteza),
                            Ruta = value.Ruta,
                            RevisionFacturas = value.RevisionFacturas,
                            RevisionPeriodicidad = value.RevisionPeriodicidad,
                            RevisionPeriodicidadDia1 = value.RevisionPeriodicidadDia1,
                            RevisionPeriodicidadDia2 = value.RevisionPeriodicidadDia2,
                            RevisionHorario = value.RevisionHorario,
                            ReportesEntrega = value.ReportesEntrega,
                            ReportesPeriodicidad = value.ReportesPeriodicidad,
                            ReportesPeriodicidadDia1 = value.ReportesPeriodicidadDia1,
                            ReportesPeriodicidadDia2 = value.ReportesPeriodicidadDia2,
                            ReportesHorario = value.ReportesHorario,
                            Presupuesto = value.Presupuesto,
                            PresupuestoPeriodicidad = value.PresupuestoPeriodicidad,
                            PresupuestoPeriodicidadDia1 = value.PresupuestoPeriodicidadDia1,
                            PresupuestoPeriodicidadDia2 = value.PresupuestoPeriodicidadDia2,
                            PresupuestoHorario = value.PresupuestoHorario,
                            Cobranza = value.Cobranza,
                            CobranzaPeriodicidad = value.CobranzaPeriodicidad,
                            CobranzaPeriodicidadDia1 = value.CobranzaPeriodicidadDia1,
                            CobranzaPeriodicidadDia2 = value.CobranzaPeriodicidadDia2,
                            CobranzaHorario = value.CobranzaHorario,
                            CobranzaPlazo = Convert.ToInt16(value.CobranzaPlazo),
                            CobranzaActiva = utileria.convBoolStr(value.CobranzaActiva),
                            PVCobroSeparado = utileria.convBoolStr(value.PVCobroSeparado),
                            TipoCobro = value.TipoCobro, // == "" ? "NAN" : value.TipoCobro
                            ConcretoC = Convert.ToInt16(value.ConcretoC),
                            VigaC = Convert.ToInt16(value.VigaC),
                            MorteroC = Convert.ToInt16(value.MorteroC),
                            CorazonC = Convert.ToInt16(value.CorazonC),
                            ArtezaC = Convert.ToInt16(value.ArtezaC),
                            Cerrada = utileria.convBoolStr(value.Cerrada),
                            IgualaMensualDesde = utileria.convHoraTiempo2(value.IgualaMensualDesde),
                            IgualaMensualHasta = utileria.convHoraTiempo2(value.IgualaMensualHasta),
                            IgualaMensualUltMov = utileria.convHoraTiempo2(value.IgualaMensualUltMov),
                            IgualaMensualUltCorrida = Convert.ToInt32(value.IgualaMensualUltCorrida),
                            IgualaSemanalCobroMuestras = utileria.convBoolStr(value.IgualaSemanalCobroMuestras),
                            Horario2 = value.Horario2,
                            HorarioDesde2 = utileria.convHoraTiempo3(value.HorarioDesde2),
                            HorarioHasta2 = utileria.convHoraTiempo3(value.HorarioHasta2),
                            HorarioSabado2 = value.HorarioSabado2,
                            HorarioSabadoDesde2 = utileria.convHoraTiempo3(value.HorarioSabadoDesde2),
                            HorarioSabadoHasta2 = utileria.convHoraTiempo3(value.HorarioSabadoHasta2),
                            HorarioDomingo2 = value.HorarioDomingo2,
                            HorarioDomingoDesde2 = utileria.convHoraTiempo3(value.HorarioDomingoDesde2),
                            HorarioDomingoHasta2 = utileria.convHoraTiempo3(value.HorarioDomingoHasta2),
                            DescuentoAutomatico = utileria.convBoolStr(value.DescuentoAutomatico),
                            ServiciosPendRemisionar = Convert.ToDecimal(value.ServiciosPendRemisionar),
                            Observaciones = value.Observaciones,
                            DiasDesc = value.DiasDesc,
                            FacturaElectronica = utileria.convBoolStr(value.FacturaElectronica),
                            NombreF = value.NombreF,
                            DireccionF = value.DireccionF,
                            NumExteriorF = value.NumExteriorF,
                            NumInteriorF = value.NumInteriorF,
                            ColoniaF = value.ColoniaF,
                            DelegacionF = value.DelegacionF,
                            CPF = value.CPF,
                            CiudadF = value.CiudadF,
                            EstadoF = value.EstadoF,
                            PaisF = value.PaisF,
                            EmailF = value.EmailF,
                            CalaCobroSeparado = utileria.convBoolStr(value.CalaCobroSeparado),
                            MetododePago = value.MetododePago,
                            NumCtaPago = value.NumCtaPago,
                            EmailC = value.EmailC,
                            Aux3 = value.Aux3,
                            Aux4 = value.Aux4,
                            LimiteCredito = Convert.ToDecimal(value.LimiteCredito),
                            OCFecha = utileria.convHoraTiempo2(value.OCFecha),
                            OCObservaciones = value.OCObservaciones,
                            FormadePago = value.FormadePago,
                            UsoCFDI = value.UsoCFDI,
                            AuxMP = "NAN",
                            ServEspSecuencia = Convert.ToInt32(value.ServEspSecuencia),
                            ServEsp = value.ServEsp,
                            SerieF = value.SerieF
                            //RegimenFiscalClave = value.RegimenFiscalClave
                        };

                        Console.WriteLine("Paso el objeto");

                        dynamic json = JsonConvert.SerializeObject(Obra);
                        var item = JsonConvert.DeserializeObject<SAVObra>(json);

                        Business n = new Business();
                        bool resp = n.registroObra(item);

                        // Actualiza en Eroi
                        var res = new
                        {
                            Res = "OK",
                            Clave = value.Clave,
                            ClaveLanco = newId
                        };

                        dynamic response = JsonConvert.SerializeObject(res);
                        Logger logger = new Logger();
                        logger.Log("ObraActualizado" + response);

                        if (resp)
                        {

                            Console.WriteLine("Obra registrada en DB");
                            Console.WriteLine("------------------------");

                            CallApi("POST", "ActualizaObras", res).Wait();

                            Console.WriteLine("Obra registrada en eROI");
                        }
                        else
                        {
                            Console.WriteLine("Obra actualizada en DB");
                            Console.WriteLine("------------------------");

                            CallApi("POST", "ActualizaObras", res).Wait();

                            Console.WriteLine("Obra actualizado en eROI");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message + e.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                //Logger logger = new Logger();
                //logger.Log("Error " + ex.Message);
                Console.WriteLine("Error " + ex.Message);
            }
            
        }
        public static async Task<string[]> Login(string username, string password)
        {
            Dictionary<string, object> loginData = new Dictionary<string, object>();
            loginData.Add("username", username);
            loginData.Add("password", password);

            dynamic resApi = await CallApi("POST", "login", loginData);

            if (resApi.status == "OK")
            {
                token = resApi.data.token;

                string[] res = { "OK", "Realizado", token };

                return res;
            }
            else
            {
                string message = resApi.message;
                string[] res = { "ER", message };
                return res;
            }
        }

        public static async Task<dynamic> CallApi(string type, string method, object dataSend)
        {
            Logger logger = new Logger();
            HttpClient client = new HttpClient();
            if (method != "login")
            {
                client.DefaultRequestHeaders.Add("AUTH", token);
            }
            dynamic httpResponse = null;
            if (type == "GET")
            {
                httpResponse = await client.GetAsync(url + method);
                //Console.WriteLine(httpResponse);
                //httpResponse = await client.GetAsync(url + "TestApi");
            }
            else
            {
                //// Serialize our concrete class into a JSON String
                var stringPayload = JsonConvert.SerializeObject(dataSend);
                //Console.WriteLine(stringPayload);
                // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
                var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
                // Do the actual request and await the response
                //httpResponse = await client.PostAsync(url + "TestApi", httpContent);
                //httpResponse = await client.PostAsync(url + method, httpContent).Result;
                if (method != "login")
                {
                    httpResponse = client.PostAsync(url + method, httpContent).Result;
                }
                else
                {
                    httpResponse = client.PostAsync(url + method, httpContent).Result;

                }

            }
            // If the response contains content we want to read it!
            if (httpResponse.Content != null)
            {
                //Console.WriteLine("llego error");
                var responseJson = httpResponse.Content.ReadAsStringAsync().Result;
                dynamic response = JsonConvert.DeserializeObject(responseJson);
                logger.Log("Llego" + response);
                return response;
            }
            var responseFail = new
            {
                status = "ER",
            };

            Console.WriteLine("llego error");
            var stringEr = JsonConvert.SerializeObject(responseFail);
            dynamic responseER = JsonConvert.DeserializeObject(stringEr);
            logger.Log("Llego error: " + responseER);
            return responseER;
        }
    }
}