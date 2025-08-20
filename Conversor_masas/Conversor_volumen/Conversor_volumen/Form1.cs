using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_volumen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /* Longitud - 10 unidades
         * Metro (m) - unidad base
         * Kilómetro (km) = 1000 m
         * Centímetro (cm) = 0.01 m
         * Milímetro (mm) = 0.001 m
         * Milla (mi) = 1609.34 m
         * Yarda (yd) = 0.9144 m
         * Pie (ft) = 0.3048 m
         * Pulgada (in) = 0.0254 m
         * Milla náutica (nmi) = 1852 m
         * Año luz (ly) = 9.461e+15 m
         */

        // Matriz de conversiones (todas las conversiones se hacen a través de metros como unidad base)
        private double[][] conversiones = new double[][]
        {
            // 0 Metro a
            new double[] {
                1,          // Metro
                0.001,      // Kilómetro
                100,        // Centímetro
                1000,       // Milímetro
                0.000621371, // Milla
                1.09361,    // Yarda
                3.28084,    // Pie
                39.3701,    // Pulgada
                0.000539957, // Milla náutica
                1.057e-16   // Año luz
            },
            // 1 Kilómetro a
            new double[] {
                1000,       // Metro
                1,          // Kilómetro
                100000,     // Centímetro
                1000000,    // Milímetro
                0.621371,   // Milla
                1093.61,    // Yarda
                3280.84,    // Pie
                39370.1,    // Pulgada
                0.539957,   // Milla náutica
                1.057e-13   // Año luz
            },
            // 2 Centímetro a
            new double[] {
                0.01,       // Metro
                0.00001,    // Kilómetro
                1,          // Centímetro
                10,         // Milímetro
                0.00000621371, // Milla
                0.0109361,  // Yarda
                0.0328084,  // Pie
                0.393701,   // Pulgada
                0.00000539957, // Milla náutica
                1.057e-18   // Año luz
            },
            // 3 Milímetro a
            new double[] {
                0.001,      // Metro
                0.000001,   // Kilómetro
                0.1,        // Centímetro
                1,          // Milímetro
                6.21371e-7, // Milla
                0.00109361, // Yarda
                0.00328084, // Pie
                0.0393701,  // Pulgada
                5.39957e-7, // Milla náutica
                1.057e-19   // Año luz
            },
            // 4 Milla a
            new double[] {
                1609.34,    // Metro
                1.60934,    // Kilómetro
                160934,     // Centímetro
                1609340,    // Milímetro
                1,          // Milla
                1760,       // Yarda
                5280,       // Pie
                63360,      // Pulgada
                0.868976,   // Milla náutica
                1.701e-13   // Año luz
            },
            // 5 Yarda a
            new double[] {
                0.9144,     // Metro
                0.0009144,  // Kilómetro
                91.44,      // Centímetro
                914.4,      // Milímetro
                0.000568182, // Milla
                1,          // Yarda
                3,          // Pie
                36,         // Pulgada
                0.000493737, // Milla náutica
                9.665e-17   // Año luz
            },
            // 6 Pie a
            new double[] {
                0.3048,     // Metro
                0.0003048,  // Kilómetro
                30.48,      // Centímetro
                304.8,      // Milímetro
                0.000189394, // Milla
                0.333333,   // Yarda
                1,          // Pie
                12,         // Pulgada
                0.000164579, // Milla náutica
                3.222e-17   // Año luz
            },
            // 7 Pulgada a
            new double[] {
                0.0254,     // Metro
                0.0000254,  // Kilómetro
                2.54,       // Centímetro
                25.4,       // Milímetro
                0.000015783, // Milla
                0.0277778,  // Yarda
                0.0833333,  // Pie
                1,          // Pulgada
                0.000013715, // Milla náutica
                2.685e-18   // Año luz
            },
            // 8 Milla náutica a
            new double[] {
                1852,       // Metro
                1.852,      // Kilómetro
                185200,     // Centímetro
                1852000,    // Milímetro
                1.15078,    // Milla
                2025.37,    // Yarda
                6076.12,    // Pie
                72913.4,    // Pulgada
                1,          // Milla náutica
                1.957e-13   // Año luz
            },
            // 9 Año luz a
            new double[] {
                9.461e+15,  // Metro
                9.461e+12,  // Kilómetro
                9.461e+17,  // Centímetro
                9.461e+18,  // Milímetro
                5.879e+12,  // Milla
                1.035e+16,  // Yarda
                3.104e+16,  // Pie
                3.725e+17,  // Pulgada
                5.108e+12,  // Milla náutica
                1           // Año luz
            }
        };

        // Función para calcular las conversiones de volumen
        public void conver(double cantidad, int origen)
        {
            // Recorrer la matriz de conversiones
            for (int i = 0; i < conversiones.Length; i++)
            {
                // Si el índice es igual al de la unidad de origen seleccionada
                if (i == origen)
                {
                    // Actualizar los labels con las conversiones
                    lblMetro.Text = "Metros = " + Math.Round(cantidad * conversiones[i][0], 6) + " m";
                    lblKilometro.Text = "Kilómetros = " + Math.Round(cantidad * conversiones[i][1], 6) + " km";
                    lblCentimetro.Text = "Centímetros = " + Math.Round(cantidad * conversiones[i][2], 6) + " cm";
                    lblMilimetro.Text = "Milímetros = " + Math.Round(cantidad * conversiones[i][3], 6) + " mm";
                    lblMilla.Text = "Millas = " + Math.Round(cantidad * conversiones[i][4], 6) + " mi";
                    lblYarda.Text = "Yardas = " + Math.Round(cantidad * conversiones[i][5], 6) + " yd";
                    lblPie.Text = "Pies = " + Math.Round(cantidad * conversiones[i][6], 6) + " ft";
                    lblPulgada.Text = "Pulgadas = " + Math.Round(cantidad * conversiones[i][7], 6) + " in";
                    lblMilla_Nautica.Text = "Millas náuticas = " + Math.Round(cantidad * conversiones[i][8], 6) + " nmi";
                    lblAnu_luz.Text = "Años luz = " + Math.Round(cantidad * conversiones[i][9], 15) + " ly";
                }
            }
        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {

            double cantidad = 0;

            int origen = cboOrigen.SelectedIndex; // Obtiene el índice de la unidad de origen seleccionada

            // Validar si se ingresa la cantidad
            if (txtNum1.Text == "")
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            cantidad = double.Parse(txtNum1.Text);

            // Mostrar mensaje de error si no se selecciona la unidad de origen
            if (cboOrigen.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione la unidad de origen");
                return;
            }

            switch (cboOrigen.SelectedIndex)
            {
                case 0: // Kilogramo
                    conver(cantidad, origen);
                    break;
                case 1: // Gramo
                    conver(cantidad, origen);
                    break;
                case 2: // Miligramo
                    conver(cantidad, origen);
                    break;
                case 3: // Tonelada métrica
                    conver(cantidad, origen);
                    break;
                case 4: // Libra
                    conver(cantidad, origen);
                    break;
                case 5: // Onza
                    conver(cantidad, origen);
                    break;
                case 6: // Stone
                    conver(cantidad, origen);
                    break;
                case 7: // Quintal
                    conver(cantidad, origen);
                    break;
                case 8: // Tonelada corta
                    conver(cantidad, origen);
                    break;
                case 9: // Tonelada larga
                    conver(cantidad, origen);
                    break;

            }
        }
    }
}   
