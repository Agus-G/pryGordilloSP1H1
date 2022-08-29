using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGordilloSP1H1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmLocalidad_Click(object sender, EventArgs e)
        {
            frmLocalidad objfrmLocalidad = new frmLocalidad();
            objfrmLocalidad.ShowDialog();
        }

        private void tsmCultivo_Click(object sender, EventArgs e)
        {
            frmCultivo objfrmCultivo = new frmCultivo();
            objfrmCultivo.ShowDialog();
        }

        private void tsmProduccion_Click(object sender, EventArgs e)
        {
            frmConsulta objfrmProduccion = new frmConsulta();
            objfrmProduccion.ShowDialog();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public struct Localidad
    {
        public string localidad;
        public int numero;
    }
    public struct Cultivo
    {
        public string cultivo;
        public int numero;
    }
    public struct Produccion
    {
        public string produccion;
        public string localidad;
        public string cultivo;
        public int toneladas;
    }


}
