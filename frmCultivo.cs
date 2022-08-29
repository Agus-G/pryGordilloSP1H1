using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryGordilloSP1H1
{
    public partial class frmCultivo : Form
    {
        public frmCultivo()
        {
            InitializeComponent();
        }

        private void cmdCargarCultivo_Click(object sender, EventArgs e)
        {
            File.Create("./NombreCultivo.txt");
            File.WriteAllText("./NombreCultivo.txt", txtCultivo.Text);
        }
    }
}
