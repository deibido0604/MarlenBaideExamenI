using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarlenBaideExamenI
{
    public partial class Ejercicio1 : Form
    {

        string stdDetalle = "{0,-10}{1,-20}";
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;

            double I = 200000;
            listBox.Items.Add(String.Format(stdDetalle, "Mes", "Intereses"));

            for (int i=1; i<=12; i++)
            {
                string nombreMes = formatoFecha.GetMonthName(i).ToUpper();

                
                listBox.Items.Add(String.Format(stdDetalle, nombreMes, I.ToString("0.##")));
                
                I = (I * 0.15) + I;
            }

            
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}
