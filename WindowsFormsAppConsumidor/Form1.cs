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
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Users\Andy\source\repos\PM_U5_Eq_4\Debug\PM_U5_Eq_4.dll")]
        static extern int largo_cadena(string str);

        [DllImport(@"C:\Users\Andy\source\repos\PM_U5_Eq_4\Debug\PM_U5_Eq_4.dll")]
        static extern int escribir_cadena(StringBuilder str, int len_buffer);

        [DllImport(@"C:\Users\Andy\source\repos\PM_U5_Eq_4\Debug\PM_U5_Eq_4.dll")]
        static extern int promedioDeUsuario(StringBuilder str, string nombre, int cal1, int cal2, int cal3);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //EJEMPLO 1
            //int len = largo_cadena("JUAN@@@@@CARLOS");
            //MessageBox.Show("Largo: " + len);

            //EJEMPLO 2
            //try
            //{
            //  StringBuilder sb = new StringBuilder(20);
            //  int largo = escribir_cadena(sb, sb.Capacity);
            //string c = sb.ToString();
            //c = c.Substring(0, largo);
            //MessageBox.Show(c);

            // }
            //catch (Exception ex)
            //{
            //MessageBox.Show(ex.ToString());
            //}
            //this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
