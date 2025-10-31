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
    public partial class frmActividades : Form
    {
        public frmActividades()
        {
            InitializeComponent();
        }

        private void frmActividades_Load(object sender, EventArgs e)
        {

        }

        private void gunaBtnAceptar_Click(object sender, EventArgs e)
        {
            clsConeccionBD clsConeccionBD = new clsConeccionBD();
            try
            {
                DateTime fechaSeleccionada = gunaDtpFecha.Value.Date.AddHours(12);

                if (fechaSeleccionada <= DateTime.Now)
                {
                    MessageBox.Show("La fecha debe ser futura.");
                    return;
                }
                clsConeccionBD.agregarActividad(gunaTxtActividad.Text, fechaSeleccionada.ToString("yyyy/MM/dd HH:mm:ss"), gunaTxtObservacion.Text);
                gunaTxtActividad.Clear();
                gunaTxtObservacion.Clear();
            }
            catch
            {
                MessageBox.Show("Datos erróneos o no ingresados.");
            }
        }

        private void gunaBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
