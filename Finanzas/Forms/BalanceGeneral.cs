using Finanzas.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas.Forms
{
    public partial class BalanceGeneral : Form
    {
        public DatosBalanceGeneral datosBalanceGeneral { get; set; }
        string[] Rows = {"Activos", "Activos Corrientes", "Caja", "Banco", "Cliente", "Inventario", "Deudores Diversos", " ", "Activos no Circulantes", "Terreno", "Edificio", "Maquinaria", "Transporte", " ", "Otros Activos", "Inversión en Proceso", "Fondo de Amortización", " ", "Total Activos", " ", "Pasivos", "Pasivos Circulantes", "Proveedor", "Acreedores Diversos", "IVA por Pagar", "Interés por Pagar", " ", "Pasivos no Circulantes", "Acreedores Hipotecarios", "Bono por Pagar", "Acreedor Bancario", "Documento por Pagar", " ", "Patrimonio", "Capital Social", "Utilidades Retenidas", "Pérdida Acumulada", "Donación", " ", "Total Pasivos"};
        public BalanceGeneral()
        {
            InitializeComponent();
            DgvBalanceGeneral.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvBalanceGeneral.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacion(out double Caja, out double Banco, out double Cliente, out double Inventario, out double DeudoresDiversos, out double Terreno, out double Edificio, out double Maquinaria, out double Transporte, out double InversionProceso, out double FondoAmortizacion, out double Proveedor, out double AcreedorDiverso, out double IVAxPagar, out double InteresxPagar, out double AcreedorHipotecario, out double BonoxPagar, out double AcreedorBancario, out double DocumentoxPagar, out double CapitalSocial, out double UtilidadesRetenidas, out double PerdidaAcumulada, out double Donacion);
                double Activos_Corrientes = Caja + Banco + Cliente + Inventario + DeudoresDiversos;
                double Activos_NoCorrientes = Terreno + Edificio + Maquinaria + Transporte;
                double Otros_Activos = InversionProceso + FondoAmortizacion;
                double TotalActivos = Activos_Corrientes + Activos_NoCorrientes + Otros_Activos;
                double Pasivos_Corrientes = Proveedor + AcreedorDiverso + IVAxPagar + InteresxPagar;
                double Pasivos_NoCorrientes = AcreedorHipotecario + BonoxPagar + AcreedorBancario + DocumentoxPagar;
                double Patrimonio = CapitalSocial + UtilidadesRetenidas + PerdidaAcumulada + Donacion;
                double TotalPasivos = Pasivos_Corrientes + Pasivos_NoCorrientes + Patrimonio;

                if (TotalActivos == TotalPasivos)
                {
                    datosBalanceGeneral = new DatosBalanceGeneral()
                    {
                        Caja = Caja,
                        Banco = Banco,
                        Cliente = Cliente,
                        Inventario = Inventario,
                        DeudoresDiversos = DeudoresDiversos,
                        Activos_Corrientes = Activos_Corrientes,
                        Terreno = Terreno,
                        Edificio = Edificio,
                        Maquinaria = Maquinaria,
                        Transporte = Transporte,
                        Activos_NoCorrientes = Activos_NoCorrientes,
                        InversionProceso = InversionProceso,
                        FondoAmortizacion = FondoAmortizacion,
                        Otros_Activos = Otros_Activos,
                        Total_Activos = TotalActivos,
                        Proveedor = Proveedor,
                        AcreedorDiverso = AcreedorDiverso,
                        IVAxPagar = IVAxPagar,
                        InteresxPagar = InteresxPagar,
                        Pasivos_Corrientes = Pasivos_Corrientes,
                        AcreedorHipotecario = AcreedorHipotecario,
                        BonoxPagar = BonoxPagar,
                        AcreedorBancario = AcreedorBancario,
                        DocumentoxPagar = DocumentoxPagar,
                        Pasivos_NoCorrientes = Pasivos_NoCorrientes,
                        CapitalSocial = CapitalSocial,
                        UtilidadesRetenidas = UtilidadesRetenidas,
                        PerdidaAcumulada = PerdidaAcumulada,
                        Donacion = Donacion,
                        Patrimonio = Patrimonio,
                        Total_Pasivos = TotalPasivos,
                    };

                    MessageBox.Show("Se ha guardado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe de tener un error en los datos establecidos!", "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Validacion(out double Caja, out double Banco, out double Cliente, out double Inventario, out double DeudoresDiversos, out double Terreno, out double Edificio, out double Maquinaria, out double Transporte, out double InversionProceso, out double FondoAmortizacion, out double Proveedor, out double AcreedorDiverso, out double IVAxPagar, out double InteresxPagar, out double AcreedorHipotecario, out double BonoxPagar, out double AcreedorBancario, out double DocumentoxPagar, out double CapitalSocial, out double UtilidadesRetenidas, out double PerdidaAcumulada, out double Donacion)
        {
            if (!Double.TryParse(TxtCaja.Text, out double C) || String.IsNullOrEmpty(TxtCaja.Text))
            {
                throw new ArgumentException("El valor de caja no es válido");
            }
            Caja = C;
            if (!Double.TryParse(TxtBanco.Text, out double B) || String.IsNullOrEmpty(TxtBanco.Text))
            {
                throw new ArgumentException("El valor de banco no es válido");
            }
            Banco = B;
            if (!Double.TryParse(TxtCliente.Text, out double Cl) || String.IsNullOrEmpty(TxtCliente.Text))
            {
                throw new ArgumentException("El valor de banco no es válido");
            }
            Cliente = Cl;
            if (!Double.TryParse(TxtInventario.Text, out double I) || String.IsNullOrEmpty(TxtInventario.Text))
            {
                throw new ArgumentException("El valor de inventario no es válido");
            }
            Inventario = I;
            if (!Double.TryParse(TxtDeudoresDiversos.Text, out double D) || String.IsNullOrEmpty(TxtDeudoresDiversos.Text))
            {
                throw new ArgumentException("El valor de deudores diversos no es válido");
            }
            DeudoresDiversos = D;
            if (!Double.TryParse(TxtTerrenos.Text, out double T) || String.IsNullOrEmpty(TxtTerrenos.Text))
            {
                throw new ArgumentException("El valor de terreno no es válido");
            }
            Terreno = T;
            if (!Double.TryParse(TxtEdificio.Text, out double E) || String.IsNullOrEmpty(TxtEdificio.Text))
            {
                throw new ArgumentException("El valor de edificio no es válido");
            }
            Edificio = E;
            if (!Double.TryParse(TxtMaquinaria.Text, out double M) || String.IsNullOrEmpty(TxtMaquinaria.Text))
            {
                throw new ArgumentException("El valor de maquinaria no es válido");
            }
            Maquinaria = M;
            if (!Double.TryParse(TxtTransporte.Text, out double T2) || String.IsNullOrEmpty(TxtTransporte.Text))
            {
                throw new ArgumentException("El valor de transporte no es válido");
            }
            Transporte = T2;
            if (!Double.TryParse(TxtInversionProceso.Text, out double IP) || String.IsNullOrEmpty(TxtInversionProceso.Text))
            {
                throw new ArgumentException("El valor de inversión en proceso no es válido");
            }
            InversionProceso = IP;
            if (!Double.TryParse(TxtFondoAmortizacion.Text, out double FA) || String.IsNullOrEmpty(TxtFondoAmortizacion.Text))
            {
                throw new ArgumentException("El valor de fondo de amortización no es válido");
            }
            FondoAmortizacion = FA;
            if (!Double.TryParse(TxtProveedor.Text, out double P) || String.IsNullOrEmpty(TxtProveedor.Text))
            {
                throw new ArgumentException("El valor de proveedor no es válido");
            }
            Proveedor = P;
            if (!Double.TryParse(TxtAcreedorDiverso.Text, out double AD) || String.IsNullOrEmpty(TxtAcreedorDiverso.Text))
            {
                throw new ArgumentException("El valor de acreedor diverso no es válido");
            }
            AcreedorDiverso = AD;
            if (!Double.TryParse(TxtIVAxPagar.Text, out double IVAP) || String.IsNullOrEmpty(TxtIVAxPagar.Text))
            {
                throw new ArgumentException("El valor de IVA por pagar no es válido");
            }
            IVAxPagar = IVAP;
            if (!Double.TryParse(TxtInteresxPagar.Text, out double InP) || String.IsNullOrEmpty(TxtInteresxPagar.Text))
            {
                throw new ArgumentException("El valor de interés por pagar no es válido");
            }
            InteresxPagar = InP;
            if (!Double.TryParse(TxtAcreedorHipotecario.Text, out double AH) || String.IsNullOrEmpty(TxtAcreedorHipotecario.Text))
            {
                throw new ArgumentException("El valor de acreedor hipotecario no es válido");
            }
            AcreedorHipotecario = AH;
            if (!Double.TryParse(TxtBonoxPagar.Text, out double BP) || String.IsNullOrEmpty(TxtBonoxPagar.Text))
            {
                throw new ArgumentException("El valor de bono por pagar no es válido");
            }
            BonoxPagar = BP;
            if (!Double.TryParse(TxtAcreedorBancario.Text, out double AC) || String.IsNullOrEmpty(TxtAcreedorBancario.Text))
            {
                throw new ArgumentException("El valor de acreedor bancario no es válido");
            }
            AcreedorBancario = AC;
            if (!Double.TryParse(TxtDocumentoxPagar.Text, out double DP) || String.IsNullOrEmpty(TxtDocumentoxPagar.Text))
            {
                throw new ArgumentException("El valor de documento por pagar no es válido");
            }
            DocumentoxPagar = DP;
            if (!Double.TryParse(TxtCapitalSocial.Text, out double CS) || String.IsNullOrEmpty(TxtCapitalSocial.Text))
            {
                throw new ArgumentException("El valor de capital social no es válido");
            }
            CapitalSocial = CS;
            if (!Double.TryParse(TxtUtilidadesRetenidas.Text, out double UR) || String.IsNullOrEmpty(TxtUtilidadesRetenidas.Text))
            {
                throw new ArgumentException("El valor de utilidades retenidas no es válido");
            }
            UtilidadesRetenidas = UR;
            if (!Double.TryParse(TxtPerdidaAcumulada.Text, out double PA) || String.IsNullOrEmpty(TxtPerdidaAcumulada.Text))
            {
                throw new ArgumentException("El valor de pérdida acumulada no es válido");
            }
            PerdidaAcumulada = PA;
            if (!Double.TryParse(TxtDonacion.Text, out double Do) || String.IsNullOrEmpty(TxtDonacion.Text))
            {
                throw new ArgumentException("El valor de donación no es válido");
            }
            Donacion = Do;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (datosBalanceGeneral.Caja == 0)
            {
                MessageBox.Show("Debes guardar los datos antes de mostrar el balance general!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DgvBalanceGeneral.Rows[2].Cells[2].Value = datosBalanceGeneral.Caja.ToString();
                DgvBalanceGeneral.Rows[3].Cells[2].Value = datosBalanceGeneral.Banco.ToString();
                DgvBalanceGeneral.Rows[4].Cells[2].Value = datosBalanceGeneral.Cliente.ToString();
                DgvBalanceGeneral.Rows[5].Cells[2].Value = datosBalanceGeneral.Inventario.ToString();
                DgvBalanceGeneral.Rows[6].Cells[2].Value = datosBalanceGeneral.DeudoresDiversos.ToString();
                DgvBalanceGeneral.Rows[6].Cells[3].Value = datosBalanceGeneral.Activos_Corrientes.ToString();
                DgvBalanceGeneral.Rows[9].Cells[2].Value = datosBalanceGeneral.Terreno.ToString();
                DgvBalanceGeneral.Rows[10].Cells[2].Value = datosBalanceGeneral.Edificio.ToString();
                DgvBalanceGeneral.Rows[11].Cells[2].Value = datosBalanceGeneral.Maquinaria.ToString();
                DgvBalanceGeneral.Rows[12].Cells[2].Value = datosBalanceGeneral.Transporte.ToString();
                DgvBalanceGeneral.Rows[12].Cells[3].Value = datosBalanceGeneral.Activos_NoCorrientes.ToString();
                DgvBalanceGeneral.Rows[15].Cells[2].Value = datosBalanceGeneral.InversionProceso.ToString();
                DgvBalanceGeneral.Rows[16].Cells[2].Value = datosBalanceGeneral.FondoAmortizacion.ToString();
                DgvBalanceGeneral.Rows[16].Cells[3].Value = datosBalanceGeneral.Otros_Activos.ToString();
                DgvBalanceGeneral.Rows[18].Cells[4].Value = datosBalanceGeneral.Total_Activos.ToString();
                DgvBalanceGeneral.Rows[22].Cells[2].Value = datosBalanceGeneral.Proveedor.ToString();
                DgvBalanceGeneral.Rows[23].Cells[2].Value = datosBalanceGeneral.AcreedorDiverso.ToString();
                DgvBalanceGeneral.Rows[24].Cells[2].Value = datosBalanceGeneral.IVAxPagar.ToString();
                DgvBalanceGeneral.Rows[25].Cells[2].Value = datosBalanceGeneral.InteresxPagar.ToString();
                DgvBalanceGeneral.Rows[25].Cells[3].Value = datosBalanceGeneral.Pasivos_Corrientes.ToString();
                DgvBalanceGeneral.Rows[28].Cells[2].Value = datosBalanceGeneral.AcreedorHipotecario.ToString();
                DgvBalanceGeneral.Rows[29].Cells[2].Value = datosBalanceGeneral.BonoxPagar.ToString();
                DgvBalanceGeneral.Rows[30].Cells[2].Value = datosBalanceGeneral.AcreedorBancario.ToString();
                DgvBalanceGeneral.Rows[31].Cells[2].Value = datosBalanceGeneral.DocumentoxPagar.ToString();
                DgvBalanceGeneral.Rows[31].Cells[3].Value = datosBalanceGeneral.Pasivos_NoCorrientes.ToString();
                DgvBalanceGeneral.Rows[34].Cells[2].Value = datosBalanceGeneral.CapitalSocial.ToString();
                DgvBalanceGeneral.Rows[35].Cells[2].Value = datosBalanceGeneral.UtilidadesRetenidas.ToString();
                DgvBalanceGeneral.Rows[36].Cells[2].Value = datosBalanceGeneral.PerdidaAcumulada.ToString();
                DgvBalanceGeneral.Rows[37].Cells[2].Value = datosBalanceGeneral.Donacion.ToString();
                DgvBalanceGeneral.Rows[37].Cells[3].Value = datosBalanceGeneral.Patrimonio.ToString();
                DgvBalanceGeneral.Rows[39].Cells[4].Value = datosBalanceGeneral.Total_Pasivos.ToString();
            }
        }

        private void BalanceGeneral_Resize(object sender, EventArgs e)
        {
            int Ancho = (DgvBalanceGeneral.Width - 100) / 5;
            for (int i = 0; i < DgvBalanceGeneral.Columns.Count; i++)
            {
                DgvBalanceGeneral.Columns[i].Width = Ancho;
            }
        }

        private void BalanceGeneral_Load(object sender, EventArgs e)
        {
            DgvBalanceGeneral.Columns.Add("", "Cuenta");
            DgvBalanceGeneral.Columns.Add("", "A");
            DgvBalanceGeneral.Columns.Add("", "B");
            DgvBalanceGeneral.Columns.Add("", "C");
            DgvBalanceGeneral.Columns.Add("", "D");

            for (int i = 0; i < Rows.Length; i++)
            {
                DgvBalanceGeneral.Rows.Add(Rows[i]);
            }
        }
    }
}