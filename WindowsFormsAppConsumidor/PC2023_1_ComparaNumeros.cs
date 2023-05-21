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
    public partial class PC2023_1_ComparaNumeros : Form
    {
        [DllImport(@"C:\Users\Andy\source\repos\PM_U5_Eq_4\Debug\PM_U5_Eq_4.dll")]

        static extern IntPtr sumaNumerosVector(StringBuilder strRes, string str, int[] auxVector1);


        public PC2023_1_ComparaNumeros()
        {
            InitializeComponent();
        }

        StringBuilder sb;
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            sb.Clear();
            int largo = comparaNumeros(sb, 50, 59, 4);
            string c = sb.ToString();
            c = c.Substring(0, largo);
            MessageBox.Show(c);*/

            sb = new StringBuilder(100);
            sb.Clear();

            int[] arregloNums = new int[6];
            arregloNums[0] = 5; //cantidad de elementos que tiene el arreglo
            arregloNums[1] = 10; // para obtener longitud de la cadena de resultado
            arregloNums[2] = 2; // decimal 1
            arregloNums[3] = 3; // decimal 2
            arregloNums[4] = 7; // decimal 3
            arregloNums[5] = 8; // decimal 4

            /*
            for(int i = 0; i < arregloNums.Length; i++)
            {
                MessageBox.Show(arregloNums[i].ToString());
            }*/

            IntPtr ptr = sumaNumerosVector(sb, "Hola :D", arregloNums);
            int arrayLength = Marshal.ReadInt32(ptr);

            //points to arr[1], which is first value
            IntPtr start = IntPtr.Add(ptr, 4);
            int[] result = new int[arrayLength];
            Marshal.Copy(start, result, 0, arrayLength);

        }

        private void PC2023_1_ComparaNumeros_Load(object sender, EventArgs e)
        {
            sb = new StringBuilder(100);
        }
    }
}
