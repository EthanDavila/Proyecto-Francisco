﻿using Finanzas.Razones_Financieras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas.Forms_Endeudamiento
{
    public partial class RazonEndeudamiento : Form
    {
        Endeudamiento RE = new Endeudamiento();
        public RazonEndeudamiento()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = RE.RazonEndeudamiento(Double.Parse(TxtPasivoTotal.Text), Double.Parse(TxtActivoTotal.Text)).ToString();
        }
    }
}