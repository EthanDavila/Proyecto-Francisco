
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstadoResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEstadoResultado
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 468);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // EstadoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvEstadoResultado);
            this.Name = "EstadoResultado";
            this.Text = "Estado de Resultado";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstadoResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEstadoResultado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}