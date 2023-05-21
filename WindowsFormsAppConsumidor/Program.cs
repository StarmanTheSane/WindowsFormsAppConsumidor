using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppConsumidor
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
            //Application.Run(new Form1());
            //Application.Run(PC2023_1_FormVector());
            //Application.Run(new PC2023_1_PromUsuario2_());
            //Application.Run(new PC2023_1_InfoTrabajador_());
            //Application.Run(new PC2023_1_VarianteVelocidad_());
            Application.Run(new PC2023_1_ComparaNumeros());
        }
    }
}
