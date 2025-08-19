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
    public partial class FormMasa : Form
    {
        public FormMasa()
        {
            InitializeComponent();
        }


        /* Masa - 10 unidades
         * Kilogramo (kg) - unidad base
         * Gramo (g) = 0.001 kg
         * Miligramo (mg) = 0.000001 kg
         * Tonelada métrica (t) = 1000 kg
         * Libbra (lb) = 0.453592 kg
         * Onza (oz) = 0.0283495 kg
         * Stone (st) = 6.35029 kg
         * Quintal (q) = 100 kg
         * Tonelada corta (US ton) = 907.185 kg
         * Tonelada larga (UK ton) = 1016.05 kg
         */

        // Matriz de conversiones (todas las conversiones se hacen a través de kilogramos como unidad base)
        private double[][] conversiones = new double[][]
        {
            // 0 Kilogramo a
            new double[] {
                1,          // Kilogramo
                1000,       // Gramo
                1000000,    // Miligramo
                0.001,      // Tonelada métrica
                2.20462,    // Libra
                35.274,     // Onza
                0.157473,   // Stone
                0.01,       // Quintal
                0.00110231, // Tonelada corta
                0.000984207 // Tonelada larga
            },
            // 1 Gramo a
            new double[] {
                0.001,      // Kilogramo
                1,          // Gramo
                1000,       // Miligramo
                0.000001,   // Tonelada métrica
                0.00220462, // Libra
                0.035274,   // Onza
                0.000157473, // Stone
                0.00001,    // Quintal
                0.00000110231, // Tonelada corta
                0.000000984207 // Tonelada larga
            },
            // 2 Miligramo a
            new double[] {
                0.000001,   // Kilogramo
                0.001,      // Gramo
                1,          // Miligramo
                0.000000001, // Tonelada métrica
                0.00000220462, // Libra
                0.000035274, // Onza
                0.000000157473, // Stone
                0.00000001, // Quintal
                0.00000000110231, // Tonelada corta
                0.000000000984207 // Tonelada larga
            },
            // 3 Tonelada métrica a
            new double[] {
                1000,       // Kilogramo
                1000000,    // Gramo
                1000000000, // Miligramo
                1,          // Tonelada métrica
                2204.62,    // Libra
                35274,      // Onza
                157.473,    // Stone
                10,         // Quintal
                1.10231,    // Tonelada corta
                0.984207    // Tonelada larga
            },
            // 4 Libra a
            new double[] {
                0.453592,   // Kilogramo
                453.592,    // Gramo
                453592,     // Miligramo
                0.000453592, // Tonelada métrica
                1,          // Libra
                16,         // Onza
                0.0714286,  // Stone
                0.00453592, // Quintal
                0.0005,     // Tonelada corta
                0.000446429 // Tonelada larga
            },
            // 5 Onza a
            new double[] {
                0.0283495,  // Kilogramo
                28.3495,    // Gramo
                28349.5,    // Miligramo
                0.0000283495, // Tonelada métrica
                0.0625,     // Libra
                1,          // Onza
                0.00446429, // Stone
                0.000283495, // Quintal
                0.00003125, // Tonelada corta
                0.0000279018 // Tonelada larga
            },
            // 6 Stone a
            new double[] {
                6.35029,    // Kilogramo
                6350.29,    // Gramo
                6350290,    // Miligramo
                0.00635029, // Tonelada métrica
                14,         // Libra
                224,        // Onza
                1,          // Stone
                0.0635029,  // Quintal
                0.007,      // Tonelada corta
                0.00625     // Tonelada larga
            },
            // 7 Quintal a
            new double[] {
                100,        // Kilogramo
                100000,     // Gramo
                100000000,  // Miligramo
                0.1,        // Tonelada métrica
                220.462,    // Libra
                3527.4,     // Onza
                15.7473,    // Stone
                1,          // Quintal
                0.110231,   // Tonelada corta
                0.0984207   // Tonelada larga
            },
            // 8 Tonelada corta a
            new double[] {
                907.185,    // Kilogramo
                907185,     // Gramo
                907185000,  // Miligramo
                0.907185,   // Tonelada métrica
                2000,       // Libra
                32000,      // Onza
                142.857,    // Stone
                9.07185,    // Quintal
                1,          // Tonelada corta
                0.892857    // Tonelada larga
            },
            // 9 Tonelada larga a
            new double[] {
                1016.05,    // Kilogramo
                1016050,    // Gramo
                1016050000, // Miligramo
                1.01605,    // Tonelada métrica
                2240,       // Libra
                35840,      // Onza
                160,        // Stone
                10.1605,    // Quintal
                1.12,       // Tonelada corta
                1           // Tonelada larga
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
                    lblKilogramo.Text = "Kilogramos = " + Math.Round(cantidad * conversiones[i][0], 6) + " kg";

                    lblGramo.Text = "Gramos = " + Math.Round(cantidad * conversiones[i][1], 6) + " g";

                    lblMiligramo.Text = "Miligramos = " + Math.Round(cantidad * conversiones[i][2], 6) + " mg";

                    lblTonelada_metrica.Text = "Toneladas metricas = " + Math.Round(cantidad * conversiones[i][3], 6) + " t";

                    lblLibra.Text = "Libras = " + Math.Round(cantidad * conversiones[i][4], 6) + " lb";

                    lblOnza.Text = "Onzas = " + Math.Round(cantidad * conversiones[i][5], 6) + " oz";

                    lblStone.Text = "Stones = " + Math.Round(cantidad * conversiones[i][6], 6) + " st";

                    lblQuintal.Text = "Quintales = " + Math.Round(cantidad * conversiones[i][7], 6) + " q";

                    lblTonelada_Corta.Text = "Toneladas cortas = " + Math.Round(cantidad * conversiones[i][8], 6) + " US ton";

                    lblTonelada_larga.Text = "Toneladas Largas = " + Math.Round(cantidad * conversiones[i][9], 6) + " UK ton";

                }
            }
        }

        private void FormConverMasa_Load(object sender, EventArgs e)
        {
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
