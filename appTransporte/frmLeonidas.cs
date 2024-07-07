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
    public partial class frmLeonidas : Form
    {
        public frmLeonidas()
        {
            InitializeComponent();
        }

        private void frmLeonidas_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            LEONIDAS obLeo = new LEONIDAS();

            obLeo.Destinatario = txtCliente.Text;
            obLeo.Destino = cboDestino.Text;
            obLeo.Tm = double.Parse(txtTM.Text);

            txtTarifa.Text = obLeo.Tarifario().ToString();
            txtFlete.Text = obLeo.Flete().ToString();
            txtSeguro.Text = obLeo.Seguro().ToString();
            txtMonto.Text = obLeo.Monto().ToString();
        }
    }
}
