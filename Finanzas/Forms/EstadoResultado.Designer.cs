
namespace Finanzas.Forms
{
    partial class EstadoResultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvEstadoResultado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPagosImpuestos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCostoVentas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtVentas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtServiciosBasicos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSueldosAgentes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRentaAlmacen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtPapeleriaUtilesOficina = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSueldoPersonalOficinas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtRentaOficinas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtInteresesPagados = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstadoResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvEstadoResultado
            // 
            this.DgvEstadoResultado.AllowUserToAddRows = false;
            this.DgvEstadoResultado.AllowUserToDeleteRows = false;
            this.DgvEstadoResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvEstadoResultado.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DgvEstadoResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstadoResultado.Location = new System.Drawing.Point(476, 13);
            this.DgvEstadoResultado.Name = "DgvEstadoResultado";
            this.DgvEstadoResultado.ReadOnly = true;
            this.DgvEstadoResultado.Size = new System.Drawing.Size(366, 468);
            this.DgvEstadoResultado.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TxtPagosImpuestos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtCostoVentas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtVentas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 438);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuentas";
            // 
            // TxtPagosImpuestos
            // 
            this.TxtPagosImpuestos.Location = new System.Drawing.Point(301, 48);
            this.TxtPagosImpuestos.Name = "TxtPagosImpuestos";
            this.TxtPagosImpuestos.Size = new System.Drawing.Size(100, 20);
            this.TxtPagosImpuestos.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pagos de Impuestos: ";
            // 
            // TxtCostoVentas
            // 
            this.TxtCostoVentas.Location = new System.Drawing.Point(151, 48);
            this.TxtCostoVentas.Name = "TxtCostoVentas";
            this.TxtCostoVentas.Size = new System.Drawing.Size(100, 20);
            this.TxtCostoVentas.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Costo de Ventas: ";
            // 
            // TxtVentas
            // 
            this.TxtVentas.Location = new System.Drawing.Point(13, 48);
            this.TxtVentas.Name = "TxtVentas";
            this.TxtVentas.Size = new System.Drawing.Size(100, 20);
            this.TxtVentas.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ventas: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtServiciosBasicos);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtSueldosAgentes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtRentaAlmacen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 93);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gastos de Ventas";
            // 
            // TxtServiciosBasicos
            // 
            this.TxtServiciosBasicos.Location = new System.Drawing.Point(298, 49);
            this.TxtServiciosBasicos.Name = "TxtServiciosBasicos";
            this.TxtServiciosBasicos.Size = new System.Drawing.Size(107, 20);
            this.TxtServiciosBasicos.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Servicios Básicos: ";
            // 
            // TxtSueldosAgentes
            // 
            this.TxtSueldosAgentes.Location = new System.Drawing.Point(162, 49);
            this.TxtSueldosAgentes.Name = "TxtSueldosAgentes";
            this.TxtSueldosAgentes.Size = new System.Drawing.Size(107, 20);
            this.TxtSueldosAgentes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldos de Agentes: ";
            // 
            // TxtRentaAlmacen
            // 
            this.TxtRentaAlmacen.Location = new System.Drawing.Point(17, 49);
            this.TxtRentaAlmacen.Name = "TxtRentaAlmacen";
            this.TxtRentaAlmacen.Size = new System.Drawing.Size(107, 20);
            this.TxtRentaAlmacen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Renta de Almacen: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtPapeleriaUtilesOficina);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxtSueldoPersonalOficinas);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtRentaOficinas);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(13, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 137);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gastos de Administración";
            // 
            // TxtPapeleriaUtilesOficina
            // 
            this.TxtPapeleriaUtilesOficina.Location = new System.Drawing.Point(129, 103);
            this.TxtPapeleriaUtilesOficina.Name = "TxtPapeleriaUtilesOficina";
            this.TxtPapeleriaUtilesOficina.Size = new System.Drawing.Size(138, 20);
            this.TxtPapeleriaUtilesOficina.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Papelería y Útiles de Oficina";
            // 
            // TxtSueldoPersonalOficinas
            // 
            this.TxtSueldoPersonalOficinas.Location = new System.Drawing.Point(219, 45);
            this.TxtSueldoPersonalOficinas.Name = "TxtSueldoPersonalOficinas";
            this.TxtSueldoPersonalOficinas.Size = new System.Drawing.Size(154, 20);
            this.TxtSueldoPersonalOficinas.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sueldo del Personal de Oficinas";
            // 
            // TxtRentaOficinas
            // 
            this.TxtRentaOficinas.Location = new System.Drawing.Point(23, 45);
            this.TxtRentaOficinas.Name = "TxtRentaOficinas";
            this.TxtRentaOficinas.Size = new System.Drawing.Size(129, 20);
            this.TxtRentaOficinas.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Renta de Oficinas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtInteresesPagados);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(13, 334);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 85);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gastos Financieros";
            // 
            // TxtInteresesPagados
            // 
            this.TxtInteresesPagados.Location = new System.Drawing.Point(133, 47);
            this.TxtInteresesPagados.Name = "TxtInteresesPagados";
            this.TxtInteresesPagados.Size = new System.Drawing.Size(136, 20);
            this.TxtInteresesPagados.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(152, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Intereses Pagados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnMostrar);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Location = new System.Drawing.Point(123, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 2;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(17, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(109, 3);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // EstadoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvEstadoResultado);
            this.Name = "EstadoResultado";
            this.Text = "Estado de Resultado";
            this.Load += new System.EventHandler(this.EstadoResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstadoResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEstadoResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPagosImpuestos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCostoVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtServiciosBasicos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSueldosAgentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRentaAlmacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtPapeleriaUtilesOficina;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSueldoPersonalOficinas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtRentaOficinas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtInteresesPagados;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}