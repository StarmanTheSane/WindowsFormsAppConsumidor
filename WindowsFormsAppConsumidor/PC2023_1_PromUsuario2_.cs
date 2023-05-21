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
    public partial class PC2023_1_PromUsuario2_ : Form
    {
        [DllImport(@"C:\Users\Andy\source\repos\PM_U5_Eq_4\Debug\PM_U5_Eq_4.dll")]
        static extern int largo_cadena(string str);

        [DllImport(@"C:\Users\Andy\source\repos\PM_U5_Eq_4\Debug\PM_U5_Eq_4.dll")]
        static extern int escribir_cadena(StringBuilder str, int len_buffer);

        [DllImport(@"C:\Users\Andy\source\repos\PM_U5_Eq_4\Debug\PM_U5_Eq_4.dll")]
        static extern int promedioDeUsuario(StringBuilder str, string nombre, int cal1, int cal2, int cal3);

        public PC2023_1_PromUsuario2_()
        {
            InitializeComponent();
        }

        private void PC2023_1_PromUsuario2__Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(100);
            int largo = promedioDeUsuario(sb, "Andres", 10, 10, 10);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);
        }
    }
}
