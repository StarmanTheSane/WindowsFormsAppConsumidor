using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppConsumidor
{
    public partial class PC2023_1_InfoTrabajador_ : Form
    {
        [DllImport(@"C:\Users\Andy\source\repos\PM_U5_Eq_4\Debug\PM_U5_Eq_4.dll")]
        static extern int infoTrabajador(StringBuilder str, string nombre, int horasTrabajadas, int salarioPorHora, int bon);

        public PC2023_1_InfoTrabajador_()
        {
            InitializeComponent();
        }


        private void PC2023_1_InfoTrabajador__Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
