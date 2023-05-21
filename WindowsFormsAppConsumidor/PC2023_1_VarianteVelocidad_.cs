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
    public partial class PC2023_1_VarianteVelocidad_ : Form
    {
        [DllImport(@"C:\Users\Andy\source\repos\PM_U5_Eq_4\Debug\PM_U5_Eq_4.dll")]

        static extern int velocidad(StringBuilder strRes, string str, int distancia, int tiempo);

        public PC2023_1_VarianteVelocidad_()
        {
            InitializeComponent();
        }

        StringBuilder sb;
        private void PC2023_1_VarianteVelocidad__Load(object sender, EventArgs e)
        {
            sb = new StringBuilder(100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sb.Clear();
            int largo = velocidad(sb, "Coche azul", 120, 2);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
        }
    }
}
