
namespace ConsultaRuc
{
    partial class FrmConsultaRUCSUNAT
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroRUC = new System.Windows.Forms.TextBox();
            this.btnConsultarRUCMedianteNumeroRandom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComprobantesPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtTipoContribuyente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaInscripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCondicionContribuyente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAfiliadoPLE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtActividadesEconomicas = new System.Windows.Forms.TextBox();
            this.txtSistemaEmisionComprobante = new System.Windows.Forms.TextBox();
            this.txtDomicilioFiscal = new System.Windows.Forms.TextBox();
            this.txtPadrones = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFechaInicioActividades = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEstadoContribuyente = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Número de RUC";
            // 
            // txtNumeroRUC
            // 
            this.txtNumeroRUC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroRUC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroRUC.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRUC.ForeColor = System.Drawing.Color.Firebrick;
            this.txtNumeroRUC.Location = new System.Drawing.Point(329, 32);
            this.txtNumeroRUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroRUC.MaxLength = 11;
            this.txtNumeroRUC.Name = "txtNumeroRUC";
            this.txtNumeroRUC.Size = new System.Drawing.Size(387, 29);
            this.txtNumeroRUC.TabIndex = 0;
            this.txtNumeroRUC.Text = "20211614545";
            this.txtNumeroRUC.TextChanged += new System.EventHandler(this.txtNumeroRUC_TextChanged);
            // 
            // btnConsultarRUCMedianteNumeroRandom
            // 
            this.btnConsultarRUCMedianteNumeroRandom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultarRUCMedianteNumeroRandom.Location = new System.Drawing.Point(464, 70);
            this.btnConsultarRUCMedianteNumeroRandom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultarRUCMedianteNumeroRandom.Name = "btnConsultarRUCMedianteNumeroRandom";
            this.btnConsultarRUCMedianteNumeroRandom.Size = new System.Drawing.Size(120, 62);
            this.btnConsultarRUCMedianteNumeroRandom.TabIndex = 1;
            this.btnConsultarRUCMedianteNumeroRandom.Text = "Consultar RUC mediante número random";
            this.btnConsultarRUCMedianteNumeroRandom.UseVisualStyleBackColor = true;
            this.btnConsultarRUCMedianteNumeroRandom.Click += new System.EventHandler(this.btnConsultarRUCMedianteNumeroRandom_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "RUC";
            // 
            // txtComprobantesPago
            // 
            this.txtComprobantesPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComprobantesPago.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComprobantesPago.Location = new System.Drawing.Point(220, 666);
            this.txtComprobantesPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComprobantesPago.Multiline = true;
            this.txtComprobantesPago.Name = "txtComprobantesPago";
            this.txtComprobantesPago.ReadOnly = true;
            this.txtComprobantesPago.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComprobantesPago.Size = new System.Drawing.Size(795, 61);
            this.txtComprobantesPago.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(35, 738);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 41);
            this.label4.TabIndex = 25;
            this.label4.Text = "Afiliado al PLE desde:";
            // 
            // txtRUC
            // 
            this.txtRUC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRUC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.Location = new System.Drawing.Point(220, 166);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.ReadOnly = true;
            this.txtRUC.Size = new System.Drawing.Size(795, 26);
            this.txtRUC.TabIndex = 2;
            // 
            // txtTipoContribuyente
            // 
            this.txtTipoContribuyente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoContribuyente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoContribuyente.Location = new System.Drawing.Point(220, 207);
            this.txtTipoContribuyente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoContribuyente.MaxLength = 11;
            this.txtTipoContribuyente.Name = "txtTipoContribuyente";
            this.txtTipoContribuyente.ReadOnly = true;
            this.txtTipoContribuyente.Size = new System.Drawing.Size(644, 26);
            this.txtTipoContribuyente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(31, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tipo Contribuyente: ";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreComercial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.Location = new System.Drawing.Point(220, 251);
            this.txtNombreComercial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreComercial.MaxLength = 11;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.ReadOnly = true;
            this.txtNombreComercial.Size = new System.Drawing.Size(644, 26);
            this.txtNombreComercial.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(35, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nombre Comercial: ";
            // 
            // txtFechaInscripcion
            // 
            this.txtFechaInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaInscripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInscripcion.Location = new System.Drawing.Point(220, 302);
            this.txtFechaInscripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaInscripcion.MaxLength = 11;
            this.txtFechaInscripcion.Name = "txtFechaInscripcion";
            this.txtFechaInscripcion.ReadOnly = true;
            this.txtFechaInscripcion.Size = new System.Drawing.Size(244, 26);
            this.txtFechaInscripcion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(35, 305);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fecha de Inscripción: ";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(35, 340);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 41);
            this.label7.TabIndex = 33;
            this.label7.Text = "Estado del Contribuyente: ";
            // 
            // txtCondicionContribuyente
            // 
            this.txtCondicionContribuyente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCondicionContribuyente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicionContribuyente.Location = new System.Drawing.Point(220, 406);
            this.txtCondicionContribuyente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCondicionContribuyente.MaxLength = 11;
            this.txtCondicionContribuyente.Name = "txtCondicionContribuyente";
            this.txtCondicionContribuyente.ReadOnly = true;
            this.txtCondicionContribuyente.Size = new System.Drawing.Size(244, 26);
            this.txtCondicionContribuyente.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(35, 394);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 39);
            this.label8.TabIndex = 35;
            this.label8.Text = "Condición del Contribuyente: ";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label9.Location = new System.Drawing.Point(35, 490);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Domicilio Fiscal: ";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.Location = new System.Drawing.Point(35, 537);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 42);
            this.label10.TabIndex = 39;
            this.label10.Text = "Sistema Emisión de Comprobante: ";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label11.Location = new System.Drawing.Point(35, 602);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 44);
            this.label11.TabIndex = 41;
            this.label11.Text = "Actividad(es) Económica(s): ";
            // 
            // txtAfiliadoPLE
            // 
            this.txtAfiliadoPLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAfiliadoPLE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfiliadoPLE.Location = new System.Drawing.Point(220, 752);
            this.txtAfiliadoPLE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAfiliadoPLE.MaxLength = 11;
            this.txtAfiliadoPLE.Name = "txtAfiliadoPLE";
            this.txtAfiliadoPLE.ReadOnly = true;
            this.txtAfiliadoPLE.Size = new System.Drawing.Size(244, 26);
            this.txtAfiliadoPLE.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label12.Location = new System.Drawing.Point(35, 654);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 74);
            this.label12.TabIndex = 43;
            this.label12.Text = "Comprobantes de Pago c/aut. de impresión (F. 806 u 816):";
            // 
            // txtActividadesEconomicas
            // 
            this.txtActividadesEconomicas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActividadesEconomicas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActividadesEconomicas.Location = new System.Drawing.Point(220, 585);
            this.txtActividadesEconomicas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtActividadesEconomicas.Multiline = true;
            this.txtActividadesEconomicas.Name = "txtActividadesEconomicas";
            this.txtActividadesEconomicas.ReadOnly = true;
            this.txtActividadesEconomicas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtActividadesEconomicas.Size = new System.Drawing.Size(795, 61);
            this.txtActividadesEconomicas.TabIndex = 11;
            // 
            // txtSistemaEmisionComprobante
            // 
            this.txtSistemaEmisionComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSistemaEmisionComprobante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSistemaEmisionComprobante.Location = new System.Drawing.Point(220, 516);
            this.txtSistemaEmisionComprobante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSistemaEmisionComprobante.Multiline = true;
            this.txtSistemaEmisionComprobante.Name = "txtSistemaEmisionComprobante";
            this.txtSistemaEmisionComprobante.ReadOnly = true;
            this.txtSistemaEmisionComprobante.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSistemaEmisionComprobante.Size = new System.Drawing.Size(795, 61);
            this.txtSistemaEmisionComprobante.TabIndex = 10;
            // 
            // txtDomicilioFiscal
            // 
            this.txtDomicilioFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomicilioFiscal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilioFiscal.Location = new System.Drawing.Point(220, 448);
            this.txtDomicilioFiscal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDomicilioFiscal.Multiline = true;
            this.txtDomicilioFiscal.Name = "txtDomicilioFiscal";
            this.txtDomicilioFiscal.ReadOnly = true;
            this.txtDomicilioFiscal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDomicilioFiscal.Size = new System.Drawing.Size(795, 59);
            this.txtDomicilioFiscal.TabIndex = 9;
            // 
            // txtPadrones
            // 
            this.txtPadrones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPadrones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPadrones.Location = new System.Drawing.Point(220, 800);
            this.txtPadrones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPadrones.Multiline = true;
            this.txtPadrones.Name = "txtPadrones";
            this.txtPadrones.ReadOnly = true;
            this.txtPadrones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPadrones.Size = new System.Drawing.Size(795, 61);
            this.txtPadrones.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label13.Location = new System.Drawing.Point(35, 833);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 28);
            this.label13.TabIndex = 45;
            this.label13.Text = "Padrones: ";
            // 
            // txtFechaInicioActividades
            // 
            this.txtFechaInicioActividades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaInicioActividades.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicioActividades.Location = new System.Drawing.Point(777, 302);
            this.txtFechaInicioActividades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaInicioActividades.MaxLength = 11;
            this.txtFechaInicioActividades.Name = "txtFechaInicioActividades";
            this.txtFechaInicioActividades.ReadOnly = true;
            this.txtFechaInicioActividades.Size = new System.Drawing.Size(244, 26);
            this.txtFechaInicioActividades.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label14.Location = new System.Drawing.Point(592, 289);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 41);
            this.label14.TabIndex = 47;
            this.label14.Text = "Fecha de Inicio de Actividades: ";
            // 
            // txtEstadoContribuyente
            // 
            this.txtEstadoContribuyente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstadoContribuyente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoContribuyente.Location = new System.Drawing.Point(220, 353);
            this.txtEstadoContribuyente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstadoContribuyente.MaxLength = 11;
            this.txtEstadoContribuyente.Name = "txtEstadoContribuyente";
            this.txtEstadoContribuyente.ReadOnly = true;
            this.txtEstadoContribuyente.Size = new System.Drawing.Size(244, 26);
            this.txtEstadoContribuyente.TabIndex = 7;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensaje.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMensaje.Location = new System.Drawing.Point(35, 135);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(1003, 18);
            this.lblMensaje.TabIndex = 48;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmConsultaRUCSUNAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 875);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtEstadoContribuyente);
            this.Controls.Add(this.txtFechaInicioActividades);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPadrones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDomicilioFiscal);
            this.Controls.Add(this.txtSistemaEmisionComprobante);
            this.Controls.Add(this.txtActividadesEconomicas);
            this.Controls.Add(this.txtAfiliadoPLE);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCondicionContribuyente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFechaInscripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTipoContribuyente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComprobantesPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroRUC);
            this.Controls.Add(this.btnConsultarRUCMedianteNumeroRandom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConsultaRUCSUNAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de número de RUC ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroRUC;
        private System.Windows.Forms.Button btnConsultarRUCMedianteNumeroRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComprobantesPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtTipoContribuyente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaInscripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCondicionContribuyente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAfiliadoPLE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtActividadesEconomicas;
        private System.Windows.Forms.TextBox txtSistemaEmisionComprobante;
        private System.Windows.Forms.TextBox txtDomicilioFiscal;
        private System.Windows.Forms.TextBox txtPadrones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFechaInicioActividades;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEstadoContribuyente;
        private System.Windows.Forms.Label lblMensaje;
    }
}

