
namespace Finanzas.Forms_Liquidez
{
    partial class RotacionCuentasxPagar
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
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPromedio = new System.Windows.Forms.TextBox();
            this.TxtComprasCredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(187, 166);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.ReadOnly = true;
            this.TxtDias.Size = new System.Drawing.Size(177, 20);
            this.TxtDias.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Días: ";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(187, 135);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(177, 20);
            this.TxtResultado.TabIndex = 39;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(144, 95);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 38;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Resultado: ";
            // 
            // TxtPromedio
            // 
            this.TxtPromedio.Location = new System.Drawing.Point(187, 56);
            this.TxtPromedio.Name = "TxtPromedio";
            this.TxtPromedio.Size = new System.Drawing.Size(182, 20);
            this.TxtPromedio.TabIndex = 36;
            // 
            // TxtComprasCredito
            // 
            this.TxtComprasCredito.Location = new System.Drawing.Point(187, 17);
            this.TxtComprasCredito.Name = "TxtComprasCredito";
            this.TxtComprasCredito.Size = new System.Drawing.Size(182, 20);
            this.TxtComprasCredito.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Promedio Cuentas por Pagar: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Compras al Crédito: ";
            // 
            // RotacionCuentasxPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 203);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPromedio);
            this.Controls.Add(this.TxtComprasCredito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RotacionCuentasxPagar";
            this.Text = "Rotación de Cuentas por Pagar a C/P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPromedio;
        private System.Windows.Forms.TextBox TxtComprasCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}