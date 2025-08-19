using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversores
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Iniciar las dos formas
            // aqui solo incia el 2 en este caso para su funcionalidad
            //Application.Run(new FormConverMoned());

            Application.Run(new FormMasa());
        }
    }
}
