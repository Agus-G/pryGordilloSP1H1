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
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void cmdCargarLocalidad_Click(object sender, EventArgs e)
        {
            StreamWriter fs = new StreamWriter("./Localidad.txt", true);
            fs.WriteLine("./Localidad.txt", txtLocalidad.Text);
            fs.Close();
        }
    }
}
