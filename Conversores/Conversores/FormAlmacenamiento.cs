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
    public partial class FormAlmacenamiento : Form
    {
        public FormAlmacenamiento()
        {
            InitializeComponent();
        }

        private double[][] conversiones = new double[][]
        {
            // 0 Bit (b) a
            new double[]
            {
                1,                // b
                1.0 / 8,          // B
                1.0 / (8 * 1024), // KB
                1.0 / (8 * Math.Pow(1024, 2)), // MB
                1.0 / (8 * Math.Pow(1024, 3)), // GB
                1.0 / (8 * Math.Pow(1024, 4)), // TB
                1.0 / (8 * Math.Pow(1024, 5)), // PB
                1.0 / (8 * Math.Pow(1024, 6)), // EB
                1.0 / (8 * Math.Pow(1024, 7)), // ZB
                1.0 / (8 * Math.Pow(1024, 8))  // YB
            },
            // 1 Byte (B) a
            new double[]
            {
                8,                // b
                1,                // B
                1.0 / 1024,       // KB
                1.0 / Math.Pow(1024, 2), // MB
                1.0 / Math.Pow(1024, 3), // GB
                1.0 / Math.Pow(1024, 4), // TB
                1.0 / Math.Pow(1024, 5), // PB
                1.0 / Math.Pow(1024, 6), // EB
                1.0 / Math.Pow(1024, 7), // ZB
                1.0 / Math.Pow(1024, 8)  // YB
            },
            // 2 Kilobyte (KB) a
            new double[]
            {
                8 * 1024,             // b
                1024,                 // B
                1,                    // KB
                1.0 / 1024,           // MB
                1.0 / Math.Pow(1024, 2), // GB
                1.0 / Math.Pow(1024, 3), // TB
                1.0 / Math.Pow(1024, 4), // PB
                1.0 / Math.Pow(1024, 5), // EB
                1.0 / Math.Pow(1024, 6), // ZB
                1.0 / Math.Pow(1024, 7)  // YB
            },
            // 3 Megabyte (MB) a
            new double[]
            {
                8 * Math.Pow(1024, 2), // b
                Math.Pow(1024, 2), // B
                1024,             // KB
                1,                // MB
                1.0 / 1024,       // GB
                1.0 / Math.Pow(1024, 2), // TB
                1.0 / Math.Pow(1024, 3), // PB
                1.0 / Math.Pow(1024, 4), // EB
                1.0 / Math.Pow(1024, 5), // ZB
                1.0 / Math.Pow(1024, 6)  // YB
            },
            // 4 Gigabyte (GB) a
            new double[]
            {
                8 * Math.Pow(1024, 3), // b
                Math.Pow(1024, 3), // B
                Math.Pow(1024, 2), // KB
                1024,             // MB
                1,                // GB
                1.0 / 1024,       // TB
                1.0 / Math.Pow(1024, 2), // PB
                1.0 / Math.Pow(1024, 3), // EB
                1.0 / Math.Pow(1024, 4), // ZB
                1.0 / Math.Pow(1024, 5)  // YB
            },
            // 5 Terabyte (TB) a
            new double[]
            {
                8 * Math.Pow(1024, 4), // b
                Math.Pow(1024, 4), // B
                Math.Pow(1024, 3), // KB
                Math.Pow(1024, 2), // MB
                1024,             // GB
                1,                // TB
                1.0 / 1024,       // PB
                1.0 / Math.Pow(1024, 2), // EB
                1.0 / Math.Pow(1024, 3), // ZB
                1.0 / Math.Pow(1024, 4)  // YB
            },
            // 6 Petabyte (PB) a
            new double[]
            {
                8 * Math.Pow(1024, 5), // b
                Math.Pow(1024, 5), // B
                Math.Pow(1024, 4), // KB
                Math.Pow(1024, 3), // MB
                Math.Pow(1024, 2), // GB
                1024,             // TB
                1,                // PB
                1.0 / 1024,       // EB
                1.0 / Math.Pow(1024, 2), // ZB
                1.0 / Math.Pow(1024, 3)  // YB
            },
            // 7 Exabyte (EB) a
            new double[]
            {
                8 * Math.Pow(1024, 6), // b
                Math.Pow(1024, 6), // B
                Math.Pow(1024, 5), // KB
                Math.Pow(1024, 4), // MB
                Math.Pow(1024, 3), // GB
                Math.Pow(1024, 2), // TB
                1024,             // PB
                1,                // EB
                1.0 / 1024,       // ZB
                1.0 / Math.Pow(1024, 2)  // YB
            },
            // 8 Zettabyte (ZB) a
            new double[]
            {
                8 * Math.Pow(1024, 7), // b
                Math.Pow(1024, 7), // B
                Math.Pow(1024, 6), // KB
                Math.Pow(1024, 5), // MB
                Math.Pow(1024, 4), // GB
                Math.Pow(1024, 3), // TB
                Math.Pow(1024, 2), // PB
                1024,             // EB
                1,                // ZB
                1.0 / 1024        // YB
            },
            // 9 Yottabyte (YB) a
            new double[]
            {
                8 * Math.Pow(1024, 8), // b
                Math.Pow(1024, 8), // B
                Math.Pow(1024, 7), // KB
                Math.Pow(1024, 6), // MB
                Math.Pow(1024, 5), // GB
                Math.Pow(1024, 4), // TB
                Math.Pow(1024, 3), // PB
                Math.Pow(1024, 2), // EB
                1024,             // ZB
                1                 // YB
            }
        };

        // Función para calcular las conversiones
        public void conver(double cantidad, int origen)
        {
            // Da un recorrido por la matriz de conversiones
            for (int i = 0; i < conversiones[origen].Length; i++)
            {
                double resultado = cantidad * conversiones[origen][i];

                // Actualiza los labels con las conversiones usando switch para cada caso
                switch (i)
                {
                    case 0:
                        lblBit.Text = "Bit = " + resultado + " b";
                        break;
                    case 1:
                        lblByte.Text = "Byte = " + resultado + " B";
                        break;
                    case 2:
                        lblKilobyte.Text = "Kilobyte = " + resultado + " KB";
                        break;
                    case 3:
                        lblMegabyte.Text = "Megabyte = " + resultado + " MB";
                        break;
                    case 4:
                        lblGigabyte.Text = "Gigabyte = " + resultado + " GB";
                        break;
                    case 5:
                        lblTerabyte.Text = "Terabyte = " + resultado + " TB";
                        break;
                    case 6:
                        lblPetabyte.Text = "Petabyte = " + resultado + " PB";
                        break;
                    case 7:
                        lblExabyte.Text = "Exabyte = " + resultado + " EB";
                        break;
                    case 8:
                        lblZettabyte.Text = "Zettabyte = " + resultado + " ZB";
                        break;
                    case 9:
                        lblYottabyte.Text = "Yottabyte = " + resultado + " YB";
                        break;
                }
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double cantidad = 0;
            int origen = cboOrigen.SelectedIndex; // Obtiene el indice de la unidad de origen seleccionada

            if (string.IsNullOrWhiteSpace(txtNum1.Text)) // Validar si se ingresa la cantidad
            {
                // Si no se ingresa cantidad, muestra un mensaje de error
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            if (!double.TryParse(txtNum1.Text, out cantidad)) // Verifica si lo que se ingresa es numero
            {
                // Si no es un número válido, muestra un mensaje de error
                MessageBox.Show("La cantidad ingresada no es un número válido.");
                return;
            }

            if (cboOrigen.SelectedIndex == -1) // Mostrar mensaje de error si no se selecciona la unidad de origen
            {
                MessageBox.Show("Por favor, seleccione la unidad de origen.");
                return;
            }

            conver(cantidad, origen); // Llama a la función de conversión
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close(); // Cierra la ventana de conversión de almacenamiento
        }
    }
}
