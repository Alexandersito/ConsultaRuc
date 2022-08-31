using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaRuc.CodigoUsuario;
using ConsultaRuc.EntidadNegocio;

namespace ConsultaRuc
{
    public partial class FrmConsultaRUCSUNAT : Form
    {
        public FrmConsultaRUCSUNAT()
        {
            InitializeComponent();
        }
        private EnSUNAT ObtenerDatos(string contenidoHTML)
        {
            CuTexto oCuTexto = new CuTexto();
            EnSUNAT oEnSUNAT = new EnSUNAT();
            string nombreInicio = "<HEAD><TITLE>";
            string nombreFin = "</TITLE></HEAD>";
            string contenidoBusqueda = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, nombreInicio, nombreFin);
            if (contenidoBusqueda == ".:: Pagina de Mensajes ::.")
            {
                nombreInicio = "<p class=\"error\">";
                nombreFin = "</p>";
                oEnSUNAT.TipoRespuesta = 2;
                oEnSUNAT.MensajeRespuesta = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, nombreInicio, nombreFin);
            }
            else if (contenidoBusqueda == ".:: Pagina de Error ::.")
            {
                nombreInicio = "<p class=\"error\">";
                nombreFin = "</p>";
                oEnSUNAT.TipoRespuesta = 3;
                oEnSUNAT.MensajeRespuesta = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, nombreInicio, nombreFin);
            }
            else
            {
                oEnSUNAT.TipoRespuesta = 2;
                nombreInicio = "<div class=\"list-group\">";
                nombreFin = "<div class=\"panel-footer text-center\">";
                contenidoBusqueda = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, nombreInicio, nombreFin);
                if (contenidoBusqueda == "")
                {
                    nombreInicio = "<strong>";
                    nombreFin = "</strong>";
                    oEnSUNAT.MensajeRespuesta = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, nombreInicio, nombreFin);
                    if(oEnSUNAT.MensajeRespuesta == "")
                        oEnSUNAT.MensajeRespuesta = "No se encuentra las cabeceras principales del contenido HTML";
                }
                else
                {
                    contenidoHTML = contenidoBusqueda;
                    oEnSUNAT.MensajeRespuesta = "Mensaje del inconveniente no especificado";
                    nombreInicio = "<h4 class=\"list-group-item-heading\">";
                    nombreFin = "</h4>";
                    int resultadoBusqueda = contenidoHTML.IndexOf(nombreInicio, 0, StringComparison.OrdinalIgnoreCase);
                    if (resultadoBusqueda > -1)
                    {
                        // Modificar cuando el estado del Contribuyente es "BAJA DE OFICIO", porque se agrega un elemento con clase "list-group-item"
                        resultadoBusqueda += nombreInicio.Length;
                        string[] arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, resultadoBusqueda,
                            nombreInicio, nombreFin);
                        if (arrResultado != null)
                        {
                            oEnSUNAT.RazonSocial = arrResultado[1];

                            // Tipo Contribuyente
                            nombreInicio = "<p class=\"list-group-item-text\">";
                            nombreFin = "</p>";
                            arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                nombreInicio, nombreFin);
                            if (arrResultado != null)
                            {
                                oEnSUNAT.TipoContribuyente = arrResultado[1];

                                // Nombre Comercial
                                arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                    nombreInicio, nombreFin);
                                if (arrResultado != null)
                                {
                                    oEnSUNAT.NombreComercial = arrResultado[1].Replace("\r\n", "").Replace("\t", "").Trim();

                                    // Fecha de Inscripción
                                    arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                        nombreInicio, nombreFin);
                                    if (arrResultado != null)
                                    {
                                        oEnSUNAT.FechaInscripcion = arrResultado[1];

                                        // Fecha de Inicio de Actividades: 
                                        arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                            nombreInicio, nombreFin);
                                        if (arrResultado != null)
                                        {
                                            oEnSUNAT.FechaInicioActividades = arrResultado[1];
                                            
                                            // Estado del Contribuyente
                                            arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                            nombreInicio, nombreFin);
                                            if (arrResultado != null)
                                            {
                                                oEnSUNAT.EstadoContribuyente = arrResultado[1].Trim();

                                                // Condición del Contribuyente
                                                arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                                    nombreInicio, nombreFin);
                                                if (arrResultado != null)
                                                {
                                                    oEnSUNAT.CondicionContribuyente = arrResultado[1].Trim();

                                                    // Domicilio Fiscal
                                                    arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                                        nombreInicio, nombreFin);
                                                    if (arrResultado != null)
                                                    {
                                                        oEnSUNAT.DomicilioFiscal = arrResultado[1].Trim();

                                                        // Actividad(es) Económica(s)
                                                        nombreInicio = "<tbody>";
                                                        nombreFin = "</tbody>";
                                                        arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                                            nombreInicio, nombreFin);
                                                        if (arrResultado != null)
                                                        {
                                                            oEnSUNAT.ActividadesEconomicas = arrResultado[1].Replace("\r\n", "").Replace("\t", "").Trim();

                                                            // Comprobantes de Pago c/aut. de impresión (F. 806 u 816)
                                                            arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                                                nombreInicio, nombreFin);
                                                            if (arrResultado != null)
                                                            {
                                                                oEnSUNAT.ComprobantesPago = arrResultado[1].Replace("\r\n", "").Replace("\t", "").Trim();

                                                                // Sistema de Emisión Electrónica
                                                                arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                                                    nombreInicio, nombreFin);
                                                                if (arrResultado != null)
                                                                {
                                                                    oEnSUNAT.SistemaEmisionComprobante = arrResultado[1].Replace("\r\n", "").Replace("\t", "").Trim();

                                                                    // Afiliado al PLE desde
                                                                    nombreInicio = "<p class=\"list-group-item-text\">";
                                                                    nombreFin = "</p>";
                                                                    arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                                                        nombreInicio, nombreFin);
                                                                    if (arrResultado != null)
                                                                    {
                                                                        oEnSUNAT.AfiliadoPLEDesde = arrResultado[1];

                                                                        // Padrones 
                                                                        nombreInicio = "<tbody>";
                                                                        nombreFin = "</tbody>";
                                                                        arrResultado = oCuTexto.ExtraerContenidoEntreTag(contenidoHTML, Convert.ToInt32(arrResultado[0]),
                                                                            nombreInicio, nombreFin);
                                                                        if (arrResultado != null)
                                                                        {
                                                                            oEnSUNAT.Padrones = arrResultado[1].Replace("\r\n", "").Replace("\t", "").Trim();
                                                                        }
                                                                    }

                                                                    oEnSUNAT.TipoRespuesta = 1;
                                                                    oEnSUNAT.MensajeRespuesta = "Ok";
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return oEnSUNAT;
        }
        
        private async void btnConsultarRUCMedianteNumeroRandom_Click(object sender, EventArgs e)
        {
            int tipoRespuesta = 2;
            string mensajeRespuesta = "";

            txtRUC.Text = "";
            txtTipoContribuyente.Text = "";
            txtNombreComercial.Text = "";
            txtFechaInscripcion.Text = "";
            txtFechaInicioActividades.Text = "";
            txtEstadoContribuyente.Text = "";
            txtCondicionContribuyente.Text = "";
            txtDomicilioFiscal.Text = "";
            txtSistemaEmisionComprobante.Text = "";
            txtActividadesEconomicas.Text = "";
            txtComprobantesPago.Text = "";
            txtAfiliadoPLE.Text = "";
            txtPadrones.Text = "";

            string ruc = txtNumeroRUC.Text;
            if (string.IsNullOrWhiteSpace(ruc))
                return;

            CuTexto oCuTexto = new CuTexto();

            Stopwatch oCronometro = new Stopwatch();
            oCronometro.Start();

            btnConsultarRUCMedianteNumeroRandom.Enabled = false;

            #region Consulta mediante numRnd (2da version - Dejó de funcionar)
            //CookieContainer cookies = new CookieContainer();
            //HttpClientHandler controladorMensaje = new HttpClientHandler();
            //controladorMensaje.CookieContainer = cookies;
            //controladorMensaje.UseCookies = true;
            //using (HttpClient cliente = new HttpClient(controladorMensaje))
            //{
            //    cliente.DefaultRequestHeaders.Add("Host", "e-consultaruc.sunat.gob.pe");
            //    cliente.DefaultRequestHeaders.Add("sec-ch-ua",
            //        " \" Not A;Brand\";v=\"99\", \"Chromium\";v=\"90\", \"Google Chrome\";v=\"90\"");
            //    cliente.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
            //    cliente.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "document");
            //    cliente.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "navigate");
            //    cliente.DefaultRequestHeaders.Add("Sec-Fetch-Site", "none");
            //    cliente.DefaultRequestHeaders.Add("Sec-Fetch-User", "?1");
            //    cliente.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
            //    cliente.DefaultRequestHeaders.Add("User-Agent",
            //        "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.150 Safari/537.36");
            //    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 |
            //                                           SecurityProtocolType.Tls12;
            //    string textoAleatorio =
            //        "IMPORTANTE LAS PALABRAS CLAVES DEBE SER ALEATORIO EXISTIR LETRAS Y ESTAR EN MAYUSCULA COMO RANDOM UAP UPC LIMA HOLA MUNDO COMO ESTAS TEST comparte LOS VIDEOS EN TUS REDES SOCIALES PARA MAS CONTENIDOS si quieres aprender sobre web api entonces revisa lista de reproduccion del canal mr angel".ToUpper();

            //    string[] arrNombreAleatorio = textoAleatorio.Split(' ');
            //    Random oAleatorio = new Random();
            //    int nPalabra = oAleatorio.Next(arrNombreAleatorio.Length);
            //    await Task.Delay(100);

            //    string url =
            //        "https://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRazonSoc&razSoc=" + arrNombreAleatorio[nPalabra];
            //    using (HttpResponseMessage resultadoConsultaToken = await cliente.GetAsync(new Uri(url)))
            //    {
            //        if (resultadoConsultaToken.IsSuccessStatusCode)
            //        {
            //            cliente.DefaultRequestHeaders.Remove("Sec-Fetch-Site");

            //            cliente.DefaultRequestHeaders.Add("Origin", "https://e-consultaruc.sunat.gob.pe");
            //            cliente.DefaultRequestHeaders.Add("Referer", url);
            //            cliente.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");

            //            string contenidoHTML = await resultadoConsultaToken.Content.ReadAsStringAsync();
            //            string numeroRandom = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, "name=\"numRnd\" value=\"", "\">");

            //            /*Solicitud GET*/
            //            //url = string.Format("https://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&actReturn=1&nroRuc={0}&numRnd={1}&modo=1", ruc, numeroRandom);
            //            // o
            //            /*Llamada POST*/
            //            var lClaveValor = new List<KeyValuePair<string, string>>
            //            {
            //                new KeyValuePair<string, string>("accion", "consPorRuc"),
            //                new KeyValuePair<string, string>("actReturn", "1"),
            //                new KeyValuePair<string, string>("nroRuc", ruc),
            //                new KeyValuePair<string, string>("numRnd", numeroRandom),
            //                new KeyValuePair<string, string>("modo", "1")
            //            };
            //            FormUrlEncodedContent contenido = new FormUrlEncodedContent(lClaveValor);

            //            url = "https://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias";
            //            using (HttpResponseMessage resultadoConsultaDatos = await cliente.PostAsync(url, contenido))
            //            {
            //                if (resultadoConsultaDatos.IsSuccessStatusCode)
            //                {
            //                    contenidoHTML = await resultadoConsultaDatos.Content.ReadAsStringAsync();
            //                    contenidoHTML = WebUtility.HtmlDecode(contenidoHTML);

            //                    #region Obtener los datos del RUC
            //                    EnSUNAT oEnSUNAT = ObtenerDatos(contenidoHTML);
            //                    if (oEnSUNAT.TipoRespuesta == 1)
            //                    {
            //                        txtRUC.Text = oEnSUNAT.RazonSocial;
            //                        txtTipoContribuyente.Text = oEnSUNAT.TipoContribuyente;
            //                        txtNombreComercial.Text = oEnSUNAT.NombreComercial;
            //                        txtFechaInscripcion.Text = oEnSUNAT.FechaInscripcion;
            //                        txtFechaInicioActividades.Text = oEnSUNAT.FechaInicioActividades;
            //                        txtEstadoContribuyente.Text = oEnSUNAT.EstadoContribuyente;
            //                        txtCondicionContribuyente.Text = oEnSUNAT.CondicionContribuyente;
            //                        txtDomicilioFiscal.Text = oEnSUNAT.DomicilioFiscal;
            //                        txtSistemaEmisionComprobante.Text = oEnSUNAT.SistemaEmisionComprobante;
            //                        txtActividadesEconomicas.Text = oEnSUNAT.ActividadesEconomicas;
            //                        txtComprobantesPago.Text = oEnSUNAT.ComprobantesPago;
            //                        txtAfiliadoPLE.Text = oEnSUNAT.AfiliadoPLEDesde;
            //                        txtPadrones.Text = oEnSUNAT.Padrones;

            //                        tipoRespuesta = 1;
            //                        mensajeRespuesta =
            //                            string.Format("Se realizó exitosamente la consulta del número de RUC {0}",
            //                                ruc);
            //                    }
            //                    else
            //                    {
            //                        tipoRespuesta = oEnSUNAT.TipoRespuesta;
            //                        mensajeRespuesta = string.Format(
            //                            "No se pudo realizar la consulta del número de RUC {0}.\r\nDetalle: {1}",
            //                            ruc,
            //                            oEnSUNAT.MensajeRespuesta);
            //                    }
            //                    #endregion

            //                }
            //                else
            //                {
            //                    mensajeRespuesta = await resultadoConsultaDatos.Content.ReadAsStringAsync();
            //                    mensajeRespuesta =
            //                        string.Format(
            //                            "Ocurrió un inconveniente al consultar los datos del RUC {0}.\r\nDetalle:{1}",
            //                            ruc, mensajeRespuesta);
            //                }
            //            }
            //        }
            //        else
            //        {
            //            mensajeRespuesta = await resultadoConsultaToken.Content.ReadAsStringAsync();
            //            mensajeRespuesta =
            //                string.Format(
            //                    "Ocurrió un inconveniente al consultar el número random del RUC {0}.\r\nDetalle:{1}",
            //                    ruc, mensajeRespuesta);
            //        }
            //    }
            //}
            
            #endregion

            CookieContainer cookies = new CookieContainer();
            HttpClientHandler controladorMensaje = new HttpClientHandler();
            controladorMensaje.CookieContainer = cookies;
            controladorMensaje.UseCookies = true;
            using (HttpClient cliente = new HttpClient(controladorMensaje))
            {
                cliente.DefaultRequestHeaders.Add("Host", "e-consultaruc.sunat.gob.pe");
                cliente.DefaultRequestHeaders.Add("sec-ch-ua",
                    " \" Not A;Brand\";v=\"99\", \"Chromium\";v=\"90\", \"Google Chrome\";v=\"90\"");
                cliente.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "document");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "navigate");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-Site", "none");
                cliente.DefaultRequestHeaders.Add("Sec-Fetch-User", "?1");
                cliente.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
                cliente.DefaultRequestHeaders.Add("User-Agent",
                    "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.150 Safari/537.36");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 |
                                                       SecurityProtocolType.Tls12;
                await Task.Delay(100);

                string url =
                    "https://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias";
                using (HttpResponseMessage resultadoConsulta = await cliente.GetAsync(new Uri(url)))
                {
                    if (resultadoConsulta.IsSuccessStatusCode)
                    {
                        await Task.Delay(100);
                        cliente.DefaultRequestHeaders.Remove("Sec-Fetch-Site");

                        cliente.DefaultRequestHeaders.Add("Origin", "https://e-consultaruc.sunat.gob.pe");
                        cliente.DefaultRequestHeaders.Add("Referer", url);
                        cliente.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");

                        string numeroDNI = "12345678"; // cualquier número DNI que exista en SUNAT. Pueden aprovechar este "bug" para consultar también mediante DNI a la SUNAT
                        var lClaveValor = new List<KeyValuePair<string, string>>
                        {
                            new KeyValuePair<string, string>("accion", "consPorTipdoc"),
                            new KeyValuePair<string, string>("razSoc", ""),
                            new KeyValuePair<string, string>("nroRuc", ""),
                            new KeyValuePair<string, string>("nrodoc", numeroDNI), 
                            new KeyValuePair<string, string>("contexto", "ti-it"),
                            new KeyValuePair<string, string>("modo", "1"),
                            new KeyValuePair<string, string>("search1", ""),
                            new KeyValuePair<string, string>("rbtnTipo", "2"),
                            new KeyValuePair<string, string>("tipdoc", "1"),
                            new KeyValuePair<string, string>("search2", numeroDNI),
                            new KeyValuePair<string, string>("search3", ""),
                            new KeyValuePair<string, string>("codigo", ""),
                        };
                        FormUrlEncodedContent contenido = new FormUrlEncodedContent(lClaveValor);
                        
                        url = "https://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias";
                        using (HttpResponseMessage resultadoConsultaRandom = await cliente.PostAsync(url, contenido))
                        {
                            if (resultadoConsultaRandom.IsSuccessStatusCode)
                            {
                                await Task.Delay(100);
                                string contenidoHTML = await resultadoConsultaRandom.Content.ReadAsStringAsync();
                                string numeroRandom = oCuTexto.ExtraerContenidoEntreTagString(contenidoHTML, 0, "name=\"numRnd\" value=\"", "\">");

                                lClaveValor = new List<KeyValuePair<string, string>>
                                {
                                    new KeyValuePair<string, string>("accion", "consPorRuc"),
                                    new KeyValuePair<string, string>("actReturn", "1"),
                                    new KeyValuePair<string, string>("nroRuc", ruc),
                                    new KeyValuePair<string, string>("numRnd", numeroRandom),
                                    new KeyValuePair<string, string>("modo", "1")
                                };
                                // Por si cae en el primer intento por el código "Unauthorized", en el buble se va a intentar hasta 3 veces "nConsulta"
                                int cConsulta = 0;
                                int nConsulta = 3;
                                HttpStatusCode codigoEstado = HttpStatusCode.Unauthorized;
                                while (cConsulta < nConsulta && codigoEstado == HttpStatusCode.Unauthorized)
                                {
                                    contenido = new FormUrlEncodedContent(lClaveValor);
                                    using (HttpResponseMessage resultadoConsultaDatos =
                                    await cliente.PostAsync(url, contenido))
                                    {
                                        codigoEstado = resultadoConsultaDatos.StatusCode;
                                        if (resultadoConsultaDatos.IsSuccessStatusCode)
                                        {
                                            contenidoHTML = await resultadoConsultaDatos.Content.ReadAsStringAsync();
                                            contenidoHTML = WebUtility.HtmlDecode(contenidoHTML);

                                            #region Obtener los datos del RUC
                                            EnSUNAT oEnSUNAT = ObtenerDatos(contenidoHTML);
                                            if (oEnSUNAT.TipoRespuesta == 1)
                                            {
                                                txtRUC.Text = oEnSUNAT.RazonSocial;
                                                txtTipoContribuyente.Text = oEnSUNAT.TipoContribuyente;
                                                txtNombreComercial.Text = oEnSUNAT.NombreComercial;
                                                txtFechaInscripcion.Text = oEnSUNAT.FechaInscripcion;
                                                txtFechaInicioActividades.Text = oEnSUNAT.FechaInicioActividades;
                                                txtEstadoContribuyente.Text = oEnSUNAT.EstadoContribuyente;
                                                txtCondicionContribuyente.Text = oEnSUNAT.CondicionContribuyente;
                                                txtDomicilioFiscal.Text = oEnSUNAT.DomicilioFiscal;
                                                txtSistemaEmisionComprobante.Text = oEnSUNAT.SistemaEmisionComprobante;
                                                txtActividadesEconomicas.Text = oEnSUNAT.ActividadesEconomicas;
                                                txtComprobantesPago.Text = oEnSUNAT.ComprobantesPago;
                                                txtAfiliadoPLE.Text = oEnSUNAT.AfiliadoPLEDesde;
                                                txtPadrones.Text = oEnSUNAT.Padrones;

                                                tipoRespuesta = 1;
                                                mensajeRespuesta =
                                                    string.Format("Se realizó exitosamente la consulta del número de RUC {0}",
                                                        ruc);
                                            }
                                            else
                                            {
                                                tipoRespuesta = oEnSUNAT.TipoRespuesta;
                                                mensajeRespuesta = string.Format(
                                                    "No se pudo realizar la consulta del número de RUC {0}.\r\nDetalle: {1}",
                                                    ruc,
                                                    oEnSUNAT.MensajeRespuesta);
                                            }
                                            #endregion
                                        }
                                        else
                                        {
                                            mensajeRespuesta = await resultadoConsultaDatos.Content.ReadAsStringAsync();
                                            mensajeRespuesta =
                                                string.Format(
                                                    "Ocurrió un inconveniente al consultar los datos del RUC {0}.\r\nDetalle:{1}",
                                                    ruc, mensajeRespuesta);
                                        }
                                    }

                                    cConsulta++;
                                }

                            }
                            else
                            {
                                mensajeRespuesta = await resultadoConsultaRandom.Content.ReadAsStringAsync();
                                mensajeRespuesta =
                                    string.Format(
                                        "Ocurrió un inconveniente al consultar el número random del RUC {0}.\r\nDetalle:{1}",
                                        ruc, mensajeRespuesta);
                            }
                        }
                    }
                    else
                    {
                        mensajeRespuesta = await resultadoConsulta.Content.ReadAsStringAsync();
                        mensajeRespuesta =
                            string.Format(
                                "Ocurrió un inconveniente al consultar la página principal {0}.\r\nDetalle:{1}",
                                ruc, mensajeRespuesta);
                    }
                }
            }

            oCronometro.Stop();


            if (tipoRespuesta > 1)
                MessageBox.Show(mensajeRespuesta, "Consultar RUC mediante número random"
                    , MessageBoxButtons.OK
                    , tipoRespuesta == 2 ? MessageBoxIcon.Warning : MessageBoxIcon.Error);

            lblMensaje.Text = string.Format("Procesado en {0} seg.", oCronometro.Elapsed.TotalSeconds);

            btnConsultarRUCMedianteNumeroRandom.Enabled = true;
            txtNumeroRUC.Focus();
            txtNumeroRUC.SelectAll();
        }

        private void txtNumeroRUC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
