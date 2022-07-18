using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltosVerdes
{
    public partial class CargaEquipos : Form
    {
        public CargaEquipos()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            tbEquipo.Enabled = false;
            btnContinuar.Enabled = false;
            gBjugadores.Enabled = true;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cBCamiseta.ResetText();
            tBJugador.Text = "";
        }
    }
}
