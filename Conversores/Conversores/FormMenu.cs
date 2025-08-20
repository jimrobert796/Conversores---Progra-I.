using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversores
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMonedas_Click(object sender, EventArgs e)
        {
            FormMoneda ventanaMoneda = new FormMoneda();
            ventanaMoneda.Show(); // Muestra la ventana de conversión de monedas
        }

        private void btnMasa_Click(object sender, EventArgs e)
        {
            FormMasa ventanaMasa = new FormMasa();
            ventanaMasa.Show(); // Muestra la ventana de conversión de masa
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            FormVolumen ventanaVolumen = new FormVolumen();
            ventanaVolumen.Show(); // Muestra la ventana de conversión de volumen
        }

        private void btnLongitud_Click(object sender, EventArgs e)
        {

        }

        private void btnAlmacenamiento_Click(object sender, EventArgs e)
        {
            FormAlmacenamiento ventanaAlmacenamiento = new FormAlmacenamiento();
            ventanaAlmacenamiento.Show(); // Muestra la ventana de conversión de almacenamiento
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            FormTiempo ventanaTiempo = new FormTiempo();
            ventanaTiempo.Show(); // Muestra la ventana de conversión de tiempo
        }
    }
}
