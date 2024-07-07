using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTransporte
{
    public partial class FrmIvovic : Form
    {
        public FrmIvovic()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            IVOVIC obIV = new IVOVIC();
            obIV.Destinatario = txtCliente.Text;
            obIV.Destino = cboDestino.Text;
            obIV.Tm = double.Parse(txtTM.Text);

            txtTarifa.Text = obIV.Tarifa.ToString();
            txtFlete.Text = obIV.Flete().ToString();
        }

        private void FrmIvovic_Load(object sender, EventArgs e)
        {

        }
    }
}
