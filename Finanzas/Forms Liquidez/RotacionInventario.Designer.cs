
namespace Finanzas.Forms_Liquidez
{
    partial class RotacionInventario
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
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPromedioInventario = new System.Windows.Forms.TextBox();
            this.TxtCostoMercanciaVendida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMeses = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(186, 137);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(177, 20);
            this.TxtResultado.TabIndex = 21;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(143, 97);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 20;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Resultado: ";
            // 
            // TxtPromedioInventario
            // 
            this.TxtPromedioInventario.Location = new System.Drawing.Point(186, 58);
            this.TxtPromedioInventario.Name = "TxtPromedioInventario";
            this.TxtPromedioInventario.Size = new System.Drawing.Size(182, 20);
            this.TxtPromedioInventario.TabIndex = 18;
            // 
            // TxtCostoMercanciaVendida
            // 
            this.TxtCostoMercanciaVendida.Location = new System.Drawing.Point(186, 19);
            this.TxtCostoMercanciaVendida.Name = "TxtCostoMercanciaVendida";
            this.TxtCostoMercanciaVendida.Size = new System.Drawing.Size(182, 20);
            this.TxtCostoMercanciaVendida.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Promedio de Inventario: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Costo de Mercancia Vendida: ";
            // 
            // TxtMeses
            // 
            this.TxtMeses.Location = new System.Drawing.Point(186, 168);
            this.TxtMeses.Name = "TxtMeses";
            this.TxtMeses.ReadOnly = true;
            this.TxtMeses.Size = new System.Drawing.Size(177, 20);
            this.TxtMeses.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Meses: ";
            // 
            // RotacionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 203);
            this.Controls.Add(this.TxtMeses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPromedioInventario);
            this.Controls.Add(this.TxtCostoMercanciaVendida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RotacionInventario";
            this.Text = "Rotación de Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPromedioInventario;
        private System.Windows.Forms.TextBox TxtCostoMercanciaVendida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMeses;
        private System.Windows.Forms.Label label4;
    }
}