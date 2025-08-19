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
    public partial class FormConverTiemp : Form
    {
        public FormConverTiemp()
        {
            InitializeComponent();
        }

        // Matriz de conversiones de tiempo 
        private double[][] conversiones_tiempo = new double[][]
        {
            // 0 Años a
            new double[] {
                1, // años
                12, // meses
                52.17857, // semanas
                365.25, // Dias
                8766, // Horas
                525960, // minutos
                31557600, // segundos 
                31557600000, // milisegundos
                3.15576e13, // microsegundos
                3.15576e16 // nanosegundos
            },
            // 1 meses a
            new double []  {
                0.08333333, // años
                1, // meses
                4.34821417, // semanas
                30.41675, // dias
                730.5, // horas
                43830, // minutos
                2629800, // Segundos
                2629800000, // milisegundos
                2.6298e12, // microsegundos
                2.6298e15  // nanosegundos

            },

            // 2 semanas a
            new double []{
                0.01916496, // años
                0.22997947, // meses
                1, // semanas
                7.00000019, // dias
                168.0000046, // horas
                1.00800003e4 ,// minutos
                6.04800017e5, // segundos
                6.04800017e8, // milisegundos 
                6.04800017e11, // microsegundos
                6.04800017e14, // nanosegundos

            },
            // FALTA ESTEEEEE OOOOHHHH
            // 3  dias a
            new double []{
                0.00273785, // años
                0.03285421, // meses
                0.14285714, // semanas
                1, // dias
                24, // horas
                1440 ,// minutos
                86400, // segundos 
                86400000, // mlisegundos
                86400000000, // microsegundos
                8.64e13, // nanosegundos

            },

            // 4 horas a
            new double []{
                0.00011408, // años
                0.00136893, // meses
                0.00595238, //semanas
                0.04166667, // dias
                1, // horas
                60 ,// minutos
                3600, // segundos
                3600000, // milisegundos
                3600000000, // microsegundos
                3.6e+12, // nanosegundos

            },

            // 5 minutos a
            new double []{
                0.0000019, // años
                0.00002282, // meses
                0.00009921, // semanas
                0.00069444, // Dias
                0.01666667, // horas
                1, // minutos
                60 ,// segundos
                60000, // milisegundos
                60000000, // microsegundos 
                60000000000, // nanosegundos
            },

            // 6 Segundos a
            new double []{
                3.16880878e-8, // años
                3.80257054e-7, // meses
                0.00000165, // semanas
                0.00001157, // dias
                0.00027778, // horas
                0.01666667 ,// minutos
                1, // segundos 
                1000, // milisegundos
                1000000, // microsegundos
               1000000000, // nanosegundos

            },
            // 7 milisegundos a
            new double []{
                3.16880878e-11, // años
                3.80257054e-10, // meses
                1.65343911e-9, // semanas
                1.15740741e-8, // dias
                2.77777778e-7, // horas
                0.00001667,// minutos
                0.001, // segundos
                1, // milisegundos
                1000, // microsegundos
                1000000, // nanosegundos
            },

            // 8 microsegundos a
            new double []{
                3.16880878e-14, // años
                3.80257054e-13, // meses
                1.65343911e-12, // semanas
                1.15740741e-11, // dias
                2.77777778e-10, // horas
                1.66666667e-8 ,// minutos
                0.000001, // segundos
                0.001, // milisegundos
                1, // microsegundos
                1000, // nanosegundos
            },

            // 9 nanosegundo a
            new double []{
                3.16880878e-17, // años    
                3.80257054e-16, // meses
                1.65343911e-15, // semanas
                1.15740741e-14, // dias
                2.77777778e-13, // horas
                1.66666667e-11 ,// minutos
                1e-9, // segundos
                0.000001, // milisegundos
                0.001, // microsegundos
                1, // nanosegundos
            }
        };


        public void conver(double cantidad, int origen)
        {
            // Da un recorrido por la matriz de conversiones
            for (int i = 0; i <= conversiones_tiempo.Length; i++)
            {
                // Si el indice de la matriz de monedas a convertir es igual al indice de la moneda de origen seleccionada
                if (i == origen)
                {
                    // Actualiza los labels con las conversiones

                    lblAños.Text = "Años = " + cantidad * conversiones_tiempo[i][0];

                    lblMeses.Text = "Meses = " + cantidad * conversiones_tiempo[i][1];

                    lblSemanas.Text = "Semanas = " + cantidad * conversiones_tiempo[i][2];

                    lblDias.Text = "Dias = " + cantidad * conversiones_tiempo[i][3];

                    lblHoras.Text = "Horas = " + cantidad * conversiones_tiempo[i][4];

                    lblMinutos.Text= "Minutos = " + cantidad * conversiones_tiempo[i][5];

                    lblSegundos.Text = "Segundos = " + cantidad * conversiones_tiempo[i][6];

                    lblMilisegundos.Text = " Milisegundos = " + cantidad * conversiones_tiempo[i][7];

                    lblMicrosegundos.Text = "Microsegundos = " + cantidad * conversiones_tiempo[i][8];

                    lblNanosegundos.Text = "Nanosegundos = " + cantidad * conversiones_tiempo[i][9];

                }
            }
        }


        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double cantidad = 0;
            

            // Validar si se ingresa la cantidad Ing.Cordero nos enseño sobre los messageBox
            if (txtNum1.Text == "")
            {
                MessageBox.Show("Por favor, ingrese una cantidad de dinero válida.");
                return;
            }

            cantidad = double.Parse(txtNum1.Text); // Convertir el texto a un número la cantidad de tiempo
          

            // En los 10 casos posibles de monedas se llama a la funcion conver dependiendo el origen seleccionado
            if (rbAños.Checked) // años
            {
                conver(cantidad, 0);
            }
            if (rbMeses.Checked) // meses
            {
                conver(cantidad, 1);
            }
            if (rbSemanas.Checked) // semanas
            {
                conver(cantidad, 2); 
            }
            if (rbDias.Checked) // dias
            {
                conver(cantidad, 3); 
            }
            if (rbHoras.Checked) // horas
            {
                conver(cantidad, 4);
            }
            if (rbMinutos.Checked) // minutos
            {
                conver(cantidad, 5); 
            }
            if (rbSegundos.Checked) // segundos
            {
                conver(cantidad, 6);
            }
            if (rbMilisegundos.Checked) // milisegundos 
            {
                conver(cantidad, 7);
            }
            if (rbMicrosegundos.Checked) // microsegundos
            {
                conver(cantidad, 8);
            }
            if (rbNanosegundos.Checked) // nanosegundos
            {
                conver(cantidad, 9);
            }

        }

        private void FormConverTiemp_Load(object sender, EventArgs e)
        {

        }
    }

        
}
