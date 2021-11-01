
namespace Finanzas.Forms_Rentabilidad
{
    partial class RendimientoCapitalComun
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
            this.TxtDividendosPreferentes = new System.Windows.Forms.TextBox();
            this.TxtUDI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCapitalPreferente = new System.Windows.Forms.TextBox();
            this.TxtCapitalContable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDividendosPreferentes
            // 
            this.TxtDividendosPreferentes.Location = new System.Drawing.Point(141, 58);
            this.TxtDividendosPreferentes.Name = "TxtDividendosPreferentes";
            this.TxtDividendosPreferentes.Size = new System.Drawing.Size(182, 20);
            this.TxtDividendosPreferentes.TabIndex = 46;
            // 
            // TxtUDI
            // 
            this.TxtUDI.Location = new System.Drawing.Point(141, 19);
            this.TxtUDI.Name = "TxtUDI";
            this.TxtUDI.Size = new System.Drawing.Size(182, 20);
            this.TxtUDI.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Dividendos Preferentes: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "UDI: ";
            // 
            // TxtCapitalPreferente
            // 
            this.TxtCapitalPreferente.Location = new System.Drawing.Point(141, 131);
            this.TxtCapitalPreferente.Name = "TxtCapitalPreferente";
            this.TxtCapitalPreferente.Size = new System.Drawing.Size(182, 20);
            this.TxtCapitalPreferente.TabIndex = 50;
            // 
            // TxtCapitalContable
            // 
            this.TxtCapitalContable.Location = new System.Drawing.Point(140, 92);
            this.TxtCapitalContable.Name = "TxtCapitalContable";
            this.TxtCapitalContable.Size = new System.Drawing.Size(182, 20);
            this.TxtCapitalContable.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Capital Preferente: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Capital Contable: ";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(140, 210);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(177, 20);
            this.TxtResultado.TabIndex = 53;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(124, 170);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 52;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Resultado: ";
            // 
            // RendimientoCapitalComun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 242);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCapitalPreferente);
            this.Controls.Add(this.TxtCapitalContable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDividendosPreferentes);
            this.Controls.Add(this.TxtUDI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RendimientoCapitalComun";
            this.Text = "Rendimiento de Capital Común";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDividendosPreferentes;
        private System.Windows.Forms.TextBox TxtUDI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCapitalPreferente;
        private System.Windows.Forms.TextBox TxtCapitalContable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label5;
    }
}