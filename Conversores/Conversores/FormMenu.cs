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
            this.Hide(); // esconde la ventana actual
            FormMoneda ventanaMoneda = new FormMoneda(); // crea una nueva instancia de la ventana
            ventanaMoneda.ShowDialog(); // Muestra la ventana de conversión de monedas
            this.Show();
        }

        private void btnMasa_Click(object sender, EventArgs e)
        {
            this.Hide(); // esconde la ventana actual
            FormMasa ventanaMasa = new FormMasa(); // Crea una nueva instancia 
            ventanaMasa.ShowDialog(); // Modal para cuando se abra ventanaMasa, la ventana actual se oculta
            this.Show(); // al cerrar ventanaMasa, muestra nuevamente la ventana actual
        }
        

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            this.Hide(); // esconde la ventana actual
            FormVolumen ventanaVolumen = new FormVolumen();
            ventanaVolumen.ShowDialog(); // Muestra la ventana de conversión de volumen
            this.Show();
        }

        private void btnLongitud_Click(object sender, EventArgs e)
        {
            this.Hide(); // esconde la ventana actual
            FormLongitud ventanaLongitud = new FormLongitud();
            ventanaLongitud.ShowDialog(); // Muestra la ventana de conversión de volumen
            this.Show();
        }

        private void btnAlmacenamiento_Click(object sender, EventArgs e)
        {
            this.Hide(); // esconde la ventana actual
            FormAlmacenamiento ventanaAlmacenamiento = new FormAlmacenamiento();
            ventanaAlmacenamiento.ShowDialog(); // Muestra la ventana de conversión de almacenamiento que al cerrar
            this.Show(); // muestra nuevamente la ventana actual
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            this.Hide(); // esconde la ventana actual
            FormTiempo ventanaTiempo = new FormTiempo();
            ventanaTiempo.ShowDialog(); // Muestra la ventana de conversión de tiempo que al cerrar
            this.Show(); // muestra nuevamente la ventana actual
        }
    }
}
