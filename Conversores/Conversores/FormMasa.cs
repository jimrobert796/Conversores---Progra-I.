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


        private double[][] conversiones = new double[][]
       {
            // 0 Miligramo (mg) a
            new double[]
            {
                1,                 // mg
                1.0/200,           // ct
                0.001,             // g
                0.0001,            // dag
                0.00001,           // hg
                3.5274e-5,         // oz
                2.20462e-6,        // lb
                1.0e-6,            // kg
                1.57473e-7,        // st
                1.0e-9             // t
            },
            // 1 Quilate (ct) a
            new double[]
            {
                200,               // mg
                1,                 // ct
                0.2,               // g
                0.02,              // dag
                0.002,             // hg
                0.00705479,        // oz
                0.000440925,       // lb
                0.0002,            // kg
                3.14995e-5,        // st
                2e-7               // t
            },
            // 2 Gramo (g) a
            new double[]
            {
                1000,              // mg
                5,                 // ct
                1,                 // g
                0.1,               // dag
                0.01,              // hg
                0.035274,          // oz
                0.00220462,        // lb
                0.001,             // kg
                0.000157473,       // st
                1.0e-6             // t
            },
            // 3 Decagramo (dag) a
            new double[]
            {
                10000,             // mg
                50,                // ct
                10,                // g
                1,                 // dag
                0.1,               // hg
                0.35274,           // oz
                0.0220462,         // lb
                0.01,              // kg
                0.00157473,        // st
                1e-5               // t
            },
            // 4 Hectogramo (hg) a
            new double[]
            {
                100000,            // mg
                500,               // ct
                100,               // g
                10,                // dag
                1,                 // hg
                3.5274,            // oz
                0.220462,          // lb
                0.1,               // kg
                0.0157473,         // st
                0.0001             // t
            },
            // 5 Onza (oz) a
            new double[]
            {
                28349.5,           // mg
                141.748,           // ct
                28.3495,           // g
                2.83495,           // dag
                0.283495,          // hg
                1,                 // oz
                0.0625,            // lb
                0.0283495,         // kg
                0.00446429,        // st
                2.83495e-5         // t
            },
            // 6 Libra (lb) a
            new double[]
            {
                453592,            // mg
                2267.96,           // ct
                453.592,           // g
                45.3592,           // dag
                4.53592,           // hg
                16,                // oz
                1,                 // lb
                0.453592,          // kg
                0.0714286,         // st
                0.000453592        // t
            },
            // 7 Kilogramo (kg) a
            new double[]
            {
                1000000,           // mg
                5000,              // ct
                1000,              // g
                100,               // dag
                10,                // hg
                35.274,            // oz
                2.20462,           // lb
                1,                 // kg
                0.157473,          // st
                0.001              // t
            },
            // 8 Stone (st) a
            new double[]
            {
                6350290,           // mg
                31751.5,           // ct
                6350.29,           // g
                635.029,           // dag
                63.5029,           // hg
                224,               // oz
                14,                // lb
                6.35029,           // kg
                1,                 // st
                0.00635029         // t
            },
            // 9 Tonelada Métrica (t) a
            new double[]
            {
                1e9,               // mg
                5e6,               // ct
                1e6,               // g
                100000,            // dag
                10000,             // hg
                35274,             // oz
                2204.62,           // lb
                1000,              // kg
                157.473,           // st
                1                  // t
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
                        lblMiligramo.Text = "Miligramo = " + resultado + " mg";
                        break;
                    case 1:
                        lblQuilate.Text = "Quilate = " + resultado + " ct";
                        break;
                    case 2:
                        lblGramo.Text = "Gramo = " + resultado + " g";
                        break;
                    case 3:
                        lblDecagramo.Text = "Decagramo = " + resultado + " dag";
                        break;
                    case 4:
                        lblHectogramo.Text = "Hectogramo = " + resultado + " hg";
                        break;
                    case 5:
                        lblOnza.Text = "Onza = " + resultado + " oz";
                        break;
                    case 6:
                        lblLibra.Text = "Libra = " + resultado + " lb";
                        break;
                    case 7:
                        lblKilogramo.Text = "Kilogramo = " + resultado + " kg";
                        break;
                    case 8:
                        lblStone.Text = "Stone = " + resultado + " st";
                        break;
                    case 9:
                        lblToneladaMetrica.Text = "Tonelada Métrica = " + resultado + " t";
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
                // En caso de que no se ingrese nada
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            // Verifica si lo que se ingressa es un numero
            if (!double.TryParse(txtNum1.Text, out cantidad)) 
            {
                // Si no es un numero valido
                MessageBox.Show("La cantidad ingresada no es un número válido.");
                return;
            }

            if (cboOrigen.SelectedIndex == -1) // Verifica si se selecciono una unidad de origen
            {
                MessageBox.Show("Por favor, seleccione la unidad de origen.");
                return;
            }

            conver(cantidad, origen); // Llama a la función de conversión
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close(); // Cierra la ventana de conversión de masa
        }
    }
}
