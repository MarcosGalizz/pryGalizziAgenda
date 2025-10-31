using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGalizziAgenda
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            clsConeccionBD clsConeccionBD = new clsConeccionBD();
            clsConeccionBD.ConectarBD();
            clsConeccionBD.cargarDgv(gunaDgvAgenda);
        }

        private void gunaBtnAgregar_Click(object sender, EventArgs e)
        {
            frmActividades frmActividades = new frmActividades();
            frmActividades.ShowDialog();
        }

        private void gunaBtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaBtnEliminar_Click(object sender, EventArgs e)
        {
            clsConeccionBD clsConeccion = new clsConeccionBD();
            if (gunaDgvAgenda.CurrentRow != null)
            {
                string asunto = gunaDgvAgenda.CurrentRow.Cells[0].Value.ToString();
                clsConeccion.eliminarActividad(asunto);
                clsConeccion.cargarDgv(gunaDgvAgenda);
            }
        }

        private void pcbActualizar_Click(object sender, EventArgs e)
        {
            clsConeccionBD clsConeccionBD = new clsConeccionBD();
            clsConeccionBD.cargarDgv(gunaDgvAgenda);
        }
    }
}
