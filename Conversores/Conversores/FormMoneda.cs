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
    public partial class FormConverMoned : Form
    {
        public FormConverMoned()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
                 /* Monedas 
                   Balboa (PAB)
                   Colón (CRC)
                   Córdoba (NIO)
                   Dólar canadiense (CAD)
                   Dólar estadounidense (USD)
                   Lempira (HNL)
                   Euros (EUR)
                   Soles (PEN)
                   Peso mexicano (MXN)
                   Quetzal (GTQ)
                  */

        private double[][] conversiones = new double[][]
        {
            // 0 Balboas a
            new double[] {
                1, // Balboa
                505.5433, // Colón costaricense
                36.7899, // Córdoba
                1.3831, // Dólar canadiense
                1.0004, // Dólar estadounidense
                26.4215, // Lempira
                0.8557, // Euros 
                3.5629, // Soles
                18.7587, // Peso mexicano
                7.6735 // Quetzal
            },
            // 1 colon cotaricense a
            new double []  {
                0.0020, // Balboa
                1, // colon costaricense
                0.0728, // Córdoba
                0.0027, // Dólar canadiense
                0.0020, // Dólar estadounidense
                0.0523, // Lempira
                0.0017, // Euros
                0.0071, // Soles
                0.0371, // peso mexicano
                0.0152 // Quetzal
            },

            // 2 Cordoba a
            new double []{
                0.0272, // Balboa
                13.7344, // Colón costaricense
                1, // Córdoba
                0.0376, // Dólar canadiense
                0.0272, // Dólar estadounidense
                0.7178 ,// Lempira
                0.0233, // Euros
                0.0968, // Soles 
                0.5096, // Peso mexicano
                0.2085, // Quetzal

            },
            // 3 Dólar canadiense a
            new double []{
                0.7233, // Balboa
                365.4687, // Colón costaricense
                26.5962, // Córdoba
                1, // Dólar canadiense
                0.7236, // Dólar estadounidense
                19.1007 ,// Lempira
                0.6183, // Euros 
                2.5773, // Soles
                13.5526, // Peso mexicano
                5.5473, // Quetzal

            },

            // 4 Dólar estadounidense a
            new double []{
                0.9996, // Balboa
                505.1326, // Colón costaricense
                36.7600, // Córdoba
                1.3820, // Dólar canadiense
                1, // Dólar estadounidense
                26.4000 ,// Lempira
                0.8542, // Euros
                3.5619, // Soles
                18.7435, // Peso mexicano
                7.6634, // Quetzal

            },

            // 5 lempira a
            new double []{
                0.0379, // Balboa
                19.1355, // Colón costaricense
                1.3925, // Córdoba
                0.0524, // Dólar canadiense
                0.0379, // Dólar estadounidense
                1 ,// Lempira
                0.0327, // Euros
                0.1349, // Soles
                0.7100, // Peso mexicano
                0.2905, // Quetzal
            },

            // 6 Euros a
            new double []{
                1.1686, // Balboa
                590.5000, // Colón costaricense
                43.0000, // Córdoba
                1.6171, // Dólar canadiense
                1.1706, // Dólar estadounidense
                30.5900 ,// Lempira
                1, // Euro
                4.1654, // Soles
                21.9247, // Peso mexicano
                8.9630, // Quetzal

            },
            // 6 Soles a
            new double []{
                0.2806, // Balboa
                141.8154, // Colón costaricense
                10.3203, // Córdoba
                0.3882, // Dólar canadiense
                0.2807, // Dólar estadounidense
                7.4118 ,// Lempira
                0.2402, // Euro
                1, // Soles
                5.2635, // Peso mexicano
                2.1526, // Quetzal
            },

            // 7 Peso mexicano a
            new double []{
                0.0533, // Balboa
                26.9498, // Colón costaricense
                1.9612, // Córdoba
                0.0738, // Dólar canadiense
                0.0534, // Dólar estadounidense
                1.4085 ,// Lempira
                0.0456, // Euro
                0.1902, // Soles
                1, // Peso mexicano
                0.4091, // Quetzal
            },

            // 8 Quetzal  a
            new double []{
                0.1304, // Balboa
                65.9148, // Colón costaricense
                4.7968, // Córdoba
                0.1803, // Dólar canadiense
                0.1305, // Dólar estadounidense
                3.4449 ,// Lempira
                0.1116, // Euro
                0.4645, // Soles
                2.4458, // Peso mexicano
                1.4091, // Quetzal
            }

            // OJO DATOS TOMADOS DESDE Google Finance  17/08/2025
        };

        // Funcion para calcular las conversiones de las monedas
        // No devuelve nada, solo actualiza los labels con las conversiones
        // void para no devolver nada <--- Lo descubri al probar con funciones
        public void conver(double cantidad, int origen)
        {
            // Da un recorrido por la matriz de conversiones
            for (int i = 0; i <= conversiones.Length; i++)
            {
                // Si el indice de la matriz de monedas a convertir es igual al indice de la moneda de origen seleccionada
                if (i == origen)
                {
                    // Actualiza los labels con las conversiones

                    lblBalboas.Text = "Balboa Panameño = B/." + cantidad * conversiones[i][0];

                    lblColonCostaricense.Text = "Colón costaricense = ₡" + cantidad * conversiones[i][1];

                    lblCordoba.Text = "Córdoba Nicaragüense = C$" + cantidad * conversiones[i][2];

                    lblDolarCanadiense.Text = "Dólar Canadiense = C$" + cantidad * conversiones[i][3];

                    lblDolarEstadounidense.Text = "Dólar Estadounidense = $" + cantidad * conversiones[i][4];

                    lblLempiraHondureño.Text = "Lempira Hondureño = L" + cantidad * conversiones[i][5];

                    lblEuro.Text = "Euro = €" + cantidad * conversiones[i][6];

                    lblSolPeruano.Text = "Soles Peruanos = S/." + cantidad * conversiones[i][7];

                    lblPesoMexicano.Text = "Peso Mexicano = $" + cantidad * conversiones[i][8];

                    lblQuetzal.Text = "Quetzal Guatemalteco = Q" + cantidad * conversiones[i][9];

                }
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double cantidad = 0;

            int origen = cboOrigen.SelectedIndex; // Obtiene el indice de la moneda de origen seleccionada

            // Validar si se ingresa la cantidad de dinero Ing.Cordero nos enseño sobre los messageBox
            if (txtNum1.Text == "")
            {
                MessageBox.Show("Por favor, ingrese una cantidad de dinero válida.");
                return;
            }

            cantidad = double.Parse(txtNum1.Text); // Convertir el texto a un número la cantidad de dinero

            // Mostrar mensaje de error si no se selecciona la moneda de origen
            if (cboOrigen.SelectedIndex == -1)
            {
                // Descubri que si no se seleciona retona -1 
                MessageBox.Show("Por favor selecione la moneda de origen");
                return;
            }

            // En los 10 casos posibles de monedas se llama a la funcion conver dependiendo el origen seleccionado
            switch (cboOrigen.SelectedIndex)
            {
                case 0: // Balboa
                    conver(cantidad, origen);
                    break;
                case 1: // Colón costaricense
                    conver(cantidad, origen);
                    break;
                case 2: // Córdoba
                    conver(cantidad, origen);
                    break;
                case 3: // Dólar canadiense
                    conver(cantidad, origen);
                    break;
                case 4: // Dólar estadounidense
                    conver(cantidad, origen);
                    break;
                case 5: // Lempira
                    conver(cantidad, origen);
                    break;
                case 6: // Euros
                    conver(cantidad, origen);
                    break;
                case 7: // Soles
                    conver(cantidad, origen);
                    break;
                case 8: // Peso mexicano
                    conver(cantidad, origen);
                    break;
                case 9: // Quetzal
                    conver(cantidad, origen);
                    break;

            }
        }
    }
}
