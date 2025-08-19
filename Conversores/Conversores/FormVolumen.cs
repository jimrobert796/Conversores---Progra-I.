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
    public partial class FormVolumen : Form
    {
        public FormVolumen()
        {
            InitializeComponent();
        }

        private double[][] conversiones = new double[][]
       {
            // 0 Litro a
            new double[] {
                1,          // Litro
                1000,       // Mililitro
                0.001,      // Metro cúbico
                1000,       // Centímetro cúbico
                0.264172,   // Galón estadounidense
                0.219969,   // Galón imperial
                33.814,     // Onza líquida
                2.11338,    // Pinta
                1.05669,    // Cuarto
                0.00628981  // Barril
            },
            // 1 Mililitro a
            new double[] {
                0.001,      // Litro
                1,          // Mililitro
                0.000001,   // Metro cúbico
                1,          // Centímetro cúbico
                0.000264172,// Galón estadounidense
                0.000219969,// Galón imperial
                0.033814,   // Onza líquida
                0.00211338, // Pinta
                0.00105669, // Cuarto
                0.00000628981 // Barril
            },
            // 2 Metro cúbico a
            new double[] {
                1000,       // Litro
                1000000,    // Mililitro
                1,          // Metro cúbico
                1000000,    // Centímetro cúbico
                264.172,    // Galón estadounidense
                219.969,    // Galón imperial
                33814,      // Onza líquida
                2113.38,    // Pinta
                1056.69,    // Cuarto
                6.28981     // Barril
            },
            // 3 Centímetro cúbico a
            new double[] {
                0.001,      // Litro
                1,          // Mililitro
                0.000001,   // Metro cúbico
                1,          // Centímetro cúbico
                0.000264172,// Galón estadounidense
                0.000219969,// Galón imperial
                0.033814,   // Onza líquida
                0.00211338, // Pinta
                0.00105669, // Cuarto
                0.00000628981 // Barril
            },
            // 4 Galón estadounidense a
            new double[] {
                3.78541,    // Litro
                3785.41,    // Mililitro
                0.00378541, // Metro cúbico
                3785.41,     // Centímetro cúbico
                1,          // Galón estadounidense
                0.832674,   // Galón imperial
                128,        // Onza líquida
                8,          // Pinta
                4,          // Cuarto
                0.0238095   // Barril
            },
            // 5 Galón imperial a
            new double[] {
                4.54609,    // Litro
                4546.09,    // Mililitro
                0.00454609, // Metro cúbico
                4546.09,    // Centímetro cúbico
                1.20095,    // Galón estadounidense
                1,          // Galón imperial
                153.722,    // Onza líquida
                9.6076,     // Pinta
                4.8038,     // Cuarto
                0.028594    // Barril
            },
            // 6 Onza líquida a
            new double[] {
                0.0295735,  // Litro
                29.5735,    // Mililitro
                0.0000295735, // Metro cúbico
                29.5735,     // Centímetro cúbico
                0.0078125,  // Galón estadounidense
                0.00650527, // Galón imperial
                1,          // Onza líquida
                0.0625,     // Pinta
                0.03125,    // Cuarto
                0.000186012 // Barril
            },
            // 7 Pinta a
            new double[] {
                0.473176,   // Litro
                473.176,    // Mililitro
                0.000473176, // Metro cúbico
                473.176,    // Centímetro cúbico
                0.125,      // Galón estadounidense
                0.104084,   // Galón imperial
                16,         // Onza líquida
                1,          // Pinta
                0.5,        // Cuarto
                0.00297619  // Barril
            },
            // 8 Cuarto a
            new double[] {
                0.946353,   // Litro
                946.353,    // Mililitro
                0.000946353, // Metro cúbico
                946.353,    // Centímetro cúbico
                0.25,       // Galón estadounidense
                0.208168,   // Galón imperial
                32,         // Onza líquida
                2,          // Pinta
                1,          // Cuarto
                0.00595238  // Barril
            },
            // 9 Barril a
            new double[] {
                158.987,    // Litro
                158987,     // Mililitro
                0.158987,   // Metro cúbico
                158987,     // Centímetro cúbico
                42,         // Galón estadounidense
                34.9723,    // Galón imperial
                5376,       // Onza líquida
                336,        // Pinta
                168,        // Cuarto
                1           // Barril
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
                    lblLitro.Text = "Litros = " + Math.Round(cantidad * conversiones[i][0], 6) + " L";
                    lblMililitro.Text = "Mililitros = " + Math.Round(cantidad * conversiones[i][1], 6) + " mL";
                    lblMetro_cubico.Text = "Metros cúbicos = " + Math.Round(cantidad * conversiones[i][2], 6) + " m³";
                    lblCentimetro_cubico.Text = "Centímetros cúbicos = " + Math.Round(cantidad * conversiones[i][3], 6) + " cm³";
                    lblGalon_EEUU.Text = "Galones estadounidenses = " + Math.Round(cantidad * conversiones[i][4], 6) + " gal US";
                    lblGalon_UK.Text = "Galones imperiales = " + Math.Round(cantidad * conversiones[i][5], 6) + " gal UK";
                    lblOnza_liquida.Text = "Onzas líquidas = " + Math.Round(cantidad * conversiones[i][6], 6) + " fl oz";
                    lblPinta.Text = "Pintas = " + Math.Round(cantidad * conversiones[i][7], 6) + " pt";
                    lblCuarto.Text = "Cuartos = " + Math.Round(cantidad * conversiones[i][8], 6) + " qt";
                    lblBarril.Text = "Barriles = " + Math.Round(cantidad * conversiones[i][9], 6) + " bbl";
                }
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
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
                case 0: // Litro
                    conver(cantidad, origen);
                    break;
                case 1: // Mililitro
                    conver(cantidad, origen);
                    break;
                case 2: // Metro cúbico
                    conver(cantidad, origen);
                    break;
                case 3: // Centímetro cúbico
                    conver(cantidad, origen);
                    break;
                case 4: // Galón estadounidense
                    conver(cantidad, origen);
                    break;
                case 5: // Galón imperial
                    conver(cantidad, origen);
                    break;
                case 6: // Onza líquida
                    conver(cantidad, origen);
                    break;
                case 7: // Pinta
                    conver(cantidad, origen);
                    break;
                case 8: // Cuarto
                    conver(cantidad, origen);
                    break;
                case 9: // Barril
                    conver(cantidad, origen);
                    break;

            }
        }

        private void lblOrigen_Click(object sender, EventArgs e)
        {

        }
    }
}
